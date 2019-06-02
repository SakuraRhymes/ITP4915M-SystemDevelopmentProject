-- -----------------------------------------------------
-- Table ReorderOrder
-- -----------------------------------------------------
DROP TABLE IF EXISTS ReorderOrder ;

CREATE TABLE ReorderOrder (
  ReorderOrderID VARCHAR(14) NOT NULL COMMENT 'SO + yy+mm+dd + 6 digits',
  StaffID VARCHAR(9) NOT NULL COMMENT 'Staff ID',
  ReorderOrderDate DATETIME NOT NULL COMMENT 'Reorder order date',
  ReorderOrderEditDate DATETIME NULL COMMENT 'Reorder order edited date',
  ReorderOrderCompletedDate DATETIME NULL COMMENT 'Reorder Order complete date',
  ReorderOrderStatus VARCHAR(11) NOT NULL COMMENT '“Processing”, ”Completed”, “Canceled”',
  PRIMARY KEY (ReorderOrderID),
  CONSTRAINT ReorderOrder_StaffID_fk1
    FOREIGN KEY (StaffID)
    REFERENCES Staff (StaffID)
);

-- -----------------------------------------------------
-- Table ReorderOrderLine
-- -----------------------------------------------------
DROP TABLE IF EXISTS ReorderOrderLine ;

CREATE TABLE ReorderOrderLine (
  ReorderOrderID VARCHAR(14) NOT NULL COMMENT 'Sales order ID',
  ProductID VARCHAR(6) NOT NULL COMMENT 'Product ID',
  Quantity INT(10) NOT NULL COMMENT 'Product quantity in specific sales order',
  PRIMARY KEY (ReorderOrderID, ProductID),
  CONSTRAINT ReorderOrder_ReorderOrderID_fk1
    FOREIGN KEY (ReorderOrderID)
    REFERENCES ReorderOrder (ReorderOrderID),
  CONSTRAINT ReorderOrderLine_ProductID_fk2
    FOREIGN KEY (ProductID)
    REFERENCES Product (ProductID)
);