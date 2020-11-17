using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Entidades_Deporte
    {
        private int idDeporte;
        private string Codigo;
        private string Nombre;
        private string Dias;
        private string Horarios;
        private int idProfesor;
        private string Buscar;
        private Entidades_Profesor entProf = new Entidades_Profesor();

        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Dias1 { get => Dias; set => Dias = value; }
        public string Horarios1 { get => Horarios; set => Horarios = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Buscar1 { get => Buscar; set => Buscar = value; }
        public Entidades_Profesor EntProf { get => entProf; set => entProf = value; }
    }
}
