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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PagosService.svc or PagosService.svc.cs at the Solution Explorer and start debugging.
    public class PagosService : IPagosService
    {
        private PagoDAO pagoDAO = null;
        private PagoDAO PagoDAO
        {
            get
            {
                if (pagoDAO == null)
                    pagoDAO = new PagoDAO();
                return pagoDAO;
            }
        }

        public Respuesta ListarPagos(string cd_alumno)
        {

            throw new FaultException<FaultException>(new FaultException("Problema del servicio"));

            Respuesta resp;
            if (PagoDAO.ListarPagos(cd_alumno).ToList().Count() > 0)
            {
                resp = new Respuesta()
                {
                    mensaje = "Usted tiene pagos pendientes por cancelar. Por favor, acérquese al área de secretaria.",
                    flag = 0
                };

                return resp;
            }
            else
            {
                resp = new Respuesta()
                {
                    mensaje = "El Alumno no presenta ninguna deuda pendiente.",
                    flag = 1
                };

                return resp;
            }


        }
     
		
    }
}
