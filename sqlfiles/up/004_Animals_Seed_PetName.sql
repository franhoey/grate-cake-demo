UPDATE Animals
SET PetName = 
    CASE AnimalID
        WHEN 1 THEN 'Gus'
        WHEN 2 THEN 'Smudge'
        WHEN 3 THEN 'Fudge'
        WHEN 4 THEN 'Erin'
        WHEN 5 THEN 'Niamh'
        WHEN 6 THEN 'Kerry'
    END
