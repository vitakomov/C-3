CREATE TABLE [dbo].[Emails] 
(
    [Id] int NOT NULL,
    [Email]  NVARCHAR (MAX) NOT NULL,
    [Name]   NVARCHAR (MAX) NOT NULL,   
	CONSTRAINT [PK_dbo_Emails] PRIMARY KEY CLUSTERED ([id] ASC)
)