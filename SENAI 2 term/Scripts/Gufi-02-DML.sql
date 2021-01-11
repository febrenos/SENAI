--DML
USE Gufi_Tarde

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES 	('ADM'),
		('Comum');

INSERT INTO TipoEvento (TituloTipoEvento)
VALUES 	('Carnaval'),
		('HakunaBatata'),
		('Evento Jeffinho'),
		('Tecnology');

INSERT INTO Instituicao (CNPJ,NomeFantasia,Endereco)
VALUES 	('1111','hAKe','Rua das mg'),
		('2222','No creativity','Rua paraiso'),
		('3333','Funny','Rua dos loko'),
		('4444','Happy','Av. Sao Miguel');

INSERT INTO Usuario (NomeUsuario,Email,Senha,Genero,DataNascimento,IdTipoUsuario)
VALUES 	('Roger silva','roger@gmail.com','2623','masc','29/10/1990','2'),
		('Kátia goncalves','nitio@gmail.com','2623','fem','14/08/2002','2'),
		('Nati kati','tiotio@gmail.com','2623','fem','23/11/2000','2'),
		('Felipe Sugisawa','felipesugisawa1@gmail.com','2623','masc','29/10/2002','1');


INSERT INTO Evento (NomeEvento,DataEvento,Descricao,AcessoLivre,IdInstituicao,IdTipoEvento)
VALUES 	('Nanias','20/02/2020','Muito legal','1','1','1'),
		('MVC','19/02/2020','Muito legal','1','1','1'),
		('BGS','17/02/2020','Muito legal','0','1','1');

INSERT INTO Presenca(IdUsuario,IdEvento,Situacao)
VALUES 	('1','1','agendado'),
		('1','2','confirmado'),
		('1','3','calcelado'),
		('1','3','cancelado');
