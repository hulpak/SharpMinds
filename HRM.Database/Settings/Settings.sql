CREATE TABLE [hrm].[Settings](
	[Id] INT,
	[SickDays] INT NOT NULL,
	[VacationDays] INT NOT NULL
	CONSTRAINT [PK_Settings] PRIMARY KEY ([Id])
)