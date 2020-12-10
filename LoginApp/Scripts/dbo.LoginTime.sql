CREATE TABLE [dbo].[LoginTime]
(
	[LoginId] INT IDENTITY(1, 1),
	[RegistrationId] INT,
	[Timestamp] DATETIME2 DEFAULT GETUTCDATE(),
	PRIMARY KEY ([LoginId]),
	FOREIGN KEY ([RegistrationId]) REFERENCES [dbo].[Registration]([RegistrationId]),
)