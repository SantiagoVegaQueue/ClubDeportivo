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
        Datos_Profesor datos_Profesor = new Datos_Profesor();
        Entidades_Profesor entidades_Profesor = new Entidades_Profesor();

        public DataTable ListarProfesor()
        {
            return datos_Profesor.ListarProfesor();
        }

        public DataTable BuscarProfesor(string Buscar)
        {
            entidades_Profesor.Buscar1 = Buscar;
            return datos_Profesor.BuscarProfesor(entidades_Profesor);
        }

        public void InsertarProfesor(Entidades_Profesor Profesor)
        {
            datos_Profesor.InsertarProfesor(Profesor);
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
