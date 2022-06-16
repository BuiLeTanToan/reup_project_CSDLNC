create database QLBH

use QLBH

--Tao bang khach hang
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
	constraint KhachHang_pk PRIMARY KEY (MaKH)
)

--Tao bang san pham
CREATE TABLE SanPham
(
	MaSP varchar(10),
	TenSP nchar(30),
	SoLuongTon smallint,
	Mota nchar(50),
	Gia int,
	constraint SanPham_pk PRIMARY KEY (MaSP)
)

--Tao bang hoa don
CREATE TABLE HoaDon 
(
	MaHD varchar(10),
	MaKH varchar(10),
	NgayLap DATETIME,
	TongTien int,
	constraint HoaDon_pk PRIMARY KEY (MaHD),
	
)

--Tao bang chi tiet hoa don
CREATE TABLE CT_HoaDon
(
	MaHD varchar(10),
	MaSP varchar(10),
	Soluong int,
	GiaBan int,
	GiaGiam int,
	ThanhTien int,
	constraint CT_HoaDon_pk PRIMARY KEY (MaHD, MaSP),
	
)

--Tao khoai ngoai
ALTER TABLE HoaDon ADD CONSTRAINT HD_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
ALTER TABLE CT_HoaDon ADD CONSTRAINT CTHD_HD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
ALTER TABLE CT_HoaDon ADD CONSTRAINT CTHD_SP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)

GO


--truy van--
--CAU a--
SELECT *
FROM HoaDon hd
WHERE YEAR(hd.NgayLap) = 2020
GO
--
--CAU b--
SELECT * 
FROM KhachHang kh
WHERE kh.TPho LIKE N'%Hồ Chí Minh%'
GO
--CAU c--
SELECT *
FROM SanPham sp
WHERE sp.Gia > 50000 AND sp.Gia < 100000
GO
--CAU d--
SELECT *
FROM SanPham sp
WHERE sp.SoLuongTon < 100
GO

--CAU e--
SELECT chd.MaSP,sp.TenSP,  SUM(chd.Soluong) AS so_luong
FROM CT_HoaDon chd , SanPham sp 
WHERE sp.MaSP = chd.MaSP
GROUP BY chd.MaSP, sp.TenSP, sp.Mota, sp.Gia
GO

--CAU f--
SELECT chd.MaSP,sp.TenSP,  SUM(chd.ThanhTien) AS doanh_thu
FROM CT_HoaDon chd , SanPham sp 
WHERE sp.MaSP = chd.MaSP
GROUP BY sp.MaSP, sp.TenSP, sp.Mota, sp.Gia
GO
-- ghi nhan recommand index
-- a khong co
-- b khong co
-- c khong co
-- d khong co
-- e khong co
-- f khong co
 
--test
SELECT * FROM HoaDon hd
JOIN KhachHang kh ON kh.MaKH = hd.MaKH

SELECT * FROM KhachHang kh 
JOIN HoaDon hd ON kh.MaKH = hd.MaKH
-- Join tu bang nho hon thi thoi gian thuc thi ngan hon