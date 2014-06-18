select PrimeiroNome, SobreNome from FUNCIONARIO order by SobreNome
select * from FUNCIONARIO order by Funcao
select PrimeiroNome, SobreNome, Salario from FUNCIONARIO where Salario > 1000 order by PrimeiroNome, SobreNome
select sum(Salario) As Salario from FUNCIONARIO
select f.PrimeiroNome, f.Funcao, d.Nome from FUNCIONARIO AS f inner join DEPARTAMENTOS AS d on d.Id = f.DEPARTAMENTO_ID order by nome
select d.Nome, sum(f.Salario) As Salario from DEPARTAMENTOS AS d inner join FUNCIONARIO AS f on d.Id = f.DEPARTAMENTO_ID group by d.Nome
delete from DEPARTAMENTOS where Id = 3
select * from DEPARTAMENTOS where Id =5 
select PrimeiroNome, Salario from FUNCIONARIO where Salario between 500 and 1500 order by PrimeiroNome
select f.PrimeiroNome, d.Nome from FUNCIONARIO As f inner join DEPARTAMENTOS AS d on d.Id = f.DEPARTAMENTO_ID and PrimeiroNome like 'L%' order by d.Nome
select count(*) from FUNCIONARIO
select count(*) from DEPARTAMENTOS AS d inner join FUNCIONARIO AS f on d.Id = f.DEPARTAMENTO_ID group by d.Id
select avg(Salario) from FUNCIONARIO
select  min(Salario) from FUNCIONARIO
select min(Salario) from DEPARTAMENTOS AS d inner join FUNCIONARIO As f on d.Id = f.DEPARTAMENTO_ID group by d.Id
select max(Salario) from DEPARTAMENTOS AS d inner join FUNCIONARIO As f on d.Id = f.DEPARTAMENTO_ID group by d.Id
select d.Nome, f.PrimeiroNome from FUNCIONARIO As f inner join DEPARTAMENTOS AS d on d.Id = f.DEPARTAMENTO_ID order by d.Nome, f.PrimeiroNome