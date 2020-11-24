using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SocioDeportivo : Socio
    {
        private string inscripcion;

        #region Constructores
        public SocioDeportivo(string tipoPago, double precioBase, string inscripcion)
        {
            this.TipoPago1 = tipoPago;
            this.PrecioBase1 = precioBase;
            this.inscripcion = inscripcion;
        }

        public SocioDeportivo(string inscripcion)
        {
            this.inscripcion = inscripcion;
        }


        public SocioDeportivo()
        {

        }
        #endregion



        public override DataTable ListarSocio()
        {
            Datos_SocioDeportivo socio = new Datos_SocioDeportivo();
            return socio.ListarSocioDeportivo();
        }

        public void InsertarSocioDeportivo(int idSocio, string inscripcion)
        {
            Datos_SocioDeportivo socio = new Datos_SocioDeportivo();
            socio.InsertarSocioDeportivo(idSocio, inscripcion);
            
        }

        public override double Calcularpreciofinal()
        {
            base.calcularPrecioCuota();
            if(inscripcion == "Normal")
            {
                this.PrecioFinal1 = base.calcularPrecioCuota();
            }
            else if (inscripcion == "Becado/a")
            {
                this.PrecioFinal1 = this.PrecioFinal1 - (this.PrecioFinal1 * 0.30);
            }
            return this.PrecioFinal1;
        }



    }
}
