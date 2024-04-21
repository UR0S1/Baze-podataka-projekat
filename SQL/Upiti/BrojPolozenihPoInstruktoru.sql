USE AUTOSKOLA

SELECT instruktor AS 'Instruktor', COUNT(*) AS 'Broj polozenih'
FROM Kandidati
WHERE JMBG IN (SELECT kandidat
			   FROM Polaganje
			   WHERE polozen = '1')/* AND datum BETWEEN {date1} AND {date2}*/ 
GROUP BY instruktor;			   /* date1 i date2 user input sa forme*/




