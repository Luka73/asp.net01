using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DataLayer.Entities;
using Projeto.DataLayer.Repositories;

namespace Projeto.BusinessLayer.Business
{
    public class ClienteBusiness
    {
        public void CadastrarCliente(Cliente cliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.AbrirConexao();
            repository.Inserir(cliente);
            repository.FecharConexao();
        }
    }
}
