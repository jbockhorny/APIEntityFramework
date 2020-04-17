using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIEntityFramework.Models;

namespace APIEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
            var db = new DbContexto();
            db.Fornecedores.Add(
                new Fornecedor() { CNPJ = "132202020/0000", Nome = "Febrasis" }
            );
            db.SaveChanges();
            */
            var retorno = new Fornecedor() { CNPJ = "132202020/0000", Nome = "Febrasis" }.Salvar();

            if (retorno)
            {
                Console.WriteLine("deu certo");
            }
            else
            {
                Console.WriteLine("deu errado");
            }


            //new Cliente() { Nome = "Bruninha", Endereco = "Rua 123", Telefone = "11292828383" }.Salvar();
            //var clientes = Cliente.Lista();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
