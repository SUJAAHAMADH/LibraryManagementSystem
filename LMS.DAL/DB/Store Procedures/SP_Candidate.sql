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
CREATE PROC [dbo].[ValidateMemberId]
	@memberId										Varchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 1 FROM [dbo].[Candidate] WHERE ServiceNo  = @memberId AND IsActive = 1

END


-- =============================================
-- Author:		Arshad
-- Create date: 14/02/2025
-- Description:	Create Store Procedure of DeactivateCandidate 
-- Execution:	EXEC DeactivateCandidate 
-- =============================================
CREATE PROCEDURE dbo.DeactivateCandidate
    @CandidateID INT,
    @UpdatedBy NVARCHAR(100),
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Candidate
        SET IsActive = 0,
            UpdatedBy = @UpdatedBy,
            UpdatedOn = GETDATE()
        WHERE CandidateID = @CandidateID;

        IF @@ROWCOUNT = 0
        BEGIN
            SET @OutputMessage = 'No candidate found with the provided ID.';
        END
        ELSE
        BEGIN
            SET @OutputMessage = 'SUCCESS';
        END
    END TRY
    BEGIN CATCH
        SET @OutputMessage = ERROR_MESSAGE();
    END CATCH
END;

-- =============================================
-- Author:		Suja
-- Create date: 09/02/2025
-- Description:	Modified Store Procedure of ShowCandidate 
-- Execution:	EXEC ShowCandidate 
-- =============================================
USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[ShowCandidate]    Script Date: 2/9/2025 11:51:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Arshad
-- Create date: 05/02/2025
-- Description:	Modified Store Procedure of ShowCandidate 
-- Execution:	EXEC ShowCandidate 
-- =============================================
ALTER PROC [dbo].[ShowCandidate]
    @CandidateID INT = NULL,
    @CourseID INT = NULL,
    @Role VARCHAR(20) = NULL,
    @ThumbImpression VARCHAR(MAX) = NULL,
    @Barcode VARCHAR(50) = NULL,
    @UserID INT = NULL,
    @SearchValue NVARCHAR(100) = NULL,
	@Stream VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        C.CandidateID AS CandidateID,
        C.Barcode AS Barcode,
        C.[Role] AS [Role],
        C.[Name] AS [Name],
        C.ContactNumber AS ContactNumber,
		C.ParentsContact AS ParentsContact,
		C.Email AS Email,
		C.PermanentAddress AS PermanentAddress,
		C.PermanentAddress AS PresentAddress,
		C.Photo AS Photo,
        C.ServiceNo AS ServiceNo,
        C.Stream AS Stream,
        C.AcademicYear AS AcademicYear,
        C.CourseID AS CourseID,
        Cour.[Name] AS CourseName,
        Cour.[Description] AS CourseDescription,
        CONVERT(VARCHAR, C.FromDate, 105) AS FromDate,
        CONVERT(VARCHAR, C.ToDate, 105) AS ToDate,
        C.Battalion AS Battalion,
        CONVERT(VARCHAR, C.TOSDate, 105) AS TOSDate,
        CONVERT(VARCHAR, C.SOSDate, 105) AS SOSDate,
        C.ThumbImpression AS ThumbImpression
    FROM
        Candidate AS C
    LEFT JOIN
        Course AS Cour
    ON
        Cour.CourseID = C.CourseID
    WHERE
        (C.CandidateID = @CandidateID OR @CandidateID IS NULL)
    AND
        (C.CourseID = @CourseID OR @CourseID IS NULL)
    AND
        (C.[Role] = @Role OR @Role IS NULL)
	AND
		(C.[Stream] = @Stream OR @Stream IS NULL)
    AND
        (C.ThumbImpression = @ThumbImpression OR @ThumbImpression IS NULL)
    AND
        (C.Barcode = @Barcode OR @Barcode IS NULL)
    AND
        (@SearchValue IS NULL OR 
        C.[Name] LIKE '%' + @SearchValue + '%' OR
        C.ContactNumber LIKE '%' + @SearchValue + '%' OR
        C.ServiceNo LIKE '%' + @SearchValue + '%' OR
        C.TOSDate LIKE '%' + @SearchValue + '%' OR
        C.SOSDate LIKE '%' + @SearchValue + '%')
    AND
        C.IsActive = 1;
END

-- =============================================
-- Author:		Junaid Khan
-- Create date: 26/02/2020
-- Updated By : Arshad
-- Updated Date : 04/02/2025
-- Description:	updated the store procedure by added some columns
-- =============================================
ALTER PROC [dbo].[SaveCandidate]
	@CandidateID										INT				= NULL,
	@Role												VARCHAR(20),
	@Name												NVARCHAR(100),
	@ContactNumber										VARCHAR(15),
	@ServiceNo											VARCHAR(50),
	@CourseID											INT				= NULL,
	@FromDate											DATE			= NULL,
	@ToDate												DATE			= NULL,
	@TOSDate											DATE			= NULL,
	@SOSDate											DATE			= NULL,
	@ThumbImpression									VARCHAR(MAX)	= NULL,
	@UserID												INT				= NULL,
	@DOB												DATE			= NULL,
	@Stream												VARCHAR(100)	= NULL,
	@AcademicYear										INT				= NULL,
	@PermanentAddress									NVARCHAR(255)	= NULL,
	@PresentAddress										NVARCHAR(255)	= NULL,
	@Email												VARCHAR(100)	= NULL,
	@ParentsContact										VARCHAR(15)		= NULL,
	@Photo												VARBINARY(MAX)  = NULL,												
	@ID													INT				OUT,
	@OutputMessage										VARCHAR(MAX)	OUT
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		IF NOT EXISTS(SELECT 1 FROM Candidate WHERE CandidateID = @CandidateID)
		BEGIN
			INSERT INTO
				Candidate([Role], Barcode, [Name], ContactNumber, ServiceNo, CourseID, FromDate, ToDate,
						 TOSDate, SOSDate, ThumbImpression, CreatedBy, DOB, Stream,AcademicYear,PermanentAddress,PresentAddress,Email,ParentsContact,Photo)
			VALUES
				(@Role, dbo.GenerateCandidateBarcode(),  @Name, @ContactNumber, @ServiceNo, @CourseID, @FromDate, @ToDate, 
				 @TOSDate, @SOSDate, @ThumbImpression, @UserID,@DOB, @Stream,@AcademicYear,@PermanentAddress,@PresentAddress,@Email,@ParentsContact,@Photo);

			SET
				@ID = SCOPE_IDENTITY();
		END

		ELSE
		BEGIN
			UPDATE
				Candidate
			SET
				[Role]			= @Role,
				[Name]			= @Name,
				ContactNumber	= @ContactNumber,
				ServiceNo       = @ServiceNo,
				CourseID        = @CourseID,
				FromDate		= @FromDate,
				ToDate			= @ToDate,
				TOSDate         = @TOSDate,
				SOSDate         = @SOSDate,
				Thumbimpression = @ThumbImpression,
				UpdatedBy       = @UserID,
				UpdatedOn       = GETDATE(),
				DOB				= @DOB,
				Stream			= @Stream,
				AcademicYear	= @AcademicYear,
				PermanentAddress	= @PermanentAddress,
				PresentAddress	= @PresentAddress,
				Email			= @Email,
				ParentsContact	= @ParentsContact,
				Photo			= @Photo
 			WHERE
				CandidateID		= @CandidateID
			SET
				@ID = @CandidateID;
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

-- =============================================
-- Author:		Arshad
-- Create Date : 04/02/2025
-- Description:	Created the store procedure to find existing RoleID
-- =============================================
Create PROCEDURE [dbo].[HasRoleID]
    @ServiceNo NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Candidate WHERE ServiceNo = @ServiceNo)
        SELECT 1 AS [IsExisting]; 
    ELSE
        SELECT 0 AS [IsExisting]; 
END;