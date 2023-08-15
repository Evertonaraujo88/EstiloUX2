USE Exercicio1_1;

SELECT
		Pessoa.IdPessoa,
		Pessoa.Nome,
		Pessoa.CNH,
		Email.NomeEmail AS Email,
		Telefone.NumeroTelefone AS Telefone

FROM

		Pessoa, Email, Telefone

WHERE
		Pessoa.IdPessoa = Email.IdEmail
AND		Pessoa.IdPessoa = Telefone.IdPessoa

ORDER BY Nome DESC





/*SELECT  
		Pessoa.IdPessoa,
		Pessoa.Nome,
		Pessoa.CNH,
		Email.NomeEmail AS Email,
		Telefone.NumeroTelefone as Telefone

FROM 
	Pessoa

JOIN  Email ON Pessoa.IdPessoa = Email.IdPessoa
JOIN Telefone ON Pessoa.IdPessoa = Telefone.IdPessoa

ORDER BY Pessoa.Nome DESC
	
