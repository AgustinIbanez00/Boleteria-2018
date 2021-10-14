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
    public partial class frmAsientos : Form
    {
        public frmAsientos()
        {
            InitializeComponent();
        }

        public int butaca = 0;

        bool permitirCambio = false;

        DataTable data_PB = new DataTable();

        Distribucion distribucion;
        Distribuciones distribuciones;

        public frmAsientos(Distribuciones distribuciones)
        {
            this.distribuciones = distribuciones;
            InitializeComponent();
        }

        public frmAsientos(Distribuciones distribuciones, Distribucion distribucion)
        {
            this.distribuciones = distribuciones;
            this.distribucion = distribucion;
            InitializeComponent();
        }



        private void frmAsientos_Load(object sender, EventArgs e)
        {
            permitirCambio = true;
            this.Size = new Size(740, 400);
            tcAsientos.SelectedIndex = 4;
            permitirCambio = false;
            cbDistrPisos.SelectedIndex = 0;

            nudDistrCantidad.Value = nudDistrCantidad.Minimum + 5;

            distribucion = new Distribucion(30, 30);
            rbPB.Checked = true;
            DrawDistribution();

            RecargarDistribuciones();
        }

        private void btnAsiento1_Click(object sender, EventArgs e)
        {
        }

        private void tcAsientos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!permitirCambio) e.Cancel = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvAsientosTOdos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnModEGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewButtonCell d in dgvAsientos.SelectedCells)
            {
                if (rbPBModEAsiento.Checked)
                {
                    d.FlatStyle = FlatStyle.Flat;
                    d.Tag = "A";
                }
                else if (rbPBModEPasillo.Checked)
                {
                    d.FlatStyle = FlatStyle.Flat;
                    d.Tag = "P";
                }
                else if (rbPBModENinguno.Checked)
                {
                    d.FlatStyle = FlatStyle.Flat;
                    d.Tag = "N";
                }
                else if (rbPBModETelevision.Checked)
                {
                    d.FlatStyle = FlatStyle.Flat;
                    d.Tag = "T";
                }
                d.Value = string.Empty;
            }
            ContarAsientos();
            Guardar();
        }

        private void ContarAsientos()
        {
            int i = 0;
            if (rbPA.Checked)
            {
                i = 1;
                for (int j = 0; j < distribucion.FilasPB; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (distribucion.MatrizPB[j, k] == 2)
                            i++;
                    }
                }
            }
            else if (rbPB.Checked)
            {
                i = 1;
            }
            foreach (DataGridViewRow d in dgvAsientos.Rows)
            {
                foreach (DataGridViewButtonCell c in d.Cells)
                {
                    switch (c.Tag)
                    {
                        case "A":
                            c.Value = i.ToString();
                            c.ToolTipText = "Butaca";
                            i++;
                            c.Style.BackColor = Color.LightGreen;
                            c.Style.ForeColor = Color.Black;
                            c.Style.SelectionForeColor = Color.Black;
                            c.FlatStyle = FlatStyle.Flat;
                            break;
                        case "P":
                            c.Value = c.Tag;
                            c.ToolTipText = "Pasillo";
                            c.Style.BackColor = Color.White;
                            c.Style.ForeColor = Color.Silver;
                            c.Style.SelectionForeColor = Color.Black;
                            c.FlatStyle = FlatStyle.Flat;
                            break;
                        case "T":
                            c.Value = "TV";
                            c.ToolTipText = "Televisión";
                            c.Style.BackColor = Color.LightSkyBlue;
                            c.Style.ForeColor = Color.Blue;
                            c.Style.SelectionForeColor = Color.Blue;
                            c.FlatStyle = FlatStyle.Flat;
                            break;
                        case "N":
                            c.Value = c.Tag;
                            c.Style.BackColor = Color.White;
                            c.Style.ForeColor = Color.Silver;
                            c.Style.SelectionForeColor = Color.Black;
                            c.FlatStyle = FlatStyle.Flat;
                            break;
                    }
                }
            }
        }

        private void Guardar()
        {
            if (rbPA.Checked)
            {
                foreach (DataGridViewRow row in dgvAsientos.Rows)
                {
                    foreach (DataGridViewButtonCell cell in row.Cells)
                    {
                        switch (cell.Tag)
                        {
                            case "A":
                                distribucion.AgregarButacaPA(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "P":
                                distribucion.AgregarPasilloPA(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "T":
                                distribucion.AgregarTVPA(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "N":
                                distribucion.RemoverPA(cell.RowIndex, cell.ColumnIndex);
                                break;
                            default:
                                distribucion.MatrizPA[cell.RowIndex, cell.ColumnIndex] = 0;
                                break;
                        }
                    }
                }
            }
            else if (rbPB.Checked)
            {
                foreach (DataGridViewRow row in dgvAsientos.Rows)
                {
                    foreach (DataGridViewButtonCell cell in row.Cells)
                    {
                        switch (cell.Tag)
                        {
                            case "A":
                                distribucion.AgregarButacaPB(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "P":
                                distribucion.AgregarPasilloPB(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "T":
                                distribucion.AgregarTVPB(cell.RowIndex, cell.ColumnIndex);
                                break;
                            case "N":
                                distribucion.RemoverPB(cell.RowIndex, cell.ColumnIndex);
                                break;
                            default:
                                distribucion.MatrizPA[cell.RowIndex, cell.ColumnIndex] = 0;
                                break;
                        }
                    }
                }
            }

        }

        private void dgvAsientosTOdos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbPBModEspacio.Enabled = true;

            if (dgvAsientos.SelectedCells.Count == 1)
            {
                foreach (DataGridViewButtonCell c in dgvAsientos.SelectedCells)
                {
                    switch (c.Tag)
                    {
                        case "A":
                            rbPBModEAsiento.Checked = true;
                            break;
                        case "P":
                            rbPBModEPasillo.Checked = true;
                            break;
                        case "T":
                            rbPBModETelevision.Checked = true;
                            break;
                        case "N":
                            rbPBModENinguno.Checked = true;
                            break;
                    }
                    break;
                }
            }
            else
            {
                foreach (Control c in gbDistrTipos.Controls) if (c is RadioButton) { (c as RadioButton).Checked = false; }
            }
        }

        private void dgvAsientosTOdos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudDistrPBCant_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbPA.Checked)
                {
                    if (nudDistrCantidad.Value != distribucion.FilasPA * 5)
                    {
                        if (nudDistrCantidad.Value < distribucion.FilasPA * 5)
                            dgvAsientos.Rows.RemoveAt(dgvAsientos.Rows.GetLastRow(DataGridViewElementStates.Visible));
                        distribucion.FilasPA = (int)nudDistrCantidad.Value / 5;
                        Guardar();
                        DrawDistribution();
                    }
                }
                else if (rbPB.Checked)
                {
                    if (nudDistrCantidad.Value != distribucion.FilasPB * 5)
                    {
                        if (nudDistrCantidad.Value < distribucion.FilasPB * 5)
                            dgvAsientos.Rows.RemoveAt(dgvAsientos.Rows.GetLastRow(DataGridViewElementStates.Visible));
                        distribucion.FilasPB = (int)nudDistrCantidad.Value / 5;
                        Guardar();
                        DrawDistribution();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*
                if (nudDistrPBCant.Value > distribucion.FilasPB * 5)
                {
                    dgvAsientos.Rows.Add();
                    foreach (DataGridViewRow d in dgvAsientos.Rows)
                    {
                        foreach (DataGridViewButtonCell c in d.Cells)
                        {
                            if (c.Tag == null)
                            {
                                c.Tag = "N";
                                c.Value = "N";
                                c.FlatStyle = FlatStyle.Flat;
                                c.Style.BackColor = Color.White;
                                c.Style.ForeColor = Color.Silver;
                            }
                        }
                    }
                }
                else
                {
                    dgvAsientos.Rows.RemoveAt(dgvAsientos.Rows.GetLastRow(DataGridViewElementStates.Visible));                 
                }*/

        private void cbDistrPisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDistrPisos.SelectedIndex)
            {
                case 0:
                    rbPB.Checked = true;
                    rbPA.Enabled = false;
                    if(distribucion != null)
                        distribucion.UnPiso = true;
                    //DrawDistribution();
                    break;
                case 1:
                    rbPB.Checked = true;
                    rbPA.Enabled = true;
                    if (distribucion != null)
                        distribucion.UnPiso = false;
                    //DrawDistribution();
                    break;
            }
        }

        private void btnDistrCrear_Click(object sender, EventArgs e)
        {
            if(rbDistrCrear.Checked)
            {
                if (distribucion.ContarAsientos() > 10)
                {
                    if (tbNota.Text != string.Empty)
                    {
                        if (distribuciones.Lista.Find(distr => distr.Nota == tbNota.Text) == null)
                        {
                            distribucion.Nota = tbNota.Text;

                            distribuciones.Lista.Add(distribucion);
                            distribuciones.Guardar();
                            distribucion = new Distribucion(30, 30);
                            DrawDistribution();

                            MessageBox.Show("La distribución se ha creado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Ya existe una distribución con esa nota.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Es necesario escribir una nota.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No se pueden crear distribuciones con tan pocos asientos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rbDistrMod.Checked)
            {
                Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == cbDistrDistribucion.SelectedItem.ToString());
                if (d != null)
                {
                    if (distribuciones.Lista.Find(distr => distr.Nota == tbNota.Text && distr != d) == null)
                    {
                        distribucion.Nota = tbNota.Text;
                        if (cbDistrPisos.SelectedIndex == 0) distribucion.UnPiso = true;
                        else distribucion.UnPiso = false;
                        d = distribucion;
                        distribuciones.Guardar();
                        DrawDistribution();
                        RecargarDistribuciones();
                        MessageBox.Show("Los cambios se han guardado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Esa nota ya está en uso.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Error intero.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPA_CheckedChanged(object sender, EventArgs e)
        {
            DrawDistribution();
        }

        private void rbPB_CheckedChanged(object sender, EventArgs e)
        {
            DrawDistribution();
        }

        private void DrawDistribution()
        {
            const int ESPACIO_NULL = -1;
            const int ESPACIO_PASILLO = 1;
            const int ESPACIO_BUTACA = 2;
            const int ESPACIO_TV = 3;

            if (rbPB.Checked)
            {
                dgvAsientos.Rows.Clear();

                try
                {
                nudDistrCantidad.Value = distribucion.FilasPB * 5;
                }
                catch(ArgumentOutOfRangeException)
                {

                }

                DataGridViewButtonCell c;
                for (int i = 0; i < distribucion.FilasPB; i++)
                {
                    dgvAsientos.Rows.Add();
                    for (int j = 0; j < 5; j++)
                    {
                        switch (distribucion.MatrizPB[i, j])
                        {
                            case ESPACIO_BUTACA:
                                c = new DataGridViewButtonCell();
                                c.Tag = "A";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_PASILLO:
                                c = new DataGridViewButtonCell();
                                c.Tag = "P";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_TV:
                                c = new DataGridViewButtonCell();
                                c.Tag = "T";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_NULL:
                                c = new DataGridViewButtonCell();
                                c.Tag = "N";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            default:
                                c = new DataGridViewButtonCell();
                                c.Tag = "N";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                        }
                    }
                }
                ContarAsientos();

            }
            else if (rbPA.Checked)
            {
                dgvAsientos.Rows.Clear();

                try
                {
                    nudDistrCantidad.Value = distribucion.FilasPA * 5;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
  
                DataGridViewButtonCell c;
                for (int i = 0; i < distribucion.FilasPA; i++)
                {
                    dgvAsientos.Rows.Add();
                    for (int j = 0; j < 5; j++)
                    {
                        switch (distribucion.MatrizPA[i, j])
                        {
                            case ESPACIO_BUTACA:
                                c = new DataGridViewButtonCell();
                                c.Tag = "A";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_PASILLO:
                                c = new DataGridViewButtonCell();
                                c.Tag = "P";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_TV:
                                c = new DataGridViewButtonCell();
                                c.Tag = "T";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            case ESPACIO_NULL:
                                c = new DataGridViewButtonCell();
                                c.Tag = "N";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                            default:
                                c = new DataGridViewButtonCell();
                                c.Tag = "N";
                                dgvAsientos.Rows[i].Cells[j] = c;
                                break;
                        }
                    }
                }
                ContarAsientos();
            }
        }

        private void RecargarDistribuciones()
        {
            cbDistrDistribucion.Items.Clear();
            foreach (Distribucion d in distribuciones.Lista)
            {
                cbDistrDistribucion.Items.Add(d.Nota);
                rbDistrMod.Enabled = true;
                cbDistrDistribucion.SelectedIndex = 0;
            }
        }

        private bool EsDoblePiso(Distribucion distribucion)
        {
            if (distribucion != null)
            {
                for (int i = 0; i < distribucion.FilasPA; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (distribucion.MatrizPA[i, j] > 0)
                            return true;
                    }
                }
            }
            return false;
        }


        private void rbDistrMod_CheckedChanged(object sender, EventArgs e)
        {
            cbDistrDistribucion.Enabled = true;
            lblDistr.Enabled = true;
            btnDistrCrear.Text = "Modificar";
            if(cbDistrDistribucion.Items.Count > 0) cbDistrDistribucion.SelectedIndex = 0;
        }

        private void cbDistrDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbDistrMod.Checked)
            {
                Distribucion d = CurrentDistribucion(cbDistrDistribucion.SelectedItem.ToString());
                if (d != null)
                {
                    distribucion = d;
                    tbNota.Text = distribucion.Nota;
                    DrawDistribution();
                    if (EsDoblePiso(distribucion))
                    {
                        cbDistrPisos.SelectedIndex = 1;
                    }
                    else cbDistrPisos.SelectedIndex = 0;
                }
            }
        }

        private Distribucion CurrentDistribucion(string text)
        {
            return distribuciones.Lista.Find(distr => distr.Nota == text);
        }

        private void rbDistrCrear_CheckedChanged(object sender, EventArgs e)
        {
            btnDistrCrear.Text = "Crear";
            cbDistrDistribucion.Enabled = false;
            lblDistr.Enabled = false;
            tbNota.Text = string.Empty;
            distribucion = new Distribucion(30, 30);
            DrawDistribution();
        }

        private void gbAsientosAdmin_Enter(object sender, EventArgs e)
        {

        }
    }
}
