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
	ThoiGianO INT,
	ThanhToan NVARCHAR(50),
	PRIMARY KEY(MaKhachHang,MaPhong,NgayThue)
)
GO

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

CREATE TABLE DoDungTheoPhong(
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	MaDoDung VARCHAR(10) REFERENCES dbo.DoDung(MaDoDung),
	NgayKT DATE,
	SoLuongBanDau INT,
	SoLuongDaDung INT,
	PRIMARY KEY(MaPhong,MaDoDung,NgayKT)
)
GO

CREATE TABLE SuDungDichVu(
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
	MaDichVu VARCHAR(10) REFERENCES dbo.DichVu(MaDichVu),
	NgayDung DATE,
	SoLuong INT,
	ThanhToan NVARCHAR(50),
	PRIMARY KEY(MaPhong,MaDichVu,NgayDung)
)
GO

CREATE TABLE ThanhToan(
	MaHoaDon INT IDENTITY PRIMARY KEY,
	MaPhong VARCHAR(10) REFERENCES dbo.Phong(MaPhong),
    TenKhachHang NVARCHAR(50),
	NgayThanhToan DATE,
	NgayThue DATE,
	ThoiGianO INT,
	TongTien INT
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



INSERT dbo.DoDungTheoPhong
        ( MaPhong ,
          MaDoDung ,
          NgayKT ,
          SoLuongBanDau ,
          SoLuongDaDung
        )
VALUES  ( 'P101' , -- MaPhong - varchar(10)
          'DD01' , -- MaDoDung - varchar(10)
          '2018-5-5' , -- NgayKT - date
          5 , -- SoLuongBanDau - int
          1  -- SoLuongDaDung - int
        )
GO

INSERT dbo.DoDungTheoPhong
        ( MaPhong ,
          MaDoDung ,
          NgayKT ,
          SoLuongBanDau ,
          SoLuongDaDung
        )
VALUES  ( 'P102' , -- MaPhong - varchar(10)
          'DD02' , -- MaDoDung - varchar(10)
          '2018-5-3' , -- NgayKT - date
          2 , -- SoLuongBanDau - int
          2  -- SoLuongDaDung - int
        )
GO
INSERT dbo.ThuePhong
        ( MaKhachHang ,
          MaPhong ,
          NgayThue ,
          ThoiGianO ,
          ThanhToan
        )
VALUES  ( 'KH01' , -- MaKhachHang - varchar(10)
          'P101' , -- MaPhong - varchar(10)
          '2018-1-1' , -- NgayThue - date
          24 , -- ThoiGianO - int
          N'Chưa'  -- ThanhToan - bit
        )
GO
INSERT dbo.ThuePhong
        ( MaKhachHang ,
          MaPhong ,
          NgayThue ,
          ThoiGianO ,
          ThanhToan
        )
VALUES  ( 'KH02' , -- MaKhachHang - varchar(10)
          'P201' , -- MaPhong - varchar(10)
          '2018-2-2' , -- NgayThue - date
          72 , -- ThoiGianO - int
          N'Chưa'  -- ThanhToan - bit
        )
GO
INSERT dbo.SuDungDichVu
        ( MaPhong ,
          MaDichVu ,
          NgayDung ,
          SoLuong ,
          ThanhToan
        )
VALUES  ( 'P101' , -- MaPhong - varchar(10)
          'DV02' , -- MaDichVu - varchar(10)
          '2018-1-1' , -- NgayDung - date
          3 , -- SoLuong - int
          N'Chưa'  -- ThanhToan - bit
        )
GO
INSERT dbo.SuDungDichVu
        ( MaPhong ,
          MaDichVu ,
          NgayDung ,
          SoLuong ,
          ThanhToan
        )
VALUES  ( 'P201' , -- MaPhong - varchar(10)
          'DV01' , -- MaDichVu - varchar(10)
          '2018-2-2' , -- NgayDung - date
          2 , -- SoLuong - int
          N'Chưa'  -- ThanhToan - bit
        )
GO

--
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
SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'1')+N'%'
GO
SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'2')+N'%'
GO
ALTER TABLE dbo.Phong ADD TinhTrang NVARCHAR(50)
GO

-- câu truy vấn thông tin trả phòng
SELECT ThuePhong.MaPhong, TenKhachHang, NgayThue, ThoiGianO, ThoiGianO*DonGiaGio AS ThanhTien1 FROM dbo.ThuePhong, dbo.KhachHang, dbo.Phong WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='P101' AND ThanhToan LIKE N'Chưa'
GO

--câu truy vấn tính tiền phòng
SELECT ThoiGianO*DonGiaGio AS TienPhong FROM dbo.ThuePhong, dbo.Phong WHERE ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='P101' AND ThanhToan LIKE N'Chưa'
GO

-- câu truy vấn thông tin dịch vụ
SELECT MaPhong,TenDichVu, NgayDung, SoLuong,DonGia, SoLuong*DonGia AS ThanhTien FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='P101'
GO

-- câu truy vấn tính tiền dịch vụ
SELECT SUM(SoLuong*DonGia) AS TienDichVu FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='P101' GROUP BY SoLuong*DonGia
GO

-- hàm tính tổng tiền
SELECT a.TienPhong+b.TienDichVu AS TongTien FROM
(SELECT ThoiGianO*DonGiaGio AS TienPhong FROM dbo.ThuePhong, dbo.Phong WHERE ThuePhong.MaPhong=Phong.MaPhong AND ThuePhong.MaPhong='P201' AND ThanhToan LIKE N'Chưa') AS a,
(SELECT SUM(SoLuong*DonGia) AS TienDichVu FROM dbo.DichVu,dbo.SuDungDichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND ThanhToan LIKE N'Chưa' AND MaPhong='P201' GROUP BY SoLuong*DonGia) AS b
GO


