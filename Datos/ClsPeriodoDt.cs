using Entidad;


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsPeriodoDt
    {
        private const int TamañoPaginas = 20;
        private int PaginaCorriente = 1;
        private int TotalPaginas = 0;
        private int TotalFilas = 0;


        SqlConnection Cn;
        ClsConexionDt ObjCon = new ClsConexionDt();
        
        public DataTable ListaPeriodo()
        {
            Cn = ObjCon.GetConexion();
            SqlDataAdapter Da = new SqlDataAdapter("PMS.SP_Periodo_Index", Cn);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public void NuevoPeriodo(ClsPeriodoEn p)
        {
            Cn = ObjCon.GetConexion();
            Cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "PMS.SP_Periodo_Nuevo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Cn;

            cmd.Parameters.Add("@Periodo", SqlDbType.Int).Value = p.Periodo;
            cmd.Parameters.Add("@EstadoPeriodo", SqlDbType.Char).Value = p.EstadoPeriodo;
            cmd.Parameters.Add("@FechaInicioPeriodo", SqlDbType.DateTime).Value = p.FechaInicioPeriodo;
            //cmd.Parameters.Add("@FechaFinalPeriodo", SqlDbType.DateTime2).Value = p.FechaFinalPeriodo;

            //cmd.Parameters.Add("@FechaInicioContabilidad", SqlDbType.DateTime2).Value = p.FechaInicioContabilidad;
            //cmd.Parameters.Add("@FechaFinalContabilidad", SqlDbType.DateTime2).Value = p.FechaFinalContabilidad;
            //cmd.Parameters.Add("@FechaInicioVencimiento", SqlDbType.DateTime2).Value = p.FechaInicioVencimiento;
            //cmd.Parameters.Add("@FechaFinalVencimiento", SqlDbType.DateTime2).Value = p.FechaFinalVencimiento;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }


        }
        public DataSet ObtenerDatosPaginados(int pageNumber, int pageSize, out int totalRecords)
        {
            Cn = ObjCon.GetConexion();
            DataSet ds = new DataSet();
            totalRecords = 0;

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{ 
                using (SqlCommand cmd = new SqlCommand("PMS.SP_Paginado_Periodo", Cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        totalRecords = Convert.ToInt32(ds.Tables[1].Rows[0]["TotalRecords"]);
                    }
                }
            //}

            return ds;
        }

    }
}
