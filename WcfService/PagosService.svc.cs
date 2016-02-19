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
    public class PagosService : IPagosService
    {
        private PagoPendienteDAO dao = new PagoPendienteDAO();

        public List<PagoPendiente> ListarPagosPendientesAlumno(string codAlumno)
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