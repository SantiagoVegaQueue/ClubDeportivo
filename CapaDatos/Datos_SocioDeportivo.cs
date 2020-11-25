using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace CapaDatos
{
    public class Datos_SocioDeportivo
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        #region Listar
        public DataTable ListarSocioDeportivo()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARSOCIODEPORTIVO", conexion);
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
        public DataTable BuscarSocioDeportivo(string buscar)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARSOCIODEPORTIVO", conexion);
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
        public void InsertarSocioDeportivo(int idSocio, string inscripcion)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARSOCIODEPORTIVO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIO", idSocio);
            cmd.Parameters.AddWithValue("@INSCRIPCION", inscripcion);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        #endregion

        #region Editar

        #endregion

        #region Eliminar
        public void EliminarSocioDeportivo(int idSocioDeportivo)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARSOCIODEPORTIVO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIODEPORTIVO", idSocioDeportivo);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
        #endregion

    }
}
