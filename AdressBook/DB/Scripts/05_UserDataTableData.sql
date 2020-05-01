BEGIN TRANSACTION [UserDataTableData]

BEGIN TRY
	SET QUOTED_IDENTIFIER ON
	SET ARITHABORT ON
	SET NUMERIC_ROUNDABORT OFF
	SET CONCAT_NULL_YIELDS_NULL ON
	SET ANSI_NULLS ON
	SET ANSI_PADDING ON
	SET ANSI_WARNINGS ON
	
	INSERT INTO [dbo].[UserData]
           ([UserName]
           ,[Password])
     VALUES
           ('Korisnik1',
           'k0r|sn|k')

	COMMIT TRANSACTION [UserDataTableData];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [UserDataTableData]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH