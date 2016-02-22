using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using WcfService.Dominio;
using WcfService.Persistencia;
using System.Data;

namespace WcfService
{
    public class ReservaService : IReservaService
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

        private PadreDAO padreDAO = null;
        private PadreDAO PadreDAO
        {
            get
            {
                if (padreDAO == null)
                    padreDAO = new PadreDAO();
                return padreDAO;
            }
        }

        private ObligacionPagoDAO obligacionPagoDAO = null;
        private ObligacionPagoDAO ObligacionPagoDAO
        {
            get
            {
                if (obligacionPagoDAO == null)
                    obligacionPagoDAO = new ObligacionPagoDAO();
                return obligacionPagoDAO;
            }
        }

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

        private ReservaMatriculaDAO reservaMatriculaDAO = null;
        private ReservaMatriculaDAO ReservaMatriculaDAO
        {
            get
            {
                if (reservaMatriculaDAO == null)
                    reservaMatriculaDAO = new ReservaMatriculaDAO();
                return reservaMatriculaDAO;
            }
        }

        public Dominio.Alumno ConsultarAlumno(int cd_alumno)
        {
            return AlumnoDAO.Obtener(cd_alumno);
        }
        
        

        public Dominio.Padre ConsultarPadre(int cd_padre)
        {
            return PadreDAO.Obtener(cd_padre);
        }

        public Dominio.Alumno registarAlumno(int cd_padre, string ds_nombre, int cd_grado, string ds_apellido)
        {
            Padre padreExistente = PadreDAO.Obtener(cd_padre);
            ObligacionPago obligacionPago = ObligacionPagoDAO.Obtener(cd_grado);
            Alumno alumnoAregistrar = new Alumno()
            {
                cd_padre = "",
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

        public int listarReserva(string cd_alumno)
        {
            return ReservaMatriculaDAO.existeReserva(cd_alumno).Count();
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

        // Johnny Rivera Barzola


        public ReservaMatricula registarReserva(string cd_alumno)
        {
            //Alumno alumno = AlumnoDAO.Obtener(cd_alumno);
            if (listarReserva(cd_alumno) == 0)
            {
                ReservaMatricula reserva = new ReservaMatricula()
                {
                    cd_alumno = cd_alumno.ToString(),
                    FechaReserva = DateTime.Now,
                    fg_estado = '1',
                    Monto = double.Parse("1000")//alumno.cd_grado.qt_monto.ToString())

                };
                return ReservaMatriculaDAO.Crear(reserva);
            }
            else
            {
                ReservaMatricula reserva = new ReservaMatricula()
                {
                    cd_alumno = "El Alumno ya tiene una reserva pendiente.",
                    FechaReserva = DateTime.Now,
                    fg_estado = '0',
                    Monto = 0.0 //  double.Parse("1000")//alumno.cd_grado.qt_monto.ToString())

                };
                return reserva;
            }


        }

        // Johnny Rivera Barzola

        public List<Nota> VerificarSituacionAcademica(int cd_alumno)
        {

            return NotaDAO.ListarNotasAlumno(cd_alumno).ToList();

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



        public Respuesta ListarPagos(string cd_alumno)
        {
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
