using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.PresentationLayer.Models;

namespace Projeto.PresentationLayer.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CadastarCliente(ClienteCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {

            }

            return View("Cadastro");
        }
    }
}