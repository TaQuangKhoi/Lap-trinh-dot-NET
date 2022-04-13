INSERT KHOA 
VALUES
('CNTT', 'Khoa Ky thuat va Cong nghe'),
('NNXH', 'Khoa Ngon ngu va Khoa hoc xa hoi'),
('KTLL', 'Khoa Kinh te - Luat - Logistics'),


INSERT LOP
VALUES
('20LT', 'Lop Lap trinh ung dung di dong va game 2020', 'CNTT'),
('20CT', 'Lop Cong nghe thing tin 2020', 'CNTT'),
('20TQ', 'Lop Ngon ngu Trung Quoc', 'NNXH')

-- Has Run ?

INSERT SINHVIEN
VALUES
('20035435', N'T? Quang Khôi')

-- UPDATE
UPDATE KHOA
SET TenKhoa = 'Khoa hoc may tinh'
WHERE MaKhoa = 'CNTT' --Teacher ask name is Cong nghe thong tin or Khoa hoc may tinh

-- DELETE
DELETE FROM KHOA WHERE MaKhoa = 'NNXH'

--13:34 
INSERT KHOA
VALUES
('CNTP', 'Khoa Cong nghe thuc pham')

