CREATE TABLE [hrm].[User](
	[Id] INT NOT NULL IDENTITY(1,1),
	[FullName] NVARCHAR(128) NOT NULL,
	[Password] NVARCHAR(128) NOT NULL,
	[Email] NVARCHAR(128) NOT NULL,	
	[StartDate] DATE NOT NULL,
	[StatusId] INT NOT NULL,
	[LevelId] INT NOT NULL,
	[UserRole] INT NOT NULL,
	[UserTeam] INT NOT NULL,		
	CONSTRAINT [PK_UserId] PRIMARY KEY ([Id]),	
	CONSTRAINT [FK_User_Status] FOREIGN KEY ([StatusId]) REFERENCES [hrm].[Status]([Id]),
	CONSTRAINT [FK_User_Level] FOREIGN KEY ([LevelId]) REFERENCES  [hrm].[UserLevel]([Id])
)