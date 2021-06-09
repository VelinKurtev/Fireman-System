CREATE TABLE [dbo].[Teams] (
    [team_id]                  INT            IDENTITY (1, 1) NOT NULL,
    [team_name]                NVARCHAR (MAX) NOT NULL,
    [number_of_members]        INT            NOT NULL,
    [choosen_fire_truck]       INT            NOT NULL,
    [number_of_answered_cases] INT            NOT NULL,
    [is_team_active]           NVARCHAR (MAX) NOT NULL,
    [is_team_busy]             NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([team_id] ASC),
    CONSTRAINT [FK_Teams_FireTrucks] FOREIGN KEY ([choosen_fire_truck]) REFERENCES [dbo].[FireTrucks] ([fire_truck_id])
);

