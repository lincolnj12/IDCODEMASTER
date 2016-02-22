using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using WcfService.Dominio;
using WcfService.Persistencia;
using System.Data;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlumnosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlumnosService.svc or AlumnosService.svc.cs at the Solution Explorer and start debugging.
    public class AlumnosService : IAlumnosService
    {
        private AlumnoDAO alumnoDAO = null;
        private AlumnoDAO AlumnoDAO
        {
            get
            {
                if (alumnoDAO == null)
                    alumnoDAO = new AlumnoDAO();
                return alumnoDAO;
            }
        }

        public Dominio.Alumno ConsultarAlumno(int cd_alumno)
        {
            return AlumnoDAO.Obtener(cd_alumno);
        }
        public Dominio.Alumno registarAlumno(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido)
        {
            //Padre padreExistente = PadreDAO.Obtener(cd_padre);
            //ObligacionPago obligacionPago = ObligacionPagoDAO.Obtener(cd_grado);
            Alumno alumnoAregistrar = new Alumno()
            {
                cd_padre = cd_padre,
                ds_nombre = ds_nombre,
                ds_apellido = ds_apellido,
                cd_pago = 1
            };
            return AlumnoDAO.Crear(alumnoAregistrar);
        }

        public List<Alumno> ListarAlumno(string id_padre)
        {
            return AlumnoDAO.ListarAlumno(id_padre).ToList();
        }
    }
}
