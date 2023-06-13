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
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [TempData]
        public string Message{get; set;}

        Context c = new Context();
        [Route ("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName =  HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route ("Logar")]

        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = c.Jogador.FirstOrDefault(j => j.Email == email & j.Senha == senha)!;


            //aqui precisamos implementar a sessao
           if (jogadorBuscado != null)
           {
                //metodo setstring para setar uma string e o valor dela
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome);
                return LocalRedirect("~/");
           }
            Message = "Dados inválidos!";
            return LocalRedirect("~/Login/Login");
            
        }

        [Route ("Logout")]

        public IActionResult Logout()
        {
            //encerrando a sessao de login
            HttpContext.Session.Remove("UserName");

            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}