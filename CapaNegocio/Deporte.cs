using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class Deporte
    {

        private int idDeporte;
        private string Codigo;
        private string Nombre;
        private string Dias;
        private string Horarios;
        private int idProfesor;
        private string Buscar;
        Profesor profe = new Profesor();

        Datos_Deporte datos_Deporte = new Datos_Deporte();

        #region Getters and Setters
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Dias1 { get => Dias; set => Dias = value; }
        public string Horarios1 { get => Horarios; set => Horarios = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
        public Profesor Profe { get => profe; set => profe = value; }

        #endregion

        #region Listar
        public DataTable ListarDeporte()
        {
            return datos_Deporte.ListarDeporte();
        }

        #endregion

        #region Buscar
        public DataTable BuscarDeporte(string Buscar)
        {
            return datos_Deporte.BuscarDeporte(Buscar);
        }

        #endregion

        #region Insertar
        public void InsertarDeporte(string Nombre1, string Dias1, string Horarios1, int IdProfesor)
        {
            datos_Deporte.InsertarDeporte(Nombre1, Dias1, Horarios1, IdProfesor);
        }

        #endregion

        #region Editar
        public void EditarDeporte(int IdDeporte, string Nombre1, string Dias1, string Horarios1, int IdProfesor)
        {
            datos_Deporte.EditarDeporte(IdDeporte, Nombre1, Dias1, Horarios1, IdProfesor);
        }

        #endregion

        #region Eliminar
        public void EliminarDeporte(int IdDeporte)
        {
            datos_Deporte.EliminarDeporte(IdDeporte);
        }

        #endregion

    }
}
