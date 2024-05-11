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

GO

USE AUTOSKOLA;

DROP TABLE IF EXISTS Polaganje
CREATE TABLE Polaganje (
    id_polaganja INT PRIMARY KEY IDENTITY(1,1),
    vrsta_polaganja INT,
    kategorija VARCHAR(3),
    kandidat VARCHAR(13),
    datum DATE,
    polozen BIT,
);

DROP TABLE IF EXISTS Duzi
CREATE TABLE Duzi (
    radnik INT,
    vozilo INT,
    datum_zaduzenja DATE,
    datum_razduzenja DATE NULL,
    PRIMARY KEY (radnik, vozilo, datum_zaduzenja)
);

DROP TABLE IF EXISTS Kandidati
CREATE TABLE Kandidati(
    ime VARCHAR(20),
    prezime VARCHAR(20),
    JMBG VARCHAR(13) PRIMARY KEY NOT NULL,
    adresa VARCHAR(30),
    teorija BIT,
    voznja BIT,
    instruktor INT,
    prva_pomoc BIT
);

DROP TABLE IF EXISTS Radnici
CREATE TABLE Radnici(
    id_radnika INT IDENTITY(1,1) PRIMARY KEY,
    ime VARCHAR(20),
    prezime VARCHAR(20),
    JMBG VARCHAR(13),
    adresa VARCHAR(50),
    pozicija INT
);

DROP TABLE IF EXISTS Vozila
CREATE TABLE Vozila (
    id_vozila INT IDENTITY(1,1) PRIMARY KEY,
    kategorija VARCHAR(3),
    brend VARCHAR(15),
    model VARCHAR(15)
);

DROP TABLE IF EXISTS Tip_radnika
CREATE TABLE Tip_radnika (
    id_pozicije INT IDENTITY(1,1) PRIMARY KEY,
    tip_radnika VARCHAR(25)
);

DROP TABLE IF EXISTS Vrste_polaganja
CREATE TABLE Vrste_polaganja (
    id INT IDENTITY(1,1) PRIMARY KEY,
    vrsta VARCHAR(10)
);



ALTER TABLE Polaganje
ADD CONSTRAINT FK_VrstePolaganja_Polaganje FOREIGN KEY (vrsta_polaganja) REFERENCES Vrste_polaganja(id),
	CONSTRAINT FK_Kandidati_Polaganje FOREIGN KEY (kandidat) REFERENCES Kandidati(JMBG);

ALTER TABLE Duzi
ADD CONSTRAINT FK_Radnici_Duzi FOREIGN KEY (radnik) REFERENCES Radnici(id_radnika),
	CONSTRAINT FK_Vozila_Duzi FOREIGN KEY (vozilo) REFERENCES Vozila(id_vozila);

ALTER TABLE Kandidati
ADD CONSTRAINT FK_Radnici_Kandidati FOREIGN KEY (instruktor) REFERENCES Radnici(id_radnika);

ALTER TABLE Radnici
ADD CONSTRAINT FK_TipRadnika_Radnici FOREIGN KEY (pozicija) REFERENCES Tip_radnika(id_pozicije);


USE AUTOSKOLA;

-- Tipovi radnika
INSERT INTO Tip_radnika(tip_radnika) VALUES
    ('Instruktor'),
    ('Administrator'),
    ('Glavni instruktor');


-- Tipovi polaganja
INSERT INTO Vrste_polaganja (vrsta) VALUES
    ('Teorija'),
    ('Voznja');

-- Radnici
INSERT INTO Radnici (ime, prezime, JMBG, adresa, pozicija) VALUES
    ('Milos', 'Nikolic', '4567890123456', 'Adresa 3', 1),
    ('Jovana', 'Stojanovic', '7890123456789', 'Adresa 4', 2),
    ('Petar', 'Milinkovic', '1234567890123', 'Adresa 5', 1),
    ('Jelena', 'Kovacevic', '9876543210123', 'Adresa 6', 2),
    ('Nikola', 'Stojanovic', '2345678901234', 'Adresa 7', 1),
    ('Ivana', 'Jovanovic', '7890123456789', 'Adresa 8', 2);

-- Kandidati
INSERT INTO Kandidati (ime, prezime, JMBG, adresa, instruktor, teorija, voznja, prva_pomoc)
VALUES
    ('Ana', 'Petrovic', '1234567890123', 'Adresa 1', 1, 1, 0, 1),
    ('Marko', 'Jovanovic', '9876543210123', 'Adresa 2', 1, 0, 1, 0),
    ('Ivana', 'Kovacevic', '4567890123456', 'Adresa 3', 3, 1, 1, 1),
    ('Nikola', 'Milic', '7890123456789', 'Adresa 4', 5, 1, 1, 0),
    ('Jelena', 'Ristic', '2345678901234', 'Adresa 5', null, 0, 0, 1),
    ('Petar', 'Nikolic', '5678901234567', 'Adresa 6', null, 0, 0, 1),
    ('Milica', 'Stojanovic', '8901234567890', 'Adresa 7', 1, 1, 1, 1),
    ('Stefan', 'Pavlovic', '3456789012345', 'Adresa 8', 5, 1, 0, 1),
    ('Marija', 'Djordjevic', '6789012345678', 'Adresa 9', 3, 1, 1, 1),
    ('Dusan', 'Milinkovic', '0123456789012', 'Adresa 10', null, 0, 0, 1);


-- Vozila
INSERT INTO Vozila (kategorija, brend, model) VALUES
    ('B', 'Toyota', 'Corolla'),
    ('B', 'Mercedes', 'Sprinter'),
    ('B', 'Ford', 'Focus'),
    ('B', 'Volkswagen', 'Golf');


-- Polaganja
INSERT INTO Polaganje (vrsta_polaganja, kategorija, kandidat, datum, polozen) VALUES
    (1, 'B','3456789012345', '2024-03-21', 1),
    (1, 'B','1234567890123', '2024-04-20', 1),
    (2, 'B','9876543210123', '2024-04-22', 1),
    (1, 'B','2345678901234', '2024-04-23', 1),
    (2, 'B','3456789012345', '2024-04-24', 0),
    (1, 'B','4567890123456', '2024-04-25', 1),
    (2, 'B','5678901234567', '2024-04-26', 0),
    (1, 'B','7890123456789', '2024-03-26', 1),
    (2, 'B','7890123456789', '2024-02-26', 1),
    (1, 'B','6789012345678', '2024-04-27', 1);

-- Duzenja
INSERT INTO Duzi (radnik, vozilo, datum_zaduzenja, datum_razduzenja) VALUES
    (1, 1, '2024-04-18', '2024-04-25'),
    (2, 2, '2024-04-19', NULL),
    (1, 3, '2024-04-20', '2024-04-27'),
    (2, 4, '2024-04-21', NULL),
    (1, 1, '2024-04-26', '2024-04-29');

