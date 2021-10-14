using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Boletos
    {
        List<Boleto> lista;
        string directory;
        string file = "\\boletos.dat";
        Pagos pagos;
        Viajes viajes;
        Clientes clientes;
        int last_id;


        public Boletos(string directory, Pagos pagos, Viajes viajes, Clientes clientes)
        {
            this.pagos = pagos;
            this.directory = directory;
            this.viajes = viajes;
            this.clientes = clientes;
            lista = new List<Boleto>();
            last_id = BuscarID();
        }

        public List<Boleto> Lista
        {
            get { return lista; }
        }

        public void Guardar()
        {
            try
            {
                string full_name = directory + file;
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                BinaryWriter bw;
                if (!File.Exists(full_name)) fs = new FileStream(full_name, FileMode.Create);
                else fs = new FileStream(full_name, FileMode.Truncate);
                bw = new BinaryWriter(fs);

                foreach(Boleto b in lista)
                {
                    bw.Write(b.ID);
                    bw.Write(b.Recorrido.Nombre);
                    bw.Write(b.Origen.Nombre);
                    bw.Write(b.Destino.Nombre);
                    bw.Write(b.FechaEmision);
                    bw.Write(b.Pasajero.ID);
                    bw.Write(b.Pasajero.Nombre);
                    bw.Write(b.Pasajero.FechaNac);
                    bw.Write(b.Pasajero.DNI);
                    bw.Write(b.Asiento);
                    bw.Write(b.Fecha);
                    bw.Write(b.Precio);
                    bw.Write(b.HoraSalida);
                    bw.Write(b.HoraSalidaAdicional);
                    bw.Write(b.HoraLlegada);
                    bw.Write(b.Estado);
                    if (b.Pago != null) bw.Write(b.Pago.Codigo);
                    else bw.Write("");
                }

                fs.Close();
                bw.Close();
                guardarID();
            
            }
            catch(IOException)
            {
                MessageBox.Show("Error inesperado: No se pudo guardar la lista de boletos.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar()
        {
            try
            {
                lista.Clear();
                string full_name = directory + file;
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(full_name)) fs = new FileStream(full_name, FileMode.Create);
                else fs = new FileStream(full_name, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                int count = 0;

                while(br.PeekChar() != -1)
                {
                    int id = br.ReadInt32();
                    string recorrido = br.ReadString();
                    string origen = br.ReadString();
                    string destino = br.ReadString();
                    string fecha_emision = br.ReadString();
                    string pas_id = br.ReadString();
                    string pas_nombre = br.ReadString();
                    string pas_fechanac = br.ReadString();
                    string pas_dni = br.ReadString();
                    int asiento = br.ReadInt32();
                    string fecha = br.ReadString();
                    string precio = br.ReadString();
                    string hora_salida = br.ReadString();
                    string hora_salida_ad = br.ReadString();
                    string hora_llegada = br.ReadString();
                    string estado = br.ReadString();
                    string codigo_pago = br.ReadString();

                    Viaje v = viajes.Lista.Find(viaje => viaje.Nombre == recorrido);
                    Cliente c = clientes.Lista.Find(cliente => cliente.ID == pas_id && cliente.Nombre == pas_nombre && cliente.FechaNac == pas_fechanac && cliente.DNI == pas_dni);
                    Vertice vO = v.Grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
                    Vertice vD = v.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
                    Pago p = pagos.Lista.Find(pago => pago.Codigo == codigo_pago);
                    if (v != null && c != null && vO != null && vD != null && vO.Destino != null && vD.Destino != null)
                    {
                        Boleto b = new Boleto(v, vO.Destino, vD.Destino, c, asiento, fecha, precio, hora_salida, hora_salida_ad, hora_llegada, estado, fecha_emision);
                        b.ID = id;
                        b.Pago = p;
                        lista.Add(b);
                    }
                    else count++;
                }
                if(count > 0)
                {
                    MessageBox.Show("Error inesperado: " + count + " boleto(s) no se pudo cargar.", "Error interno.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                fs.Close();
                br.Close();
            }
            catch(IOException ex)
            {
                MessageBox.Show("Error inesperado: No se pudo cargar la lista de boletos." + Environment.NewLine + "Detalles: " + ex.Message, "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Error inesperado: No se pudo cargar la lista de boletos." + Environment.NewLine + "Detalles: " + ex.Message, "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Add(Boleto boleto)
        {
            if(lista != null && boleto != null)
            {                      
                lista.Add(boleto);
                boleto.ID = last_id;
                last_id++;
            }
        }

        private int BuscarID()
        {
            try
            {
                string full_name_id = directory + "\\boleto_id.dat";
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(full_name_id)) fs = new FileStream(full_name_id, FileMode.Create);
                else fs = new FileStream(full_name_id, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                last_id = br.ReadInt32();

                fs.Close();
                br.Close();
                return last_id;
            }
            catch(IOException)
            {

            }
            return 1;
        }

        private void guardarID()
        {
            try
            {
                string full_name_id = directory + "\\boleto_id.dat";
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(full_name_id)) fs = new FileStream(full_name_id, FileMode.Create);
                else fs = new FileStream(full_name_id, FileMode.Truncate);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(last_id);

                fs.Close();
                bw.Close();

            }
            catch(IOException)
            {

            }
        }

    }
}
