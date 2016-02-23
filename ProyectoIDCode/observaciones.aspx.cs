using ProyectoIDCode.WSMatricula;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIDCode
{
    public partial class observaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                StreamReader reader1 = null;
                List<Observacion> observacionesObtenidas = new List<Observacion>();
                try
                {
                    HttpWebRequest req1 = (HttpWebRequest)WebRequest
                        .Create("http://localhost:4920/ObservacionService.svc/Observaciones/" + Session["cod_alumno"]);
                    req1.Method = "GET";
                    HttpWebResponse res1 = null;

                    res1 = (HttpWebResponse)req1.GetResponse();

                    reader1 = new StreamReader(res1.GetResponseStream());
                    string alumnosJson1 = reader1.ReadToEnd();
                    JavaScriptSerializer js1 = new JavaScriptSerializer();
                    observacionesObtenidas = js1.Deserialize<List<Observacion>>(alumnosJson1);


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
                tb.Columns.Add("Profesor");
                tb.Columns.Add("Comentario");


                foreach (var item in observacionesObtenidas)
                {
                    Observacion x = (Observacion)item;
                    DataRow r = tb.NewRow();
                    r["Profesor"] = x.ds_profesor;
                    r["Comentario"] = x.ds_comentario;
                    tb.Rows.Add(r);

                }
                listaobs.DataSource = tb;
                listaobs.DataBind();
            }
         
        }
    }
}
