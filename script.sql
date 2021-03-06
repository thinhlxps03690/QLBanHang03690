USE [QLBanHang03690]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[SoHoaDon] [nvarchar](50) NOT NULL,
	[MaSanPham] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [ChiTietHoaDon_pk] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHoaDon] [nvarchar](50) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TriGia] [money] NOT NULL,
	[MaNhanVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [HoaDon_pk] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[SDT] [int] NOT NULL,
	[MaAnhKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [KhachHang_pk] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](150) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[SDT] [int] NOT NULL,
 CONSTRAINT [NhanVien_pk] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [nvarchar](50) NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[MaAnhSanPham] [nvarchar](50) NULL,
 CONSTRAINT [SanPham_pk] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHoaDon] ([SoHoaDon], [MaSanPham], [SoLuong]) VALUES (N'HD01', N'SP01', 35)
INSERT [dbo].[ChiTietHoaDon] ([SoHoaDon], [MaSanPham], [SoLuong]) VALUES (N'HD02', N'SP02', 46)
INSERT [dbo].[ChiTietHoaDon] ([SoHoaDon], [MaSanPham], [SoLuong]) VALUES (N'HD03', N'SP03', 80)
INSERT [dbo].[ChiTietHoaDon] ([SoHoaDon], [MaSanPham], [SoLuong]) VALUES (N'HD04', N'SP04', 50)
INSERT [dbo].[ChiTietHoaDon] ([SoHoaDon], [MaSanPham], [SoLuong]) VALUES (N'HD05', N'SP05', 55)
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD01', CAST(N'2016-02-25 00:00:00.000' AS DateTime), N'KH01', 5000000.0000, N'NV01')
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD02', CAST(N'2016-05-14 00:00:00.000' AS DateTime), N'KH02', 200000000.0000, N'NV02')
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD03', CAST(N'2016-08-20 00:00:00.000' AS DateTime), N'KH03', 450000000.0000, N'NV03')
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD04', CAST(N'2016-04-22 00:00:00.000' AS DateTime), N'KH04', 650000000.0000, N'NV04')
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD05', CAST(N'2016-07-20 00:00:00.000' AS DateTime), N'KH05', 800000000.0000, N'NV05')
INSERT [dbo].[HoaDon] ([SoHoaDon], [Ngay], [MaKhachHang], [TriGia], [MaNhanVien]) VALUES (N'HD06', CAST(N'2016-08-23 00:00:00.000' AS DateTime), N'KH04', 99999999999.0000, N'NV05')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH01', N'Lưu Xuân Thịnh', N'Long An', 165445555, N'KH01.jpg')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH02', N'Nguyễn Thành Công', N'TPHCM', 926544882, N'KH02.jpg')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH03', N'Nguyễn Ngọc Thiên Nhân', N'Quảng Ngãi', 1663131115, N'KH03.jpg')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH04', N'Nguyễn Thanh Ngọc Thảo Nhi', N'Lâm Ðồng', 165445555, N'KH04.jpg')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH05', N'Trần Thanh Tuấn', N'Nha Trang', 1654848555, N'KH05.jpg')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [MaAnhKhachHang]) VALUES (N'KH06', N'aaaaaaaaa', N'aaaaaaaaaaa', 494954649, N'KH06.jpg')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV01', N'Hulk', 0, N'TPHCM', 923155124)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV02', N'Thor', 0, N'Đà Nẵng', 1215421563)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV03', N'Widows', 1, N'Vũng Tàu', 122151355)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV04', N'Captain', 0, N'Bình Định', 968645524)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV05', N'Torm', 1, N'TPHCM', 165454855)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP01', N'Máy sấy tóc Lady', 11, 300000.0000, N'SP01.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP02', N'Tủ lạnh LG', 23, 8000000.0000, N'SP02.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP03', N'Nồi cơm điện teamcook', 55, 500000.0000, N'SP03.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP04', N'Máy lạnh L', 66, 3400000.0000, N'SP04.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP05', N'Bếp ga Japan', 50, 6000000.0000, N'SP05.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuong], [DonGia], [MaAnhSanPham]) VALUES (N'SP07', N'Máy xay sinh tố', 5, 9000000.0000, N'SP07.jpg')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[HoaDon] ([SoHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HoaDon_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[spTimkhachhang]    Script Date: 6/22/2016 3:31:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[spTimkhachhang](
	@Ma_KH Varchar(6) = '',
	@Ten_KH Nvarchar(50) = '',
	@Dia_chi Nvarchar(50) = '')
As

Select MaKhachHang as 'Mã Khách Hàng' , TenKhachHang as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', SDT as 'SĐT'
From KhachHang 
Where	(MaKhachHang = @Ma_KH or @Ma_KH = '') and
		(TenKhachHang Like @Ten_KH or @Ten_KH = '') and
		(DiaChi Like @Dia_chi or @Dia_chi = '')
GO
