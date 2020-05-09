BEGIN TRANSACTION [PhoneNumberData]

BEGIN TRY	
	INSERT INTO [dbo].[PhoneNumber]
           ([PhoneNumber]
           ,[DefaultNumber]
           ,[ContactId])
     VALUES
           (0915578985
           ,1
           ,1);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (051274274
			   ,0
			   ,1);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0915578745
			   ,1
			   ,2);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0991244125
			   ,0
			   ,2);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (051987541
			   ,0
			   ,2);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0915665754
			   ,1
			   ,3);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0925288652
			   ,1
			   ,4);

	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0958765123
			   ,1
			   ,5);


	INSERT INTO [dbo].[PhoneNumber]
			   ([PhoneNumber]
			   ,[DefaultNumber]
			   ,[ContactId])
		 VALUES
			   (0985425364
			   ,1
			   ,7);

	COMMIT TRANSACTION [PhoneNumberData];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [PhoneNumberData]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH