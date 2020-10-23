using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoParcialLab2
{
    class Camisa : Prenda
    {
        private bool mangaCorta;

        public Camisa(bool mangaCorta, double precio, bool premium) : base(precio, premium)
        {
            this.mangaCorta = mangaCorta;
        }

        public override double calcularPrecio(int cantidad)
        {
            double precioFinal;
           
            precioFinal = base.calcularPrecio(cantidad);

            if (this.mangaCorta == true)
                precioFinal *= 0.90;

            return precioFinal;
        }
    }
}
