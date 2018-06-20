using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    [DataContract]
    public class ClienteEntidade
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string CPF { get; set; }

    }
}
