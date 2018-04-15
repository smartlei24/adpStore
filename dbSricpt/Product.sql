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

ORDER BY ProductId DESC
OFFSET @PageStart FETCH NEXT @PageSize ROW ONLY


INSERT TOP(1) INTO dbo.Product
    (Name, SimpleDescription, DateilDescription, Price, Situation, Style)
VALUES
    (@Name, @SimpleDescription, @DateilDescription, @Price, @Situation, @Style)

DELETE FROM dbo.Product WHERE ProductId=@ProductId

UPDATE dbo.Product SET 
Name=@Name
, SimpleDescription=@SimpleDescription
, DetailDescription=@DetailDescription
, Price=@Price
, Situaion=@Situation
, Style=@Style
WHERE ProductId=@ProductId

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
WHERE ProductId=@ProductId
