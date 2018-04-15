USE adpStore
GO

SELECT
    UserID,
    Name,
    PassWord,
    EmailAddress,
    TelNumber,
    Address,
    Indate
FROM dbo.User 
WHERE UserId=@UserId

UPDATE dbo.User 
SET Name=@Name, 
    PassWord=@PassWord, 
    EmailAddress=@EmailAddress, 
    TelNumber=@TelNumber, 
    Address=@Address
Where UserId=@UserId

INSERT INTO dbo.User 
(Name, PassWord, EmailAddress, TelNumber, Address) 
VALUES
(@Name, @PassWord, @EmailAddress, @TelNumber, @Address)

DELETE FROM dbo.User WHERE UserId=@UserId
