CREATE TABLE [dbo].[tbl_shifting] (
    [id]            INT          IDENTITY (1,1) NOT NULL,
    [truck_number]  VARCHAR (50) NULL,
    [ship_name]     VARCHAR (50) NULL,
    [date]          DATETIME     NULL,
    [loading_point] VARCHAR (50) NULL,
    [destination]   VARCHAR (50) NULL,
    [price]         FLOAT (53)   NULL,
    [sacks]         INT          NULL,
    [m_ton]         FLOAT (53)   NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);
