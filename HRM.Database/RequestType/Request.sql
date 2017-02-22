CREATE TABLE [hrm].[Request](
	[Id] int NOT NULL IDENTITY(1,1),
	[UserId] int NOT NULL,
	[RequestTypeId] int NOT NULL,
	[StartDate] DateTime NOT NULL,
	[EndDate] DateTime NOT NULL,
	[StatusId] int NOT NULL,
	CONSTRAINT [PK_Request] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_RequestType] FOREIGN KEY ([RequestTypeId]) REFERENCES [hrm].[RequestType]([Id]),
	CONSTRAINT [FK_Request_User] FOREIGN KEY ([UserId]) REFERENCES [hrm].[User]([Id]),
	CONSTRAINT [FK_Request_Status] FOREIGN KEY ([StatusId]) REFERENCES [hrm].[Status]([Id])
)