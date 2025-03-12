import sys
import io
import base64
import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import lognorm

def work(mean1, variance1, mean2, variance2):
    sigma1 = np.sqrt(np.log(variance1 / mean1 ** 2 + 1))
    mu1 = np.log(mean1) - 0.5 * sigma1 ** 2

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
    
    buffer = io.BytesIO()
    plt.savefig(buffer, format="png", dpi=300, bbox_inches="tight")
    plt.close()
    buffer.seek(0)

    img_base64 = base64.b64encode(buffer.getvalue()).decode("utf-8")
    
    return img_base64 

if __name__ == "__main__":
    if len(sys.argv) < 5:
        print("Usage: python generate_image.py param1 param2 param3 param4")
        sys.exit(1)

    param1 = float(sys.argv[1])
    param2 = float(sys.argv[2])
    param3 = float(sys.argv[3])
    param4 = float(sys.argv[4])

    image_data = work(param1, param2, param3, param4)
    print(image_data)