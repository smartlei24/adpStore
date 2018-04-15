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
    OrderId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    UserId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    OrderPrice INT NOT NULL,
    Indate DATETIME DEFAULT GETDATE()
)
