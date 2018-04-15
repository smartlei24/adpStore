USE adpStore
GO

SELECT 
    ShoppingId,
    ProductId,
    UserId,
    Indate
From dbo.ShoppingCart WITH(NOLOCK)
WHERE UserId=@UserId

INSERT INTO dbo.ShoppingCart (ProductId, UserId) VALUES(@ProductId, @UserId)


