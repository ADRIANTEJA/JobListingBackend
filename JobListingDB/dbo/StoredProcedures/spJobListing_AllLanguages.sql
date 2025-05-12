CREATE PROCEDURE [dbo].[spJobListing_AllLanguages]
	@JobListingId int
AS

BEGIN

	SET NOCOUNT ON;

	SELECT l.[Name]
	FROM dbo.JobListing j
	JOIN dbo.JobListingHasLanguage jl ON j.Id = jl.JobListingId
	JOIN dbo.[Language] l ON jl.LanguageId = l.Id
	WHERE j.Id = @JobListingId;

END
