USE adpStore
GO

SELECT TOP 1
    OrderId,
    UserId,
    ProductId,
    Quantity,
    OrderPrice,
    Indate
FROM dbo.adpStore WITH(NOLOCK)
WHERE OrderId=@OrderId

SELECT 
    OrderId,
    UserId,
    ProductId,
    Quantity,
    OrderPrice,
    Indate
FROM dbo.adpStore WITH(NOLOCK)
WHERE UserId=@UserId

INSERT INTO dbo.adpStore
(UserId,ProductId, Quantity, OrderPrice)
VALUES
(@UserId, @ProductId, @Quantity, @OrderPrice)
