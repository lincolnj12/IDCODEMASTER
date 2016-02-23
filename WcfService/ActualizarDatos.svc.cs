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
    public class ActualizarDatos : IActualizarDatos
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

        public Alumno ConsultarAlumno(string cd_alumno)
        {
            return AlumnoDAO.Obtener(Int32.Parse(cd_alumno));
        }


        public Alumno actualizarAlumno(Alumno alu)
        {

           return AlumnoDAO.Modificar(alu);

        }


        //public List<Alumno> ListarAlumno(string id_padre)
        //{
        //    return AlumnoDAO.ListarAlumno(id_padre).ToList();
        //}

    }
}
