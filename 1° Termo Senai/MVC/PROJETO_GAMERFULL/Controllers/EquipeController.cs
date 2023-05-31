using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROJETO_GAMERFULL.Infra;
using PROJETO_GAMERFULL.Models;

namespace PROJETO_GAMERFULL.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        //instancia do contexto para acessar o banco de dados
        Context c = new Context();//objeto "c" da classe context armazenas a informacoes e envia para o BD

        [Route("Listar")]//http://localhost:/Equipe/Listar

        public IActionResult Index()

        {
            //Variavel que armazena as equipes listadas do banco de dados
            ViewBag.Equipe = c.Equipe.ToList();

            //retorna a view de equipe (tela)
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("Cadastar")]
        public IActionResult Cadastrar(IFormCollection form){
            
            /*Instancia um objeto Equipe*/
            Equipe novaEquipe = new Equipe();

            /*Atribuição de valores recebidos do formulario.*/
            novaEquipe.Nome = form["Nome"].ToString();

            //no codigo abaixo estava chegando como string (nao vamos usar desta forma)
            /* novaEquipe.Imagem = form["Imagem"].ToString(); */

            //inicio da logica do upload da imagem
            if (form.Files.Count > 0)
            {
                //file eh a variavel que vai receber o indice do arquivo que esta no array
                var file = form.Files[0];

                //folder eh caminho que deve ser criado caso nao exista
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                //se nao existir o caminho atribuido a variavel folder....dentro da condicao ele cria o caminho
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //gera o caminho completo ate o caminho do arquivo(imagem - nome com extensao)
                var caminho = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/", folder, file.FileName);

                //using para que a instrucao dentro dele seja encerrado assim que for executada
                using (var stream = new FileStream(caminho, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;

            }
            else 
            {
                novaEquipe.Imagem = "padrao.png";
            }//fim da logica do upload


            /*Adiciona objeto na tabela do banco de dados*/
            c.Add(novaEquipe);

            /*Salva alterações no banco de dados*/
            c.SaveChanges();

            // /*Atualiza a lista, !!! Testar sem essa atualização*/
            // ViewBag.Equipe = c.Equipe.ToList(); nao tem necessidade deixar porque o codigo esta atualizando pelo return localRedirect
        /*Retorna para o Local chamando a toda de Listar(método Index)*/
            
            return LocalRedirect("~/Equipe/Listar");
        }
    }

}