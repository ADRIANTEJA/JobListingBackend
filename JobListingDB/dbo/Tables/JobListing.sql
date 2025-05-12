CREATE TABLE [dbo].[JobListing]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Company] NVARCHAR(50) NOT NULL,
    [Logo] NVARCHAR(MAX) NOT NULL,
    [IsNew] BIT NOT NULL,
    [IsFeatured] BIT NOT NULL,
    [Position] NVARCHAR(50) NOT NULL,
    [Role] NVARCHAR(50) NOT NULL, 
    [Level] NVARCHAR(50) NOT NULL,
    [PostedAt] NVARCHAR(50) NOT NULL, 
    [ContractType] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL
)
