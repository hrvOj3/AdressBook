BEGIN TRANSACTION [ContactGroupData]

BEGIN TRY	
	INSERT INTO [dbo].[ContactGroup]
			   ([Name]
			   ,[Description]
			   ,[ContactId])
		 VALUES
			   ('Posao'
			   ,'Kolege sa posla');
	INSERT INTO [dbo].[ContactGroup]
			   ([Name]
			   ,[Description]
			   ,[ContactId])
		 VALUES
			   ('Obitelj'
			   ,'Obitelj');
	COMMIT TRANSACTION [ContactGroupData];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [ContactGroupData]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH