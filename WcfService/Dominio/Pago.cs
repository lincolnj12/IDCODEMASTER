using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{

     [DataContract]
    public class Pago
    {
         [DataMember]
         public int cd_pago { get; set; }

         [DataMember]
         public string cd_alumno { get; set; }

         [DataMember]
        public string ds_pago { get; set; }

         [DataMember]
         public string ds_estado { get; set; }


         [DataMember]
        public double qt_monto { get; set; }
         [DataMember]
        public DateTime dt_fecha { get; set; }
    }
}