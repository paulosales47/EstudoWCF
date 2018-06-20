using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        ClienteEntidade GetCliente(string nome);

        [OperationContract]
        void AddCliente(ClienteEntidade clienteEntidade);

        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addCliente/{nome}&{cpf}")]
        void AddClienteWeb(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate ="listaClientes/")]
        IList<ClienteEntidade> ListaClientes();
    }
}
