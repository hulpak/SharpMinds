CREATE TABLE [hrm].[Status](
	[Id] INT  NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	[StatusTypeId] INT NOT NULL
	CONSTRAINT [PK_Status] PRIMARY KEY ([Id])
	CONSTRAINT [FK_Status_StatusType] FOREIGN KEY ([StatusTypeId]) REFERENCES [hrm].[StatusType]([Id])
)