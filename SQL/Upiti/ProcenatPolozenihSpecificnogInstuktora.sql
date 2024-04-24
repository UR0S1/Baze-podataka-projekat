USE AUTOSKOLA

SELECT 
	r.id_radnika AS 'ID',
	r.ime AS 'Ime',
	r.prezime AS 'Prezime',
	SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih',
    SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih',
	CAST (
		ROUND(
        100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) /
        NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),
        2
    ) AS DECIMAL(5,2)) AS 'Procenat polozenih'
FROM Kandidati k
INNER JOIN Polaganje p ON k.JMBG = p.kandidat
INNER JOIN Radnici r ON r.id_radnika = k.instruktor
WHERE instruktor = '3' AND vrsta_polaganja = '2' /*user_input za id instruktora*/ /* AND datum BETWEEN {date1} AND {date2}*/
GROUP BY instruktor,r.id_radnika,r.ime,r.prezime;




