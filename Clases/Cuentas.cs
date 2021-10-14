using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class Cuentas
    {
        List<Cuenta> lista = new List<Cuenta>();

        const string directory = "C:\\trabajo final\\datos";
        const string archivo = "\\cuentas.dat";
        const string ruta_entera = directory + archivo;


        public List<Cuenta> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public string Cargar()
        {
            string resultado = string.Empty;
            try
            {
                if (Directory.Exists(directory))
                {
                    if (File.Exists(ruta_entera))
                    {
                        lista.Clear();
                        FileStream fs = new FileStream(ruta_entera, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs);

                        while (br.PeekChar() != -1)
                        {
                            Cuenta cuenta = new Cuenta(br.ReadInt32(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString());
                            CargarCuenta(cuenta);
                        }

                        fs.Close();
                        br.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                resultado = ex.Message;
            }

            return resultado;
        }

        public bool CargarCuenta(Cuenta c)
        {
            if(lista != null)
            {
                lista.Add(c);
                return true;
            }
            return false;
        }
        
        public bool EliminarCuenta(Cuenta c)
        {
            if(lista != null)
            {
                lista.Remove(c);
                return true;
            }
            return false;
        }

        public string Guardar()
        {
            string resultado = string.Empty;
            if (lista != null)
            {
                try
                {
                    if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                    FileStream fs;
                    if (!File.Exists(ruta_entera)) fs = new FileStream(ruta_entera, FileMode.CreateNew);
                    else fs = new FileStream(ruta_entera, FileMode.Truncate);
                    BinaryWriter bw = new BinaryWriter(fs);

                    foreach (Cuenta c in lista)
                    {
                        bw.Write(c.ID);
                        bw.Write(c.Usuario);
                        bw.Write(c.Contraseña);
                        bw.Write(c.Correo);
                        bw.Write(c.FechaNac);
                        bw.Write(c.FechaReg);
                        bw.Write(c.Sexo);
                        bw.Write(c.Tipo);
                    }

                    fs.Close();
                    bw.Close();
                }
                catch (IOException ex)
                {
                    resultado = ex.Message;
                }
                return resultado;
            }
            return resultado;
        }

        public bool BuscarCuenta(Cuenta c)
        {
            if(lista != null)
            {
                if (lista.Contains(c))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public bool BuscarNombre(string nombre)
        {
            if(lista != null)
            {
                foreach (Cuenta c in lista)
                {
                    if(nombre == c.Usuario)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string Directorio
        {
            get { return directory; }
        }
    }
}
