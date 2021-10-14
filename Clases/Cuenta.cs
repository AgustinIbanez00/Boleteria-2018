using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cuenta
    {
        int id;
        string usuario;
        string contraseña;
        string correo;
        string fechanac;
        string fechareg;
        string sexo;
        string tipo;

        public Cuenta(int id, string usuario, string contraseña, string correo, string fechanac, string fechareg, string sexo, string tipo)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.correo = correo;
            this.fechanac = fechanac;
            this.fechareg = fechareg;
            this.sexo = sexo;
            this.tipo = tipo;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string FechaNac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }

        public string FechaReg
        {
            get { return fechareg; }
            set { fechareg = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
