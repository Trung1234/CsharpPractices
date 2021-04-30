Use TrungNT65
GO
--1. Xuất ra thông tin giáo viên và Giáo viên quản lý chủ nhiệm của người đó
SELECT GV1.MAGV,GV1.HOTEN,GV2.HOTEN AS 'GVQLCN' FROM GIAOVIEN AS GV1, GIAOVIEN AS GV2 WHERE GV1.GVQLCM = GV2.MAGV
GO
--2. Xuất ra số lượng giáo viên của khoa CNTT
SELECT COUNT(*) FROM GIAOVIEN AS GV, BOMON AS BM, KHOA AS K 
WHERE GV.MABM = BM.MABM AND BM.MAKHOA = K.MAKHOA AND K.MAKHOA = 'CNTT'
GO
--3. Xuất ra thông tin giáo viên và đề tài người đó tham gia khi mà kết quả là đạt
SELECT GV.*, TG.KETQUA FROM GIAOVIEN AS GV, THAMGIADT AS TG WHERE GV.MAGV = TG.MAGV AND TG.KETQUA LIKE N'%t'