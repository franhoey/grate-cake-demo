CREATE PROCEDURE Animals_GetBySpecies
(
    @Species VARCHAR(255)
)
AS
    SELECT 
        AnimalID,
        Species,
        [Name]
    FROM vw_Animals
    Where Species = @Species