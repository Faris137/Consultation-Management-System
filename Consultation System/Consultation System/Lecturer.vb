Imports MySql.Data.MySqlClient
Public Class Lecturer

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Login.Show()
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            Dim stat As String
            stat = "Rejected"
            MysqlConn.Open()
            Dim query As String
            query = "update consultationdb.appointment set status='" & stat & "' where stu_name = '" & TextBox1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Session Rejected")
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
            Dim stat As String
            stat = "Accepted"
            MysqlConn.Open()
            Dim query As String
            query = "update consultationdb.appointment set status='" & stat & "' where stu_name = '" & TextBox1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Session Approved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            Dim MysqlConn As MySqlConnection
            Dim command As MySqlCommand
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"
            Dim reader As MySqlDataReader
            MysqlConn.Open()
            Dim query As String
            query = "Delete from consultationdb.appointment where stu_name = '" & TextBox1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader
            MessageBox.Show("Data Deleted")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
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
            query = " select * from consultationdb.appointment where lect_name = '" & Login.TextBox1.Text & "' "
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

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        post.Show()
    End Sub

    Private Sub Lecturer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MysqlConn As MySqlConnection
        Dim command As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root; database=consultationdb"



        Try
            Dim sda As New MySqlDataAdapter
            Dim dbdata As New DataTable
            Dim source As New BindingSource

            MysqlConn.Open()
            Dim query As String
            query = " select * from consultationdb.appointment where lect_name = '" & Login.TextBox1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdata)
            source.DataSource = dbdata
            DataGridView1.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try


        Try
            Dim sda As New MySqlDataAdapter
            Dim dbdata As New DataTable
            Dim source As New BindingSource
            Dim command1 As MySqlCommand

            MysqlConn.Open()
            Dim query As String
            query = " select * from consultationdb.post"
            command1 = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command1
            sda.Fill(dbdata)
            source.DataSource = dbdata
            DataGridView2.DataSource = source
            sda.Update(dbdata)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("stu_name").Value.ToString
            TextBox2.Text = row.Cells("lect_name").Value.ToString
            TextBox3.Text = row.Cells("Date").Value.ToString
            TextBox4.Text = row.Cells("time").Value.ToString

        End If
    End Sub
End Class