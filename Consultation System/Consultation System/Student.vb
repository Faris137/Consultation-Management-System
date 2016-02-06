Imports MySql.Data.MySqlClient
Public Class Student

    Private Sub Student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
            query = " select * from consultationdb.post"
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
            query = " select * from consultationdb.appointment"
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        request.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class