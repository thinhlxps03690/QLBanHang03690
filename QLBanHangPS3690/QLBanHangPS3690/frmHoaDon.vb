Imports System.Data.SqlClient

Public Class frmHoaDon
    'Các biến trong form
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
    'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim sohd As String
    Dim ngay As Date
    Dim makh As String
    Dim trigia As Integer
    Dim manv As String

    Private Sub LoadData()
        ' chuỗi upload HD
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SoHoaDon as 'Số Hóa Đơn',Ngay as 'Ngày',MaKhachHang as 'Mã Khách Hàng',TriGia as 'Trị Giá', MaNhanVien as 'Mã Nhân Viên' from HoaDon", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgay.Value = Today ' cập nhật ngày giờ hiện tại
        LoadData() ' load chuỗi HD
    End Sub
    Private Sub reset() ' làm mới các ô txt
        txtsohd.Text = ""
        dtpNgay.Text = ""
        txtmakh.Text = ""
        txttrigia.Text = ""
        txtmanv.Text = ""
        txtsohd.Focus()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reset() ' thực thi làm mới txt
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' báo lỗi bỏ trống ô txt
        If txtsohd.Text = "" Then
            MessageBox.Show("Chưa Nhập Số Hóa Đơn")
            txtsohd.Focus()
        ElseIf txtmakh.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Khách Hàng")
            txtmakh.Focus()
        ElseIf txttrigia.Text = "" Then
            MessageBox.Show("Chưa Nhập Trị Giá Đơn Hàng")
            txttrigia.Focus()
        ElseIf txtmanv.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Nhân Viên")
            txtmanv.Focus()
        Else
            ' Lưu các dữ liệu từ ô txt
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HoaDon values(@SoHoaDon,@Ngay,@MaKhachHang,@TriGia,@MaNhanVien)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SoHoaDon", txtsohd.Text)
            save.Parameters.AddWithValue("@Ngay", dtpNgay.Text)
            save.Parameters.AddWithValue("@MaKhachHang", txtmakh.Text)
            save.Parameters.AddWithValue("@TriGia", txttrigia.Text)
            save.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtsohd.Text = "" Then 'báo lỗi bỏ trống
            MessageBox.Show("Nhập Hóa Đơn Cần Xóa")
            txtmakh.Focus()
        Else
            Dim delquery As String = "delete from HoaDon where SoHoaDon=@sohd" 'lệnh xóa
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@sohd", txtsohd.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Click hiển thị từ datagrid lên ô txt
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtsohd.Text = DataGridView1.Item(0, click).Value
        dtpNgay.Text = DataGridView1.Item(1, click).Value
        txtmakh.Text = DataGridView1.Item(2, click).Value
        txttrigia.Text = DataGridView1.Item(3, click).Value
        txtmanv.Text = DataGridView1.Item(4, click).Value
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        ' Sửa hóa đơn
        If btnSua.Text = "Sửa" Then
            txtsohd.ReadOnly = True
            btnSua.Text = "Update"
            txtmanv.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update HoaDon set SoHoaDon=@SoHD, Ngay=@ngay, MaKhachHang=@makh, TriGia=@trigia, MaNhanVien=@MaNhanVien where SoHoaDon=@SoHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@SoHD", txtsohd.Text)
            save.Parameters.AddWithValue("@ngay", dtpNgay.Text)
            save.Parameters.AddWithValue("@makh", txtmakh.Text)
            save.Parameters.AddWithValue("@trigia", txttrigia.Text)
            save.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtmanv.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close() 'đóng
    End Sub
End Class