using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Boleto
    {
        Viaje recorrido;
        Destino origen;
        Destino destino;
        Cliente pasajero;
        Pago pago;
        int id;
        int asiento;
        string fecha_emision;
        string fecha;
        string precio;
        string hora_salida;
        string hora_salida_ad;
        string hora_llegada;
        string estado;


        public Boleto(Viaje recorrido, Destino origen, Destino destino, Cliente pasajero, int asiento, string fecha, string precio, string hora_salida, string hora_salida_ad, string hora_llegada)
        {
            fecha_emision = DateTime.Now.ToString();
            this.recorrido = recorrido;
            this.origen = origen;
            this.destino = destino;
            this.pasajero = pasajero;
            this.asiento = asiento;
            this.fecha = fecha;
            this.precio = precio;
            this.hora_salida = hora_salida;
            this.hora_salida_ad = hora_salida_ad;
            this.hora_llegada = hora_llegada;
            estado = "PENDIENTE";
        }

        public Boleto(Viaje recorrido, Destino origen, Destino destino, Cliente pasajero, int asiento, string fecha, string precio, string hora_salida, string hora_salida_ad, string hora_llegada, string estado, string fecha_emision)
        {
            this.fecha_emision = fecha_emision;
            this.recorrido = recorrido;
            this.origen = origen;
            this.destino = destino;
            this.pasajero = pasajero;
            this.asiento = asiento;
            this.fecha = fecha;
            this.precio = precio;
            this.hora_salida = hora_salida;
            this.hora_salida_ad = hora_salida_ad;
            this.hora_llegada = hora_llegada;
            this.estado = estado;
        }

        public Pago Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        public string FechaEmision
        {
            get { return fecha_emision; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Viaje Recorrido
        {
            get { return recorrido; }
        }

        public Destino Origen
        {
            get { return origen; }
        }

        public Destino Destino
        {
            get { return destino; }
        }

        public Cliente Pasajero
        {
            get { return pasajero; }
            set { pasajero = value; }
        }

        public int Asiento
        {
            get { return asiento; }
        }

        public string HoraSalida
        {
            get { return hora_salida; }
        }

        public string HoraSalidaAdicional
        {
            get { return hora_salida_ad; }
        }

        public string HoraLlegada
        {
            get { return hora_llegada; }
        }

        public string Fecha
        {
            get { return fecha; }
        }

        public string Precio
        {
            get { return precio; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
