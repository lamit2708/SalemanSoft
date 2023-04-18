-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2023 at 10:49 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crmdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Id` bigint(20) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Phone` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Gender` tinyint(1) DEFAULT NULL COMMENT 'True: Male, False: Female',
  `PriorityId` int(11) DEFAULT NULL,
  `IsBought` tinyint(1) NOT NULL,
  `Keyword` varchar(512) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `CustomerSourceId` int(11) DEFAULT NULL,
  `Hobby` varchar(512) DEFAULT NULL,
  `IsMarrage` tinyint(1) DEFAULT NULL,
  `Job` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Id`, `Name`, `Phone`, `Email`, `Address`, `Gender`, `PriorityId`, `IsBought`, `Keyword`, `BirthDate`, `CustomerSourceId`, `Hobby`, `IsMarrage`, `Job`) VALUES
(1, 'Nguyễn Văn Nam', '0923232411', 'nam@gmail.com', '22 Đặng Văn Bi, TP Thủ Đức', 1, 1, 0, 'Nguyen Van Nam 0923232411 nam@gmail.com', NULL, NULL, NULL, NULL, NULL),
(2, 'Lê Thanh Hoàng', '0923232412', 'hoang@gmail.com', '32 Kha Vạn Cân, TP Thủ Đức', 1, 1, 0, 'Le Thanh Hoang 0923232412 hoang@gmail.com 32 Kha Van Can, TP Thu Duc', '1995-07-14 00:00:00', NULL, 'Thể thao', NULL, 'Giám đốc bán hàng'),
(3, 'Vũ Thị Thọ', '0923232413', 'tho@gmail.com', '32 Tô Ngọc Vân, TP Thủ Đức', 0, 2, 0, 'Vu Thi Tho 0923232413 tho@gmail.com', NULL, NULL, NULL, NULL, NULL),
(7, 'Đặng Thế Nhân', '35049843957', 'aaa@gmail.com', '12 Kha Vạn Cân, Thủ Đức', 1, 2, 0, 'Dang The Nhan 35049843957 aaa@gmail.com', NULL, NULL, NULL, NULL, NULL),
(8, 'Lê Văn Phú', '02345332565', 'phule@yahoo.com', '21 Kha Vạn Cân, Thủ Đức', 1, 2, 0, 'Le Van Phu 02345332565 phule@yahoo.com', NULL, NULL, NULL, NULL, NULL),
(11, 'Nguyễn Thành Tiến', '05434634858', 'tphat@gmail.com', '313 Quang Trung, Q12, HCM', 1, 1, 0, 'Nguyen Thanh Tien 05434634858 tphat@gmail.com', NULL, NULL, NULL, NULL, NULL),
(13, 'Nguyễn Thế Hiệp', '0350498237', 'aaa@gmail.com', '13 Kha Vạn Cân, Thủ Đức', 1, 1, 0, 'Nguyen The Hiep 0350498237 aaa@gmail.com', NULL, NULL, NULL, NULL, NULL),
(16, 'Hoàng Phi Hải', '0923232311', 'haihoang@gmail.com', '33 Tô Ngọc Vân, TP Thủ Đức', 1, 3, 0, 'Hoang Phi Hai 0923232311 haihoang@gmail.com', NULL, NULL, NULL, NULL, NULL),
(18, 'Lê Ngọc Thanh', '0923232312', 'thanhngoc@gmail.com', '32 Kha Vạn Cân, TP Thủ Đức', 0, 1, 0, 'Le Ngoc Thanh 0923232312 thanhngoc@gmail.com', NULL, NULL, NULL, NULL, NULL),
(19, 'Vũ Thị Thọ', '0923232313', 'tho@gmail.com', '32 Tô Ngọc Vân, TP Thủ Đức', 0, 2, 0, 'Vu Thi Tho 0923232313 tho@gmail.com', NULL, NULL, NULL, NULL, NULL),
(22, 'Đoàn Hoàng Nam', '0962993333', 'namdoan@gmail.com', '12 Võ Văn Ngân', 1, 1, 0, 'Doan Hoang Nam 0962993333 namdoan@gmail.com', NULL, NULL, NULL, NULL, NULL),
(23, 'Nguyễn Văn Hùng', '0434634858', 'xyz133@gmail.com', NULL, 0, NULL, 0, 'Nguyen Van Hung 0434634858 xyz133@gmail.com', '1985-08-10 00:00:00', NULL, NULL, NULL, NULL),
(25, 'Nguyễn Thị Tuyết', '0434634277', 'tuyetthi@gmail.com', '77 Lý Thường Kiệt,Q10, TP HCM', 1, 1, 0, 'Nguyen Thi Tuyet 0434634277 tuyetthi@gmail.com 77 Ly Thuong Kiet,Q10, TP HCM', '1985-08-10 00:00:00', 1, 'Công nghệ', 1, 'IT'),
(26, 'Lê Ngọc Lan', '0434634266', 'lanngoc@gmail.com', '66 Phạm Văn Đồng, TP Thủ Đức', 1, 1, 0, 'Le Ngoc Lan 0434634266 lanngoc@gmail.com 66 Pham Van Dong, TP Thu Duc', '1985-08-10 00:00:00', 1, 'Công nghệ', 1, 'IT'),
(27, 'Nguyễn Văn Nam 1', '092542342345', 'namnguyen@gmail.com', '123 đường 6 khu phố 5,Phường Linh Tây, TP Thủ Đức', 1, 1, 1, 'Nguyen Van Nam 1 092542342345 namnguyen@gmail.com 123 duong 6 khu pho 5,Phuong Linh Tay, TP Thu Duc', '1995-04-16 09:26:49', 0, 'Du lịch', 1, 'Trưởng phòng Marketing'),
(28, 'Nguyễn Ngọc Ngân', '0975634266', 'nganngoc@gmail.com', '61 Phạm Văn Đồng, TP Thủ Đức', 1, 1, 0, 'Nguyen Ngoc Ngan 0975634266 nganngoc@gmail.com 61 Pham Van Dong, TP Thu Duc', '1985-08-10 00:00:00', 1, 'shopping', 1, 'Kế toán'),
(29, 'Lê Thanh Hồng', '093322112233', 'hongthanh@gmail.com', '12 Tô Ngọc Vân, Phường Trường Thọ, TP Thủ Đức', 0, 2, 0, 'Le Thanh Hong 093322112233 hongthanh@gmail.com 12 To Ngoc Van, Phuong Truong Tho, TP Thu Duc', '1993-04-17 00:00:00', NULL, NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UQ_Phone` (`Phone`),
  ADD KEY `FK_Priority_TO_Customer` (`PriorityId`),
  ADD KEY `FK_CustomerSource_TO_CustomerInfo` (`CustomerSourceId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `FK_Priority_TO_Customer` FOREIGN KEY (`PriorityId`) REFERENCES `priority` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
