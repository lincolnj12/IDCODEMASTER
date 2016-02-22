using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dominio;

namespace WcfService
{
    [ServiceContract]
    interface IObservacion
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Observaciones/{codAlumno}", ResponseFormat = WebMessageFormat.Json)]
        List<Observacion> ListarLibrosPendientesAlumno(string codAlumno);
    }
}
