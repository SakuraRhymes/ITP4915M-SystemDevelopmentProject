SET NAMES 'utf8';
USE SLMCS_DB;
--
-- Delete data from the table 'Dealer'
--
DELETE FROM Dealer;

--
-- Inserting data into table Dealer
--
INSERT INTO Dealer(DealerID, DealerName, DealerShippingAddress, DealerPhoneNo) VALUES
('D0000000', 'Letha', '240 Hidden Front Way', '80460192228'),
('D0000001', 'Kraig', '2948 Stonewood Pkwy', '68490827623'),
('D0000002', 'Harlan', '44 West Church Ct', '00368767478'),
('D0000003', 'Brad', '3778 Edgewood Highway', '64449631587'),
('D0000004', 'Enrique', '12 1st Circle', '84009375351'),
('D0000005', 'Bennie', '3570 Flintwood Parkway', '34115891693'),
('D0000006', 'Francis', '1790 SW Church Avenue', '79570539869'),
('D0000007', 'Nickie', '2014 Social Road', '53293261764'),
('D0000008', 'Boyd', '34 Riddle Hill Pkwy', '57335893201'),
('D0000009', 'Alonzo', '65 Waterview Avenue', '48823116874'),
('D0000010', 'Reed', '3760 West Social Parkway', '01414516278'),
('D0000011', 'Cory', '1254 New Cedar Tree Rd', '22183842355'),
('D0000012', 'Abbie', '2354 N Cedar Tree Hwy', '62976086964'),
('D0000013', 'Lazaro', '95 North Church Road', '65249368582'),
('D0000014', 'Danielle', '47 W Ashwood Avenue', '04878184404'),
('D0000015', 'Gregorio', '2455 Buttonwood Ln', '62008942994'),
('D0000016', 'Monty', '10 Social Lane', '74266355509'),
('D0000017', 'Abby', '633 New Parkwood St', '89203167930'),
('D0000018', 'Evelin', '2762 Buttonwood Road', '63438151769'),
('D0000019', 'Earline', '1027 NW Ashwood Cir', '27007622225'),
('D0000020', 'Viviana', '38 South Mount Highway', '99070628884'),
('D0000021', 'Chae', '2795 East Lake Ct', '50437058002'),
('D0000022', 'Delta', '1063 SW Hope Pkwy', '36884763047'),
('D0000023', 'Toney', '3172 Deepwood Blvd', '15944328100'),
('D0000024', 'Wynell', '582 Rushwood Court', '27868892048'),
('D0000025', 'Ashley', '994 SW Glenwood Parkway', '24810650561'),
('D0000026', 'Ressie', '1136 SW Ashwood St', '41300364487'),
('D0000027', 'Shane', '36 NE Hunting Hill Way', '98175045510'),
('D0000028', 'Raleigh', '105 Old Deepwood Lane', '63294076195'),
('D0000029', 'Jean', '777 Pine Tree Pkwy', '41724714178'),
('D0000030', 'Roosevelt', '75 Riverside Rd', '44786222330'),
('D0000031', 'Alanna', '3474 New Farmview St', '03902968983'),
('D0000032', 'Lilliana', '255 Edgewood Street', '73937286219'),
('D0000033', 'Amiee', '71 Buttonwood Way', '40421088056'),
('D0000034', 'Rene', '2049 North Chapel Hill Street', '59987909086'),
('D0000035', 'Demarcus', '81 Old Mountain Ln', '03823586550'),
('D0000036', 'Ashley', '476 Rushwood Pkwy', '18343228666'),
('D0000037', 'Abel', '139 Mount Hwy', '90933765765'),
('D0000038', 'Ali', '1296 Beachwood Way', '41095746857'),
('D0000039', 'Clark', '2052 Mountain Lane', '85547482635'),
('D0000040', 'Adam', '2429 Rock Hill Highway', '86309795357'),
('D0000041', 'Gayle', '2402 East Rockwood Pkwy', '14621640212'),
('D0000042', 'Kristy', '685 Rock Hill Loop', '50949104899'),
('D0000043', 'Ryan', '10 North Highland Blvd', '36874051522'),
('D0000044', 'Marjory', '701 Ski Hill Drive', '97679513520'),
('D0000045', 'Christopher', '2744 New Rock Hill Way', '14620830031'),
('D0000046', 'Abraham', '665 SW Waterview Court', '86033027147'),
('D0000047', 'Lavelle', '11 Rock Hill Hwy', '82066910841'),
('D0000048', 'Brigida', '802 Oak Blvd', '00341090574'),
('D0000049', 'Cristobal', '2035 Mountain Pkwy', '99704973998');

--
-- Delete data from the table 'Department'
--
DELETE FROM Department;

--
-- Inserting data into table Department
--
INSERT INTO Department VALUES ('HR', 'Personnel');
INSERT INTO Department VALUES ('SA', 'Sales');
INSERT INTO Department VALUES ('WH', 'Warehouse');
INSERT INTO Department VALUES ('PO', 'Procurement');
INSERT INTO Department VALUES ('FI', 'Finance');

--
-- Delete data from the table 'StaffPosition'
--
DELETE FROM StaffPosition;

--
-- Inserting data into table StaffPosition
--
INSERT INTO StaffPosition VALUES ('01', 'Staff');
INSERT INTO StaffPosition VALUES ('02', 'Manager');

--
-- Delete data from the table 'Staff'
--
DELETE FROM Staff;

--
-- Inserting data into table Staff
--
INSERT INTO Staff(StaffID, Password, PasswordChangeDate, StaffName, StaffPhoneNo, StaffPositionID, DepartmentID) VALUES
('S19627333', 'KSXcBtq23', '2019-04-21 20:49:26', 'Draper', '80460192228', '01', 'SA'),
('S19565771', 'LBdrqRl39', '2019-04-02 12:46:04', 'Schaeffer', '68490827623', '01', 'WH'),
('S19184512', '98b8M66r1', '2019-01-01 02:05:35', 'Alicea', '00368767478', '02', 'HR'),
('S19811427', 'xG38MEX8u', '2019-04-29 10:05:04', 'Nowak', '64449631587', '02', 'HR'),
('S19187179', 'Rxvvj6NSx', '2019-05-14 10:33:42', 'Brice', '84009375351', '01', 'WH'),
('S19867589', 'zvIYd2TPq', '2019-05-03 22:28:13', 'Allan', '34115891693', '01', 'WH'),
('S19067625', '7L9q2ey79', '2019-01-01 00:09:27', 'Gonsalves', '79570539869', '01', 'SA'),
('S19167524', 'e3c6694Pl', '2019-01-01 00:15:15', 'Drayton', '53293261764', '01', 'WH'),
('S19386854', '0Tbpr37GZ', '2019-04-22 08:35:35', 'Longo', '57335893201', '02', 'HR'),
('S19336525', 'LM8NO863z', '2019-02-18 23:01:47', 'Gonzales', '48823116874', '01', 'SA'),
('S19239223', '1YquJK1OH', '2019-04-20 10:02:09', 'Roberge', '01414516278', '01', 'SA'),
('S19387982', '20dD9n706', '2019-01-01 00:00:31', 'Nowlin', '22183842355', '02', 'HR'),
('S19739794', 'FcdxT11f6', '2019-02-28 06:54:27', 'Roberson', '62976086964', '01', 'WH'),
('S19264217', 'JG5p40l30', '2019-03-06 01:23:22', 'Drew', '65249368582', '01', 'PO'),
('S19563696', 'aldCTs5bp', '2019-01-01 00:00:14', 'Gonzalez', '04878184404', '01', 'SA'),
('S19812649', '85AE7up4j', '2019-01-29 16:05:51', 'Driscoll', '62008942994', '01', 'SA'),
('S19753172', 'smaEj494j', '2019-02-16 05:59:40', 'Tirado', '74266355509', '01', 'WH'),
('S19224157', 'dCtIqpqYU', '2019-01-05 14:22:56', 'Schafer', '89203167930', '02', 'FI'),
('S19908330', '46VHeR877', '2019-01-01 00:00:06', 'Hughey', '63438151769', '01', 'SA'),
('S19818781', '67awiai0s', '2019-02-22 00:05:16', 'Gooch', '27007622225', '01', 'WH'),
('S19692949', '5B39ghZ52', '2019-01-01 02:16:16', 'Bridges', '99070628884', '02', 'HR'),
('S19696250', 'He9Bb9MX7', '2019-01-01 00:57:14', 'Allard', '50437058002', '01', 'PO'),
('S19966985', 'KSwwJ3VvI', '2019-05-15 13:38:07', 'Briggs', '36884763047', '01', 'PO'),
('S19624138', 'HX6eP2poI', '2019-01-01 00:10:47', 'Driver', '15944328100', '01', 'WH'),
('S19935161', '0SKnu0Uuj', '2019-05-21 11:43:25', 'Gooden', '27868892048', '01', 'SA'),
('S19693787', 'b5zqoKpWa', '2019-02-20 15:25:09', 'Noyes', '24810650561', '01', 'PO'),
('S19002708', 'u1s5tw051', '2019-01-13 16:02:35', 'Tisdale', '41300364487', '01', 'PO'),
('S19547398', 'dr29Ah8KZ', '2019-03-24 20:32:23', 'Schaffer', '98175045510', '01', 'WH'),
('S19105923', 'R2J89jNb9', '2019-01-25 00:31:02', 'Titus', '63294076195', '02', 'HR'),
('S19181657', 'wJeW8fL9Y', '2019-03-28 16:34:51', 'Schell', '41724714178', '02', 'HR'),
('S19071264', 'hWx2C0H62', '2019-05-03 14:41:39', 'Longoria', '44786222330', '01', 'SA'),
('S19976951', 'x012jpLlb', '2019-01-01 00:10:23', 'Drummond', '03902968983', '01', 'PO'),
('S19852605', 'KxlrIWUpF', '2019-04-07 18:28:06', 'Robert', '73937286219', '01', 'PO'),
('S19026963', '9jKMvYP47', '2019-01-27 14:54:08', 'Tobias', '40421088056', '01', 'SA'),
('S19933986', 'FV99UMR6i', '2019-04-17 02:44:47', 'Hull', '59987909086', '01', 'SA'),
('S19611273', 'V8kqsk6H8', '2019-01-01 00:00:05', 'Nugent', '03823586550', '01', 'WH'),
('S19225176', '6r3Dn8b0S', '2019-01-09 15:18:58', 'Goodman', '18343228666', '01', 'SA'),
('S19386857', 'XJZF509Nn', '2019-01-01 00:01:38', 'Drury', '90933765765', '01', 'SA'),
('S19431523', 'K3rm4OnGx', '2019-05-18 03:51:14', 'Scherer', '41095746857', '01', 'SA'),
('S19521873', 'fH1g0Rm0x', '2019-02-02 02:08:34', 'Allen', '85547482635', '01', 'SA'),
('S19439645', 'DBw8lSgbh', '2019-01-01 00:00:58', 'Bright', '86309795357', '01', 'PO'),
('S19050007', '2tgLVK0TJ', '2019-01-01 00:51:28', 'Tobin', '14621640212', '01', 'SA'),
('S19375261', '4S0B0ChJb', '2019-01-01 00:00:54', 'Alley', '50949104899', '01', 'SA'),
('S19242668', 'wwvIoukcF', '2019-01-01 00:06:23', 'Goodrich', '36874051522', '01', 'SA'),
('S19235414', 'hz102MOiT', '2019-01-01 00:04:04', 'Duarte', '97679513520', '01', 'SA'),
('S19655018', 'ymm7w4V1t', '2019-04-18 13:57:56', 'Roberts', '14620830031', '02', 'FI'),
('S19958817', 'SxhkGBIGu', '2019-04-01 22:55:48', 'Schiller', '86033027147', '01', 'PO'),
('S19756871', '6ck68Y9Ja', '2019-04-14 01:53:44', 'Goodson', '82066910841', '01', 'PO'),
('S19827432', 'q7nyRCwtB', '2019-03-11 23:23:15', 'Loomis', '00341090574', '01', 'PO'),
('S19319037', 'ZrAd6qhdW', '2019-05-06 16:40:55', 'Brill', '99704973998', '01', 'SA');

--
-- Delete data from the table 'Vendor'
--
DELETE FROM Vendor;

--
-- Inserting data into table Vendor
--
INSERT INTO Vendor(VendorID, VendorName, VendorAddress, VendorPhoneNo) VALUES
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

--
-- Delete data from the table 'Product'
--
DELETE FROM Product;

--
-- Inserting data into table Product
--
INSERT INTO Product(ProductID, ProductName, ProductDescription, ProductUnit, ProductPrice, ProductProcurementPrice, VendorID, ActualVolume) VALUES
('D68570', 'Monofindoller', 'Quae error ad dolore. Labore itaque autem nihil modi! Sit eius. Itaque sit!', 'piece', 3528, 460, 'V0000008', 446),
('A27271', 'Cleantopefon', 'Aut aliquam consequatur culpa doloribus. Numquam placeat! Maiores quos? Non!', 'item', 2772, 1195, 'V0000001', 686),
('C02467', 'Transceivscope', 'Cum quam aut labore. Voluptatem veniam. Magnam magni sunt reprehenderit?', 'item', 2649, 479, 'V0000002', 495),
('B03019', 'Readculor', 'Obcaecati deleniti incidunt sequi. Amet fugiat ut? Blanditiis sed. Ut earum!', 'item', 2891, 856, 'V0000002', 756),
('D96161', 'Contopedgor', 'Sit consequuntur nihil. Molestiae quos officia et; est natus. Doloremque ut!', 'item', 4129, 286, 'V0000007', 322),
('C36750', 'Readtinaquer', 'Voluptas unde harum dolores odit. Officia aspernatur facere libero omnis?', 'set', 2916, 291, 'V0000004', 486),
('D13439', 'Monlescope', 'Praesentium sequi. Eaque hic voluptatem iste. Corporis ipsam. Ipsa quia.', 'set', 2184, 239, 'V0000003', 766),
('D21694', 'Stereolifiridge', 'Iste ab omnis et. Ea magni excepturi. Vitae molestias! Ut minima.', 'set', 2680, 1107, 'V0000003', 171),
('B35234', 'Cartnierentor', 'Tempore unde soluta. Architecto laudantium. Aspernatur natus error! Est omnis.', 'set', 2676, 230, 'V0000008', 360),
('B35930', 'Micnientor', 'Minus totam laboriosam. Omnis possimus. Iste dolorem! Est natus. Dolores.', 'piece', 1791, 901, 'V0000001', 95),
('C33253', 'Rejectlet', 'Unde quae. Blanditiis modi quo vero ratione.', 'item', 3487, 714, 'V0000001', 60),
('D06622', 'Miclifiedgor', 'Maxime possimus amet obcaecati necessitatibus. Natus quasi est cupiditate.', 'set', 3641, 504, 'V0000006', 881),
('C45678', 'Transceiver', 'Cumque obcaecati similique neque praesentium.', 'item', 2384, 534, 'V0000001', 416),
('A81405', 'Readtaerer', 'Vero dolore quo error rem.', 'item', 4334, 150, 'V0000005', 775),
('C48859', 'Subwoofgaer', 'Et excepturi ratione porro. Voluptas tempore temporibus non! Sit explicabo.', 'piece', 3647, 334, 'V0000004', 821),
('D27864', 'Conceivphone', 'Aut unde magni. Quia deleniti? Nesciunt natus unde; alias vel id.', 'set', 2021, 261, 'V0000001', 830),
('D38300', 'Mictopepor', 'Velit in exercitationem voluptatem. Placeat enim laudantium illum officiis.', 'set', 3616, 399, 'V0000001', 505),
('A71801', 'Montaphone', 'Sed et. Voluptatem unde est explicabo voluptas.', 'set', 1874, 766, 'V0000008', 2),
('D92786', 'Armcycllet', 'Qui perferendis. Ut labore et veritatis. At voluptate quis.', 'piece', 4848, 973, 'V0000007', 861),
('A76337', 'Tweetleefra', 'Dolore sed. Repudiandae aut nihil. Dolorem repellat. Placeat quia. Quasi rem!', 'set', 4123, 375, 'V0000003', 495),
('A66046', 'Supwoofewry', 'Ducimus unde qui dolore placeat.', 'set', 4426, 332, 'V0000007', 179),
('B24945', 'Monjectplridge', 'Voluptatem non quo voluptas velit. Repellendus iure qui temporibus!', 'set', 3096, 572, 'V0000007', 559),
('B99769', 'Micplottor', 'Architecto iste. Dolores iste doloremque sequi enim.', 'item', 4915, 666, 'V0000002', 825),
('A72990', 'Comniedgscope', 'Ut est. Sit excepturi omnis. Dolor vel; aut vel delectus.', 'item', 4850, 555, 'V0000007', 526),
('D56780', 'Speaktaoller', 'Et quia sint. Perspiciatis ipsa autem. Veniam tempora! Omnis aspernatur.', 'item', 4838, 887, 'V0000003', 4),
('C97966', 'Charlictry', 'Dignissimos omnis. Necessitatibus dolores mollitia dicta ipsa.', 'piece', 4171, 816, 'V0000005', 554),
('A07364', 'Readpickor', 'Velit dolores est. Voluptatibus quidem! Quaerat exercitationem. Voluptatum;', 'item', 2369, 308, 'V0000007', 766),
('B40813', 'Transplottentor', 'Corporis iste error quia omnis. Consectetur voluptatem laudantium...', 'piece', 1712, 1188, 'V0000005', 939),
('C56796', 'Amptopplentor', 'Laboriosam debitis ipsam quaerat doloremque.', 'set', 1911, 446, 'V0000006', 121),
('D91056', 'Transholder', 'Eaque itaque. Iure quae. Maxime eligendi sequi iste fugiat...', 'set', 4278, 912, 'V0000004', 97),
('D30253', 'Moncyclupra', 'Qui quia optio iste. Qui aut! Nesciunt quisquam. Deserunt ullam.', 'piece', 4938, 124, 'V0000001', 599),
('A67285', 'Printculentor', 'Qui assumenda qui possimus voluptatem. Totam dolorum! Iste facilis. Omnis!', 'set', 2441, 577, 'V0000004', 458),
('B42223', 'Speaktiner', 'Quod incidunt magni cum dolor.', 'set', 1681, 1052, 'V0000004', 703),
('A67756', 'Supcessor', 'Neque ullam nobis qui. Voluptatem iste aut et ea...', 'set', 2814, 746, 'V0000001', 433),
('B20367', 'Cleanjectader', 'Et temporibus rem voluptas sunt. Repudiandae ratione minima labore.', 'set', 4721, 819, 'V0000003', 884),
('D54566', 'Amptopra', 'Et aut blanditiis et. Iste laudantium consectetur! Fugiat ipsa. Non fugit.', 'set', 2852, 247, 'V0000001', 503),
('D40242', 'Conmutar', 'Autem a rerum corporis. Tempore impedit! Vitae error. Et veritatis.', 'set', 1573, 913, 'V0000005', 143),
('D54455', 'Tetaer', 'Aut in unde dicta repudiandae. Ut quo aliquam nisi...', 'set', 3600, 377, 'V0000007', 978),
('C16722', 'Tabcordlet', 'Et quod. Hic non reiciendis aliquam aspernatur.', 'set', 4548, 172, 'V0000006', 93),
('A01253', 'Cartcordexphone', 'Corrupti veritatis ratione non. Ratione laudantium voluptatem; sit id.', 'item', 3445, 1010, 'V0000003', 292),
('A04546', 'Biholder', 'Maiores quis quos minima. Perspiciatis est et! Obcaecati vel. Qui quia!', 'set', 3955, 448, 'V0000005', 84),
('D22604', 'Rejectefer', 'Aut sapiente accusamus itaque. Quia cupiditate. Eligendi perspiciatis.', 'set', 1871, 366, 'V0000008', 8),
('B09673', 'Tweetmuter', 'Mollitia nulla laborum magnam. Quia qui voluptatem. Omnis ut perferendis.', 'piece', 3018, 492, 'V0000005', 85),
('A92852', 'Concordar', 'Voluptas id fuga. Suscipit minus nesciunt. Explicabo nobis unde!', 'set', 3286, 421, 'V0000001', 870),
('B60928', 'Armputphone', 'Et ut tempora magnam; eveniet ipsa. Architecto dolores; qui deserunt.', 'set', 1982, 585, 'V0000001', 302),
('A28525', 'Stereofindedator', 'Molestiae mollitia. Aut voluptatem iste voluptas. Eos sed iste velit!', 'item', 4343, 201, 'V0000007', 47),
('C94311', 'Tabtelladar', 'Iure qui. Inventore aliquid. Enim iste odio culpa! Autem praesentium ut.', 'item', 4223, 823, 'V0000001', 7),
('B83923', 'Tablifior', 'Quis praesentium iste in. Iure ut earum minus. Suscipit obcaecati.', 'item', 4202, 510, 'V0000004', 832),
('A90524', 'Projectry', 'Odio sint non sequi magni. Earum consequatur? Iste sed! Sit error.', 'set', 2751, 1022, 'V0000008', 659),
('A44616', 'Transculewra', 'Et aut. Ullam voluptas tempore suscipit nesciunt.', 'item', 3053, 685, 'V0000002', 497);