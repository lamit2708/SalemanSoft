-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 06, 2023 at 12:02 PM
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
-- Table structure for table `activity`
--

CREATE TABLE `activity` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Content` varchar(512) NOT NULL,
  `ActivityType` varchar(100) NOT NULL,
  `Date` datetime DEFAULT NULL,
  `From` datetime DEFAULT NULL,
  `To` datetime DEFAULT NULL,
  `ToWho` varchar(100) DEFAULT NULL,
  `SubType` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `anwser`
--

CREATE TABLE `anwser` (
  `Id` bigint(20) NOT NULL,
  `Content` varchar(512) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `UserId` int(11) NOT NULL,
  `QuestionId` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  `CustomerInfoId` bigint(20) DEFAULT NULL,
  `IsBought` tinyint(1) NOT NULL,
  `Keyword` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Id`, `Name`, `Phone`, `Email`, `Address`, `Gender`, `PriorityId`, `CustomerInfoId`, `IsBought`, `Keyword`) VALUES
(1, 'Nguyễn Văn Nam 1', '0923232411', 'nam@gmail.com', '22 Đặng Văn Bi, TP Thủ Đức', 1, 1, NULL, 0, 'Nguyen Van Nam 1 0923232411 nam@gmail.com'),
(2, 'Lê Thanh Hoàng', '0923232412', 'hoang@gmail.com', '32 Kha Vạn Cân, TP Thủ Đức', 1, 1, NULL, 0, 'Le Thanh Hoang 0923232412 hoang@gmail.com'),
(3, 'Vũ Thị Thọ', '0923232413', 'tho@gmail.com', '32 Tô Ngọc Vân, TP Thủ Đức', 0, 2, NULL, 0, 'Vu Thi Tho 0923232413 tho@gmail.com'),
(7, 'Đặng Thế Nhân1', '35049843957', 'aaa@gmail.com', NULL, NULL, NULL, NULL, 0, 'Dang The Nhan1 35049843957 aaa@gmail.com'),
(8, 'Lê Vũ Lâm1', '02345332565', 'abc@yahoo.com', NULL, NULL, NULL, NULL, 0, 'Le Vu Lam1 02345332565 abc@yahoo.com'),
(11, 'Nguyễn Tấn Phát2', '5434634858', 'xyz133@gmail.com', NULL, NULL, NULL, NULL, 0, 'Nguyen Tan Phat2 5434634858 xyz133@gmail.com'),
(13, 'Đặng Thế Nhân 11', '0350498237', 'aaa@gmail.com', NULL, NULL, NULL, NULL, 0, NULL),
(16, 'Đặng Thế Nhân', '0923232311', 'aaa@gmail.com', NULL, NULL, NULL, NULL, 0, 'Dang The Nhan 0923232311 aaa@gmail.com'),
(18, 'Lê Vũ Lâm', '0923232312', 'lam@gmail.com', '32 Kha Vạn Cân, TP Thủ Đức', 1, 1, NULL, 0, 'Le Vu Lam 0923232312 lam@gmail.com'),
(19, 'Vũ Thị Thọ', '0923232313', 'tho@gmail.com', '32 Tô Ngọc Vân, TP Thủ Đức', 0, 2, NULL, 0, 'Vu Thi Tho 0923232313 tho@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `customerinfo`
--

CREATE TABLE `customerinfo` (
  `Id` bigint(20) NOT NULL,
  `CustomerSourceId` int(11) DEFAULT NULL,
  `Hobby` varchar(512) DEFAULT NULL,
  `Job` varchar(100) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `IsMarrage` tinyint(1) DEFAULT NULL,
  `Charater` varchar(100) DEFAULT NULL,
  `Income` varchar(100) DEFAULT NULL,
  `Evaluate` varchar(100) DEFAULT NULL,
  `Type` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customersource`
--

CREATE TABLE `customersource` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `deal`
--

CREATE TABLE `deal` (
  `Id` bigint(20) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `CustomerId` bigint(20) NOT NULL,
  `DealStepId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `OrderId` int(11) DEFAULT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Description` varchar(512) DEFAULT NULL,
  `PridictPrice` double NOT NULL,
  `DateFor` datetime DEFAULT NULL,
  `PricePossible` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dealactivity`
--

CREATE TABLE `dealactivity` (
  `Id` int(11) NOT NULL,
  `DealId` bigint(20) NOT NULL,
  `ActivityId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dealquotation`
--

CREATE TABLE `dealquotation` (
  `Id` bigint(20) NOT NULL,
  `DealId` bigint(20) NOT NULL,
  `ProductId` int(11) NOT NULL,
  `Quatitty` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dealstep`
--

CREATE TABLE `dealstep` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dealstephistory`
--

CREATE TABLE `dealstephistory` (
  `Id` bigint(20) NOT NULL,
  `DealStepId` int(11) NOT NULL,
  `DateTime` datetime NOT NULL,
  `UserId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `Id` int(11) NOT NULL,
  `CustomerId` bigint(20) NOT NULL,
  `UserId` int(11) NOT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `EditedUserId` int(11) DEFAULT NULL,
  `EditedDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `priority`
--

CREATE TABLE `priority` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `priority`
--

INSERT INTO `priority` (`Id`, `Name`, `Description`) VALUES
(1, 'Cao', ''),
(2, 'Trung bình', ''),
(3, 'Thấp', '');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Price` double NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 0,
  `Description` varchar(512) DEFAULT NULL,
  `CategoryId` int(11) NOT NULL,
  `Keyword` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Id`, `Name`, `Price`, `Quantity`, `Description`, `CategoryId`, `Keyword`) VALUES
(1, 'Hệ thống quản lý nhân viên, chấm công', 200000000, 1, 'Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.', 1, 'He thong quan ly nhan vien, cham cong He thong giup thu thap, giai quyet, luu tru, truyen dat, phan phoi cac thong tin co lien quan den nguon nhan luc trong cong ty de ho tro cho viec ra quyet dinh.'),
(2, 'Hệ thống chăm sóc khách hàng', 100000000, 1, 'Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.', 1, 'He thong cham soc khach hang He thong CRM nhu mot kho luu tru duy nhat de ket hop cac hoat dong ban hang, tiep thi, ho tro khach hang, giup hop ly hoa quy trinh, chinh sach va nhan luc trong mot nen tang.'),
(3, 'Hệ thống quản lý phòng trọ', 20000000, 1, 'Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).', 1, 'He thong quan ly phong tro Moi thong tin ve khach thue tro chi tiet co the luu tru khi su dung phan mem quan ly nha tro. Tu thong tin ca nhan toi hop dong cho thue (gia ca, phi dich vu, thoi gian, tien coc, so nguoi o…).'),
(4, 'Hệ thống quản lý trung tâm ngoại ngữ', 20000000, 1, 'Phần mềm quản lý giúp ban lãnh đạo có thể nắm bắt được tình hình trung tâm, tình trạng học viên, đưa ra cái nhìn tổng quan cho chất lượng giảng dạy của các giảng viên.', 1, 'He thong quan ly trung tam ngoai ngu Phan mem quan ly giup ban lanh dao co the nam bat duoc tinh hinh trung tam, tinh trang hoc vien, dua ra cai nhin tong quan cho chat luong giang day cua cac giang vien.'),
(5, 'Hệ thống quản lý quán cà phê', 20000000, 1, 'Phần mềm quản lý quán cafe giúp tính tiền, quản lý kho, quản lý dữ liệu khách hàng, quản lý nhân viên.', 1, 'He thong quan ly quan ca phe Phan mem quan ly quan cafe giup tinh tien, quan ly kho, quan ly du lieu khach hang, quan ly nhan vien.'),
(6, 'Hệ thống quản lý nhà hàng', 100000000, 1, 'Phần mềm quản lý bàn, hỗ trợ in bếp, quản lý nhân viên, quản lý kho', 1, 'He thong quan ly nha hang Phan mem quan ly ban, ho tro in bep, quan ly nhan vien, quan ly kho'),
(7, 'Thiết kế website bất động sản', 50000000, 1, 'Website bất động sản là 1 hệ thống hỗ trợ trong các chiến lược marketing online, và là công cụ bán hàng đơn giản, hiệu quả.', 2, 'Thiet ke website bat dong san Website bat dong san la 1 he thong ho tro trong cac chien luoc marketing online, va la cong cu ban hang don gian, hieu qua.'),
(8, 'Thiết kế website Forum, tin tức, rao vặt', 15000000, 1, 'Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử', 2, 'Thiet ke website Forum, tin tuc, rao vat Ho tro nang cap cai tien cac chuc nang cua he thong thuong mai dien tu'),
(9, 'Thiết kế website thương mại điện tử', 20000000, 1, 'Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử', 2, 'Thiet ke website thuong mai dien tu Ho tro nang cap cai tien cac chuc nang cua he thong thuong mai dien tu'),
(10, 'Thiết kế website quản trị, giới thiệu doanh nghiệp', 20000000, 1, 'Website giới thiệu sản phẩm, dịch vụ, nhân sự, thế mạnh công ty, giúp quảng bá thương hiệu và tìm khách hàng hiệu quả', 2, 'Thiet ke website quan tri, gioi thieu doanh nghiep Website gioi thieu san pham, dich vu, nhan su, the manh cong ty, giup quang ba thuong hieu va tim khach hang hieu qua'),
(11, 'App thanh toán ví điện tử', 100000000, 1, 'App liên kết với nhiều ngân hàng tại Việt Nam và bạn dễ dàng nạp tiền vào ví một cách đơn giản và nhanh chóng, giúp nạp nạp thẻ điện thoại, thanh toán tiền điện nước, mua sắm online,...', 3, 'App thanh toan vi dien tu App lien ket voi nhieu ngan hang tai Viet Nam va ban de dang nap tien vao vi mot cach don gian va nhanh chong, giup nap nap the dien thoai, thanh toan tien dien nuoc, mua sam online,...'),
(12, 'App đặt vé du lịch', 20000000, 1, 'App đặt vé máy bay, vé tàu, xe; Đặt phòng khách sạn, homestay tuỳ thích; Đặt dịch vụ đưa đón sân bay; Đặt các vé tham quan với mức giá ưu đãi; Đặt tour du lịch chuyên nghiệp nâng cao trải nghiệm người dùng…', 3, 'App dat ve du lich App dat ve may bay, ve tau, xe; Dat phong khach san, homestay tuy thich; Dat dich vu dua don san bay; Dat cac ve tham quan voi muc gia uu dai; Dat tour du lich chuyen nghiep nang cao trai nghiem nguoi dung…'),
(13, 'Nâng cấp hệ thống ERP', 100000000, 1, 'Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống ERP', 4, 'Nang cap he thong ERP Ho tro nang cap cai tien cac chuc nang cua he thong ERP'),
(14, 'Nâng cấp hệ thống CRM', 50000000, 1, 'Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống CRM', 4, 'Nang cap he thong CRM Ho tro nang cap cai tien cac chuc nang cua he thong CRM'),
(15, 'Nâng cấp hệ thống thương mại điện tử', 50000000, 1, 'Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử', 4, 'Nang cap he thong thuong mai dien tu Ho tro nang cap cai tien cac chuc nang cua he thong thuong mai dien tu'),
(16, 'Dịch vụ SEO', 3000000, 1, 'Cung cấp dịch vụ SEO tổng thể chuyên nghiệp. Phục vụ chủ yếu đối tượng khách hàng là công ty, doanh nghiệp lớn, vừa & nhỏ (SME) tại HCM & toàn quốc', 5, 'Dich vu SEO Cung cap dich vu SEO tong the chuyen nghiep. Phuc vu chu yeu doi tuong khach hang la cong ty, doanh nghiep lon, vua & nho (SME) tai HCM & toan quoc'),
(17, 'Dịch vụ chạy quảng cáo Youtube, Facebook, Google Ads', 4000000, 1, 'Thực hiện hoạt động các hoạt động quảng cáo Digital Marketing trên các kênh YouTube, Facebook, Google Ads sẽ giúp các doanh nghiệp tiếp cận đông đảo khách hàng tiềm năng.', 5, 'Dich vu chay quang cao Youtube, Facebook, Google Ads Thuc hien hoat dong cac hoat dong quang cao Digital Marketing tren cac kenh YouTube, Facebook, Google Ads se giup cac doanh nghiep tiep can dong dao khach hang tiem nang.'),
(18, 'Quản trị nội dung, viết bài', 5000000, 1, 'Content Marketing là quá trình tạo ra và chia sẻ những nội dung có ý nghĩa một cách liên tục đến một đối tượng cụ thể, để đạt được mục tiêu tiếp thị theo từng giai đoạn khác nhau của doanh nghiệp.', 5, 'Quan tri noi dung, viet bai Content Marketing la qua trinh tao ra va chia se nhung noi dung co y nghia mot cach lien tuc den mot doi tuong cu the, de dat duoc muc tieu tiep thi theo tung giai doan khac nhau cua doanh nghiep.'),
(60, 'Hệ thống quản lý nhân viên, chấm công 111', 200000000, 1, 'Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.', 1, 'He thong quan ly nhan vien, cham cong 111 He thong giup thu thap, giai quyet, luu tru, truyen dat, phan phoi cac thong tin co lien quan den nguon nhan luc trong cong ty de ho tro cho viec ra quyet dinh.');

-- --------------------------------------------------------

--
-- Table structure for table `productcategory`
--

CREATE TABLE `productcategory` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `productcategory`
--

INSERT INTO `productcategory` (`Id`, `Name`) VALUES
(1, 'Xây dựng hệ thống quản lý'),
(2, 'Thiết kế website'),
(3, 'Thiết kế ứng dụng mobile'),
(4, 'Nâng cấp hệ thống'),
(5, 'Dịch vụ Marketing Online');

-- --------------------------------------------------------

--
-- Table structure for table `productorder`
--

CREATE TABLE `productorder` (
  `Id` int(11) NOT NULL,
  `OrderId` int(11) NOT NULL,
  `ProductId` int(11) NOT NULL,
  `Quatity` int(11) NOT NULL,
  `UnitPrice` double NOT NULL,
  `ChangePrice` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `productquotation`
--

CREATE TABLE `productquotation` (
  `Id` int(11) NOT NULL,
  `ProductId` int(11) NOT NULL,
  `Price` double NOT NULL,
  `From` datetime NOT NULL,
  `To` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `Id` bigint(20) NOT NULL,
  `Description` varchar(512) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `TicketId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `survey`
--

CREATE TABLE `survey` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) DEFAULT NULL,
  `CreatedUser` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `surveycontent`
--

CREATE TABLE `surveycontent` (
  `Id` int(11) NOT NULL,
  `SurveyId` int(11) NOT NULL,
  `Question` varchar(100) NOT NULL,
  `Answer` varchar(100) DEFAULT NULL,
  `From` int(11) DEFAULT NULL,
  `To` int(11) DEFAULT NULL,
  `Score` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `surveyresult`
--

CREATE TABLE `surveyresult` (
  `Id` int(11) NOT NULL,
  `SurveyId` int(11) NOT NULL,
  `From` int(11) NOT NULL,
  `To` int(11) DEFAULT NULL,
  `Score` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `task`
--

CREATE TABLE `task` (
  `Id` int(11) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `Content` varchar(512) NOT NULL,
  `CreatedUser` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `From` datetime NOT NULL,
  `To` datetime NOT NULL,
  `TaskStatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `taskcustomer`
--

CREATE TABLE `taskcustomer` (
  `Id` int(11) NOT NULL,
  `TaskId` int(11) NOT NULL,
  `UserRelated` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `taskdeal`
--

CREATE TABLE `taskdeal` (
  `Id` int(11) NOT NULL,
  `TaskId` int(11) NOT NULL,
  `DealRelated` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `taskstatus`
--

CREATE TABLE `taskstatus` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `taskuser`
--

CREATE TABLE `taskuser` (
  `Id` int(11) NOT NULL,
  `TaskId` int(11) NOT NULL,
  `UserRelated` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `team`
--

CREATE TABLE `team` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `CustomerId` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Phone` varchar(100) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `TeamId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usercustomer`
--

CREATE TABLE `usercustomer` (
  `Id` int(11) NOT NULL,
  `CustomerId` bigint(20) NOT NULL,
  `UserId` int(11) DEFAULT NULL,
  `TeamId` int(11) NOT NULL,
  `CreatedDateTeam` datetime NOT NULL,
  `CreatedDateUser` datetime NOT NULL,
  `IsAccept` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `userrole`
--

CREATE TABLE `userrole` (
  `RoleId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230316090937_init', '7.0.2'),
('20230316091926_add_customer_keyword_column', '7.0.2'),
('20230320094013_init', '7.0.2'),
('20230320095001_addKeywordProduct', '7.0.2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activity`
--
ALTER TABLE `activity`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_User_TO_Activity` (`CreatedUser`);

--
-- Indexes for table `anwser`
--
ALTER TABLE `anwser`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_User_TO_Anwser` (`UserId`),
  ADD KEY `FK_Question_TO_Anwser` (`QuestionId`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UQ_Phone` (`Phone`),
  ADD KEY `FK_Priority_TO_Customer` (`PriorityId`),
  ADD KEY `FK_CustomerInfo_TO_Customer` (`CustomerInfoId`);

--
-- Indexes for table `customerinfo`
--
ALTER TABLE `customerinfo`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_CustomerSource_TO_CustomerInfo` (`CustomerSourceId`);

--
-- Indexes for table `customersource`
--
ALTER TABLE `customersource`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UQ_Name` (`Name`);

--
-- Indexes for table `deal`
--
ALTER TABLE `deal`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Customer_TO_Deal` (`CustomerId`),
  ADD KEY `FK_DealStep_TO_Deal` (`DealStepId`),
  ADD KEY `FK_User_TO_Deal` (`UserId`),
  ADD KEY `FK_Order_TO_Deal` (`OrderId`);

--
-- Indexes for table `dealactivity`
--
ALTER TABLE `dealactivity`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Activity_TO_DealActivity` (`ActivityId`),
  ADD KEY `FK_Deal_TO_DealActivity` (`DealId`);

--
-- Indexes for table `dealquotation`
--
ALTER TABLE `dealquotation`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Product_TO_DealQuotation` (`ProductId`),
  ADD KEY `FK_Deal_TO_DealQuotation` (`DealId`),
  ADD KEY `FK_User_TO_DealQuotation` (`UserId`);

--
-- Indexes for table `dealstep`
--
ALTER TABLE `dealstep`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `dealstephistory`
--
ALTER TABLE `dealstephistory`
  ADD KEY `FK_Deal_TO_DealStepHistory` (`Id`),
  ADD KEY `FK_DealStep_TO_DealStepHistory` (`DealStepId`),
  ADD KEY `FK_User_TO_DealStepHistory` (`UserId`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Customer_TO_Order` (`CustomerId`),
  ADD KEY `FK_User_TO_Order` (`UserId`),
  ADD KEY `FK_User_TO_Order1` (`EditedUserId`);

--
-- Indexes for table `priority`
--
ALTER TABLE `priority`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_ProductCategory_TO_Product` (`CategoryId`);

--
-- Indexes for table `productcategory`
--
ALTER TABLE `productcategory`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `productorder`
--
ALTER TABLE `productorder`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Order_TO_ProductOrder` (`OrderId`),
  ADD KEY `FK_Product_TO_ProductOrder` (`ProductId`);

--
-- Indexes for table `productquotation`
--
ALTER TABLE `productquotation`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Product_TO_ProductQuotation` (`ProductId`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Ticket_TO_Question` (`TicketId`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `survey`
--
ALTER TABLE `survey`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_User_TO_Survey` (`CreatedUser`);

--
-- Indexes for table `surveycontent`
--
ALTER TABLE `surveycontent`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Survey_TO_SurveyContent` (`SurveyId`);

--
-- Indexes for table `surveyresult`
--
ALTER TABLE `surveyresult`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Survey_TO_SurveyResult` (`SurveyId`);

--
-- Indexes for table `task`
--
ALTER TABLE `task`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_User_TO_Task` (`CreatedUser`),
  ADD KEY `FK_TaskStatus_TO_Task` (`TaskStatus`);

--
-- Indexes for table `taskcustomer`
--
ALTER TABLE `taskcustomer`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Task_TO_TaskCustomer` (`TaskId`),
  ADD KEY `FK_User_TO_TaskCustomer` (`UserRelated`);

--
-- Indexes for table `taskdeal`
--
ALTER TABLE `taskdeal`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Task_TO_TaskDeal` (`TaskId`),
  ADD KEY `FK_Deal_TO_TaskDeal` (`DealRelated`);

--
-- Indexes for table `taskstatus`
--
ALTER TABLE `taskstatus`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `taskuser`
--
ALTER TABLE `taskuser`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Task_TO_TaskUser` (`TaskId`),
  ADD KEY `FK_User_TO_TaskUser` (`UserRelated`);

--
-- Indexes for table `team`
--
ALTER TABLE `team`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UQ_Name` (`Name`),
  ADD KEY `FK_Customer_TO_Ticket` (`CustomerId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Team_TO_User` (`TeamId`);

--
-- Indexes for table `usercustomer`
--
ALTER TABLE `usercustomer`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Customer_TO_UserCustomer` (`CustomerId`),
  ADD KEY `FK_User_TO_UserCustomer` (`UserId`),
  ADD KEY `FK_Team_TO_UserCustomer` (`TeamId`);

--
-- Indexes for table `userrole`
--
ALTER TABLE `userrole`
  ADD KEY `FK_Role_TO_UserRole` (`RoleId`),
  ADD KEY `FK_User_TO_UserRole` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activity`
--
ALTER TABLE `activity`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `anwser`
--
ALTER TABLE `anwser`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `customerinfo`
--
ALTER TABLE `customerinfo`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customersource`
--
ALTER TABLE `customersource`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `deal`
--
ALTER TABLE `deal`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `dealactivity`
--
ALTER TABLE `dealactivity`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `dealstep`
--
ALTER TABLE `dealstep`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `priority`
--
ALTER TABLE `priority`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `productcategory`
--
ALTER TABLE `productcategory`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `productquotation`
--
ALTER TABLE `productquotation`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `survey`
--
ALTER TABLE `survey`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `surveycontent`
--
ALTER TABLE `surveycontent`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `surveyresult`
--
ALTER TABLE `surveyresult`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `task`
--
ALTER TABLE `task`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `taskcustomer`
--
ALTER TABLE `taskcustomer`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `taskdeal`
--
ALTER TABLE `taskdeal`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `taskstatus`
--
ALTER TABLE `taskstatus`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `taskuser`
--
ALTER TABLE `taskuser`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `team`
--
ALTER TABLE `team`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `usercustomer`
--
ALTER TABLE `usercustomer`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `activity`
--
ALTER TABLE `activity`
  ADD CONSTRAINT `FK_User_TO_Activity` FOREIGN KEY (`CreatedUser`) REFERENCES `user` (`Id`);

--
-- Constraints for table `anwser`
--
ALTER TABLE `anwser`
  ADD CONSTRAINT `FK_Question_TO_Anwser` FOREIGN KEY (`QuestionId`) REFERENCES `question` (`Id`),
  ADD CONSTRAINT `FK_User_TO_Anwser` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `FK_CustomerInfo_TO_Customer` FOREIGN KEY (`CustomerInfoId`) REFERENCES `customerinfo` (`Id`),
  ADD CONSTRAINT `FK_Priority_TO_Customer` FOREIGN KEY (`PriorityId`) REFERENCES `priority` (`Id`);

--
-- Constraints for table `customerinfo`
--
ALTER TABLE `customerinfo`
  ADD CONSTRAINT `FK_CustomerSource_TO_CustomerInfo` FOREIGN KEY (`CustomerSourceId`) REFERENCES `customersource` (`Id`);

--
-- Constraints for table `deal`
--
ALTER TABLE `deal`
  ADD CONSTRAINT `FK_Customer_TO_Deal` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`Id`),
  ADD CONSTRAINT `FK_DealStep_TO_Deal` FOREIGN KEY (`DealStepId`) REFERENCES `dealstep` (`Id`),
  ADD CONSTRAINT `FK_Order_TO_Deal` FOREIGN KEY (`OrderId`) REFERENCES `order` (`Id`),
  ADD CONSTRAINT `FK_User_TO_Deal` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `dealactivity`
--
ALTER TABLE `dealactivity`
  ADD CONSTRAINT `FK_Activity_TO_DealActivity` FOREIGN KEY (`ActivityId`) REFERENCES `activity` (`Id`),
  ADD CONSTRAINT `FK_Deal_TO_DealActivity` FOREIGN KEY (`DealId`) REFERENCES `deal` (`Id`);

--
-- Constraints for table `dealquotation`
--
ALTER TABLE `dealquotation`
  ADD CONSTRAINT `FK_Deal_TO_DealQuotation` FOREIGN KEY (`DealId`) REFERENCES `deal` (`Id`),
  ADD CONSTRAINT `FK_Product_TO_DealQuotation` FOREIGN KEY (`ProductId`) REFERENCES `product` (`Id`),
  ADD CONSTRAINT `FK_User_TO_DealQuotation` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `dealstephistory`
--
ALTER TABLE `dealstephistory`
  ADD CONSTRAINT `FK_DealStep_TO_DealStepHistory` FOREIGN KEY (`DealStepId`) REFERENCES `dealstep` (`Id`),
  ADD CONSTRAINT `FK_Deal_TO_DealStepHistory` FOREIGN KEY (`Id`) REFERENCES `deal` (`Id`),
  ADD CONSTRAINT `FK_User_TO_DealStepHistory` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `FK_Customer_TO_Order` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`Id`),
  ADD CONSTRAINT `FK_User_TO_Order` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`),
  ADD CONSTRAINT `FK_User_TO_Order1` FOREIGN KEY (`EditedUserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `FK_ProductCategory_TO_Product` FOREIGN KEY (`CategoryId`) REFERENCES `productcategory` (`Id`);

--
-- Constraints for table `productorder`
--
ALTER TABLE `productorder`
  ADD CONSTRAINT `FK_Order_TO_ProductOrder` FOREIGN KEY (`OrderId`) REFERENCES `order` (`Id`),
  ADD CONSTRAINT `FK_Product_TO_ProductOrder` FOREIGN KEY (`ProductId`) REFERENCES `product` (`Id`);

--
-- Constraints for table `productquotation`
--
ALTER TABLE `productquotation`
  ADD CONSTRAINT `FK_Product_TO_ProductQuotation` FOREIGN KEY (`ProductId`) REFERENCES `product` (`Id`);

--
-- Constraints for table `question`
--
ALTER TABLE `question`
  ADD CONSTRAINT `FK_Ticket_TO_Question` FOREIGN KEY (`TicketId`) REFERENCES `ticket` (`Id`);

--
-- Constraints for table `survey`
--
ALTER TABLE `survey`
  ADD CONSTRAINT `FK_User_TO_Survey` FOREIGN KEY (`CreatedUser`) REFERENCES `user` (`Id`);

--
-- Constraints for table `surveycontent`
--
ALTER TABLE `surveycontent`
  ADD CONSTRAINT `FK_Survey_TO_SurveyContent` FOREIGN KEY (`SurveyId`) REFERENCES `survey` (`Id`);

--
-- Constraints for table `surveyresult`
--
ALTER TABLE `surveyresult`
  ADD CONSTRAINT `FK_Survey_TO_SurveyResult` FOREIGN KEY (`SurveyId`) REFERENCES `survey` (`Id`);

--
-- Constraints for table `task`
--
ALTER TABLE `task`
  ADD CONSTRAINT `FK_TaskStatus_TO_Task` FOREIGN KEY (`TaskStatus`) REFERENCES `taskstatus` (`Id`),
  ADD CONSTRAINT `FK_User_TO_Task` FOREIGN KEY (`CreatedUser`) REFERENCES `user` (`Id`);

--
-- Constraints for table `taskcustomer`
--
ALTER TABLE `taskcustomer`
  ADD CONSTRAINT `FK_Task_TO_TaskCustomer` FOREIGN KEY (`TaskId`) REFERENCES `task` (`Id`),
  ADD CONSTRAINT `FK_User_TO_TaskCustomer` FOREIGN KEY (`UserRelated`) REFERENCES `user` (`Id`);

--
-- Constraints for table `taskdeal`
--
ALTER TABLE `taskdeal`
  ADD CONSTRAINT `FK_Deal_TO_TaskDeal` FOREIGN KEY (`DealRelated`) REFERENCES `deal` (`Id`),
  ADD CONSTRAINT `FK_Task_TO_TaskDeal` FOREIGN KEY (`TaskId`) REFERENCES `task` (`Id`);

--
-- Constraints for table `taskuser`
--
ALTER TABLE `taskuser`
  ADD CONSTRAINT `FK_Task_TO_TaskUser` FOREIGN KEY (`TaskId`) REFERENCES `task` (`Id`),
  ADD CONSTRAINT `FK_User_TO_TaskUser` FOREIGN KEY (`UserRelated`) REFERENCES `user` (`Id`);

--
-- Constraints for table `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `FK_Customer_TO_Ticket` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`Id`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `FK_Team_TO_User` FOREIGN KEY (`TeamId`) REFERENCES `team` (`Id`);

--
-- Constraints for table `usercustomer`
--
ALTER TABLE `usercustomer`
  ADD CONSTRAINT `FK_Customer_TO_UserCustomer` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`Id`),
  ADD CONSTRAINT `FK_Team_TO_UserCustomer` FOREIGN KEY (`TeamId`) REFERENCES `team` (`Id`),
  ADD CONSTRAINT `FK_User_TO_UserCustomer` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);

--
-- Constraints for table `userrole`
--
ALTER TABLE `userrole`
  ADD CONSTRAINT `FK_Role_TO_UserRole` FOREIGN KEY (`RoleId`) REFERENCES `role` (`Id`),
  ADD CONSTRAINT `FK_User_TO_UserRole` FOREIGN KEY (`UserId`) REFERENCES `user` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
