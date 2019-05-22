-- -----------------------------------------------------
-- Schema SLMCS_DB
-- -----------------------------------------------------
DROP DATABASE IF EXISTS SLMCS_DB ;

-- -----------------------------------------------------
-- Schema SLMCS_DB
-- -----------------------------------------------------
CREATE DATABASE SLMCS_DB DEFAULT CHARACTER SET utf8 ;
USE SLMCS_DB ;

-- -----------------------------------------------------
-- Table Dealer
-- -----------------------------------------------------
DROP TABLE IF EXISTS Dealer ;

CREATE TABLE Dealer (
  DealerID VARCHAR(8) NOT NULL COMMENT 'Dealer ID, D +  7 digits',
  DealerName VARCHAR(50) NOT NULL COMMENT 'Dealer Name',
  DealerShippingAddress VARCHAR(80) NOT NULL COMMENT 'Dealer shipping address',
  DealerPhoneNo VARCHAR(11) NOT NULL COMMENT 'Dealer phone number',
  PRIMARY KEY (DealerID)
);


-- -----------------------------------------------------
-- Table Department
-- -----------------------------------------------------
DROP TABLE IF EXISTS Department ;

CREATE TABLE Department (
  DepartmentID VARCHAR(2) NOT NULL COMMENT 'Company department ID, “HR”, ”SA”, ”WH”, “PO”, “FI”',
  DepartmentName VARCHAR(30) NOT NULL COMMENT 'Company department name',
  PRIMARY KEY (DepartmentID)
);


-- -----------------------------------------------------
-- Table StaffPosition
-- -----------------------------------------------------
DROP TABLE IF EXISTS StaffPosition ;

CREATE TABLE StaffPosition (
  StaffPositionID VARCHAR(2) NOT NULL COMMENT 'Staff position ID',
  PositionName VARCHAR(7) NOT NULL COMMENT 'Position Name',
  PRIMARY KEY (StaffPositionID)
);

-- -----------------------------------------------------
-- Table Staff
-- -----------------------------------------------------
DROP TABLE IF EXISTS Staff ;

CREATE TABLE Staff (
  StaffID VARCHAR(9) NOT NULL COMMENT 'Login account, S + Year (2 digits) + 6 digits',
  Password VARCHAR(30) NOT NULL COMMENT '5 digits with 1 upper case letter and 1 lower case letter',
  PasswordChangeDate DATETIME NOT NULL COMMENT 'for counting 30 days to change password',
  StaffName VARCHAR(50) NOT NULL COMMENT 'Staff full name',
  StaffPhoneNo VARCHAR(11) NOT NULL COMMENT 'Staff phone number',
  StaffPositionID VARCHAR(2) NOT NULL COMMENT 'Staff position using for permission',
  DepartmentID VARCHAR(2) NOT NULL COMMENT 'Company department ID',
  PRIMARY KEY (StaffID),
  CONSTRAINT Staff_DepartmentID_fk1
    FOREIGN KEY (DepartmentID)
    REFERENCES Department (DepartmentID),
  CONSTRAINT Staff_StaffPositionID_fk2
    FOREIGN KEY (StaffPositionID)
    REFERENCES StaffPosition (StaffPositionID)
);


-- -----------------------------------------------------
-- Table SalesOrder
-- -----------------------------------------------------
DROP TABLE IF EXISTS SalesOrder ;

CREATE TABLE SalesOrder (
  SalesOrderID VARCHAR(14) NOT NULL COMMENT 'SO + yy+mm+dd + 6 digits',
  StaffID VARCHAR(9) NOT NULL COMMENT 'Staff ID',
  DealerID VARCHAR(8) NOT NULL COMMENT 'Dealer ID',
  SalesOrderDate DATETIME NOT NULL COMMENT 'Sales order date',
  SalesOrderEditDate DATETIME NULL COMMENT 'Sales order edited date',
  SalesDispatchDate DATETIME NULL COMMENT 'Pick up list date',
  SalesDeliveryDate DATETIME NULL COMMENT 'Delivery date of sales order',
  SalesOrderStatus VARCHAR(11) NOT NULL COMMENT '“Dispatching”, ”Dispatched”, “Shipping”,  “Shipped”, ”Completed”',
  PRIMARY KEY (SalesOrderID),
  CONSTRAINT SalesOrder_StaffID_fk1
    FOREIGN KEY (StaffID)
    REFERENCES Staff (StaffID),
  CONSTRAINT SalesOrder_DealerID_fk2
    FOREIGN KEY (DealerID)
    REFERENCES Dealer (DealerID)
);


-- -----------------------------------------------------
-- Table Vendor
-- -----------------------------------------------------
DROP TABLE IF EXISTS Vendor ;

CREATE TABLE IF NOT EXISTS Vendor (
  VendorID VARCHAR(8) NOT NULL COMMENT 'Vendor ID, V +  7 digits',
  VendorName VARCHAR(50) NOT NULL COMMENT 'Vendor name',
  VendorAddress VARCHAR(80) NOT NULL COMMENT 'Vendor address',
  VendorPhoneNo VARCHAR(11) NOT NULL COMMENT 'Vendor phone number',
  PRIMARY KEY (VendorID)
);


-- -----------------------------------------------------
-- Table Product
-- -----------------------------------------------------
DROP TABLE IF EXISTS Product ;

CREATE TABLE Product (
  ProductID VARCHAR(6) NOT NULL COMMENT 'Product ID, Category letter + 5 digit',
  ProductName VARCHAR(50) NOT NULL COMMENT 'Product name',
  ProductDescription VARCHAR(100) NOT NULL COMMENT 'Product description',
  ProductUnit VARCHAR(10) NOT NULL COMMENT 'Product unit',
  ProductPrice INT(10) NOT NULL COMMENT 'Product price',
  ProductProcurementPrice INT(10) NOT NULL COMMENT 'Price of procurement in specific product',
  VendorID VARCHAR(8) NOT NULL COMMENT 'Vendor ID',
  ActualVolume INT(10) NOT NULL DEFAULT 0 COMMENT 'Stock quantity that stores in the inventory',
  PRIMARY KEY (ProductID),
  CONSTRAINT Product_ProductID_fk1
    FOREIGN KEY (VendorID)
    REFERENCES Vendor (VendorID)
);


-- -----------------------------------------------------
-- Table SalesOrderLine
-- -----------------------------------------------------
DROP TABLE IF EXISTS SalesOrderLine ;

CREATE TABLE SalesOrderLine (
  SalesOrderID VARCHAR(14) NOT NULL COMMENT 'Sales order ID',
  ProductID VARCHAR(6) NOT NULL COMMENT 'Product ID',
  Quantity INT(10) NOT NULL COMMENT 'Product quantity in specific sales order',
  ProductPrice INT(10) NOT NULL COMMENT 'Prodcut price',
  PRIMARY KEY (SalesOrderID, ProductID),
  CONSTRAINT SalesOrderLine_SalesOrderID_fk1
    FOREIGN KEY (SalesOrderID)
    REFERENCES SalesOrder (SalesOrderID),
  CONSTRAINT SalesOrderLine_ProductID_fk2
    FOREIGN KEY (ProductID)
    REFERENCES Product (ProductID)
);


-- -----------------------------------------------------
-- Table ProcurementOrder
-- -----------------------------------------------------
DROP TABLE IF EXISTS ProcurementOrder ;

CREATE TABLE ProcurementOrder (
  ProcurementOrderID VARCHAR(14) NOT NULL COMMENT 'Procurement order ID, PO + yy+mm+dd + 6 digits',
  StaffID VARCHAR(9) NOT NULL COMMENT 'Staff ID',
  VendorID VARCHAR(8) NOT NULL COMMENT 'Vendor ID',
  ProcurementOrderDate DATETIME NOT NULL COMMENT 'Procurement order date',
  ProcurementOrderEditDate DATETIME NULL COMMENT 'procurement order edited date',
  ProcurementGoodReceiveDate DATETIME NULL COMMENT 'Good receive date',
  ProcurementOrderStatus VARCHAR(11) NOT NULL COMMENT 'Procurement order status, “Processing”, “Completed”',
  PRIMARY KEY (ProcurementOrderID),
  CONSTRAINT ProcurementOrder_StaffID_fk1
    FOREIGN KEY (StaffID)
    REFERENCES Staff (StaffID),
  CONSTRAINT ProcurementOrder_VendorID_fk2
    FOREIGN KEY (VendorID)
    REFERENCES Vendor (VendorID)
);


-- -----------------------------------------------------
-- Table ProcurementOrderLine
-- -----------------------------------------------------
DROP TABLE IF EXISTS ProcurementOrderLine ;

CREATE TABLE ProcurementOrderLine (
  ProcurementOrderID VARCHAR(14) NOT NULL COMMENT 'Procurement order ID',
  ProductID VARCHAR(6) NOT NULL COMMENT 'Product ID',
  Quantity INT(10) NOT NULL COMMENT 'Product quantity in specific procurement order',
  ProductProcurementPrice INT(10) NOT NULL COMMENT 'Price of procurement in specific product',
  PRIMARY KEY (ProcurementOrderID, ProductID),
  CONSTRAINT ProcurementOrderLine_ProcurementOrderID_fk1
    FOREIGN KEY (ProcurementOrderID)
    REFERENCES ProcurementOrder (ProcurementOrderID),
  CONSTRAINT ProcurementOrderLine_ProductID_fk2
    FOREIGN KEY (ProductID)
    REFERENCES Product (ProductID)
);
