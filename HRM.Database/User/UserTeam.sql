CREATE TABLE [hrm].[UserTeam](
	[UserId] INT NOT NULL,
	[TeamId] INT NOT NULL
	CONSTRAINT [PK_UserTeam] PRIMARY KEY ([UserId],[TeamId])
	CONSTRAINT [FK_UserTeam_Team] FOREIGN KEY ([TeamId]) REFERENCES [hrm].[Team]([Id])
	CONSTRAINT [FK_UserTeam_User] FOREIGN KEY ([UserId]) REFERENCES [hrm].[User]([Id])

)