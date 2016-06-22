Imports System.Data.SqlClient

Public Class frmTimkimsanpham
    ' biến trong from
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim fs As System.IO.FileStream
    Dim image As Image
    Dim masp As String
    Dim tensp As String
    Dim soluong As Integer
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        DataGridView1.DataSource = hienthi.Loadsanpham.Tables(0)
        ' xuat du lieu tu class
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        ' tìm kiếm Masp
        conn.Open()
        Dim timkiemmasp As SqlDataAdapter = New SqlDataAdapter("select MaSanPham as 'Mã sản phẩm',TenSanPham as 'Tên sản phẩm',SoLuong as 'Số lượng',DonGia as 'Đơn giá' from SanPham  where MaSanPham ='" & txtMaSP.Text & "' ", conn)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                DataGridView1.DataSource = Nothing
                timkiemmasp.Fill(db)
                If db.Rows.Count > 0 Then
                    DataGridView1.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Điền đúng mã sản phẩm")
                    txtMaSP.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close() 'đóng
    End Sub
    Private Sub btntimtensp_Click(sender As Object, e As EventArgs) Handles btntimtensp.Click
        ' tìm kiếm theo tensp
        conn.Open()
        Dim timkiemtensp As SqlDataAdapter = New SqlDataAdapter("SELECT MaSanPham as 'Mã sản phẩm',TenSanPham as 'Tên sản phẩm',SoLuong as 'Số lượng',DonGia as'Đơn giá' FROM SanPham where TenSanPham like '%" & txttensp.Text & "%'", conn)
        Try
            If txttensp.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                DataGridView1.DataSource = Nothing
                timkiemtensp.Fill(db)
                If db.Rows.Count > 0 Then
                    DataGridView1.DataSource = db.DefaultView
                    txttensp.Text = Nothing
                Else
                    MessageBox.Show("Không thấy sản phẩm ")
                    txttensp.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class