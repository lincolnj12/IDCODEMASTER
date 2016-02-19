using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using WcfService.Persistencia;
using System.Net;

namespace WcfService
{
    [ServiceContract]
    public interface IPagosService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "PagosPendientes/{codAlumno}", ResponseFormat = WebMessageFormat.Json)]
        List<PagoPendiente> ListarPagosPendientesAlumno(string codAlumno);
    }
}
