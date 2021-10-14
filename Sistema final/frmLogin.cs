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
    public partial class frmLogin : Form
    {
        Cuentas cuentas = new Cuentas();
        Cuenta cuentaUso;

        public frmLogin()
        {
            InitializeComponent();
            ttMensajes.UseAnimation = true;
            cuentas.Cargar();
            lblCuentas.Text = "Cuentas: " + cuentas.Lista.Count;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        { 
            if(btnRegistrarse.Text == "Crear cuenta")
            {
                lblRContraseña.Visible = true;
                tbRContraseña.Visible = true;
                lblCorreo.Visible = true;
                tbCorreo.Visible = true;
                tbRContraseña.Visible = true;
                lblFechaNac.Visible = true;
                dtpFechaNac.Visible = true;
                lblSexo.Visible = true;
                cbSexo.Visible = true;
                cbSexo.TabIndex = 1;
                lblFechaRegistro.Visible = true;
                lblFechaRegistro.Text = "Fecha de registro: " + DateTime.Now.ToString();
                btnIngresar.Text = "Registrarse";
                btnRegistrarse.Text = "Volver";
                tbUsuario.Text = string.Empty;
                tbContraseña.Text = string.Empty;
                tbUsuario.Focus();
            }
            else
            {
                lblRContraseña.Visible = false;
                tbRContraseña.Visible = false;
                lblCorreo.Visible = false;
                tbCorreo.Visible = false;
                tbRContraseña.Visible = false;
                lblFechaNac.Visible = false;
                dtpFechaNac.Visible = false;
                lblSexo.Visible = false;
                cbSexo.Visible = false;
                cbSexo.TabIndex = 1;
                lblFechaRegistro.Visible = false;
                lblFechaRegistro.Text = "Fecha de registro: " + DateTime.Now.ToString();
                btnIngresar.Text = "Iniciar sesión";
                btnRegistrarse.Text = "Crear cuenta";
                tbUsuario.Text = string.Empty;
                tbContraseña.Text = string.Empty;
                tbUsuario.Focus();
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool log = false;
            if (btnIngresar.Text == "Iniciar sesión")
            {
                IniciarSesion(log);
            }
            else
            {
                if (tbUsuario.Text != string.Empty)
                {
                    if (!cuentas.BuscarNombre(tbUsuario.Text))
                    {
                        if (tbContraseña.Text != string.Empty)
                        {
                            if (tbRContraseña.Text != string.Empty)
                            {
                                if (tbContraseña.Text == tbRContraseña.Text)
                                {
                                    if (tbCorreo.Text != string.Empty)
                                    {
                                        if (tbCorreo.Text.Contains("@"))
                                        {
                                            if (cbSexo.SelectedItem != null)
                                            {
                                                Cuenta c = new Cuenta(cuentas.Lista.Count, tbUsuario.Text, tbContraseña.Text, tbCorreo.Text, dtpFechaNac.Value.ToString(), DateTime.Now.ToString(), cbSexo.Items[cbSexo.SelectedIndex].ToString(), "boleteria");
                                                cuentas.CargarCuenta(c);
                                                cuentas.Guardar();

                                                MessageBox.Show("Cuenta creada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                lblRContraseña.Visible = false;
                                                tbRContraseña.Visible = false;
                                                lblCorreo.Visible = false;
                                                tbCorreo.Visible = false;
                                                tbRContraseña.Visible = false;
                                                lblFechaNac.Visible = false;
                                                dtpFechaNac.Visible = false;
                                                lblSexo.Visible = false;
                                                cbSexo.Visible = false;
                                                cbSexo.TabIndex = 1;
                                                lblFechaRegistro.Visible = false;
                                                lblFechaRegistro.Text = "Fecha de registro: " + DateTime.Now.ToString();
                                                btnIngresar.Text = "Iniciar sesión";
                                                btnRegistrarse.Text = "Crear cuenta";
                                                tbUsuario.Text = string.Empty;
                                                tbContraseña.Text = string.Empty;
                                                tbUsuario.Focus();

                                            }
                                            else MessageBox.Show("Faltó seleccionar el sexo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else MessageBox.Show("Debe ingresar un correo válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else MessageBox.Show("Debe ingresar un correo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else MessageBox.Show("Las contraseñas no coinciden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Faltó confirmar la contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Falta ingresar una contraseña", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ese nombre de usuario ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Debe ingresar un nombre de usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            if (tbContraseña.Text != string.Empty)
            {
                if (btnRegistrarse.Visible == false)
                {
                    if (tbContraseña.Text.Length >= 8)
                    {
                        pbVerErrorContraseña.Visible = false;
                        pbVerContraseña.Visible = true;
                    }
                    else
                    {
                        pbVerErrorContraseña.Visible = true;
                        pbVerContraseña.Visible = false;
                    }
                }
                btnMostrarC.Visible = true;
            }
            else btnMostrarC.Visible = false;
        }

        private void btnMostrarC_MouseHover(object sender, EventArgs e)
        {
            tbContraseña.UseSystemPasswordChar = false;
            tbRContraseña.UseSystemPasswordChar = false;
      
        }

        private void btnMostrarC_MouseLeave(object sender, EventArgs e)
        {
            tbContraseña.UseSystemPasswordChar = true;
            tbRContraseña.UseSystemPasswordChar = true;
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text != string.Empty)
            {
                if (btnRegistrarse.Visible == false)
                {
                    pbVerErrorUsuario.Visible = true;
                    foreach (Cuenta c in cuentas.Lista)
                    {
                        if (c.Usuario == tbUsuario.Text)
                        {
                            pbVerErrorUsuario.Visible = true;
                            pbVerUsuario.Visible = false;
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                pbVerErrorUsuario.Visible = false;
                pbVerUsuario.Visible = false;
            }
        }
        private void pbVerErrorContraseña_Click(object sender, EventArgs e) { }

        private void pnlCuentas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pbVerErrorUsuario_Click(object sender, EventArgs e)
        {
            pbVerContraseña.Load();
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
        }


        private void IniciarSesion(bool log)
        {
            if (tbUsuario.Text != string.Empty)
            {
                if (tbContraseña.Text != string.Empty)
                {
                    cuentaUso = cuentas.Lista.Find(cuenta => cuenta.Usuario == tbUsuario.Text && cuenta.Contraseña == tbContraseña.Text);
                    if (cuentaUso != null)
                    {
                        frmPrincipal form = new frmPrincipal(cuentas.Directorio);
                        form.SyncAccounts(cuentaUso, cuentas);
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbContraseña.Text = string.Empty;
                    }
                }
                else MessageBox.Show("Ingrese una contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Ingrese un nombre de usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void tbContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (btnIngresar.Text == "Iniciar sesión" && tbContraseña.Text != string.Empty)
                {
                    IniciarSesion(false);
                }
            }

        }
    }
}
