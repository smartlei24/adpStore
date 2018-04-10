USE AdpStore
GO

SELECT
    ProductId,
    Name,
    SimpleDescription,
    DetailDescription,
    Price,
    Situation,
    Style,
    Indate
FROM dbo.Product WITH(NOLOCK)