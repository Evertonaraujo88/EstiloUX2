using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PRODUTOS.Classes
{
    public class Login
    {
        public bool Logado{ get; private set; }

        public Login()
        {
            Usuario user = new Usuario(); //instanciando o construtor da classe usuario

            //validar se esta logado
            Logar(user);

            //se Logado...gerar um menu de opcoes
            if (Logado == true)
            {
                GerarMenu();
            }
            
        }

        public void Logar(Usuario _usuario)
        {
            Console.WriteLine($"Insira seu e-mail: ");
            string email = Console.ReadLine();
            
            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();
            
            if (email == _usuario.Email && senha == _usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login Efetuado com sucesso!!");
                
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar!!");
                
            }
            
            
        }

        public void Deslogar ()
        {
            Logado = false;
            Console.WriteLine($"Deslogando do app");
            
        }

        
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;
        
            do
            {
             Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produto
            [3] - Remover Produto
            _______________________
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            
            ");
            
            opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                //cadastrar
                produto.Cadastrar();
                break;

                case "2":
                //listar
                produto.Listar();
                break;

                case "3":
                //remover
                Console.WriteLine($"Informe o codigo do produto a ser removido: ");
                int codigo = int.Parse(Console.ReadLine());
                
                produto.Deletar(codigo);
                break;

                case "4":
                //Cadastrar Marca
                marca.Cadastrar();
                break;

                case "5":
                //Listar marca
                marca.Listar();

                break;

                case "6":
                //Remover Marca
                Console.WriteLine($"Informe o codigo da marca a ser removido: ");
                int codigoMarca = int.Parse(Console.ReadLine());

                marca.Deletar(codigoMarca);         
                break;

                case "0":
                Deslogar();
                break;
                default:
                Console.WriteLine($"Opcao invalida!!!");
                
                break;
                }
                } while (opcao != "0");

           
            
        }

    }
}