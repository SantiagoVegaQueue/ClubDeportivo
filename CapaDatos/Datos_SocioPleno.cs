using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Datos_SocioPleno
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarSocioPleno()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARSOCIOPLENO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }

        public void InsertarSocioPleno(int idSocio, string tipoPlan)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARSOCIOPLENO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIO", idSocio);
            cmd.Parameters.AddWithValue("@TIPOPLAN", tipoPlan);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }
    }
}
