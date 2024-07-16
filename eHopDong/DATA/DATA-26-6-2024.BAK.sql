USE [eMekong]
GO
/****** Object:  Table [dbo].[chamsockhachhang]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[coquandonvi]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[cungcapdichvu]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[dsform]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[khachhang]    Script Date: 26/06/2024 10:40:22 AM ******/
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
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[nhomdichvu]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[nhomquyen]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[phanquyen]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[phongban]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[tinh]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  Table [dbo].[version]    Script Date: 26/06/2024 10:40:22 AM ******/
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
SET IDENTITY_INSERT [dbo].[chamsockhachhang] ON 
GO
INSERT [dbo].[chamsockhachhang] ([id], [ngay], [makh], [noidung], [username]) VALUES (1, CAST(N'2024-06-26T00:00:00.000' AS DateTime), 2, N'Anh Quý vui vẻ oki nhe', N'ttmhang')
GO
INSERT [dbo].[chamsockhachhang] ([id], [ngay], [makh], [noidung], [username]) VALUES (2, CAST(N'2024-05-26T00:00:00.000' AS DateTime), 2, N'nhập sao đây', N'ttmhang')
GO
SET IDENTITY_INSERT [dbo].[chamsockhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[coquandonvi] ON 
GO
INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (1, N'Chi cục Phát triển nông thôn', N'', N'', N'', NULL, NULL)
GO
INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (2, N'Phòng Kinh tế Mỏ Cày ', N'', N'', N'', NULL, NULL)
GO
INSERT [dbo].[coquandonvi] ([ma], [ten], [diachi], [dienthoai], [mst], [nganhang], [nganhangten]) VALUES (3, N'Trung tâm Xúc tiến Đầu tư và Khởi nghiệp tỉnh Bến Tre', N'', N'', N'', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[coquandonvi] OFF
GO
SET IDENTITY_INSERT [dbo].[cungcapdichvu] ON 
GO
INSERT [dbo].[cungcapdichvu] ([id], [ngay], [sohopdong], [noidung], [nhomdichvu], [makh], [tenkh], [diachi], [sotien], [covat], [vat], [sotientiensauvat], [sotienvon], [loinhuan], [phutrach], [username], [ketthuc], [kethucngay]) VALUES (1, CAST(N'2024-06-25T00:00:00.000' AS DateTime), NULL, N'Dịch vụ sự kiện', N'SK', 2, N'Anh Quí', NULL, 500000, 1, 5, 525000, 0, 500000, N'ttmhang', N'ttmhang', NULL, NULL)
GO
INSERT [dbo].[cungcapdichvu] ([id], [ngay], [sohopdong], [noidung], [nhomdichvu], [makh], [tenkh], [diachi], [sotien], [covat], [vat], [sotientiensauvat], [sotienvon], [loinhuan], [phutrach], [username], [ketthuc], [kethucngay]) VALUES (2, CAST(N'2024-06-25T00:00:00.000' AS DateTime), NULL, N'Tour du lịch hè', N'TU', 2, N'Anh Quí', NULL, 100000, 1, 0, 100000, 0, 100000, N'ttmhang', N'ttmhang', NULL, NULL)
GO
INSERT [dbo].[cungcapdichvu] ([id], [ngay], [sohopdong], [noidung], [nhomdichvu], [makh], [tenkh], [diachi], [sotien], [covat], [vat], [sotientiensauvat], [sotienvon], [loinhuan], [phutrach], [username], [ketthuc], [kethucngay]) VALUES (3, CAST(N'2024-05-25T00:00:00.000' AS DateTime), NULL, N'Sự kiện T5', N'SK', 2, N'Anh Quí', NULL, 4000000, NULL, 0, 4000000, 0, 4000000, N'ttmhang', N'ttmhang', NULL, NULL)
GO
INSERT [dbo].[cungcapdichvu] ([id], [ngay], [sohopdong], [noidung], [nhomdichvu], [makh], [tenkh], [diachi], [sotien], [covat], [vat], [sotientiensauvat], [sotienvon], [loinhuan], [phutrach], [username], [ketthuc], [kethucngay]) VALUES (4, CAST(N'2024-03-26T00:00:00.000' AS DateTime), NULL, N'dịch vụ nè', N'TU', 2, N'Anh Quí', N'Chợ Lách', 5000000, 0, 0, 5000000, 0, 5000000, N'ttmhang', N'ttmhang', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[cungcapdichvu] OFF
GO
SET IDENTITY_INSERT [dbo].[dsform] ON 
GO
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (1, N'frm_DlgHopdong', N'KD', N'Hợp đồng')
GO
INSERT [dbo].[dsform] ([id], [tenform], [nhom], [tiengviet]) VALUES (2, N'frm_DlgHotro', N'KD', N'Hỗ trợ khách hàng')
GO
SET IDENTITY_INSERT [dbo].[dsform] OFF
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON 
GO
INSERT [dbo].[khachhang] ([id], [ma], [ten], [chucvu], [dienthoai], [diachi], [email], [facebook], [donvi], [tendonvi], [congtacvien], [nhacungcap], [tiemnang], [ngaycuoi], [username], [tinh], [sinhnhat], [sinhnhatco], [kyniem], [kyniemco]) VALUES (2, NULL, N'Anh Quí', N'TP', N'', N'Chợ Lách', N'', N'', 0, N'Chợ Lách', 1, NULL, 1, NULL, N'ttmhang', N'bt', CAST(N'2024-06-25T00:00:00.000' AS DateTime), 0, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'dqsi', N'Đoàn Quốc Sỉ', N'aebb380a56390ca88914f50b39d85e3c', 1, 1, N'ql')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'hpnguyen', N'Huỳnh Phúc Nguyên', N'a66aa44eedcab738c925fef35e374c55', 1, 1, N'ql')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'nhtai', N'Nguyễn Hữu Tài', N'bafad58af011117ac39084fe6ee343d7', 3, 1, N'to')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'phuqui', N'Mr Quí', N'c4ca4238a0b923820dcc509a6f75849b', 1, 1, N'ql')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [pass], [nhomquyen], [ok], [bophan]) VALUES (N'ttmhang', N'Trần Thị Mỹ Hằng', N'1b8d281e0dbaf59afe38ba6ad1a3a58d', 2, 1, N'sk')
GO
INSERT [dbo].[nhomdichvu] ([ma], [ten]) VALUES (N'SK', N'Sự kiện')
GO
INSERT [dbo].[nhomdichvu] ([ma], [ten]) VALUES (N'TU', N'Tour')
GO
SET IDENTITY_INSERT [dbo].[nhomquyen] ON 
GO
INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (1, N'Quản trị', 0)
GO
INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (2, N'Phụ trách bộ phận', 1)
GO
INSERT [dbo].[nhomquyen] ([ma], [ten], [cap]) VALUES (3, N'Nhân viên', 9)
GO
SET IDENTITY_INSERT [dbo].[nhomquyen] OFF
GO
SET IDENTITY_INSERT [dbo].[phanquyen] ON 
GO
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (3, N'3', N'frm_DlgHotro', 1, 1, 1, 1, 1, 1, 7)
GO
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (4, N'3', N'frm_DlgHopdong', 1, 1, 1, 1, 1, 1, 7)
GO
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (5, N'2', N'frm_DlgHotro', 1, 1, 7, 1, 7, 1, 7)
GO
INSERT [dbo].[phanquyen] ([id], [quyen], [form], [chophep], [xoa], [xoangay], [sua], [suangay], [them], [themngay]) VALUES (6, N'2', N'frm_DlgHopdong', 1, 1, 7, 1, 7, 1, 7)
GO
SET IDENTITY_INSERT [dbo].[phanquyen] OFF
GO
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'ql', N'Ban quản lý', NULL, NULL, 0)
GO
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'sk', N'Kinh doanh sự kiện', NULL, NULL, 1)
GO
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'to', N'Kinh doanh Tour', NULL, NULL, 1)
GO
INSERT [dbo].[phongban] ([ma], [ten], [macaptruong], [tencaptruong], [cap]) VALUES (N'tt', N'Kinh doanh thị trường', NULL, NULL, 1)
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'bl', N'Bạc Liêu')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'bt', N'Bến Tre')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'cm', N'Cà Mau')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'ct', N'Cần Thơ')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'dt', N'Đồng tháp')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'hcm', N'Hồ Chí Minh')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'hg', N'Hậu Giang')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'kg', N'Kiên Giang')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'la', N'Long An')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'st', N'Sóc Trăng')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tg', N'Tiền Giang')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tn', N'Tây Ninh')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'tv', N'Trà Vinh')
GO
INSERT [dbo].[tinh] ([ma], [ten]) VALUES (N'vl', N'Vĩnh Long')
GO
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_ADMIN]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_CANHAN]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DS_CHAMSOC_QUANLY]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DS_DICHVU_QUANLY]    Script Date: 26/06/2024 10:40:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[DS_DICHVU_QUANLY]
@bophan nvarchar(2)
AS
BEGIN 
SELECT * FROM cungcapdichvu INNER JOIN nhanvien on cungcapdichvu.phutrach = nhanvien.ma
where nhanvien.bophan=@bophan
order by cungcapdichvu.ngay desc
END

GO
/****** Object:  StoredProcedure [dbo].[DS_KHACHHANG_QUANLY]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DS_NHANVIEN_ADMIN]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DS_NHANVIEN_QUANLY]    Script Date: 26/06/2024 10:40:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[PQ_NGAYHETHONG]    Script Date: 26/06/2024 10:40:22 AM ******/
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
