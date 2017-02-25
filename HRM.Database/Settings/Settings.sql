CREATE TABLE [hrm].[Settings](
	[Id] INT NOT NULL IDENTITY(1,1),
	[SickDays] INT NOT NULL,
	[VacationDays] INT NOT NULL
	CONSTRAINT [PK_Settings] PRIMARY KEY ([Id])
)