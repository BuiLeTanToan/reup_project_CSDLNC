--Xem danh sach don hang cua  chi nhanh
select d.*
from DonHang d
where d.MaCN=@MaCN
-- Xem danh sach cac don dat hang chi tiet cua cac don hang trong Chi nhanh
select ct.*
from ChiTietDonHang ct, DonHang d
where d.MaCN=@MaCN and d.MaDH = ct.MaDH
-- Thong ke doanh thu theo chi nhanh
SELECT c.MaCN as N'Mã chi nhanh', c.TenCN as N'Tên chi nhanh', SUM(dh.TongTienDH) as N'Doanh Thu' 
FROM ChiNhanh c, DonHang dh 
WHERE dh.MaCN = c.MaCN AND c.MaCN = @MaCN 
GROUP BY c.MaCN, c.TenCN
-- Xem danh sach cac chi nhanh cua he thong
select c.*
from ChiNhanh c
where c.MaCN=@MaCN

-- Them thong tin khuyen mai
INSERT INTO KhuyenMai 
VALUES ('" + MaKhuyenMai.Text + "', '" + NgayBatDauKM.Text + "', '" + NgayKetThucKM.Text + "', '" + SoTienGiam.Text + "')

-- Xem danh sach khieu nai theo chi nhanh
select k.*
from KhieuNai k, DonHang d
where d.MaCN=@MaCN and d.MaKN = k.MaKN

-- Xem danh sach Comment theo san pham
select c.*
from Comment c, 
where c.MaSP=@MaSP