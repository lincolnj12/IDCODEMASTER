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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservasService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ReservasService.svc or ReservasService.svc.cs at the Solution Explorer and start debugging.
    public class ReservasService : IReservasService
    {

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
        public int listarReserva(string cd_alumno)
        {
            return ReservaMatriculaDAO.existeReserva(cd_alumno).Count();
        }

        public ReservaMatricula cancelarReserva(string cd_alumno)
        {
            List<ReservaMatricula> listaReserva = ReservaMatriculaDAO.existeReserva(cd_alumno).ToList();
            if (listaReserva.Count() > 0)
            {
                ReservaMatricula reservaACancelar = listaReserva[0];
                reservaACancelar.fg_estado = '0';
                return ReservaMatriculaDAO.Modificar(reservaACancelar);
            }
            else
            {
                throw new FaultException<ReservaInexistenteException>(
                        new ReservaInexistenteException()
                        {
                            Codigo = "01",
                            Mensaje = "No existe reservas para este alumno"
                        },
                            new FaultReason("Validacion de Negocio"));
            }
        }
    }
}
