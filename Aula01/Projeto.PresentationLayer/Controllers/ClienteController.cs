using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.PresentationLayer.Models;
using Projeto.BusinessLayer.Business;
using Projeto.DataLayer.Entities;

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
        public ActionResult CadastrarCliente(ClienteCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    cliente.DataCadastro = DateTime.Now;

                    ClienteBusiness business = new ClienteBusiness();
                    business.CadastrarCliente(cliente);

                    ViewBag.Mensagem = "Cliente cadastrado com sucesso.";
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View("Cadastro");
        }
    }
}