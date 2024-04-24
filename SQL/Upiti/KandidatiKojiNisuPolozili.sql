SELECT *
FROM Kandidati k
LEFT JOIN Polaganje p ON k.JMBG = p.kandidat
WHERE polozen IS NULL OR polozen = 0; /* AND tip_polaganja = {user_input}*/ /*treba dodati i proveru da ne izlaze za polaganje voznje oni koji nisu teoriju sa user_input-om*/
