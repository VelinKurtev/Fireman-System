CREATE TABLE [dbo].[Employees] (
    [employee_id]              INT            NOT NULL,
    [first_name]               NVARCHAR (MAX) NOT NULL,
    [middle_name]              NVARCHAR (MAX) NOT NULL,
    [last_name]                NVARCHAR (MAX) NOT NULL,
    [age]                      INT            NOT NULL,
    [rank]                     NVARCHAR (MAX) NOT NULL,
    [home_address]             NVARCHAR (MAX) NULL,
    [personal_phone_number]    INT            NULL,
    [email]                    NVARCHAR (MAX) NOT NULL,
    [vacation_start_date]      DATETIME       NULL,
    [vacation_end_date]        DATETIME       NULL,
    [business_trip_start_date] DATETIME       NULL,
    [buisiness_trip_end_date]  DATETIME       NULL,
    [number_of_answered_cases] INT            DEFAULT ((0)) NOT NULL,
    [choosen_team]             INT            NULL,
    PRIMARY KEY CLUSTERED ([employee_id] ASC),
    CONSTRAINT [FK_Employees_Teams] FOREIGN KEY ([choosen_team]) REFERENCES [dbo].[Teams] ([team_id])
);

