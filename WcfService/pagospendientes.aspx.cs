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
    public partial class pagos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader1=null;
            List<PagoPendiente> pagosRealizados = new List<PagoPendiente>();
            try
            {
HttpWebRequest req1 = (HttpWebRequest)WebRequest
    .Create("http://localhost:4920/PagosService.svc/PagosPendientes/" + Session["cod_alumno"]);
            req1.Method = "GET";
            HttpWebResponse res1 = null;

            res1 = (HttpWebResponse)req1.GetResponse();

            reader1 = new StreamReader(res1.GetResponseStream());
            string alumnosJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            pagosRealizados = js1.Deserialize<List<PagoPendiente>>(alumnosJson1);
            }
            catch (WebException be)
            {
                HttpStatusCode code = ((HttpWebResponse)be.Response).StatusCode;
                string statusDescription = ((HttpWebResponse)be.Response).StatusDescription;
                StreamReader reader = new StreamReader(be.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string message = js.Deserialize<string>(error);

                lblmensaje.Text =message;
            }
            
            

            DataTable tb = new DataTable();
            tb.Columns.Add("Codigo");
            tb.Columns.Add("Descripcion");
            tb.Columns.Add("Monto");
            tb.Columns.Add("Fecha");

           
            foreach (var item in pagosRealizados)
            {
                PagoPendiente pago = (PagoPendiente)item;
                DataRow r = tb.NewRow();
                r["Codigo"] = pago.cd_alumno;
                r["Descripcion"] = pago.ds_pago;
                r["Monto"] = pago.qt_monto;
                r["Fecha"] = pago.dt_fecha;
                tb.Rows.Add(r);

            }
            datos.DataSource = tb;
            datos.DataBind();

        }

        protected void datos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}