using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using WcfService.Persistencia;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagosServicesRest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PagosServicesRest.svc or PagosServicesRest.svc.cs at the Solution Explorer and start debugging.
    public class PagosServicesRest : IPagosServicesRest
    {
        private PagoDAO dao = new PagoDAO();

        public List<Pago> ListarPagosPendientesAlumno(string codAlumno)
        {
            int cantidadPagosPendientes = dao.ListarTodos(codAlumno).Count();


            if (cantidadPagosPendientes <= 0)
            {
                throw new WebFaultException<string>(
                        "El alumno no tiene deuda pendiente.", HttpStatusCode.InternalServerError);
            }

            return dao.ListarTodos(codAlumno);
        }
    }
}
