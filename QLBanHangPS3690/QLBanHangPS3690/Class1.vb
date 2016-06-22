Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
        'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKhachHang as 'Mã KH',TenKhachHang as 'Tên Khách Hàng',DiaChi as 'Địa chỉ',SDT as 'SĐT' from KhachHang", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
        'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select MaSanPham as 'Mã sản phẩm',TenSanPham as 'Tên sản phẩm',SoLuong as 'Số lượng', DonGia as 'Đơn giá' from SanPham", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadhoadon() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690"
        'Dim chuoiketnoi As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadHD As New SqlDataAdapter("select SoHoaDon as 'Số Hóa Đơn',Ngay as 'Ngày',MaKhachHang as 'Mã Khách Hàng',TriGia as 'Trị Giá', MaNhanVien as 'Mã Nhân Viên' from HoaDon", conn)
        Dim db As New DataSet
        conn.Open()
        LoadHD.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
