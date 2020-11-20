using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class SocioDeportivo : Socio
    {
        private int cantDeportes;

        public int CantDeportes { get => cantDeportes; set => cantDeportes = value; }

        public override double CalcularPrecioCuota()
        {
            base.CalcularPrecioCuota();

            if (CantDeportes>=3)
            {
                this.PrecioFinal1 = PrecioFinal1 - (PrecioFinal1 * 0.10);
            }

            return this.PrecioFinal1;
        }




    }
}
