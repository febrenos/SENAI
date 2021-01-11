using System;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC
{
    public class ClienteController : Controller
    {
        private ClienteRepository clienterepository = new ClienteRepository();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form) //armazena informaçoes
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine(form ["email"]);
                System.Console.WriteLine(form ["senha"]);
                System.Console.WriteLine("========================");

                var usuario = form["email"];
                var senha = form["senha"];
                var cliente = clienterepository.ObterPor(usuario);

                return View("sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View ("Error");
            }
        }
    }
}