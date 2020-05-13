BEGIN TRANSACTION [ContactData]

BEGIN TRY	

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Maki'
           ,'Marko'
           ,'Maruli?'
           ,''
           ,'mmarko@gmail.com');

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Ante'
           ,'Anto'
           ,'Anti?'
           ,''
           ,'aante@gmail.com');

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Kate'
           ,'Katarina'
           ,'Mari?'
           ,''
           ,'keti13@gmail.com');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Mariana'
           ,'Mariana'
           ,'Mariana'
           ,'Udruga sidro'
           ,'');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Ana'
           ,'Ana'
           ,'Ani?'
           ,''
           ,'anci123@hotmail.com');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Kuma'
           ,'Ana'
           ,'?op'
           ,''
           ,'zekipeki45@hotmail.com');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Kum'
           ,'Andro'
           ,'Andri?'
           ,'RiRock'
           ,'')


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Andro Barka'
           ,'Andro'
           ,'Andro'
           ,'Lu?ica I?i?i'
           ,'');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Boki'
           ,'Bojan'
           ,'Bojan'
           ,'Fit Bit Teretana'
           ,'');

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Trener'
           ,'Tomislav'
           ,'Tomislavi?'
           ,'Fit Bit Teretana'
           ,'');


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email])
     VALUES
           ('Biciklista'
           ,'Erik'
           ,'Erik'
           ,''
           ,'biciklista78@gmail.com');



	COMMIT TRANSACTION [ContactData];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [ContactData]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH