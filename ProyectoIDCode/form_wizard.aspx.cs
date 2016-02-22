using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoIDCode.WSMatricula;
using System.Net;
using System.IO;
using ProyectoIDCode.CLASES;
using System.Web.Script.Serialization;
using ProyectoIDCode.WSReservas;
using ProyectoIDCode.WSNotas;
using System.Xml;
using System.Xml.Serialization;


namespace ProyectoIDCode
{
    public partial class form_wizard : System.Web.UI.Page
    {

        static string cod_alumno;
        static int notas = 0, bibli = 0, deud = 0;
        static string flag;

        WSMatricula.ReservaServiceClient ws = new WSMatricula.ReservaServiceClient();
        WSReservas.ReservasServiceClient reserva = new WSReservas.ReservasServiceClient();
        WSLibrosPrestados.LibrosPerstadosServiceClient libros = new WSLibrosPrestados.LibrosPerstadosServiceClient();
        WSNotas.NotasServiceClient nota = new WSNotas.NotasServiceClient();
        WSPagos.PagosServiceClient pagos = new WSPagos.PagosServiceClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                notas = 0; bibli = 0; deud = 0;
                cod_alumno = Session["cod_alumno"].ToString();  //Request.QueryString["cod_alumno"].ToString();


                cargarmensaje(sender, e);
                btnfinish.Visible = false;
            }
        }

        public void cargarmensaje(object sender, EventArgs e)
        {

            btndevolucion.Enabled = false;
            btnestadoD.Enabled = false;
            //btnfinish.Enabled = false;
            btnsitacademica_Click(sender, e);
        }



        protected void btnfinish_Click(object sender, EventArgs e)
        {

            pnl_mensajeFinal.Visible = true;
            ProyectoIDCode.WSReservas.ReservaMatricula res = reserva.registarReserva(cod_alumno);

            if (res.fg_estado.Equals('0'))
            {
                lbltitulo1.Text = "";
                lbltitulo2.Text = "";
                lblmsj1.Text = res.cd_alumno.ToString();
                lblmsj2.Text = res.FechaReserva.ToString();
            }
            else
            {
                lbltitulo1.Text = "Pago a realizar :";
                lbltitulo2.Text = "Fecha de reserva :";
                lblmsj1.Text = res.Monto.ToString();
                lblmsj2.Text = res.FechaReserva.ToString();
            }
            flag = res.fg_estado.ToString();
        }


        protected void btcontinuar_Click(object sender, EventArgs e)
        {

            if (btndevolucion.Enabled.ToString().Equals("False"))
            {
                btndevolucion.Enabled = true;
                btndevolucion_Click(sender, e);
            }
            else if (btnestadoD.Enabled.ToString().Equals("False"))
            {
                btnestadoD.Enabled = true;
                btnestadoD_Click(sender, e);
            }
            
            

        }

        protected void btnsitacademica_Click(object sender, EventArgs e)
        {

            ProyectoIDCode.WSNotas.Respuesta resp = nota.ListarNotaAlumno(cod_alumno);
            lblmensaje.Text = resp.mensaje;
            notas = resp.flag;
            
            
        }

        protected void btndevolucion_Click(object sender, EventArgs e)
        {

            ProyectoIDCode.WSLibrosPrestados.Respuesta resp = libros.ListarLibrosPrestados(cod_alumno);
            lblmensaje.Text = resp.mensaje;
            bibli = resp.flag;
            des_biblio();
            
        }


        protected void btnestadoD_Click(object sender, EventArgs e)
        {

            try
            {
                ProyectoIDCode.WSPagos.Respuesta resp = pagos.ListarPagos(cod_alumno);
                lblmensaje.Text = resp.mensaje;
                deud = resp.flag;
                des_deudas();
                validar_fini();

            }
            catch (Exception ex)
            {


                AlumnoConsulta alumno = new AlumnoConsulta();
                alumno.codigo_alumno=cod_alumno;

                MQConexion conexionMQ = new MQConexion();
                conexionMQ.ConnectMQ("IB9QMGR", "MBK.SESION3.ENTRADA", "SYSTEM.DEF.SVRCONN");
                conexionMQ.WriteMsg(alumno.mensaje);

                XmlDocument xml = new XmlDocument();
                try
                {
                    xml.LoadXml(conexionMQ.ReadMsg());
                }
                catch (Exception bee)
                {
                    deud = 1;
                    lblmensaje.Text = "El Alumno no presenta ninguna deuda pendiente.";
                    des_deudas();
                    validar_fini();
                    return;
                }


                XmlSerializer serializer = new XmlSerializer(typeof(AlumnoConsultaRS));
                AlumnoConsultaRS response = new AlumnoConsultaRS();
                var nsmgr = new XmlNamespaceManager(xml.NameTable);
                nsmgr.AddNamespace("io", "http://www.example.org/Alumno/");
                XmlNodeList xnList = xml.SelectNodes("//io:AlumnoConsultaRS", nsmgr);
                string des_pago = "";
                foreach (XmlNode xn in xnList)
                {
                    des_pago = xn["des_pago"].InnerText;
                    string des_estado = xn["des_estado"].InnerText;
                    
                }

                if (des_pago == "")
                {
                    deud = 1;
                    lblmensaje.Text = "El Alumno no presenta ninguna deuda pendiente.";
                }
                else
                {
                    deud = 0;
                    lblmensaje.Text = "Usted tiene pagos pendientes por cancelar. Por favor, acérquese al área de secretaria.";
                }

                des_deudas();
                validar_fini();

            }
            
        }
        public void validar_fini()
        {
            if (notas == 1 && bibli == 1 && deud == 1)
            {
                btnfinish.Visible = true;
            }
            else
            {
                btnfinish.Visible = false;
            }
        }

        public void des_continuar()
        {
            if (notas == 1)
            {
                btcontinuar.Visible = true;
                btncontinuar();
            }
            else
            {
                btcontinuar.Visible = false;
            }
        }
        public void des_biblio()
        {
            if (bibli == 1)
            {
                btcontinuar.Visible = true;
                btncontinuar();
            }
            else
            {
                btcontinuar.Visible = false;
            }
        }
        public void des_deudas()
        {
            if (deud == 1)
            {
                btcontinuar.Visible = false;
                btncontinuar();
            }
            else
            {
                btcontinuar.Visible = false;
            }
        }
        public void btncontinuar()
        {
            if (btndevolucion.Enabled.ToString().Equals("True") && btnestadoD.Enabled.ToString().Equals("True"))
            {
                btcontinuar.Visible = false;
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (flag.Equals("0"))
            {
                pnl_mensajeFinal.Visible = false;
            }
            else
            {
                Response.Redirect("index.aspx");
            }

        }
    }
}