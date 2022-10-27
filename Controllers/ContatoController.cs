using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_MVC_Example.Context;
namespace ASP.NET_MVC_Example.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext context;

        public ContatoController(AgendaContext context)
        {
            this.context = context;
        }
        public ActionResult Index()
        {
            var contatos = this.context.Contatos.ToList();
            return View(contatos);
        }

        public ActionResult Criar()
        {
            return View();
        }
    }
}