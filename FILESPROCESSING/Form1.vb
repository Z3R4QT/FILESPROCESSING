Imports System.CodeDom
Imports System.IO
Imports System.Linq.Expressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = "sample.txt"

            Using Writer As New StreamWriter(filePath, True) ' True to Append 
                Writer.WriteLine("Hello this is a test files!")
                Writer.WriteLine("Second line of text.")
            End Using

            Using Reader As New StreamReader(filePath)
                Dim content As String = Reader.ReadToEnd()
                Console.WriteLine("File Content:")
                Console.WriteLine(content)
            End Using

            MessageBox.Show("File written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error writing file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
