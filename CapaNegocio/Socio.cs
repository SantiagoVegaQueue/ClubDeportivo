using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Socio
    {

        protected int idSocio;
        protected string Nombre;
        protected string Apellido;
        protected string Sexo;
        protected int Dni;
        protected DateTime Fechanac;
        protected string Nacionalidad;
        protected string Estcivil;
        protected string Direccion;
        protected long Telefono;
        protected string Email;
        protected string Buscar;
        protected float Cuotabase;
        protected float Cuotafinal;

        public Socio(string nombre, string apellido, string sexo, int dni, DateTime fechanac, string nacionalidad, string estcivil, string direccion, long telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Dni = dni;
            Fechanac = fechanac;
            Nacionalidad = nacionalidad;
            Estcivil = estcivil;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        public Socio(int idSocio)
        {
            this.idSocio = idSocio;
        }
        
        public Socio()
        {

        }

        public Socio(int idSocio, string nombre, string apellido, string sexo, int dni, DateTime fechanac, string nacionalidad, string estcivil, string direccion, long telefono, string email)
        {
            this.idSocio = idSocio;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Dni = dni;
            Fechanac = fechanac;
            Nacionalidad = nacionalidad;
            Estcivil = estcivil;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }



        public DataTable ListarSocio()
        {
            Datos_Socio socio = new Datos_Socio();
            return socio.ListarSocio();
        }

        public DataTable BuscarSocio(string buscar)
        {
            Datos_Socio socio = new Datos_Socio();
            return socio.BuscarSocio(buscar);
        }

        public virtual void InsertarSocio()
        {
            Datos_Socio socio = new Datos_Socio();
            
            socio.InsertarSocio(Nombre, Apellido, Sexo, Dni, Fechanac, Nacionalidad, Estcivil, Direccion, Telefono, Email);
        }

        public void EditarSocio(int idSocio)
        { 
            Datos_Socio socio = new Datos_Socio();
            socio.EditarSocio(idSocio, Nombre, Apellido, Sexo, Dni, Fechanac, Nacionalidad, Estcivil, Direccion, Telefono, Email);
        }

        public void EliminarSocio(int idSocio)
        {
            Datos_Socio socio = new Datos_Socio();
            socio.EliminarSocio(idSocio);
        }
    }
}
