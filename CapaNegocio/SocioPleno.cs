using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SocioPleno : Socio
    {
        private string tipoPlan;

        public string TipoPlan { get => tipoPlan; set => tipoPlan = value; }

        #region Constructores
        public SocioPleno(string tipoPago, double precioBase, string tipoPlan)
        {
            this.TipoPago1 = tipoPago;
            this.PrecioBase1 = precioBase;
            this.tipoPlan = tipoPlan;
        }

        public SocioPleno(string tipoPlan)
        {
            this.tipoPlan = tipoPlan;
        }

        public SocioPleno()
        {

        }
        #endregion

        public override DataTable ListarSocio()
        {
            Datos_SocioPleno socio = new Datos_SocioPleno();
            return socio.ListarSocioPleno();
        }

        public void InsertarSocioPleno(int idSocio, string tipoPlan)
        {
            Datos_SocioPleno socio = new Datos_SocioPleno();
            socio.InsertarSocioPleno(idSocio, tipoPlan);
        }

    }
}
