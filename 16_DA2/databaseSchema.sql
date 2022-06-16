﻿use [master]
go
if DB_ID('CONCUNG') is not null
	drop database CONCUNG
go
CREATE DATABASE CONCUNG
go
use CONCUNG
go

Create table DonHang(
	MaDH bigint not null PRIMARY KEY IDENTITY,
	MaTTGH bigint,
	MANV int,
	MaKho int,
	MaCN int,
	NgayXuatDH Datetime not null,
	TamTinhDH money not null,
	PhiVCDH money not null,
	TongTienDH money not null,
	KhuyenMaiApDungDH money not null,
	HinhThucThanhToan tinyint not null
)

Create table Kho(
	MaKho int not null primary key IDENTITY,
	TenKho nchar(30) not null,
	DiaChiKho nchar(200) not null,
	SdtKho numeric(10) not null,
	EmailKho nchar(30) not null,
)

Create table ChiTietKho(
	MaCTK int not null primary key IDENTITY,
	MaKho int not null,
	MaSp int not null,
	SoLuong tinyint not null,
)

Create table PhieuNhapXuatKho(
	MaPNXK int not null primary key IDENTITY, 
	MaKho int not null,
	MaCN int not null,
	TongTienNXK money not null,
	Loai bit not null,
)

Create table ChiTietPNXK(
	MaChiTietPNXK bigint not null primary key IDENTITY,
	MaPNXK int not null,
	MaSP int not null,
	SoLuong int not null,
	DonGia money not null
)

Create table SanPham(
	MaSP int not null primary key IDENTITY,
	TenSP nchar(30) not null,
	GiaSP money not null,
	MoTaSP nvarchar(100),
	LoaiSP nvarchar(100) not null,
)

Create table ChiNhanhSanPham(
	MaCNSP int not null primary key IDENTITY,
	MaCN int not null,
	MaSP int not null,
	SoLuong int not null,
)

Create table ChiNhanh(
	MaCN int not null primary key IDENTITY,
	MaHD int not null,
	TenCN nchar(30) not null,
	DiaChiCN nchar(30) not null,
	SdtCN numeric(10) not null,
	EmailCN nchar(30) not null
)

Create table HDong(
	MaHD int not null primary key IDENTITY,
	MaCN int not null,
	LoaiHD bit not null,
	MoTa nvarchar(300),
	NgayKK datetime not null,
	NgayKT datetime not null
)

Create table NhanVien(
	MaNV int not null primary key IDENTITY,
	MaCN int not null,
	TenNV nchar(30) not null,
	SdtNV numeric(10) not null,
	DiaChiNV nvarchar(300) not null,
	GioiTinhNV bit not null,
	SoCMNDVN numeric(12) not null,
	SoTKNV numeric(16) not null
)

Create table KhieuNai(
	MaKN bigint not null primary key IDENTITY,
	MaDH bigint not null,
	NgayGhiNhanKN datetime not null,
	TinhTrangKN bit not null,
	LoaiKN bit not null,
)

Create table DanhGia(
	MaDG bigint not null primary key IDENTITY,
	MaDH bigint not null,
	SoSao tinyint not null,
	Comment nvarchar(300),
	ThoiGianDanhGia datetime
)

Create table ThongTinGiaoHang(
	MaTTGH bigint not null primary key IDENTITY,
	MaKhachHang int not null,
	SoNhaTTGH nchar(30) not null,
	DuongTTGH nchar(30) not null,
	QuanTTGH nchar(30) not null,
	ThanhPhoTTGH nchar(30) not null,
	HinhThucVanChuyen tinyint not null,
	TinhTrangDonHang tinyint not null
)

Create table ChiTietDonHang(
	MaCTDH bigint not null primary key IDENTITY,
	MaDH bigint not null,
	MaSP int not null,
	SoLuong tinyint not null,
	DonGia money not null
)

Create table ChiTietGioHang(
	MaCTGH bigint not null primary key IDENTITY,
	MaKH int not null,
	MaSP int not null,
	SoLuong tinyint not null,
)

Create table Comment(
	MaComment bigint not null primary key IDENTITY,
	MaKH int not null,
	MaSP int not null,
	Ngay datetime not null,
	NoiDung nvarchar(300) not null,
)

Create table KhachHang(
	MaKhachHang int not null primary key IDENTITY,
	TenKH nchar(30) not null,
	NgaySinhKH datetime not null,
	GioiTinhKH bit not null,
	EmailKH nchar(30) not null,
	SdtKH numeric(10) not null,
)

Create table KhuyenMaiDaNhan(
	MaKMDN bigint not null primary key IDENTITY,
	MaKhachHang int not null,
	MaKhuyenMai int not null,
	NgayNhanKMDN datetime not null
)

Create table KhuyenMai(
	MaKhuyenMai int not null primary key IDENTITY,
	NgayBatDauKM datetime not null,
	NgayKetThucKM datetime not null,
	SoTienGiam money
)

--Tao Khoa ngoai
Alter table ChiTietGioHang 
add constraint fk_chitietgiohang_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table Comment 
add constraint fk_comment_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table ChiTietDonHang 
add constraint fk_chitietdonhang_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table ChiTietKho 
add constraint fk_chitietkho_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table ChiTietPNXK 
add constraint fk_chitietphieunhapxuatkho_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table ChiNhanhSanPham 
add constraint fk_chinhanhsanpham_sanpham 
foreign key (MaSP) references SanPham(MaSP)

Alter table ChiTietPNXK 
add constraint fk_chiTietPNXK_PhieuNhapXuatKho 
foreign key (MaPNXK) references PhieuNhapXuatKho(MaPNXK)

Alter table chiNhanhSanPham 
add constraint fk_chinhanhsanpham_chinhanh 
foreign key (MaCN) references ChiNhanh(MaCN)

Alter table PhieuNhapXuatKho 
add constraint fk_phieuNhapXuatKho_chiNhanh 
foreign key (MaCN) references ChiNhanh(MaCN)

Alter table HDong 
add constraint fk_HDong_ChiNhanh 
foreign key (MaCN) references ChiNhanh(MaCN)

Alter table NhanVien 
add constraint fk_NhanVien_ChiNhanh 
foreign key (MaCN) references ChiNhanh(MaCN)

Alter table DonHang 
add constraint fk_DonHang_ChiNhanh 
foreign key (MaCN) references ChiNhanh(MaCN)

Alter table PhieuNhapXuatKho 
add constraint fk_PhieuXuatNhapKho_Kho 
foreign key (MaKho) references Kho(MaKho)

Alter table ChiTietKho 
add constraint fk_ChiTietKho_kho 
foreign key (MaKho) references Kho(MaKho)

Alter table DonHang 
add constraint fk_DonHang_Kho 
foreign key (MaKho) references Kho(MaKho)

Alter table DonHang 
add constraint fk_DonHang_NhanVien 
foreign key (MaNV) references NhanVien(MaNV)

Alter table ChiTietGioHang 
add constraint fk_ChiTietGioHang_KhachHang 
foreign key (MaKH) references KhachHang(MaKhachHang)

Alter table Comment 
add constraint fk_Comment_KhachHang 
foreign key (MaKh) references KhachHang(MaKhachHang)

Alter table KhieuNai 
add constraint fk_KhieuNai_DonHang 
foreign key (MaDH) references DonHang(MaDH)

Alter table DanhGia 
add constraint fk_DanhGia_DonHang 
foreign key (MaDH) references DonHang(MaDH)

Alter table ChiTietDonHang 
add constraint fk_ChiTietDonHang_DonHang 
foreign key (MaDH) references DonHang(MaDH)

Alter table KhuyenMaiDaNhan 
add constraint fk_KhuyenMaiDaNhan_KhuyenMai 
foreign key (MaKhuyenMai) references KhuyenMai(MaKhuyenMai)

Alter table KhuyenMaiDaNhan 
add constraint fk_KhachHang_KhuyenMai 
foreign key (MaKhachHang) references KhachHang(MaKhachHang)

Alter table ThongTinGiaoHang 
add constraint fk_ThongTinGiaoHang_KhachHang 
foreign key (MaKhachHang) references KhachHang(MaKhachHang)

Alter table DonHang 
add constraint fk_DonHang_ThongTinGiaoHang 
foreign key (MaTTGH) references ThongTinGiaoHang(MaTTGH)
