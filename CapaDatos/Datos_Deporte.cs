using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CapaDatos
{
    public class Datos_Deporte
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        #region Listar
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

        #endregion

        #region Buscar
        public DataTable BuscarDeporte(string buscar)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        #endregion

        #region Insertar
        public void InsertarDeporte(string nombre, string dias, string horarios, int idProf)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DIAS", dias);
            cmd.Parameters.AddWithValue("@HORARIOS", horarios);
            cmd.Parameters.AddWithValue("@IDPROFESOR", idProf);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        #endregion

        #region Editar
        public void EditarDeporte(int idDepo, string nombre, string dias, string horarios, int idProf)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDEPORTE", idDepo);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DIAS", dias);
            cmd.Parameters.AddWithValue("@HORARIOS", horarios);
            cmd.Parameters.AddWithValue("@IDPROFESOR", idProf);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        #endregion

        #region Eliminar
        public void EliminarDeporte(int idDepo)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARDEPORTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDEPORTE", idDepo);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        #endregion

    }
}
