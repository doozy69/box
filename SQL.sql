CREATE TABLE Product(
	ProductID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(255) NOT NULL
);

CREATE TABLE Category(
	CategoryID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(256) NOT NULL
);

CREATE TABLE ProductCategory(
	ProductCategoryID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProductId int NOT NULL FOREIGN KEY REFERENCES Product(ProductID),
	CategoryId int NOT NULL FOREIGN KEY REFERENCES Category(CategoryID)
);


INSERT INTO Product VALUES	('prod1'),	('prod2'),	('prod3');
INSERT INTO Category VALUES	('cat1'),	('cat2'),	('cat3');
INSERT INTO ProductCategory VALUES	(1,1),	(1,2),	(2,2), (1,3);

SELECT p.name, c.Name from dbo.Product as P
left join dbo.ProductCategory as PC on PC.ProductId = P.ProductID
left join dbo.Category as C on C.CategoryID = pc.CategoryId

/*
drop table ProductCategory
drop table Product
drop table Category
