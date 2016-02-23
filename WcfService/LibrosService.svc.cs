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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LibrosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LibrosService.svc or LibrosService.svc.cs at the Solution Explorer and start debugging.
    public class LibrosService : ILibrosService
    {
        private LibroPendienteDAO dao = new LibroPendienteDAO();

        public List<LibroPendiente> ListarLibrosPendientesAlumno(string codAlumno)
        {
            int cantidadLibrosPendientes = dao.ListarTodos(codAlumno).Count();

            if (DateTime.Now.Hour == 11)
            {
                throw new WebFaultException<string>(
                        "El horario de atención es de Lunes a Sábado hasta las 11 am", HttpStatusCode.Forbidden);
            } else
            if (cantidadLibrosPendientes <= 0)
            {
                throw new WebFaultException<string>(
                        "El alumno no registra Libros Pendientes", HttpStatusCode.InternalServerError);
            }

            return dao.ListarTodos(codAlumno);
        }


        
    }
}
