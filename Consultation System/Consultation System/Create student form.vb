Imports MySql.Data.MySqlClient
Public Class Create_student_form

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "insert into consultationdb.student (name, Faculty, Year, PhoneNumber, Address, Email) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
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
            query = " select * from consultationdb.student"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdata)
            source.DataSource = dbdata
            DataGridView1.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Create_student_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
            query = " select * from consultationdb.student"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdata)
            source.DataSource = dbdata
            DataGridView1.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class