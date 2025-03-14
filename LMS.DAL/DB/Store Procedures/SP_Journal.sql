-- =============================================
-- Author:		Arshad
-- Create date: 11/02/2025
-- Description:	Create Store Procedure For UpdateJournal
-- Execution:	EXEC UpdateJournal 
-- =============================================
CREATE PROCEDURE UpdateJournal
    @ID INT,
    @JournalName NVARCHAR(255),
    @Frequency INT,
    @Price DECIMAL(18,2),
    @InvoiceNo NVARCHAR(50),
    @InvoiceDate DATETIME,
    @OrderNo NVARCHAR(50),
    @IsActive BIT,
    @SubjectID INT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Journal WHERE ID = @ID)
        BEGIN
            SET @OutputMessage = 'Journal not found.';
            RETURN;
        END

        UPDATE Journal
        SET 
            JournalName = @JournalName,
            Frequency = @Frequency,
            Price = @Price,
            InvoiceNo = @InvoiceNo,
            InvoiceDate = @InvoiceDate,
            OrderNo = @OrderNo,
            IsActive = @IsActive,
            SubjectID = @SubjectID
        WHERE ID = @ID;

        SET @OutputMessage = 'SUCCESS';
    END TRY
    BEGIN CATCH
        SET @OutputMessage = ERROR_MESSAGE();
    END CATCH
END;

-- =============================================
-- Author:		Arshad
-- Create date: 09/02/2025
-- Description:	Modified Store Procedure of ShowJournal
-- Execution:	EXEC ShowJournal 
-- =============================================
ALTER PROCEDURE [dbo].[ShowJournal]
    @ID INT = -1,
    @JournalName NVARCHAR(255) = NULL,
    @SubjectID INT = -1
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        J.ID AS ID,
        J.JournalName AS JournalName,
        J.Frequency AS Frequency,
        J.Price AS Price,
        J.InvoiceNo AS InvoiceNo,
        J.InvoiceDate AS InvoiceDate,
        J.OrderNo AS OrderNo, 
        J.IsActive AS IsActive,
        J.SubjectID AS SubjectID,  -- Corrected column reference
        S.Name AS Subjects
    FROM Journal AS J
    INNER JOIN [Subjects] AS S ON J.SubjectID = S.SubjectID  -- 
    WHERE 
        (@ID = -1 OR J.ID = @ID)
        AND (@JournalName IS NULL OR J.JournalName LIKE '%' + @JournalName + '%')
        AND (@SubjectID = -1 OR J.SubjectID = @SubjectID);  -- 
END;
-- =============================================
-- Author:		Arshad
-- Create date: 09/02/2025
-- Description:	Modified Store Procedure of SaveJournal
-- Execution:	EXEC SaveJournal
-- =============================================
ALTER PROCEDURE [dbo].[SaveJournal]
    @JournalID INT = -1, -- -1 for new journal, otherwise update
    @JournalName NVARCHAR(255),
    @Frequency INT,
    @Price DECIMAL(10, 2),
    @InvoiceNo NVARCHAR(50),
    @InvoiceDate DATE,
    @OrderNo NVARCHAR(50),
    @IsActive BIT,
    @SubjectID INT,
    @ID INT OUTPUT, -- Output ID
    @OutputMessage NVARCHAR(2000) OUTPUT -- Output message
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF @JournalID = -1
        BEGIN
            -- Insert a new journal record
            INSERT INTO Journal
            (
                JournalName, Frequency, Price, InvoiceNo, InvoiceDate, OrderNo,
                IsActive, SubjectID
            )
            VALUES
            (
                @JournalName, @Frequency, @Price, @InvoiceNo, @InvoiceDate, @OrderNo,
                @IsActive, @SubjectID
            );

            SET @ID = SCOPE_IDENTITY();
            SET @OutputMessage = 'SUCCESS';
        END
        ELSE
        BEGIN
            -- Update an existing journal record
            UPDATE Journal
            SET
                JournalName = @JournalName,
                Frequency = @Frequency,
                Price = @Price,
                InvoiceNo = @InvoiceNo,
                InvoiceDate = @InvoiceDate,
                OrderNo = @OrderNo,
                IsActive = @IsActive,
                SubjectID = @SubjectID
            WHERE ID = @JournalID;

            SET @ID = @JournalID;
            SET @OutputMessage = 'SUCCESS';
        END
    END TRY
    BEGIN CATCH
        SET @OutputMessage = ERROR_MESSAGE();
        SET @ID = 0;
    END CATCH
END

-- =============================================
-- Author:		Arshad
-- Create date: 07/02/2025
-- Description:	Created Store Procedure For DeactiveJournal
-- Execution:	EXECDeactiveJournal 
-- =============================================
USE [LibrarySystem-Army]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeactiveJournal]
    @ID INT,
    @OutputMessage NVARCHAR(2000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Check if Journal exists
        IF EXISTS (SELECT 1 FROM Journal WHERE ID = @ID)
        BEGIN
            -- Deactivate Journal
            UPDATE Journal
            SET IsActive = 0
            WHERE ID = @ID;

            SET @OutputMessage = 'SUCCESS';
        END
        ELSE
        BEGIN
            SET @OutputMessage = 'Journal not found.';
        END
    END TRY
    BEGIN CATCH
        SET @OutputMessage = ERROR_MESSAGE();
    END CATCH
END
GO

