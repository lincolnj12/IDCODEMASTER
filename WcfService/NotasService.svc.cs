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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NotasService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NotasService.svc or NotasService.svc.cs at the Solution Explorer and start debugging.
    public class NotasService : INotasService
    {
        private NotaDAO notaDAO = null;
        private NotaDAO NotaDAO
        {
            get
            {
                if (notaDAO == null)
                    notaDAO = new NotaDAO();
                return notaDAO;
            }
        }

        public Respuesta ListarNotaAlumno(string cd_alumno)
        {

            Respuesta resp;
            if (NotaDAO.ListarNotasDesaprobadas(cd_alumno).ToList().Count() > 0)
            {
                resp = new Respuesta()
                {
                    mensaje = "Usted no cumple con el requisito de Notas aprobadas. Por favor, acérquese al área de secretaria.",
                    flag = 0
                };

                return resp;

            }
            else
            {
                resp = new Respuesta()
                {
                    mensaje = "El Alumno no debe ninguna materia académica.",
                    flag = 1
                };

                return resp;
            }
        }
    }
}
