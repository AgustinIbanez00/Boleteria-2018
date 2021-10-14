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
    public partial class frmPasaje : Form
    {
        Clientes clientes;
        Boletos boletos;

        public frmPasaje(string directory, Clientes clientes, Boletos boletos)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.boletos = boletos;
        }
        private void frmPasajeros_Load(object sender, EventArgs e)
        {            
            if (clientes.Lista.Count > 0)
            {
                cbNombre.AutoCompleteCustomSource.Clear();
                cbDNI.AutoCompleteCustomSource.Clear();
                foreach (Cliente c in clientes.Lista)
                {
                    cbNombre.AutoCompleteCustomSource.Add(c.Nombre);
                    cbDNI.AutoCompleteCustomSource.Add(c.DNI);
                }
                ActualizarFiltros();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rbRegistrar.Checked)
            {
                if (cbNombre.Text != string.Empty)
                {
                    if (cbDNI.Text != string.Empty)
                    {
                        if (dtpFechaNac.Value != DateTime.Now)
                        {
                            if (clientes.Lista.Find(cf => cf.DNI == cbDNI.Text) == null)
                            {
                                Cliente c = new Cliente((Convert.ToInt32(clientes.Lista[clientes.Lista.Count - 1].ID) + 1).ToString(), cbNombre.Text, dtpFechaNac.Value.ToShortDateString(), cbDNI.Text);
                                clientes.Cargar(c);
                                clientes.Guardar();
                                cbNombre.Text = string.Empty;
                                cbDNI.Text = string.Empty;
                                cbNombre.Focus();
                                MessageBox.Show("Pasajero registrado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("El documento de identidad debe ser único.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Ingrese una fecha de nacimiento válida.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Para registrar un cliente se necesita un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Para registrar un cliente se necesita un nombre.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbEditar.Checked)
            {
                if (cbNombre.Text != string.Empty)
                {
                    if (cbDNI.Text != string.Empty)
                    {
                        if (clientes.Lista.Find(cf => cf.DNI == cbDNI.Text && cf.DNI != dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString()) == null)
                        {
                            Cliente c = clientes.Lista.Find(cliente => cliente.DNI == dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString());
                            if (c != null)
                            {
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Pasajero.ID == c.ID)
                                    {
                                        b.Pasajero = c;
                                        break;
                                    }
                                }

                                c.DNI = cbDNI.Text;
                                c.Nombre = cbNombre.Text;
                                c.FechaNac = dtpFechaNac.Value.ToShortDateString();
                                clientes.Guardar();
                                boletos.Guardar();
                                cbNombre.Text = string.Empty;
                                cbDNI.Text = string.Empty;
                                cbNombre.Focus();
                                MessageBox.Show("Los cambios se guardaron correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Error inválido: El pasajero no se encuentra registrado en la lista.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("El documento de identidad debe ser único.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Para registrar un cliente se necesita un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Para registrar un cliente se necesita un nombre.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbEliminar.Checked)
            {
                Cliente c = clientes.Lista.Find(cliente => cliente.DNI == dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString());
                if (c != null)
                {
                    int count = boletos.Lista.Count(bol => bol.Pasajero.DNI == c.DNI);
                    if (count == 0)
                    {
                        clientes.Lista.Remove(c);
                        clientes.Guardar();
                        MessageBox.Show("El cliente se eliminó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString())*Convert.ToInt32(cbPagina.SelectedItem.ToString()))-Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));
                    }
                    else
                    {
                        if (MessageBox.Show("Hay " + count + " boletos a nombre de este pasajero, al eliminarlo se eliminarán los boletos a su nombre." + Environment.NewLine + "¿Está seguro que desea eliminar este pasajero?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            List<Boleto> boletos_temp = new List<Boleto>();
                            foreach(Boleto b in boletos.Lista) if(b.Pasajero.DNI == c.DNI) boletos_temp.Add(b);
                            foreach (Boleto b in boletos_temp) boletos.Lista.Remove(b);

                            clientes.Lista.Remove(c);
                            clientes.Guardar();
                            boletos.Guardar();
                            ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())) - Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));
                            MessageBox.Show("Se eliminaron " + count + " boletos correctamente.", "Acción realizada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else MessageBox.Show("Error inesperado: No se pudo encontrar el pasajero en la lista.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())) - Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));
        }   
        private void cbDNI_KeyPress(object sender, KeyPressEventArgs e)
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
        private void rbRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbRegistrar.Checked)
                {
                    cbNombre.Enabled = true;
                    cbDNI.Enabled = true;
                    dtpFechaNac.Enabled = true;

                    btnOperar.Enabled = true;
                    btnOperar.Text = "Registrar";
                    cbNombre.Text = string.Empty;
                    cbDNI.Text = string.Empty;
                    dtpFechaNac.Value = DateTime.Now;
                    cbNombre.AutoCompleteMode = AutoCompleteMode.None;
                    cbDNI.AutoCompleteMode = AutoCompleteMode.None;
                }
            }     
            catch(NullReferenceException)
            {
            }
        }
        private void rbEditar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbEditar.Checked)
                {
                    cbNombre.Enabled = true;
                    cbDNI.Enabled = true;
                    dtpFechaNac.Enabled = true;

                    btnOperar.Enabled = false;
                    btnOperar.Text = "Guardar";
                    cbNombre.Text = dgvPasajeros.CurrentRow.Cells["Nombre"].Value.ToString();
                    cbDNI.Text = dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString();
                    dtpFechaNac.Value = Convert.ToDateTime(dgvPasajeros.CurrentRow.Cells["FechaNac"].Value.ToString());
                    cbNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cbDNI.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (NullReferenceException)
            {
            }
        }    
        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbEliminar.Checked)
                {
                    cbNombre.Enabled = false;
                    cbDNI.Enabled = false;
                    dtpFechaNac.Enabled = false;

                    btnOperar.Enabled = true;
                    btnOperar.Text = "Eliminar";
                    cbNombre.Text = dgvPasajeros.CurrentRow.Cells["Nombre"].Value.ToString();
                    cbDNI.Text = dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString();
                    dtpFechaNac.Value = Convert.ToDateTime(dgvPasajeros.CurrentRow.Cells["FechaNac"].Value.ToString());
                    cbNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cbDNI.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            catch (NullReferenceException)
            {
            }
        }
        private void cbMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())) - Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));
            if(cbMostrarTodo.Checked)
            {
                cbFilas.Enabled = false;
                lblNumeroFilas.Enabled = false;
            }
            else
            {
                cbFilas.Enabled = true;
                lblNumeroFilas.Enabled = true;
            }
        }
        private void cbNombre_TextChanged(object sender, EventArgs e)
        {
            if(rbEditar.Checked)
            {
                EnableSaveButton();
            }
        }
        private void cbDNI_TextChanged(object sender, EventArgs e)
        {
            if (rbEditar.Checked)
            {
                EnableSaveButton();
            }
        }
        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (rbEditar.Checked)
            {
                EnableSaveButton();
            }
        }
        private void dgvPasajeros_SelectionChanged(object sender, EventArgs e)
        {
            if (rbEditar.Checked || rbEliminar.Checked)
            {
                Cliente c = clientes.Lista.Find(cliente => cliente.DNI == dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString());
                if (c != null)
                {
                    cbNombre.Text = c.Nombre;
                    cbDNI.Text = c.DNI;
                    dtpFechaNac.Value = Convert.ToDateTime(c.FechaNac);
                }
                else MessageBox.Show("Error inesperado: Ese pasajero ya no se encuentra en la lista.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbDNI_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void dgvPasajeros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void cbFilas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarFiltros();

            }
            catch (NullReferenceException)
            {

            }

        }    
        private void cbPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())) - Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));

            }
            catch (NullReferenceException)
            {

            }
        }

        private void ActualizarInformacion(int start, int end)
        {
            if (cbMostrarTodo.Checked)
            {
                dgvPasajeros.Rows.Clear();
                foreach (Cliente c in clientes.Lista)
                {
                    dgvPasajeros.Rows.Add(c.ID, c.Nombre, c.DNI, c.FechaNac);
                }
            }
            else
            {
                dgvPasajeros.Rows.Clear();
                for (int i = start; i < end; i++)
                {
                    if (i < clientes.Lista.Count)
                    {
                        if (clientes.Lista[i] != null)
                        {
                            dgvPasajeros.Rows.Add(clientes.Lista[i].ID, clientes.Lista[i].Nombre, clientes.Lista[i].DNI, clientes.Lista[i].FechaNac);
                        }
                    }
                }

            }
        }
        private void EnableSaveButton()
        {
            Cliente c = clientes.Lista.Find(cliente => cliente.DNI == dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString());
            if (c != null)
            {
                if (cbNombre.Text != c.Nombre || cbDNI.Text != c.DNI || dtpFechaNac.Value.ToShortDateString() != c.FechaNac)
                {
                    btnOperar.Enabled = true;
                }
                else btnOperar.Enabled = false;
            }
            else MessageBox.Show("Error inesperado: El pasajero ya no se encuentra registrado en la lista.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ActualizarFiltros()
        {
            cbPagina.Items.Clear();
            cbPagina.Items.Add("1");
            if (cbFilas.SelectedItem == null) cbFilas.SelectedIndex = 0;
            if (cbPagina.SelectedItem == null) cbPagina.SelectedIndex = 0;
            for (int i = 1; i < clientes.Lista.Count / Convert.ToInt32(cbFilas.SelectedItem.ToString()); i++)
            {
                cbPagina.Items.Add((i + 1).ToString());
            }            
            if (clientes.Lista.Count < Convert.ToInt32(cbFilas.Items[0].ToString()))
            {
                cbMostrarTodo.Visible = true;
            }
            else cbMostrarTodo.Visible = false;
            ActualizarInformacion((Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())) - Convert.ToInt32(cbFilas.SelectedItem.ToString()), (Convert.ToInt32(cbFilas.SelectedItem.ToString()) * Convert.ToInt32(cbPagina.SelectedItem.ToString())));
        }
    }
}
