using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vertice
    {
        Destino vX;
        List<Arco> lista = new List<Arco>();

        public Vertice(Destino vX)
        {
            this.vX = vX;
        }

        public List<Arco> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public Destino Destino
        {
            get { return vX; }
            set { vX = value; }
        }
    }
}
