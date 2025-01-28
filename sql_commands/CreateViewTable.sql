CREATE VIEW View_Products AS 
SELECT 
    p.pro_id AS proid,
    p.pro_id AS proNo,
    p.pro_name AS productName,
    p.qty AS Quantity,
    p.price AS UnitPrice,
    p.unit AS Units,
    p.instock AS Instock,
    p.pro_img AS picture,
    pt.ptType_name AS productTypeName,
    pt.ptType_ID AS productTypeid
FROM 
    tbProducts p
JOIN 
    tbProductType pt
ON
    p.ptType_ID = pt.ptType_ID;

SELECT * FROM View_Products;