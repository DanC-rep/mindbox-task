DROP TABLE IF EXISTS ProductCategories;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;

CREATE TABLE Categories 
(
    Id INT PRIMARY KEY,
    NAME VARCHAR(100)
);

CREATE TABLE Products 
(
    Id INT PRIMARY KEY,
    NAME VARCHAR(100)
);

INSERT INTO Products VALUES
    (1, 'Product 1'),
    (2, 'Product 2'),
    (3, 'Product 3');

INSERT INTO Categories VALUES
    (1, 'Category 1'),
    (2, 'Category 2'),
    (3, 'Category 3');
    
CREATE TABLE ProductCategories
(
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO ProductCategories VALUES
    (1, 1),
    (1, 2),
    (2, 3);
    
SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
    ON P.Id = PC.ProductId
LEFT JOIN Categories C
    ON C.Id = PC.CategoryId;
