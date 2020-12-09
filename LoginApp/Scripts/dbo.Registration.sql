CREATE TABLE [dbo].[Registration] (
    [RegistrationId] INT           IDENTITY (1, 1) NOT NULL,
    [EmailAddress]   NVARCHAR (50) NOT NULL UNIQUE,
    [FirstName]      NVARCHAR (50) NOT NULL,
    [LastName]       NVARCHAR (50) NOT NULL,
    [Password]       NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([RegistrationId] ASC)
);