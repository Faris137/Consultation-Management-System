Imports MySql.Data.MySqlClient
Public Class request

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            Dim stat As String
            stat = "Pending"
            query = "insert into consultationdb.appointment (stu_name, lect_name, Date, time,status) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & stat & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Student.Show()
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
            query = " select * from consultationdb.appointment"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdata)
            source.DataSource = dbdata
            Student.DataGridView2.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class