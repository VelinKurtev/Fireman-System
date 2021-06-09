CREATE TABLE [dbo].[FireTrucks] (
    [fire_truck_id]   INT            IDENTITY (1, 1) NOT NULL,
    [model]           NVARCHAR (MAX) NOT NULL,
    [water_capacity]  FLOAT (53)     NOT NULL,
    [staff_capacity]  FLOAT (53)     NOT NULL,
    [available_water] FLOAT (53)     NOT NULL,
    [fuel_capacity]   FLOAT (53)     NOT NULL,
    [available_fuel]  FLOAT (53)     NOT NULL,
    [answered_cases]  INT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([fire_truck_id] ASC)
);

