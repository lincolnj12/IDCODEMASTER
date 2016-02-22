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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlumnosService" in both code and config file together.
    [ServiceContract]
    public interface IAlumnosService
    {
        [OperationContract]
        Alumno ConsultarAlumno(int cd_alumno);

        [OperationContract]
        Alumno registarAlumno(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido);

        [OperationContract]
        List<Alumno> ListarAlumno(string id_padre);

    }
}
