declare @ID int
declare @LastUpdate datetime

INSERT INTO EXP.SimpleUser (FirstName, LastName, Age, Status, LastUpdate) 
VALUES ('Chirasit', 'Yedoo', 29, 'Yesped', GETDATE()) 
SELECT @ID = ID, @LastUpdate = LastUpdate FROM EXP.SimpleUser WHERE ID = @@IDENTITY

SELECT @ID, @LastUpdate


