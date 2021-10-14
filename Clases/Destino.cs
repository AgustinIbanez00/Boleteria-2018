using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class Destino
    {
        string nombre;
        double x;
        double y;
        RadioButton rb;

        public Destino(string nombre, double x, double y)
        {
            this.nombre = nombre;
            this.x = x;
            this.y = y;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public RadioButton Boton
        {
            get { return rb; }
            set { rb = value; }
        }
    }
}
