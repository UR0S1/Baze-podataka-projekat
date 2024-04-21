IF NOT EXISTS 
   (
    SELECT name FROM master.dbo.sysdatabases 
    WHERE name = 'AUTOSKOLA'
    )
BEGIN
CREATE DATABASE AUTOSKOLA 
ON
( NAME = Auto_skola_dat, 
		 FILENAME = 'E:\Skola\Baze\Auto_skola.mdf', 
		 SIZE = 100MB,	MAXSIZE = 500MB, FILEGROWTH = 20% )
LOG ON 
( NAME = Auto_skola_log, 
		 FILENAME = 'E:\Skola\Baze\Auto_skola.ldf', 
		 SIZE = 20MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10MB );

ALTER DATABASE AUTOSKOLA
COLLATE Serbian_Latin_100_CS_AS;
END