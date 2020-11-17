using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Negocio_Socio
    {
        private int idSocio;
        private string Codigo;
        private string Nombre;
        private string Apellido;
        private string Sexo;
        private int Dni;
        private DateTime Fechanac;
        private string Nacionalidad;
        private string Estcivil;
        private string Direccion;
        private long Telefono;
        private string Email;
        private string Buscar;

        Datos_Socio Socio = new Datos_Socio();

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public DateTime Fechanac1 { get => Fechanac; set => Fechanac = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public string Estcivil1 { get => Estcivil; set => Estcivil = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }

        public DataTable ListarSocio()
        {
            return Socio.ListarSocio();
        }

        public DataTable BuscarSocio(string Buscar1)
        {
            return Socio.BuscarSocio(Buscar1);
        }

        public void InsertarSocio(string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Nacionalidad1, string Estcivil1, string Direccion1, long Telefono1, string Email1)
        {
            Socio.InsertarSocio(Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Nacionalidad1, Estcivil1, Direccion1, Telefono1, Email1);
        }

        public void EditarSocio(int IdSocio, string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Nacionalidad1, string Estcivil1, string Direccion1, long Telefono1, string Email1)
        {
            Socio.EditarSocio(IdSocio, Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Nacionalidad1, Estcivil1, Direccion1, Telefono1, Email1);
        }

        public void EliminarSocio(int IdSocio)
        {
            Socio.EliminarSocio(IdSocio);
        }
    }
}
