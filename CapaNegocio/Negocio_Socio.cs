using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class Negocio_Socio
    {
        Datos_Socio datos_Socio = new Datos_Socio();
        Entidades_Socio entidades_Socio = new Entidades_Socio();

        public DataTable ListarSocio()
        {
            return datos_Socio.ListarSocios();
        }

        public DataTable BuscarSocio(string Buscar)
        {
            entidades_Socio.Buscar1 = Buscar;
            return datos_Socio.BuscarSocio(entidades_Socio);
        }

        public void InsertarSocio(Entidades_Socio Socio)
        {
            datos_Socio.InsertarSocio(Socio);
        }

        public void EditarSocio(Entidades_Socio Socio)
        {
            datos_Socio.EditarSocio(Socio);
        }

        public void ElimnarSocio(Entidades_Socio Socio)
        {
            datos_Socio.EliminarSocio(Socio);
        }
    }
}
