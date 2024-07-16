USE [ves24771_dongthanh]
GO
/****** Object:  Table [dbo].[chamsockhachhang]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chamsockhachhang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ngay] [datetime] NULL,
	[makh] [bigint] NULL,
	[noidung] [nvarchar](500) NULL,
	[username] [nvarchar](20) NULL,
 CONSTRAINT [PK_chamsockhachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coquandonvi]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coquandonvi](
	[ma] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NULL,
	[diachi] [nvarchar](250) NULL,
	[dienthoai] [nvarchar](20) NULL,
	[mst] [nvarchar](20) NULL,
	[nganhang] [nvarchar](20) NULL,
	[nganhangten] [nvarchar](200) NULL,
 CONSTRAINT [PK_coquandonvi] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cungcapdichvu]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cungcapdichvu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ngay] [datetime] NULL,
	[sohopdong] [int] NULL,
	[noidung] [nvarchar](500) NULL,
	[nhomdichvu] [nvarchar](2) NULL,
	[makh] [bigint] NULL,
	[tenkh] [nvarchar](250) NULL,
	[diachi] [nvarchar](250) NULL,
	[sotien] [float] NULL,
	[covat] [bit] NULL,
	[vat] [float] NULL,
	[sotientiensauvat] [float] NULL,
	[sotienvon] [float] NULL,
	[loinhuan] [float] NULL,
	[phutrach] [nvarchar](20) NULL,
	[username] [nvarchar](20) NULL,
	[ketthuc] [bit] NULL,
	[kethucngay] [datetime] NULL,
 CONSTRAINT [PK_cungcapdichvu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dsform]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsform](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tenform] [nvarchar](50) NULL,
	[nhom] [nvarchar](50) NULL,
	[tiengviet] [nvarchar](250) NULL,
 CONSTRAINT [PK_dsform] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ma] [nvarchar](20) NULL,
	[ten] [nvarchar](250) NULL,
	[chucvu] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](20) NULL,
	[diachi] [nvarchar](250) NULL,
	[email] [nvarchar](50) NULL,
	[facebook] [nvarchar](150) NULL,
	[donvi] [bigint] NULL,
	[tendonvi] [nvarchar](250) NULL,
	[congtacvien] [bit] NULL,
	[nhacungcap] [bit] NULL,
	[tiemnang] [bit] NULL,
	[ngaycuoi] [datetime] NULL,
	[username] [nvarchar](20) NULL,
	[tinh] [nvarchar](3) NULL,
	[sinhnhat] [datetime] NULL,
	[sinhnhatco] [bit] NULL,
	[kyniem] [datetime] NULL,
	[kyniemco] [bit] NULL,
	[tuongtacuoi] [datetime] NULL,
	[ghichu] [nvarchar](550) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kyniem]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kyniem](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[maidkh] [bigint] NULL,
	[ngay] [datetime] NULL,
	[noidung] [nvarchar](150) NULL,
	[username] [nvarchar](20) NULL,
 CONSTRAINT [PK_kyniem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](250) NULL,
	[pass] [nvarchar](250) NULL,
	[nhomquyen] [int] NULL,
	[ok] [bit] NULL,
	[bophan] [nvarchar](2) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomdichvu]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomdichvu](
	[ma] [nvarchar](2) NOT NULL,
	[ten] [nvarchar](150) NULL,
 CONSTRAINT [PK_nhomdichvu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomquyen]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomquyen](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](150) NULL,
	[cap] [int] NULL,
 CONSTRAINT [PK_nhomquyen] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phanquyen]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phanquyen](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[quyen] [nvarchar](10) NULL,
	[form] [nvarchar](50) NULL,
	[chophep] [bit] NULL,
	[xoa] [bit] NULL,
	[xoangay] [int] NULL,
	[sua] [bit] NULL,
	[suangay] [int] NULL,
	[them] [bit] NULL,
	[themngay] [int] NULL,
 CONSTRAINT [PK_phanquyen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phongban]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongban](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](150) NULL,
	[macaptruong] [nvarchar](20) NULL,
	[tencaptruong] [nvarchar](150) NULL,
	[cap] [int] NULL,
 CONSTRAINT [PK_phongban] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinh]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinh](
	[ma] [nvarchar](4) NOT NULL,
	[ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_tinh] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[version]    Script Date: 09/07/2024 2:06:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[version](
	[ngay] [smalldatetime] NOT NULL,
	[noidung] [ntext] NULL,
	[username] [nvarchar](10) NULL,
	[batbuot] [bit] NULL,
 CONSTRAINT [PK_version] PRIMARY KEY CLUSTERED 
(
	[ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[coquandonvi] ON 

INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (1, N'Chi cục Phát triển nông thôn', N'', N'', N'', NULL, NULL)
INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (2, N'Phòng Kinh tế Mỏ Cày ', N'', N'', N'', NULL, NULL)
INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (3, N'Trung tâm Xúc tiến Đầu tư và Khởi nghiệp tỉnh Bến Tre', N'', N'', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[coquandonvi] OFF
GO
SET IDENTITY_INSERT [dbo].[dsform] ON 

INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (1, N'frm_DlgHopdong', N'KD', N'Hợp đồng')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (2, N'frm_DlgHotro', N'KD', N'Hỗ trợ khách hàng')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (3, N'frm_DlgKhachhang', N'DM', N'Khách hàng')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (4, N'frm_Donvi', N'DM', N'Cơ quan / Đơn vị')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (5, N'frm_Tinh', N'DM', N'Tỉnh thành')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (6, N'frm_Nhanvien', N'DM', N'Nhân viên')
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (7, N'frm_Phongban', N'DM', N'Phòng ban')
SET IDENTITY_INSERT [dbo].[dsform] OFF
GO
SET IDENTITY_INSERT [dbo].[kyniem] ON 

INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (1, 2, CAST(N'2024-06-30T15:18:33.000' AS DateTime), N'Đám hỏi', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (2, 2, CAST(N'2024-11-08T14:02:51.000' AS DateTime), N'Ngày cưới', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (3, 4, CAST(N'2024-06-28T07:56:44.280' AS DateTime), N'Đám cưới', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (4, 4, CAST(N'2024-06-30T15:18:33.000' AS DateTime), N'Đám hỏi', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (5, 9, CAST(N'2023-07-06T08:51:21.000' AS DateTime), N'Sinh nhật anh B', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (6, 2, CAST(N'1985-02-02T09:22:34.000' AS DateTime), N'Thử 2', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (7, 9, CAST(N'2022-07-06T09:29:10.000' AS DateTime), N'thành lập cty', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (8, 4, CAST(N'1997-01-01T09:25:53.000' AS DateTime), N'sn Nguyên nè', NULL)
INSERT [dbo].[kyniem] ([id], [maidkh], [ngay], [noidung], [username]) VALUES (9, 4, CAST(N'1997-07-06T09:32:20.000' AS DateTime), N'', NULL)
SET IDENTITY_INSERT [dbo].[kyniem] OFF
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'dqsi', N'Đoàn Quốc Sỉ', N'aebb380a56390ca88914f50b39d85e3c', 1, 1, N'ql')
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'hpnguyen', N'Huỳnh Phúc Nguyên', N'a66aa44eedcab738c925fef35e374c55', 1, 1, N'ql')
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'nhtai', N'Nguyễn Hữu Tài', N'bafad58af011117ac39084fe6ee343d7', 3, 1, N'to')
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'nthoanh', N'Nguyễn Thị Hoàng Oanh', N'd6bc8aa26395ab34906b583879d9c0da', 3, 1, N'sk')
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'phuqui', N'Mr Quí', N'c4ca4238a0b923820dcc509a6f75849b', 1, 1, N'ql')
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'ttmhang', N'Trần Thị Mỹ Hằng', N'1b8d281e0dbaf59afe38ba6ad1a3a58d', 2, 1, N'sk')
GO
INSERT [dbo].[nhomdichvu] ([ma], [ten]) VALUES (N'SK', N'Sự kiện')
INSERT [dbo].[nhomdichvu] ([ma], [ten]) VALUES (N'TU', N'Tour')
GO
SET IDENTITY_INSERT [dbo].[nhomquyen] ON 

INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (1, N'Quản trị', 0)
INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (2, N'Phụ trách bộ phận', 1)
INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (3, N'Nhân viên', 9)
SET IDENTITY_INSERT [dbo].[nhomquyen] OFF
GO
SET IDENTITY_INSERT [dbo].[phanquyen] ON 

INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (49, N'2', N'frm_Donvi', 1, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (50, N'2', N'frm_DlgKhachhang', 1, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (51, N'2', N'frm_Nhanvien', 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (52, N'2', N'frm_Phongban', 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (53, N'2', N'frm_Tinh', 1, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (54, N'2', N'frm_DlgHotro', 1, 1, 7, 1, 7, 1, 7)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (55, N'2', N'frm_DlgHopdong', 1, 1, 7, 1, 7, 1, 7)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (56, N'3', N'frm_Donvi', 1, 0, 1, 1, 1, 1, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (57, N'3', N'frm_DlgKhachhang', 1, 0, 1, 1, 1, 1, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (58, N'3', N'frm_Nhanvien', 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (59, N'3', N'frm_Phongban', 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (60, N'3', N'frm_Tinh', 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (61, N'3', N'frm_DlgHotro', 1, 1, 1, 1, 1, 1, 7)
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (62, N'3', N'frm_DlgHopdong', 1, 1, 1, 1, 1, 1, 7)
SET IDENTITY_INSERT [dbo].[phanquyen] OFF
GO
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'cc', N'Thu mua', NULL, NULL, 1)
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'ql', N'Ban quản lý', NULL, NULL, 0)
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'sk', N'Kinh doanh sự kiện', NULL, NULL, 1)
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'to', N'Kinh doanh Tour', NULL, NULL, 1)
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'tt', N'Kinh doanh thị trường', NULL, NULL, 1)
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'bl', N'Bạc Liêu')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'bt', N'Bến Tre')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'cm', N'Cà Mau')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'ct', N'Cần Thơ')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'dt', N'Đồng tháp')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'hcm', N'Hồ Chí Minh')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'hg', N'Hậu Giang')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'kg', N'Kiên Giang')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'la', N'Long An')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'st', N'Sóc Trăng')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tg', N'Tiền Giang')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tn', N'Tây Ninh')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tv', N'Trà Vinh')
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'vl', N'Vĩnh Long')
GO
INSERT [dbo].[version] ([ngay], [noidung], [username], [batbuot]) VALUES (CAST(N'2024-06-29T00:00:00' AS SmallDateTime), N'Cập nhật đơn vị theo khách hàng
Thêm click phải chuột xem hợp đồng đơn vị (quản trị và phụ trách mới xem).', N'phuqui', 1)
INSERT [dbo].[version] ([ngay], [noidung], [username], [batbuot]) VALUES (CAST(N'2024-07-07T00:00:00' AS SmallDateTime), N'Cập nhật xóa dữ liệu toàn bộ, tạo dữ liệu trống', N'phuqui', 1)
GO
/****** Object:  StoredProcedure [dbo].[BAOCAO_CHAMSOC_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[BAOCAO_CHAMSOC_ADMIN]
@tu datetime,
@den datetime
AS
BEGIN 

select username, ten, sum(solan) as solan, count(makh) as sokh from 
(select 
chamsockhachhang.username, makh, count(chamsockhachhang.id) as solan

from chamsockhachhang 
where  chamsockhachhang.ngay >=@tu and chamsockhachhang.ngay <= @den

group by chamsockhachhang.username, chamsockhachhang.makh) as lan

left join nhanvien on nhanvien.ma=username

group by username, nhanvien.ten


END

GO
/****** Object:  StoredProcedure [dbo].[BAOCAO_CHAMSOC_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[BAOCAO_CHAMSOC_QUANLY]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 

select username, ten, sum(solan) as solan, count(makh) as sokh from 
(select 
chamsockhachhang.username, makh, count(chamsockhachhang.id) as solan

from chamsockhachhang 
where  chamsockhachhang.ngay >=@tu and chamsockhachhang.ngay <= @den

group by chamsockhachhang.username, chamsockhachhang.makh) as lan

left join nhanvien on nhanvien.ma=username
where nhanvien.bophan=@ma
group by username, nhanvien.ten


END

GO
/****** Object:  StoredProcedure [dbo].[BAOCAO_DICHVU_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[BAOCAO_DICHVU_ADMIN]
@tu datetime,
@den datetime
AS
BEGIN 

select 
phutrach, ten, sum(sotien) as doanhthu, sum(cungcapdichvu.sotienvon) as tienvon, sum(loinhuan) as loinhuan, count(id) as sohd

from cungcapdichvu
left join nhanvien on nhanvien.ma=phutrach

where  cungcapdichvu.kethucngay >=@tu and cungcapdichvu.kethucngay <= @den AND ketthuc='1'

group by cungcapdichvu.phutrach, nhanvien.ten


END
GO
/****** Object:  StoredProcedure [dbo].[BAOCAO_DICHVU_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BAOCAO_DICHVU_QUANLY]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 

select 
phutrach, ten, sum(sotien) as doanhthu, sum(cungcapdichvu.sotienvon) as tienvon, sum(loinhuan) as loinhuan, count(id) as sohd

from cungcapdichvu
left join nhanvien on nhanvien.ma=phutrach

where  cungcapdichvu.kethucngay >=@tu and cungcapdichvu.kethucngay <= @den AND ketthuc='1' AND nhanvien.bophan=@ma

group by cungcapdichvu.phutrach, nhanvien.ten


END
GO
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_CHAMSOC_ADMIN]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
select chamsockhachhang.*, khachhang.ten as tenkh, khachhang.diachi, khachhang.dienthoai
from chamsockhachhang left join khachhang on chamsockhachhang.makh=khachhang.id
where  chamsockhachhang.ngay >=@tu and chamsockhachhang.ngay <= @den
order by ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_CANHAN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_CHAMSOC_CANHAN]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
select chamsockhachhang.*, khachhang.ten as tenkh, khachhang.diachi, khachhang.dienthoai
from chamsockhachhang left join khachhang on chamsockhachhang.makh=khachhang.id
where  chamsockhachhang.username=@ma and chamsockhachhang.ngay >=@tu and chamsockhachhang.ngay <= @den
order by ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_CHAMSOC_QUANLY]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
select chamsockhachhang.*, khachhang.ten as tenkh, khachhang.diachi, khachhang.dienthoai
from chamsockhachhang left join khachhang on chamsockhachhang.makh=khachhang.id
INNER JOIN nhanvien ON chamsockhachhang.username=nhanvien.ma
where  nhanvien.bophan=@ma and chamsockhachhang.ngay >=@tu and chamsockhachhang.ngay <= @den
order by ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_DICHVU_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DS_DICHVU_ADMIN]
@tu datetime,
@den datetime
AS
BEGIN 
SELECT cungcapdichvu.*, khachhang.tendonvi, khachhang.donvi FROM cungcapdichvu 
--INNER JOIN nhanvien on cungcapdichvu.phutrach = nhanvien.ma
left join khachhang on cungcapdichvu.makh=khachhang.id

where  (cungcapdichvu.ngay >= @tu and cungcapdichvu.ngay <= @den) or ketthuc='0'
order by cungcapdichvu.ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_DICHVU_CANHAN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[DS_DICHVU_CANHAN]
@bophan nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
SELECT cungcapdichvu.*, khachhang.tendonvi, khachhang.donvi FROM cungcapdichvu 
--INNER JOIN nhanvien on cungcapdichvu.phutrach = nhanvien.ma
left join khachhang on cungcapdichvu.makh=khachhang.id

where cungcapdichvu.phutrach=@bophan and cungcapdichvu.ngay >= @tu and cungcapdichvu.ngay <= @den
order by cungcapdichvu.ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_DICHVU_MADONVI]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DS_DICHVU_MADONVI]
@ma bigint
AS
BEGIN 
SELECT cungcapdichvu.* FROM cungcapdichvu 
--INNER JOIN nhanvien on cungcapdichvu.phutrach = nhanvien.ma
left join khachhang on cungcapdichvu.makh=khachhang.id

where  khachhang.donvi=@ma
order by cungcapdichvu.ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_DICHVU_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DS_DICHVU_QUANLY]
@bophan nvarchar(2),
@tu datetime,
@den datetime
AS
BEGIN 
SELECT cungcapdichvu.*, khachhang.tendonvi, khachhang.donvi FROM cungcapdichvu INNER JOIN nhanvien on cungcapdichvu.phutrach = nhanvien.ma
left join khachhang on cungcapdichvu.makh=khachhang.id

where nhanvien.bophan=@bophan and cungcapdichvu.ngay >= @tu and cungcapdichvu.ngay <= @den
order by cungcapdichvu.ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_KHACHHANG_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_KHACHHANG_QUANLY]
@bophan nvarchar(2)
AS
BEGIN 
SELECT khachhang.* FROM khachhang INNER JOIN nhanvien on khachhang.username = nhanvien.ma
where nhanvien.bophan=@bophan
order by khachhang.ten asc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_NGAYKYNIEM_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_NGAYKYNIEM_ADMIN]
@tu datetime,
@den datetime
AS
BEGIN 
SELECT kyniem.id, kyniem.ngay, kyniem.noidung,
	khachhang.ten, khachhang.diachi, khachhang.dienthoai,khachhang.username
	
FROM khachhang inner join kyniem on khachhang.id=kyniem.maidkh

where
	convert(datetime,concat(year(@tu),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) >= @tu
	and
	convert(datetime,concat(year(@den),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) <= @den
	order by kyniem.ngay asc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_NGAYKYNIEM_CANHAN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_NGAYKYNIEM_CANHAN]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
SELECT kyniem.id, kyniem.ngay, kyniem.noidung,
	khachhang.ten, khachhang.diachi, khachhang.dienthoai,khachhang.username

FROM khachhang inner join kyniem on khachhang.id=kyniem.maidkh
where
	convert(datetime,concat(year(@tu),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) >= @tu
	and
	convert(datetime,concat(year(@den),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) <= @den
	and khachhang.username=@ma
	order by kyniem.ngay asc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_NGAYKYNIEM_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_NGAYKYNIEM_QUANLY]
@ma nvarchar(20),
@tu datetime,
@den datetime
AS
BEGIN 
SELECT kyniem.id, kyniem.ngay, kyniem.noidung,
	khachhang.ten, khachhang.diachi, khachhang.dienthoai,khachhang.username
	
FROM khachhang inner join kyniem on khachhang.id=kyniem.maidkh
inner join nhanvien on khachhang.username=nhanvien.ma
where
	convert(datetime,concat(year(@tu),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) >= @tu
	and
	convert(datetime,concat(year(@den),'-',month(kyniem.ngay),'-',day(kyniem.ngay))) <= @den
	and nhanvien.bophan=@ma
	order by kyniem.ngay asc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_NHANVIEN_ADMIN]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DS_NHANVIEN_ADMIN]
AS
BEGIN 
select nhanvien.ma, nhanvien.ten, nhanvien.ok, nhanvien.bophan, nhanvien.nhomquyen, phongban.ten as tenphong 
from nhanvien left join phongban on nhanvien.bophan=phongban.ma
where nhanvien.ma<>'phuqui'
order by nhanvien.ten ASc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_NHANVIEN_QUANLY]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DS_NHANVIEN_QUANLY]
@bophan nvarchar(2)
AS
BEGIN 
select *
from nhanvien 
where nhanvien.ma<>'phuqui' and bophan=@bophan
order by nhanvien.ten ASc
END

GO
/****** Object:  StoredProcedure [dbo].[PQ_NGAYHETHONG]    Script Date: 09/07/2024 2:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[PQ_NGAYHETHONG]
AS

BEGIN
 select getdate() as ngay
END

GO
