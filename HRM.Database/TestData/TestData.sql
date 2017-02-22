
INSERT INTO [hrm].[Settings]([Id],[SickDays],[VacationDays]) VALUES (1,5,20);

INSERT INTO [hrm].[UserLevel]([Id],[Name]) VALUES (1,'Junior');
INSERT INTO [hrm].[UserLevel]([Id],[Name]) VALUES (2,'Middle');
INSERT INTO [hrm].[UserLevel]([Id],[Name]) VALUES (3,'Senior');

INSERT INTO [hrm].[RequestType]([Id],[Name]) VALUES (1,'SickReques');
INSERT INTO [hrm].[RequestType]([Id],[Name]) VALUES (2,'VacationRequst');

INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (1,'01-01-2017','New Year');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (2,'01-07-2017','Christmas');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (3,'03-08-2017','March 8');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (4,'04-16-2017','Easter');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (5,'05-01-2017','Workers Day');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (6,'05-09-2017','Victory Day');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (7,'06-04-2017','Trinity');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (8,'06-28-2017','Constitution Day of Ukraine');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (9,'08-24-2017','Independence Day of Ukraine');
INSERT INTO [hrm].[OfficialHollidays]([Id],[Date],[Name]) VALUES (10,'10-14-2017','Day of defenders of Ukraine');

INSERT INTO [hrm].[StatusType]([Id], [Name]) VALUES (1, 'User');
INSERT INTO [hrm].[StatusType]([Id], [Name]) VALUES (2, 'Request');

INSERT INTO [hrm].[Status]([Id],[Name], [StatusTypeId]) VALUES (1,'Vacation',		1);
INSERT INTO [hrm].[Status]([Id],[Name], [StatusTypeId]) VALUES (2,'Sickness',		2);
INSERT INTO [hrm].[Status]([Id],[Name], [StatusTypeId]) VALUES (3,'In processing',	1);

INSERT INTO [hrm].[Role]([Id],[Name]) VALUES (1,'User');
INSERT INTO [hrm].[Role]([Id],[Name]) VALUES (2,'TeamLead');
INSERT INTO [hrm].[Role]([Id],[Name]) VALUES (3,'HR');

SET IDENTITY_INSERT [hrm].[Team] ON
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (1,'Students');
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (2,'HRM');
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (3,'Barcelona');
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (4,'RealMadrid');
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (5,'Uventus');
INSERT INTO [hrm].[Team]([Id],[Name]) VALUES (6,'Portugal');
SET IDENTITY_INSERT [hrm].[Team] OFF

SET IDENTITY_INSERT [hrm].[User] ON
INSERT INTO [hrm].[User]([Id],[FullName],[Password],[Email],[StartDate],[UserLevelId],[UserStatusId]) VALUES (1,'Grisha','grisha2017','grisha@mail.ru','2017-02-03',1,1 );
INSERT INTO [hrm].[User]([Id],[FullName],[Password],[Email],[StartDate],[UserLevelId],[UserStatusId]) VALUES (2,'Oleg','oleg','oleg@mail.ru','2017-02-03',2,2 );
INSERT INTO [hrm].[User]([Id],[FullName],[Password],[Email],[StartDate],[UserLevelId],[UserStatusId]) VALUES (3,'Andriy','andriy','andriy@mail.ru','2017-02-03',3,3 );
INSERT INTO [hrm].[User]([Id],[FullName],[Password],[Email],[StartDate],[UserLevelId],[UserStatusId]) VALUES (4,'Dmytro','dmytro','dmytro@mail.ru','2017-02-03',1,1 );
INSERT INTO [hrm].[User]([Id],[FullName],[Password],[Email],[StartDate],[UserLevelId],[UserStatusId]) VALUES (5,'Vasyl','vasyl','vasyl@mail.ru','2017-02-03',2,2 );
SET IDENTITY_INSERT [hrm].[User] OFF

INSERT INTO [hrm].[UserTeam]([UserId],[TeamId]) VALUES (1,1);
INSERT INTO [hrm].[UserTeam]([UserId],[TeamId]) VALUES (2,2);
INSERT INTO [hrm].[UserTeam]([UserId],[TeamId]) VALUES (1,3);

INSERT INTO [hrm].[UserRole]([UserId],[RoleId]) VALUES (1,1);
INSERT INTO [hrm].[UserRole]([UserId],[RoleId]) VALUES (2,2);
INSERT INTO [hrm].[UserRole]([UserId],[RoleId]) VALUES (3,3);

INSERT INTO [hrm].[UserDocument]([UserId],[DocumentLink]) VALUES (1,'vk');
INSERT INTO [hrm].[UserDocument]([UserId],[DocumentLink]) VALUES (2,'mail');
INSERT INTO [hrm].[UserDocument]([UserId],[DocumentLink]) VALUES (1,'www');

INSERT INTO [hrm].[Request]([UserId],[RequestTypeId],[StartDate],[EndDate],[StatusId]) VALUES (1,1,'2017-01-01','2017-01-02',1);
INSERT INTO [hrm].[Request]([UserId],[RequestTypeId],[StartDate],[EndDate],[StatusId]) VALUES (2,2,'2017-02-03','2017-02-04',2);
INSERT INTO [hrm].[Request]([UserId],[RequestTypeId],[StartDate],[EndDate],[StatusId]) VALUES (1,3,'2017-03-04','2017-03-05',3);
INSERT INTO [hrm].[Request]([UserId],[RequestTypeId],[StartDate],[EndDate],[StatusId]) VALUES (2,1,'2017-04-05','2017-04-06',1);