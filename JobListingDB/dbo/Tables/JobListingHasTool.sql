CREATE TABLE [dbo].[JobListingHasTool]
(
    [JobListingId] INT NOT NULL, 
    [ToolId] INT NOT NULL, 
    CONSTRAINT [FK_JobListingHasTool_JobListing] FOREIGN KEY ([JobListingId]) REFERENCES [JobListing](id), 
    CONSTRAINT [FK_JobListingHasTool_Tool] FOREIGN KEY ([ToolId]) REFERENCES [Tool](id)
)
