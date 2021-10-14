using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pago
    {
        string codigo;
        int boleto;
        string tipo;
        string titular;
        long dni;
        string correo;
        string tarjeta;
        long nro_tarjeta;
        DateTime fecha_vencimiento;
        int precio;

        public Pago(string codigo, int boleto, string tipo, string titular, long dni, string correo, string tarjeta, long nro_tarjeta, DateTime fecha_vencimiento, int precio)
        {
            this.codigo = codigo;
            this.boleto = boleto;
            this.tipo = tipo;
            this.titular = titular;
            this.dni = dni;
            this.correo = correo;
            this.tarjeta = tarjeta;
            this.nro_tarjeta = nro_tarjeta;
            this.fecha_vencimiento = fecha_vencimiento;
            this.precio = precio;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Boleto
        {
            get { return boleto; }
            set { boleto = value; }
        }
        
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public long DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        public long NROTarjeta
        {
            get { return nro_tarjeta; }
            set { nro_tarjeta = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fecha_vencimiento; }
            set { fecha_vencimiento = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }                 
        }
    }
}
