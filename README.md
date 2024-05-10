# Baze-podataka-projekat
Projekat iz baza podataka koji podržava deo rada auto škole

Tabele u projektu:
### KANDIDATI
- ime (varchar(20))  
- prezime (varchar(20))  
- JMBG (primary key)  
- adresa (varchar(50))  
- instruktor (foreign key)  
- teorija (bool)  
- voznja (bool)  
- prva_pomoc (bool)  

### VOZILA
- id_vozila (primary key)  
- kategorija (varchar(3))  
- brend (varchar(15))  
- model (varchar(15))  

### RADNICI
- ime (varchar(20))  
- prezime (varchar(20))  
- JMBG (varchar(13))  
- adresa (varchar(50))  
- pozicija (foreign key)  
- vozilo (foreign key)  

### TIP_RADNIKA
- id_pozicije (primary key)  
- tip_radnika (varchar(25))  

### DUZI
- radnik (foreign key)  
- vozilo (foreign key)  
- datum_zaduzenja (date)  

### VRSTE_POLAGANJA
- id (primary key)  
- vrsta(varchar(10))  

### POLAGANJE
- id_polaganja (primary key)
- vrsta_polaganja (foreign key) 
- kategorija (varchar(3))
- kandidat (foreign key)  
- datum (date)  
- polozen (bool)

## RELATIONSHIP DIAGRAM
![relationship-diagram](https://github.com/UR0S1/Baze-podataka-projekat/blob/main/SQL_baza_dijagram.png?raw=true)
