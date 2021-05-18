-- Create a new table called '[DataJson]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DataJson]', 'U') IS NOT NULL
DROP TABLE [dbo].[DataJson]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[DataJson]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Primary Key column
    [DataSetId] INT NOT NULL FOREIGN KEY REFERENCES dbo.DataSet(Id),
    [Stamp] DATETIME NOT NULL,
    [Draft] BIT NOT NULL,
    [Json] NVARCHAR(MAX) NOT NULL
);
GO


-- Create a new stored procedure called 'GetData' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetData'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.GetData
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.GetData
AS
BEGIN
    SELECT * FROM dbo.DataCategory

    SELECT * FROM dbo.DataSet

    SELECT * FROM dbo.DataJson
END
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.GetData 
GO

-- Create a new stored procedure called 'InsertDataJson' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'InsertDataJson'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.InsertDataJson
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.InsertDataJson
    @DataSetId INT,
    @Stamp DATETIME,
    @Json NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO dbo.DataJson (DataSetId, Stamp, Draft, [Json])
        VALUES(@DataSetId, @Stamp, 0, @Json)
END
GO

-- Create a new stored procedure called 'GetDataJson' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetDataJson'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.GetDataJson
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.GetDataJson
    @Filename VARCHAR(50)
AS
BEGIN
    SELECT TOP 1 DJ.* 
    FROM DataJson DJ 
    JOIN DataSet DS ON DS.Id = DJ.DataSetId
    WHERE DS.[Filename] = @Filename AND DJ.Draft = 0
    ORDER BY DJ.Stamp DESC
END
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.GetDataJson 1
GO