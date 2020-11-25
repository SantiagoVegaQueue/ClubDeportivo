using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class Profesor
    {
        private int idProfesor;
        private string Codigo;
        private string Nombre;
        private string Apellido;
        private string Sexo;
        private int Dni;
        private DateTime Fechanac;
        private string Direccion;
        private long Telefono;
        private string Email;
        private string Buscar;

        public Profesor(int idProfesor, string codigo, string nombre, string apellido, string sexo, int dni, DateTime fechanac, string direccion, long telefono, string email, string buscar)
        {
            this.idProfesor = idProfesor;
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Dni = dni;
            Fechanac = fechanac;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Buscar = buscar;
        }

        public Profesor()
        {

        }

        #region Getters and Setters
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public DateTime Fechanac1 { get => Fechanac; set => Fechanac = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }

        #endregion

        #region Listar
        public DataTable ListarProfesor()
        {
            Datos_Profesor profesor = new Datos_Profesor();
            return profesor.ListarProfesor();
        }

        #endregion

        #region Buscar
        public DataTable BuscarProfesor(string Buscar1)
        {
            Datos_Profesor profesor = new Datos_Profesor();
            return profesor.BuscarProfesor(Buscar1);
        }

        #endregion

        #region Insertar
        public void InsertarProfesor(string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Direccion1, long Telefono1, string Email1)
        {
            Datos_Profesor profesor = new Datos_Profesor();
            profesor.InsertarProfesor(Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Direccion1, Telefono1, Email1);
        }

        #endregion

        #region Editar
        public void EditarProfesor(int IdProfesor, string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Direccion1, long Telefono1, string Email1)
        {
            Datos_Profesor profesor = new Datos_Profesor();
            profesor.EditarProfesor(IdProfesor, Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Direccion1, Telefono1, Email1);
        }

        #endregion

        #region Eliminar
        public void EliminarProfesor(int IdProfesor)
        {
            Datos_Profesor profesor = new Datos_Profesor();
            profesor.EliminarProfesor(IdProfesor);
        }

        #endregion

    }
}
