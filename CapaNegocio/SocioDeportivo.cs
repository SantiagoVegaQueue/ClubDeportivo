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

        public string Inscripcion { get => inscripcion; set => inscripcion = value; }

        public SocioDeportivo(string inscripcion)
        {
            this.Inscripcion = inscripcion;
        }

        public SocioDeportivo(string tipoPago, double precioBase, string inscripcion)
        {
            this.TipoPago1 = tipoPago;
            this.PrecioBase1 = precioBase;
            this.Inscripcion = inscripcion;
        }

        public SocioDeportivo()
        {

        }

        public override DataTable ListarSocio()
        {
            Datos_SocioDeportivo socio = new Datos_SocioDeportivo();

            return socio.ListarSocioDeportivo();
        }

        public override double Calcularpreciofinal()
        {
            base.calcularPrecioCuota();
            if (Inscripcion == "Normal")
            {
                this.PrecioFinal1 = base.calcularPrecioCuota();
            }

            if (Inscripcion == "Becado/a")
            {
                this.PrecioFinal1 = this.PrecioFinal1 - (this.PrecioFinal1 * 0.30);
            }
            return this.PrecioFinal1;
        }

    }
}
