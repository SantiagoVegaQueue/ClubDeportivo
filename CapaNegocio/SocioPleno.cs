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

        #region Listar
        public DataTable ListarSocioPleno()
        {
            Datos_SocioPleno socio = new Datos_SocioPleno();
            return socio.ListarSocioPleno();
        }

        #endregion

        #region Buscar

        #endregion

        #region Insertar
        public void InsertarSocioPleno(int idSocio, string tipoPlan)
        {
            Datos_SocioPleno socio = new Datos_SocioPleno();
            socio.InsertarSocioPleno(idSocio, tipoPlan);
        }

        #endregion

        #region Editar

        #endregion

        #region Eliminar
        public override void EliminarSocio(int idSocioPleno)
        {
            Datos_SocioPleno socio = new Datos_SocioPleno();
            socio.EliminarSocioPleno(idSocioPleno);
        }
        #endregion

        #region Precio final
        public override double Calcularpreciofinal()
        {
            base.Calcularpreciofinal();

            if (TipoPlan == "Individual")
            {
                this.PrecioFinal1 = this.PrecioFinal1 + (this.PrecioFinal1 * 0.25);
            }

            if (TipoPlan == "Familiar")
            {
                this.PrecioFinal1 = this.PrecioFinal1 - (this.PrecioFinal1 * 0.10);
            }
            return this.PrecioFinal1;
        }

        #endregion


    }
}
