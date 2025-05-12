CREATE PROCEDURE [dbo].[spJobListing_AllTools]
	@JobListingId int
AS

BEGIN

	SET NOCOUNT ON;

	SELECT t.[Name]
	FROM dbo.JobListing j
	JOIN dbo.JobListingHasTool jt ON j.Id = jt.JobListingId
	JOIN dbo.Tool t ON jt.ToolId = t.Id
	WHERE j.Id = @JobListingId;

END