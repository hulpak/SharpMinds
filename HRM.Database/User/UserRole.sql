CREATE TABLE [hrm].[UserRole](
	[UserId] INT NOT NULL,
	[RoleId] INT NOT NULL
	CONSTRAINT [PK_UserRole] PRIMARY KEY ([UserId],[RoleId])
	CONSTRAINT [FK_UserRole] FOREIGN KEY ([RoleId]) REFERENCES [hrm].[Role]([Id])
	CONSTRAINT [FK_UserRole_User] FOREIGN KEY ([UserId]) REFERENCES [hrm].[User]([Id])
)