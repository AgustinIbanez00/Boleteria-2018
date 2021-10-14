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
    public partial class frmMetodoDePago : Form
    {
        int cantidad;
        Boleto boleto;
        public Pago pago;

        public frmMetodoDePago(int cantidad, Boleto boleto)
        {
            this.cantidad = cantidad;
            this.boleto = boleto;
            InitializeComponent();
        }

        private void frmMetodoDePago_Load(object sender, EventArgs e)
        {
            rbEfectivo.Checked = true;
            tbTotal.Enabled = false;
            tbTotal.Text = "$" + cantidad.ToString();
            gbInformacion.Enabled = false;
            if (boleto.Pago != null)
            {
                btnPagar.Enabled = false;
            }
            else btnPagar.Enabled = true;
        }

        private void rbMetodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEfectivo.Checked)
            {
                foreach(Control c in gbInformacion.Controls)
                {
                    c.Enabled = false;
                }
            }
            else if(rbTarjeta.Checked)
            {
                foreach (Control c in gbInformacion.Controls)
                {
                    if (c.Tag.ToString() == "tarjeta" || c.Tag.ToString() == "pagofacil")
                        c.Enabled = true;
                    else c.Enabled = false;
                }
            }
            else if(rbRapiPago.Checked || rbPagoFacil.Checked)
            {
                foreach (Control c in gbInformacion.Controls)
                {
                    if (c.Tag.ToString() == "pagofacil")
                        c.Enabled = true;
                    else c.Enabled = false;
                }
            }
            else if(rbPaypal.Checked)
            {
                foreach (Control c in gbInformacion.Controls)
                {
                    if (c.Tag.ToString() == "pagofacil" || c.Tag.ToString() == "paypal")
                        c.Enabled = true;
                    else c.Enabled = false;
                }
            }
            gbInformacion.Enabled = true;
     
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (pago == null)
            {
                if (!cbTarjeta.Enabled || cbTarjeta.Enabled && cbTarjeta.SelectedItem != null)
                {
                    if (!tbTitular.Enabled || tbTitular.Text != string.Empty)
                    {
                        if (!tbDNI.Enabled || tbDNI.Text != string.Empty)
                        {
                            if (!tbCorreo.Enabled || tbCorreo.Text != string.Empty)
                            {
                                if (!tbNroTarjeta.Enabled || tbNroTarjeta.Text != string.Empty)
                                {
                                    if (MessageBox.Show("¿Los datos ingresados son correctos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        string metodo = "No tiene";
                                        foreach (Control c in gbMetodos.Controls)
                                        {
                                            if (c is RadioButton)
                                            {
                                                if (c.Tag != null)
                                                {
                                                    if (c.Tag.ToString() == "metodos")
                                                    {
                                                        if((c as RadioButton).Checked)
                                                        metodo = (c as RadioButton).Text;
                                                    }
                                                }
                                            }
                                        }
                                        string tarjeta = "Ninguna";
                                        if(cbTarjeta.SelectedItem != null) tarjeta = cbTarjeta.SelectedItem.ToString();
                                        long dni = 0;
                                        if (tbDNI.Text != string.Empty) Convert.ToInt64(tbDNI.Text);
                                        long nro_tarjeta = 0;
                                        if (tbNroTarjeta.Text != string.Empty) Convert.ToInt64(tbNroTarjeta.Text);
                                        string titular = "ninguno";
                                        if (tbTitular.Text != string.Empty) titular = tbTitular.Text;
                                        string correo = "ninguno";
                                        if (tbCorreo.Text != string.Empty) correo = tbCorreo.Text;

                                        string codigo = randomstring(10);
                                        pago = new Pago(codigo, boleto.ID, metodo, titular, dni, correo, tarjeta, nro_tarjeta, dtpFechaVencimiento.Value, cantidad);
                                        btnPagar.Enabled = false;
                                        MessageBox.Show("Cupón de pago creado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else MessageBox.Show("Faltó escribir el número de tarjeta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("El campo de correo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("El campo de DNI está vacío.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("El campo de titular está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Debes seleccionar una tarjeta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string randomstring(int lenght)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, lenght).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
