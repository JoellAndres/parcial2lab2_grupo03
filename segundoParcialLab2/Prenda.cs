using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoParcialLab2
{
    abstract class Prenda
    {
        protected double precio;
        protected bool premium;

        protected Prenda(double precio, bool premium)
        {
            this.precio = precio;
            this.premium = premium;
        }

        public virtual double calcularPrecio(int cantidad)
        {
            double precioFinal;

            precioFinal = cantidad * this.precio;

            if (this.premium == true)
                precioFinal += (precioFinal * 0.30);

            return precioFinal;
        }
    }
}
