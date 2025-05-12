CREATE TABLE [dbo].[JobListingHasLanguage]
(
    [JobListingId] INT NOT NULL, 
    [LanguageId] INT NOT NULL, 
    CONSTRAINT [FK_JobListingHasLanguage_JobListing] FOREIGN KEY ([JobListingId]) REFERENCES [JobListing](id),
    CONSTRAINT [FK_JobListingHasLanguage_Language] FOREIGN KEY ([LanguageId]) REFERENCES [Language](id)
)
