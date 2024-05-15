USE AUTOSKOLA;

SELECT DISTINCT id_vozila, brend, model
FROM Duzi INNER JOIN Vozila ON Duzi.vozilo = Vozila.id_vozila
WHERE CAST(GETDATE() AS DATE) NOT BETWEEN datum_zaduzenja AND ISNULL(datum_razduzenja, DATEADD(DAY, 1, GETDATE()));