Imports System.Data.SqlClient
Imports System.Data
Module Ap__module
    'Dim _ConnectionString As String = "server=XUANTHINH;database=QLBanHang03690;trusted_connection=false;uid=sa;pwd=123"
    Public _ConnectionString As String = "workstation id=QuanLyBanHang03690.mssql.somee.com;packet size=4096;user id=thinhlxps03690_SQLLogin_1;pwd=ycfs24epns;data source=QuanLyBanHang03690.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang03690" ' Kết nối đến Database
    Public Connect As SqlConnection = New SqlConnection(_ConnectionString)
    Public Dadapter As SqlDataAdapter ' Gửi các truy vấn đến Database

    ' Đọc dữ liệu từ bảng KHACHHANG
    Public Function LoadKH() As DataSet
        Dadapter = New SqlDataAdapter("select MaKhachHang as 'Mã Khách Hàng',TenKhachHang as 'Tên khách hàng',DiaChi as 'Địa chỉ',SDT as 'SĐT' from KhachHang", Connect)
        Dim db As New DataSet
        Connect.Open()
        Dadapter.Fill(db)
        Connect.Close()
        Return db
    End Function
End Module
