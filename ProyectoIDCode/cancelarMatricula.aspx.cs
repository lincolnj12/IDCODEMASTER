using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIDCode
{
    public partial class cancelarMatricula : System.Web.UI.Page
    {
        static string cod_alumno;

        WSReservas.ReservasServiceClient reserva = new WSReservas.ReservasServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cod_alumno = Session["cod_alumno"].ToString();
            }
        }

        protected void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoIDCode.WSReservas.ReservaMatricula res = reserva.cancelarReserva(cod_alumno);
            }
            catch
            {

            }
        }
    }
}