# ToDo

WCF service for backend__
MVC Web Application for get setup file and get product key__
Winform Application for using ToDo App (Tasky)__

For Create DataBase : 
``` sql

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NULL,
    [CreationDate] datetimeoffset  NULL,
    [GUID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [CreationDate] datetimeoffset  NOT NULL,
    [IsComplete] bit  NOT NULL,
    [DoneDate] datetimeoffset  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'TaskLogs'
CREATE TABLE [dbo].[TaskLogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [CreationDate] datetimeoffset  NOT NULL,
    [TaskId] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LogLevel] nvarchar(max)  NOT NULL,
    [LogTitle] nvarchar(max)  NOT NULL,
    [LogDetail] nvarchar(max)  NULL,
    [Date] datetimeoffset  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TaskLogs'
ALTER TABLE [dbo].[TaskLogs]
ADD CONSTRAINT [PK_TaskLogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_UserTask]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTask'
CREATE INDEX [IX_FK_UserTask]
ON [dbo].[Tasks]
    ([UserId]);
GO

-- Creating foreign key on [TaskId] in table 'TaskLogs'
ALTER TABLE [dbo].[TaskLogs]
ADD CONSTRAINT [FK_TaskTaskLog]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[Tasks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TaskTaskLog'
CREATE INDEX [IX_FK_TaskTaskLog]
ON [dbo].[TaskLogs]
    ([TaskId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
```
