CREATE TABLE [hrm].[UserDocument](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[UserId] INT NOT NULL,
	[DocumentLink] NVARCHAR(128) NOT NULL
	CONSTRAINT [PK_UserDocument] PRIMARY KEY ([Id])
	CONSTRAINT [FK_UserDocument_User] FOREIGN KEY ([UserId]) REFERENCES [hrm].[User]([Id])

)