CREATE DATABASE QuanLyKho
GO

USE QuanLyKho
GO


create table NhaCungCap
(
	MaNCC VARCHAR(10) primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SDT nvarchar(20)
)
GO 

create table KhachHang
(
	MaKH VARCHAR(10) primary key,
	TenKH nvarchar(50),
	GioiTinh NVARCHAR(10),
	DiaChi nvarchar(50),
	SDT nvarchar(20),
)
GO 

create table HangHoa
(
	MaHang VARCHAR(10) primary key,
	TenHang nvarchar(50),
	NganhHang NVARCHAR(50),
	DVT NVARCHAR(50),
	SoLuong INT 
)
GO 

CREATE TABLE PhieuNhap
(
	MaPhieuNhap VARCHAR(10) PRIMARY KEY,
	NgayNhap DATE,
	MaNCC VARCHAR(10) REFERENCES dbo.NhaCungCap(MaNCC)
)
GO

create table ChiTietPhieuNhap
(
	MaPhieuNhap VARCHAR(10) REFERENCES dbo.PhieuNhap(MaPhieuNhap),
	MaHang VARCHAR(10)  REFERENCES dbo.HangHoa(MaHang),
	SoLuong int,
	DonGiaNhap INT,
	PRIMARY KEY(MaPhieuNhap,MaHang)
)
GO 


CREATE TABLE PhieuXuat
(
	MaPhieuXuat VARCHAR(10) PRIMARY KEY,
	NgayXuat DATE,
	MaKH VARCHAR(10) REFERENCES dbo.KhachHang(MaKH)
)
GO

create table ChiTietPhieuXuat
(
	MaPhieuXuat VARCHAR(10) REFERENCES dbo.PhieuXuat(MaPhieuXuat),
	MaHang VARCHAR(10)  REFERENCES dbo.HangHoa(MaHang),
	SoLuong int,
	DonGiaXuat INT,
	PRIMARY KEY(MaPhieuXuat,MaHang)
)
GO 

CREATE TABLE LoaiTK
(
	MaLoaiTK VARCHAR(10) PRIMARY KEY,
	LoaiTK NVARCHAR(50)
)
GO
CREATE TABLE TaiKhoan
(
	TenDN NVARCHAR(50) PRIMARY KEY,
	TenND NVARCHAR(50),
	MatKhau NVARCHAR(50),
	MaLoaiTK VARCHAR(10) REFERENCES dbo.LoaiTK(MaLoaiTK)
)
GO

INSERT dbo.NhaCungCap
        ( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ( 'NCC01', -- MaNCC - varchar(10)
          N'Thanh Hải', -- TenNCC - nvarchar(50)
          N'Hà Nội', -- DiaChi - nvarchar(50)
          N'0908563827'  -- SDT - nvarchar(20)
          )
GO

INSERT dbo.NhaCungCap
        ( MaNCC, TenNCC, DiaChi, SDT )
VALUES  ( 'NCC02', -- MaNCC - varchar(10)
          N'Nam Long', -- TenNCC - nvarchar(50)
          N'Tp Hồ Chí Minh', -- DiaChi - nvarchar(50)
          N'01628420124'  -- SDT - nvarchar(20)
          )
GO

INSERT dbo.KhachHang
        ( MaKH, TenKH, GioiTinh, DiaChi, SDT )
VALUES  ( 'KH01', -- MaKH - varchar(10)
          N'Lê Văn Quang', -- TenKH - nvarchar(50)
          N'Nam', -- GioiTinh - nvarchar(10)
          N'Hà Nội', -- DiaChi - nvarchar(50)
          N'0123456789'  -- SDT - nvarchar(20)
          )
GO

INSERT dbo.KhachHang
        ( MaKH, TenKH, GioiTinh, DiaChi, SDT )
VALUES  ( 'KH02', -- MaKH - varchar(10)
          N'Nguyễn Văn Trung', -- TenKH - nvarchar(50)
          N'Nam', -- GioiTinh - nvarchar(10)
          N'Đà Nẵng', -- DiaChi - nvarchar(50)
          N'0134529844'  -- SDT - nvarchar(20)
          )
GO

INSERT dbo.PhieuNhap
        ( MaPhieuNhap, NgayNhap, MaNCC )
VALUES  ( 'PN01', -- MaPhieuNhap - varchar(10)
          '2018-2-1', -- NgayNhap - date
          'NCC02'  -- MaNCC - varchar(10)
          )
GO
INSERT dbo.PhieuNhap
        ( MaPhieuNhap, NgayNhap, MaNCC )
VALUES  ( 'PN02', -- MaPhieuNhap - varchar(10)
          '2018-3-2', -- NgayNhap - date
          'NCC01'  -- MaNCC - varchar(10)
          )
GO

INSERT dbo.PhieuXuat
        ( MaPhieuXuat, NgayXuat, MaKH )
VALUES  ( 'PX01', -- MaPhieuXuat - varchar(10)
          '2018-4-4', -- NgayXuat - date
          'KH01'  -- MaKH - varchar(10)
          )
GO
INSERT dbo.PhieuXuat
        ( MaPhieuXuat, NgayXuat, MaKH )
VALUES  ( 'PX02', -- MaPhieuXuat - varchar(10)
          '2018-1-1', -- NgayXuat - date
          'KH02'  -- MaKH - varchar(10)
          )
GO

INSERT dbo.HangHoa
        ( MaHang ,
          TenHang ,
          NganhHang ,
          DVT ,
          SoLuong
        )
VALUES  ( 'H01' , -- MaHang - varchar(10)
          N'Điện thoại Samsung' , -- TenHang - nvarchar(50)
          N'Điện tử' , -- NganhHang - nvarchar(50)
          N'Cái' , -- DVT - nvarchar(50)
          10  -- SoLuong - int
        )
GO
INSERT dbo.HangHoa
        ( MaHang ,
          TenHang ,
          NganhHang ,
          DVT ,
          SoLuong
        )
VALUES  ( 'H02' , -- MaHang - varchar(10)
          N'Tủ lạnh Toshiba' , -- TenHang - nvarchar(50)
          N'Điện lạnh' , -- NganhHang - nvarchar(50)
          N'Cái' , -- DVT - nvarchar(50)
          5  -- SoLuong - int
        )
GO
INSERT dbo.ChiTietPhieuNhap
        ( MaPhieuNhap ,
          MaHang ,
          SoLuong ,
          DonGiaNhap
        )
VALUES  ( 'PN01' , -- MaPhieuNhap - varchar(10)
          'H01' , -- MaHang - varchar(10)
          2 , -- SoLuong - int
          5000000  -- DonGiaNhap - int
        )
GO
INSERT dbo.ChiTietPhieuNhap
        ( MaPhieuNhap ,
          MaHang ,
          SoLuong ,
          DonGiaNhap
        )
VALUES  ( 'PN01' , -- MaPhieuNhap - varchar(10)
          'H02' , -- MaHang - varchar(10)
          1 , -- SoLuong - int
          10000000  -- DonGiaNhap - int
        )
GO
INSERT dbo.ChiTietPhieuXuat
        ( MaPhieuXuat ,
          MaHang ,
          SoLuong ,
          DonGiaXuat
        )
VALUES  ( 'PX01' , -- MaPhieuXuat - varchar(10)
          'H01' , -- MaHang - varchar(10)
          1 , -- SoLuong - int
          6000000  -- DonGiaXuat - int
        )
GO

INSERT dbo.ChiTietPhieuXuat
        ( MaPhieuXuat ,
          MaHang ,
          SoLuong ,
          DonGiaXuat
        )
VALUES  ( 'PX02' , -- MaPhieuXuat - varchar(10)
          'H02' , -- MaHang - varchar(10)
          1 , -- SoLuong - int
          12000000  -- DonGiaXuat - int
        )
GO

INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 'LTK01', -- MaLoaiTK - varchar(10)
          N'Quản lí'  -- LoaiTK - nvarchar(50)
          )
GO
INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 'LTK02', -- MaLoaiTK - varchar(10)
          N'Nhân viên'  -- LoaiTK - nvarchar(50)
          )
GO
INSERT dbo.TaiKhoan
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'minh', -- TenDN - nvarchar(50)
          N'Lê Xuân Minh', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          'LTK01'  -- MaLoaiTK - varchar(10)
          )
GO
INSERT dbo.TaiKhoan
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'nam', -- TenDN - nvarchar(50)
          N'Lê Văn Nam', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          'LTK02'  -- MaLoaiTK - varchar(10)
          )
GO