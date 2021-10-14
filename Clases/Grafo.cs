using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clases
{
    public class Grafo
    {
        List<Vertice> lista = new List<Vertice>();
        string directory = "C:\\trabajo final\\datos\\lugares";
        string file_v = "\\lugares.dat";
        string file_a = "\\conexiones.dat";


        public Grafo (string directory)
        {
            this.directory = directory + "\\lugares\\";
        }

        public Grafo (string directory, string archivo_vertices, string archivo_arcos)
        {
            this.directory = directory;
            this.file_v = archivo_vertices;
            this.file_a = archivo_arcos;
        }

        public string Directorio
        {
            get { return directory; }
            set { directory = value; }
        }

        public List<Vertice> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public void Inicializar(List<Destino> D)
        {
            foreach(Destino d in D)
            {
                lista.Add(new Vertice(d));
            }
        }

        public void AgregarVertice(Destino destino)
        {
            lista.Add(new Vertice(destino));
        }

        public bool AgregarArco(Destino vX, Destino vY, string demora, double precio)
        {
            int x = BuscarIndice(vX);
            int y = BuscarIndice(vY);
            if(x != -1 && y != -1)
            {
                Arco a = new Arco(vY, demora, precio);
                lista[x].Lista.Add(a);
                return true;
            }
            return false;
        }

        public void EliminarArco(Destino vX, Destino a)
        {
            int x = BuscarIndice(vX);
            Arco arco = lista[x].Lista.Find(y => y.Destino == a);
            lista[x].Lista.Remove(arco);
        }

        public int BuscarIndice(Destino v)
        {
            Vertice vertice = lista.Find(vfind => vfind.Destino == v);

            if (vertice != null)
            {
                return lista.IndexOf(vertice);
            }
            else return -1;
        }

        public List<int> floydMarshall(Destino verticeX, Destino verticeY)
        {

            int n = lista.Count;// Cantidad de Vertices
            int a = BuscarIndice(verticeX); // Indice de Vertice
            int?[,] M = new int?[n, n]; // Matriz con el minimo Camino a Otro Vertice
            double[,] Cm = new double[n, n];//Matriz Costo   

            for (int i = 0; i < n; i++)
            {
                int index = 0;
                for (int c = 0; c < n; c++)
                {
                    if (Lista[i].Lista.Count != 0 && Lista[i].Lista[index].Destino == Lista[c].Destino)
                    {
                        Cm[i, c] = Convert.ToDouble(Lista[i].Lista[index++].Precio);
                    }
                    else Cm[i, c] = 999999;
                }
            }

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (Cm[f, c] == 0 || Cm[f, c] == 999999) M[f, c] = null;
                    else M[f, c] = f;
                }
            }

            double dk;

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dk = Cm[i, k] + Cm[k, j];
                        if (Cm[i, j] > dk)
                        {
                            Cm[i, j] = dk;
                            M[i, j] = k;
                        }
                    }
                }
            }

            int x = BuscarIndice(verticeX);
            int y = BuscarIndice(verticeY);
            List<int> Camino = new List<int>();
            MuestraCamino(M, x, y, Camino);
            return Camino;
        }

        public List<int> MuestraCamino(int?[,] M, int i, int j, List<int> Camino)
        {
            if (i == j) Camino.Add(i);
            else
            {
                if (M[i, j] != null)
                {
                    MuestraCamino(M, i, (int)M[i, j], Camino);
                    Camino.Add(j);
                }
            }
            return Camino;
        }

        public void Cargar()
        {
            try
            {
                lista.Clear();

                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                string full_name_v = directory + file_v;
                FileStream fs_v;
                if (!File.Exists(full_name_v)) fs_v = new FileStream(full_name_v, FileMode.CreateNew);
                else fs_v = new FileStream(full_name_v, FileMode.Open);
                BinaryReader br_v = new BinaryReader(fs_v);

                while (br_v.PeekChar() != -1)
                {
                    string nombre = br_v.ReadString();
                    double x = br_v.ReadDouble();
                    double y = br_v.ReadDouble();
                    Destino dV = new Destino(nombre, x, y);
                    AgregarVertice(dV);
                }
                fs_v.Close();
                br_v.Close();

                string full_name_a = directory + file_a;
                FileStream fs_a;
                if (!File.Exists(full_name_a)) fs_a = new FileStream(full_name_a, FileMode.CreateNew);
                else fs_a = new FileStream(full_name_a, FileMode.Open);
                BinaryReader br_a = new BinaryReader(fs_a);

                while (br_a.PeekChar() != -1)
                {
                    string destino_nombre = br_a.ReadString();

                    string nombre = br_a.ReadString();
                    double x = br_a.ReadDouble();
                    double y = br_a.ReadDouble();
                    string demora = br_a.ReadString();
                    double precio = br_a.ReadDouble();

                    Destino dV = null;
                    Destino dA = null;
                    Vertice vA = lista.Find(vert => vert.Destino.Nombre == nombre);
                    if (vA != null) dA = vA.Destino;
                    Vertice vD = lista.Find(vert => vert.Destino.Nombre == destino_nombre);
                    if (vD != null) dV = vD.Destino;
                    Arco arco = new Arco(dA, demora, precio);
                    vD.Lista.Add(arco);

                }
                fs_a.Close();
                br_a.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar los destinos." + Environment.NewLine + "Excepcion: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Guardar()
        {
            try
            {
                string full_name_v = directory + file_v;
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                FileStream fs_v;
                if (!File.Exists(full_name_v)) fs_v = new FileStream(full_name_v, FileMode.CreateNew);
                else fs_v = new FileStream(full_name_v, FileMode.Truncate);
                BinaryWriter bw_v = new BinaryWriter(fs_v);
                foreach (Vertice d in Lista)
                {
                    bw_v.Write(d.Destino.Nombre);
                    bw_v.Write(d.Destino.X);
                    bw_v.Write(d.Destino.Y);
                }
                fs_v.Close();
                bw_v.Close();

                string full_name_a = directory + file_a;
                FileStream fs_a;
                if (!File.Exists(full_name_a)) fs_a = new FileStream(full_name_a, FileMode.CreateNew);
                else fs_a = new FileStream(full_name_a, FileMode.Truncate);
                BinaryWriter bw_a = new BinaryWriter(fs_a);

                foreach (Vertice d in Lista)
                {
                    foreach (Arco a in d.Lista)
                    {
                        bw_a.Write(d.Destino.Nombre);
                        bw_a.Write(a.Destino.Nombre);
                        bw_a.Write(a.Destino.X);
                        bw_a.Write(a.Destino.Y);
                        bw_a.Write(a.Demora);
                        bw_a.Write(a.Precio);
                    }
                }
                fs_a.Close();
                bw_a.Close();
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
