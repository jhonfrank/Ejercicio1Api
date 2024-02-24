CREATE DATABASE db
GO

USE db
GO

CREATE TABLE Employee(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(100),
	document_number CHAR(8),
	salary NUMERIC(12,2),
	age INT,
	profile VARCHAR(100),
	admission_date DATE
)
GO

INSERT INTO Employee VALUES('Joellen Tanzer','15236481',6481.76,34,'Contador','2020-1-12')
INSERT INTO Employee VALUES('Amargo Worsfield','22499116',1162.27,52,'Administrativo','2020-5-21')
INSERT INTO Employee VALUES('Sanson Regenhardt','24216912',1291.11,49,'Arquitecto','2020-4-16')
INSERT INTO Employee VALUES('Elinore McClay','74205701',5701.91,47,'Vendedor','2020-8-25')
INSERT INTO Employee VALUES('Orlan Hinksen','11774531',4531.49,59,'Administrativo','2020-7-4')
INSERT INTO Employee VALUES('Ignazio Voss','20236178',1781.75,28,'Vendedor','2021-9-15')
INSERT INTO Employee VALUES('Hakim Gregoletti','17477157',7715.72,41,'Marketing','2021-6-18')
INSERT INTO Employee VALUES('Bert Landeaux','14680444',8044.44,47,'Administrativo','2021-8-4')
INSERT INTO Employee VALUES('Correy Brookhouse','45206013',0601.32,38,'Arquitecto','2021-12-7')
INSERT INTO Employee VALUES('Kingsley Nolton','39912618',1261.83,26,'Vendedor','2021-11-1')
INSERT INTO Employee VALUES('Nester Brightman','57501382',1382.21,32,'Administrativo','2022-5-2')
INSERT INTO Employee VALUES('Allie Canellas','24754364',7543.64,49,'Contador','2022-9-5')
INSERT INTO Employee VALUES('Corinna Allawy','12924524',5248.91,47,'Administrativo','2022-3-29')
INSERT INTO Employee VALUES('Willow Bett','24218897',8971.41,22,'Arquitecto','2022-6-13')
INSERT INTO Employee VALUES('Coraline Townsend','22713081',3081.60,28,'Arquitecto','2022-5-8')
INSERT INTO Employee VALUES('Guillaume Antonacci','15913798',7981.62,41,'Vendedor','2022-8-24')
INSERT INTO Employee VALUES('Sylvia Mapes','43199542',9954.22,47,'Marketing','2022-9-16')
INSERT INTO Employee VALUES('Keslie Ellsom','11823721',2162.40,54,'Administrativo','2022-5-25')
INSERT INTO Employee VALUES('Roth McKennan','91231572',3157.25,35,'Vendedor','2022-10-29')
INSERT INTO Employee VALUES('Ulrich Gutsell','20418923',9235.97,41,'Arquitecto','2022-11-30')

