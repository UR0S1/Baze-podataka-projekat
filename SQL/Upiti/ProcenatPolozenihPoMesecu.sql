USE AUTOSKOLA

SELECT
    DATEPART(YEAR, datum) AS 'Godina',
    DATEPART(MONTH, datum) AS 'Mesec',
    SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) AS 'Polozenih',
    SUM(CASE WHEN p.polozen = 0 THEN 1 ELSE 0 END) AS 'Palih',
	CAST (
		ROUND(
        100.0 * SUM(CASE WHEN p.polozen = 1 THEN 1 ELSE 0 END) /
        NULLIF(SUM(CASE WHEN p.polozen IN (0, 1) THEN 1 ELSE 0 END), 0),
        2
    ) AS DECIMAL(5,2)) AS 'Procenat polozenih'
FROM Kandidati k
LEFT JOIN Polaganje p ON k.JMBG = p.kandidat
WHERE datum IS NOT NULL
GROUP BY DATEPART(YEAR, datum),DATEPART(MONTH, datum)
ORDER BY Godina, Mesec;
/* WHERE datum BETWEEN {date1} AND {date2} */

