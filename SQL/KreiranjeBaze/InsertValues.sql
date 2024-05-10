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
    ('Jelena', 'Ristic', '2345678901234', 'Adresa 5', 5, 0, 0, 1),
    ('Petar', 'Nikolic', '5678901234567', 'Adresa 6', 3, 0, 0, 1),
    ('Milica', 'Stojanovic', '8901234567890', 'Adresa 7', 1, 0, 1, 0),
    ('Stefan', 'Pavlovic', '3456789012345', 'Adresa 8', 5, 1, 0, 1),
    ('Marija', 'Djordjevic', '6789012345678', 'Adresa 9', 3, 1, 1, 0),
    ('Dusan', 'Milinkovic', '0123456789012', 'Adresa 10', 3, 0, 0, 1);


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

