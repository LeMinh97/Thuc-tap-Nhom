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
-- Nháp
INSERT dbo.HangHoa( MaHang , TenHang , NganhHang , DVT , SoLuong ) VALUES  ( '' , N'' , N'' , N'' , 0  )
GO
UPDATE dbo.HangHoa SET TenHang=N'',NganhHang=N'',DVT=N'', SoLuong= WHERE MaHang=''
GO
DELETE dbo.HangHoa WHERE MaHang=''
GO
SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(DVT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'm')+N'%'
GO
SELECT ChiTietPhieuXuat.MaPhieuXuat,NgayXuat,TenKH,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.PhieuXuat,dbo.KhachHang,dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE KhachHang.MaKH=PhieuXuat.MaKH AND ChiTietPhieuXuat.MaPhieuXuat=PhieuXuat.MaPhieuXuat AND ChiTietPhieuXuat.MaHang=HangHoa.MaHang
GO
SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat,dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH
GO
SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang
GO
SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'')+N'%'
GO
SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC
GO
SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang
GO
SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'')+N'%'