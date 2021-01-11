--DQL
USE Gufi_Tarde

SELECT * FROM TipoUsuario;
SELECT * FROM TipoEvento;
SELECT * FROM Instituicao;
SELECT * FROM  Usuario;
SELECT * FROM Evento;
SELECT * FROM Presenca;

USE Gufi_Tarde

--Listar tds os usuarios (Nome, Email,Tpo,Data de Nasc, Genero)
SELECT Usuario.NomeUsuario,Usuario.Email,TipoUsuario.TituloTipoUsuario,Usuario.DataNascimento,Usuario.Genero FROM Usuario
INNER JOIN TipoUsuario ON TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario;

--Listar tds as Instituiçoes cadastradas (CNPJ,Nome Fantasia,Endereco)
SELECT Instituicao.CNPJ,Instituicao.NomeFantasia,Instituicao.Endereco FROM Instituicao;

--Listar apenas os eventos que sao publicos (NomeEvento,Tipo,Data,Publico ou Privado,Descricao,Dados da Instituicao)
SELECT	Evento.NomeEvento,
		TipoEvento.TituloTipoEvento,
		Evento.DataEvento,
		CASE	WHEN AcessoLivre = 1 THEN 'Publico'
		WHEN  AcessoLivre = 0 THEN 'Privado'
END AS PublicoPrivado,Evento.Descricao,Instituicao.CNPJ,Instituicao.NomeFantasia,Instituicao.Endereco FROM Evento
INNER JOIN Instituicao	ON Instituicao.IdInstituicao = Evento.IdInstituicao
INNER JOIN TipoEvento	ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento

--Listar tds os eventos que um determindo usuario participa (NomeEvento,Tipo,Data,Publico ou Privado,Descricao,Dados da instituicao,Dados do usuario)
SELECT Evento.NomeEvento,TipoEvento.TituloTipoEvento,Evento.DataEvento,Evento.AcessoLivre,Evento.Descricao,Instituicao.CNPJ,Instituicao.NomeFantasia,Instituicao.Endereco FROM Evento
INNER JOIN Instituicao	ON Instituicao.IdInstituicao = Evento.IdInstituicao
INNER JOIN TipoEvento	ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
WHERE Evento.AcessoLivre = 1; --Mostrando somente os eventos publicos

--EXTRAS

--Ao listar os eventos, mostrar na coluna acessolivre o valor 'PUBLICO'quando for 1 e 'PRIVADO' quando for 0
--feito

--Ao listar os eventos que um usuario participa,mostra apenas os eventos com a situacao 'confirmada'



--Cadastrar mais tres usuarios (Voce e duas pessoas) com os dados pessoais, ao listar todos os usuarios, mostrar também a idade

SELECT Usuario.NomeUsuario, Usuario.Genero, Usuario.Email, DATEDIFF(YEAR , Usuario.DataNascimento, GETDATE()) as Idade FROM Usuario 

DECLARE @DataNascimento DATETIME = '1991-12-12'
DECLARE @Hoje DATETIME = GETDATE					-- exemplo de horário da função GETDATE()
																-- funciona corretamente se alterado acima para hora 00:00:00

SELECT FLOOR(DATEDIFF(DAY, @DataNascimento, @Hoje) / 365.25)	-- retorna 21, idade correta
SELECT DATEDIFF(HOUR, @DataNascimento, @Hoje) / 8766			-- retorna 22

datediff(yy, data ou campo, getdate()) as Idade,		-- Em anos
	datediff(mm, data ou campo, getdate()) as Meses,	-- Em meses
	datediff(dd, data ou campo, getdate()) as dias,		-- Em dias
	datediff(hh, data ou campo, getdate()) as Horas		-- Em horas
from Sua tabela

