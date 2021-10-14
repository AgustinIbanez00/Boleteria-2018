using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Sistema_final
{
    public partial class frmCuenta : Form
    {
        Cuentas cuentas;
        Cuenta cuenta;
        public frmCuenta(Cuentas cuentas, Cuenta cuenta)
        {
            InitializeComponent();
            this.cuentas = cuentas;
            this.cuenta = cuenta;
        }

        private void tbContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            if (cuenta != null)
            {
                tbUsuario.Text = cuenta.Usuario;
                tbCorreo.Text = cuenta.Correo;
                tbContrasena.Text = cuenta.Contraseña;
            }
            else MessageBox.Show("No se ha detectado ninguna cuenta, es posible que haya sido un error interno.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCuenta();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (!gbCambiarContraseña.Visible)
                gbCambiarContraseña.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCuenta();
        }

        private void GuardarCuenta()
        {
            if (tbUsuario.Text != string.Empty)
            {
                if (tbCorreo.Text != string.Empty)
                {
                    if (tbContrasena.Text != string.Empty)
                    {
                        if (!gbCambiarContraseña.Visible)
                        {
                            cuenta.Usuario = tbUsuario.Text;
                            cuenta.Contraseña = tbContrasena.Text;
                            cuenta.Correo = tbCorreo.Text;
                            cuentas.Guardar();
                            //MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Completa los datos que faltan para cambiar tu contraseña.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Contraseña incorrecta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No hay ninguna dirección de correo ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No hay ningún nombre de usuario ingresado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (tbContraseña.Text != string.Empty)
            {
                if (tbNuevaContraseña.Text != string.Empty)
                {
                    if (tbRepetirContraseña.Text != string.Empty)
                    {
                        if (tbContraseña.Text == cuenta.Contraseña)
                        {
                            if (tbNuevaContraseña.Text == tbRepetirContraseña.Text)
                            {
                                tbContrasena.Text = tbNuevaContraseña.Text;
                                gbCambiarContraseña.Visible = false;
                                MessageBox.Show("Contraseña cambiada correctamente.", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Las contraseñas no coinciden.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("La contraseña actual es incorrecta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Tienes que repetir la contraseña nueva.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Escribe tu contraseña nueva.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debes escribir la contraseña actual de tu cuenta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
