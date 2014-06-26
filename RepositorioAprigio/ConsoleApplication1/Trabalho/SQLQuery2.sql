
select a.Nome_Aluno As NomeAlunos, c.NomeCurso As NomeCursos from MATRICULA As m inner join ALUNO As a on a.Id =  m.ALUNO_ID  inner join CURSO As c on c.Id =  m.CURSO_ID order by NomeCurso
select Email from ALUNO where DataNascimento < '1996'
select count(*) As ContidadesAlunos from ALUNO 
select c.NomeCurso As NomeCurso, count(*) As NumeroPessoas from ALUNO as a inner join MATRICULA as m on m.ALUNO_ID = a.Id inner join CURSO As c on m.CURSO_ID = c.Id group by c.NomeCurso
select Nome_Aluno from ALUNO where DataNascimento < '1996'
select Nome_Aluno from ALUNO where Sexo = 'F'
select a.Nome_Aluno, c.Id from MATRICULA As m inner join ALUNO As a on a.Id = m.ALUNO_ID  inner join CURSO As c on c.Id = m.CURSO_ID  where c.Id = 1 and Sexo = 'F'
select NomeCurso from CURSO order by NomeCurso