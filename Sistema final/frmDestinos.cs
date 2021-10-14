using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Clases;

namespace Sistema_final
{
    public partial class frmDestinos : Form
    {
        Grafo grafo;
        Viajes viajes;
        Boletos boletos;
        Distribuciones distribuciones;
        Distribucion distribucion;

        Point punto = Point.Empty;
        Point punto_temp = Point.Empty;
        const int ESTADO_NULO = 0;
        const int ESTADO_CREANDO = 1;
        const int ESTADO_EDITANDO_C = 2;
        const int ESTADO_EDITANDO = 3;

        int estado;

        public frmDestinos()
        {
            InitializeComponent();
        }    
        public frmDestinos(string directory, Grafo grafo, Viajes viajes, Boletos boletos, Distribuciones distribuciones)
        {
            InitializeComponent();
            this.grafo = grafo;
            this.viajes = viajes;
            this.boletos = boletos;
            this.distribuciones = distribuciones;
        }
        private void frmDestinos_Load(object sender, EventArgs e)
        {
            cbLugar.Items.Add("Seleccione un lugar.");
            grafo.Cargar();
            viajes.Cargar();

            RecargarDestinos();
            RecargarViajes();

            tbLugarNombre.Enabled = false;
            btnLugarUbicacion.Enabled = false;

            nudDistrCantidad.Value = nudDistrCantidad.Minimum + 5;

            distribucion = new Distribucion(30, 30);
            rbPB.Checked = true;
            DrawDistribution();

            RecargarDistribuciones();
            EnableRadioButtons();

        }
        private void btnCrearD_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty)
            {
                //if (!punto.IsEmpty)
                //{
                if (grafo.Lista.Find(vert => vert.Destino.Nombre == tbNombre.Text) == null)
                {
                    Destino dest_temp = new Destino(tbNombre.Text, punto_temp.X, punto_temp.Y);
                    grafo.AgregarVertice(dest_temp);
                    tbNombre.Text = string.Empty;
                    lblUbicacion.Text = "Ubicación: 0; 0;";
                    grafo.Guardar();
                    RecargarDestinos();
                    foreach (Viaje v in viajes.Lista)
                    {
                        if (v.Grafo != null)
                        {
                            v.Grafo.AgregarVertice(dest_temp);
                            v.Grafo.Guardar();
                        }
                    }
                    viajes.Guardar();
                    RecargarViajes();
                    ActualizarDataGridView();
                }
                else MessageBox.Show("No se pueden ingresar destinos iguales.");
                //}
                //else MessageBox.Show("El destino debe tener una ubicación en el mapa.", "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("El destino debe tener un nombre.", "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            if (estado == ESTADO_NULO)
            {
                estado = ESTADO_EDITANDO;
                foreach (Control c in pnlMapa.Controls)
                {
                    if (c is RadioButton) (c as RadioButton).Enabled = false;
                }
                pnlMapa.Enabled = true;
                pnlMapa.Controls.Add(rb_edit);
                gbConexionDestinos.Enabled = false;
                gbTodosDestinos.Enabled = false;
                gbConexiones.Enabled = false;
                pnlMapa.Cursor = Cursors.NoMove2D;
            }
        }
        private void pnlMapa_MouseMove(object sender, MouseEventArgs e)
        {
            switch (estado)
            {
                case ESTADO_EDITANDO:
                    lblUbicacion.Text = "Ubicación: " + PointToClient(MousePosition).X + ";" + PointToClient(MousePosition).Y + ";";
                    break;
                case ESTADO_EDITANDO_C:
                    lblLugarUbicacion.Text = "Ubicación: " + PointToClient(MousePosition).X + ";" + PointToClient(MousePosition).Y + ";";
                    break;
            }
            lblTestMouse.Text = "Mouse: " + PointToClient(MousePosition).X + ";" + PointToClient(MousePosition).Y + ";";
        }
        private void BtnConectarD_Click(object sender, EventArgs e)
        {
            if (cbConexOrigen.SelectedIndex >= 0 && cbConexDestino.SelectedIndex >= 0)
            {
                if (dtpConexDemora.Value.Hour != 0 || dtpConexDemora.Value.Minute != 0 || dtpConexDemora.Value.Second != 0)
                {
                    try
                    {
                        if (cbConexTrayecto.SelectedItem.ToString() != string.Empty)
                        {
                            if (cbConexOrigen.SelectedItem.ToString() != cbConexDestino.SelectedItem.ToString())
                            {
                                if (rbConexCrear.Checked)
                                {
                                    Viaje viaje = CurrentViaje(cbConexTrayecto.SelectedItem.ToString());
                                    if (viaje != null)
                                    {
                                        Vertice vD = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbConexOrigen.SelectedItem.ToString());
                                        Vertice vA = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbConexDestino.SelectedItem.ToString());
                                        if (vD != null && vA != null)
                                        {
                                            if (vD.Destino != null && vA.Destino != null)
                                            {
                                                Arco bA = vD.Lista.Find(arco => arco.Destino.Nombre == vA.Destino.Nombre);
                                                if (bA == null)
                                                {
                                                    viaje.Grafo.AgregarArco(vD.Destino, vA.Destino, dtpConexDemora.Value.ToShortTimeString(), Convert.ToDouble(nudConexPrecio.Value));
                                                    viaje.Grafo.Guardar();
                                                    viajes.Guardar();
                                                    if (cbConexOrigen.Items.Count > 0) cbConexOrigen.SelectedIndex = 0;
                                                    if (cbConexDestino.Items.Count > 0) cbConexDestino.SelectedIndex = 0;
                                                    dtpConexDemora.Value = DateTime.Today.Add(new TimeSpan(0, 0, 0));
                                                    nudConexPrecio.Value = 0;
                                                    pnlMapa.Invalidate();
                                                    ActualizarDataGridView();
                                                    //cbDestinosTrayecto.SelectedIndex = cbConexTrayecto.Items.IndexOf(cbConexTrayecto.SelectedItem.ToString());
                                                    MessageBox.Show("Conexión creada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                }
                                                else MessageBox.Show("No se pueden repetir las conexiones entre destinos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else MessageBox.Show("No se pudo ejecutar la acción.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else MessageBox.Show("Error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (rbConexModificar.Checked)
                                {
                                    Viaje viaje = CurrentViaje(cbConexTrayecto.SelectedItem.ToString());
                                    if (viaje != null)
                                    {
                                        if (cbConexConexion.SelectedItem.ToString() != string.Empty)
                                        {

                                        }
                                        else MessageBox.Show("No se ha seleccionado una conexión.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else MessageBox.Show("No pueden ser iguales los dos destinos.", "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("No hay trayectos seleccionados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("No se pudo ejecutar la acción." + Environment.NewLine + "Detalles: " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("El destino debe tener un tiempo de demora.");
            }
            else MessageBox.Show("Debe seleccionar un origen y destino.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cbOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            cbConexDestino.Items.Clear();
            Destino d = null;
            foreach (Vertice v in grafo.Lista)
            {
                if (v != null) d = v.Destino;
                cbConexDestino.Items.Add(d.Nombre);
            }
            cbConexDestino.Items.Remove(cbConexOrigen.SelectedItem);
            if (cbConexDestino.Items.Count >= 1) cbConexDestino.SelectedIndex = 0;
        }
        private void cbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(btnLugarGuardar.Enabled == true && MessageBox.Show("¿Desea guardar los cambios en el destino " + cbLugar.SelectedItem.ToString() + "?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GuardarLugar();
            }
            */
            Vertice v = grafo.Lista.Find(vert => vert.Destino.Nombre == cbLugar.SelectedItem.ToString());
            if (v != null)
            {
                tbLugarNombre.Text = cbLugar.SelectedItem.ToString();
                lblLugarUbicacion.Text = "Ubicación: " + v.Destino.X.ToString() + "; " + v.Destino.Y.ToString() + ";";
                foreach (Control c in pnlMapa.Controls)
                {
                    if (c is RadioButton)
                    {
                        (c as RadioButton).Text = string.Empty;
                        (c as RadioButton).Size = new Size(15, 15);
                        (c as RadioButton).Checked = false;
                    }
                }
                v.Destino.Boton.Checked = true;
                v.Destino.Boton.Text = v.Destino.Nombre;
                v.Destino.Boton.Size = new Size(120, 20);
                punto = new Point((int)v.Destino.X, (int)v.Destino.Y);
                punto_temp = new Point((int)v.Destino.X, (int)v.Destino.Y);

                tbLugarNombre.Enabled = true;
                btnLugarUbicacion.Enabled = true;
            }
        }
        private void tbLugarNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbLugarNombre.Text != cbLugar.SelectedItem.ToString() || punto != punto_temp)
            {
                btnLugarGuardar.Enabled = true;
            }
            else btnLugarGuardar.Enabled = false;
        }
        private void pnlMapa_MouseClick(object sender, MouseEventArgs e)
        {
            Point rb_loc = Point.Empty;
            if (estado != ESTADO_NULO)
            {
                switch (estado)
                {
                    case ESTADO_EDITANDO:
                        rb_loc = new Point(PointToClient(MousePosition).X - 5, PointToClient(MousePosition).Y - 5);
                        rb_edit.Location = rb_loc;
                        rb_edit.Checked = true;
                        rb_edit.Visible = true;
                        rb_edit.Enabled = true;
                        pnlMapa.Controls.Add(rb_edit);
                        punto_temp = PointToClient(MousePosition);
                        if (punto != punto_temp) btnDestinoEliminar.Visible = true;
                        gbTodosDestinos.Enabled = true;
                        break;
                    case ESTADO_EDITANDO_C:
                        Vertice v = grafo.Lista.Find(vfind => vfind.Destino.Nombre == cbLugar.SelectedItem.ToString());
                        if (v != null)
                        {
                            RadioButton boton = v.Destino.Boton;
                            rb_loc = new Point(PointToClient(MousePosition).X - 5, PointToClient(MousePosition).Y - 5);
                            boton.Location = rb_loc;
                            boton.Checked = true;
                            boton.Enabled = true;
                            punto_temp = PointToClient(MousePosition);
                            if (punto != punto_temp) btnLugarGuardar.Enabled = true;
                        }
                        gbCrearDestino.Enabled = true;
                        btnDestinoEliminar.Visible = true;
                        break;
                }
                pnlMapa.Enabled = true;
                foreach (Control c in pnlMapa.Controls) if (c is RadioButton) (c as RadioButton).Enabled = true;
                pnlMapa.Cursor = Cursors.Arrow;
                gbConexionDestinos.Enabled = true;
                gbConexiones.Enabled = true;
                estado = ESTADO_NULO;
            }
        }
        private void btnLugarUbicacion_Click(object sender, EventArgs e)
        {
            if (estado == ESTADO_NULO)
            {
                estado = ESTADO_EDITANDO_C;
                foreach (Control c in pnlMapa.Controls)
                {
                    if (c is RadioButton) (c as RadioButton).Enabled = false;
                }
                pnlMapa.Enabled = true;
                pnlMapa.Controls.Add(rb_edit);
                gbConexionDestinos.Enabled = false;
                gbCrearDestino.Enabled = false;
                gbConexiones.Enabled = false;
                pnlMapa.Cursor = Cursors.NoMove2D;
            }
        }
        private void btnLugarGuardar_Click(object sender, EventArgs e)
        {
            GuardarLugar();
        } 
        private void pnlMapa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (estado)
                {
                    case ESTADO_EDITANDO:
                        gbConexionDestinos.Enabled = true;
                        gbConexiones.Enabled = true;
                        gbTodosDestinos.Enabled = true;
                        pnlMapa.Cursor = Cursors.Arrow;

                        estado = ESTADO_NULO;
                        break;
                    case ESTADO_EDITANDO_C:
                        gbConexionDestinos.Enabled = true;
                        gbConexiones.Enabled = true;
                        gbCrearDestino.Enabled = true;
                        pnlMapa.Cursor = Cursors.Arrow;
                        break;
                }
            }
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            Vertice vertice = grafo.Lista.Find(vert => vert.Destino.Boton == (sender as RadioButton));
            if (vertice != null)
            {
                foreach (Control c in pnlMapa.Controls)
                {
                    if (c is RadioButton)
                    {
                        (c as RadioButton).Text = string.Empty;
                        (c as RadioButton).Size = new Size(15, 15);
                    }
                }
                RadioButton boton = vertice.Destino.Boton;
                if (boton != null)
                {
                    boton.Text = vertice.Destino.Nombre;
                    boton.Size = new Size(120, 20);
                    cbLugar.SelectedIndex = cbLugar.Items.IndexOf(vertice.Destino.Nombre);
                }
            }
        }
        private void btnDestinoEliminar_Click(object sender, EventArgs e)
        {
            punto = Point.Empty;
            lblUbicacion.Text = "Ubicación: " + punto.X.ToString() + "; " + punto.Y.ToString() + ";";
            rb_edit.Location = new Point(347, 484);
            rb_edit.BackColor = Color.Transparent;
            rb_edit.AutoSize = false;
            rb_edit.Size = new Size(100, 20);
            rb_edit.Visible = false;
            rb_edit.Text = string.Empty;
            btnDestinoEliminar.Visible = false;
        }
        private void pnlMapa_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                //g.Clear(Color.White);
                Pen lapiz = new Pen(Color.Blue, 4);
                string text = string.Empty;
                switch (tcAdmin.SelectedIndex)
                {
                    case 0:
                        text = cbViajeTrayecto.SelectedItem.ToString();
                        break;
                    case 1:
                        text = cbHorTrayecto.SelectedItem.ToString();
                        break;
                    case 2:
                        text = cbDestinosTrayecto.SelectedItem.ToString();
                        break;
                    default:
                        break;
                }
                Viaje vj = CurrentViaje(text);
                if (vj != null)
                {
                    if (vj.Grafo != null)
                    {
                        foreach (Vertice v in vj.Grafo.Lista)
                        {
                            if (v.Destino != null)
                            {
                                foreach (Arco a in v.Lista)
                                {
                                    if (a.Destino != null)
                                    {
                                        g.DrawLine(lapiz, (int)v.Destino.X, (int)v.Destino.Y, (int)a.Destino.X, (int)a.Destino.Y);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbDestinosTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                Vertice v = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == dgvConexiones.CurrentRow.Cells["Origen"].Value.ToString());
                if (v != null)
                {
                    foreach (DataGridViewRow data in dgvConexiones.SelectedRows)
                    {
                        Arco a = v.Lista.Find(arco => arco.Destino.Nombre == data.Cells["Destino"].Value.ToString());
                        v.Lista.Remove(a);
                        break;
                    }
                    MessageBox.Show("Conexiones eliminadas correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    viaje.Grafo.Guardar();
                    pnlMapa.Invalidate();
                    ActualizarDataGridView();
                }
                else MessageBox.Show("Error inesperado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No hay ningún recorrido seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnViajeCrear_Click(object sender, EventArgs e)
        {
            if (cbViajeOrigen.SelectedIndex >= 0 && cbViajeDestino.SelectedIndex > 0)
            {
                if (rbViajeCrear.Checked)
                {
                    if (dtpViajeHoraSalida.Value.ToShortTimeString() != dtpViajeHoraSalida.MinDate.ToShortTimeString())
                    {
                        if (cbViajeDistribucion.SelectedItem != null)
                        {
                            if (cbViajeDistribucion.SelectedItem.ToString() != string.Empty)
                            {
                                if (tbViajeNombre.Text != string.Empty && !viajes.Lista.Exists(v => v.Nombre == tbViajeNombre.Text))
                                {
                                    if (clbViajeFrecuencia.CheckedItems.Count > 0)
                                    {
                                        if (IsValidFileName(tbViajeNombre.Text))
                                        {
                                            Viaje v = viajes.Lista.Find(viaje => viaje.Origen.Nombre == cbViajeOrigen.SelectedItem.ToString() && viaje.Destino.Nombre == cbViajeDestino.SelectedItem.ToString());
                                            if (v == null)
                                            {
                                                Vertice vO = grafo.Lista.Find(vert => vert.Destino.Nombre == cbViajeOrigen.SelectedItem.ToString());
                                                Vertice vD = grafo.Lista.Find(vert => vert.Destino.Nombre == cbViajeDestino.SelectedItem.ToString());
                                                Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == cbViajeDistribucion.SelectedItem.ToString());
                                                if (vO.Destino != null && vD.Destino != null)
                                                {
                                                    if (d != null)
                                                    {

                                                        Destino dO = vO.Destino;
                                                        Destino dD = vD.Destino;

                                                        bool[] frecuencia = new bool[7];
                                                        for (int i = 0; i < clbViajeFrecuencia.CheckedItems.Count; i++)
                                                        {
                                                            frecuencia[clbViajeFrecuencia.CheckedIndices[i]] = true;
                                                        }
                                                        Viaje vi = new Viaje(tbViajeNombre.Text, dO, dD);
                                                        vi.Origen.Nombre = cbViajeOrigen.SelectedItem.ToString();
                                                        vi.Destino.Nombre = cbViajeDestino.SelectedItem.ToString();
                                                        vi.CrearGrafo(grafo, grafo.Directorio);
                                                        vi.AddHorario(dtpViajeHoraSalida.Value.ToShortTimeString(), frecuencia, d);
                                                        viajes.Lista.Add(vi);
                                                        viajes.Guardar();
                                                        boletos.Guardar();
                                                        RecargarViajes();
                                                    }

                                                }
                                                else MessageBox.Show("Error interno: Distribución inválida.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else MessageBox.Show("No se pueden repetir los recorridos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            /*
                                            else
                                            {
                                                Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == cbViajeDistribucion.SelectedItem.ToString());
                                                if (d != null)
                                                {
                                                    bool[] frecuencia = new bool[7];
                                                    for (int i = 0; i < clbViajeFrecuencia.CheckedItems.Count; i++)
                                                    {
                                                        frecuencia[clbViajeFrecuencia.CheckedIndices[i]] = true;
                                                    }
                                                    v.AddHorario(dtpViajeHoraSalida.Value.ToShortTimeString(), frecuencia, d);
                                                    viajes.Guardar();
                                                    RecargarViajes();
                                                }
                                                else MessageBox.Show("Error interno: Distribución inválida.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }*/

                                        }
                                        else
                                        {
                                            char[] carateres_invalidos = Path.GetInvalidFileNameChars();
                                            string string_invalidos = string.Empty;
                                            foreach (char c in carateres_invalidos)
                                            {
                                                string_invalidos += c.ToString() + ", ";
                                            }
                                            string_invalidos.TrimEnd(',');

                                            MessageBox.Show("No puedes ingresar estos caracteres:" + Environment.NewLine + string_invalidos, "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else MessageBox.Show("No hay dias seleccionados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("Este recorrido ya existe o no es válido.", "Error al crear.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("El recorrido debe tener una distribución de asientos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("No se ha creado ninguna distribución de asientos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("No se ha especificado el horario de salida para ese recorrido.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbViajeModificar.Checked)
                {
                    try
                    {
                        Viaje viaje = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
                        if (viaje != null)
                        {
                            Viaje viaje_comprobar = viajes.Lista.Find(vi => vi.Origen.Nombre == cbViajeOrigen.SelectedItem.ToString() && vi.Destino.Nombre == cbViajeDestino.SelectedItem.ToString() && vi != viaje);
                            if (viaje_comprobar == null)
                            {
                                if (!viajes.Lista.Exists(viaje_t => viaje_t.Nombre == tbViajeNombre.Text && viaje_t != viaje))
                                {
                                    Vertice vO = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbViajeOrigen.SelectedItem.ToString());
                                    Vertice vD = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbViajeDestino.SelectedItem.ToString());

                                    if (vO != null && vD != null)
                                    {
                                        if (vO.Destino != null && vD.Destino != null)
                                        {
                                            if (IsValidFileName(tbViajeNombre.Text))
                                            {
                                                foreach(Boleto b in boletos.Lista)
                                                {
                                                    if(b.Recorrido.Nombre == viaje.Nombre)
                                                    {
                                                        b.Recorrido.Nombre = tbViajeNombre.Text;
                                                    }
                                                }
                                                if (Directory.Exists(viajes.Directorio + "\\recorridos\\" + viaje.Nombre)) Directory.Delete(viajes.Directorio + "\\recorridos\\" + viaje.Nombre, true);
                                                viaje.Nombre = tbViajeNombre.Text;
                                                viaje.Origen = vO.Destino;
                                                viaje.Destino = vD.Destino;
                                                viaje.Grafo.Directorio = viajes.Directorio + "\\recorridos\\" + viaje.Nombre;
                                                viaje.Grafo.Guardar();
                                                viajes.Guardar();
                                                boletos.Guardar();
                                                RecargarDestinos();
                                                RecargarViajes();
                                                ActualizarDataGridView();
                                            }
                                            else
                                            {
                                                char[] carateres_invalidos = Path.GetInvalidFileNameChars();
                                                string string_invalidos = string.Empty;
                                                foreach (char c in carateres_invalidos)
                                                {
                                                    string_invalidos += c.ToString() + ", ";
                                                }
                                                string_invalidos.TrimEnd(',');

                                                MessageBox.Show("No puedes ingresar estos caracteres:" + Environment.NewLine + string_invalidos, "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else MessageBox.Show("Se produjo un error mientras se intentaba buscar el destino registrado.", "Error inesperado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else MessageBox.Show("Los destinos seleccionados no están registrados en ese recorrido.", "Error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("No puede haber dos recorridos con el mismo nombre.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Ya existe un recorrido con esos destinos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(NullReferenceException)
                    {
                        MessageBox.Show("Los datos ingresados no son correctos o son inválidos.", "Error inesperado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(rbViajeEliminar.Checked)
                {
                    if(MessageBox.Show("Eliminar un recorrido puede causar errores en los boletos que se hayan hecho en base al mismo." + Environment.NewLine + "¿Está seguro que desea eliminar este recorrido, sus conexiones y horarios?" + Environment.NewLine + Environment.NewLine + "Esta acción no se puede deshacer.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
                            if(v != null)
                            {
                                viajes.Eliminar(v);
                                viajes.Guardar();
                                RecargarViajes();
                                MessageBox.Show("El recorrido fue eliminado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EnableRadioButtons();
                            }
                        }
                        catch(NullReferenceException)
                        {

                        }
                    }
                }
            }
            else MessageBox.Show("No hay destinos seleccionados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void rbCrearRecorrido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbViajeCrear.Checked)
            {
                foreach (Control c in gbCrearViajes.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == "viaje_modificables" || c.Tag.ToString() == "viaje_creables")
                        {
                            c.Enabled = true;
                        }
                        else c.Enabled = false;
                    }
                }
                btnViajeCrear.Text = "Crear";
                if(cbViajeOrigen.Items.Count > 0) cbViajeDestino.SelectedIndex = 0;
                if (cbViajeDestino.Items.Count > 0) cbViajeDestino.SelectedIndex = 0;
                if (cbViajeDistribucion.Items.Count > 0) cbViajeDistribucion.SelectedIndex = 0;
                tbViajeNombre.Text = string.Empty;
                dtpViajeHoraSalida.Value = Convert.ToDateTime(DateTime.MinValue.ToShortTimeString());

                for (int i = 0; i < clbViajeFrecuencia.Items.Count; i++)
                {
                    clbViajeFrecuencia.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void rbModificarRecorrido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbViajeModificar.Checked)
                {
                    foreach (Control c in gbCrearViajes.Controls)
                    {
                        if (c.Tag != null)
                        {
                            if (c.Tag.ToString() == "viaje_creables")
                            {
                                c.Enabled = false;
                            }
                            else c.Enabled = true;
                        }
                    }
                    btnViajeCrear.Text = "Modificar";

                    Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
                    if (v != null)
                    {
                        if (cbViajeOrigen.Items.Contains(v.Origen.Nombre)) cbViajeOrigen.SelectedIndex = cbViajeOrigen.Items.IndexOf(v.Origen.Nombre);
                        if (cbViajeDestino.Items.Contains(v.Destino.Nombre)) cbViajeDestino.SelectedIndex = cbViajeDestino.Items.IndexOf(v.Destino.Nombre);
                        //if(cbViajeDistribucion.Items.Contains())
                        if (cbViajeTrayecto.Items.Count > 0) cbViajeTrayecto.SelectedIndex = cbViajeTrayecto.SelectedIndex;
                    }
                }
            }
            catch(NullReferenceException)
            {

            }
        }
        private void rbViajeEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbViajeEliminar.Checked)
            {
                foreach (Control c in gbCrearViajes.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == "no_modificables")
                        {
                            c.Enabled = true;
                        }
                        else c.Enabled = false;
                    }
                }
                btnViajeCrear.Text = "Eliminar";
            }
        }
        private void rbCrearConexion_CheckedChanged(object sender, EventArgs e)
        {
            lblConexConexion.Enabled = false;
            cbConexConexion.Enabled = false;
            btnConexConectar.Text = "Conectar";
        }
        private void rbModificarConexion_CheckedChanged(object sender, EventArgs e)
        {
            lblConexConexion.Enabled = true;
            cbConexConexion.Enabled = true;
            btnConexConectar.Text = "Modificar";
        }
        private void cbViajeOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            cbViajeDestino.Items.Clear();
            foreach (Vertice v in grafo.Lista)
            {
                if(v.Destino != null)
                cbViajeDestino.Items.Add(v.Destino.Nombre);
            }
            cbViajeDestino.Items.Remove(cbConexOrigen.SelectedItem);
            if (cbViajeDestino.Items.Count >= 1) cbViajeDestino.SelectedIndex = 0;
        }
        private void cbDestinosTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlMapa.Invalidate();
            ActualizarDataGridView();
            cbConexTrayecto.SelectedIndex = cbDestinosTrayecto.SelectedIndex;
        }
        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlMapa.Invalidate();
        }
        private void cbViajeTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (v != null)
            {
                if (cbViajeOrigen.Items.Contains(v.Origen.Nombre)) cbViajeOrigen.SelectedIndex = cbViajeOrigen.Items.IndexOf(v.Origen.Nombre);
                if (cbViajeDestino.Items.Contains(v.Destino.Nombre)) cbViajeDestino.SelectedIndex = cbViajeDestino.Items.IndexOf(v.Destino.Nombre);
                tbViajeNombre.Text = v.Nombre;
                pnlMapa.Invalidate();
            }
            
        }
        private void rbHorCrear_CheckedChanged(object sender, EventArgs e)
        {
            if(rbHorCrear.Checked)
            {
                btnHorCrear.Text = rbHorCrear.Text;
                foreach(Control c in gbHorControl.Controls)
                {
                    if(c.Tag != null)
                    {
                        if (c.Tag.ToString() == "horario_modificable")
                        {
                            c.Enabled = false;
                        }
                        else c.Enabled = true;
                    }
                }
            }
        }
        private void rbHorModificar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbHorModificar.Checked)
            {
                btnHorCrear.Text = rbHorModificar.Text;
                foreach (Control c in gbHorControl.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == "horario_modificable")
                        {
                            c.Enabled = true;
                        }
                        else c.Enabled = true;
                    }
                }
                cbHorHorarios.SelectedIndex = 0;
            }
        }
        private void rbHorEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHorEliminar.Checked)
            {
                btnHorCrear.Text = rbHorModificar.Text;
                foreach (Control c in gbHorControl.Controls)
                {
                    if (c.Tag != null)
                    {
                        if (c.Tag.ToString() == "horario_modificable")
                        {
                            c.Enabled = true;
                        }
                        else c.Enabled = false;
                    }
                }
            }
        }
        private void cbHorTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecargarListaHorarios();
            pnlMapa.Invalidate();
        }
        private void cbHorHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbHorModificar.Checked)
            {
                Viaje viaje = CurrentViaje(cbHorTrayecto.SelectedItem.ToString());
                if(viaje != null)
                {
                    Horario h = viaje.ListaHorarios.Find(horario => horario.Hora == cbHorHorarios.SelectedItem.ToString());
                    if(h != null)
                    {
                        dtpHorHora.Value = DateTime.Parse(h.Hora);
                        for (int i = 0; i < clbHorFrecuencia.Items.Count; i++)
                        {
                            if (h.Frecuencia[i]) clbHorFrecuencia.SetItemCheckState(i, CheckState.Checked);
                        }
                        cbHorDistr.SelectedIndex = cbHorDistr.Items.IndexOf(h.Distribucion.Nota);
                    }
                }
            }
        }
        private void cbConexTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbConexTrayecto.SelectedItem.ToString());
            if(viaje != null)
            {
                cbConexConexion.Items.Clear();
                foreach (Vertice v in viaje.Grafo.Lista)
                {
                    if (v.Destino != null)
                    {
                        foreach (Arco a in v.Lista)
                        {
                            cbConexConexion.Items.Add(v.Destino.Nombre + " - " + a.Destino.Nombre);
                            cbConexConexion.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
        private void cbConexConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbConexModificar.Checked)
            {
                Viaje viaje = CurrentViaje(cbConexTrayecto.SelectedItem.ToString());
                if (viaje != null)
                {
                    if (viaje.Grafo != null)
                    {
                        string[] conexion = cbConexConexion.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.None);
                        string origen = conexion[0];
                        string destino = conexion[1];
                        cbConexOrigen.SelectedIndex = cbConexOrigen.Items.IndexOf(origen);
                        cbConexDestino.SelectedIndex = cbConexDestino.Items.IndexOf(destino);
                        Vertice v = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
                        if (v != null)
                        {
                            Arco a = v.Lista.Find(arco => arco.Destino.Nombre == destino);
                            if (a != null)
                            {
                                dtpConexDemora.Value = DateTime.Parse(a.Demora);
                                nudConexPrecio.Value = Convert.ToDecimal(a.Precio);
                            }
                        }
                    }
                }
            }
        }
        private void btnHorDistr_Click(object sender, EventArgs e)
        {
            frmAsientos form = new frmAsientos(distribuciones);
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }
        private void btnHorCrear_Click(object sender, EventArgs e)
        {
            if (cbHorTrayecto.SelectedItem != null)
            {
                Viaje v = CurrentViaje(cbHorTrayecto.SelectedItem.ToString());
                if (v != null)
                {
                    if (rbHorCrear.Checked)
                    {
                        if (dtpHorHora.Value.ToShortTimeString() != dtpHorHora.MinDate.ToShortTimeString())
                        {
                            if (clbHorFrecuencia.CheckedItems.Count > 0)
                            {
                                if (cbHorDistr.SelectedItem != null)
                                {
                                    if (cbHorDistr.SelectedItem.ToString() != string.Empty)
                                    {
                                        if (!v.ListaHorarios.Exists(horario => horario.Hora == dtpHorHora.Value.ToShortTimeString()))
                                        {
                                            bool[] frecuencia = new bool[7];
                                            for (int i = 0; i < clbHorFrecuencia.CheckedItems.Count; i++)
                                            {
                                                frecuencia[clbHorFrecuencia.CheckedIndices[i]] = true;
                                            }

                                            Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == cbHorDistr.SelectedItem.ToString());
                                            if (d != null)
                                            {
                                                v.AddHorario(dtpHorHora.Value.ToShortTimeString(), frecuencia, d);
                                                MessageBox.Show("Horario agregado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                viajes.Guardar();
                                                RecargarListaHorarios();
                                            }
                                            else MessageBox.Show("Error inesperado: No se logró encontrar la distribución seleccionada.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else MessageBox.Show("No se puede crear dos horarios iguales.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else MessageBox.Show("No se ha seleccionado ninguna distribución de asientos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Debe haber como minimo un día seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("No se ha especificado una hora.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbHorModificar.Checked)
                    {
                        if (dtpHorHora.Value.ToShortTimeString() != "00:00:00")
                        {
                            if (clbHorFrecuencia.CheckedItems.Count > 0)
                            {
                                if (cbHorDistr.SelectedItem != null)
                                {
                                    if (cbHorDistr.SelectedItem.ToString() != string.Empty)
                                    {
                                        try
                                        {
                                            Horario h = v.ListaHorarios.Find(horario => horario.Hora == cbHorHorarios.SelectedItem.ToString());
                                            if (h != null)
                                            {
                                                Distribucion d = distribuciones.Lista.Find(distr => distr.Nota == cbHorDistr.SelectedItem.ToString());
                                                bool[] frecuencia = new bool[7];
                                                for (int i = 0; i < clbHorFrecuencia.CheckedItems.Count; i++)
                                                {
                                                    frecuencia[clbHorFrecuencia.CheckedIndices[i]] = true;
                                                }

                                                if (d != null)
                                                {
                                                    h.Hora = dtpHorHora.Value.ToShortTimeString();
                                                    h.Frecuencia = frecuencia;
                                                    h.Distribucion = d;

                                                    viajes.Guardar();
                                                    RecargarListaHorarios();
                                                    MessageBox.Show("Horario modificado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else MessageBox.Show("Error inesperado: No se logró encontrar la distribución seleccionada.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else MessageBox.Show("Error inesperado: No se pudo encontrar en la lista el horario seleccionado.", "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        catch (NullReferenceException)
                                        {

                                        }
                                    }
                                }
                                else MessageBox.Show("No se ha seleccionado ninguna distribución de asientos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Debe haber como minimo un día seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("No se ha especificado una hora.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbHorEliminar.Checked)
                    {
                        if(cbHorHorarios.SelectedItem != null)
                        {
                            if (cbHorHorarios.SelectedItem.ToString() != string.Empty)
                            {
                                Horario h = v.ListaHorarios.Find(horario => horario.Hora == cbHorHorarios.SelectedItem.ToString());
                                if (h != null)
                                {
                                    if (MessageBox.Show("Eliminar horarios puede provocar errores en los boletos que se hayan creado con ese horario." + Environment.NewLine + "¿Está seguro que quiere eliminar este horario?" + Environment.NewLine + Environment.NewLine + "Esta acción no se puede deshacer.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        v.RemoveHorario(h);
                                        viajes.Guardar();
                                        RecargarListaHorarios();
                                        MessageBox.Show("El horario fue eliminado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else MessageBox.Show("Error inesperado: No se pudo encontrar el horario especificado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else MessageBox.Show("Error inesperado: No se pudo encontrar ese viaje.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No hay ningun recorrido seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvAsientos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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
        private void nudDistrCantidad_ValueChanged(object sender, EventArgs e)
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
        private void cbDistrPisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDistrPisos.SelectedIndex)
            {
                case 0:
                    rbPB.Checked = true;
                    rbPA.Enabled = false;
                    if (distribucion != null)
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
            if (rbDistrCrear.Checked)
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
            else if (rbDistrMod.Checked)
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
        private void rbDistrMod_CheckedChanged(object sender, EventArgs e)
        {
            cbDistrDistribucion.Enabled = true;
            lblDistr.Enabled = true;
            btnDistrCrear.Text = "Modificar";
            if (cbDistrDistribucion.Items.Count > 0) cbDistrDistribucion.SelectedIndex = 0;
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
        private void rbDistrCrear_CheckedChanged(object sender, EventArgs e)
        {
            btnDistrCrear.Text = "Crear";
            cbDistrDistribucion.Enabled = false;
            lblDistr.Enabled = false;
            tbNota.Text = string.Empty;
            distribucion = new Distribucion(30, 30);
            DrawDistribution();
        }

        private string GetDayStringFromIndex(int i)
        {
            switch(i)
            {
                case 0: return "Lun";
                case 1: return "Mar";
                case 2: return "Mie";
                case 3: return "Jue";
                case 4: return "Vie";
                case 5: return "Sab";
                case 6: return " Dom";
                default: return "Error.";
            }
        }
        private Distribucion CurrentDistribucion(string text)
        {
            return distribuciones.Lista.Find(distr => distr.Nota == text);
        }
        private void ActualizarDataGridView()
        {
            Viaje viaje = CurrentViaje(cbDestinosTrayecto.SelectedItem.ToString());
            dgvConexiones.Rows.Clear();
            if (viaje != null)
            {
                if (viaje.Grafo != null)
                {
                    foreach (Vertice v in viaje.Grafo.Lista)
                    {
                        foreach (Arco a in v.Lista)
                        {
                            dgvConexiones.Rows.Add(v.Destino.Nombre, a.Destino.Nombre, a.Demora, a.Precio);
                        }
                    }
                }
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
        private void RecargarDistribuciones()
        {
            cbHorDistr.Items.Clear();
            cbViajeDistribucion.Items.Clear();
            cbDistrDistribucion.Items.Clear();
            foreach (Distribucion d in distribuciones.Lista)
            {
                cbHorDistr.Items.Add(d.Nota);
                cbViajeDistribucion.Items.Add(d.Nota);
                cbHorDistr.SelectedIndex = 0;
                cbDistrDistribucion.Items.Add(d.Nota);
                rbDistrMod.Enabled = true;
                cbDistrDistribucion.SelectedIndex = 0;
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
                catch (ArgumentOutOfRangeException)
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
        private Viaje CurrentViaje(string text)
        {
            foreach (Viaje v in viajes.Lista) if (v.Nombre == text) return v;                         
            return null;
        }
        private void RecargarViajes()
        {
            cbViajeTrayecto.Items.Clear();
            cbConexTrayecto.Items.Clear();
            cbDestinosTrayecto.Items.Clear();
            cbHorTrayecto.Items.Clear();
            foreach(Viaje viaje in viajes.Lista)
            {
                cbViajeTrayecto.Items.Add(viaje.Nombre);
                cbViajeTrayecto.SelectedIndex = 0;
                cbConexTrayecto.Items.Add(viaje.Nombre);
                cbConexTrayecto.SelectedIndex = 0;
                cbDestinosTrayecto.Items.Add(viaje.Nombre);
                cbDestinosTrayecto.SelectedIndex = 0;
                cbHorTrayecto.Items.Add(viaje.Nombre);
                cbHorTrayecto.SelectedIndex = 0;
            }
            if(viajes.Lista.Count <= 0)
            {
                rbViajeModificar.Enabled = false;
                rbViajeCrear.Checked = true;
                gbConexionDestinos.Enabled = false;
                gbHorControl.Enabled = false;
                gbHorHorarios.Enabled = false;
                gbHorRecorridos.Enabled = false;
            }
            else
            {
                rbConexModificar.Enabled = true;
                gbConexionDestinos.Enabled = true;
                gbHorControl.Enabled = true;
                gbHorHorarios.Enabled = true;
                gbHorRecorridos.Enabled = true;
            }
        }
        private void RecargarDestinos()
        {
            cbViajeOrigen.Items.Clear();
            cbViajeDestino.Items.Clear();
            cbConexOrigen.Items.Clear();
            cbConexDestino.Items.Clear();
            cbLugar.Items.Clear();
            grafo.Cargar();
            foreach (Control c in pnlMapa.Controls) { pnlMapa.Controls.Clear(); }
            rb_edit = new RadioButton
            {
                Anchor = pnlMapa.Anchor,
                Location = new Point(347, 484),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(100, 20),
                Visible = false,
                Text = string.Empty
            };

            foreach (Vertice v in grafo.Lista)
            {
                if (v.Destino != null)
                {
                    cbConexOrigen.Items.Add(v.Destino.Nombre);
                    cbViajeOrigen.Items.Add(v.Destino.Nombre);
                    cbLugar.Items.Add(v.Destino.Nombre);
                    cbConexOrigen.SelectedIndex = 0;
                    cbViajeOrigen.SelectedIndex = 0;
                    RadioButton rb = new RadioButton
                    {
                        Location = new Point((int)v.Destino.X - 5, (int)v.Destino.Y - 5),
                        BackColor = Color.Transparent,
                        AutoSize = false,
                        Size = new Size(15, 15),
                        Text = string.Empty
                    };
                    v.Destino.Boton = rb;
                    rb.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                    pnlMapa.Controls.Add(rb);

                    v.Destino.Boton = rb;
                }
            }
            cbConexDestino.Items.Remove(cbConexOrigen.SelectedItem);
            if (cbConexDestino.Items.Count >= 1) cbConexDestino.SelectedIndex = 0;
            cbViajeDestino.Items.Remove(cbViajeOrigen.SelectedItem);
            if (cbViajeDestino.Items.Count > 0) cbViajeDestino.SelectedIndex = 0;
            if (cbViajeDistribucion.Items.Count > 0) cbViajeDistribucion.SelectedIndex = 0;
            pnlMapa.Invalidate();
        }    
        private void GuardarLugar()
        {
            string text = cbLugar.SelectedItem.ToString();
            Vertice v = grafo.Lista.Find(vert => vert.Destino.Nombre == text);
            Destino d = null;
            List<Destino> destinos_reemplazar = new List<Destino>();
            destinos_reemplazar.Clear();
            if (v != null)
            {
                d = v.Destino;
                if(d != null)
                {
                    Vertice v_temp = grafo.Lista.Find(vert => vert.Destino.Nombre == tbLugarNombre.Text && vert.Destino.Nombre != text);
                    if (v_temp == null)
                    {
                        destinos_reemplazar.Add(d);

                        foreach(Vertice vert in grafo.Lista)
                        {
                            if (vert.Destino.Nombre == text) destinos_reemplazar.Add(vert.Destino);
                            foreach(Arco a in vert.Lista)
                            {
                                if (a.Destino.Nombre == text) destinos_reemplazar.Add(vert.Destino);
                            }
                        }

                        foreach (Viaje viaje in viajes.Lista)
                        {
                            if (viaje.Grafo != null)
                            {
                                if (viaje.Origen.Nombre == text) destinos_reemplazar.Add(viaje.Origen);
                                if (viaje.Destino.Nombre == text) destinos_reemplazar.Add(viaje.Destino);
                                foreach(Vertice vert in viaje.Grafo.Lista)
                                {
                                    if (vert.Destino != null)
                                    {
                                        if(vert.Destino.Nombre == text)
                                        destinos_reemplazar.Add(vert.Destino);

                                        foreach(Arco a in vert.Lista)
                                        {
                                            if (a.Destino.Nombre == text) destinos_reemplazar.Add(a.Destino);
                                        }
                                    }
                                }                                
                            }
                        }

                        foreach(Boleto b in boletos.Lista)
                        {
                            if (b.Origen.Nombre == text) destinos_reemplazar.Add(b.Origen);
                            if (b.Destino.Nombre == text) destinos_reemplazar.Add(b.Destino);
                        }

                        foreach(Destino dest in destinos_reemplazar)
                        {
                            dest.Nombre = tbLugarNombre.Text;
                            dest.X = punto_temp.X;
                            dest.Y = punto_temp.Y;
                        }
                        grafo.Guardar();
                        viajes.Guardar();
                        boletos.Guardar();

                        RecargarDestinos();
                        RecargarViajes();
                        ActualizarDataGridView();
                        btnLugarGuardar.Enabled = false;
                    }
                    else MessageBox.Show("No se puede usar un nombre ya existente.", "Error de sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RecargarListaHorarios()
        {
            Viaje viaje = CurrentViaje(cbHorTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                cbHorHorarios.Items.Clear();
                dgvHorHorarios.Rows.Clear();
                foreach (Horario h in viaje.ListaHorarios)
                {
                    if (h.Hora != string.Empty)
                    {
                        cbHorHorarios.Items.Add(h.Hora);
                        cbHorHorarios.SelectedIndex = 0;
                        string dias = "";
                        for (int i = 0; i < 7; i++)
                        {
                            if (h.Frecuencia[i]) dias += GetDayStringFromIndex(i) + " - ";
                        }

                        dgvHorHorarios.Rows.Add(h.Hora + " hs.", h.Distribucion.Nota, dias);
                    }
                }
            }
        }
        private void EnableRadioButtons()
        {
            if (viajes.Lista.Count > 0)
            {
                rbViajeCrear.Enabled = true;
                rbViajeModificar.Enabled = true;
                rbViajeEliminar.Enabled = true;
            }
            else
            {
                rbViajeCrear.Enabled = true;
                rbViajeEliminar.Enabled = false;
                rbViajeModificar.Enabled = false;
                rbViajeCrear.Checked = true;
            }
        }
        private bool IsValidFileName(string file_name)
        {
            char[] carateres_invalidos = Path.GetInvalidFileNameChars();
            foreach(char c in carateres_invalidos)
            {
                if (file_name.Contains(c)) return false;                
            }
            return true;
        }

        private void tbViajeNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
