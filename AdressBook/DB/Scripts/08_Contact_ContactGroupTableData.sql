BEGIN TRANSACTION [Contact_ContactGroupTableData]

BEGIN TRY
	SET QUOTED_IDENTIFIER ON
	SET ARITHABORT ON
	SET NUMERIC_ROUNDABORT OFF
	SET CONCAT_NULL_YIELDS_NULL ON
	SET ANSI_NULLS ON
	SET ANSI_PADDING ON
	SET ANSI_WARNINGS ON		

	INSERT INTO dbo.Contact_ContactGroup
			   ([ContactId]
			   ,[ContactGroupId])
		 VALUES
			   (1
			   ,2);

	INSERT INTO dbo.Contact_ContactGroup
			   ([ContactId]
			   ,[ContactGroupId])
		 VALUES
			   (6
			   ,2);

	INSERT INTO dbo.Contact_ContactGroup
			   ([ContactId]
			   ,[ContactGroupId])
		 VALUES
			   (7
			   ,2);

	INSERT INTO dbo.Contact_ContactGroup
			   ([ContactId]
			   ,[ContactGroupId])
		 VALUES
			   (2
			   ,1);

	INSERT INTO dbo.Contact_ContactGroup
			   ([ContactId]
			   ,[ContactGroupId])
		 VALUES
			   (5
			   ,1);


	COMMIT TRANSACTION [Contact_ContactGroupTableData];
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION [Contact_ContactGroupTableData]

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_SEVERITY() AS ErrorSeverity, 
			ERROR_STATE() AS ErrorState, 
			ERROR_PROCEDURE() AS ErrorProcedure, 
			ERROR_LINE() AS ErrorLine, 
			ERROR_MESSAGE() AS ErrorMessage;
END CATCH