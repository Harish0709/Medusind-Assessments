CREATE TABLE FruitProducts (
    ProductId int PRIMARY KEY,
    ProductName nvarchar(50) NOT NULL,
    UnitPrice decimal(10,2) NOT NULL,
    Category nvarchar(50) NOT NULL
)

INSERT INTO FruitProducts (ProductId, ProductName, UnitPrice, Category)
VALUES (1, 'Apple', 0.99, 'Fruits'),
       (2, 'Banana', 0.79, 'Fruits'),
       (3, 'Orange', 1.29, 'Fruits'),
       (4, 'Grapes', 2.99, 'Fruits')



select * from FruitProducts




CREATE PROCEDURE GetFruitProducts
AS
BEGIN
    SELECT * FROM FruitProducts WHERE Category = 'Fruits'
END