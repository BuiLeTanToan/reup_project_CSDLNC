--load danh sach nhan vien tu DB
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', nv.SdtNV as N'Số điện thoại', nv.DiaChiNV as N'Địa chỉ', nv.GioiTinhNV as N'Giới tính', nv.SoCMNDNV as N'Số CMND/CCCD', nv.SoTKNV as N'Số tài khoản', nv.MaCN as N'Mã chi nhánh' FROM NhanVien nv
--tra cuu nhan vien theo ma nhan vien
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', nv.SdtNV as N'Số điện thoại', nv.DiaChiNV as N'Địa chỉ', nv.GioiTinhNV as N'Giới tính', nv.SoCMNDNV as N'Số CMND/CCCD', nv.SoTKNV as N'Số tài khoản', nv.MaCN as N'Mã chi nhánh' FROM NhanVien nv WHERE nv.MaNV = @manv
--insert them nhan vien
INSERT INTO NhanVien(TenNV, SdtNV, DiaChiNV, GioiTinhNV, SoCMNDNV, SoTKNV, MaCN) VALUES ('" + tenNhanVien.Text + "', '" + SoDT.Text + "', '" + diaChi.Text + "', '" + gioiTinh.Text + "', '" + CMND.Text + "', '" + STK.Text + "', '" + maChiNhanh.Text + "')
--xoa nhan vien
DELETE FROM NhanVien WHERE MaNV = @manv
--update nhan vien
UPDATE NhanVien SET TenNV = '" + tenNhanVien.Text + "', SdtNV = '" + SoDT.Text + "', DiaChiNV = '" + diaChi.Text + "', GioiTinhNV = '" + gioiTinh.Text + "', SoCMNDNV = '" + CMND.Text + "', SoTKNV =  '" + STK.Text + "', MaCN = '" + maChiNhanh.Text + "' WHERE MaNV = '" + maNhanVien.Text + "'
--load nhan vien va tinh luong cua nhan vien
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM((dh.TongTienDH * 0.1) + 6000000) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV GROUP BY nv.MaNV, nv.TenNV
--search luong theo ma nhan vien
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM((dh.TongTienDH * 0.1) + 6000000) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV and dh.MaNV = @manv GROUP BY nv.MaNV, nv.TenNV
--load nhan vien va tinh doanh thu cua nhan vien
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM(dh.TongTienDH) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV GROUP BY nv.MaNV, nv.TenNV
--search doanh thu theo ma nhan vien
SELECT nv.MaNV as N'Mã nhân viên', nv.TenNV as N'Tên nhân viên', SUM(dh.TongTienDH) as N'Doanh Thu' FROM NhanVien nv, DonHang dh WHERE dh.MaNV = nv.MaNV AND nv.MaNV = @maNV GROUP BY nv.MaNV, nv.TenNV
--load danh sach cac don hang bang ma nhan vien
SELECT * FROM DonHang dh where dh.MaNV = @maNV
--load danh sach cac chi tiet don hang bang ma don hang
SELECT * FROM ChiTietDonHang ct where ct.MaDH = @madh