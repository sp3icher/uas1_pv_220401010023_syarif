Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Using MyReader As New FileIO.TextFieldParser("d:\test\data.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            MyReader.ReadFields()
            While Not MyReader.EndOfData
                Try
                    Dim currentRow As String() = MyReader.ReadFields()
                    For Each currentField In currentRow
                        MsgBox(currentField)
                    Next
                Catch ex As FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
End Class
