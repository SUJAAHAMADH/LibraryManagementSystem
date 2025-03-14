
-- =============================================
-- Author:		Arshad
-- Create date: 12/02/2025
-- Description:	Create Store Procedures For Update Subject 
-- Execution:	EXEC UpdateSubject 
-- =============================================
Create PROCEDURE [dbo].[UpdateSubject] 
    @SubjectID INT,
    @Name NVARCHAR(255),
    @IsActive BIT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Subjects WHERE SubjectID = @SubjectID)
    BEGIN
        UPDATE Subjects
        SET Name = @Name, IsActive = @IsActive
        WHERE SubjectID = @SubjectID;

        SET @OutputMessage = 'SUCCESS';
    END
    ELSE
    BEGIN
        SET @OutputMessage = 'ERROR: Subject not found';
    END
END;


-- =============================================
-- Author:		Arshad
-- Create date: 09/02/2025
-- Description:	Create All Store Procedures For Subject 
-- Execution:	EXEC ShowCandidate 
-- =============================================
CREATE PROCEDURE GetSubjectByName
    @SearchValue NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SubjectID, Name, IsActive
    FROM Subjects
    WHERE Name = @SearchValue;
END;
-- =============================================
CREATE PROCEDURE DeactiveSubject
    @SubjectID INT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Subjects
    SET IsActive = 0
    WHERE SubjectID = @SubjectID;

    SET @OutputMessage = 'SUCCESS';
END;

-- =============================================
CREATE PROCEDURE GetSubjectByID
    @SubjectID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SubjectID, Name, IsActive
    FROM Subjects
    WHERE SubjectID = @SubjectID;
END;
-- =============================================
CREATE PROCEDURE ShowSubject
    @UserID INT = NULL,       -- Optional filter (if needed in future)
    @SearchValue NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SubjectID, Name, IsActive
    FROM Subjects
    WHERE (@SearchValue IS NULL OR Name LIKE '%' + @SearchValue + '%')
    ORDER BY Name;
END;
-- =============================================
CREATE PROCEDURE SaveSubject
    @SubjectID INT = NULL, -- If NULL, insert; otherwise, update
    @Name NVARCHAR(255),
    @IsActive BIT = 1,
    @ID INT OUTPUT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Subjects WHERE SubjectID = @SubjectID)
    BEGIN
        -- Update existing record
        UPDATE Subjects
        SET Name = @Name, IsActive = @IsActive
        WHERE SubjectID = @SubjectID;

        SET @ID = @SubjectID;
        SET @OutputMessage = 'SUCCESS';
    END
    ELSE
    BEGIN
        -- Insert new record
        INSERT INTO Subjects (Name, IsActive)
        VALUES (@Name, @IsActive);

        SET @ID = SCOPE_IDENTITY();
        SET @OutputMessage = 'SUCCESS';
    END
END;
