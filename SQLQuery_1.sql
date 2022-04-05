CREATE TABLE Customers
( 
    customerID int PRIMARY KEY IDENTITY(1, 1),
    username varchar(50) not null unique,
)
INSERT INTO Customers(username) VALUES('John Krasenski') 
SELECT * FROM Customers


CREATE TABLE Orders
(
    OrderID int PRIMARY KEY IDENTITY(1, 1),
    total int
); 


CREATE TABLE Products
(
    ProductID int PRIMARY KEY IDENTITY(1, 1),
    Cost decimal(3,2),
    Title varchar(255),
    Content varchar(255)
);
INSERT INTO Products(Title, Content, Cost) VALUES('Jurrasic Park: by Michael Crichton',
'Old man loves dinosaurs and doesnt consider they went extinct for a good reason.', '28.89') 
SELECT * FROM Products


UPDATE Products
SET Title = 'Harry Potter and The Sorcerer''s Stone'
WHERE ProductID = 12
Select * From Products


CREATE TABLE Inventory
(
    InventoryID int PRIMARY KEY IDENTITY(1, 1),
    Quantity_Inv int
);

CREATE TABLE Store
(
    StoreID int PRIMARY KEY IDENTITY(1, 1),
    city varchar(50)
);
INSERT INTO Store(city) VALUES('Nashville, TN') 
SELECT * FROM Store

CREATE TABLE Cart
(
    CartID int PRIMARY KEY IDENTITY(1, 1),
);