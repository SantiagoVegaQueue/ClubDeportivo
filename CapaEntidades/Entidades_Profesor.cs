using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class Entidades_Profesor
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

        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public DateTime Fechanac1 { get => Fechanac; set => Fechanac = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
    }
}
