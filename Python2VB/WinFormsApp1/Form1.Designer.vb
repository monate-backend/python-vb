<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Mean1Box = New TextBox()
        Varience1Box = New TextBox()
        Mean2Box = New TextBox()
        Varience2Box = New TextBox()
        OutputBox = New PictureBox()
        RunButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(OutputBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Mean1Box
        ' 
        Mean1Box.Location = New Point(61, 26)
        Mean1Box.Name = "Mean1Box"
        Mean1Box.Size = New Size(100, 23)
        Mean1Box.TabIndex = 0
        Mean1Box.Text = "1.0"
        ' 
        ' Varience1Box
        ' 
        Varience1Box.Location = New Point(241, 27)
        Varience1Box.Name = "Varience1Box"
        Varience1Box.Size = New Size(100, 23)
        Varience1Box.TabIndex = 1
        Varience1Box.Text = "0.25"
        ' 
        ' Mean2Box
        ' 
        Mean2Box.Location = New Point(61, 86)
        Mean2Box.Name = "Mean2Box"
        Mean2Box.Size = New Size(100, 23)
        Mean2Box.TabIndex = 2
        Mean2Box.Text = "3.0"
        ' 
        ' Varience2Box
        ' 
        Varience2Box.Location = New Point(241, 86)
        Varience2Box.Name = "Varience2Box"
        Varience2Box.Size = New Size(100, 23)
        Varience2Box.TabIndex = 3
        Varience2Box.Text = "0.5"
        ' 
        ' OutputBox
        ' 
        OutputBox.Location = New Point(12, 168)
        OutputBox.Name = "OutputBox"
        OutputBox.Size = New Size(329, 270)
        OutputBox.SizeMode = PictureBoxSizeMode.StretchImage
        OutputBox.TabIndex = 4
        OutputBox.TabStop = False
        ' 
        ' RunButton
        ' 
        RunButton.Location = New Point(136, 129)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(75, 23)
        RunButton.TabIndex = 5
        RunButton.Text = "Run"
        RunButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 6
        Label1.Text = "mean1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 7
        Label2.Text = "varience1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 8
        Label3.Text = "mean2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(178, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "varience2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(354, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RunButton)
        Controls.Add(OutputBox)
        Controls.Add(Varience2Box)
        Controls.Add(Mean2Box)
        Controls.Add(Varience1Box)
        Controls.Add(Mean1Box)
        Name = "Form1"
        Text = "Form1"
        CType(OutputBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Mean1Box As TextBox
    Friend WithEvents Varience1Box As TextBox
    Friend WithEvents Mean2Box As TextBox
    Friend WithEvents Varience2Box As TextBox
    Friend WithEvents OutputBox As PictureBox
    Friend WithEvents RunButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
