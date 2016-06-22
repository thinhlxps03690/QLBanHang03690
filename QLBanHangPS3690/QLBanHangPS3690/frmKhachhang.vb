Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmKhachhang
    ' biến trong from
    Dim noiluu As String = Application.StartupPath & "\hinh\"
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim makh As String
    Dim tenkh As String
    Dim diachi As String
    Dim sdt As Integer
    Dim tenhinh As String
    Dim duongdan As String
    Private Sub LoadData() 'hàm load dữ liệu
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKhachHang as 'Mã KH' ,TenKhachHang as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT', MaAnhKhachHang as 'Mã Ảnh Khách Hàng' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub frmKhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' load data
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close() ' đóng
    End Sub
    Private Sub reset() ' làm mới các ô txt
        txtMakh.Text = ""
        txtTenkhachhang.Text = ""
        txtDiachi.Text = ""
        txtSdt.Text = ""
        txttenanh.Text = ""
        txtMakh.Focus()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        reset() ' thực thi làm mới txt
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' báo lỗi bỏ trống ô txt
        If txtMakh.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã KH")
            txtMakh.Focus()
        ElseIf txtTenkhachhang.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên KH")
            txtTenkhachhang.Focus()
        ElseIf txtDiachi.Text = "" Then
            MessageBox.Show("Chưa Nhập Địa Chỉ")
            txtDiachi.Focus()
        ElseIf txtSdt.Text = "" Then
            MessageBox.Show("Chưa Nhập SĐT")
            txtSdt.Focus()
        ElseIf txttenanh.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Ảnh")
            txttenanh.Focus()
        Else
            ' Lưu các dữ liệu từ ô txt
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KhachHang values(@MAKH,@TENKH,@DIACHI,@SDT,@MAANH)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMakh.Text)
            save.Parameters.AddWithValue("@TENKH", txtTenkhachhang.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
            save.Parameters.AddWithValue("@SDT", txtSdt.Text)
            save.Parameters.AddWithValue("@MAANH", txttenanh.Text)
            save.ExecuteNonQuery()
            conn.Close() 'đóng kết nối
            MessageBox.Show("Thêm thành công")
            Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                If System.IO.File.Exists(noiluu & txtMakh.Text & ".jpg") Then
                    Kill(noiluu & txtMakh.Text & ".jpg")
                    FileCopy(duongdan, noiluu & tenhinh & "1")
                    Rename(noiluu & tenhinh & "1", noiluu & txtMakh.Text & ".jpg")
                Else
                    FileCopy(duongdan, noiluu & tenhinh & "1")
                    Rename(noiluu & tenhinh & "1", noiluu & txtMakh.Text & ".jpg")
                End If
            Catch ex As Exception
            End Try
            conn.Close() 'đóng kết nối
            MessageBox.Show("Thêm thành công")
        End If
        'Sau khi thêm xong sẽ tự làm mới lại bảng
        conn.Open()
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select MaKhachHang as 'Mã KH' ,TenKhachHang as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT', MaAnhKhachHang as 'Mã Ảnh Khách Hàng' from KhachHang", conn)
        db.Clear()
        lammoi.Fill(db)
        Try
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMakh.Text = "" Then 'báo lỗi bỏ trống
            MessageBox.Show("Nhập Mã Khách Hàng cần xóa")
            txtMakh.Focus()
        Else
            Dim delquery As String = "delete from KhachHang where MaKhachHang=@MAKH" 'lệnh xóa
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMakh.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        ' Sửa KH
        If btnSua.Text = "Sửa" Then
            txtMakh.ReadOnly = True
            btnSua.Text = "Update"
            txtTenkhachhang.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KhachHang set MaKhachHang=@MAKH, TenKhachHang=@TENKH, DiaChi=@DIACHI, SDT=@SDT, MaAnhKhachHang=@MaAnh where MaKhachHang=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMakh.Text)
            save.Parameters.AddWithValue("@TENKH", txtTenkhachhang.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
            save.Parameters.AddWithValue("@SDT", txtSdt.Text)
            save.Parameters.AddWithValue("@MaAnh", txttenanh.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMakh.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Click hiển thị từ datagrid lên ô txt
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMakh.Text = DataGridView1.Item(0, click).Value
        txtTenkhachhang.Text = DataGridView1.Item(1, click).Value
        txtDiachi.Text = DataGridView1.Item(2, click).Value
        txtSdt.Text = DataGridView1.Item(3, click).Value
        txttenanh.Text = DataGridView1.Item(4, click).Value
        Try
            ptbanh.BackgroundImage = Image.FromFile(Application.StartupPath & "\hinh\" & DataGridView1.Item(4, click).Value)
        Catch ex As Exception
            MessageBox.Show("File ảnh không trùng với database")
        End Try
    End Sub

    Private Sub btnchon_Click(sender As Object, e As EventArgs) Handles btnchon.Click
        ' btn chọn ảnh
        Dim anh As New OpenFileDialog
        If anh.ShowDialog <> DialogResult.Cancel Then 'show tab chọn ảnh
            duongdan = anh.FileName
            If Not duongdan.EndsWith(".jpg") Then
                MessageBox.Show("Lỗi ảnh", "lỗi", MessageBoxButtons.OK)
            Else
                ptbanh.BackgroundImage = Image.FromFile(duongdan)
            End If
        End If
        tenhinh = anh.FileName.Substring(anh.FileName.LastIndexOf("\") + 1) 'lấy tên hình
        txttenanh.Text = tenhinh
    End Sub
End Class