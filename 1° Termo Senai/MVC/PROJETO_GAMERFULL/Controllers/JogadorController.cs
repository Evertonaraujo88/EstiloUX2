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
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();


        [Route ("Listar")]//http://localhost:/Jogador/Listar
        public IActionResult Index()
        {
            ViewBag.Jogador= c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

        [Route ("Cadastrar")]//http://localhost:/Jogador/Cadastrar

        public IActionResult Cadastrar (IFormCollection form)
        {
            //instanciando objeto Jogador
            Jogador novoJogador = new Jogador();

            //adicionando no Objeto o que cada item do formulario (index jogador) deve ser salvo de cada campo
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            //acessando context(c), classe Jogador  e adcionando as informacoes do novoJogador
            c.Jogador.Add(novoJogador);

            //Salvando
            c.SaveChanges();

            //apos feito tudo..retornar para pagina Jogador/Listar
            return LocalRedirect("~/Jogador/Listar");

        }

        [Route ("Excluir")]
        public IActionResult Excluir (int id)
        {
                Jogador jogadorBuscado = c.Jogador.First(j => j.IdJogador == id);

                c.Remove(jogadorBuscado);

                c.SaveChanges();

                return LocalRedirect("~/Jogador/Listar");
        }

        [Route ("Editar/{id}")]

        public IActionResult Editar(int id)
        {
            Jogador jogador = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Jogador = jogador;

            ViewBag.Equipe = c.Equipe.ToList();//disponibiliza a lista de equipes cadastradas

            return View("Edit");//leva para a tela de edição de jogador
        }

       [Route ("Atualizar")]
        public IActionResult Atualizar (IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());

            novoJogador.Nome = form["Nome"].ToString();

            novoJogador.Email = form["Email"].ToString();

            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());


            Jogador jogadorBuscado = c.Jogador.First(j => j.IdJogador == novoJogador.IdJogador);
            
            // atribuindo o nome do novo jogador atualizado no lugar dos dados antigos
            jogadorBuscado.Nome = novoJogador.Nome;
            jogadorBuscado.Email= novoJogador.Email;
            jogadorBuscado.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(jogadorBuscado);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        
    }
}