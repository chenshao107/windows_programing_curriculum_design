CREATE TABLE [dbo].StudentTable
(
	[StudentId] NCHAR(10) NOT NULL PRIMARY KEY,
    [Name] VARCHAR(10) NULL,
    [RoomId] INT NULL,
    [Telephone] NCHAR(11) NULL,
    [Sex] NCHAR(1) NULL
)
CREATE TABLE [dbo].Room
(
	[RoomId] INT NOT NULL PRIMARY KEY,
    [StudentNumber] INT NULL,
    [Balance] DECIMAL(8, 2) NULL
)
