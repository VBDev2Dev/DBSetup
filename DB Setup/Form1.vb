Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MyDb").ConnectionString)
            cn.Open()

            MessageBox.Show(cn.ConnectionString)

        End Using
    End Sub
End Class
