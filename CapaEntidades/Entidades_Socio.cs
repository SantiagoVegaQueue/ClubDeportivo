using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Entidades_Socio
    {
        private int idSocio;
        private string Codigo;
        private string Nombre;
        private string Apellido;
        private string Sexo;
        private long Dni;
        private DateTime Fechanac;
        private string Nacionalidad;
        private string Estcivil;
        private string Direccion;
        private long Telefono;
        private string Email;
        private string Buscar;

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public long Dni1 { get => Dni; set => Dni = value; }
        public DateTime Fechanac1 { get => Fechanac; set => Fechanac = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public string Estcivil1 { get => Estcivil; set => Estcivil = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
    }
}
