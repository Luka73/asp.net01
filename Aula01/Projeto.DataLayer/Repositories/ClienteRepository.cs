using Projeto.DataLayer.Entities;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DataLayer.Repositories
{
    public class ClienteRepository : Conexao
    {
        public void Inserir(Cliente cliente)
        {
            string query = "insert into Cliente (Nome, Email, DataCadastro) values " +
                "(@Nome, @Email, @DataCadastro)";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", cliente.Nome);
            Command.Parameters.AddWithValue("@Email", cliente.Email);
            Command.Parameters.AddWithValue("@DataCadastro", cliente.DataCadastro);
            Command.ExecuteNonQuery();
        }
    }
}
