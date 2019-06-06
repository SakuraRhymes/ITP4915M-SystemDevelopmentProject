CREATE VIEW ReorderLevelProduct AS
SELECT * FROM Product 
WHERE ActualQuantity <= ReorderLevel 
AND ActualQuantity > DangerLevel 
AND ReorderLevel <> 0 ;

CREATE VIEW DangerLevelProduct AS
SELECT * FROM Product 
WHERE ActualQuantity <= DangerLevel 
AND DangerLevel <> 0 ;