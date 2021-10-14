using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Clientes
    {
        List<Cliente> lista = new List<Cliente>();
        string directory = "C:\\trabajo final\\datos\\";
        string archivo = "\\clientes.dat";

        public Clientes(string directory)
        {
            this.directory = directory;
        }

        public void Cargar()
        {
            try
            {
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                lista.Clear();
                FileStream fs;
                if (!File.Exists(directory + archivo)) fs = new FileStream(directory + archivo, FileMode.Create);
                else fs = new FileStream(directory + archivo, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                while (br.PeekChar() != -1)
                {
                    Cliente c = new Cliente(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString());
                    Cargar(c);
                }
                fs.Close();
                br.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los pasajeros." + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        public void Guardar()
        {
            try
            {
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(directory + archivo)) fs = new FileStream(directory + archivo, FileMode.Create);
                else fs = new FileStream(directory + archivo, FileMode.Truncate);
                BinaryWriter bw = new BinaryWriter(fs);
                foreach(Cliente c in lista)
                {
                    bw.Write(c.ID);
                    bw.Write(c.Nombre);
                    bw.Write(c.FechaNac);
                    bw.Write(c.DNI);
                }
                fs.Close();
                bw.Close();
                
            }
            catch (IOException)
            {
                //MessageBox.Show("Ocurrió un error al guardar los pasajeros.");
            }
        }

        public void Cargar(Cliente c)
        {
            if (lista != null) lista.Add(c);
        }

        public void Eliminar(Cliente c)
        {
            if (lista != null) lista.Remove(c);
        }

        public List<Cliente> Lista
        {
            get { return lista; }
        }

    }
}
