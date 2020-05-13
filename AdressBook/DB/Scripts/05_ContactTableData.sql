BEGIN TRANSACTION [ContactData]

BEGIN TRY	

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Maki'
           ,'Marko'
           ,'Marulic'
           ,''
           ,'mmarko@gmail.com'
		   ,GETDATE());

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Ante'
           ,'Anto'
           ,'Antic'
           ,''
           ,'aante@gmail.com'
		   ,GETDATE());

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Kate'
           ,'Katarina'
           ,'Maric'
           ,''
           ,'keti13@gmail.com'
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Mariana'
           ,'Mariana'
           ,'Mariana'
           ,'Udruga sidro'
           ,''
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Ana'
           ,'Ana'
           ,'Anic'
           ,''
           ,'anci123@hotmail.com'
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Kuma'
           ,'Ana'
           ,'Cop'
           ,''
           ,'zekipeki45@hotmail.com'
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Kum'
           ,'Andro'
           ,'Andric'
           ,'RiRock'
           ,''
		   ,GETDATE())


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Andro Barka'
           ,'Andro'
           ,'Andro'
           ,'Lucica Icici'
           ,''
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Boki'
           ,'Bojan'
           ,'Bojan'
           ,'Fit Bit Teretana'
           ,''
		   ,GETDATE());

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Trener'
           ,'Tomislav'
           ,'Tomislavic'
           ,'Fit Bit Teretana'
           ,''
		   ,GETDATE());


INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Biciklista'
           ,'Erik'
           ,'Erik'
           ,''
           ,'biciklista78@gmail.com'
		   ,GETDATE());

INSERT INTO [dbo].[Contact]
           ([Title]
           ,[Name]
           ,[Surname]
           ,[Organization]
           ,[Email]
		   ,[Modified_Datetime])
     VALUES
           ('Valko'
           ,'Val'
           ,'Valić'
           ,''
           ,'biciklista1@gmail.com'
		   ,GETDATE());


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