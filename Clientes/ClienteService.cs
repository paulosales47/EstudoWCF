using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class ClienteService : IClienteService
    {
        private ClienteDAO _dao;

        public ClienteService()
        {
            _dao = new ClienteDAO();
        }
        public void AddCliente(ClienteEntidade clienteEntidade)
        {
            _dao.CadastraCliente(clienteEntidade);
        }

        public void AddClienteWeb(string nome, string cpf)
        {
            var entidade = new ClienteEntidade
            {
                Nome = nome
                ,
                CPF = cpf
            };

            _dao.CadastraCliente(entidade);
        }

        public ClienteEntidade GetCliente(string nome)
        {
            return _dao.BuscaCliente(nome);
        }

        public IList<ClienteEntidade> ListaClientes()
        {
            return ClienteDAO.clientes;
        }
    }
}
