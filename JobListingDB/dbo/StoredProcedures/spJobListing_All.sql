CREATE PROCEDURE [dbo].[spJobListing_All]
AS

BEGIN

	SET NOCOUNT ON;

	SELECT [Id], [Company], [Logo], [IsNew], [IsFeatured], [Position], [Role], [Level], [PostedAt], [ContractType], [Location]
	FROM dbo.JobListing;

END
