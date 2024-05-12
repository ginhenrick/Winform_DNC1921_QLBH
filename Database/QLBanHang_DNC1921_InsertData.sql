INSERT INTO CHATLIEU (TENCHATLIEU) VALUES
(N'Gỗ tự nhiên'),
(N'Gỗ công nghiệp'),
(N'MDF'),
(N'Da tự nhiên'),
(N'Da tổng hợp'),
(N'Nhựa'),
(N'Kim loại'),
(N'Kính');

INSERT INTO KHACHHANG (TENKHACH, DIACHI, SODIENTHOAI, GIOITINH, LOAIKHACHHANG, NGAYSINH) VALUES
(N'Nguyễn Văn A', N'123 Đường Lê Lợi, Quận 1, Thành phố Hồ Chí Minh', '0987654321', N'Nam', N'Cá nhân', '1990-05-15'),
(N'Phạm Thị Bảo Châu', N'456 Đường Nguyễn Huệ, Quận 3, Thành phố Hồ Chí Minh', '0123456789', N'Nữ', N'Doanh nghiệp', '1985-10-20'),
(N'Lê Văn Công', N'789 Đường Trần Hưng Đạo, Quận Hải Châu, Thành phố Đà Nẵng', '0978123456', N'Nam', N'Khách hàng tiềm năng', '2000-02-28'),
(N'Trần Thị Diệu Linh', N'101 Đường Nguyễn Công Trứ, Quận Hồng Bàng, Thành phố Hải Phòng', '0909123456', N'Nữ', N'Khách hàng thân thiết', '1995-12-10'),
(N'Hoàng Minh Đức', N'456 Đường Nguyễn Thị Minh Khai, Quận 1, Thành phố Hồ Chí Minh', '0918234567', N'Nữ', N'Cá nhân', '1988-07-05'),
(N'Đỗ Thị Hải Yến', N'789 Đường Hùng Vương, Quận Thanh Khê, Thành phố Đà Nẵng', '0987123456', N'Nam', N'Doanh nghiệp', '1979-03-18'),
(N'Trần Văn Hải', N'101 Đường Hồ Tùng Mậu, Quận Cái Răng, Thành phố Cần Thơ', '0908123456', N'Nữ', N'Khách hàng tiềm năng', '1998-11-30'),
(N'Nguyễn Thị Hoa', N'123 Đường Nguyễn Thị Minh Khai, Quận 3, Thành phố Hồ Chí Minh', '0918234567', N'Nam', N'Khách hàng thân thiết', '1992-09-25'),
(N'Lê Văn Hòa', N'456 Đường Trần Hưng Đạo, Quận Ninh Kiều, Thành phố Cần Thơ', '0978123456', N'Nam', N'Cá nhân', '1994-12-03'),
(N'Phạm Thị Kim', N'789 Đường Lê Duẩn, Quận Bình Thủy, Thành phố Cần Thơ', '0908123456', N'Nữ', N'Doanh nghiệp', '1980-08-14'),
(N'Trần Văn Long', N'101 Đường Trần Hưng Đạo, Quận Cẩm Lệ, Thành phố Đà Nẵng', '0987654321', N'Nam', N'Khách hàng tiềm năng', '1987-06-07'),
(N'Hoàng Thị Minh', N'123 Đường Lê Lợi, Quận 1, Thành phố Hồ Chí Minh', '0918123456', N'Nữ', N'Khách hàng thân thiết', '1993-04-22'),
(N'Đỗ Văn Nam', N'456 Đường Nguyễn Huệ, Quận 3, Thành phố Hồ Chí Minh', '0987234567', N'Nam', N'Cá nhân', '1986-01-17'),
(N'Lê Thị Phương', N'789 Đường Lê Lợi, Quận Thanh Khê, Thành phố Đà Nẵng', '0918234567', N'Nữ', N'Doanh nghiệp', '1975-11-09'),
(N'Nguyễn Minh Quân', N'101 Đường Nguyễn Văn Linh, Quận Liên Chiểu, Thành phố Đà Nẵng', '0978123456', N'Nam', N'Khách hàng tiềm năng', '1999-10-01'),
(N'Phạm Văn Rồng', N'123 Đường Trần Phú, Quận Ba Đình, Thành phố Hà Nội', '0909123456', N'Nữ', N'Khách hàng thân thiết', '1991-08-12'),
(N'Trần Thị Sương', N'456 Đường Hồ Tùng Mậu, Quận Cầu Giấy, Thành phố Hà Nội', '0987654321', N'Nam', N'Cá nhân', '1984-02-05'),
(N'Lê Văn Tiến', N'789 Đường Nguyễn Thị Định, Quận Hoàng Mai, Thành phố Hà Nội', '0918234567', N'Nữ', N'Doanh nghiệp', '1978-12-28'),
(N'Nguyễn Thị út', N'101 Đường Lê Lợi, Quận Hai Bà Trưng, Thành phố Hà Nội', '0908123456', N'Nữ', N'Khách hàng tiềm năng', '1983-05-16');

INSERT INTO THANHTOAN (PHUONGTHUCTHANHTOAN, GIAMGIA)
VALUES
('Tiền mặt', ROUND(RAND() * 95 + 5, 2)),
('Chuyển khoản', ROUND(RAND() * 95 + 5, 2)),
('Thẻ vật lý', ROUND(RAND() * 95 + 5, 2)),
('MOMO', ROUND(RAND() * 95 + 5, 2)),
('VN Pay', ROUND(RAND() * 95 + 5, 2));

INSERT INTO [dbo].[HANGHOANHAPKHO]
           ([TENSANPHAM]
           ,[SOLUONG]
           ,[GIANHAP]
           ,[GIABAN]
           ,[MACHATLIEU]
           ,[GHICHU]
           ,[ANH]
		   ,[MASANPHAM])
VALUES
    (N'Sofa da cao cấp phong cách Châu Âu', 100, 15000000, 19500000, 1, N'Đây là sản phẩm sofa da cao cấp phong cách Châu Âu', NULL,'SP001'),
    (N'Bàn trà gỗ sồi tự nhiên vân gỗ đẹp mắt', 80, 3000000, 3900000, 2, N'Bàn trà gỗ sồi tự nhiên vân gỗ đẹp mắt', NULL, 'SP002'),
    (N'Kệ TV hiện đại chất liệu gỗ cao cấp', 120, 5000000, 6500000, 3, N'Kệ TV hiện đại chất liệu gỗ cao cấp', NULL, 'SP001'),
    (N'Giường ngủ sang trọng gỗ công nghiệp', 90, 8000000, 10400000, 4, N'Giường ngủ sang trọng gỗ công nghiệp', NULL, 'SP001'),
    (N'Bàn làm việc MDF chống nước chất lượng cao', 110, 4000000, 5200000, 5, N'Bàn làm việc MDF chống nước chất lượng cao', NULL, 'SP001'),
    (N'Tủ quần áo gỗ tự nhiên phong cách cổ điển', 70, 12000000, 15600000, 6, N'Tủ quần áo gỗ tự nhiên phong cách cổ điển', NULL, 'SP001'),
    (N'Bộ bàn ăn gỗ tự nhiên kiểu dáng hiện đại', 85, 10000000, 13000000, 7, N'Bộ bàn ăn gỗ tự nhiên kiểu dáng hiện đại', NULL, 'SP001'),
    (N'Ghế ăn da cao cấp êm ái và thoải mái', 95, 6000000, 7800000, 8, N'Ghế ăn da cao cấp êm ái và thoải mái', NULL, 'SP001'),
    (N'Tủ giày dép gỗ công nghiệp tiện ích và đẹp mắt', 75, 3000000, 3900000, 1, N'Tủ giày dép gỗ công nghiệp tiện ích và đẹp mắt', NULL, 'SP001'),
    (N'Giường tầng gỗ tự nhiên cho trẻ em phong cách vui nhộn', 105, 9000000, 11700000, 2, N'Giường tầng gỗ tự nhiên cho trẻ em phong cách vui nhộn', NULL, 'SP001'),
    (N'Bàn trang điểm gỗ tự nhiên thiết kế tiện dụng', 65, 4500000, 5850000, 3, N'Bàn trang điểm gỗ tự nhiên thiết kế tiện dụng', NULL, 'SP001'),
    (N'Kệ sách gỗ tự nhiên tạo điểm nhấn cho không gian sống', 55, 3500000, 4550000, 4, N'Kệ sách gỗ tự nhiên tạo điểm nhấn cho không gian sống', NULL, 'SP001'),
    (N'Sofa bed gỗ công nghiệp linh hoạt và tiết kiệm không gian', 115, 8500000, 11050000, 5, N'Sofa bed gỗ công nghiệp linh hoạt và tiết kiệm không gian', NULL, 'SP001'),
    (N'Bàn học gỗ tự nhiên cho học sinh năng động', 125, 2500000, 3250000, 6, N'Bàn học gỗ tự nhiên cho học sinh năng động', NULL, 'SP001'),
    (N'Ghế gấp gọn kim loại phong cách hiện đại và tiện lợi', 85, 1500000, 1950000, 7, N'Ghế gấp gọn kim loại phong cách hiện đại và tiện lợi', NULL, 'SP001'),
    (N'Tủ rượu gỗ tự nhiên sang trọng và lịch lãm', 75, 7000000, 9100000, 8, N'Tủ rượu gỗ tự nhiên sang trọng và lịch lãm', NULL, 'SP001'),
    (N'Bàn cà phê kính tempered chống va đập, bền bỉ', 105, 4000000, 5200000, 1, N'Bàn cà phê kính tempered chống va đập, bền bỉ', NULL, 'SP001'),
    (N'Ghế massage tự nhiên giúp thư giãn sau ngày làm việc căng thẳng', 95, 10000000, 13000000, 2, N'Ghế massage tự nhiên giúp thư giãn sau ngày làm việc căng thẳng', NULL, 'SP001'),
    (N'Ghế phòng chờ nhựa đẹp và dễ dàng vệ sinh', 110, 2000000, 2600000, 3, N'Ghế phòng chờ nhựa đẹp và dễ dàng vệ sinh', NULL, 'SP001'),
    (N'Bàn ăn kính tempered hiện đại và đẳng cấp', 85, 7000000, 9100000, 4, N'Bàn ăn kính tempered hiện đại và đẳng cấp', NULL, 'SP001'),
    (N'Bộ bàn ăn kính tempered sang trọng và đẳng cấp', 95, 12000000, 15600000, 5, N'Bộ bàn ăn kính tempered sang trọng và đẳng cấp', NULL, 'SP001'),
    (N'Tủ sách nhựa tiện dụng và đa năng', 105, 2500000, 3250000, 6, N'Tủ sách nhựa tiện dụng và đa năng', NULL, 'SP001'),
    (N'Ghế thư giãn nhựa linh hoạt và thoải mái', 115, 1500000, 1950000, 7, N'Ghế thư giãn nhựa linh hoạt và thoải mái', NULL, 'SP001'),
    (N'Tủ quần áo nhựa đa năng và tiện ích', 125, 3000000, 3900000, 8, N'Tủ quần áo nhựa đa năng và tiện ích', NULL, 'SP001'),
    (N'Kệ TV nhựa đơn giản và hiện đại', 55, 3500000, 4550000, 1, N'Kệ TV nhựa đơn giản và hiện đại', NULL, 'SP001'),
    (N'Bàn làm việc nhựa phong cách và tiện ích', 75, 2000000, 2600000, 2, N'Bàn làm việc nhựa phong cách và tiện ích', NULL, 'SP001'),
    (N'Ghế ăn nhựa dễ dàng vệ sinh và bảo quản', 85, 1000000, 1300000, 3, N'Ghế ăn nhựa dễ dàng vệ sinh và bảo quản', NULL, 'SP001'),
    (N'Bàn trà nhựa tiện lợi và đa năng', 95, 1500000, 1950000, 4, N'Bàn trà nhựa tiện lợi và đa năng', NULL, 'SP001'),
    (N'Ghế sofa nhựa phong cách và tiện lợi', 105, 3000000, 3900000, 5, N'Ghế sofa nhựa phong cách và tiện lợi', NULL, 'SP001'),
    (N'Tủ giày dép nhựa đa năng và tiện ích', 115, 2000000, 2600000, 6, N'Tủ giày dép nhựa đa năng và tiện ích', NULL, 'SP001'),
    (N'Bàn học nhựa cho học sinh năng động', 125, 1200000, 1560000, 7, N'Bàn học nhựa cho học sinh năng động', NULL, 'SP001'),
    (N'Bàn ăn gỗ tự nhiên phong cách hiện đại', 85, 10000000, 13000000, 8, N'Bàn ăn gỗ tự nhiên phong cách hiện đại', NULL, 'SP001'),
    (N'Bàn trà gỗ sồi tự nhiên chất lượng cao', 95, 5000000, 6500000, 1, N'Bàn trà gỗ sồi tự nhiên chất lượng cao', NULL, 'SP001'),
    (N'Kệ TV gỗ công nghiệp thiết kế đẹp mắt', 105, 7000000, 9100000, 2, N'Kệ TV gỗ công nghiệp thiết kế đẹp mắt', NULL, 'SP001'),
    (N'Giường ngủ gỗ tự nhiên phong cách hiện đại', 115, 8000000, 10400000, 3, N'Giường ngủ gỗ tự nhiên phong cách hiện đại', NULL, 'SP001'),
    (N'Bàn làm việc MDF chất lượng cao và bền bỉ', 125, 4000000, 5200000, 4, N'Bàn làm việc MDF chất lượng cao và bền bỉ', NULL, 'SP001'),
    (N'Tủ quần áo gỗ tự nhiên phong cách cổ điển', 55, 12000000, 15600000, 5, N'Tủ quần áo gỗ tự nhiên phong cách cổ điển', NULL, 'SP001'),
    (N'Bộ bàn ăn gỗ tự nhiên thiết kế đẹp và tiện ích', 65, 10000000, 13000000, 6, N'Bộ bàn ăn gỗ tự nhiên thiết kế đẹp và tiện ích', NULL, 'SP001'),
    (N'Ghế ăn da cao cấp êm ái và thoải mái', 75, 6000000, 7800000, 7, N'Ghế ăn da cao cấp êm ái và thoải mái', NULL, 'SP001'),
    (N'Tủ giày dép gỗ công nghiệp tiện lợi và đẹp mắt', 85, 3000000, 3900000, 8, N'Tủ giày dép gỗ công nghiệp tiện lợi và đẹp mắt', NULL, 'SP001'),
    (N'Giường tầng gỗ tự nhiên cho trẻ em phong cách vui nhộn', 95, 9000000, 11700000, 1, N'Giường tầng gỗ tự nhiên cho trẻ em phong cách vui nhộn', NULL, 'SP001'),
    (N'Bàn trang điểm gỗ tự nhiên thiết kế tiện dụng', 105, 4500000, 5850000, 2, N'Bàn trang điểm gỗ tự nhiên thiết kế tiện dụng', NULL, 'SP001'),
    (N'Kệ sách gỗ tự nhiên đẹp mắt và tiện ích', 115, 3500000, 4550000, 3, N'Kệ sách gỗ tự nhiên đẹp mắt và tiện ích', NULL, 'SP001'),
    (N'Sofa bed gỗ công nghiệp linh hoạt và tiết kiệm không gian', 125, 8500000, 11050000, 4, N'Sofa bed gỗ công nghiệp linh hoạt và tiết kiệm không gian', NULL, 'SP001'),
    (N'Bàn học gỗ tự nhiên cho học sinh năng động', 55, 2500000, 3250000, 5, N'Bàn học gỗ tự nhiên cho học sinh năng động', NULL, 'SP001'),
    (N'Ghế gấp gọn kim loại phong cách hiện đại và tiện lợi', 75, 1500000, 1950000, 6, N'Ghế gấp gọn kim loại phong cách hiện đại và tiện lợi', NULL, 'SP001'),
    (N'Tủ rượu gỗ tự nhiên sang trọng và lịch lãm', 85, 7000000, 9100000, 7, N'Tủ rượu gỗ tự nhiên sang trọng và lịch lãm', NULL, 'SP001'),
    (N'Bàn cà phê kính tempered chống va đập, bền bỉ', 95, 4000000, 5200000, 8, N'Bàn cà phê kính tempered chống va đập, bền bỉ', NULL, 'SP001'),
    (N'Ghế massage tự nhiên giúp thư giãn sau ngày làm việc căng thẳng', 105, 10000000, 13000000, 1, N'Ghế massage tự nhiên giúp thư giãn sau ngày làm việc căng thẳng', NULL, 'SP001'),
    (N'Ghế phòng chờ nhựa đẹp và dễ dàng vệ sinh', 115, 2000000, 2600000, 2, N'Ghế phòng chờ nhựa đẹp và dễ dàng vệ sinh', NULL, 'SP001');

