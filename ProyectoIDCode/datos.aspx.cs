using ProyectoIDCode.WSAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIDCode
{
    public partial class datos : System.Web.UI.Page
    {

        WSAlumnos.AlumnosServiceClient alumno = new WSAlumnos.AlumnosServiceClient();
        static string ds_identificador,cd_padre,ds_nombre,ds_apellido;
        static int cd_pago;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    string codigoA = Session["cod_alumno"].ToString();
                    Alumno alu = (Alumno)alumno.ConsultarAlumno(Int32.Parse(codigoA));
                    Session["ds_nombre"] = alu.ds_nombre;
                    Session["ds_apellido"] = alu.ds_apellido;
                    Session["cd_padre"] = alu.cd_padre;

                    nombre.Text = alu.ds_nombre;
                    apellido.Text = alu.ds_apellido;

                    direccion.Text = alu.ds_direccion;
                    distrito.Text = alu.ds_distrito;
                    telefono.Text = alu.ds_telefono;
                    celular.Text = alu.ds_celular;

                    ds_identificador = alu.ds_identificador_alumno;
                    cd_padre = alu.cd_padre;
                    ds_nombre = alu.ds_nombre;
                    ds_apellido = alu.ds_apellido;
                    cd_pago = alu.cd_pago;

                    Image2.ImageUrl = traer_imgalu();
                }
                catch (Exception)
                {

                    pnl_mensajeFinal.Visible = true;
                }
                
            }
        }

        protected void grabar_Click(object sender, EventArgs e)
        {
            Alumno alu = new Alumno();
            alu.cd_alumno = Int32.Parse(Session["cod_alumno"].ToString());

            alu.ds_identificador_alumno=ds_identificador ;
            alu.cd_padre = Session["cd_padre"].ToString();
            alu.ds_nombre = Session["ds_nombre"].ToString();
            alu.ds_apellido = Session["ds_apellido"].ToString();
            alu.cd_pago=cd_pago;


            alu.ds_direccion = direccion.Text;
            alu.ds_distrito = distrito.Text;
            alu.ds_telefono = telefono.Text;
            alu.ds_celular = celular.Text;


            alumno.actualizarAlumno(alu);
        }

        public string traer_imgalu()
        {
            return Image2.ImageUrl = "img/a" + Session["cod_alumno"] + ".jpg";

        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            //pnl_mensajeFinal.Visible = false;
        }

    }
}