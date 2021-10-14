using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Origen
    {
        string nombre;
        Destinos destinos;
        public Origen(string nombre, Destinos destinos)
        {
            this.nombre = nombre;
            this.destinos = destinos;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


    }
}
