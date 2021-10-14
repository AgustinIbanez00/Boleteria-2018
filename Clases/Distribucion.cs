using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Distribucion
    {
        string nota;
        int cant_PB = 25;
        int cant_PA = 25;
        bool unPiso;
        int[,] matriz_PB;
        int[,] matriz_PA;
        int filas_pb;
        int filas_pa;

        public const int ESPACIO_NULL = -1;
        public const int ESPACIO_PASILLO = 1;
        public const int ESPACIO_BUTACA = 2;
        public const int ESPACIO_TV = 3;


        public Distribucion(int cantidad_PB)
        {
            this.cant_PB = cantidad_PB;
            if (cantidad_PB / 5 > 0)
            {
                filas_pb = (cantidad_PB / 5);
                matriz_PB = new int[filas_pb, 5];
            }
            //unPiso = true;
        }

        public Distribucion(int cantidad_PB, int cantidad_PA)
        {
            this.cant_PB = cantidad_PB;
            this.cant_PA = cantidad_PA;
            if (cantidad_PB / 5 > 0)
            {
                filas_pb = (cantidad_PB / 5);
                matriz_PB = new int[filas_pb, 5];
            }
            if (cantidad_PA / 5 > 0)
            {
                filas_pa = (cantidad_PA / 5);
                matriz_PA = new int[filas_pa, 5];
            }
            //unPiso = false;
        }

        public bool UnPiso
        {
            get { return unPiso; }
            set { unPiso = true; }
        }

        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public int FilasPB
        {
            get { return filas_pb; }
            set
            {
                filas_pb = value;
                matriz_PB = new int[filas_pb, 5];
            }
        }

        public int FilasPA
        {
            get { return filas_pa; }
            set
            {
                filas_pa = value;
                matriz_PA = new int[filas_pa, 5];
            }
        }

        public void AgregarPasilloPB(int x, int y)
        {
            matriz_PB[x, y] = ESPACIO_PASILLO;
        }

        public void AgregarButacaPB(int x, int y)
        {
            matriz_PB[x, y] = ESPACIO_BUTACA;
        }

        public void AgregarTVPB(int x, int y)
        {
            matriz_PB[x, y] = ESPACIO_TV;
        }

        public void RemoverPB(int x, int y)
        {
            matriz_PB[x, y] = ESPACIO_NULL;
        }

        public void AgregarPasilloPA(int x, int y)
        {
            matriz_PA[x, y] = ESPACIO_PASILLO;
        }

        public void AgregarButacaPA(int x, int y)
        {
            matriz_PA[x, y] = ESPACIO_BUTACA;
        }

        public void AgregarTVPA(int x, int y)
        {
            matriz_PA[x, y] = ESPACIO_TV;
        }

        public void RemoverPA(int x, int y)
        {
            matriz_PA[x, y] = ESPACIO_NULL;
        }

        public int[,] MatrizPB
        {
            get { return matriz_PB; }
            set { matriz_PB = value; }
        }

        public int[,] MatrizPA
        {
            get { return matriz_PA; }
            set { matriz_PA = value; }
        }

        public int ContarAsientos()
        {
            int c = 0;
            for(int i = 0; i < filas_pa; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (matriz_PA[i, j] == ESPACIO_BUTACA)
                        c++;
                }
            }
            for (int i = 0; i < filas_pb; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz_PB[i, j] == ESPACIO_BUTACA)
                        c++;
                }
            }
            return c;
        }

    }
}
