CREATE TABLE JobApplicationTask.dbo.Category
(
	CategoryID int IDENTITY(1,1) PRIMARY KEY,
	CategoryName nvarchar(50) NOT NULL
);


CREATE TABLE JobApplicationTask.dbo.Product
(
	ProductID int IDENTITY(1,1) PRIMARY KEY,
	ProductName nvarchar(50) NOT NULL
);


CREATE TABLE JobApplicationTask.dbo.CategoryAndProduct
(
	CategoryID int NOT NULL,
	ProductID int NOT NULL,
	CONSTRAINT FK_CategoryID FOREIGN KEY (CategoryID)
    REFERENCES Category (CategoryID),
	CONSTRAINT FK_ProductID FOREIGN KEY (ProductID)
    REFERENCES Product (ProductID)
);

SELECT p.ProductName, c.CategoryName
FROM CategoryAndProduct as cp
RIGHT JOIN Product as p
    ON cp.ProductID = p.ProductID
LEFT JOIN Category as c
    ON c.CategoryID = cp.CategoryID