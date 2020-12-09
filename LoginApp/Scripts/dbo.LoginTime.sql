CREATE TABLE [dbo].[LoginTime]
(
	[LoginId] INT IDENTITY(1, 1),
	[RegistrationId] INT,
	[Timestamp] AS CURRENT_TIMESTAMP,
	PRIMARY KEY ([LoginId]),
	FOREIGN KEY ([RegistrationId]) REFERENCES [dbo].[Registration]([RegistrationId]),
)
