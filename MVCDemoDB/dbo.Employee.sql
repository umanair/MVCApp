CREATE TABLE [dbo].[Employee] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeId]   INT           NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [EmailAddress] NVARCHAR (50) NOT NULL,
    [Password]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

