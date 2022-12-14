CREATE DATABASE StoreSneaker;
GO
use StoreSneaker;
GO
ALTER DATABASE [StoreSneaker] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreSneaker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreSneaker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StoreSneaker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StoreSneaker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StoreSneaker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StoreSneaker] SET ARITHABORT OFF 
GO
ALTER DATABASE [StoreSneaker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StoreSneaker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StoreSneaker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StoreSneaker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StoreSneaker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StoreSneaker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StoreSneaker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StoreSneaker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StoreSneaker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StoreSneaker] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StoreSneaker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StoreSneaker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StoreSneaker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StoreSneaker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StoreSneaker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StoreSneaker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StoreSneaker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StoreSneaker] SET RECOVERY FULL 
GO
ALTER DATABASE [StoreSneaker] SET  MULTI_USER 
GO
ALTER DATABASE [StoreSneaker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StoreSneaker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StoreSneaker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StoreSneaker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StoreSneaker] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StoreSneaker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StoreSneaker', N'ON'
GO
ALTER DATABASE [StoreSneaker] SET QUERY_STORE = OFF
GO
USE [StoreSneaker]
GO
/****** Object:  Table [dbo].[BANG_SIZE]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANG_SIZE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENSIZE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CA_LAM]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CA_LAM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENCA] [nvarchar](50) NULL,
	[THOIGIAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_PHIEUNHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_PHIEUNHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idSanPham] [int] NULL,
	[SOLUONG] [int] NULL,
	[GIANHAP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUC_VU]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUC_VU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENCHUCVU] [nvarchar](50) NULL,
	[LUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIO_HANG]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIO_HANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idHoaDon] [int] NULL,
	[idSanPham] [int] NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANG_SAN_XUAT]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG_SAN_XUAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENHANG] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NGAYLAPHD] [date] NULL,
	[idKhachHang] [int] NULL,
	[TRANGTHAI] [bit] NULL,
	[TONGTIEN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[SDT] [nvarchar](12) NULL,
	[DIACHI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENKHO] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHA_CUNG_CAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHA_CUNG_CAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[GIOITINH] [bit] NULL,
	[NGAYSINH] [date] NULL,
	[CMND] [nvarchar](20) NULL,
	[SDT] [nvarchar](20) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[idCALAM] [int] NULL,
	[idCHUCVU] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_NHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_NHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[NGAYNHAP] [date] NULL,
	[idNhaCC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](50) NULL,
	[MAUSAC] [nvarchar](20) NULL,
	[idSIZE] [int] NULL,
	[GIABAN] [int] NULL,
	[idHANGSX] [int] NULL,
	[idKHO] [int] NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER_LOGIN]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER_LOGIN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [nvarchar](15) NULL,
	[PASSWORD] [nvarchar](15) NULL,
	[TYPE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT (getdate()) FOR [NGAYLAPHD]
GO
ALTER TABLE [dbo].[HOA_DON] ADD  DEFAULT ((0)) FOR [TRANGTHAI]
GO
ALTER TABLE [dbo].[PHIEU_NHAP] ADD  DEFAULT (getdate()) FOR [NGAYNHAP]
GO
ALTER TABLE [dbo].[CHITIET_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_ctphieunhap_phieunhap] FOREIGN KEY([ID])
REFERENCES [dbo].[PHIEU_NHAP] ([ID])
GO
ALTER TABLE [dbo].[CHITIET_PHIEUNHAP] CHECK CONSTRAINT [fk_ctphieunhap_phieunhap]
GO
ALTER TABLE [dbo].[CHITIET_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_ctphieunhap_sanpham] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SAN_PHAM] ([ID])
GO
ALTER TABLE [dbo].[CHITIET_PHIEUNHAP] CHECK CONSTRAINT [fk_ctphieunhap_sanpham]
GO
ALTER TABLE [dbo].[GIO_HANG]  WITH CHECK ADD  CONSTRAINT [fk_giohang_hoadon] FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[HOA_DON] ([ID])
GO
ALTER TABLE [dbo].[GIO_HANG] CHECK CONSTRAINT [fk_giohang_hoadon]
GO
ALTER TABLE [dbo].[GIO_HANG]  WITH CHECK ADD  CONSTRAINT [fk_giohang_sp] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SAN_PHAM] ([ID])
GO
ALTER TABLE [dbo].[GIO_HANG] CHECK CONSTRAINT [fk_giohang_sp]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_khachhang] FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([ID])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [fk_hoadon_khachhang]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_calam] FOREIGN KEY([idCALAM])
REFERENCES [dbo].[CA_LAM] ([ID])
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [fk_nhanvien_calam]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_chucvu] FOREIGN KEY([idCHUCVU])
REFERENCES [dbo].[CHUC_VU] ([ID])
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [fk_nhanvien_chucvu]
GO
ALTER TABLE [dbo].[PHIEU_NHAP]  WITH CHECK ADD  CONSTRAINT [fk_ncc_phieunhap] FOREIGN KEY([idNhaCC])
REFERENCES [dbo].[NHA_CUNG_CAP] ([ID])
GO
ALTER TABLE [dbo].[PHIEU_NHAP] CHECK CONSTRAINT [fk_ncc_phieunhap]
GO
ALTER TABLE [dbo].[PHIEU_NHAP]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_phieunhap] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([ID])
GO
ALTER TABLE [dbo].[PHIEU_NHAP] CHECK CONSTRAINT [fk_nhanvien_phieunhap]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [fk_hangsx_sp] FOREIGN KEY([idHANGSX])
REFERENCES [dbo].[HANG_SAN_XUAT] ([ID])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [fk_hangsx_sp]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [fk_kho_sp] FOREIGN KEY([idKHO])
REFERENCES [dbo].[KHO] ([ID])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [fk_kho_sp]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [fk_size_sp] FOREIGN KEY([idSIZE])
REFERENCES [dbo].[BANG_SIZE] ([ID])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [fk_size_sp]
GO
ALTER TABLE [dbo].[USER_LOGIN]  WITH CHECK ADD  CONSTRAINT [fk_login_chucvu] FOREIGN KEY([TYPE])
REFERENCES [dbo].[CHUC_VU] ([ID])
GO
ALTER TABLE [dbo].[USER_LOGIN] CHECK CONSTRAINT [fk_login_chucvu]
GO
/****** Object:  StoredProcedure [dbo].[ADD_GIOHANG]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_GIOHANG]
	@IDHOADON INT, @IDSANPHAM INT, @SOLUONG INT
	AS
	BEGIN
	    DECLARE @isExitsGioHang INT
			DECLARE @SanPhamCount INT = 1
			
			SELECT @isExitsGioHang = id , @SanPhamCount = GIO_HANG.SOLUONG
			FROM GIO_HANG
			WHERE idHoaDon = @IDHOADON AND idSanPham = @IDSANPHAM
			
			IF(@isExitsGioHang>0)
			BEGIN
					DECLARE @newCount INT = @SanPhamCount + @SOLUONG
					IF(@newCount > 0)
						UPDATE GIO_HANG SET SOLUONG = @SanPhamCount + @SOLUONG WHERE idSanPham = @IDSANPHAM
					ElSE
						DELETE GIO_HANG WHERE idHoaDon = @IDHOADON AND idSanPham = @IDSANPHAM
			END
			ELSE
				BEGIN
					INSERT INTO GIO_HANG(idHoaDon,idSanPham,SOLUONG)
					VALUES (@IDHOADON,@IDSANPHAM,@SOLUONG)
				END
	END
GO
/****** Object:  StoredProcedure [dbo].[ADD_HOADON]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_HOADON]
@IDKHACHHANG INT
AS
BEGIN
	INSERT INTO HOA_DON(NGAYLAPHD, idKhachHang,TRANGTHAI)
	VALUES (GETDATE(),@IDKHACHHANG,0)
END
GO
/****** Object:  StoredProcedure [dbo].[ADD_PHIEUNHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_PHIEUNHAP]
@IDNhanVien INT,@idNhaCC INT,@idSanPham INT, @SoLuong INT, @GiaNhap INT
AS
BEGIN
	INSERT INTO PHIEU_NHAP(idNhanVien,NGAYNHAP,idNhaCC)
	VALUES(@IDNhanVien,GETDATE(),@idNhaCC)
	INSERT INTO CHITIET_PHIEUNHAP(idSanPham,SOLUONG,GIANHAP)
	VALUES(@idSanPham,@SoLuong,@GiaNhap)
END
GO
/****** Object:  StoredProcedure [dbo].[DEL_PHIEUNHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DEL_PHIEUNHAP]
@ID INT
AS
BEGIN
DELETE FROM CHITIET_PHIEUNHAP WHERE ID = @ID
	DELETE FROM PHIEU_NHAP WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[Show_SanPham]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[Show_SanPham]
AS
BEGIN
	SELECT SAN_PHAM.ID,SAN_PHAM.TEN,SAN_PHAM.MAUSAC,BANG_SIZE.TENSIZE,SAN_PHAM.GIABAN,HANG_SAN_XUAT.TENHANG,Kho.TENKHO FROM SAN_PHAM INNER JOIN BANG_SIZE ON SAN_PHAM.idSIZE = BANG_SIZE.ID
INNER JOIN HANG_SAN_XUAT ON SAN_PHAM.idHANGSX = HANG_SAN_XUAT.ID
INNER JOIN KHO ON SAN_PHAM.idKHO = KHO.ID
END;
GO
/****** Object:  StoredProcedure [dbo].[UP_PHIEUNHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UP_PHIEUNHAP]
@ID INT, @IDNhanVien INT,@idNhaCC INT,@idSanPham INT, @SoLuong INT, @GiaNhap INT
AS
BEGIN
	UPDATE PHIEU_NHAP SET idNhanVien = @IDNhanVien, idNhaCC = @idNhaCC WHERE ID = @ID
	UPDATE CHITIET_PHIEUNHAP SET idSanPham = @idSanPham, SOLUONG = @SoLuong, GIANHAP = @GiaNhap WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[VIEW_PHIEUNHAP]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VIEW_PHIEUNHAP]
AS
BEGIN
		SELECT PHIEU_NHAP.ID, PHIEU_NHAP.NGAYNHAP,PHIEU_NHAP.idNhanVien, PHIEU_NHAP.idNhaCC, CHITIET_PHIEUNHAP.idSanPham , SAN_PHAM.idSIZE , CHITIET_PHIEUNHAP.SOLUONG,CHITIET_PHIEUNHAP.GIANHAP, GIANHAP*CHITIET_PHIEUNHAP.SOLUONG AS TONGTIEN, BANG_SIZE.TENSIZE, NHAN_VIEN.HOTEN, NHA_CUNG_CAP.TENNCC, SAN_PHAM.TEN
		FROM PHIEU_NHAP
		INNER JOIN CHITIET_PHIEUNHAP ON PHIEU_NHAP.ID = CHITIET_PHIEUNHAP.ID
		INNER JOIN NHAN_VIEN ON NHAN_VIEN.ID = PHIEU_NHAP.idNhanVien
		INNER JOIN NHA_CUNG_CAP ON NHA_CUNG_CAP.ID = PHIEU_NHAP.idNhaCC
		INNER JOIN SAN_PHAM ON CHITIET_PHIEUNHAP.idSanPham = SAN_PHAM.ID
		INNER JOIN BANG_SIZE ON BANG_SIZE.ID = SAN_PHAM.idSIZE
END
GO
/****** Object:  StoredProcedure [dbo].[View_SanPham]    Script Date: 11/9/2022 6:24:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[View_SanPham]
AS
BEGIN
SELECT SAN_PHAM.ID, SAN_PHAM.TEN, SAN_PHAM.MAUSAC, SAN_PHAM.GIABAN, BANG_SIZE.TENSIZE, HANG_SAN_XUAT.TENHANG, SAN_PHAM.SOLUONG, KHO.TENKHO 
FROM SAN_PHAM
INNER JOIN BANG_SIZE ON SAN_PHAM.idSIZE = BANG_SIZE.ID
INNER JOIN HANG_SAN_XUAT ON SAN_PHAM.idHANGSX = HANG_SAN_XUAT.ID
INNER JOIN KHO ON SAN_PHAM.idKHO = KHO.ID;

END
GO
USE [master]
GO
ALTER DATABASE [StoreSneaker] SET  READ_WRITE 
GO
