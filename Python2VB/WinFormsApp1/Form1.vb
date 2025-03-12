Imports System.IO

Public Class Form1
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim pythonExe As String = "E:\Work\python-vb\.venv\Scripts\python.exe"

        Dim scriptPath As String = "E:\Work\python-vb\work.py"

        Dim param1 As String = Mean1Box.Text
        Dim param2 As String = Varience1Box.Text
        Dim param3 As String = Mean2Box.Text
        Dim param4 As String = Varience2Box.Text

        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = pythonExe
        startInfo.Arguments = $" ""{scriptPath}"" {param1} {param2} {param3} {param4}"
        startInfo.RedirectStandardOutput = True
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = True

        Try
            Dim process As Process = Process.Start(startInfo)
            Dim output As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            If Not String.IsNullOrWhiteSpace(output) Then
                Dim imageBytes As Byte() = Convert.FromBase64String(output)
                Using ms As New MemoryStream(imageBytes)
                    Dim image As Image = Image.FromStream(ms)

                    OutputBox.Image = image
                End Using
            Else
                MessageBox.Show("No image data received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error running Python script: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
