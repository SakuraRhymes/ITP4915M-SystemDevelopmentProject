USE DB07062019 ;

CREATE VIEW ReorderLevelProduct AS
SELECT * FROM Product 
WHERE ActualQuantity <= ReorderLevel 
AND ActualQuantity > DangerLevel 
AND ReorderLevel <> 0;


CREATE VIEW DangerLevelProduct AS
SELECT * FROM Product 
WHERE ActualQuantity <= DangerLevel 
AND DangerLevel <> 0;


CREATE VIEW ProductSaleableQuantity AS
SELECT ProductID, (ActualQuantity - ReserveQuantity) AS 'SaleableQuantity'
FROM Product;


CREATE VIEW SalesOrderTotalAmount AS
SELECT SalesOrderID, SUM(Quantity * ProductPrice) AS 'SUM(Quantity * ProductPrice)'
FROM SalesOrderLine GROUP BY SalesOrderID;

CREATE VIEW TopTenDealer AS
SELECT Dealer.DealerID AS 'DealerID', Dealer.DealerName AS 'DealerName', SUM(SalesOrderLine.ProductPrice * SalesOrderLine.Quantity) AS 'TotalAmount'
FROM Dealer, SalesOrder, SalesOrderLine
WHERE Dealer.DealerID = SalesOrder.DealerID AND
SalesOrder.SalesOrderID = SalesOrderLine.SalesOrderID AND
SalesOrder.SalesOrderStatus = 'Completed'
GROUP BY Dealer.DealerID, Dealer.DealerName
ORDER BY SUM(SalesOrderLine.ProductPrice * SalesOrderLine.Quantity) DESC;

CREATE VIEW TopSaleProduct AS
SELECT Product.ProductID, Product.ProductName, SUM(SalesOrderLine.Quantity) AS 'TotalSaleQty'
FROM Product, SalesOrderLine, SalesOrder
WHERE Product.ProductID = SalesOrderLine.ProductID AND
SalesOrder.SalesOrderID = SalesOrderLine.SalesOrderID AND
SalesOrder.SalesOrderStatus = 'Completed'
GROUP BY Product.ProductID, Product.ProductName
ORDER BY SUM(SalesOrderLine.Quantity) DESC;

CREATE VIEW CheckDispatchQty AS 
SELECT SalesOrderLine.SalesOrderID, Product.ActualQuantity-SalesOrderLine.Quantity AS 'CheckOK' 
FROM SalesOrderLine, Product 
WHERE SalesOrderLine.ProductID = Product.ProductID AND 
Product.ActualQuantity-SalesOrderLine.Quantity < 0;