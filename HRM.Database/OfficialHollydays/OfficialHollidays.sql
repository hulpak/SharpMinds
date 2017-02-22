CREATE TABLE [hrm].[OfficialHollidays](
	[Id] INT  NOT NULL,
	[Date] DATETIME NOT NULL,
	[Name] NVARCHAR(128) 
	CONSTRAINT [PK_OfficialHollidaysId] PRIMARY KEY ([Id])
)
