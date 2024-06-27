ALTER PROCEDURE Animals_GetBySpecies
(
    @Species VARCHAR(255)
)
AS
    SELECT 
        AnimalID,
        Species,
        [Name],
        PetName
    FROM vw_Animals
    Where Species = @Species