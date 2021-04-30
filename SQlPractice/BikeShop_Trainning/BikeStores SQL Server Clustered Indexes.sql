
/*  creates a new table named production.parts that consists of two columns part_id and part_name:.*/
CREATE TABLE production.parts(
    part_id   INT NOT NULL, 
    part_name VARCHAR(100)
);
GO
/* inserts some rows into the production.parts.*/
INSERT INTO 
    production.parts(part_id, part_name)
VALUES
    (1,'Frame'),
    (2,'Head Tube'),
    (3,'Handlebar Grip'),
    (4,'Shock Absorber'),
    (5,'Fork');

--SELECT 
--    part_id, 
--    part_name
--FROM 
--    production.parts
--WHERE 
--    part_id = 5;
GO
CREATE TABLE production.part_prices(
    part_id int,
    valid_from date,
    price decimal(18,4) not null,
    PRIMARY KEY(part_id, valid_from) 
);
GO
---This statement defines a primary key for the production.parts----
---SQL Server created a non-clustered index for the primary key.---
ALTER TABLE production.parts
ADD PRIMARY KEY(part_id);

GO
---define a clustered index for the table.--
CREATE CLUSTERED INDEX ix_parts_id
ON production.parts (part_id);  