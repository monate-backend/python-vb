import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import lognorm

mean1 = 1.0
variance1 = 0.25
sigma1 = np.sqrt(np.log(variance1 / mean1 ** 2 + 1))
mu1 = np.log(mean1) - 0.5 * sigma1 ** 2

mean2 = 3.0
variance2 = 0.5
sigma2 = np.sqrt(np.log(variance2 / mean2 ** 2 + 1))
mu2 = np.log(mean2) - 0.5 * sigma2 ** 2

x = np.linspace(0, 10, 1000)

pdf1 = lognorm.pdf(x, s=sigma1, scale=np.exp(mu1))
pdf2 = lognorm.pdf(x, s=sigma2, scale=np.exp(mu2))

bimodal_pdf = 0.5 * pdf1 + 0.5 * pdf2

plt.figure(figsize=(10,6))
plt.plot(x, pdf1, label = "Log-normal Distribution 1")
plt.plot(x, pdf2, label='Log-normal Distribution 2')
plt.plot(x, bimodal_pdf, label='Bimodal Distribution', linestyle='--')
plt.xlabel('x')
plt.ylabel('Probability Density')
plt.title('Bimodal Probabilit Distribution')
plt.legend()
plt.grid(True)
plt.savefig('bimodal_distribution.png', dpi=300, bbox_inches='tight')
plt.show()
