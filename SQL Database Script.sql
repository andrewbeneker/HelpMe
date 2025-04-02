CREATE DATABASE HelpMeDB;
GO;
USE HelpMeDB;
GO;

CREATE TABLE [User] (
id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
UserName NVARCHAR (40) NOT NULL,
Password BINARY NOT NULL,
Email NVARCHAR (70) NOT NULL
);
GO;


CREATE TABLE [Ticket] (
id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Name NVARCHAR (60) NOT NULL,
Email NVARCHAR (70) NOT NULL,
Title NVARCHAR (100) NOT NULL,
Body NVARCHAR(MAX) NOT NULL,
TicketOpen BIT,
ResolvedBy NVARCHAR (70)

);
GO;

SELECT * FROM [User]
SELECT * FROM Ticket

INSERT INTO Ticket (Name, Email, Title, Body, TicketOpen)
VALUES ('Benito Bonita', 'ben@example.com', 'My Phone is Broken', 'Please help. My phone is broken!', 1),
('Parjy Popularn', 'parj@example.com', 'Battery will not charge', 'my dang battery will not charge!', 1),
('Charch Montano', 'charch@example.com', 'Cannot see messages', 'I cannot see my messages. Please help me fix.', 1),
('Mary Quantrary', 'marequan@example.com', 'Internet is all weird', 'My frickin internet is all weird', 1),
('Jeeb Jibjab', 'jeebs@example.com', 'instagram ruined my life', 'everyone hates me for this one simple trick', 1);

INSERT INTO [User] (UserName, Password, Email)
VALUES ('HelpDeskHero', 01010101010101010, 'helpdeskhero@example.com');

GO;