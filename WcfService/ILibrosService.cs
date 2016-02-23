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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILibrosService" in both code and config file together.
    [ServiceContract]
    public interface ILibrosService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "LibrosPendientes/{codAlumno}", ResponseFormat = WebMessageFormat.Json)]
        List<LibroPendiente> ListarLibrosPendientesAlumno(string codAlumno);

        
    }
}
