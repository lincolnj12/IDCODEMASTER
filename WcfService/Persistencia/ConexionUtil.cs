using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {

            return "Data Source=192.168.1.33;Initial Catalog=BD_PROYECTO;user=sa;password=123;";
            //return "Data Source=(local);Initial Catalog=BD_PROYECTO;Integrated Security=SSPI;";

        }
    }
}