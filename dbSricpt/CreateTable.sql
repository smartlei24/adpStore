USE AdpStore
GO

Create TABLE dbo.[User]
(
    UserId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    [Name] NVARCHAR(30) NOT NULL,
    [PassWord] CHAR(20) NOT NULL,
    [EmailAddress] CHAR(30) NOT NULL,
    [TelNumber] CHAR(30) NOT NULL,
    [Address] NVARCHAR(300) NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)

CREATE TABLE dbo.[ShoppingCart]
(
    ShoppingId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    ProductId INT NOT NULL,
    UserId INT NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)

CREATE TABLE dbo.[Product]
(
    ProductId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    [Name] NVARCHAR(200) NOT NULL,
    SimpleDescription NVARCHAR(500) NULL,
    DetailDescription NVARCHAR(1000) NULL,
    Price DECIMAL(12,2) NULL,
    Situation NVARCHAR(20) NULL,
    Style NVARCHAR(20) NULL,
    Indate DATETIME DEFAULT GETDATE()
)

CREATE TABLE dbo.[Order]
(
    TranscationNumber INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    OrderId INT NOT NULL,
    UserName NVARCHAR(30) NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    OrderPrice INT NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)

-- 修改UserName为查询条件
DROP TABLE dbo.[ShoppingCart]

CREATE TABLE dbo.[ShoppingCart]
(
    ShoppingId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    ProductId INT NOT NULL,
    UserName NVARCHAR(30) NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)

DROP TABLE dbo.[Order]

CREATE TABLE dbo.[Order]
(
    OrderId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    UserName NVARCHAR(30) NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    OrderPrice INT NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)

ALTER TABLE dbo.[Product] ADD ImageName VARCHAR(100) NOT NULL
