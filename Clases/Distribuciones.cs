using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Distribuciones
    {
        string directorio = string.Empty;
        List<Distribucion> lista = new List<Distribucion>();

        public List<Distribucion> Lista
        {
            get { return lista; }
        }

        public Distribuciones(string directorio)
        {
            this.directorio = directorio;
        }

        public void Cargar()
        {
            try
            {
                FileStream fs;
                string full_name = directorio + "\\distribuciones.dat";
                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
                if (!File.Exists(full_name)) fs = new FileStream(full_name, FileMode.CreateNew);
                else fs = new FileStream(full_name, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                lista.Clear();

                while(br.PeekChar() != -1)
                {
                    string nota = br.ReadString();
                    bool unPiso = br.ReadBoolean();
                    int filas_pb = br.ReadInt32();
                    int[,] matriz_pb = new int[filas_pb, 5];
                    for (int i = 0; i < filas_pb; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            matriz_pb[i, j] = br.ReadInt32();
                        }
                    }
                    int filas_pa = br.ReadInt32();
                    int[,] matriz_pa = new int[filas_pa, 5];
                    for (int i = 0; i < filas_pa; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            matriz_pa[i, j] = br.ReadInt32();
                        }
                    }
                    Distribucion d = new Distribucion(filas_pb*5, filas_pa*5);
                    d.UnPiso = unPiso;
                    d.Nota = nota;
                    d.MatrizPA = matriz_pa;
                    d.MatrizPB = matriz_pb;
                    lista.Add(d);
                }
                fs.Close();
                br.Close();
            }
            catch(IOException)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar las distribuciones.", "Error inesperado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Guardar()
        {
            try
            {
                FileStream fs;
                string full_name = directorio + "\\distribuciones.dat";
                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
                if (!File.Exists(full_name)) fs = new FileStream(full_name, FileMode.CreateNew);
                else fs = new FileStream(full_name, FileMode.Truncate);
                BinaryWriter bw = new BinaryWriter(fs);

                foreach(Distribucion d in lista)
                {
                    bw.Write(d.Nota);
                    bw.Write(d.UnPiso);
                    bw.Write(d.FilasPB);
                    for (int i = 0; i < d.FilasPB; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            bw.Write(d.MatrizPB[i, j]);
                        }
                    }
                    bw.Write(d.FilasPA);
                    for(int i = 0; i < d.FilasPA; i++)
                    {
                        for(int j = 0; j < 5; j++)
                        {
                            bw.Write(d.MatrizPA[i, j]);
                        }
                    }

                }
                fs.Close();
                bw.Close();
            }
            catch(IOException)
            {
                MessageBox.Show("Ocurrió un error al guardar las distribuciones.", "Error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
