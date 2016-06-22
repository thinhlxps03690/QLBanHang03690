Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLySanPham
    ' khai báo biến
    Dim noiluu As String = Application.StartupPath & "\hinh\"
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
    Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim masp As String
    Dim tensp As String
    Dim soluong As Integer
    Dim tenhinh As String
    Dim duongdan As String
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        reset() 'thực thi lệnh refresh
    End Sub
    Private Sub LoadData()
        'lệnh load data lên datagrid
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSanPham as 'Mã SP' ,TenSanPham as 'Tên Sản phẩm', SoLuong as 'Số lượng', DonGia as 'Đơn giá', Soluong * Dongia as 'Thành tiền', MaAnhSanPham as 'Mã Ảnh' from SanPham", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset() ' lệnh refresh
        txtDongia.Text = ""
        txtMaSP.Text = ""
        txtSoluong.Text = ""
        txtTenSP.Text = ""
        txttenanh.Text = ""
        txtMaSP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() 'thực hi lệnh load data lên datagrid
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' thông báo lỗi bỏ trống ô txt
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chưa Nhập mã sản phẩm")
            txtMaSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên sản phẩm")
            txtTenSP.Focus()
        ElseIf txtSoluong.Text = "" Then
            MessageBox.Show("Chưa Nhập Số lượng")
            txtSoluong.Focus()
        ElseIf txtDongia.Text = "" Then
            MessageBox.Show("Chưa Nhập Đơn giá")
            txtDongia.Focus()
        ElseIf txttenanh.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Ảnh")
            txttenanh.Focus()
        Else
            ' Lưu các giá trị trong ô txt vào datagrid
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SanPham values(@MASP,@TENSP,@SOLUONG,@DONGIA,@MAANH)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDongia.Text)
            save.Parameters.AddWithValue("@MAANH", txttenanh.Text)
            save.ExecuteNonQuery()
            'tiến hành chép file ảnh vào thư mục của ứng dụng
            Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                If System.IO.File.Exists(noiluu & txtMaSP.Text & ".jpg") Then
                    Kill(noiluu & txtMaSP.Text & ".jpg")
                    FileCopy(duongdan, noiluu & tenhinh & "1")
                    Rename(noiluu & tenhinh & "1", noiluu & txtMaSP.Text & ".jpg")
                Else
                    FileCopy(duongdan, noiluu & tenhinh & "1")
                    Rename(noiluu & tenhinh & "1", noiluu & txtMaSP.Text & ".jpg")
                End If
            Catch ex As Exception
            End Try
            conn.Close() 'đóng kết nối
            MessageBox.Show("Thêm thành công")
        End If
        'Sau khi thêm xong sẽ tự làm mới lại bảng
        conn.Open()
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select MaSanPham as 'Mã SP' ,TenSanPham as 'Tên Sản phẩm', SoLuong as 'Số lượng', DonGia as 'Đơn giá', Soluong * Dongia as 'Thành tiền', MaAnhSanPham as 'Mã Ảnh' from SanPham", conn)
        db.Clear()
        lammoi.Fill(db)
        Try
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' thông báo lỗi bỏ trống
        If txtMaSP.Text = "" Then
            MessageBox.Show("Nhập Mã Sản Phẩm cần xóa")
            txtMaSP.Focus()
            ' thực thi lệnh xóa,
        Else
            Dim delquery As String = "delete from SanPham where MaSanPham=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMaSP.Text) ' dk xóa
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        ' sửa
        If btnSua.Text = "Sửa" Then
            txtMaSP.ReadOnly = True
            btnSua.Text = "Update"
            txtTenSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SanPham set TenSanPham=@TENSP, SoLuong=@SOLUONG, DonGia=@DONGIA, MaAnhSanPham=@MAANH where MaSanPham=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDongia.Text)
            save.Parameters.AddWithValue("@MAANH", txttenanh.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' các giá trị click trong datagrid
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaSP.Text = DataGridView1.Item(0, click).Value
        txtTenSP.Text = DataGridView1.Item(1, click).Value
        txtSoluong.Text = DataGridView1.Item(2, click).Value
        txtDongia.Text = DataGridView1.Item(3, click).Value
        txttenanh.Text = DataGridView1.Item(5, click).Value
        Try
            ptbanh.BackgroundImage = Image.FromFile(Application.StartupPath & "\hinh\" & DataGridView1.Item(5, click).Value)
        Catch ex As Exception
            MessageBox.Show("File ảnh không trùng với database")
        End Try
    End Sub

    Private Sub btnchon_Click(sender As Object, e As EventArgs) Handles btnchon.Click
        ' mở file chọn ảnh
        Dim anh As New OpenFileDialog
        If anh.ShowDialog <> DialogResult.Cancel Then
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close() 'đóng
    End Sub
End Class