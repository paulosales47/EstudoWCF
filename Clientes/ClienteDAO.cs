using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class ClienteDAO
    {
        public static IList<ClienteEntidade> clientes = new List<ClienteEntidade>();

        public void CadastraCliente(ClienteEntidade clienteEntidade)
        {
            clientes.Add(clienteEntidade);
        }

        public ClienteEntidade BuscaCliente(string nome)
        {
            return clientes.FirstOrDefault(c => c.Nome.Equals(nome));
        }
    }
}
