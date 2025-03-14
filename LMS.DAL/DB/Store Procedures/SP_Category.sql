USE [LibrarySystem-Army]
GO
/****** Object:  StoredProcedure [dbo].[DeactiveSubject]    Script Date: 2/15/2025 3:48:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeactiveCategory]
    @CategoryID INT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Category]
    SET IsActive = 0
    WHERE CategoryID = @CategoryID;

    SET @OutputMessage = 'SUCCESS';
END;