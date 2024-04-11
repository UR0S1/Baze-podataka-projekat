# Baze-podataka-projekat
Projekat iz baza podataka koji podržava deo rada auto škole

Tabele u projektu:
### ISPITI
-id_ispita (primary key)  
-datum (date)  
-kandidat (foreign key)  
-tip polaganja (foreign key)  
-prolaz (bool)  

### KANDIDATI
-ime (varchar(20))  
-prezime (varchar(20))  
-JMBG (primary key)  
-adresa (varchar(50))  
-teorija (bool)  
-voznja (bool)  
-prva_pomoc (bool)  

### VOZILA
-id_vozila (primary key)  
-kategorija (varchar(3))  
-brend (varchar(15))  
-model (varchar(15))  

### RADNICI
-ime (varchar(20))  
-prezime (varchar(20))  
-JMBG (varchar(13))  
-adresa (varchar(50))  
-pozicija (foreign key)  
-vozilo (foreign key)  

### DUZI
-radnik (foreign key)  
-vozilo (foreign key)  
-datum_zaduzenja (date)  

### VRSTE_POLAGANJA
-id (primary key)  
-vrsta(varchar(10))  

### Polaganje
-vrsta_polaganja (foreign key)  
-kandidat (foreign key)  
-datum (date)  

