using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WcfService.Dominio;
using WcfService.Persistencia;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LibrosPerstadosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LibrosPerstadosService.svc or LibrosPerstadosService.svc.cs at the Solution Explorer and start debugging.
    public class LibrosPerstadosService : ILibrosPerstadosService
    {
        //Raul paucar
        private LibroPendienteDAO libroPendienteDAO = null;
        private LibroPendienteDAO LibroPendienteDAO
        {
            get
            {
                if (libroPendienteDAO == null)
                    libroPendienteDAO = new LibroPendienteDAO();
                return libroPendienteDAO;
            }
        }

        public Respuesta ListarLibrosPrestados(string codigo)
        {
            Respuesta resp;
            if (LibroPendienteDAO.ListarLibrosPrestados(codigo).ToList().Count() > 0)
            {
                resp = new Respuesta()
                {
                    mensaje = "Usted cuenta con libros pendientes por devolver. Por favor, acérquese a la biblioteca.",
                    flag = 0
                };

                return resp;

            }
            else
            {
                resp = new Respuesta()
                {
                    mensaje = "El Alumno no tiene devoluciones pendientes.",
                    flag = 1
                };
                return resp;
            }


        }

        //Raul paucar
    }
}
