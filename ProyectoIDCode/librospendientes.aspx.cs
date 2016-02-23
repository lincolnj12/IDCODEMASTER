using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.IO;
using ProyectoIDCode.CLASES;
using System.Web.Script.Serialization;
using System.Data;

namespace ProyectoIDCode
{
    public partial class librospendientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            traer_imgalu();
//            StreamReader reader1=null;
//            List<LibroPendiente> librosObtenidos = new List<LibroPendiente>();
//            try
//            {
//HttpWebRequest req1 = (HttpWebRequest)WebRequest
//    .Create("http://localhost:4920/LibrosService.svc/LibrosPendientes/" + Session["cod_alumno"]);
//            req1.Method = "GET";
//            HttpWebResponse res1 = null;

//            res1 = (HttpWebResponse)req1.GetResponse();

//            reader1 = new StreamReader(res1.GetResponseStream());
//            string alumnosJson1 = reader1.ReadToEnd();
//            JavaScriptSerializer js1 = new JavaScriptSerializer();
//            librosObtenidos = js1.Deserialize<List<LibroPendiente>>(alumnosJson1);
//            }
//            catch (WebException be)
//            {
//                HttpStatusCode code = ((HttpWebResponse)be.Response).StatusCode;
//                string statusDescription = ((HttpWebResponse)be.Response).StatusDescription;
//                StreamReader reader = new StreamReader(be.Response.GetResponseStream());
//                string error = reader.ReadToEnd();
//                JavaScriptSerializer js = new JavaScriptSerializer();
//                string message = js.Deserialize<string>(error);

//                lblmensaje.Text =message;
//            }
            
            

//            DataTable tb = new DataTable();
//           tb.Columns.Add("Libro");
//            tb.Columns.Add("Autor");
//            tb.Columns.Add("Fecha de Préstamo");
//            tb.Columns.Add("Fecha de Devolución");

//            //Array alumno = librosObtenidos.ToList();

//            foreach (var item in librosObtenidos)
//            {
//                LibroPendiente x = (LibroPendiente)item;
//                DataRow r = tb.NewRow();
//                r["Libro"] = x.ds_libro;
//                r["Autor"] = x.ds_autor;                
//                r["Fecha de Préstamo"] = x.dt_fecha_prestamo;
//                r["Fecha de Devolución"] = x.dt_fecha_devolucion;
//                tb.Rows.Add(r);

//            }
//            datos.DataSource = tb;
//            datos.DataBind();


            StreamReader reader1 = null;
            List<LibroPendiente> librosObtenidos = new List<LibroPendiente>();
            try
            {
                HttpWebRequest req1 = (HttpWebRequest)WebRequest
                    .Create("http://localhost:4920/LibrosService.svc/LibrosPendientes/" + Session["cod_alumno"]);
                req1.Method = "GET";
                HttpWebResponse res1 = null;

                res1 = (HttpWebResponse)req1.GetResponse();

                reader1 = new StreamReader(res1.GetResponseStream());
                string alumnosJson1 = reader1.ReadToEnd();
                JavaScriptSerializer js1 = new JavaScriptSerializer();
                librosObtenidos = js1.Deserialize<List<LibroPendiente>>(alumnosJson1);
            }
            catch (WebException be)
            {
                HttpStatusCode code = ((HttpWebResponse)be.Response).StatusCode;
                string statusDescription = ((HttpWebResponse)be.Response).StatusDescription;
                StreamReader reader = new StreamReader(be.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string message = js.Deserialize<string>(error);

                lblmensaje.Text = message;
            }



            DataTable tb = new DataTable();
            tb.Columns.Add("Libro");
            tb.Columns.Add("Autor");
            tb.Columns.Add("Fecha de Préstamo");
            tb.Columns.Add("Fecha de Devolución");

            //Array alumno = librosObtenidos.ToList();

            foreach (var item in librosObtenidos)
            {
                LibroPendiente x = (LibroPendiente)item;
                DataRow r = tb.NewRow();
                r["Libro"] = x.ds_libro;
                r["Autor"] = x.ds_autor;
                r["Fecha de Préstamo"] = x.dt_fecha_prestamo;
                r["Fecha de Devolución"] = x.dt_fecha_devolucion;
                tb.Rows.Add(r);

            }
            datos.DataSource = tb;
            datos.DataBind();


        }



        public void  traer_imgalu()
        {
            Image2.ImageUrl="img/a" + Session["cod_alumno"] + ".jpg";
            
        }
    }
}