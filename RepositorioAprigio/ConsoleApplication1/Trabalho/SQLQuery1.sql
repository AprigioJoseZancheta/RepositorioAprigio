﻿select a.Nome_Aluno, c.NomeCurso from MATRICULA As m inner join ALUNO As a on a.Id =  m.ALUNO_ID  inner join CURSO As c on c.Id =  m.CURSO_ID order by NomeCurso
select Email from ALUNO where DataNascimento < '1996'
select count(*) from ALUNO
select count(c.Id) from CURSO As c inner join MATRICULA  As m on c.Id = m.CURSO_ID group by c.Id
select Nome_Aluno from ALUNO where DataNascimento < '1996' 
select Nome_Aluno from ALUNO where Sexo = 'F'
select a.Nome_Aluno, c.Id from MATRICULA As m inner join ALUNO As a on a.Id = m.ALUNO_ID  inner join CURSO As c on c.Id = m.CURSO_ID  where c.Id = 1 and Sexo = 'F'
select NomeCurso from CURSO order by NomeCurso