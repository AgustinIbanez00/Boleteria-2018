using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Horario
    {
        string hora;
        bool[] frecuencia = new bool[7];
        Distribucion distribucion;

        public Horario(string hora, bool[] frecuencia, Distribucion distribucion)
        {
            this.hora = hora;
            this.frecuencia = frecuencia;
            this.distribucion = distribucion;
        }

        public Distribucion Distribucion
        {
            get { return distribucion; }
            set { distribucion = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public bool[] Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }

    }
}
