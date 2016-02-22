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
    public class ObservacionService : IObservacion
    {
        private ObservacionDAO observacionDAO = null;
        private ObservacionDAO ObservacionDAO
        {
            get
            {
                if (observacionDAO == null)
                    observacionDAO = new ObservacionDAO();
                return observacionDAO;
            }
        }


        public List<Observacion> ListarLibrosPendientesAlumno(string codAlumno)
        {
            if(ObservacionDAO.ListarObservaciones(codAlumno).Count==0){
                throw new WebFaultException<string>(
                        "El alumno no registra observaciones", HttpStatusCode.InternalServerError);
            }

            return ObservacionDAO.ListarObservaciones(codAlumno).ToList();
        }
    }
}
