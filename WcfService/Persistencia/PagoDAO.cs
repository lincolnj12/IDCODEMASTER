using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Dominio;

namespace WcfService.Persistencia
{
    public class PagoDAO:BaseDAO<Pago,int>
    {
	
	 public List<Pago> ListarTodos(string codAlumno)
        {
            List<Pago> listaPagosPendientes = new List<Pago>();

            string sql = "select cd_alumno, ds_pago, qt_monto, dt_fecha from tb_pago where cd_alumno=@cod";



            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codAlumno));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            Pago pagoPendiente = new Pago()
                            {

                                cd_alumno = (string)resultado["cd_alumno"],
                                ds_pago = (string)resultado["ds_pago"],
                                qt_monto = (decimal)resultado["qt_monto"],
                                dt_fecha = (DateTime)resultado["dt_fecha"],


                            };
                            listaPagosPendientes.Add(pagoPendiente);
                        }
                    }
                }
            }
            return listaPagosPendientes;
        }
		
		
    }
}