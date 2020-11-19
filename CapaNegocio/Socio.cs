using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Socio
    {
        private int idSocio;
        private string Codigo;
        private string Nombre;
        private string Apellido;
        private string Sexo;
        private int Dni;
        private DateTime Fechanac;
        private string Nacionalidad;
        private string EstadoCivil;
        private string Direccion;
        private long Telefono;
        private string Email;
        private string Buscar;
        private double CuotaBase;
        private double CuotaFinal;

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public DateTime Fechanac1 { get => Fechanac; set => Fechanac = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public string EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public long Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
        public double CuotaBase1 { get => CuotaBase; set => CuotaBase = value; }
        public double CuotaFinal1 { get => CuotaFinal; set => CuotaFinal = value; }

        public virtual DataTable ListarSocio()
        {
            Datos_Socio socio = new Datos_Socio();
            return socio.ListarSocio();
        }

        public virtual DataTable BuscarSocio(string Buscar1)
        {
            Datos_Socio socio = new Datos_Socio();
            return socio.BuscarSocio(Buscar1);
        }

        public void InsertarSocio(string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Nacionalidad1, string EstadoCivil1, string Direccion1, long Telefono1, string Email1)
        {
            Datos_Socio socio = new Datos_Socio();
            socio.InsertarSocio(Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Nacionalidad1, EstadoCivil1, Direccion1, Telefono1, Email1);
        }

        public void EditarSocio(int IdSocio, string Nombre1, string Apellido1, string Sexo1, int Dni1, DateTime Fechanac1, string Nacionalidad1, string EstadoCivil1, string Direccion1, long Telefono1, string Email1)
        {
            Datos_Socio socio = new Datos_Socio();
            socio.EditarSocio(IdSocio, Nombre1, Apellido1, Sexo1, Dni1, Fechanac1, Nacionalidad1, EstadoCivil1, Direccion1, Telefono1, Email1);
        }

        public void EliminarSocio(int IdSocio)
        {
            Datos_Socio socio = new Datos_Socio();
            socio.EliminarSocio(IdSocio);
        }

        public virtual double CalcularPrecioFinal()
        {

            return CuotaFinal1 + (CuotaFinal1 * CuotaBase1);
        }
        
    }
}
