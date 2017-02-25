CREATE TABLE [hrm].[OfficialHollidays](
	[Id] INT  NOT NULL IDENTITY(1,1),
	[Date] DATETIME NOT NULL,
	[Name] NVARCHAR(128) NOT NULL, 
	CONSTRAINT [PK_OfficialHollidaysId] PRIMARY KEY ([Id])
)
