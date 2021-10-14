using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class Cliente
    {
        string id;
        string nombre;
        string fechaNac;
        string dni;


        public Cliente(string id, string nombre, string fechaNac, string dni)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            this.dni = dni;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
       
        public int ultimoID()
        {
            try
            {
                int id = 0;
                string directory = "C:\\trabajo final\\datos";
                string archivo = "\\cliente_id.dat";
                string ruta = directory + archivo;
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(ruta)) fs = new FileStream(ruta, FileMode.Create);
                else fs = new FileStream(ruta, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                id = br.ReadInt32();
                fs.Close();
                br.Close();
                return id;
            }
            catch(IOException)
            {
                return -1;
            }
        }

        public void guardarID(int id)
        {
            try
            {
                string directory = "C:\\trabajo final\\datos\\";
                string archivo = "cliente_id.dat";
                string ruta = directory + archivo;
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                FileStream fs;
                if (!File.Exists(ruta)) fs = new FileStream(ruta, FileMode.Create);
                else fs = new FileStream(ruta, FileMode.Truncate);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                fs.Close();
                bw.Close();

            }
            catch(IOException)
            {

            }
        }
    }
}
