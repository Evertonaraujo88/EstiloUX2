USE Health_Clinic_Manha;

INSERT INTO tb_TipoDeUsuario(TituloTidoDeUsuario)
VALUES 
	('Administrador'),
	('Medico'),
	('Paciente')

SELECT * FROM tb_TipoDeUsuario

INSERT INTO tb_Usuario (IdTipoDeUsuario,Email, Senha)
VALUES
		(1, 'gabi.ramos1309@gmail.com', 'Chiuaua123'),
		(2, 'joao.gostosao@gmail.com', '20533539Jj'),
		(2, 'evertonaraujosenai@gmail.com', 'caogataoK'),
		(3, 'luizinhogameplays@gmail.com', 'TmNg@1984'),
		(3, 'guilhermedarth045@gmail.com', '4444'),
		(3, 'brizidao@gmail.com', 'humbertinho345')

SELECT * FROM tb_Usuario

INSERT INTO tb_Paciente (IdUsuario, NomePaciente, CPF, DataNascimento, Telefone, Endereco)
VALUES
		(4, 'Luis Henrique de jesus Correia', '28586061214', '06/04/2003', '00000001', 'Rua Niteroi - 10'),
		(5, 'Guilherme Sousa Oliveira', '45839277642', '26/04/2002', '00000002', 'Rua Niteroi - 20'),
		(6, 'André Brizido Basilio', '13556798812', '01/01/2004', '00000003', 'Rua Niteroi - 30')

SELECT * FROM tb_Paciente

INSERT INTO tb_Clinica (CNPJ, RazaoSocial, NomeFantasia, Endereco, HorarioAbertura, HoraroFechamento)
VALUES
		('35626165000158', 'Clinica de Saude Ltda', 'Health Clinic', 'Rua Amazonas, 1910', '08:00', '17:00')

SELECT * FROM tb_Clinica

INSERT INTO tb_Especialidade(NomeEspecialidade)
VALUES 
		('Pediatria'),
		('Cirurgia Geral'),
		('Ginecologia e Obstetrícia'),
		('Anestesiologia'),
		('Ortopedia e Traumatologia'),
		('Medicina do trabalho'),
		('Cardiologia')

SELECT * FROM tb_Usuario
SELECT * FROM tb_Especialidade

INSERT INTO tb_Medico(IdUsuario, IdClinica, IdEspecialidade, NomeMedico, CRM)
VALUES
		(2, 1, 1, 'João Vitor Oliveira Santos', '123456'),
		(3, 1, 5, 'Everton Silva de Araujo', '789456')
SELECT * FROM tb_Paciente
SELECT * FROM tb_Medico

INSERT INTO tb_Consulta (IdPaciente, IdMedico, DataConsulta, HoraConsulta, Prontuario, Situacao)
VALUES
		(1, 1, '21/08/2023', '09:00', 'Paciente Luis, encontra-se com boa saude, se queixa apenas de tosse todas as noites, indiquei o remedio prelone durante 5 dias e caso nao melhorar, retornar a clinica', 1),
		(2, 2, '22/08/2023', '12:00', 'Paciente Guilherme reclama de dores na coluna lombar, foi solicitado RM da coluna lombar e medicado, assim que estiver o exame em maos deve retornar a consulta', 1),
		(3, 2, '22/08/2023', '14:00', 'Paciente Andre, indica ter caido da escada e batido o ante-braco direito no degrau da escada, apos exame da rx foi constatado uma luxacao na regiao, o paciente ficara 8 dias imobilizado e depois retornar para novos exames', 1)

SELECT * FROM tb_Paciente
SELECT * FROM tb_Consulta

INSERT INTO tb_Comentarios (IdPaciente, IdConsulta, Descricao, Situacao)
VALUES
	(1, 1, 'Dr. Joao me atendeu super mal, nao gostei da forma na qual ele fale e nao irei retornar nem Fodendo!!',0),
	(2, 2, 'Dr. Everton eh um excelente profissional', 1),
	(3, 3, 'Dr. Everton me atendeu super bem, muito educado e prestativo', 1)

	SELECT * FROM tb_Comentarios
