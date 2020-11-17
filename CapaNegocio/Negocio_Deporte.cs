using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Negocio_Deporte
    {

        private int idDeporte;
        private string Codigo;
        private string Nombre;
        private string Dias;
        private string Horarios;
        private int idProfesor;
        private string Buscar;
        Negocio_Profesor profe = new Negocio_Profesor();

        Datos_Deporte datos_Deporte = new Datos_Deporte();

        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Dias1 { get => Dias; set => Dias = value; }
        public string Horarios1 { get => Horarios; set => Horarios = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
        public Negocio_Profesor Profe { get => profe; set => profe = value; }

        public DataTable ListarDeporte()
        {
            return datos_Deporte.ListarDeporte();
        }

        public DataTable BuscarDeporte(string Buscar)
        {
            entidades_Deporte.Buscar1 = Buscar;
            return datos_Deporte.BuscarDeporte(entidades_Deporte);
        }

        public void InsertarDeporte(Entidades_Deporte Deporte)
        {
            datos_Deporte.InsertarDeporte(Deporte);
        }

        public void EditarDeporte(Entidades_Deporte Deporte)
        {
            datos_Deporte.EditarDeporte(Deporte);
        }

        public void EliminarDeporte(Entidades_Deporte Deporte)
        {
            datos_Deporte.EliminarDeporte(Deporte);
        }
    }
}
