CREATE TABLE [dbo].[Cases] (
    [case_id]                   INT            IDENTITY (1, 1) NOT NULL,
    [Region]                    NVARCHAR (MAX) NOT NULL,
    [Town]                      NVARCHAR (MAX) NOT NULL,
    [Street]                    NVARCHAR (MAX) NOT NULL,
    [Neighborhood]              NVARCHAR (MAX) NULL,
    [Address_number]            INT            NOT NULL,
    [Floor]                     INT            NULL,
    [Apartment]                 INT            NULL,
    [Case_type]                 NVARCHAR (MAX) NOT NULL,
    [Dangerous_substances_info] NVARCHAR (MAX) NULL,
    [Selected_team]             INT            NOT NULL,
    [Date_time_of_case]         DATETIME       NOT NULL,
    [End_date_time_of_case]     DATETIME       NOT NULL,
    [Used_water_resources]      FLOAT (53)     NULL,
    [Used_fuel]                 FLOAT (53)     NOT NULL,
    PRIMARY KEY CLUSTERED ([case_id] ASC),
    CONSTRAINT [FK_Cases_Teams] FOREIGN KEY ([Selected_team]) REFERENCES [dbo].[Teams] ([team_id])
);

