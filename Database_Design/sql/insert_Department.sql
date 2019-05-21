SET NAMES 'utf8';
USE SLMCS_DB;
--
-- Delete data from the table 'Department'
--
DELETE FROM Department;

INSERT INTO Department VALUES ('HR', 'Personnel');
INSERT INTO Department VALUES ('SA', 'Sales');
INSERT INTO Department VALUES ('WH', 'Warehouse');
INSERT INTO Department VALUES ('PO', 'Procurement');
INSERT INTO Department VALUES ('FI', 'Finance');