using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arco
    {
        Destino vY;
        string demora;
        double precio;


        public Arco(Destino vy, string demora, double precio)
        {
            this.vY = vy;
            this.demora = demora;
            this.precio = precio;
        }

        public Destino Destino
        {
            get { return vY; }
            set { vY = value; }
        }

        public string Demora
        {
            get { return demora; }
            set { demora = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
    }
}
