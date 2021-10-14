using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Viajes
    {
        List<Viaje> lista = new List<Viaje>();
        Grafo grafo;
        Distribuciones distribuciones;
        string directorio;
        string archivo = "\\viajes.dat";

        public Viajes(Grafo grafo, Distribuciones distribuciones, string directorio)
        {
            this.directorio = directorio;
            this.distribuciones = distribuciones;
            this.grafo = grafo;
        }

        public string Directorio
        {
            get { return directorio; }
        }

        public List<Viaje> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public void Agregar(Viaje v)
        {
            if (lista != null) lista.Add(v);
        }

        public void Eliminar(Viaje v)
        {
            if (lista != null)
            {
                Directory.Delete(directorio + "\\recorridos\\" + v.Nombre, true);
                lista.Remove(v);
            }
        }

        public bool Buscar(Viaje v)
        {
            if (lista != null) if (lista.Contains(v)) return true;
            return false;
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

                        while(br.PeekChar() != -1)
                        {
                            string nombre = br.ReadString();
                            string origen = br.ReadString();
                            string destino = br.ReadString();
                            Vertice vO = grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
                            Vertice vD = grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
                            Destino dO = null;
                            Destino dD = null;
                            if(vO.Destino != null && vD.Destino != null)
                            {
                                dO = vO.Destino;
                                dD = vD.Destino;
                                Viaje viaje = new Viaje(nombre, dO, dD);
                                viaje.CrearGrafo(grafo, directorio);
                                viaje.Grafo.Cargar();
                                int cant_horario = br.ReadInt32();
                                bool[] frecuencia = new bool[7];
                                for(int i = 0; i < cant_horario; i++)
                                {
                                    string tiempo = br.ReadString();
                                    for (int f = 0; f < 7; f++)
                                    {
                                        frecuencia[f] = br.ReadBoolean();
                                    }
                                    string nota = br.ReadString();
                                    Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == nota);
                                    if(d != null)
                                    {
                                    viaje.AddHorario(tiempo, frecuencia, d);
                                    }
                                }
                                lista.Add(viaje);
                            }
                        }
                        fs.Close();
                        br.Close();

                    }
                }
                    
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error: (viajes)", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                foreach (Viaje v in lista)
                {
                    bw.Write(v.Nombre);
                    bw.Write(v.Origen.Nombre);
                    bw.Write(v.Destino.Nombre);
                    bw.Write(v.CantidadHorarios);
                    for(int i = 0; i < v.CantidadHorarios; i++)
                    {
                        Horario h = v.ListaHorarios[i];
                        if (h != null)
                        {
                            bw.Write(h.Hora);
                            for (int f = 0; f < 7; f++)
                            {
                                bw.Write(h.Frecuencia[f]);
                            }
                            bw.Write(h.Distribucion.Nota);
                        }
                    }
                }
                fs.Close();
                bw.Close();

                foreach(Viaje v in Lista)
                {
                    if(v != null)
                    {
                        if(v.Grafo != null)
                        v.Grafo.Guardar();
                    }
                }
                
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error: (viajes)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
