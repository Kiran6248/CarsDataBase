CREATE TABLE [dbo].[tblCar] (
    [VehicleRegNo]   VARCHAR (10) NOT NULL,
    [Make]           VARCHAR (50) NULL,
    [EngineSize]     VARCHAR (10) NULL,
    [DateRegistered] DATE         DEFAULT ('dd/mm/yyyy') NULL,
    [RentalPerDay]   MONEY        NULL,
    [Available]      VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([VehicleRegNo] ASC)
); 
