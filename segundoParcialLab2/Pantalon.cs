using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoParcialLab2
{
    class Pantalon : Prenda
    {
        private bool bermuda;

        public Pantalon(bool bermuda, double precio, bool premium) : base(precio, premium)
        {
            this.bermuda = bermuda;
        }

        public override double calcularPrecio(int cantidad)
        {
            double precioFinal;

            precioFinal = base.calcularPrecio(cantidad);

            if (this.bermuda == true)
                precioFinal *= 0.80;

            return precioFinal;
        }
    }
}
