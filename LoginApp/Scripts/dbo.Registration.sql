CREATE TABLE [dbo].[Registration]
(
	[RegistrationId] INT IDENTITY(1, 1) PRIMARY KEY,
	[EmailAddress] NVARCHAR(50) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
)
