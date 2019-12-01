Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static rand As New Random
        Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MyDb").ConnectionString)
            cn.Open()

            MessageBox.Show(cn.ConnectionString)

            Using cmd As New SqlCommand("Insert into Numbers Values(@Num)", cn)
                cmd.Parameters.AddWithValue("@Num", CLng(rand.Next(0, Integer.MaxValue)))
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New SqlCommand("Select Count(*) from Numbers", cn)
                Dim count As Long = CLng(cmd.ExecuteScalar)
                MessageBox.Show($"There are {count} numbers in the table.")
            End Using
        End Using
    End Sub
End Class
