using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class Datos_Deporte
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarDeporte()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }

        public DataTable BuscarDeporte(Entidades_Deporte Deporte)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@BUSCAR", Deporte.Buscar1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        public void InsertarDeporte(Entidades_Deporte Deporte)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Deporte.Nombre1);
            cmd.Parameters.AddWithValue("@DIAS", Deporte.Dias1);
            cmd.Parameters.AddWithValue("@HORARIOS", Deporte.Horarios1);
            cmd.Parameters.AddWithValue("@IDPROFESOR", Deporte.IdProfesor);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EditarDeporte(Entidades_Deporte Deporte)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDEPORTE", Deporte.IdDeporte);
            cmd.Parameters.AddWithValue("@NOMBRE", Deporte.Nombre1);
            cmd.Parameters.AddWithValue("@DIAS", Deporte.Dias1);
            cmd.Parameters.AddWithValue("@HORARIOS", Deporte.Horarios1);
            cmd.Parameters.AddWithValue("@IDPROFESOR", Deporte.IdProfesor);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public void EliminarDeporte(Entidades_Deporte Deporte)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDEPORTE", Deporte.IdDeporte);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
