using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dominio;
using System.Data.SqlClient;
namespace WcfService.Persistencia
{
    public class PagoPendienteDAO : BaseDAO<PagoPendiente, int>
    {
        public List<PagoPendiente> ListarTodos(string codAlumno)
        {
            List<PagoPendiente> listaPagosPendientes = new List<PagoPendiente>();

            string sql = "select cd_alumno, ds_pago, qt_monto, dt_fecha where cd_alimno=@cod";



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
                            PagoPendiente pagoPendiente = new PagoPendiente()
                            {

                                cd_alumno = (string)resultado["cd_alumno"],
                                ds_pago = (string)resultado["ds_pago"],
                                qt_monto = (double)resultado["qt_monto"],
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