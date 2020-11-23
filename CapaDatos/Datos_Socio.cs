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
    public class Datos_Socio
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarSocio()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }

        public DataTable BuscarSocio(string buscar)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        public void InsertarSocio(string nombre, string apellido, string sexo, int dni, DateTime fechanac, string nacionalidad, string estadocivil, string direccion, long telefono, string email, string tipoPago)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", apellido);
            cmd.Parameters.AddWithValue("@SEXO", sexo);
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@FECHANAC", fechanac);
            cmd.Parameters.AddWithValue("@NACIONALIDAD", nacionalidad);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", estadocivil);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@TIPOPAGO", tipoPago);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EditarSocio(int idSocio, string nombre, string apellido, string sexo, int dni, DateTime fechanac, string nacionalidad, string estadocivil, string direccion, long telefono, string email, string tipoPago)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIO", idSocio);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", apellido);
            cmd.Parameters.AddWithValue("@SEXO", sexo);
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@FECHANAC", fechanac);
            cmd.Parameters.AddWithValue("@NACIONALIDAD", nacionalidad);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", estadocivil);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@TIPOPAGO", tipoPago);
            
            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EliminarSocio(int idSocio)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIO", idSocio);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
