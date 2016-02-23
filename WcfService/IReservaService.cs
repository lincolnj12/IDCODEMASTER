using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using System.Data;
using System.Web.Services;

namespace WcfService
{
    
    [ServiceContract]
    public interface IReservaService
    {
        //[OperationContract]
        //List<Nota> ConsultarSituacionAcademicaXalumno(int cd_alumno);

        [OperationContract]
        Alumno ConsultarAlumno(int cd_alumno);
        
        

        [OperationContract]
        Padre ConsultarPadre(int cd_padre);

        [OperationContract]
        Alumno registarAlumno(int cd_padre, string ds_nombre, int cd_grado, string ds_apellido);

        [OperationContract]
        List<Alumno> ListarAlumno(string id_padre);

        [OperationContract]
        Respuesta ListarNotaAlumno(string cd_alumno);


        [OperationContract]
        ReservaMatricula registarReserva(string cd_alumno);


        [OperationContract]
        List<Nota> VerificarSituacionAcademica(int cd_alumno);


        [OperationContract]
        Respuesta ListarLibrosPrestados(string codigo);


        [OperationContract]
        Respuesta ListarPagos(string cd_alumno);

        
    }


}
