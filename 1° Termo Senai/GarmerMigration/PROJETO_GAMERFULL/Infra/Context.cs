using Microsoft.EntityFrameworkCore;
using PROJETO_GAMERFULL.Models;

namespace PROJETO_GAMERFULL.Infra
{
    //configuracoes para acesso ao banco de dados
    public class Context : DbContext
    {
        public Context()
        {   
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string de conexao com o banco
            //Data Source : o nome do servidor do gerenciador do banco
            //Initial Catalog : nome do banco de dados

            //Autenticacao pelo Windows
            //Integrated Security : Autenticaao pelo Windows
            //TrustServerCertificate: Autentificacao pelo Windows

            //Autenticacao pelo SqlServer
            //user Id = "nome do seu usuario de login"
            //pwd (password) = "senha do seu usuario"

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE16-S15; Initial Catalog = gamerFull; User Id = sa; pwd = Senai@134; TrustServerCertificate = true ");//string de conexao com o banco de dados

            }
            
        }

        //Referencia de classe de tabelas
        public DbSet<Jogador> Jogador {get; set; }
        public DbSet<Equipe> Equipe {get; set; }
    }
}