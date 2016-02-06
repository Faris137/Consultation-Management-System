Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"

        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from login where user_name='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' and type='" & ComboBox1.Text & "'"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read Then
                MessageBox.Show("username and password are correct")
                If ComboBox1.Text = "Admin" Then
                    Me.Hide()
                    Admin.Show()
                ElseIf ComboBox1.Text = "Lecturer" Then
                    Me.Hide()
                    Lecturer.Show()
                Else
                    Me.Hide()
                    Student.Show()
                End If
            Else
                MessageBox.Show("Username and Password are Incorrect")
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
