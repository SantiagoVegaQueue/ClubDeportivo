using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Negocio_Profesor
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

        Datos_Profesor datos_Profesor = new Datos_Profesor();
        

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

        public DataTable ListarProfesor()
        {
            return datos_Profesor.ListarProfesor();
        }

        public DataTable BuscarProfesor(string Buscar)
        {
            entidades_Profesor.Buscar1 = Buscar;
            return datos_Profesor.BuscarProfesor(entidades_Profesor);
        }

        public void InsertarProfesor(string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Direccion1, long Telefono1, string Email1)
        {
            datos_Profesor.InsertarProfesor(Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Direccion1, Telefono1, Email1);
        }

        public void EditarProfesor(Entidades_Profesor Profesor)
        {
            datos_Profesor.EditarProfesor(Profesor);
        }

        public void EliminarProfesor(Entidades_Profesor Profesor)
        {
            datos_Profesor.EliminarProfesor(Profesor);
        }
    }
}
