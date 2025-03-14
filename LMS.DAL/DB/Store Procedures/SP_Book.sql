USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[ShowIssueBook]    Script Date: 2/19/2025 11:04:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Suja
-- Create date: 02/19/2025
-- Description:	Used to show issue book
-- Execution:	EXEC ShowIssueBook @StartDate = '2020-02-17', @EndDate = '2020-02-17'
-- =============================================
CREATE PROC [dbo].[ShowBookTransactionInMonth]
	@IssueBookID										INT				= NULL,
	@BookBarcodeID										INT				= NULL,
	@CandidateID										INT				= NULL,
	@UserID												INT				= NULL,
	@Barcode											VARCHAR(50)		= NULL,
	@SearchValue										VARCHAR(100)	= NULL,
	@StartDate											DATE			= NULL,
	@EndDate											DATE			= NULL
AS
BEGIN
	SET NOCOUNT ON;

	IF(@StartDate IS NULL)
	BEGIN
		SELECT
			@StartDate = CAST(MIN(IssuedOn) AS DATE)  FROM IssueBook WHERE IsActive = 1;
	END

	IF(@EndDate IS NULL)
	BEGIN
		SELECT
			@EndDate = CAST(MAX(IssuedOn) AS DATE) FROM IssueBook WHERE IsActive = 1;
	END

	SELECT
		IB.IssueBookID									AS IssueBookID,
		IB.BookBarcodeID								AS BookBarcodeID,
		BB.Barcode										AS BookBarcode,
		BB.BookID										AS BookID,
		B.[Name]										AS BookName,
		IB.CandidateID									AS CandidateID,
		IB.IssuedOn										AS IssuedOn,
		IB.ReturnDate									AS ReturnDate,
		IB.ReturnedOn									AS ReturnedOn,
		IB.LastRenewaledOn								AS LastRenewaledOn,
		IB.NoOfTimeRenewal								AS NoOfTimeRenewal,
		IB.Remark										AS Remark,
		C.[Name]										AS CandidateNames,
		C.ServiceNo										AS ROllNo
	FROM
		IssueBook										AS IB
	INNER JOIN
		BookBarcode										AS BB
	ON
		BB.BookBarcodeID = IB.BookBarcodeID
	INNER JOIN
		Book											AS B
	ON
		B.BookID = BB.BookID
	INNER JOIN
		Candidate										AS C
	ON
		C.CandidateID =  IB.CandidateID
	WHERE
	--	IB.ReturnedOn IS NULL
	----AND
	----	IB.LastRenewaledOn IS  NULL
	--AND
		(IB.IssueBookID = @IssueBookID OR @IssueBookID IS NULL)
	AND
		(IB.BookBarcodeID = @BookBarcodeID OR @BookBarcodeID IS NULL)
	AND
		(IB.CandidateID = @CandidateID OR @CandidateID IS NULL)
	AND
		(IB.CreatedBy = @UserID OR @UserID IS NULL)
	AND
		(BB.Barcode = @Barcode OR @Barcode IS NULL)
	AND
		CAST(IB.IssuedOn AS DATE) BETWEEN @StartDate AND @EndDate
	AND
		IB.IsActive = 1
	AND
		(@SearchValue									IS NULL OR 
		IB.IssuedOn										LIKE '%' + @SearchValue + '%' OR
		IB.ReturnDate									LIKE '%' + @SearchValue + '%' OR
		IB.ReturnedOn									LIKE '%' + @SearchValue + '%' OR
		IB.LastRenewaledOn								LIKE '%' + @SearchValue + '%' OR
		B.[Name]										LIKE '%' + @SearchValue + '%' OR
		C.[ServiceNo]									LIKE '%' + @SearchValue + '%')
END


USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[ShowBook]    Script Date: 2/19/2025 10:15:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Suja
-- Create date: 19/02/2025
-- Description:	Used to show book detail
-- Execution:	EXEC ShowBook @SearchValue = 'Founds'
-- =============================================
ALTER PROC [dbo].[ShowBook]
	@BookID												INT			= NULL,
	@AuthorID											INT			= NULL,
	@PublisherID										INT			= NULL,
	@UserID												INT			= NULL,
	@CategoryID											INT			= NULL,
	@SearchValue										NVARCHAR(100)= NULL,
	@Funds												VARCHAR(100)= NULL
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		B.BookID										AS BookID,
		B.[Name]										AS [Name],
		B.Edition										AS Edition,
		B.Price											AS Price,
		B.ISBN											AS ISBN,
		B.[Description]									AS [Description],
		B.TotalQuantity									AS TotalQuantity,
		B.Funds											AS Funds,
		B.IsRestricted									AS IsRestricted,
		B.VolumeNo										AS VolumeNo,
		B.RackNo										AS RackNo,

		C.CategoryID									AS CategoryID,
		C.[Name]										AS Category,

		L.LanguageID									AS LanguageID,
		L.[Name]										AS [Language],								

		B.AuthorID										AS AuthorID,
		A.[Name]										AS Author,

		B.PublisherID									AS PublisherID,
		P.[Name]										AS Publisher
	FROM
		Book											AS B
	INNER JOIN
		Author											AS A
	ON
		A.AuthorID = B.AuthorID
	INNER JOIN
		Publisher										AS P
	ON
		P.PublisherID = B.PublisherID
	INNER JOIN
		[Language]										AS L
	ON
		L.LanguageID = B.LanguageID
	INNER JOIN
		Category										AS C
	ON
		C.CategoryID = B.CategoryID
	WHERE
		(B.BookID = @BookID OR @BookID IS NULL)
	AND
		(B.AuthorID = @AuthorID OR @AuthorID IS NULL)
	AND
		(B.PublisherID = @PublisherID OR @PublisherID IS NULL)
	AND
		(B.CategoryID = @CategoryID OR @CategoryID IS NULL)
	AND
		(B.Funds = @Funds OR @Funds IS NULL)
	AND
		(B.CreatedBy = @UserID OR @UserID IS NULL)
	AND
		(@SearchValue									IS NULL OR 
		B.Name											LIKE '%' + @SearchValue + '%' OR
		B.Edition										LIKE '%' + @SearchValue + '%' OR
		L.[Name]										LIKE '%' + @SearchValue + '%' OR
		B.Price											LIKE '%' + @SearchValue + '%' OR
		B.ISBN											LIKE '%' + @SearchValue + '%' OR
		B.Funds											LIKE '%' + @SearchValue + '%' OR
		B.[Description]									LIKE '%' + @SearchValue + '%')
	AND
		B.IsActive = 1;
END

---- END 2025-02-19 --------------------

USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[CheckAvailableBookBarcode]    Script Date: 2/15/2025 1:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Suja
-- Create date: 15/02/2025

-- =============================================
CREATE PROC [dbo].[ValidateISBN]
	@ISBN										Varchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 1 FROM [dbo].[Book] WHERE ISBN  = @ISBN AND IsActive = 1

END



USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[ShowIssueBook]    Script Date: 2/14/2025 8:37:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Suja
-- Create date: 15/02/2025
-- Description:	Used to show issue book

-- =============================================
ALTER PROC [dbo].[ShowIssueBook]
	@IssueBookID										INT				= NULL,
	@BookBarcodeID										INT				= NULL,
	@CandidateID										INT				= NULL,
	@UserID												INT				= NULL,
	@Barcode											VARCHAR(50)		= NULL,
	@SearchValue										VARCHAR(100)	= NULL,
	@StartDate											DATE			= NULL,
	@EndDate											DATE			= NULL
AS
BEGIN
	SET NOCOUNT ON;

	IF(@StartDate IS NULL)
	BEGIN
		SELECT
			@StartDate = CAST(MIN(IssuedOn) AS DATE)  FROM IssueBook WHERE IsActive = 1;
	END

	IF(@EndDate IS NULL)
	BEGIN
		SELECT
			@EndDate = CAST(MAX(IssuedOn) AS DATE) FROM IssueBook WHERE IsActive = 1;
	END

	SELECT
		IB.IssueBookID									AS IssueBookID,
		IB.BookBarcodeID								AS BookBarcodeID,
		BB.Barcode										AS BookBarcode,
		BB.BookID										AS BookID,
		B.[Name]										AS BookName,
		IB.CandidateID									AS CandidateID,
		IB.IssuedOn										AS IssuedOn,
		IB.ReturnDate									AS ReturnDate,
		IB.ReturnedOn									AS ReturnedOn,
		IB.LastRenewaledOn								AS LastRenewaledOn,
		IB.NoOfTimeRenewal								AS NoOfTimeRenewal,
		IB.Remark										AS Remark,
		C.[Name]										AS CandidateNames,
		C.ServiceNo										AS ROllNo
	FROM
		IssueBook										AS IB
	INNER JOIN
		BookBarcode										AS BB
	ON
		BB.BookBarcodeID = IB.BookBarcodeID
	INNER JOIN
		Book											AS B
	ON
		B.BookID = BB.BookID
	INNER JOIN
		Candidate										AS C
	ON
		C.CandidateID =  IB.CandidateID
	WHERE
		IB.ReturnedOn IS NULL
	--AND
	--	IB.LastRenewaledOn IS  NULL
	AND
		(IB.IssueBookID = @IssueBookID OR @IssueBookID IS NULL)
	AND
		(IB.BookBarcodeID = @BookBarcodeID OR @BookBarcodeID IS NULL)
	AND
		(IB.CandidateID = @CandidateID OR @CandidateID IS NULL)
	AND
		(IB.CreatedBy = @UserID OR @UserID IS NULL)
	AND
		(BB.Barcode = @Barcode OR @Barcode IS NULL)
	AND
		CAST(IB.IssuedOn AS DATE) BETWEEN @StartDate AND @EndDate
	AND
		IB.IsActive = 1
	AND
		(@SearchValue									IS NULL OR 
		IB.IssuedOn										LIKE '%' + @SearchValue + '%' OR
		IB.ReturnDate									LIKE '%' + @SearchValue + '%' OR
		IB.ReturnedOn									LIKE '%' + @SearchValue + '%' OR
		IB.LastRenewaledOn								LIKE '%' + @SearchValue + '%' OR
		B.[Name]										LIKE '%' + @SearchValue + '%' OR
		C.[ServiceNo]									LIKE '%' + @SearchValue + '%')
END

-- =============================================
-- Author:		Suja
-- Create date: 11/02/2025
-- Description:	Modified Store Procedure of SaveBook
-- Execution:	EXEC SaveBook 
-- =============================================
USE [LibrarySystem-Army]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[SaveBook]
	@BookID												INT				= NULL,
	@Name												NVARCHAR(200),
	@AuthorID											INT,
	@Edition											VARCHAR(20)		= NULL,
	@PublisherID										INT,
	@LanguageID											INT				= NULL,
	@Price												DECIMAL(18,2),
	@ISBN												VARCHAR(20)		= NULL,
	@Description										VARCHAR(200)	= NULL,
	@Funds												VARCHAR(100)	= NULL,
	@CategoryID											INT,
	@IsRestricted										BIT				= NULL,
	@TotalQuantity										INT,
	@UserID												INT,
	@VolumeNo											NVARCHAR(20)    = NULL, 
	@Vendor												NVARCHAR(20)	= NULL,
	@BillNo												NVARCHAR(20)	= NULL,
	@BillDate											DateTime		= NULL,
	@OfficeOrder										NVARCHAR(20)	= NULL,
	@OfficeOrderDate									DateTime        = NULL,
	@Discount											decimal(18,2)	= NULL,
	@RackNo												integer			= Null,
	@ID													INT				OUT,
	@OutputMessage										VARCHAR(MAX)	OUT
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		IF NOT EXISTS(SELECT 1 FROM Book WHERE BookID = @BookID)
		BEGIN
			INSERT INTO
				Book([Name], AuthorID, Edition, PublisherID, LanguageID, Price, ISBN, [Description], TotalQuantity, Funds, IsRestricted, CategoryID, CreatedBy,
				VolumeNo,Vendor,BillNo,BillDate,OfficeOrder,OfficeOrderDate,Discount,RackNo)
			VALUES
				(@Name, @AuthorID, @Edition, @PublisherID, @LanguageID, @Price, @ISBN, @Description, @TotalQuantity, @Funds, @IsRestricted, @CategoryID, @UserID,
				@VolumeNo,@Vendor,@BillNo,@BillDate,@OfficeOrder,@OfficeOrderDate,@Discount,@RackNo);

			SET
				@ID = SCOPE_IDENTITY();
		END

		ELSE
		BEGIN
			UPDATE
				Book
			SET
				[Name]				= @Name,
				AuthorID			= @AuthorID,
				Edition				= @Edition,
				PublisherID			= @PublisherID,
				LanguageID			= @LanguageID,
				Price				= @Price,
				Funds				= @Funds,
				IsRestricted		= @IsRestricted,
				CategoryID			= @CategoryID,
				ISBN				= @ISBN,	
				[Description]		= @Description,
				TotalQuantity		= @TotalQuantity,
				UpdatedBy			= @UserID,
				VolumeNo			= @VolumeNo,
				Vendor				= @Vendor,
				BillNo				= @BillNo,
				BillDate			= @BillDate,
				OfficeOrder			= @OfficeOrder,
				OfficeOrderDate		= @OfficeOrderDate,
				Discount			= @Discount,
				RackNo				= @RackNo,
				UpdatedOn			= GETDATE()
			WHERE
				BookID				= @BookID
			SET
				@ID = @BookID;
		END

		SET
			@OutputMessage = 'SUCCESS';
	END TRY

	BEGIN CATCH
		DECLARE @ErrorNumber			INT
		DECLARE @ErrorSeverity			INT
		DECLARE @ErrorState				INT
		DECLARE @ErrorProcedure			NVARCHAR(126)
		DECLARE @ErrorLine				INT
		DECLARE @ErrorMessage			NVARCHAR(MAX)
		
		SELECT
			@ErrorNumber				= ERROR_NUMBER(),
			@ErrorSeverity				= ERROR_SEVERITY(),
			@ErrorState					= ERROR_STATE(),
			@ErrorProcedure				= ERROR_PROCEDURE(),
			@ErrorLine					= ERROR_LINE(),
			@ErrorMessage				= ERROR_MESSAGE();

		SET
			 @OutputMessage = @ErrorMessage

		 RAISERROR(' Error #: %d in %s . Message: %s', @ErrorSeverity, @ErrorState, 
		 @ErrorProcedure, @ErrorMessage);
	END CATCH
END
