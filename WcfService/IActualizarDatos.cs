using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using WcfService.Dominio;
namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IActualizarDatos" in both code and config file together.
    [ServiceContract]
    public interface IActualizarDatos
    {
        [OperationContract]
        Alumno actualizarAlumno(Alumno alu);

        [OperationContract]
        Alumno ConsultarAlumno(string cd_alumno);
    }
}
