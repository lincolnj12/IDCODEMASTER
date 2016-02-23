
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dominio;

namespace ProyectoIDCode.CLASES
{
    public class Alumno
    {

        public int cd_alumno { get; set; }
        public Padre cd_padre { get; set; }
        public string ds_nombre { get; set; }
        public string ds_apellido { get; set; }


    }
}