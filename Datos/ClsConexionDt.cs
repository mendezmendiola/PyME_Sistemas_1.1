using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsConexionDt
    {
        public SqlConnection GetConexion()
        {
            SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cn"].ConnectionString);
            return Cn;
        }
    }
}

