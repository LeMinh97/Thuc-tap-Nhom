CREATE DATABASE QuanLyKhachSan
GO
USE QuanLyKhachSan
GO

CREATE TABLE Phong(
	MaPhong VARCHAR(10) PRIMARY KEY,
	LoaiPhong NVARCHAR(50),
	MoTa NVARCHAR(max),
	TinhTrang BIT,
	DonGiaGio INT
)
GO

CREATE TABLE KhachHang
(
	MaKhachHang VARCHAR(10) PRIMARY KEY,
	TenKhachHang NVARCHAR(50),
	GioiTinh NVARCHAR(10),
	NgaySinh DATE,
	SoCMT VARCHAR(20),
	SDT VARCHAR(20)
)
GO

CREATE TABLE ThuePhong(
	MaKhachHang VARCHAR(10) REFERENCES dbo.KhachHang(MaKhachHang),
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	NgayThue DATE,
	ThoiGian INT,
	PRIMARY KEY(MaKhachHang,MaPhong)
)

CREATE TABLE DichVu(
	MaDichVu VARCHAR(10) PRIMARY KEY,
	TenDichVu NVARCHAR(50),
	DonGia INT
)
GO

CREATE TABLE DoDung(
	MaDoDung VARCHAR(10) PRIMARY KEY,
	TenDoDung NVARCHAR(50),
	DonGia INT
)
GO

CREATE TABLE HoaDonDoDung(
	MaHoaDonDoDung VARCHAR(10) PRIMARY KEY,
	MaKhachHang VARCHAR(10) REFERENCES dbo.KhachHang(MaKhachHang),
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	NgayLap DATE,
	TongTien INT
)
GO

CREATE TABLE ChiTietHoaDonDoDung(
	MaHoaDonDoDung VARCHAR(10) REFERENCES dbo.HoaDonDoDung(MaHoaDonDoDung),
	MaDoDung VARCHAR(10) REFERENCES dbo.DoDung(MaDoDung),
	SoLuongDung INT,
	ThanhTien INT,
	PRIMARY KEY(MaHoaDonDoDung,MaDoDung)
)
GO

CREATE TABLE HoaDonDV(
	MaHoaDonDV VARCHAR(10) PRIMARY KEY,
	MaKhachHang VARCHAR(10) REFERENCES dbo.KhachHang(MaKhachHang),
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	NgayLap DATE,
	TongTien INT
)
GO

CREATE TABLE ChiTietHDDV(
	MaHoaDonDV VARCHAR(10) REFERENCES dbo.HoaDonDV(MaHoaDonDV),
	MaDichVu VARCHAR(10) REFERENCES dbo.DichVu(MaDichVu),
	SoLuong INT,
	ThanhTien INT,
	PRIMARY KEY(MaHoaDonDV,MaDichVu)
)
GO

CREATE TABLE HoaDonTraPhong(
	MaHoaDonTP VARCHAR(10) PRIMARY KEY,
	MaKhachHang VARCHAR(10) REFERENCES dbo.KhachHang(MaKhachHang),
	NgayTra DATE,
	TongTien INT
)
GO

CREATE TABLE ChiTietHoaDonTP(
	MaHoaDonTP VARCHAR(10) REFERENCES dbo.HoaDonTraPhong(MaHoaDonTP),
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	ThoiGian INT,
	ThanhTien INT,
	PRIMARY KEY(MaHoaDonTP,MaPhong)
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

INSERT dbo.Phong
        ( MaPhong ,
          LoaiPhong ,
          MoTa ,
          TinhTrang ,
          DonGiaGio
        )
VALUES  ( 'P101' , -- MaPhong - varchar(10)
          N'Phòng thường' , -- LoaiPhong - nvarchar(50)
          N'2 giường đơn, hướng biển' , -- MoTa - nvarchar(max)
          0 , -- TinhTrang - bit
          40000  -- DonGiaGio - int
        )
GO

INSERT dbo.Phong
        ( MaPhong ,
          LoaiPhong ,
          MoTa ,
          TinhTrang ,
          DonGiaGio
        )
VALUES  ( 'P102' , -- MaPhong - varchar(10)
          N'Phòng VIP' , -- LoaiPhong - nvarchar(50)
          N'1 giường đôi, 4 sao, hướng biển' , -- MoTa - nvarchar(max)
          0 , -- TinhTrang - bit
          100000  -- DonGiaGio - int
        )
GO

INSERT dbo.Phong
        ( MaPhong ,
          LoaiPhong ,
          MoTa ,
          TinhTrang ,
          DonGiaGio
        )
VALUES  ( 'P103' , -- MaPhong - varchar(10)
          N'Phòng thường' , -- LoaiPhong - nvarchar(50)
          N'2 giường đơn' , -- MoTa - nvarchar(max)
          0 , -- TinhTrang - bit
          30000  -- DonGiaGio - int
        )
GO

INSERT dbo.Phong
        ( MaPhong ,
          LoaiPhong ,
          MoTa ,
          TinhTrang ,
          DonGiaGio
        )
VALUES  ( 'P201' , -- MaPhong - varchar(10)
          N'Phòng thường' , -- LoaiPhong - nvarchar(50)
          N'1 giường đơn' , -- MoTa - nvarchar(max)
          1 , -- TinhTrang - bit
          20000  -- DonGiaGio - int
        )
GO

INSERT dbo.Phong
        ( MaPhong ,
          LoaiPhong ,
          MoTa ,
          TinhTrang ,
          DonGiaGio
        )
VALUES  ( 'P202' , -- MaPhong - varchar(10)
          N'Phòng VIP' , -- LoaiPhong - nvarchar(50)
          N'2 giường đôi, 4 sao' , -- MoTa - nvarchar(max)
          0 , -- TinhTrang - bit
          120000  -- DonGiaGio - int
        )
GO

INSERT dbo.KhachHang
        ( MaKhachHang ,
          TenKhachHang ,
          GioiTinh ,
          NgaySinh ,
          SoCMT ,
          SDT
        )
VALUES  ( 'KH01' , -- MaKhachHang - varchar(10)
          N'Trần Văn Tuấn' , -- TenKhachHang - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(10)
          '1971-1-1' , -- NgaySinh - date
          '151627193' , -- SoCMT - varchar(20)
          '01628398472'  -- SDT - varchar(20)
        )
GO

INSERT dbo.KhachHang
        ( MaKhachHang ,
          TenKhachHang ,
          GioiTinh ,
          NgaySinh ,
          SoCMT ,
          SDT
        )
VALUES  ( 'KH02' , -- MaKhachHang - varchar(10)
          N'Lê Tuấn Cường' , -- TenKhachHang - nvarchar(50)
          N'Nam' , -- GioiTinh - nvarchar(10)
          '1977-2-2' , -- NgaySinh - date
          '293527365' , -- SoCMT - varchar(20)
          '0826374848'  -- SDT - varchar(20)
        )
GO

INSERT dbo.KhachHang
        ( MaKhachHang ,
          TenKhachHang ,
          GioiTinh ,
          NgaySinh ,
          SoCMT ,
          SDT
        )
VALUES  ( 'KH03' , -- MaKhachHang - varchar(10)
          N'Nguyễn Lan Anh' , -- TenKhachHang - nvarchar(50)
          N'Nữ' , -- GioiTinh - nvarchar(10)
          '1990-2-1' , -- NgaySinh - date
          '123537937' , -- SoCMT - varchar(20)
          '01693847583'  -- SDT - varchar(20)
        )
GO

INSERT dbo.DoDung
        ( MaDoDung, TenDoDung, DonGia )
VALUES  ( 'DD01', -- MaDoDung - varchar(10)
          N'Khăn tắm', -- TenDoDung - nvarchar(50)
          50000  -- DonGia - int
          )
GO

INSERT dbo.DoDung
        ( MaDoDung, TenDoDung, DonGia )
VALUES  ( 'DD02', -- MaDoDung - varchar(10)
          N'Kem đánh răng và bàn chải', -- TenDoDung - nvarchar(50)
          20000  -- DonGia - int
          )
GO

INSERT dbo.DoDung
        ( MaDoDung, TenDoDung, DonGia )
VALUES  ( 'DD03', -- MaDoDung - varchar(10)
          N'Xà phòng', -- TenDoDung - nvarchar(50)
          15000  -- DonGia - int
          )
GO

INSERT dbo.DichVu
        ( MaDichVu, TenDichVu, DonGia )
VALUES  ( 'DV01', -- MaDichVu - varchar(10)
          N'Ăn sáng', -- TenDichVu - nvarchar(50)
          200000  -- DonGia - int
          )
GO

INSERT dbo.DichVu
        ( MaDichVu, TenDichVu, DonGia )
VALUES  ( 'DV02', -- MaDichVu - varchar(10)
          N'Ăn buffe tối', -- TenDichVu - nvarchar(50)
          300000  -- DonGia - int
          )
GO

INSERT dbo.DichVu
        ( MaDichVu, TenDichVu, DonGia )
VALUES  ( 'DV03', -- MaDichVu - varchar(10)
          N'Massage xông hơi', -- TenDichVu - nvarchar(50)
          200000  -- DonGia - int
          )
GO

INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 'LTK01', -- MaLoaiTK - varchar(10)
          N'Nhân viên'  -- LoaiTK - nvarchar(50)
          )
GO

INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 'LTK02', -- MaLoaiTK - varchar(10)
          N'Quản lí'  -- LoaiTK - nvarchar(50)
          )
GO

INSERT dbo.TaiKhoan
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'minh', -- TenDN - nvarchar(50)
          N'Lê Xuân Minh', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          'LTK02'  -- MaLoaiTK - varchar(10)
          )
GO

INSERT dbo.TaiKhoan
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'chien', -- TenDN - nvarchar(50)
          N'Phạm Minh Chiến', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          'LTK02'  -- MaLoaiTK - varchar(10)
          )
GO

INSERT dbo.TaiKhoan
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'nam', -- TenDN - nvarchar(50)
          N'Lê Văn Nam', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          'LTK01'  -- MaLoaiTK - varchar(10)
          )
GO

INSERT dbo.ThuePhong
        ( MaKhachHang ,
          MaPhong ,
          NgayThue ,
          ThoiGian
        )
VALUES  ( 'KH01' , -- MaKhachHang - varchar(10)
          'P102' , -- MaPhong - varchar(10)
          '2018-4-20 11:00:00' , -- NgayThue - datetime
          48  -- ThoiGian - int
        )
GO

INSERT dbo.ThuePhong
        ( MaKhachHang ,
          MaPhong ,
          NgayThue ,
          ThoiGian
        )
VALUES  ( 'KH02' , -- MaKhachHang - varchar(10)
          'P201' , -- MaPhong - varchar(10)
          '2018-5-1 19:00:00' , -- NgayThue - datetime
          28  -- ThoiGian - int
        )
GO

INSERT dbo.HoaDonDV
        ( MaHoaDonDV ,
          MaKhachHang ,
          MaPhong ,
          NgayLap ,
          TongTien
        )
VALUES  ( 'HDDV01' , -- MaHoaDonDV - varchar(10)
          'KH01' , -- MaKhachHang - varchar(10)
          'P102' , -- MaPhong - varchar(10)
          '2018-4-20' , -- NgayLap - date
          200000  -- TongTien - int
        )
GO

INSERT dbo.HoaDonDV
        ( MaHoaDonDV ,
          MaKhachHang ,
          MaPhong ,
          NgayLap ,
          TongTien
        )
VALUES  ( 'HDDV02' , -- MaHoaDonDV - varchar(10)
          'KH02' , -- MaKhachHang - varchar(10)
          'P201' , -- MaPhong - varchar(10)
          '2018-5-1' , -- NgayLap - date
          800000  -- TongTien - int
        )
GO

INSERT dbo.ChiTietHDDV
        ( MaHoaDonDV ,
          MaDichVu ,
          SoLuong ,
          ThanhTien
        )
VALUES  ( 'HDDV01' , -- MaHoaDonDV - varchar(10)
          'DV01' , -- MaDichVu - varchar(10)
          1 , -- SoLuong - int
          200000  -- ThanhTien - int
        )
GO

INSERT dbo.ChiTietHDDV
        ( MaHoaDonDV ,
          MaDichVu ,
          SoLuong ,
          ThanhTien
        )
VALUES  ( 'HDDV02' , -- MaHoaDonDV - varchar(10)
          'DV02' , -- MaDichVu - varchar(10)
          2 , -- SoLuong - int
          600000  -- ThanhTien - int
        )
GO

INSERT dbo.ChiTietHDDV
        ( MaHoaDonDV ,
          MaDichVu ,
          SoLuong ,
          ThanhTien
        )
VALUES  ( 'HDDV02' , -- MaHoaDonDV - varchar(10)
          'DV01' , -- MaDichVu - varchar(10)
          1 , -- SoLuong - int
          200000  -- ThanhTien - int
        )
GO

INSERT dbo.HoaDonDoDung
        ( MaHoaDonDoDung ,
          MaKhachHang ,
          MaPhong ,
          NgayLap ,
          TongTien
        )
VALUES  ( 'HDDD01' , -- MaHoaDonDoDung - varchar(10)
          'KH02' , -- MaKhachHang - varchar(10)
          'P201' , -- MaPhong - varchar(10)
          '2018-5-1' , -- NgayLap - date
          50000  -- TongTien - int
        )
GO

INSERT dbo.HoaDonDoDung
        ( MaHoaDonDoDung ,
          MaKhachHang ,
          MaPhong ,
          NgayLap ,
          TongTien
        )
VALUES  ( 'HDDD02' , -- MaHoaDonDoDung - varchar(10)
          'KH01' , -- MaKhachHang - varchar(10)
          'P102' , -- MaPhong - varchar(10)
          '2018-4-20' , -- NgayLap - date
          40000  -- TongTien - int
        )
GO

INSERT dbo.ChiTietHoaDonDoDung
        ( MaHoaDonDoDung ,
          MaDoDung ,
          SoLuongDung ,
          ThanhTien
        )
VALUES  ( 'HDDD01' , -- MaHoaDonDoDung - varchar(10)
          'DD01' , -- MaDoDung - varchar(10)
          1, -- SoLuongDung - int
          50000  -- ThanhTien - int
        )
GO

INSERT dbo.ChiTietHoaDonDoDung
        ( MaHoaDonDoDung ,
          MaDoDung ,
          SoLuongDung ,
          ThanhTien
        )
VALUES  ( 'HDDD02' , -- MaHoaDonDoDung - varchar(10)
          'DD02' , -- MaDoDung - varchar(10)
          2 , -- SoLuongDung - int
          40000  -- ThanhTien - int
        )
GO

INSERT dbo.HoaDonTraPhong
        ( MaHoaDonTP ,
          MaKhachHang ,
          NgayTra ,
          TongTien
        )
VALUES  ( 'HDTP01' , -- MaHoaDonTP - varchar(10)
          'KH01' , -- MaKhachHang - varchar(10)
          '2018-4-22' , -- NgayTra - date
          0  -- TongTien - int
        )
GO

INSERT dbo.ChiTietHoaDonTP
        ( MaHoaDonTP ,
          MaPhong ,
          ThoiGian ,
          ThanhTien
        )
VALUES  ( 'HDTP01' , -- MaHoaDonTP - varchar(10)
          'P102' , -- MaPhong - varchar(10)
          48 , -- ThoiGian - int
          4800000  -- ThanhTien - int
        )
GO

CREATE FUNCTION [dbo].[ChuyenDoiKiTuUnicode] ( @strInput NVARCHAR(4000) )
 RETURNS NVARCHAR(4000) AS BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput 
 DECLARE @RT NVARCHAR(4000) 
 DECLARE @SIGN_CHARS NCHAR(136) 
 DECLARE @UNSIGN_CHARS NCHAR (136) 
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
 DECLARE @COUNTER int 
 DECLARE @COUNTER1 int 
 SET @COUNTER = 1 
 WHILE (@COUNTER <=LEN(@strInput)) 
 BEGIN SET @COUNTER1 = 1 
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
 BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
 BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
 BREAK END 
 SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END 
 SET @strInput = replace(@strInput,' ','-') 
 RETURN @strInput END
GO

-- test
SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'102')+N'%'
GO
SELECT * FROM dbo.Phong WHERE TinhTrang=0
GO