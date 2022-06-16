CREATE TABLE KhachHang 
(
MaKH varchar(10),
Ho nchar(10),
Ten nchar(10),
NgSinh DATETIME,
SoNha varchar(5),
Duong nchar(30),
Phuong nchar(30),
Quan nchar(20),
TPho nchar(20),
DienThoai varchar(15),
PRIMARY KEY (MaKH)
)
CREATE TABLE SanPham
(
MaSP varchar(10),
TenSP nchar(30),
SoLuongTon smallint,
Mota nchar(50),
Gia int,
PRIMARY KEY (MaSP)
)
CREATE TABLE HoaDon 
(
MaHD varchar(10),
MaKH varchar(10),
NgayLap DATETIME,
TongTien int,
PRIMARY KEY (MaHD),
CONSTRAINT HD_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
)
CREATE TABLE CT_HoaDon
(
MaHD varchar(10),
MaSP varchar(10),
Soluong int,
GiaBan int,
GiaGiam int,
ThanhTien int,
PRIMARY KEY (MaHD, MaSP),
CONSTRAINT CTHD_HD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
CONSTRAINT CTHD_SP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)
GO
--tao trigger--
create trigger ct_thanhtien on CT_HoaDon after insert, update
as 
begin
	declare @MaHD as varchar(10);
	declare @MaSP as varchar(10);
	declare @SL as int;
	declare @Gia as int;
	declare @Giam as int;
	declare @ThanhTien as int;	
	SELECT 
		@MaHD = a.MaHD,
		@MaSP = a.MaSP,
		@SL = a.Soluong,
		@Gia = (SELECT sp.Gia FROM SanPham sp WHERE sp.MaSP = a.MaSP),
		@Giam = a.GiaGiam,
		@ThanhTien = a.Soluong * (@Gia-a.GiaGiam)
	FROM inserted a;
	if exists (select MaHD, MaSP from CT_HoaDon where MaHD = @MaHD and MaSP = @MaSP)
	begin
		UPDATE CT_HoaDon 
		SET ThanhTien = @ThanhTien, GiaBan = @Gia
		WHERE MaHD = @MaHD and MaSP = @MaSP
	end
	else 
	begin
		insert into CT_HoaDon values (@MaHD, @MaSP, @SL, @Gia, @Giam, @ThanhTien)
	end
end
go
create trigger ct_tongtienhd on CT_HoaDon after insert, update
as
begin
	declare @MaHD as varchar(10);
	SELECT 
		@MaHD = a.MaHD
	From inserted a;
	begin 
		UPDATE HoaDon
		SET TongTien = (SELECT SUM(ct.ThanhTien) from CT_HoaDon ct where ct.MaHD = @MaHD)
		WHERE MaHD = @MaHD
	end
END
DROP TRIGGER ct_tongtienhd
--truy van--
--CAU 1--
SELECT *
FROM HoaDon hd
WHERE YEAR(hd.NgayLap) = 2020
GO
--Estimated operator cost: 2.2918s, CPU: 0.550157
--
--CAU 2--
SELECT * 
FROM KhachHang kh
WHERE KH.TPho = N'Hồ Chí Minh'
GO
--Estimated operator cost: 2.27587s, CPU: 0.110157
--CAU 3--
SELECT *
FROM SanPham sp
WHERE sp.Gia > 20000 AND sp.Gia < 50000
GO
--Estimated operator cost: 0.18243s, CPU: 0.011157
--CAU 4--
SELECT *
FROM SanPham sp
WHERE sp.SoLuongTon < 100
GO
--Estimated operator cost: 0.18243s, CPU: 0.011157
--CAU 5--
SELECT sp.*, SUM(chd.Soluong) AS DaBan
FROM SanPham sp JOIN CT_HoaDon chd ON chd.MaSP = sp.MaSP
WHERE sp.MaSP IN 
(
SELECT chd.MaSP
FROM CT_HoaDon chd
GROUP BY chd.MaSP
HAVING SUM(chd.Soluong) >= ALL(SELECT SUM(chd1.Soluong) FROM CT_HoaDon chd1 GROUP BY chd1.MaSP)
)
GROUP BY sp.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia
GO
--CAU 6--
SELECT sp.*, SUM(chd.Soluong) AS DaBan, SUM(chd.ThanhTien) AS TongDoanhThu
FROM SanPham sp JOIN CT_HoaDon chd ON chd.MaSP = sp.MaSP
WHERE sp.MaSP IN 
(
SELECT chd.MaSP
FROM CT_HoaDon chd
GROUP BY chd.MaSP
HAVING SUM(chd.ThanhTien) >= ALL(SELECT SUM(chd1.ThanhTien) FROM CT_HoaDon chd1 GROUP BY chd1.MaSP)
)
GROUP BY sp.MaSP, sp.TenSP, sp.SoLuongTon, sp.Mota, sp.Gia
GO
--DELETE FROM CT_HoaDon
--DELETE FROM HoaDon
--DELETE FROM SanPham
--DELETE FROM KhachHang
SELECT * FROM CT_HoaDon chd JOIN SanPham sp ON sp.MaSP = chd.MaSP
--Câu 5b: Các thông số theo như trường hợp mình làm thì hầu như là như nhau