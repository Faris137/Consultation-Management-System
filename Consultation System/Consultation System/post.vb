Imports MySql.Data.MySqlClient
Public Class post

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Lecturer.Show()
        Dim MysqlConn As MySqlConnection
        Dim command As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim source As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = " select * from consultationdb.post"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdata)
            source.DataSource = dbdata
            Lecturer.DataGridView2.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "insert into consultationdb.post (post, time) values ('" & RichTextBox1.Text & "','" & DateTimePicker1.Text & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Announcement Broadcasted")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class