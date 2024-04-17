USE AUTOSKOLA;


CREATE TABLE Kandidati(
    ime VARCHAR(20),
    prezime VARCHAR(20),
    JMBG VARCHAR(13) PRIMARY KEY NOT NULL,
    adresa VARCHAR(30),
    teorija BIT,
    voznja BIT,
    prva_pomoc BIT
);


CREATE TABLE Vozila (
    id_vozila INT IDENTITY(1,1) PRIMARY KEY,
    kategorija VARCHAR(3),
    brend VARCHAR(15),
    model VARCHAR(15)
);



CREATE TABLE Tip_radnika (
    id_pozicije INT IDENTITY(1,1) PRIMARY KEY,
    tip_radnika VARCHAR(25)
);

CREATE TABLE Radnici(
    id_radnika INT IDENTITY(1,1) PRIMARY KEY,
    ime VARCHAR(20),
    prezime VARCHAR(20),
    JMBG VARCHAR(13),
    adresa VARCHAR(50),
    pozicija INT,
    FOREIGN KEY (pozicija) REFERENCES Tip_radnika(id_pozicije)
);

CREATE TABLE Duzi (
    radnik INT,
    vozilo INT,
    datum_zaduzenja DATE,
    datum_razduzenja DATE NULL,
    PRIMARY KEY (radnik, vozilo, datum_zaduzenja),
    FOREIGN KEY (radnik) REFERENCES Radnici(id_radnika),
    FOREIGN KEY (vozilo) REFERENCES Vozila(id_vozila)
);


CREATE TABLE Vrste_polaganja (
    id INT IDENTITY(1,1) PRIMARY KEY,
    vrsta VARCHAR(10)
);


CREATE TABLE Polaganje (
    vrsta_polaganja INT,
    kandidat VARCHAR(13),
    datum DATE,
    polozen BIT,
    PRIMARY KEY (vrsta_polaganja, kandidat, datum),
    FOREIGN KEY (vrsta_polaganja) REFERENCES Vrste_polaganja(id),
    FOREIGN KEY (kandidat) REFERENCES Kandidati(JMBG)
);