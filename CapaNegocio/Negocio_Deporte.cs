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
        Datos_Deporte datos_Deporte = new Datos_Deporte();
        Entidades_Deporte entidades_Deporte = new Entidades_Deporte();

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
