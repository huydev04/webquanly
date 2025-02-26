USE [WebData]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[id_baoCao] [varchar](50) NOT NULL,
	[tieuDeBaoCao] [nvarchar](max) NULL,
	[id_loaiBaoCao] [varchar](50) NULL,
	[noiDungBaoCao] [text] NULL,
	[ngayBaoCao] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_baoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[id_chucVu] [varchar](50) NOT NULL,
	[tenChucVu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_chucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[id_donHang] [varchar](50) NOT NULL,
	[ngayTaoDonHang] [datetime2](7) NULL,
	[diaChiNhanHang] [nvarchar](max) NULL,
	[dsSanPham] [nvarchar](max) NULL,
	[chietkhau] [int] NULL,
	[thanhTien] [decimal](18, 0) NULL,
	[id_PTTT] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_donHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[id_gioHang] [varchar](50) NOT NULL,
	[id_KH] [varchar](40) NULL,
	[dsSanPham] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_gioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id_KH] [varchar](50) NOT NULL,
	[hoTenKH] [nvarchar](100) NULL,
	[ngaySinh] [date] NULL,
	[diaChi] [nvarchar](max) NULL,
	[email] [varchar](100) NULL,
	[std] [varchar](10) NULL,
	[giayPhep] [varchar](100) NULL,
	[tichDiem] [decimal](18, 0) NULL,
	[matKhau] [varchar](100) NULL,
	[loaiKH] [nvarchar](100) NULL,
	[id_gioHang] [varchar](50) NULL,
	[id_donHang] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBaoCao]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBaoCao](
	[id_loaiBaoCao] [varchar](50) NOT NULL,
	[tenLoaiBaoCao] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_loaiBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[id_nhaCungCap] [varchar](50) NOT NULL,
	[tenNhaCungCap] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id_NV] [varchar](50) NOT NULL,
	[hoTenNV] [nvarchar](300) NULL,
	[email] [varchar](100) NULL,
	[sdt] [varchar](10) NULL,
	[diaChi] [text] NULL,
	[matKhau] [varchar](100) NULL,
	[id_chucVu] [varchar](50) NULL,
	[id_PNH] [varchar](50) NULL,
	[id_PXH] [varchar](50) NULL,
	[id_baoCao] [varchar](50) NULL,
	[id_thongBao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomThuoc]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomThuoc](
	[id_nhomThuoc] [varchar](50) NOT NULL,
	[tenNhomThuoc] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhomThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[id_PNH] [varchar](50) NOT NULL,
	[id_nhaCungCap] [varchar](50) NULL,
	[ngayNhapHang] [datetime2](7) NULL,
	[dsSanPham] [nvarchar](max) NULL,
	[ghiChu] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_PNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[id_PXH] [varchar](50) NOT NULL,
	[ngayXuatHang] [datetime2](7) NULL,
	[ghiChu] [text] NULL,
	[id_donHang] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_PXH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PTTT]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PTTT](
	[id_PTTT] [varchar](50) NOT NULL,
	[tenLoaiPT] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_PTTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id_sanPham] [varchar](50) NOT NULL,
	[tenSanPham] [nvarchar](max) NULL,
	[thanhPhan] [nvarchar](max) NULL,
	[hinhDang] [nvarchar](100) NULL,
	[hamLuong] [int] NULL,
	[donVi] [varchar](30) NULL,
	[nuocSX] [nvarchar](100) NULL,
	[hanSuDung] [date] NULL,
	[gia] [decimal](18, 0) NULL,
	[hinhAnhThuoc] [nvarchar](max) NULL,
	[soLuongTonKho] [int] NULL,
	[id_nhomThuoc] [varchar](50) NULL,
	[id_nhaCungCap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 17-May-24 1:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[id_thongBao] [varchar](50) NOT NULL,
	[tieuDeThongBao] [nvarchar](max) NULL,
	[noiDungThongBao] [text] NULL,
	[phanAnh] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_thongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425103116_init1', N'8.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425130948_init2', N'8.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425163206_init1', N'8.0.4')
GO
INSERT [dbo].[ChucVu] ([id_chucVu], [tenChucVu]) VALUES (N'nh', N'Nhân viên nhập hàng')
INSERT [dbo].[ChucVu] ([id_chucVu], [tenChucVu]) VALUES (N'ql', N'Nhân viên quản lý')
INSERT [dbo].[ChucVu] ([id_chucVu], [tenChucVu]) VALUES (N'xh', N'Nhân viên xuất hàng')
GO
INSERT [dbo].[DonHang] ([id_donHang], [ngayTaoDonHang], [diaChiNhanHang], [dsSanPham], [chietkhau], [thanhTien], [id_PTTT]) VALUES (N'4IQNHG', CAST(N'2024-05-17T13:44:08.3773789' AS DateTime2), N'Bình định', N'../Admin/StoreData/4IQNHG.json', NULL, CAST(69 AS Decimal(18, 0)), N'momo')
GO
INSERT [dbo].[GioHang] ([id_gioHang], [id_KH], [dsSanPham]) VALUES (N'4IQNHG', N'4IQNHG', N'~Admin/StoreData/4IQNHG.json')
INSERT [dbo].[GioHang] ([id_gioHang], [id_KH], [dsSanPham]) VALUES (N'7P6YVW', NULL, NULL)
INSERT [dbo].[GioHang] ([id_gioHang], [id_KH], [dsSanPham]) VALUES (N'8', NULL, NULL)
INSERT [dbo].[GioHang] ([id_gioHang], [id_KH], [dsSanPham]) VALUES (N'Le Van Huy0354502789', N'Le Van Huy0354502789', N'StoreData/Le Van Huy0354502789.json')
INSERT [dbo].[GioHang] ([id_gioHang], [id_KH], [dsSanPham]) VALUES (N'Nguyen Gia Ân0123456789', N'Nguyen Gia Ân0123456789', N'~Admin/StoreData/Nguyen Gia Ân0123456789.json')
GO
INSERT [dbo].[KhachHang] ([id_KH], [hoTenKH], [ngaySinh], [diaChi], [email], [std], [giayPhep], [tichDiem], [matKhau], [loaiKH], [id_gioHang], [id_donHang]) VALUES (N'4IQNHG', N'Thái Văn Hiệp', CAST(N'2002-01-15' AS Date), N'Bình định', N'hiep@gmail.com', N'0354502789', NULL, NULL, N'12425823', NULL, N'4IQNHG', N'4IQNHG')
INSERT [dbo].[KhachHang] ([id_KH], [hoTenKH], [ngaySinh], [diaChi], [email], [std], [giayPhep], [tichDiem], [matKhau], [loaiKH], [id_gioHang], [id_donHang]) VALUES (N'7P6YVW', N'Lê Văn Huy', CAST(N'2024-05-03' AS Date), N'Lê hồng phong - phú hoà - thủ dầu một - bình dương', N'127@gmail.com', N'0354502789', NULL, NULL, N'huyvanle', NULL, N'7P6YVW', NULL)
INSERT [dbo].[KhachHang] ([id_KH], [hoTenKH], [ngaySinh], [diaChi], [email], [std], [giayPhep], [tichDiem], [matKhau], [loaiKH], [id_gioHang], [id_donHang]) VALUES (N'Le Van Huy0354502789', N'Le Van Huy', CAST(N'2002-03-15' AS Date), N'Lê hồng phong - phú hoà - thủ dầu một - bình dương', N'huydev4@gmail.com', N'0354502789', NULL, NULL, N'Huy2002', NULL, N'Le Van Huy0354502789', NULL)
INSERT [dbo].[KhachHang] ([id_KH], [hoTenKH], [ngaySinh], [diaChi], [email], [std], [giayPhep], [tichDiem], [matKhau], [loaiKH], [id_gioHang], [id_donHang]) VALUES (N'Nguyen Gia Ân0123456789', N'Nguyen Gia Ân', CAST(N'2024-05-09' AS Date), N'Lê hồng phong - phú hoà - thủ dầu một - bình dương', N'andeptroai@gmail.com', N'0123456789', NULL, NULL, N'giaAn2002', NULL, NULL, NULL)
GO
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'bidiphar', N'Bidiphar ')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'bidoharma', N' Bidopharma USA')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'dhg', N'Công ty Dược Hậu Giang')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'domesco', N'Domesco ')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'glomed', N'Dược phẩm Glomed')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'gr', N'Gedeon Richter')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'imexpharm', N'Công ty dược Imexpharm ')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'mekophar', N'Công ty Hóa - Dược phẩm Mekophar')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'olic', N'OLIC (Thailand) Limited')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'organon', N'N.V Organon')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'rowa', N'Rowa Pharmaceuticals Limited')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'sanofi', N'Sanofi (Pháp)')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'stada', N'Stada')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'stella', N'Stellapharm ')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'traphaco', N'Traphaco ')
INSERT [dbo].[NhaCungCap] ([id_nhaCungCap], [tenNhaCungCap]) VALUES (N'vidipha', N'Dược Phẩm Trung Ương Vidipha')
GO
INSERT [dbo].[NhanVien] ([id_NV], [hoTenNV], [email], [sdt], [diaChi], [matKhau], [id_chucVu], [id_PNH], [id_PXH], [id_baoCao], [id_thongBao]) VALUES (N'nvnh01', N'Đặng Minh Hiếu', N'hieu@gmail.com', NULL, NULL, N'123456', N'nh', NULL, NULL, NULL, NULL)
INSERT [dbo].[NhanVien] ([id_NV], [hoTenNV], [email], [sdt], [diaChi], [matKhau], [id_chucVu], [id_PNH], [id_PXH], [id_baoCao], [id_thongBao]) VALUES (N'nvql01', N'Lê Văn Huy', N'huy@gmail.com', N'0354502789', N'Bình Duong', N'123456', N'ql', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'CN', N'Vật dụng sinh hoạt cá nhân')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'CTTHMNCM', N'Nhóm thuốc cải thiện tuần hoàn máu não, chóng mặt')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'DDN', N'Nhóm dùng ngoài ')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'DTCBVG', N'Nhóm điều trị các bệnh về gan')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'DTRLH', N'Nhóm điều trị rối loạn lipid huyết')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'DTSST', N'Nhóm điều trị bệnh sỏi thận')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'GDHS', N'Nhóm thuốc giảm đau, hạ sốt ')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'HATM', N'Nhóm huyết áp tim mạch')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'KSN', N'Nhóm thuốc kháng sinh')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'KV', N'Nhóm kháng viêm ')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'KVV', N'Nhóm kháng virus')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TDD', N'Nhóm thuốc dạ dày')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'THLD', N'Nhóm thuốc ho và long đờm')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TKN', N'Kháng nhóm kháng nấm nấm')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TNM', N'Nhóm thuốc nhỏ mắt')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TPCN', N'Nhóm thực phẩm chức năng')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TRLKN', N'Nhóm trị rối loạn kinh nguyệt')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TTH', N'Nhóm thuốc tiêu hóa')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'TTT', N'Thuốc tránh thai')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'VTYT', N'Nhóm vật tư y tế')
INSERT [dbo].[NhomThuoc] ([id_nhomThuoc], [tenNhomThuoc]) VALUES (N'XG', N'Nhóm xổ giun')
GO
INSERT [dbo].[PTTT] ([id_PTTT], [tenLoaiPT]) VALUES (N'bank', N'Thanh toán qua ngân hàng')
INSERT [dbo].[PTTT] ([id_PTTT], [tenLoaiPT]) VALUES (N'momo', N'Thanh toán qua MoMo')
INSERT [dbo].[PTTT] ([id_PTTT], [tenLoaiPT]) VALUES (N'tm', N'Thanh toán bằng tiền mặt khi nhận hàng')
GO
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'A9D4O', N'Marvelon thuốc tránh thai hằng ngày (1 vỉ x 21 viên)', N'', N'', NULL, N'', N'Hà Lan', CAST(N'2024-05-01' AS Date), CAST(69 AS Decimal(18, 0)), N'Marvelon thuốc tránh thai hằng ngày (1 vỉ x 21 viên).jpg', 1000, N'TTT', N'organon')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'B4E5B', N'Omeprazol DHG 20mg trị trào ngược dạ dày, thực quản (3 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2026-08-21' AS Date), CAST(100 AS Decimal(18, 0)), N'Omeprazol DHG 20mg trị trào ngược dạ dày, thực quản (3 vỉ x 10 viên).jpg', 1000, N'TDD', N'dhg')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'C4D2W', N'Claminat IMP 625 trị nhiễm khuẩn (2 vỉ x 7 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2024-11-16' AS Date), CAST(90 AS Decimal(18, 0)), N'Claminat IMP 625 trị nhiễm khuẩn (2 vỉ x 7 viên).jpg', 1000, N'KSN', N'imexpharm')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'D0Z0C', N'Atorvastatin Domesco 20mg trị tăng cholesterol máu (2 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2024-01-22' AS Date), CAST(96 AS Decimal(18, 0)), N'Atorvastatin Domesco 20mg trị tăng cholesterol máu (2 vỉ x 10 viên).jpg', 1000, N'DTRLH', N'domesco')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'D8O8Y', N'Beatil 4mg_5mg trị tăng huyết áp, mạch vành (3 vỉ x 10 viên)', N'', N'', NULL, N'', N'Hungary', CAST(N'2024-04-08' AS Date), CAST(310 AS Decimal(18, 0)), N'Beatil 4mg_5mg trị tăng huyết áp, mạch vành (3 vỉ x 10 viên).jpg', 1000, N'HATM', N'gr')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'E2O7Y', N'Dung dịch nhỏ mắt, tai Ciprofloxacin 0.3% Bidiphar trị nhiễm khuẩn mắt, tai lọ 5ml', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2027-10-05' AS Date), CAST(10 AS Decimal(18, 0)), N'Dung dịch nhỏ mắt, tai Ciprofloxacin 0.3% Bidiphar trị nhiễm khuẩn mắt, tai lọ 5ml.jpg', 1000, N'TNM', N'bidiphar')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'E6E5Q', N'Viên nhai Fugacar vị sô cô la 500mg trị giun đường ruột (1 vỉ x 1 viên)', N'', N'', NULL, N'', N'Thái Lan', CAST(N'2024-04-17' AS Date), CAST(180 AS Decimal(18, 0)), N'Viên nhai Fugacar vị sô cô la 500mg trị giun đường ruột (1 vỉ x 1 viên).jpg', 1000, N'XG', N'olic')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'G9G7N', N'Alpha Chymotrypsine Choay 21µkatals trị phù nề sau chấn thương (2 vỉ x 15 viên)', N'', N'', NULL, N'', N'Pháp', CAST(N'2027-10-31' AS Date), CAST(77 AS Decimal(18, 0)), N'Alpha Chymotrypsine Choay 21µkatals trị phù nề sau chấn thương (2 vỉ x 15 viên).jpg', 1000, N'KV', N'sanofi')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'I2D7D', N'Ibumed 400 giảm đau, hạ sốt, kháng viêm (10 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2024-05-10' AS Date), CAST(50 AS Decimal(18, 0)), N'Ibumed 400 giảm đau, hạ sốt, kháng viêm (10 vỉ x 10 viên).jpg', 1000, N'GDHS', N'glomed')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'I3O7L', N'Ciclevir 800 thuốc trị và phòng virus Herpes simplex (10 vỉ x 5 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2025-02-02' AS Date), CAST(70 AS Decimal(18, 0)), N'Ciclevir 800 thuốc trị và phòng virus Herpes simplex (10 vỉ x 5 viên).jpg', 1000, N'KVV', N'glomed')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'I9S5P', N'Piracetam Stada 800mg trị chóng mặt, giật rung cơ (3 vỉ x 15 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2025-05-06' AS Date), CAST(20 AS Decimal(18, 0)), N'Piracetam Stada 800mg trị chóng mặt, giật rung cơ (3 vỉ x 15 viên).jpg', 1000, N'CTTHMNCM', N'stada')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'N0N4V', N'Cồn 70 độ Bidophar chai 1000ml', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2025-08-05' AS Date), CAST(40 AS Decimal(18, 0)), N'Cồn 70 độ Bidophar chai 1000ml.jpg', 1000, N'VTYT', N'bidoharma')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'O0S3X', N'Orgametril 5mg trị đa kinh, rong kinh (1 vỉ x 30 viên)', N'', N'', NULL, N'', N'Hà Lan', CAST(N'2026-12-21' AS Date), CAST(75 AS Decimal(18, 0)), N'Orgametril 5mg trị đa kinh, rong kinh (1 vỉ x 30 viên).jpg', 1000, N'TRLKN', N'organon')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'R1M1N', N'Clarithromycin Stella 500mg trị nhiễm khuẩn (4 vỉ x 7 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2027-12-31' AS Date), CAST(154 AS Decimal(18, 0)), N'Clarithromycin Stella 500mg trị nhiễm khuẩn (4 vỉ x 7 viên).jpg', 1000, N'DDN', N'stella')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'R4W3U', N'Rowatinex phòng và trị sỏi niệu, sỏi thận (10 vỉ x 10 viên)', N'', N'', NULL, N'', N'Ireland', CAST(N'2024-02-24' AS Date), CAST(38 AS Decimal(18, 0)), N'Rowatinex phòng và trị sỏi niệu, sỏi thận (10 vỉ x 10 viên).jpg', 1000, N'DTSST', N'rowa')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'R8J6B', N'Griseofulvin Mekophar 500mg trị nấm da, tóc và móng (2 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2026-07-08' AS Date), CAST(75 AS Decimal(18, 0)), N'Griseofulvin Mekophar 500mg trị nấm da, tóc và móng (2 vỉ x 10 viên).jpg', 1000, N'TKN', N'mekophar')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'S4S2R', N'Pharmaton Energy bổ sung năng lượng chai 30 viên', N'', N'', NULL, N'', N'Đức', CAST(N'2025-09-10' AS Date), CAST(371 AS Decimal(18, 0)), N'Pharmaton Energy bổ sung năng lượng chai 30 viên.jpg', 1000, N'TPCN', N'sanofi')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'U6L5C', N'Hapacol Blue 500mg giảm đau, hạ sốt (10 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2024-07-01' AS Date), CAST(115 AS Decimal(18, 0)), N'Hapacol Blue 500mg giảm đau, hạ sốt (10 vỉ x 10 viên).jpg', 1000, N'GDHS', N'dhg')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'V0C9O', N'Penicilin V Kali Vidiphar điều trị nhiễm khuẩn đường hô hấp trên (100 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2026-03-09' AS Date), CAST(206 AS Decimal(18, 0)), N'Penicilin V Kali Vidiphar điều trị nhiễm khuẩn đường hô hấp trên (100 viên).jpg', 1000, N'KSN', N'vidipha')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'V7Z6U', N'Aspirin pH8 500mg giảm đau, kháng viêm, hạ sốt (20 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2027-05-18' AS Date), CAST(21 AS Decimal(18, 0)), N'Aspirin pH8 500mg giảm đau, kháng viêm, hạ sốt (20 vỉ x 10 viên).jpg', 1000, N'GDHS', N'mekophar')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'W8N3Y', N'Hỗn dịch uống Enterogermina 4 tỷ_5ml trị, phòng ngừa rối loạn tiêu hóa (20 ống x 5ml)', N'', N'', NULL, N'', N'Pháp', CAST(N'2025-10-15' AS Date), CAST(115 AS Decimal(18, 0)), N'Hỗn dịch uống Enterogermina 4 tỷ_5ml trị, phòng ngừa rối loạn tiêu hóa (20 ống x 5ml).jpg', 1000, N'TTH', N'sanofi')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'X2X7Y', N'Acetylcysteine Mekophar 200mg tan đàm trong bệnh lý hô hấp (10 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2027-06-25' AS Date), CAST(290 AS Decimal(18, 0)), N'Acetylcysteine Mekophar 200mg tan đàm trong bệnh lý hô hấp (10 vỉ x 10 viên).jpg', 1000, N'THLD', N'mekophar')
INSERT [dbo].[SanPham] ([id_sanPham], [tenSanPham], [thanhPhan], [hinhDang], [hamLuong], [donVi], [nuocSX], [hanSuDung], [gia], [hinhAnhThuoc], [soLuongTonKho], [id_nhomThuoc], [id_nhaCungCap]) VALUES (N'Z8J4Q', N'Boganic Forte hỗ trợ trị bệnh lý gan mật, mỡ máu (5 vỉ x 10 viên)', N'', N'', NULL, N'', N'Việt Nam', CAST(N'2024-08-08' AS Date), CAST(55 AS Decimal(18, 0)), N'Boganic Forte hỗ trợ trị bệnh lý gan mật, mỡ máu (5 vỉ x 10 viên).jpg', 1000, N'DTCBVG', N'traphaco')
GO
ALTER TABLE [dbo].[BaoCao] ADD  DEFAULT (getdate()) FOR [ngayBaoCao]
GO
ALTER TABLE [dbo].[DonHang] ADD  DEFAULT (getdate()) FOR [ngayTaoDonHang]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [ngayNhapHang]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  DEFAULT (getdate()) FOR [ngayXuatHang]
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([id_loaiBaoCao])
REFERENCES [dbo].[LoaiBaoCao] ([id_loaiBaoCao])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([id_PTTT])
REFERENCES [dbo].[PTTT] ([id_PTTT])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([id_donHang])
REFERENCES [dbo].[DonHang] ([id_donHang])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([id_gioHang])
REFERENCES [dbo].[GioHang] ([id_gioHang])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([id_baoCao])
REFERENCES [dbo].[BaoCao] ([id_baoCao])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([id_chucVu])
REFERENCES [dbo].[ChucVu] ([id_chucVu])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([id_PNH])
REFERENCES [dbo].[PhieuNhap] ([id_PNH])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([id_PXH])
REFERENCES [dbo].[PhieuXuat] ([id_PXH])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([id_thongBao])
REFERENCES [dbo].[ThongBao] ([id_thongBao])
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD FOREIGN KEY([id_donHang])
REFERENCES [dbo].[DonHang] ([id_donHang])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([id_nhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([id_nhaCungCap])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([id_nhomThuoc])
REFERENCES [dbo].[NhomThuoc] ([id_nhomThuoc])
GO
