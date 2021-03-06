BEGIN TRANSACTION [ContactsTable]

BEGIN TRY
	SET QUOTED_IDENTIFIER ON
	SET ARITHABORT ON
	SET NUMERIC_ROUNDABORT OFF
	SET CONCAT_NULL_YIELDS_NULL ON
	SET ANSI_NULLS ON
	SET ANSI_PADDING ON
	SET ANSI_WARNINGS ON

	CREATE TABLE dbo.Contact(
		Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		Title NVARCHAR(100) NOT NULL,
		Name NVARCHAR(50),
		Surname NVARCHAR(50),
		Organization NVARCHAR(50),
		Email NVARCHAR(50),
		Modified_Datetime DATETIME);

	COMMIT TRANSACTION [ContactsTable];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [ContactsTable]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH