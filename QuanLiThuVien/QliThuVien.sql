CREATE DATABASE QuanLyThuVien
GO

USE QuanLyThuVien
GO

CREATE TABLE Nhanh
(
	MaNhanh VARCHAR(10) PRIMARY KEY,
	TenNhanh NVARCHAR(50),
	DiaChi NVARCHAR(50)
)
GO

CREATE TABLE NhaXB
(
	MaNXB VARCHAR(10) PRIMARY KEY,
	TenNXB NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(20)
)
GO

CREATE TABLE TacGia
(
	MaTacGia VARCHAR(10) PRIMARY KEY,
	TenTacGia NVARCHAR(50)
)


CREATE TABLE DauSach
(
	MaDauSach VARCHAR(10) PRIMARY KEY,
	TenDauSach NVARCHAR(50),
	TheLoai NVARCHAR(50),
	MaNhaXB VARCHAR(10) REFERENCES dbo.NhaXB(MaNXB),
	MaNhanh VARCHAR(10) REFERENCES dbo.Nhanh(MaNhanh)
)
GO

CREATE TABLE ChiTietTacGia
(
	MaDauSach VARCHAR(10) REFERENCES dbo.DauSach(MaDauSach),
	MaTacGia VARCHAR(10) REFERENCES dbo.TacGia(MaTacGia),
	PRIMARY KEY(MaDauSach,MaTacGia)
)
GO

CREATE TABLE CuonSach
(
	MaCuonSach VARCHAR(10) PRIMARY KEY,
	NamXB DATE,
	TinhTrang NVARCHAR(20),
	MaDauSach VARCHAR(10) REFERENCES dbo.DauSach(MaDauSach)
)
GO


CREATE TABLE NguoiDoc
(
	MaNguoiDoc VARCHAR(10) PRIMARY KEY,
	TenNguoiDoc NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(20)
)
GO

CREATE TABLE PhieuMuon
(
	MaNguoiDoc VARCHAR(10) REFERENCES dbo.NguoiDoc( MaNguoiDoc),
	MaCuonSach VARCHAR(10) REFERENCES dbo.CuonSach(MaCuonSach),
	NgayMuon DATE,
	NgayTra DATE,
	PRIMARY KEY(MaNguoiDoc,MaCuonSach)
)
GO

CREATE TABLE LoaiTK
(
	MaLoaiTK INT PRIMARY KEY,
	LoaiTK NVARCHAR(50)
)
GO
CREATE TABLE NguoiDung
(
	TenDN NVARCHAR(50) PRIMARY KEY,
	TenND NVARCHAR(50),
	MatKhau NVARCHAR(50),
	MaLoaiTK INT REFERENCES dbo.LoaiTK(MaLoaiTK)
)
GO

SELECT * FROM dbo.NguoiDoc
GO
INSERT INTO dbo.NguoiDoc
        ( MaNguoiDoc ,
          TenNguoiDoc ,
          DiaChi ,
          SDT
        )
VALUES  ( 'ND01' , -- MaNguoiDoc - varchar(10)
          N'Nguyễn Hà An', -- TenNguoiMuon - nvarchar(50)
          N'Hà Nội', -- DiaChi - nvarchar(50)
          N'0904847362'  -- SDT - nvarchar(20)
        )
GO

INSERT INTO dbo.NguoiDoc
        ( MaNguoiDoc ,
          TenNguoiDoc ,
          DiaChi ,
          SDT
        )
VALUES  ( 'ND02' , -- MaNguoiDoc - varchar(10)
          N'Trần Bảo Long', -- TenNguoiMuon - nvarchar(50)
          N'Tp Hồ Chí Minh', -- DiaChi - nvarchar(50)
          N'0172349346'  -- SDT - nvarchar(20)
        )
GO

INSERT INTO dbo.Nhanh
        ( MaNhanh, TenNhanh, DiaChi )
VALUES  ( 'N01', -- MaNhanh - varchar(10)
          N'Khoa học tự nhiên', -- TenNhanh - nvarchar(50)
          N'Tầng 1'  -- DiaChi - nvarchar(50)
          )
 GO

INSERT INTO dbo.Nhanh
        ( MaNhanh, TenNhanh, DiaChi )
VALUES  ( 'N02', -- MaNhanh - varchar(10)
          N'Lịch Sử', -- TenNhanh - nvarchar(50)
          N'Tầng 2'  -- DiaChi - nvarchar(50)
          )
GO

INSERT INTO dbo.NhaXB
        ( MaNXB, TenNXB, DiaChi, SDT )
VALUES  ( 'NXB01', -- MaNXB - varchar(10)
          N'NXB Giáo Dục', -- TenNXB - nvarchar(50)
          N'Hà Nội', -- DiaChi - nvarchar(50)
          N'0908746352'  -- SDT - nvarchar(20)
          )
GO
INSERT INTO dbo.NhaXB
        ( MaNXB, TenNXB, DiaChi, SDT )
VALUES  ( 'NXB02', -- MaNXB - varchar(10)
          N'NXB Tuổi Trẻ', -- TenNXB - nvarchar(50)
          N'Đà Nẵng', -- DiaChi - nvarchar(50)
          N'0168263847'  -- SDT - nvarchar(20)
          )
GO

INSERT INTO dbo.TacGia
        ( MaTacGia, TenTacGia )
VALUES  ( 'TG01', -- MaTacGia - varchar(10)
          N'Bùi Hiển Trung'  -- TenTacGia - nvarchar(50)
          )
GO
INSERT INTO dbo.TacGia
        ( MaTacGia, TenTacGia )
VALUES  ( 'TG02', -- MaTacGia - varchar(10)
          N'Lê Đình Quý'  -- TenTacGia - nvarchar(50)
          )
GO
INSERT INTO dbo.DauSach
        ( MaDauSach ,
          TenDauSach ,
          TheLoai ,
          MaNhaXB ,
          MaNhanh
        )
VALUES  ( 'DS01' , -- MaDauSach - varchar(10)
          N'Không gia đình' , -- TenDauSach - nvarchar(50)
          N'Tiểu thuyết hiện thực' , -- TheLoai - nvarchar(50)
          'NXB01' , -- MaNhaXB - int
          'N02'  -- MaNhanh - int
        )
GO
INSERT INTO dbo.DauSach
        ( MaDauSach ,
          TenDauSach ,
          TheLoai ,
          MaNhaXB ,
          MaNhanh
        )
VALUES  ( 'DS02' , -- MaDauSach - varchar(10)
          N'Doraemon' , -- TenDauSach - nvarchar(50)
          N'Truyện tranh' , -- TheLoai - nvarchar(50)
          'NXB02' , -- MaNhaXB - varchar(10)
          'N01'  -- MaNhanh - varchar(10)
        )
GO

INSERT INTO dbo.ChiTietTacGia
        ( MaDauSach, MaTacGia )
VALUES  ( 'DS01', -- MaDauSach - varchar(10)
          'TG02'  -- MaTacGia - varchar(10)
          )
GO
INSERT INTO dbo.ChiTietTacGia
        ( MaDauSach, MaTacGia )
VALUES  ( 'DS01', -- MaDauSach - varchar(10)
          'TG01'  -- MaTacGia - varchar(10)
          )
GO
INSERT INTO dbo.ChiTietTacGia
        ( MaDauSach, MaTacGia )
VALUES  ( 'DS02', -- MaDauSach - varchar(10)
          'TG02'  -- MaTacGia - varchar(10)
          )
GO

INSERT INTO dbo.CuonSach
        ( MaCuonSach ,
          NamXB ,
          TinhTrang ,
          MaDauSach
        )
VALUES  ( 'CS01' , -- MaCuonSach - varchar(10)
          '2012-1-1', -- NamXB - date
          N'Đang mượn', -- TinhTrang - nvarchar(20)
          'DS01'  -- MaDauSach - varchar(10)
        )
GO
INSERT INTO dbo.CuonSach
        ( MaCuonSach ,
          NamXB ,
          TinhTrang ,
          MaDauSach
        )
VALUES  ( 'CS02' , -- MaCuonSach - varchar(10)
          '2015-1-1', -- NamXB - date
          N'Trong kho', -- TinhTrang - nvarchar(20)
          'DS01'  -- MaDauSach - varchar(10)
        )
GO
INSERT INTO dbo.CuonSach
        ( MaCuonSach ,
          NamXB ,
          TinhTrang ,
          MaDauSach
        )
VALUES  ( 'CS03' , -- MaCuonSach - varchar(10)
          '2016-1-1', -- NamXB - date
          N'Trong kho', -- TinhTrang - nvarchar(20)
          'DS02'  -- MaDauSach - varchar(10)
        )
GO

INSERT INTO dbo.PhieuMuon
        ( MaNguoiDoc ,
          MaCuonSach ,
          NgayMuon ,
          NgayTra
        )
VALUES  ( 'ND01' , -- MaNguoiDoc - varchar(10)
          'CS02' , -- MaCuonSach - varchar(10)
          '2018-3-12' , -- NgayMuon - date
          '2018-3-20'  -- NgayTra - date
        )
GO
INSERT INTO dbo.PhieuMuon
        ( MaNguoiDoc ,
          MaCuonSach ,
          NgayMuon ,
          NgayTra
        )
VALUES  ( 'ND01' , -- MaNguoiDoc - varchar(10)
          'CS01' , -- MaCuonSach - varchar(10)
          '2018-3-1' , -- NgayMuon - date
          '2018-3-25'  -- NgayTra - date
        )
GO
INSERT INTO dbo.PhieuMuon
        ( MaNguoiDoc ,
          MaCuonSach ,
          NgayMuon ,
          NgayTra
        )
VALUES  ( 'ND02' , -- MaNguoiDoc - varchar(10)
          'CS03' , -- MaCuonSach - varchar(10)
          '2018-4-1' , -- NgayMuon - date
          '2018-4-12'  -- NgayTra - date
        )
GO

INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 1, -- MaLoaiTK - int
          N'Quản lí'  -- LoaiTK - nvarchar(50)
          )
GO
INSERT dbo.LoaiTK
        ( MaLoaiTK, LoaiTK )
VALUES  ( 2, -- MaLoaiTK - int
          N'Nhân viên'  -- LoaiTK - nvarchar(50)
          )
GO
INSERT dbo.NguoiDung
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'minh', -- TenDN - nvarchar(50)
          N'Lê Xuân Minh', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          1  -- MaLoaiTK - int
          )
GO
INSERT dbo.NguoiDung
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'chien', -- TenDN - nvarchar(50)
          N'Phạm Minh Chiến', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          1  -- MaLoaiTK - int
          )
GO
INSERT dbo.NguoiDung
        ( TenDN, TenND, MatKhau, MaLoaiTK )
VALUES  ( N'nam', -- TenDN - nvarchar(50)
          N'Lê Văn Nam', -- TenND - nvarchar(50)
          N'123', -- MatKhau - nvarchar(50)
          2  -- MaLoaiTK - int
          )
GO
--Test
SELECT* FROM dbo.NguoiDung WHERE TenDN=N'minh' AND MatKhau=N'123'
GO

SELECT * FROM dbo.PhieuMuon
GO
DELETE dbo.PhieuMuon WHERE MaNguoiDoc='ND03'
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) )
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

SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'l')+N'%' OR dbo.fuConvertToUnsign1(MaNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'l')+N'%' OR dbo.fuConvertToUnsign1(DiaChi) LIKE N'%'+dbo.fuConvertToUnsign1(N'l')+N'%'OR dbo.fuConvertToUnsign1(SDT) LIKE N'%'+dbo.fuConvertToUnsign1(N'l')+N'%'
GO
SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'123')+N'%'
GO

SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB
GO
SELECT TenNXB FROM dbo.NhaXB
GO
SELECT TenNhanh FROM dbo.Nhanh
GO
INSERT dbo.DauSach( MaDauSach, TenDauSach, TheLoai, MaNhaXB, MaNhanh ) VALUES  ( '', N'', N'', '', '' )
GO
SELECT * FROM dbo.DauSach
GO
UPDATE dbo.DauSach SET TenDauSach=N'Không gia đình',TheLoai=N'Tiểu thuyết hiện thực',MaNhaXB='NXB01',MaNhanh='N02' WHERE MaDauSach='DS01'
GO
DELETE dbo.ChiTietTacGia WHERE MaDauSach=''
GO
SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenNhanh) LIKE N'%'+dbo.fuConvertToUnsign1(N'0')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB
GO
SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(NgayTra) LIKE N'%'+dbo.fuConvertToUnsign1(N'12')+N'%'
GO
SELECT * FROM dbo.NhaXB
GO
SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE NguoiDung.MaLoaiTK=LoaiTK.MaLoaiTK
GO
SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenDN) LIKE N'%'+dbo.fuConvertToUnsign1(N'h')+N'%'
GO