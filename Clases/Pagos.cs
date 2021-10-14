using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Pagos
    {
        List<Pago> lista = new List<Pago>();

        string directorio;
        string archivo = "\\pagos.dat";

        public Pagos(string directorio)
        {
            this.directorio = directorio;
        }

        public List<Pago> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public void Cargar()
        {
            try
            {
                string full_name = directorio + archivo;
                if (Directory.Exists(directorio))
                {
                    if (File.Exists(full_name))
                    {
                        lista.Clear();
                        FileStream fs = new FileStream(full_name, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs);

                        while (br.PeekChar() != -1)
                        {
                            string codigo = br.ReadString();
                            int boletoid = br.ReadInt32();
                            string tipo = br.ReadString();
                            string titular = br.ReadString();
                            long dni = br.ReadInt64();
                            string correo = br.ReadString();
                            string tarjeta = br.ReadString();
                            long nro_tarjeta = br.ReadInt64();
                            string fecha_vencimiento = br.ReadString();
                            int precio = br.ReadInt32();
                            Pago pago = new Pago(codigo, boletoid, tipo, titular, dni, correo, tarjeta, nro_tarjeta, Convert.ToDateTime(fecha_vencimiento), precio);
                            lista.Add(pago);
                        }
                        fs.Close();
                        br.Close();
                    }
                }
                
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error: (pagos)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Guardar()
        {
            try
            {
                string full_name = directorio + archivo;
                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
                FileStream fs;
                if (!File.Exists(full_name)) fs = new FileStream(full_name, FileMode.CreateNew);
                else fs = new FileStream(full_name, FileMode.Truncate);
                BinaryWriter bw = new BinaryWriter(fs);

                foreach(Pago p in lista)
                {
                    bw.Write(p.Codigo);
                    bw.Write(p.Boleto);
                    bw.Write(p.Tipo);
                    bw.Write(p.Titular);
                    bw.Write(p.DNI);
                    bw.Write(p.Correo);
                    bw.Write(p.Tarjeta);
                    bw.Write(p.NROTarjeta);
                    bw.Write(p.FechaVencimiento.ToShortDateString());
                    bw.Write(p.Precio);
                }
                fs.Close();
                bw.Close();
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error: (pagos)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

    }
}
