Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmTimKH
    Private Sub TimKiemKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKH.DataSource = LoadKH.Tables(0)
        cboMaKH.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btvXemall.Click
        dgvKH.DataSource = Nothing
        dgvKH.DataSource = LoadKH.Tables(0)
        cboMaKH.DataSource = Nothing
        txtTenKH.Text = ""
        txtDiachi.Text = ""
    End Sub
    Private Sub cboMaKH_Click(sender As Object, e As EventArgs) Handles cboMaKH.Click
        txtTenKH.Text = ""
        txtDiachi.Text = ""
        cboMaKH.DataSource = LoadKH.Tables(0)
        cboMaKH.DisplayMember = "Mã Khách Hàng"
    End Sub
    Private Sub cboMaKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaKH.SelectedIndexChanged
        cboMaKH.ValueMember = "Mã Khách Hàng"
        Dim Choose As String = cboMaKH.SelectedValue
        Try
            Connect.Open()
            Dim db As New DataTable
            Dadapter = New SqlDataAdapter _
                ("Exec spTimkhachhang @Ma_KH = '" & Choose & "'", Connect)
            db.Clear()
            Dadapter.Fill(db)
            dgvKH.DataSource = Nothing
            dgvKH.DataSource = db.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connect.Close()
        End Try
    End Sub
    Private Sub txtTenKH_Click(sender As Object, e As EventArgs) Handles txtTenKH.Click
        cboMaKH.DataSource = Nothing
    End Sub
    Private Sub txtTenKH_TextChanged(sender As Object, e As EventArgs) Handles txtTenKH.TextChanged
        Try
            Connect.Open()
            Dim db As New DataTable
            Dadapter = New SqlDataAdapter _
                ("Exec spTimkhachhang @Ten_KH = N'%" & txtTenKH.Text & "%', @Dia_chi = N'%" & txtDiachi.Text & "%'", Connect)
            db.Clear()
            Dadapter.Fill(db)
            dgvKH.DataSource = Nothing
            dgvKH.DataSource = db.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connect.Close()
        End Try
    End Sub
    Private Sub txtDiaChi_Click(sender As Object, e As EventArgs) Handles txtDiachi.Click
        cboMaKH.DataSource = Nothing
    End Sub
    Private Sub txtDiachi_TextChanged(sender As Object, e As EventArgs) Handles txtDiachi.TextChanged
        Try
            Connect.Open()
            Dim db As New DataTable
            Dadapter = New SqlDataAdapter _
                ("Exec spTimkhachhang @Ten_KH = N'%" & txtTenKH.Text & "%', @Dia_chi = N'%" & txtDiachi.Text & "%'", Connect)
            db.Clear()
            Dadapter.Fill(db)
            dgvKH.DataSource = Nothing
            dgvKH.DataSource = db.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connect.Close()
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class