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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INotasService" in both code and config file together.
    [ServiceContract]
    public interface INotasService
    {
        [OperationContract]
        Respuesta ListarNotaAlumno(string cd_alumno);
    }
}
