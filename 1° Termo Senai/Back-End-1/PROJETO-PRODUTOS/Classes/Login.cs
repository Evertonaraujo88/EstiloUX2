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
            string email;
            string senha;

            do //Validação paralogar no sistema, enquanto usuario e senha estiver incorretos, não entra no sistema e fica perguntando usuario e senha corretos
           {

            Console.WriteLine($"Insira seu e-mail: ");
            email = Console.ReadLine();
            
            Console.WriteLine($"Insira sua senha: ");
            senha = Console.ReadLine();
           
            
            
            if (email == _usuario.Email && senha == _usuario.Senha)
            {
                this.Logado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login Efetuado com sucesso!!");
                Console.ResetColor();

                                
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Falha ao logar!!");
                Console.ResetColor();
                Console.WriteLine($"");
                
            }
            } while (Logado == false);
            
        }
        //Deslogar do app
        public void Deslogar ()
        {
            Logado = false;
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Deslogando do app");
            Console.ResetColor();
            Console.WriteLine($"");
        }

        
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;
        
            do
            {
            Console.WriteLine($"");
            Console.WriteLine(@$"

                  MENU DE OPÇÕES:
            ---------------------------
            | [1] - Cadastrar Produto |
            |                         |
            | [2] - Listar Produto    |
            |                         |
            | [3] - Remover Produto   |
            |                         |
            | [4] - Cadastrar Marca   |
            |                         |
            | [5] - Listar Marcas     |
            |                         |
            | [6] - Remover Marca     |
            |                         |
            | [0] - Sair              |
            ---------------------------
            ");
            Console.WriteLine($"");
            
            
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
                produto.Listar();
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
                marca.Listar();
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