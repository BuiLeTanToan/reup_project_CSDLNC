-- Lấy thông tin sản phẩm => hiển thị
SELECT * FROM SANPHAM

-- Thêm sản phẩm
INSERT INTO SANPHAM VALUES ('"+tb_MaSP.Text+"', '"+tb_TenSP.Text+"', "'+tb_GiaSP.Text+'", "'+tb_MoTaSP.Text+'", "+tb_LoaiSP.Text+");

-- Cập nhật sản phẩm
UPDATE SANPHAM
SET TenSP='"+tb_TenSP.Text+"', 
GiaSP = '"+tb_GiaSP.Text+"',
MoTaSP='"+tb_MoTaSP.Text+"',
LoaiSP='"+tb_MoTaSP.Text+"'
WHERE MaSP='"+tb_MaSP.Text+"'

-- Xóa sản phẩm
DELETE FROM SANPHAM
WHERE MaSP = '"+tb_MaSP.Text+"'

-- Theo dõi hàng tồn kho
SELECT K.MaKho, K.TenKho, K.DiaChiKho, CT.MaSp, CT.SoLuong FROM KHO K JOIN CHITIETKHO CT ON K.MaKho = CT.MaKho
WHERE K.MaKho = '"tb_MaKho.Text"';

-- Theo dõi lịch sử nhập hàng
SELECT K.MaKho, K.MaCN, CT.MaSP, CT.SoLuong, CT.DonGia FROM KHO K JOIN ChiTietPNXK CT ON K.MaPNXK = CT.MaPNXK
WHERE K.MaPNXK = '"tb_MaNhapXuatKho.Text"' AND K.Loai = 0

-- Theo dõi lịch sử xuất hàng
SELECT K.MaKho, K.MaCN, CT.MaSP, CT.SoLuong, CT.DonGia FROM KHO K JOIN ChiTietPNXK CT ON K.MaPNXK = CT.MaPNXK
WHERE K.MaPNXK = '"tb_MaNhapXuatKho.Text"' AND K.Loai = 1