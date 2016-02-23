using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIDCode.CLASES
{
    public class PagoPendiente
    {


        public string cd_alumno { get; set; }
        public string ds_pago { get; set; }
        public double qt_monto { get; set; }
        public DateTime dt_fecha { get; set; }
    }
}