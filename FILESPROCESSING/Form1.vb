Imports System.CodeDom
Imports System.IO
Imports System.Linq.Expressions

Public Class Form1
    Dim filePath As String = "sample.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using Writer As New StreamWriter(filePath, True) ' True to Append 
                Writer.WriteLine("Hello this is a test files!")
                Writer.WriteLine("Second line of text.")
            End Using

            MessageBox.Show("File written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error writing file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Using reader As New StreamReader(filePath) ' Commit
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show(content, "File Content: ")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While

        End Using
    End Sub
End Class

