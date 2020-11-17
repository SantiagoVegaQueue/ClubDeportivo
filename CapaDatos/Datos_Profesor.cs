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
    public class Datos_Profesor
    {
        /* Al usar el app.config creamos una cadena de conexión mediante la cual hicimos referencia dentro de la capa de datos. 
         * Incluimos system.configuration para aplicar la conexion a la base de datos*/

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        /*
         * Creamos la funcion datatable para listar los profesores anotados
         * Tambien creamos un objeto de tipo datatable para almacenar nuestra tabla
         * Agregamos una variable leerfilas de tipo Sqldatareader para poder analizar cada fila de la tabla
         * Especificamos el comando para acceder al procedimiento almacenado junto al parametro de conexion
         * Abrimos la conexion.
         * Ejecutamos el cmd para las filas
         * Cargamos en la tabla las filas leidas por el comando
         * Cerramos la conexion
         * Retornamos la tabla
         */
        public DataTable ListarProfesor()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARPROFESOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }

        public DataTable BuscarProfesor(Entidades_Profesor Profesor)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARPROFESOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@BUSCAR", Profesor.Buscar1);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        public void InsertarProfesor(string nombre, string apellido, string sexo, int dni, DateTime fechanac, string direccion, long telefono, string email)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARPROFESOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", apellido);
            cmd.Parameters.AddWithValue("@SEXO", sexo);
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@FECHANAC", fechanac);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("@EMAIL", email);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EditarProfesor(Entidades_Profesor Profesor)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPROFESOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPROFESOR", Profesor.IdProfesor);
            cmd.Parameters.AddWithValue("@NOMBRE", Profesor.Nombre1);
            cmd.Parameters.AddWithValue("@APELLIDO", Profesor.Apellido1);
            cmd.Parameters.AddWithValue("@SEXO", Profesor.Sexo1);
            cmd.Parameters.AddWithValue("@DNI", Profesor.Dni1);
            cmd.Parameters.AddWithValue("@FECHANAC", Profesor.Fechanac1);
            cmd.Parameters.AddWithValue("@DIRECCION", Profesor.Direccion1);
            cmd.Parameters.AddWithValue("@TELEFONO", Profesor.Telefono1);
            cmd.Parameters.AddWithValue("@EMAIL", Profesor.Email1);

            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public void EliminarProfesor(Entidades_Profesor Profesor)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARPROFESOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPROFESOR", Profesor.IdProfesor);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
