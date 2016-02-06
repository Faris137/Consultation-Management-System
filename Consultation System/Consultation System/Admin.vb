Imports MySql.Data.MySqlClient
Public Class Admin

    Private Sub Admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
            query = " select * from consultationdb.Login"
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "insert into consultationdb.Login (user_name, password, type) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "update consultationdb.login set user_name='" & TextBox1.Text & "',password='" & TextBox2.Text & "' where password='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Updated")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "Delete from consultationdb.login where password = '" & TextBox2.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Deleted")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
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
            query = " select * from consultationdb.Login"
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

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("user_name").Value.ToString
            TextBox2.Text = row.Cells("password").Value.ToString
            ComboBox1.Text = row.Cells("type").Value.ToString
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Create_student_form.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        Create_lecturer_form.Show()
    End Sub
End Class