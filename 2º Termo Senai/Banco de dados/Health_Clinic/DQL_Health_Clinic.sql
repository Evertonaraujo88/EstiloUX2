--Criar script que exiba os seguintes dados:

-- Id Consulta
-- Data da Consulta
-- Horario da Consulta
-- Nome da Clinica
-- Nome do Paciente
-- Nome do Medico
-- Especialidade do Medico
-- CRM
-- Prontuário ou Descricao
-- FeedBack(Comentario da consulta)

USE Health_Clinic_Manha;

SELECT
tb_Consulta.IdConsulta AS "Id Consulta",
tb_Consulta.DataConsulta AS "Data da Consulta",
tb_Consulta.HoraConsulta AS "Horario da Consulta",
tb_Clinica.NomeFantasia AS "Nome da Clinica",
tb_Paciente.NomePaciente AS "Nome do Paciente",
tb_Medico.NomeMedico AS "Nome do Medico",
tb_Especialidade.NomeEspecialidade AS "Especialidade do Medico",
Tb_Medico.CRM AS "CRM",
tb_Consulta.Prontuario AS "Prontuario do Paciente",
tb_Comentarios.Descricao AS "FeedBack"
FROM tb_Consulta

LEFT JOIN tb_Paciente 
ON tb_Paciente.IdPaciente = tb_Consulta.IdPaciente

LEFT JOIN tb_Medico
ON tb_Medico.IdMedico = tb_Consulta.IdMedico

LEFT JOIN tb_Clinica
ON tb_Clinica.IdClinica = tb_Medico.IdClinica

LEFT JOIN tb_Especialidade
ON tb_Especialidade.IdEspecialidade = tb_Medico.IdEspecialidade

LEFT JOIN tb_Comentarios
ON tb_Comentarios.IdConsulta = tb_Consulta.IdConsulta




