CREATE TABLE [dbo].[tbl_profile] (
    [id]            INT       IDENTITY (1,1)   NOT NULL,
    [mobile_number] VARCHAR (50) NULL,
    [name]          VARCHAR (50) NULL,
    [address]       VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

