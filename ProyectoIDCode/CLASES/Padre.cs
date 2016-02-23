using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    public class Padre
    {
        public int cd_padre { get; set; }

        public string ds_nombre { get; set; }
        public string ds_apellido { get; set; }
    }
}