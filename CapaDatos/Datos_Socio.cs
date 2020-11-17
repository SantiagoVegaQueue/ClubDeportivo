using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datos_Socio
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarSocios()
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

        public DataTable BuscarSocio(Entidades_Socio Socio)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@BUSCAR", Socio.Buscar1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        public void InsertarSocio(Entidades_Socio Socio)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Socio.Nombre1);
            cmd.Parameters.AddWithValue("@APELLIDO", Socio.Apellido1);
            cmd.Parameters.AddWithValue("@SEXO", Socio.Sexo1);
            cmd.Parameters.AddWithValue("@DNI", Socio.Dni1);
            cmd.Parameters.AddWithValue("@FECHANAC", Socio.Fechanac1);
            cmd.Parameters.AddWithValue("@NACIONALIDAD", Socio.Nacionalidad1);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", Socio.Nacionalidad1);
            cmd.Parameters.AddWithValue("@DIRECCION", Socio.Direccion1);
            cmd.Parameters.AddWithValue("@TELEFONO", Socio.Telefono1);
            cmd.Parameters.AddWithValue("@EMAIL", Socio.Email1);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EditarSocio(Entidades_Socio Socio)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPROFESOR", Socio.IdSocio);
            cmd.Parameters.AddWithValue("@APELLIDO", Socio.Apellido1);
            cmd.Parameters.AddWithValue("@SEXO", Socio.Sexo1);
            cmd.Parameters.AddWithValue("@DNI", Socio.Dni1);
            cmd.Parameters.AddWithValue("@FECHANAC", Socio.Fechanac1);
            cmd.Parameters.AddWithValue("@NACIONALIDAD", Socio.Nacionalidad1);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", Socio.Nacionalidad1);
            cmd.Parameters.AddWithValue("@DIRECCION", Socio.Direccion1);
            cmd.Parameters.AddWithValue("@TELEFONO", Socio.Telefono1);
            cmd.Parameters.AddWithValue("@EMAIL", Socio.Email1);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EliminarSocio(Entidades_Socio Socio)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARSOCIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSOCIO", Socio.IdSocio);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
