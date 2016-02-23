using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WcfService.Dominio;
using WcfService.Persistencia;
using System.Data;
using System.ServiceModel.Web;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPagosService" in both code and config file together.
    [ServiceContract]
    public interface IPagosService
    {

        [OperationContract]
        Respuesta ListarPagos(string cd_alumno);

    }
}
