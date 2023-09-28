using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Health_Clinic_manha.Migrations
{
    /// <inheritdoc />
    public partial class BDHealth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClinicaDomain",
                columns: table => new
                {
                    IdClinica = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "CHAR(14)", maxLength: 14, nullable: false),
                    RazaoSocial = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    HorarioAbertura = table.Column<TimeOnly>(type: "time", nullable: false),
                    HorarioFechamento = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicaDomain", x => x.IdClinica);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadesDomain",
                columns: table => new
                {
                    IdEspecialidade = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeEspecialidade = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadesDomain", x => x.IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuarioDomain",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuarioDomain", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDomain",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "CHAR(60)", maxLength: 60, nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDomain", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_UsuarioDomain_TiposUsuarioDomain_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuarioDomain",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoDomain",
                columns: table => new
                {
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeMedico = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CRM = table.Column<string>(type: "CHAR(6)", maxLength: 6, nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdClinica = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEspecialidade = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoDomain", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_MedicoDomain_ClinicaDomain_IdClinica",
                        column: x => x.IdClinica,
                        principalTable: "ClinicaDomain",
                        principalColumn: "IdClinica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoDomain_EspecialidadesDomain_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "EspecialidadesDomain",
                        principalColumn: "IdEspecialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoDomain_UsuarioDomain_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioDomain",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacienteDomain",
                columns: table => new
                {
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePaciente = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CPF = table.Column<string>(type: "CHAR(11)", maxLength: 11, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Telefone = table.Column<string>(type: "CHAR(11)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteDomain", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_PacienteDomain_UsuarioDomain_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioDomain",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultaDomain",
                columns: table => new
                {
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "date", nullable: false),
                    HoraConsulta = table.Column<TimeOnly>(type: "time", nullable: false),
                    Prontuario = table.Column<string>(type: "TEXT", nullable: false),
                    Confirmacao = table.Column<bool>(type: "BIT", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaDomain", x => x.IdConsulta);
                    table.ForeignKey(
                        name: "FK_ConsultaDomain_MedicoDomain_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "MedicoDomain",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultaDomain_PacienteDomain_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "PacienteDomain",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ComentariosDomain",
                columns: table => new
                {
                    IdComentario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Exibe = table.Column<bool>(type: "BIT", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentariosDomain", x => x.IdComentario);
                    table.ForeignKey(
                        name: "FK_ComentariosDomain_ConsultaDomain_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "ConsultaDomain",
                        principalColumn: "IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentariosDomain_PacienteDomain_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "PacienteDomain",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosDomain_IdConsulta",
                table: "ComentariosDomain",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosDomain_IdPaciente",
                table: "ComentariosDomain",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaDomain_IdMedico",
                table: "ConsultaDomain",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaDomain_IdPaciente",
                table: "ConsultaDomain",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDomain_CRM",
                table: "MedicoDomain",
                column: "CRM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDomain_IdClinica",
                table: "MedicoDomain",
                column: "IdClinica");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDomain_IdEspecialidade",
                table: "MedicoDomain",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDomain_IdUsuario",
                table: "MedicoDomain",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteDomain_CPF",
                table: "PacienteDomain",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PacienteDomain_IdUsuario",
                table: "PacienteDomain",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDomain_Email",
                table: "UsuarioDomain",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDomain_IdTipoUsuario",
                table: "UsuarioDomain",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentariosDomain");

            migrationBuilder.DropTable(
                name: "ConsultaDomain");

            migrationBuilder.DropTable(
                name: "MedicoDomain");

            migrationBuilder.DropTable(
                name: "PacienteDomain");

            migrationBuilder.DropTable(
                name: "ClinicaDomain");

            migrationBuilder.DropTable(
                name: "EspecialidadesDomain");

            migrationBuilder.DropTable(
                name: "UsuarioDomain");

            migrationBuilder.DropTable(
                name: "TiposUsuarioDomain");
        }
    }
}
