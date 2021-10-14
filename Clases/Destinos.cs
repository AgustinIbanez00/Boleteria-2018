using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Destinos
    {
        List<Destino> lista = new List<Destino>();
        string directory = "C:\\trabajo final\\datos";
        string file;

        public Destinos(string directory)
        {
            this.directory = directory;
            file = directory + "\\destinos.dat";
        }


        public bool Cargar()
        {
            try
            {
                lista.Clear();
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                if (!File.Exists(file)) File.Create(file);
                FileStream fs = new FileStream(file, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                while (br.PeekChar() != -1)
                {
                    Destino d = new Destino(br.ReadString(), br.ReadDouble(), br.ReadDouble());
                    Agregar(d);
                }
                fs.Close();
                br.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar los destinos." + Environment.NewLine + "Excepcion: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public void Agregar(Destino d)
        {
            if(lista != null)
            {
                lista.Add(d);
            }
        }
        public void Guardar()
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    if(File.Exists(file))
                    {
                        FileStream fs = new FileStream(file, FileMode.Truncate);
                        BinaryWriter bw = new BinaryWriter(fs);

                        foreach (Destino d in lista)
                        {
                            bw.Write(d.Nombre);
                            bw.Write(d.X);
                            bw.Write(d.Y);

                        }
                        fs.Close();
                        bw.Close();
                    }
                }

            }
            catch(IOException ex)
            {
                MessageBox.Show("Ocurrió un error al intentar guardar los destinos." + Environment.NewLine + "Excepcion: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Eliminar(Destino d)
        {
            if(lista != null)
            {
                lista.Remove(d);
            }
        }
        public bool Buscar(Destino d)
        {
            if(lista != null)
            {
                if(lista.Contains(d))
                {
                    return true;
                }
            }
            return false;
        }

        public string Directorio
        {
            get { return directory; }
            set { directory = value; }
        }

        public List<Destino> Lista
        {
            get { return lista; }
        }

    }
}
