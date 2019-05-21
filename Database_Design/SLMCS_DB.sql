-- -----------------------------------------------------
-- Schema SLMCS_DB
-- -----------------------------------------------------
DROP DATABASE IF EXISTS `SLMCS_DB` ;

-- -----------------------------------------------------
-- Schema SLMCS_DB
-- -----------------------------------------------------
CREATE DATABASE `SLMCS_DB` DEFAULT CHARACTER SET utf8 ;
USE `SLMCS_DB` ;

-- -----------------------------------------------------
-- Table `SLMCS_DB`.`Dealer`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`Dealer` ;

CREATE TABLE `SLMCS_DB`.`Dealer` (
  `DealerID` VARCHAR(8) NOT NULL COMMENT 'Dealer ID, D +  7 digits',
  `DealerName` VARCHAR(50) NOT NULL COMMENT 'Dealer Name',
  `DealerShippingAddress` VARCHAR(80) NOT NULL COMMENT 'Dealer shipping address',
  `DealerPhoneNo` VARCHAR(11) NOT NULL COMMENT 'Dealer phone number',
  PRIMARY KEY (`DealerID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`Department`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`Department` ;

CREATE TABLE `SLMCS_DB`.`Department` (
  `DepartmentID` VARCHAR(2) NOT NULL COMMENT 'Company department ID, “HR”, ”SA”, ”WH”, “PO”, “FI”',
  `DepartmentName` VARCHAR(30) NOT NULL COMMENT 'Company department name',
  PRIMARY KEY (`DepartmentID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`Staff`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`Staff` ;

CREATE TABLE `SLMCS_DB`.`Staff` (
  `StaffID` VARCHAR(9) NOT NULL COMMENT 'Login account, S + Year (2 digits) + 6 digits',
  `Password` VARCHAR(30) NOT NULL COMMENT '5 digits with 1 upper case letter and 1 lower case letter',
  `PasswordChangeDate` DATETIME NOT NULL COMMENT 'for counting 30 days to change password',
  `StaffName` VARCHAR(50) NOT NULL COMMENT 'Staff full name',
  `StaffPhoneNo` VARCHAR(20) NOT NULL COMMENT 'Staff phone number',
  `StaffPosition` VARCHAR(20) NOT NULL COMMENT 'Staff position using for permission',
  `DepartmentID` VARCHAR(2) NOT NULL COMMENT 'Company department ID',
  PRIMARY KEY (`StaffID`),
  CONSTRAINT `Staff_StaffID_fk1`
    FOREIGN KEY (`DepartmentID`)
    REFERENCES `SLMCS_DB`.`Department` (`DepartmentID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`SalesOrder`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`SalesOrder` ;

CREATE TABLE `SLMCS_DB`.`SalesOrder` (
  `SalesOrderID` VARCHAR(14) NOT NULL COMMENT 'SO + yy+mm+dd + 6 digits',
  `StaffID` VARCHAR(9) NOT NULL COMMENT 'Staff ID',
  `DealerID` VARCHAR(8) NOT NULL COMMENT 'Dealer ID',
  `SalesOrderDate` DATETIME NOT NULL COMMENT 'Sales order date',
  `SalesOrderEditDate` DATETIME NULL COMMENT 'Sales order edited date',
  `SalesDispatchDate` DATETIME NULL COMMENT 'Pick up list date',
  `SalesDeliveryDate` DATETIME NULL COMMENT 'Delivery date of sales order',
  `SalesOrderStatus` VARCHAR(11) NOT NULL COMMENT '“Dispatching”, ”Dispatched”, “Shipping”,  “Shipped”, ”Completed”',
  PRIMARY KEY (`SalesOrderID`),
  CONSTRAINT `SalesOrder_StaffID_fk1`
    FOREIGN KEY (`StaffID`)
    REFERENCES `SLMCS_DB`.`Staff` (`StaffID`),
  CONSTRAINT `SalesOrder_DealerID_fk2`
    FOREIGN KEY (`DealerID`)
    REFERENCES `SLMCS_DB`.`Dealer` (`DealerID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`Vendor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`Vendor` ;

CREATE TABLE IF NOT EXISTS `SLMCS_DB`.`Vendor` (
  `VendorID` VARCHAR(8) NOT NULL COMMENT 'Vendor ID, V +  7 digits',
  `VendorName` VARCHAR(50) NOT NULL COMMENT 'Vendor name',
  `VendorAddress` VARCHAR(80) NOT NULL COMMENT 'Vendor address',
  `VendorPhoneNo` VARCHAR(11) NOT NULL COMMENT 'Vendor phone number',
  PRIMARY KEY (`VendorID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`Product`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`Product` ;

CREATE TABLE `SLMCS_DB`.`Product` (
  `ProductID` VARCHAR(6) NOT NULL COMMENT 'Product ID, Category letter + 5 digit',
  `ProductName` VARCHAR(50) NOT NULL COMMENT 'Product name',
  `ProductDescription` VARCHAR(10) NOT NULL COMMENT 'Product description',
  `ProductUnit` VARCHAR(10) NOT NULL COMMENT 'Product unit',
  `ProductPrice` INT NOT NULL COMMENT 'Product price',
  `ProductProcurementPrice` INT NOT NULL COMMENT 'Price of procurement in specific product',
  `VendorID` VARCHAR(8) NOT NULL COMMENT 'Vendor ID',
  `ActualVolume` VARCHAR(10) NOT NULL DEFAULT 0 COMMENT 'Stock quantity that stores in the inventory',
  PRIMARY KEY (`ProductID`),
  CONSTRAINT `Product_ProductID_fk1`
    FOREIGN KEY (`VendorID`)
    REFERENCES `SLMCS_DB`.`Vendor` (`VendorID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`SalesOrderLine`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`SalesOrderLine` ;

CREATE TABLE `SLMCS_DB`.`SalesOrderLine` (
  `SalesOrderID` VARCHAR(14) NOT NULL COMMENT 'Sales order ID',
  `ProductID` VARCHAR(6) NOT NULL COMMENT 'Product ID',
  `Quantity` INT NOT NULL COMMENT 'Product quantity in specific sales order',
  `ProductPrice` INT NOT NULL COMMENT 'Prodcut price',
  PRIMARY KEY (`SalesOrderID`, `ProductID`),
  CONSTRAINT `SalesOrderLine_SalesOrderID_fk1`
    FOREIGN KEY (`SalesOrderID`)
    REFERENCES `SLMCS_DB`.`SalesOrder` (`SalesOrderID`),
  CONSTRAINT `SalesOrderLine_ProductID_fk2`
    FOREIGN KEY (`ProductID`)
    REFERENCES `SLMCS_DB`.`Product` (`ProductID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`ProcurementOrder`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`ProcurementOrder` ;

CREATE TABLE `SLMCS_DB`.`ProcurementOrder` (
  `ProcurementOrderID` VARCHAR(14) NOT NULL COMMENT 'Procurement order ID, PO + yy+mm+dd + 6 digits',
  `StaffID` VARCHAR(9) NOT NULL COMMENT 'Staff ID',
  `VendorID` VARCHAR(8) NOT NULL COMMENT 'Vendor ID',
  `ProcurementOrderDate` DATETIME NOT NULL COMMENT 'Procurement order date',
  `ProcurementOrderEditDate` DATETIME NULL COMMENT 'procurement order edited date',
  `ProcurementGoodReceiveDate` DATETIME NULL COMMENT 'Good receive date',
  `ProcurementOrderStatus` VARCHAR(11) NOT NULL COMMENT 'Procurement order status, “Processing”, “Completed”',
  PRIMARY KEY (`ProcurementOrderID`),
  CONSTRAINT `ProcurementOrder_StaffID_fk1`
    FOREIGN KEY (`StaffID`)
    REFERENCES `SLMCS_DB`.`Staff` (`StaffID`),
  CONSTRAINT `ProcurementOrder_VendorID_fk2`
    FOREIGN KEY (`VendorID`)
    REFERENCES `SLMCS_DB`.`Vendor` (`VendorID`));


-- -----------------------------------------------------
-- Table `SLMCS_DB`.`ProcurementOrderLine`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SLMCS_DB`.`ProcurementOrderLine` ;

CREATE TABLE `SLMCS_DB`.`ProcurementOrderLine` (
  `ProcurementOrderID` VARCHAR(14) NOT NULL COMMENT 'Procurement order ID',
  `ProductID` VARCHAR(6) NOT NULL COMMENT 'Product ID',
  `Quantity` INT NOT NULL COMMENT 'Product quantity in specific procurement order',
  `ProductProcurementPrice` INT NOT NULL COMMENT 'Price of procurement in specific product',
  PRIMARY KEY (`ProcurementOrderID`, `ProductID`),
  CONSTRAINT `ProcurementOrderLine_ProcurementOrderID_fk1`
    FOREIGN KEY (`ProcurementOrderID`)
    REFERENCES `SLMCS_DB`.`ProcurementOrder` (`ProcurementOrderID`),
  CONSTRAINT `ProcurementOrderLine_ProductID_fk2`
    FOREIGN KEY (`ProductID`)
    REFERENCES `SLMCS_DB`.`Product` (`ProductID`));
