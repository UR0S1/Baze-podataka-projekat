SELECT
    r.ime AS 'Instruktor',
    SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih',
    SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih',
	CAST (
		ROUND(
        100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) /
        NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),
        2
    ) AS DECIMAL(5,2)) AS 'Procenat polozenih'
FROM Radnici r
LEFT JOIN Kandidati k ON r.id_radnika = k.instruktor
LEFT JOIN Polaganje p ON k.JMBG = p.kandidat
WHERE r.pozicija = '1'/* instruktor */ /* AND datum BETWEEN {date1} AND {date2} */
GROUP BY r.ime;
