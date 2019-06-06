-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jun 04, 2019 at 07:07 PM
-- Server version: 10.3.11-MariaDB
-- PHP Version: 5.6.39

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `DB05062019`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `DangerLevelProduct`
-- (See below for the actual view)
--
CREATE TABLE `DangerLevelProduct` (
`ProductID` varchar(6)
,`ProductName` varchar(50)
,`ProductType` varchar(17)
,`ProductDescription` varchar(100)
,`ProductUnit` varchar(10)
,`ProductPrice` int(10)
,`ProductProcurementPrice` int(10)
,`VendorID` varchar(8)
,`ActualQuantity` int(10)
,`ReserveQuantity` int(10)
,`ReorderLevel` int(10)
,`DangerLevel` int(10)
);

-- --------------------------------------------------------

--
-- Table structure for table `Dealer`
--

CREATE TABLE `Dealer` (
  `DealerID` varchar(8) NOT NULL COMMENT 'Dealer ID, D +  7 digits',
  `DealerName` varchar(50) NOT NULL COMMENT 'Dealer Name',
  `DealerInvoiceAddress` varchar(80) NOT NULL COMMENT 'Dealer invoice address',
  `DealerShippingAddress` varchar(80) NOT NULL COMMENT 'Dealer shipping address',
  `DealerPhoneNo` varchar(11) NOT NULL COMMENT 'Dealer phone number'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Dealer`
--

INSERT INTO `Dealer` (`DealerID`, `DealerName`, `DealerInvoiceAddress`, `DealerShippingAddress`, `DealerPhoneNo`) VALUES
('D0000000', 'Letha', '461 NW Riddle Hill Lane, Concord, NH, 04357', '461 NW Riddle Hill Lane, Concord, NH, 04357', '80460192228'),
('D0000001', 'Kraig', '11 Red Lake Hwy, Harrisburg, Pennsylvania, 30254', '11 Red Lake Hwy, Harrisburg, Pennsylvania, 30254', '68490827623'),
('D0000002', 'Harlan', '1753 North Church Pkwy, Boise, Idaho, 95705', '1753 North Church Pkwy, Boise, Idaho, 95705', '00368767478'),
('D0000003', 'Brad', '1695 Hidden Deepwood Cir, Superior Bldg, Indianapolis, Indiana, 88231', '1695 Hidden Deepwood Cir, Superior Bldg, Indianapolis, Indiana, 88231', '64449631587'),
('D0000004', 'Enrique', '970 Riddle Hill Pkwy, Comcast Building, Albany, New York, 12229', '970 Riddle Hill Pkwy, Comcast Building, Albany, New York, 12229', '84009375351'),
('D0000005', 'Bennie', '1955 Front Road, Madison, WI, 37006', '1955 Front Road, Madison, WI, 37006', '34115891693'),
('D0000006', 'Francis', '2844 North Woodfort St, Raleigh, NC, 26635', '2844 North Woodfort St, Raleigh, NC, 26635', '79570539869'),
('D0000007', 'Nickie', '2989 East Pine Tree Road, Topeka, KS, 16758', '2989 East Pine Tree Road, Topeka, KS, 16758', '53293261764'),
('D0000008', 'Boyd', '62 Ashwood Pkwy, 3rd Floor, Madison, Wisconsin, 04370', '62 Ashwood Pkwy, 3rd Floor, Madison, Wisconsin, 04370', '57335893201'),
('D0000009', 'Alonzo', '40 Bayview Lane, Topeka, Kansas, 52885', '40 Bayview Lane, Topeka, Kansas, 52885', '48823116874'),
('D0000010', 'Reed', '18 2nd Ct, 1st FL, Pierre, SD, 48106', '18 2nd Ct, 1st FL, Pierre, SD, 48106', '01414516278'),
('D0000011', 'Cory', '664 Town Way, Oklahoma City, OK, 55081', '664 Town Way, Oklahoma City, OK, 55081', '22183842355'),
('D0000012', 'Abbie', '66 East Quailwood Rd, Standard Building, Montgomery, AL, 48135', '66 East Quailwood Rd, Standard Building, Montgomery, AL, 48135', '62976086964'),
('D0000013', 'Lazaro', '3215 Beachwood Highway, Lincoln, Nebraska, 38238', '3215 Beachwood Highway, Lincoln, Nebraska, 38238', '65249368582'),
('D0000014', 'Danielle', '3927 North Town Street, Augusta, Maine, 09086', '3927 North Town Street, Augusta, Maine, 09086', '04878184404'),
('D0000015', 'Gregorio', '3235 NW Farmview Loop, Boston, Massachusetts, 65476', '3235 NW Farmview Loop, Boston, Massachusetts, 65476', '62008942994'),
('D0000016', 'Monty', '1765 Ironwood Hwy, Kearns Bldg, Juneau, AK, 44263', '1765 Ironwood Hwy, Kearns Bldg, Juneau, AK, 44263', '74266355509'),
('D0000017', 'Abby', '739 Waterview Hwy, Helena, MT, 64021', '739 Waterview Hwy, Helena, MT, 64021', '89203167930'),
('D0000018', 'Evelin', '3949 New Town Blvd, Guardian Building, Phoenix, AZ, 19385', '3949 New Town Blvd, Guardian Building, Phoenix, AZ, 19385', '63438151769'),
('D0000019', 'Earline', '44 White Glenwood Court, Appartment 9, Salt Lake City, Utah, 30714', '44 White Glenwood Court, Appartment 9, Salt Lake City, Utah, 30714', '27007622225'),
('D0000020', 'Viviana', '1752 East Chapel Hill Highway, Austin, Texas, 53257', '1752 East Chapel Hill Highway, Austin, Texas, 53257', '99070628884'),
('D0000021', 'Chae', '34 New Waterview Loop, 3rd FL, Carson City, NV, 56781', '34 New Waterview Loop, 3rd FL, Carson City, NV, 56781', '50437058002'),
('D0000022', 'Delta', '875 Stonewood Pkwy, Carson City, Nevada, 72024', '875 Stonewood Pkwy, Carson City, Nevada, 72024', '36884763047'),
('D0000023', 'Toney', '786 Rock Hill Drive, Augusta, Maine, 44321', '786 Rock Hill Drive, Augusta, Maine, 44321', '15944328100'),
('D0000024', 'Wynell', '3984 Ironwood Loop, Santa Fe, NM, 62291', '3984 Ironwood Loop, Santa Fe, NM, 62291', '27868892048'),
('D0000025', 'Ashley', '1912 E Deepwood Ave, Austin, Texas, 55348', '1912 E Deepwood Ave, Austin, Texas, 55348', '24810650561'),
('D0000026', 'Ressie', '63 Waterview Ct, Boise, ID, 60661', '63 Waterview Ct, Boise, ID, 60661', '41300364487'),
('D0000027', 'Shane', '37 Market Street, APT 666, Cheyenne, Wyoming, 21327', '37 Market Street, APT 666, Cheyenne, Wyoming, 21327', '98175045510'),
('D0000028', 'Raleigh', '3249 Fox Hill Ct, 1st FL, Saint Paul, Minnesota, 69091', '3249 Fox Hill Ct, 1st FL, Saint Paul, Minnesota, 69091', '63294076195'),
('D0000029', 'Jean', '804 West Bayview Ln, STE 1849, Trenton, NJ, 49680', '804 West Bayview Ln, STE 1849, Trenton, NJ, 49680', '41724714178'),
('D0000030', 'Roosevelt', '546 NW Waterview Blvd, Duke Energy Building, Charleston, WV, 15053', '546 NW Waterview Blvd, Duke Energy Building, Charleston, WV, 15053', '44786222330'),
('D0000031', 'Alanna', '92 3rd Ct, Montpelier, Vermont, 60820', '92 3rd Ct, Montpelier, Vermont, 60820', '03902968983'),
('D0000032', 'Lilliana', '729 Meadowview Drive, Hartford, Connecticut, 90181', '729 Meadowview Drive, Hartford, Connecticut, 90181', '73937286219'),
('D0000033', 'Amiee', '1787 Mountain Loop, Salt Lake City, UT, 54836', '1787 Mountain Loop, Salt Lake City, UT, 54836', '40421088056'),
('D0000034', 'Rene', '1664 NW Edgewood Pkwy, Buhl Building, Tallahassee, Florida, 40360', '1664 NW Edgewood Pkwy, Buhl Building, Tallahassee, Florida, 40360', '59987909086'),
('D0000035', 'Demarcus', '283 Sharp Hill Parkway, STE 8682, Dover, Delaware, 25934', '283 Sharp Hill Parkway, STE 8682, Dover, Delaware, 25934', '03823586550'),
('D0000036', 'Ashley', '31 SE Stonewood Lane, Annapolis, Maryland, 85286', '31 SE Stonewood Lane, Annapolis, Maryland, 85286', '18343228666'),
('D0000037', 'Abel', '963 2nd Parkway, Atlanta, Georgia, 68754', '963 2nd Parkway, Atlanta, Georgia, 68754', '90933765765'),
('D0000038', 'Ali', '442 White Edgewood Ct, Frankfort, Kentucky, 20402', '442 White Edgewood Ct, Frankfort, Kentucky, 20402', '41095746857'),
('D0000039', 'Clark', '718 NW Hunting Hill Blvd, Albany, New York, 70768', '718 NW Hunting Hill Blvd, Albany, New York, 70768', '85547482635'),
('D0000040', 'Adam', '924 East Church Pkwy, Buhl Building, Sacramento, California, 45033', '924 East Church Pkwy, Buhl Building, Sacramento, California, 45033', '86309795357'),
('D0000041', 'Gayle', '365 Red Beachwood Ct, Bartlett Building, Montgomery, Alabama, 78518', '365 Red Beachwood Ct, Bartlett Building, Montgomery, Alabama, 78518', '14621640212'),
('D0000042', 'Kristy', '467 SE Hazelwood Loop, 7th FL, Charleston, WV, 26819', '467 SE Hazelwood Loop, 7th FL, Charleston, WV, 26819', '50949104899'),
('D0000043', 'Ryan', '3747 Farmview Blvd, Bartlett Building, Olympia, WA, 43866', '3747 Farmview Blvd, Bartlett Building, Olympia, WA, 43866', '36874051522'),
('D0000044', 'Marjory', '1388 Ironwood Ln, Cheyenne, WY, 22475', '1388 Ironwood Ln, Cheyenne, WY, 22475', '97679513520'),
('D0000045', 'Christopher', '1321 9th Circle, Bismarck, North Dakota, 66160', '1321 9th Circle, Bismarck, North Dakota, 66160', '14620830031'),
('D0000046', 'Abraham', '91 Bayview Dr, Lincoln, NE, 73119', '91 Bayview Dr, Lincoln, NE, 73119', '86033027147'),
('D0000047', 'Lavelle', '1684 White Sharp Hill Street, Juneau, Alaska, 00157', '1684 White Sharp Hill Street, Juneau, Alaska, 00157', '82066910841'),
('D0000048', 'Brigida', '84 Ski Hill Hwy, Providence, RI, 35291', '84 Ski Hill Hwy, Providence, RI, 35291', '00341090574'),
('D0000049', 'Cristobal', '30 51th Road, Equitable Building, Trenton, New Jersey, 66590', '30 51th Road, Equitable Building, Trenton, New Jersey, 66590', '99704973998');

-- --------------------------------------------------------

--
-- Table structure for table `Department`
--

CREATE TABLE `Department` (
  `DepartmentID` varchar(2) NOT NULL COMMENT 'Company department ID, “HR”, ”SA”, ”WH”, “PO”, “FI”',
  `DepartmentName` varchar(30) NOT NULL COMMENT 'Company department name'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Department`
--

INSERT INTO `Department` (`DepartmentID`, `DepartmentName`) VALUES
('FI', 'Finance'),
('HR', 'Personnel'),
('PO', 'Procurement'),
('SA', 'Sales'),
('WH', 'Warehouse');

-- --------------------------------------------------------

--
-- Table structure for table `Product`
--

CREATE TABLE `Product` (
  `ProductID` varchar(6) NOT NULL COMMENT 'Product ID, Category letter + 5 digit',
  `ProductName` varchar(50) NOT NULL COMMENT 'Product name',
  `ProductType` varchar(17) NOT NULL COMMENT 'Sheet Metal, Major Asssemblies, Light Components, Accessories',
  `ProductDescription` varchar(100) NOT NULL COMMENT 'Product description',
  `ProductUnit` varchar(10) NOT NULL COMMENT 'Product unit',
  `ProductPrice` int(10) NOT NULL COMMENT 'Product price',
  `ProductProcurementPrice` int(10) DEFAULT NULL,
  `VendorID` varchar(8) NOT NULL COMMENT 'Vendor ID',
  `ActualQuantity` int(10) NOT NULL DEFAULT 0 COMMENT 'Stock quantity that stores in the inventory',
  `ReserveQuantity` int(10) NOT NULL DEFAULT 0,
  `ReorderLevel` int(10) NOT NULL DEFAULT 0,
  `DangerLevel` int(10) NOT NULL DEFAULT 0,
  `ProductStatus` varchar(11) NOT NULL DEFAULT 'Available' COMMENT 'Available, Unavailable'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Product`
--

INSERT INTO `Product` (`ProductID`, `ProductName`, `ProductType`, `ProductDescription`, `ProductUnit`, `ProductPrice`, `ProductProcurementPrice`, `VendorID`, `ActualQuantity`, `ReserveQuantity`, `ReorderLevel`, `DangerLevel`, `ProductStatus`) VALUES
('A00000', 'Monofindoller', 'Sheet Metal', 'Quae error ad dolore. Labore itaque autem nihil modi! Sit eius. Itaque sit!', 'piece', 3528, 460, 'V0000008', 214982, 48, 0, 0, 'Available'),
('A00002', 'AAAAACCCC', 'Sheet Metal', 'Cum quam aut labore', 'item', 30000, 479, 'V0000002', 10000, 0, 30, 10, 'Available'),
('A00009', 'Micnientor', 'Sheet Metal', 'Minus totam laboriosam. Omnis possimus. Iste dolorem! Est natus. Dolores.', 'piece', 1791, 901, 'V0000001', 8765, 15, 70, 1, 'Available'),
('A00013', 'Readtaerer', 'Sheet Metal', 'Vero dolore quo error rem.', 'item', 4334, 150, 'V0000005', 36, 1, 11, 0, 'Available'),
('A00015', 'Conceivphone', 'Sheet Metal', 'Aut unde magni. Quia deleniti? Nesciunt natus unde; alias vel id.', 'set', 2021, 261, 'V0000001', 22, 6, 0, 0, 'Available'),
('A00017', 'Montaphone', 'Sheet Metal', 'Sed et. Voluptatem unde est explicabo voluptas.', 'set', 1874, 766, 'V0000008', 46, 10, 0, 0, 'Available'),
('A00024', 'Speaktaoller', 'Sheet Metal', 'Et quia sint. Perspiciatis ipsa autem. Veniam tempora! Omnis aspernatur.', 'item', 4838, 887, 'V0000003', 86, 9, 0, 0, 'Available'),
('B00003', 'Readculor', 'Major Assemblies', 'Obcaecati deleniti incidunt sequi. Amet fugiat ut? Blanditiis sed. Ut earum!', 'item', 2891, 856, 'V0000002', 75, 9, 0, 0, 'Available'),
('B00004', 'Contopedgor', 'Major Assemblies', 'Sit consequuntur nihil. Molestiae quos officia et; est natus. Doloremque ut!', 'item', 4129, 286, 'V0000007', 61, 7, 0, 0, 'Available'),
('B00007', 'Stereolifiridge', 'Major Assemblies', 'Iste ab omnis et. Ea magni excepturi. Vitae molestias! Ut minima.', 'set', 2680, 1107, 'V0000003', 41, 3, 0, 0, 'Available'),
('B00010', 'Rejectlet', 'Major Assemblies', 'Unde quae. Blanditiis modi quo vero ratione.', 'item', 3487, 714, 'V0000001', 19, 1, 0, 99, 'Available'),
('B00016', 'Mictopepor', 'Major Assemblies', 'Velit in exercitationem voluptatem. Placeat enim laudantium illum officiis.', 'set', 3616, 399, 'V0000001', 53, 7, 0, 0, 'Available'),
('B00018', 'Armcycllet', 'Major Assemblies', 'Qui perferendis. Ut labore et veritatis. At voluptate quis.', 'piece', 4848, 973, 'V0000007', 17, 7, 0, 0, 'Available'),
('B00023', 'Comniedgscope', 'Major Assemblies', 'Ut est. Sit excepturi omnis. Dolor vel; aut vel delectus.', 'item', 4850, 555, 'V0000007', 35, 8, 0, 0, 'Available'),
('B00025', 'Charlictry', 'Major Assemblies', 'Dignissimos omnis. Necessitatibus dolores mollitia dicta ipsa.', 'piece', 4171, 816, 'V0000005', 63, 1, 0, 0, 'Available'),
('B00026', 'Readpickor', 'Major Assemblies', 'Velit dolores est. Voluptatibus quidem! Quaerat exercitationem. Voluptatum;', 'item', 2369, 308, 'V0000007', 35, 8, 0, 0, 'Available'),
('B00027', 'Transplottentor', 'Major Assemblies', 'Corporis iste error quia omnis. Consectetur voluptatem laudantium...', 'piece', 1712, 1188, 'V0000005', 37, 8, 0, 0, 'Available'),
('B00028', '42', 'Major Assemblies', '424242', 'piece', 2424201, NULL, 'V0000038', 0, 0, 0, 0, 'Available'),
('C00005', 'Readtinaquer', 'Light Components', 'Voluptas unde harum dolores odit. Officia aspernatur facere libero omnis?', 'set', 2916, 291, 'V0000004', 12, 4, 0, 0, 'Available'),
('C00008', 'Cartnierentor', 'Light Components', 'Tempore unde soluta. Architecto laudantium. Aspernatur natus error! Est omnis.', 'set', 2676, 230, 'V0000008', 32, 3, 0, 0, 'Available'),
('C00011', 'Miclifiedgor', 'Light Components', 'Maxime possimus amet obcaecati necessitatibus. Natus quasi est cupiditate.', 'set', 3641, 504, 'V0000006', 66, 10, 0, 0, 'Available'),
('C00022', 'Micplottor', 'Light Components', 'Architecto iste. Dolores iste doloremque sequi enim.', 'item', 4915, 666, 'V0000002', 66, 5, 0, 0, 'Available'),
('D00001', 'Cleantopefon', 'Accessories', 'Aut aliquam consequatur culpa doloribus. Numquam placeat! Maiores quos? Non!', 'item', 2772, 1195, 'V0000001', 51, 6, 0, 0, 'Available'),
('D00006', 'Monlescope', 'Accessories', 'Praesentium sequi. Eaque hic voluptatem iste. Corporis ipsam. Ipsa quia.', 'set', 2184, 239, 'V0000003', 77, 5, 1, 0, 'Available'),
('D00012', 'Transceiver', 'Accessories', 'Cumque obcaecati similique neque praesentium.', 'item', 2384, 534, 'V0000001', 15, 0, 0, 0, 'Available'),
('D00014', 'Subwoofgaer', 'Accessories', 'Et excepturi ratione porro. Voluptas tempore temporibus non! Sit explicabo.', 'piece', 3647, 334, 'V0000004', 41, 3, 0, 0, 'Available'),
('D00019', 'Tweetleefra', 'Accessories', 'Dolore sed. Repudiandae aut nihil. Dolorem repellat. Placeat quia. Quasi rem!', 'set', 4123, 375, 'V0000003', 39, 9, 0, 0, 'Available'),
('D00020', 'Supwoofewry', 'Accessories', 'Ducimus unde qui dolore placeat.', 'set', 4426, 332, 'V0000007', 71, 3, 0, 0, 'Available'),
('D00021', 'Monjectplridge', 'Accessories', 'Voluptatem non quo voluptas velit. Repellendus iure qui temporibus!', 'set', 3096, 572, 'V0000007', 95, 1, 0, 0, 'Available'),
('D00022', 'big dick', 'Accessories', 'very big', 'piece', 80, NULL, 'V0000006', 0, 0, 0, 0, 'Available');

-- --------------------------------------------------------

--
-- Stand-in structure for view `ProductSaleableQuantity`
-- (See below for the actual view)
--
CREATE TABLE `ProductSaleableQuantity` (
`ProductID` varchar(6)
,`SaleableQuantity` bigint(12)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `ReorderLevelProduct`
-- (See below for the actual view)
--
CREATE TABLE `ReorderLevelProduct` (
`ProductID` varchar(6)
,`ProductName` varchar(50)
,`ProductType` varchar(17)
,`ProductDescription` varchar(100)
,`ProductUnit` varchar(10)
,`ProductPrice` int(10)
,`ProductProcurementPrice` int(10)
,`VendorID` varchar(8)
,`ActualQuantity` int(10)
,`ReserveQuantity` int(10)
,`ReorderLevel` int(10)
,`DangerLevel` int(10)
);

-- --------------------------------------------------------

--
-- Table structure for table `ReorderOrder`
--

CREATE TABLE `ReorderOrder` (
  `ReorderOrderID` varchar(14) NOT NULL COMMENT 'RO + yy+mm+dd + 6 digits',
  `StaffID` varchar(9) NOT NULL COMMENT 'Staff ID',
  `ReorderOrderDate` datetime NOT NULL COMMENT 'Reorder order date',
  `ReorderOrderEditDate` datetime DEFAULT NULL COMMENT 'Reorder order edited date',
  `ReorderOrderReceivedDate` datetime DEFAULT NULL COMMENT 'Reorder order Received Date',
  `ReorderOrderCompletedDate` datetime DEFAULT NULL COMMENT 'Reorder Order complete date',
  `ReorderOrderStatus` varchar(11) NOT NULL COMMENT '“Processing”, "Received", ”Completed”, “Canceled”'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `ReorderOrderLine`
--

CREATE TABLE `ReorderOrderLine` (
  `ReorderOrderID` varchar(14) NOT NULL COMMENT 'Reorder order ID',
  `ProductID` varchar(6) NOT NULL COMMENT 'Product ID',
  `Quantity` int(10) NOT NULL COMMENT 'Product quantity in specific sales order'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SalesOrder`
--

CREATE TABLE `SalesOrder` (
  `SalesOrderID` varchar(14) NOT NULL COMMENT 'SO + yy+mm+dd + 6 digits',
  `StaffID` varchar(9) NOT NULL COMMENT 'Staff ID',
  `DealerID` varchar(8) NOT NULL COMMENT 'Dealer ID',
  `SalesOrderDate` datetime NOT NULL COMMENT 'Sales order date',
  `SalesOrderEditDate` datetime DEFAULT NULL COMMENT 'Sales order edited date',
  `SalesDispatchDate` datetime DEFAULT NULL COMMENT 'Dispatch date',
  `SalesOrderCompletedDate` datetime DEFAULT NULL COMMENT 'Sales order completed data',
  `SalesOrderStatus` varchar(11) NOT NULL COMMENT '“Processing”, ”Dispatched”, “Resserved”, ”Completed”, "Canceled'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SalesOrderLine`
--

CREATE TABLE `SalesOrderLine` (
  `SalesOrderID` varchar(14) NOT NULL COMMENT 'Sales order ID',
  `ProductID` varchar(6) NOT NULL COMMENT 'Product ID',
  `Quantity` int(10) NOT NULL COMMENT 'Product quantity in specific sales order',
  `ProductPrice` int(10) NOT NULL COMMENT 'Prodcut price'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `Staff`
--

CREATE TABLE `Staff` (
  `StaffID` varchar(9) NOT NULL COMMENT 'Login account, S + Year (2 digits) + 6 digits',
  `Password` varchar(30) NOT NULL COMMENT '5 digits with 1 upper case letter and 1 lower case letter',
  `PasswordChangeDate` datetime NOT NULL COMMENT 'for counting 30 days to change password',
  `StaffName` varchar(50) NOT NULL COMMENT 'Staff full name',
  `StaffPhoneNo` varchar(11) NOT NULL COMMENT 'Staff phone number',
  `StaffPositionID` varchar(2) NOT NULL COMMENT 'Staff position using for permission',
  `DepartmentID` varchar(2) NOT NULL COMMENT 'Company department ID'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Staff`
--

INSERT INTO `Staff` (`StaffID`, `Password`, `PasswordChangeDate`, `StaffName`, `StaffPhoneNo`, `StaffPositionID`, `DepartmentID`) VALUES
('S19002708', 'u1s5tw051', '2019-01-13 16:02:35', 'Tisdale', '41300364487', '01', 'PO'),
('S19026963', '9jKMvYP47', '2019-01-27 14:54:08', 'Tobias', '40421088056', '01', 'SA'),
('S19050007', '2tgLVK0TJ', '2019-01-01 00:51:28', 'Tobin', '14621640212', '01', 'SA'),
('S19067625', '7L9q2ey79', '2019-01-01 00:09:27', 'Gonsalves', '79570539869', '01', 'SA'),
('S19071264', 'hWx2C0H62', '2019-05-03 14:41:39', 'Longoria', '44786222330', '01', 'SA'),
('S19105923', 'R2J89jNb9', '2019-01-25 00:31:02', 'Titus', '63294076195', '02', 'HR'),
('S19167524', 'e3c6694Pl', '2019-01-01 00:15:15', 'Drayton', '53293261764', '01', 'WH'),
('S19181657', 'wJeW8fL9Y', '2019-03-28 16:34:51', 'Schell', '41724714178', '02', 'HR'),
('S19184512', '98b8M66r1', '2019-01-01 02:05:35', 'Alicea', '00368767478', '02', 'HR'),
('S19187179', 'Rxvvj6NSx', '2019-05-14 10:33:42', 'Brice', '84009375351', '01', 'WH'),
('S19224157', 'dCtIqpqYU', '2019-01-05 14:22:56', 'Schafer', '89203167930', '02', 'FI'),
('S19225176', '6r3Dn8b0S', '2019-01-09 15:18:58', 'Goodman', '18343228666', '01', 'SA'),
('S19235414', 'hz102MOiT', '2019-01-01 00:04:04', 'Duarte', '97679513520', '01', 'SA'),
('S19239223', '1YquJK1OH', '2019-04-20 10:02:09', 'Roberge', '01414516278', '01', 'SA'),
('S19242668', 'wwvIoukcF', '2019-01-01 00:06:23', 'Goodrich', '36874051522', '01', 'SA'),
('S19264217', 'JG5p40l30', '2019-03-06 01:23:22', 'Drew', '65249368582', '01', 'PO'),
('S19319037', 'ZrAd6qhdW', '2019-05-06 16:40:55', 'Brill', '99704973998', '01', 'SA'),
('S19336525', 'LM8NO863z', '2019-02-18 23:01:47', 'Gonzales', '48823116874', '01', 'SA'),
('S19375261', '4S0B0ChJb', '2019-01-01 00:00:54', 'Alley', '50949104899', '01', 'SA'),
('S19386854', '0Tbpr37GZ', '2019-04-22 08:35:35', 'Longo', '57335893201', '02', 'HR'),
('S19386857', 'XJZF509Nn', '2019-01-01 00:01:38', 'Drury', '90933765765', '01', 'SA'),
('S19387982', '20dD9n706', '2019-01-01 00:00:31', 'Nowlin', '22183842355', '02', 'HR'),
('S19431523', 'K3rm4OnGx', '2019-05-18 03:51:14', 'Scherer', '41095746857', '01', 'SA'),
('S19439645', 'DBw8lSgbh', '2019-01-01 00:00:58', 'Bright', '86309795357', '01', 'PO'),
('S19521873', 'fH1g0Rm0x', '2019-02-02 02:08:34', 'Allen', '85547482635', '01', 'SA'),
('S19547398', 'dr29Ah8KZ', '2019-03-24 20:32:23', 'Schaffer', '98175045510', '01', 'WH'),
('S19563696', 'aldCTs5bp', '2019-01-01 00:00:14', 'Gonzalez', '04878184404', '01', 'SA'),
('S19565771', 'LBdrqRl39', '2019-04-02 12:46:04', 'Schaeffer', '68490827623', '01', 'WH'),
('S19611273', 'V8kqsk6H8', '2019-01-01 00:00:05', 'Nugent', '03823586550', '01', 'WH'),
('S19624138', 'HX6eP2poI', '2019-01-01 00:10:47', 'Driver', '15944328100', '01', 'WH'),
('S19627333', 'KSXcBtq23', '2019-04-21 20:49:26', 'Draper', '80460192228', '01', 'SA'),
('S19655018', 'ymm7w4V1t', '2019-04-18 13:57:56', 'Roberts', '14620830031', '02', 'FI'),
('S19692949', '5B39ghZ52', '2019-01-01 02:16:16', 'Bridges', '99070628884', '02', 'HR'),
('S19693787', 'b5zqoKpWa', '2019-02-20 15:25:09', 'Noyes', '24810650561', '01', 'PO'),
('S19696250', 'He9Bb9MX7', '2019-01-01 00:57:14', 'Allard', '50437058002', '01', 'PO'),
('S19739794', 'FcdxT11f6', '2019-02-28 06:54:27', 'Roberson', '62976086964', '01', 'WH'),
('S19753172', 'smaEj494j', '2019-02-16 05:59:40', 'Tirado', '74266355509', '01', 'WH'),
('S19756871', '6ck68Y9Ja', '2019-04-14 01:53:44', 'Goodson', '82066910841', '01', 'PO'),
('S19811427', 'xG38MEX8u', '2019-04-29 10:05:04', 'Nowak', '64449631587', '02', 'HR'),
('S19812649', '85AE7up4j', '2019-01-29 16:05:51', 'Driscoll', '62008942994', '01', 'SA'),
('S19818781', '67awiai0s', '2019-02-22 00:05:16', 'Gooch', '27007622225', '01', 'WH'),
('S19827432', 'q7nyRCwtB', '2019-03-11 23:23:15', 'Loomis', '00341090574', '01', 'PO'),
('S19852605', 'KxlrIWUpF', '2019-04-07 18:28:06', 'Robert', '73937286219', '01', 'PO'),
('S19867589', 'zvIYd2TPq', '2019-05-03 22:28:13', 'Allan', '34115891693', '01', 'WH'),
('S19908330', '46VHeR877', '2019-01-01 00:00:06', 'Hughey', '63438151769', '01', 'SA'),
('S19933986', 'FV99UMR6i', '2019-04-17 02:44:47', 'Hull', '59987909086', '01', 'SA'),
('S19935161', '0SKnu0Uuj', '2019-05-21 11:43:25', 'Gooden', '27868892048', '01', 'SA'),
('S19958817', 'SxhkGBIGu', '2019-04-01 22:55:48', 'Schiller', '86033027147', '01', 'PO'),
('S19966985', 'KSwwJ3VvI', '2019-05-15 13:38:07', 'Briggs', '36884763047', '01', 'PO'),
('S19976951', 'x012jpLlb', '2019-01-01 00:10:23', 'Drummond', '03902968983', '01', 'PO');

-- --------------------------------------------------------

--
-- Table structure for table `StaffPosition`
--

CREATE TABLE `StaffPosition` (
  `StaffPositionID` varchar(2) NOT NULL COMMENT 'Staff position ID',
  `PositionName` varchar(7) NOT NULL COMMENT 'Position Name'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `StaffPosition`
--

INSERT INTO `StaffPosition` (`StaffPositionID`, `PositionName`) VALUES
('01', 'Staff'),
('02', 'Manager');

-- --------------------------------------------------------

--
-- Table structure for table `Vendor`
--

CREATE TABLE `Vendor` (
  `VendorID` varchar(8) NOT NULL COMMENT 'Vendor ID, V +  7 digits',
  `VendorName` varchar(50) NOT NULL COMMENT 'Vendor name',
  `VendorAddress` varchar(80) NOT NULL COMMENT 'Vendor address',
  `VendorPhoneNo` varchar(11) NOT NULL COMMENT 'Vendor phone number'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Vendor`
--

INSERT INTO `Vendor` (`VendorID`, `VendorName`, `VendorAddress`, `VendorPhoneNo`) VALUES
('V0000000', 'Smart H-Mobile Co.', '1388 Parkwood Loop, STE 31, Lansing, Michigan, 24438', '91747636842'),
('V0000001', 'Federal Space Research Group', '2083 SE Bayview Hwy, Diamond Bldg, Austin, Texas, 35512', '43047518570'),
('V0000002', 'WorldWide Partners Corporation', '3782 Hidden Meadowview Avenue, Comcast Bldg, Phoenix, AZ, 14366', '28383782178'),
('V0000003', 'Special Engineering Group', '56 Front Way, 7th Floor, Salem, Oregon, 66021', '42842812943'),
('V0000004', 'General B-Mobile Corp.', '646 SE Ironwood Avenue, Little Rock, Arkansas, 83249', '42252147580'),
('V0000005', 'Professional Wind Energy Inc.', '1086 Brentwood Blvd, Dover, DE, 59369', '77185159659'),
('V0000006', 'Home Protection Corporation', '94 North Chapel Hill Pkwy, APT 436, Frankfort, Kentucky, 94314', '33188101585'),
('V0000007', 'Home High-Technologies Group', '3543 Rockwood Way, Bartlett Building, Santa Fe, NM, 74100', '24748895581'),
('V0000008', 'Pacific O-Mobile Group', '296 SW Rockwood Blvd, Comcast Building, Saint Paul, Minnesota, 63918', '72117475734'),
('V0000009', 'North Space Research Inc.', '291 E Market Pkwy, Helena, MT, 32277', '86011472058'),
('V0000010', 'Union High-Technologies Corp.', '1811 S Rock Hill Blvd, Juneau, AK, 04145', '76060293998'),
('V0000011', 'Union Trust Inc.', '2676 E Prospect Hill Ave, Lincoln, NE, 15194', '24465157333'),
('V0000012', 'Professional Business Co.', '605 White Rock Hill Lane, 86th Floor, Montpelier, VT, 67021', '67153468540'),
('V0000013', 'East Space Explore Corp.', '441 S Ski Hill Highway, Bartlett Building, Boise, Idaho, 94526', '19872343962'),
('V0000014', 'First High-Technologies Inc.', '2526 West Pine Tree Highway, Diamond Building, Salt Lake City, Utah, 01418', '52673529967'),
('V0000015', 'North Telecom Corp.', '2815 W Ashwood Pkwy, 9th Floor, Indianapolis, IN, 35378', '86506472646'),
('V0000016', 'South Travel Inc.', '653 NE Edgewood St, Columbia, South Carolina, 96021', '95730291571'),
('V0000017', 'Pacific High-Technologies Group', '75 Town Ln, Frankfort, Kentucky, 24833', '99425478779'),
('V0000018', 'Canadian High-Technologies Inc.', '694 Hidden Ironwood Loop, Standard Bldg, Denver, CO, 06597', '78095305596'),
('V0000019', 'WorldWide M-Mobile Co.', '1547 NE Ski Hill Dr, Kearns Building, Jackson, Mississippi, 91926', '28161132614'),
('V0000020', 'Special High-Technologies Corporation', '1858 Waterview Ln, Appartment 67, Topeka, Kansas, 31062', '09833375070'),
('V0000021', 'First Systems Corporation', '2130 White Mountain Street, First Security Bldg, Indianapolis, Indiana, 45948', '68524316845'),
('V0000022', 'International High-Technologies Corp.', '3250 East Riverside Road, Phoenix, AZ, 34596', '75997379950'),
('V0000023', 'Creative Explore Corporation', '1179 North Mountain Hwy, Des Moines, Iowa, 27520', '44248497795'),
('V0000024', 'City 2G Wireless Co.', '1964 NE Rose Hill Lane, Columbia, South Carolina, 97413', '74485767134'),
('V0000025', 'Creative Research Corp.', '422 Fox Hill Hwy, Suite 515, Lincoln, Nebraska, 90113', '43342961999'),
('V0000026', 'Canadian Space Explore Corp.', '3265 Market Lane, Dover, Delaware, 26858', '89194021861'),
('V0000027', 'Future High-Technologies Co.', '58 E Quailwood Ct, Diamond Bldg, Tallahassee, Florida, 10323', '74691511599'),
('V0000028', 'International Industry Inc.', '969 Burwood Court, Appartment 47, Sacramento, California, 04454', '48137604219'),
('V0000029', 'West Coast I-Mobile Group', '67 Hidden Lake Blvd, Diamond Bldg, Raleigh, NC, 20451', '26347869131'),
('V0000030', 'Western Data Corp.', '316 Church Blvd, Juneau, AK, 41935', '00911352594'),
('V0000031', 'American Travel Corp.', '758 Prospect Hill Dr, 52th FL, Annapolis, Maryland, 40674', '80799346358'),
('V0000032', 'National Data Corp.', '31 S Stonewood Loop, STE 87, Juneau, Alaska, 53219', '52370340629'),
('V0000033', 'American Explore Co.', '63 Pine Tree Ave, Judge Building, Lansing, Michigan, 06118', '72069113054'),
('V0000034', 'National High-Technologies Corporation', '319 Prospect Hill Blvd, Keith Bldg, Boise, Idaho, 76994', '21699750095'),
('V0000035', 'Domestic Space Research Inc.', '238 Hunting Hill Way, Honolulu, Hawaii, 19687', '91627092132'),
('V0000036', 'Smart Services Group', '61 Ironwood Parkway, Plaza Bldg, Baton Rouge, Louisiana, 38502', '43226595043'),
('V0000037', 'Future S-Mobile Corp.', '1761 Front Lane, Salt Lake City, Utah, 70320', '99430042999'),
('V0000038', 'Special Space Explore Corp.', '2513 SW Pine Tree Parkway, 3rd FL, Tallahassee, FL, 28146', '41097341979'),
('V0000039', 'Future High-Technologies Corporation', '122 White Edgewood Ave, Atlanta, Georgia, 14003', '34076684677'),
('V0000040', 'Global Devices Corporation', '2619 New Flintwood Hwy, Boise, ID, 31658', '42700685330'),
('V0000041', 'Western Petroleum Co.', '2158 South Hazelwood Highway, Duke Energy Building, Hartford, Connecticut, 46929', '81931372041'),
('V0000042', 'National Mobile Inc.', '1503 Market Cir, Concord, NH, 29993', '88080443714'),
('V0000043', 'Advanced E-Mobile Inc.', '1495 Rose Hill Rd, Guardian Building, Salem, OR, 07561', '31423982675'),
('V0000044', 'Australian High-Technologies Corp.', '2094 N Pine Tree Circle, Frankfort, Kentucky, 59405', '91845685640'),
('V0000045', 'East Green Resources Group', '1959 Mount Cir, Diamond Bldg, Santa Fe, New Mexico, 09699', '82907239771'),
('V0000046', 'North Nuclear Resources Inc.', '3001 West Ski Hill Way, Buhl Building, Topeka, Kansas, 91545', '80249455504'),
('V0000047', 'North Software Corporation', '2340 Lake Hwy, Montgomery, AL, 99427', '21056018305'),
('V0000048', 'Creative 3G Wireless Group', '55 Rockwood Parkway, Plaza Bldg, Salt Lake City, Utah, 30352', '43397300880'),
('V0000049', 'Beyond High-Technologies Co.', '3026 North Sharp Hill Ln, Madison, Wisconsin, 96478', '03595294593');

-- --------------------------------------------------------

--
-- Structure for view `DangerLevelProduct`
--
DROP TABLE IF EXISTS `DangerLevelProduct`;

CREATE ALGORITHM=UNDEFINED DEFINER=`test`@`%` SQL SECURITY DEFINER VIEW `DangerLevelProduct`  AS  select `Product`.`ProductID` AS `ProductID`,`Product`.`ProductName` AS `ProductName`,`Product`.`ProductType` AS `ProductType`,`Product`.`ProductDescription` AS `ProductDescription`,`Product`.`ProductUnit` AS `ProductUnit`,`Product`.`ProductPrice` AS `ProductPrice`,`Product`.`ProductProcurementPrice` AS `ProductProcurementPrice`,`Product`.`VendorID` AS `VendorID`,`Product`.`ActualQuantity` AS `ActualQuantity`,`Product`.`ReserveQuantity` AS `ReserveQuantity`,`Product`.`ReorderLevel` AS `ReorderLevel`,`Product`.`DangerLevel` AS `DangerLevel` from `Product` where `Product`.`ActualQuantity` <= `Product`.`DangerLevel` and `Product`.`DangerLevel` <> 0 ;

-- --------------------------------------------------------

--
-- Structure for view `ProductSaleableQuantity`
--
DROP TABLE IF EXISTS `ProductSaleableQuantity`;

CREATE ALGORITHM=UNDEFINED DEFINER=`test`@`%` SQL SECURITY DEFINER VIEW `ProductSaleableQuantity`  AS  select `Product`.`ProductID` AS `ProductID`,`Product`.`ActualQuantity` - `Product`.`ReserveQuantity` AS `SaleableQuantity` from `Product` ;

-- --------------------------------------------------------

--
-- Structure for view `ReorderLevelProduct`
--
DROP TABLE IF EXISTS `ReorderLevelProduct`;

CREATE ALGORITHM=UNDEFINED DEFINER=`test`@`%` SQL SECURITY DEFINER VIEW `ReorderLevelProduct`  AS  select `Product`.`ProductID` AS `ProductID`,`Product`.`ProductName` AS `ProductName`,`Product`.`ProductType` AS `ProductType`,`Product`.`ProductDescription` AS `ProductDescription`,`Product`.`ProductUnit` AS `ProductUnit`,`Product`.`ProductPrice` AS `ProductPrice`,`Product`.`ProductProcurementPrice` AS `ProductProcurementPrice`,`Product`.`VendorID` AS `VendorID`,`Product`.`ActualQuantity` AS `ActualQuantity`,`Product`.`ReserveQuantity` AS `ReserveQuantity`,`Product`.`ReorderLevel` AS `ReorderLevel`,`Product`.`DangerLevel` AS `DangerLevel` from `Product` where `Product`.`ActualQuantity` <= `Product`.`ReorderLevel` and `Product`.`ActualQuantity` > `Product`.`DangerLevel` and `Product`.`ReorderLevel` <> 0 ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Dealer`
--
ALTER TABLE `Dealer`
  ADD PRIMARY KEY (`DealerID`);

--
-- Indexes for table `Department`
--
ALTER TABLE `Department`
  ADD PRIMARY KEY (`DepartmentID`);

--
-- Indexes for table `Product`
--
ALTER TABLE `Product`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `Product_ProductID_fk1` (`VendorID`);

--
-- Indexes for table `ReorderOrder`
--
ALTER TABLE `ReorderOrder`
  ADD PRIMARY KEY (`ReorderOrderID`),
  ADD KEY `ReorderOrder_StaffID_fk1` (`StaffID`);

--
-- Indexes for table `ReorderOrderLine`
--
ALTER TABLE `ReorderOrderLine`
  ADD PRIMARY KEY (`ReorderOrderID`,`ProductID`),
  ADD KEY `ReorderOrderLine_ProductID_fk2` (`ProductID`);

--
-- Indexes for table `SalesOrder`
--
ALTER TABLE `SalesOrder`
  ADD PRIMARY KEY (`SalesOrderID`),
  ADD KEY `SalesOrder_StaffID_fk1` (`StaffID`),
  ADD KEY `SalesOrder_DealerID_fk2` (`DealerID`);

--
-- Indexes for table `SalesOrderLine`
--
ALTER TABLE `SalesOrderLine`
  ADD PRIMARY KEY (`SalesOrderID`,`ProductID`),
  ADD KEY `SalesOrderLine_ProductID_fk2` (`ProductID`);

--
-- Indexes for table `Staff`
--
ALTER TABLE `Staff`
  ADD PRIMARY KEY (`StaffID`),
  ADD KEY `Staff_DepartmentID_fk1` (`DepartmentID`),
  ADD KEY `Staff_StaffPositionID_fk2` (`StaffPositionID`);

--
-- Indexes for table `StaffPosition`
--
ALTER TABLE `StaffPosition`
  ADD PRIMARY KEY (`StaffPositionID`);

--
-- Indexes for table `Vendor`
--
ALTER TABLE `Vendor`
  ADD PRIMARY KEY (`VendorID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Product`
--
ALTER TABLE `Product`
  ADD CONSTRAINT `Product_ProductID_fk1` FOREIGN KEY (`VendorID`) REFERENCES `Vendor` (`VendorID`);

--
-- Constraints for table `ReorderOrder`
--
ALTER TABLE `ReorderOrder`
  ADD CONSTRAINT `ReorderOrder_StaffID_fk1` FOREIGN KEY (`StaffID`) REFERENCES `Staff` (`StaffID`);

--
-- Constraints for table `ReorderOrderLine`
--
ALTER TABLE `ReorderOrderLine`
  ADD CONSTRAINT `ReorderOrderLine_ProductID_fk2` FOREIGN KEY (`ProductID`) REFERENCES `Product` (`ProductID`),
  ADD CONSTRAINT `ReorderOrder_ReorderOrderID_fk1` FOREIGN KEY (`ReorderOrderID`) REFERENCES `ReorderOrder` (`ReorderOrderID`);

--
-- Constraints for table `SalesOrder`
--
ALTER TABLE `SalesOrder`
  ADD CONSTRAINT `SalesOrder_DealerID_fk2` FOREIGN KEY (`DealerID`) REFERENCES `Dealer` (`DealerID`),
  ADD CONSTRAINT `SalesOrder_StaffID_fk1` FOREIGN KEY (`StaffID`) REFERENCES `Staff` (`StaffID`);

--
-- Constraints for table `SalesOrderLine`
--
ALTER TABLE `SalesOrderLine`
  ADD CONSTRAINT `SalesOrderLine_ProductID_fk2` FOREIGN KEY (`ProductID`) REFERENCES `Product` (`ProductID`),
  ADD CONSTRAINT `SalesOrderLine_SalesOrderID_fk1` FOREIGN KEY (`SalesOrderID`) REFERENCES `SalesOrder` (`SalesOrderID`);

--
-- Constraints for table `Staff`
--
ALTER TABLE `Staff`
  ADD CONSTRAINT `Staff_DepartmentID_fk1` FOREIGN KEY (`DepartmentID`) REFERENCES `Department` (`DepartmentID`),
  ADD CONSTRAINT `Staff_StaffPositionID_fk2` FOREIGN KEY (`StaffPositionID`) REFERENCES `StaffPosition` (`StaffPositionID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
