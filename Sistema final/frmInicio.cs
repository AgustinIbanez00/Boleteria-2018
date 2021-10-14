using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Clases;

namespace Sistema_final
{
    public partial class frmPrincipal : Form
    {
        string directory = "C:\\trabajo final\\datos\\";
        Clientes clientes;
        Grafo grafo;
        Viajes viajes;
        Distribuciones distribuciones;
        Boletos boletos;
        Pagos pagos;

        public frmPrincipal(string directory)
        {
            InitializeComponent();
            grafo = new Grafo(directory, "\\lugares.dat", "\\conexiones.dat");
            distribuciones = new Distribuciones(directory);
            clientes = new Clientes(directory);
            viajes = new Viajes(grafo, distribuciones, directory);
            pagos = new Pagos(directory);
            boletos = new Boletos(directory, pagos, viajes, clientes);
        }

        Cuenta cuentaUso;
        Cuentas cuentas;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            grafo.Cargar();
            distribuciones.Cargar();
            clientes.Cargar();
            viajes.Cargar();
            pagos.Cargar();
            boletos.Cargar();

            try
            {
                RecargarViajes();
                RecargarBoletos();
                dtpFechaIda.MinDate = DateTime.Now;
                dtpFechaIda.MaxDate = DateTime.Now.AddMonths(5);
                dtpFechaVuelta.MinDate = DateTime.Now;
                dtpFechaVuelta.MaxDate = DateTime.Now.AddMonths(5);

                if (cbBoleto.Items.Count > 0) cbBoleto.SelectedIndex = 0;
                if (cbTrayecto.Items.Count > 0) cbTrayecto.SelectedIndex = 0;
                rbFiltrosRecorrido.Checked = true;
                rbPasajero.Checked = true;

                ActualizarListaPasajeros();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error interno", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMasOrigen_Click(object sender, EventArgs e)
        {
            frmDestinos form = new frmDestinos(directory, grafo, viajes, boletos, distribuciones);
            if (form.ShowDialog() != DialogResult.None)
            {
                try
                {
                    RecargarViajes();
                    boletos.Guardar();
                    RecargarBoletos();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Los nuevos destinos se cargarán al volver a abrir el menú para reservar pasajes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnMasAsientos_Click(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                Horario h = viaje.ListaHorarios[cbHoraSalidaIda.SelectedIndex];
                if (h != null)
                {
                    frmAsientosSelect form = new frmAsientosSelect(h.Distribucion, boletos, viaje, dtpFechaIda.Value.ToShortDateString(), h.Hora.ToString(), cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.butaca > 0)
                        {
                            tbAsientoIda.Text = ((int)form.butaca).ToString();
                        }
                    }
                }
                else MessageBox.Show("Error inesperado: Horario inválido.", "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No hay ningún viaje seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnMasPasajeros_Click(object sender, EventArgs e)
        {
            frmPasaje form = new frmPasaje(directory, clientes, boletos);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cbPasNombre.Text = form.dgvPasajeros.CurrentRow.Cells["Nombre"].Value.ToString();
                cbPasDNI.Text = form.dgvPasajeros.CurrentRow.Cells["DNI"].Value.ToString();
            }
            RecargarBoletos();
            ActualizarListaPasajeros();
        }
        private void btnVender_Click_1(object sender, EventArgs e)
        {
            if (cbPasNombre.Text != string.Empty)
            {
                if (cbPasDNI.Text != string.Empty)
                {
                    if (cbOrigen.SelectedItem.ToString() != string.Empty && cbDestino.SelectedItem.ToString() != string.Empty)
                    {
                        if (cbOrigen.Enabled && cbDestino.Enabled)
                        {
                            if (cbHoraSalidaIda.SelectedItem.ToString() != string.Empty)
                            {
                                if (tbAsientoIda.Text != string.Empty)
                                {
                                    Viaje v = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                                    if (v != null)
                                    {
                                        Vertice vO = v.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbOrigen.SelectedItem.ToString());
                                        Vertice vD = v.Grafo.Lista.Find(vert => vert.Destino.Nombre == cbDestino.SelectedItem.ToString());
                                        if (vO != null && vD != null)
                                        {
                                            if (vO.Destino != null && vD.Destino != null)
                                            {
                                                Cliente c = clientes.Lista.Find(cliente => cliente.Nombre == cbPasNombre.Text && cliente.DNI == cbPasDNI.Text);
                                                if (c != null)
                                                {
                                                    if (boletos.Lista.Find(boleto => boleto.Recorrido == v && boleto.Asiento == Convert.ToInt32(tbAsientoIda.Text) && boleto.Fecha == dtpFechaIda.Value.ToShortDateString() && boleto.HoraSalida == cbHoraSalidaIda.SelectedItem.ToString() && boleto.HoraLlegada == dtpHoraLlegadaIda.Value.ToShortTimeString()) == null)
                                                    {
                                                        DateTime tiempo = ObtenerTiempo(v, vO.Destino.Nombre, vD.Destino.Nombre);
                                                        Boleto b = new Boleto(v, vO.Destino, vD.Destino, c, Convert.ToInt32(tbAsientoIda.Text), dtpFechaIda.Value.ToShortDateString(), ObtenerPrecio(v, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString()).ToString(), v.ListaHorarios[cbHoraSalidaIda.SelectedIndex].Hora.ToString(), cbHoraSalidaIda.SelectedItem.ToString(), dtpHoraLlegadaIda.Value.ToShortTimeString());
                                                        boletos.Add(b);
                                                        boletos.Guardar();
                                                        RecargarBoletos();
                                                        cbPasNombre.Text = string.Empty;
                                                        cbPasDNI.Text = string.Empty;
                                                        dtpFechaIda.Value = DateTime.Now;
                                                        MessageBox.Show("Boleto creado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    else MessageBox.Show("Ya hay un boleto con esa información.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else MessageBox.Show("Ese pasajero no se encuentra registrado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else MessageBox.Show("Error al intentar buscar los destinos seleccionados.", "Error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else MessageBox.Show("Error inesperado: No se encontraron los destinos en la lista.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else MessageBox.Show("No hay recorridos seleccionados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("No se ha seleccionado una butaca.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("No hay un horario de salida seleccionado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("No se puede vender boletos para ese día.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("No se han completados los datos de origen y destino.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No se puede vender boletos con algunos campos vacíos." + Environment.NewLine + "Campos requeridos:" + Environment.NewLine + "* Nombre" + Environment.NewLine + "*DNI", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No se puede vender boletos con algunos campos vacíos." + Environment.NewLine + "Campos requeridos:" + Environment.NewLine + "* Nombre", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cbOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbTrayecto.SelectedIndex >= 0)
                {
                    Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                    if (viaje != null)
                    {
                        Vertice v = grafo.Lista.Find(vert => vert.Destino.Nombre == viaje.Origen.Nombre);
                        if (v != null && viaje != null)
                        {
                            List<string> siguientes = new List<string>();
                            MostrarSiguientes(viaje, siguientes, cbOrigen.SelectedItem.ToString(), viaje.Destino.Nombre);
                            cbDestino.Items.Clear();
                            foreach (var s in siguientes)
                            {
                                cbDestino.Items.Add(s);
                            }
                            cbDestino.Items.Add(viaje.Destino.Nombre);

                            //DateTime tiempo_llegada = ObtenerTiempo(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());

                            cbHoraSalidaIda.Items.Clear();
                            DateTime tiempo = ObtenerTiempo(viaje, viaje.Origen.Nombre, cbOrigen.SelectedItem.ToString());
                            DateTime horarios = DateTime.MinValue;
                            foreach (Horario h in viaje.ListaHorarios)
                            {
                                if (h.Hora != string.Empty)
                                {
                                    horarios = DateTime.Parse(h.Hora);
                                    horarios = DateTime.Parse(horarios.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());
                                    cbHoraSalidaIda.Items.Add(horarios.ToShortTimeString());
                                    cbHoraSalidaIda.SelectedIndex = 0;
                                }
                            }
                            tbAsientoIda.Text = string.Empty;

                            if (cbDestino.Items.Count > 0) cbDestino.SelectedIndex = 0;
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay un recorridos registrados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            if (cbTrayecto.SelectedIndex >= 0)
            {
                Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                if (viaje != null)
                {
                    if (viaje.Origen.Nombre != string.Empty && viaje.Destino.Nombre != string.Empty)
                    {
                        if (viaje != null)
                            AgregarArcosR(viaje, lista, viaje.Origen.Nombre, viaje.Destino.Nombre);
                    }

                    cbHoraSalidaIda.Items.Clear();
                    foreach (Horario h in viaje.ListaHorarios)
                    {
                        if (h.Hora != string.Empty)
                        {
                            DayOfWeek dia = dtpFechaIda.Value.DayOfWeek;
                            if (h.Frecuencia[GetDayOfWeekIndex(dia)] == true)
                            {
                                cbHoraSalidaIda.Items.Add(h.Hora);
                            }
                        }
                    }

                    RecargarBoletos();

                    if (cbHoraSalidaIda.Items.Count > 0) cbHoraSalidaIda.SelectedIndex = 0;
                    cbOrigen.Items.Clear();
                    cbDestino.Items.Clear();
                    foreach (var a in lista) { cbOrigen.Items.Add(a); cbDestino.Items.Add(a); }
                    if (cbOrigen.Items.Contains(viaje.Destino.Nombre)) cbOrigen.Items.Remove(viaje.Destino.Nombre);
                    if (cbOrigen.Items.Count > 0) cbOrigen.SelectedIndex = 0;
                    if (cbDestino.Items.Count > 0) cbDestino.SelectedIndex = 0;
                    cbOrigen.SelectedIndex = cbOrigen.Items.IndexOf(viaje.Origen.Nombre);
                    cbDestino.SelectedIndex = cbDestino.Items.IndexOf(viaje.Destino.Nombre);

                    dtpFechaIda.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("No hay recorridos registrados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cbDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                if (viaje != null)
                {
                    DateTime tiempo = ObtenerTiempo(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                    DateTime hora_ad = DateTime.Parse(cbHoraSalidaIda.SelectedItem.ToString());

                    hora_ad = DateTime.Parse(hora_ad.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());

                    dtpHoraLlegadaIda.Value = hora_ad;

                    tbAsientoIda.Text = string.Empty;

                    lblPrecio.Text = "Precio: $" + ObtenerPrecio(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                }
            }
            catch (NullReferenceException)
            {

            }
        }
        private void cbHoraSalidaIda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                try
                {
                    DateTime tiempo = ObtenerTiempo(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                    DateTime hora_ad = DateTime.Parse(cbHoraSalidaIda.SelectedItem.ToString());

                    hora_ad = DateTime.Parse(hora_ad.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());

                    dtpHoraLlegadaIda.Value = hora_ad;

                    tbAsientoIda.Text = string.Empty;
                }
                catch (NullReferenceException)
                {

                }
            }
        }
        private void dtpFechaIda_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbTrayecto.SelectedItem != null)
                {
                    Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                    if (viaje != null)
                    {
                        cbHoraSalidaIda.Items.Clear();
                        //dtpFechaIda.Value = DateTime.Parse(DateTime.MinValue.Add(new TimeSpan(0, 0, 0)).ToShortTimeString());
                        foreach (Horario h in viaje.ListaHorarios)
                        {
                            if (h.Hora != string.Empty)
                            {
                                DayOfWeek dia = dtpFechaIda.Value.DayOfWeek;
                                DateTime tiempo = ObtenerTiempo(viaje, viaje.Origen.Nombre, cbOrigen.SelectedItem.ToString());
                                DateTime horarios = DateTime.MinValue;
                                if (h.Frecuencia[GetDayOfWeekIndex(dia)] == true)
                                {
                                    horarios = DateTime.Parse(h.Hora);
                                    horarios = DateTime.Parse(horarios.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());
                                    cbHoraSalidaIda.Items.Add(horarios.ToShortTimeString());
                                    cbHoraSalidaIda.SelectedIndex = 0;
                                    EnableControls();
                                }
                                else DisableControls();
                            }
                        }
                    }
                }
            }
            catch(NullReferenceException)
            {

            }
        }
        private void rbFiltroTodos_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void rbFiltrosDiaHoy_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void rbFiltrosPendientes_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void rbFiltrosVendidos_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void rbFiltrosRecorrido_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void rbFiltrosExpirados_CheckedChanged(object sender, EventArgs e)
        {
            RecargarBoletos();
        }
        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dgvBoletos.SelectedRows)
                {
                    if (row.Cells["Estado"].Value.ToString() != "VENDIDO")
                    {
                        if (row.Cells["Estado"].Value.ToString() != "EXPIRADO" && row.Cells["Estado"].Value.ToString() != "CANCELADO")
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            Boleto b = boletos.Lista.Find(boleto => boleto.ID == id);
                            Viaje v = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                            if (v != null)
                            {
                                if (b != null)
                                {
                                    frmMetodoDePago frm = new frmMetodoDePago(ObtenerPrecio(v, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString()), b);
                                    if (frm.ShowDialog() == DialogResult.OK)
                                    {
                                        if (frm.pago != null)
                                        {
                                            b.Estado = "VENDIDO";
                                            pagos.Lista.Add(frm.pago);
                                            b.Pago = frm.pago;
                                            b.Pago.Boleto = b.ID;
                                            boletos.Guardar();
                                            pagos.Guardar();
                                            RecargarBoletos();
                                        }
                                    }
                                    break;
                                }
                                else MessageBox.Show("Error interno.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("No se ha seleccionado ningún recorrido.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Este boleto ya está expirado o fue cancelado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Ese boleto ya está vendido.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Ocurrió un error inesperado." + Environment.NewLine + "Detalles del error: " + ex.Message, "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBoletos.SelectedRows)
            {
                if (row.Cells["Estado"].Value.ToString() != "CANCELADO")
                {
                    if (row.Cells["Estado"].Value.ToString() != "EXPIRADO")
                    {
                        if (MessageBox.Show("¿Estás seguro de cancelar este boleto?" + Environment.NewLine + "Tendrás que esperar un tiempo para volver a habilitarlo.", "Dar de baja un boleto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            Boleto b = boletos.Lista.Find(boleto => boleto.ID == id);
                            if (b != null)
                            {
                                b.Estado = "CANCELADO";
                                boletos.Guardar();
                                RecargarBoletos();
                                MessageBox.Show("El boleto fue cancelado correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else MessageBox.Show("Error interno.", "Error fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MessageBox.Show("Este boleto ya expiró.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Ese boleto ya está cancelado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnBuscarPasajeros_Click(object sender, EventArgs e)
        {
            BuscarPasajeros();
        }
        private void cbPasNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPasajeros();
            }
        }
        private void cbPasDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPasajeros();
            }
        }
        private void cbPasDNI_KeyPress(object sender, KeyPressEventArgs e)
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
        private void cbViajeTrayecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (v != null)
            {
                cbViajeHoraSalida.Items.Clear();
                foreach (Horario h in v.ListaHorarios)
                {
                    if (h.Hora != string.Empty)
                    {
                        cbViajeHoraSalida.Items.Add(h.Hora);
                    }
                }
            }
                if (cbViajeHoraSalida.Items.Count > 0) cbViajeHoraSalida.SelectedIndex = 0;
            rbPB.Checked = true;
        }
        private void cbViajeHoraSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                Horario h = viaje.ListaHorarios.Find(horario => horario.Hora == cbViajeHoraSalida.SelectedItem.ToString());
                if (h != null)
                {
                    for (int i = 0; i < clbViajeFrecuencia.Items.Count; i++)
                    {
                        if (h.Frecuencia[i]) clbViajeFrecuencia.SetItemCheckState(i, CheckState.Checked);
                        else clbViajeFrecuencia.SetItemCheckState(i, CheckState.Unchecked);
                    }
                    DrawDistribution(h.Distribucion);           
                    RecargarDataGridView();
                }
            }
        }
        private void rbViajesHorarios_CheckedChanged(object sender, EventArgs e)
        {
            pnlViajeHorariosTodos.Visible = true;
            ActualizarDataGridView();
            RecargarDataGridView();
        }
        private void rbViajesPrecios_CheckedChanged(object sender, EventArgs e)
        {
            pnlViajeHorariosTodos.Visible = false;
            ActualizarDataGridView();
            RecargarDataGridView();
        }
        private void rbPB_CheckedChanged(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                Horario h = viaje.ListaHorarios.Find(horario => horario.Hora == cbViajeHoraSalida.SelectedItem.ToString());
                if (h != null)
                {
                    DrawDistribution(h.Distribucion);
                }
            }
        }
        private void rbPA_CheckedChanged(object sender, EventArgs e)
        {
            Viaje viaje = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (viaje != null)
            {
                Horario h = viaje.ListaHorarios.Find(horario => horario.Hora == cbViajeHoraSalida.SelectedItem.ToString());
                if (h != null)
                {
                    DrawDistribution(h.Distribucion);
                }
            }
        }
        //METODOS PARTICULARES

        public void SyncAccounts(Cuenta cuentaUso, Cuentas cuentas)
        {
            this.cuentaUso = cuentaUso;
            this.cuentas = cuentas;
        }
        private void AgregarArcosR(Viaje viaje, List<string> listaR, string destino, string destino_final)
        {
            Vertice v = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
            Vertice vf = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino_final);

            if (v != null && vf != null)
            {
                if (!listaR.Contains(destino)) listaR.Add(destino);
                foreach (Arco a in v.Lista)
                {
                    if (a.Destino != null && a.Destino.Nombre != destino_final)
                    {
                        AgregarArcosR(viaje, listaR, a.Destino.Nombre, destino_final);
                    }
                    if (a.Destino.Nombre == destino_final) listaR.Add(destino_final);
                    break;
                }

            }
        }
        private void MostrarSiguientes(Viaje viaje, List<string> list, string origen, string destino)
        {
            MostrarSiguientesR(viaje, list, origen, destino);
        }
        internal void MostrarSiguientesR(Viaje viaje, List<string> list, string origen, string destino)
        {
            Vertice vO = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
            Vertice vD = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
            if (vO != null && vD != null)
            {
                foreach (Arco a in vO.Lista)
                {
                    if (a.Destino != null)
                    {
                        if (a.Destino.Nombre != destino)
                        {
                            list.Add(a.Destino.Nombre);
                            MostrarSiguientesR(viaje, list, a.Destino.Nombre, destino);
                        }
                    }
                }
            }
        }
        private int ObtenerPrecio(Viaje viaje, string origen, string destino)
        {
            int precio = 0;
            List<int> precios = new List<int>();
            ObtenerPrecioR(viaje, precios, origen, destino);
            foreach (int var in precios)
            {
                precio += var;
            }
            return precio;
        }
        internal void ObtenerPrecioR(Viaje viaje, List<int> precio, string origen, string destino)
        {
            Vertice vO = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
            Vertice vD = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
            if (vO != null && vD != null)
            {
                foreach (Arco a in vO.Lista)
                {
                    if (a.Destino != null)
                    {
                        precio.Add(Convert.ToInt32(a.Precio));
                        if (a.Destino.Nombre != destino)
                            ObtenerPrecioR(viaje, precio, a.Destino.Nombre, destino);
                    }
                }
            }
        }
        private DateTime ObtenerTiempo(Viaje viaje, string origen, string destino)
        {
            DateTime dt = DateTime.MinValue;
            if (origen != destino)
            {
                List<string> list = new List<string>();
                ObtenerTiempoR(viaje, list, origen, destino);

                foreach (var a in list)
                {
                    string[] tiempo = a.Split(':');
                    int hora = Convert.ToInt32(tiempo[0]);
                    int minuto = Convert.ToInt32(tiempo[1]);
                    dt = DateTime.Parse(dt.Add(new TimeSpan(hora, minuto, 0)).ToShortTimeString());
                }
            }
            return dt;
        }
        internal void ObtenerTiempoR(Viaje viaje, List<string> list, string origen, string destino)
        {
            Vertice vO = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == origen);
            Vertice vD = viaje.Grafo.Lista.Find(vert => vert.Destino.Nombre == destino);
            if (vO != null && vD != null)
            {
                foreach (Arco a in vO.Lista)
                {
                    if (a.Destino != null)
                    {
                        list.Add(a.Demora);
                        if (a.Destino.Nombre != destino)
                            ObtenerTiempoR(viaje, list, a.Destino.Nombre, destino);
                    }
                }
            }
        }
        private Destino BuscarDestino(string destino)
        {
            return grafo.Lista.Find(vert => vert.Destino.Nombre == destino).Destino;
        }
        private void RecargarViajes()
        {
            cbTrayecto.Items.Clear();
            cbViajeTrayecto.Items.Clear();
            foreach (Viaje v in viajes.Lista)
            {
                cbTrayecto.Items.Add(v.Nombre);
                cbViajeTrayecto.Items.Add(v.Nombre);
            }
            if (cbTrayecto.Items.Count > 0) cbTrayecto.SelectedIndex = 0;
            if (cbViajeTrayecto.Items.Count > 0) cbViajeTrayecto.SelectedIndex = 0;
            lblInfo.Text = "Cuenta: " + cuentaUso.Usuario + " | Cuentas: " + cuentas.Lista.Count + " | Vertices en grafo: " + grafo.Lista.Count + " | Trayectos: " + viajes.Lista.Count + " | Boletos: " + boletos.Lista.Count + " | Pagos: " + pagos.Lista.Count;

            
        }
        private Viaje CurrentViaje(string text)
        {
            foreach (Viaje v in viajes.Lista) if (v.Nombre == text) return v;             
            return null;
        }
        private int GetDayOfWeekIndex(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return 0;
                case DayOfWeek.Tuesday: return 1;
                case DayOfWeek.Wednesday: return 2;
                case DayOfWeek.Thursday: return 3;
                case DayOfWeek.Friday: return 4;
                case DayOfWeek.Saturday: return 5;
                case DayOfWeek.Sunday: return 6;
                default: return -1;
                  
                        
            }
        }
        private void ActualizarInformacion()
        {
            try
            {
                Viaje viaje = CurrentViaje(cbTrayecto.SelectedItem.ToString());
                if (viaje != null)
                {
                    DateTime tiempo = ObtenerTiempo(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                    DateTime hora_ad = DateTime.Parse(cbHoraSalidaIda.SelectedItem.ToString());

                    hora_ad = DateTime.Parse(hora_ad.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());

                    dtpHoraLlegadaIda.Value = hora_ad;

                    tbAsientoIda.Text = string.Empty;

                    lblPrecio.Text = "Precio: $" + ObtenerPrecio(viaje, cbOrigen.SelectedItem.ToString(), cbDestino.SelectedItem.ToString());
                }
            }
            catch (NullReferenceException)
            {

            }
        }
        private void ActualizarListaPasajeros()
        {
            cbPasNombre.AutoCompleteCustomSource.Clear();
            cbPasDNI.AutoCompleteCustomSource.Clear();
            foreach (Cliente c in clientes.Lista)
            {
                cbPasNombre.AutoCompleteCustomSource.Add(c.Nombre);
                cbPasDNI.AutoCompleteCustomSource.Add(c.DNI);
            }
        }
        private void ActualizarDataGridView()
        {
            dgvViajeTrayectos.Rows.Clear();
            dgvViajeTrayectos.Columns.Clear();
            Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (v != null)
            {
                List<string> lista = new List<string>();
                MostrarSiguientes(v, lista, v.Origen.Nombre, v.Destino.Nombre);
                dgvViajeTrayectos.Columns.Add("clmX", "X");
                dgvViajeTrayectos.Columns.Add("clm" + v.Origen.Nombre, v.Origen.Nombre);
                if (rbViajesPrecios.Checked)
                {
                    dgvViajeTrayectos.Rows.Add(v.Origen.Nombre);
                    foreach (string nombre in lista)
                    {
                        dgvViajeTrayectos.Columns.Add("clm" + nombre, nombre);
                        dgvViajeTrayectos.Rows.Add(nombre);
                    }
                    dgvViajeTrayectos.Columns.Add("clm" + v.Destino.Nombre, v.Destino.Nombre);
                }
                else if (rbViajesHorarios.Checked)
                {
                    if (!cbViajesHorariosTodos.Checked)
                    {
                        dgvViajeTrayectos.Rows.Add(v.Origen.Nombre);
                        cbViajeHoraSalida.Enabled = true;
                    }
                    else
                    {
                        for(int i = 0; i < v.ListaHorarios.Count; i++)
                        {
                            dgvViajeTrayectos.Rows.Add(v.Origen.Nombre);
                        }
                        cbViajeHoraSalida.Enabled = false;
                    }
                    foreach (string nombre in lista)
                    {
                        dgvViajeTrayectos.Columns.Add("clm" + nombre, nombre);
                    }
                    dgvViajeTrayectos.Columns.Add("clm" + v.Destino.Nombre, v.Destino.Nombre);
                }
            }
        }
        private void RecargarDataGridView()
        {
            Viaje v = CurrentViaje(cbViajeTrayecto.SelectedItem.ToString());
            if (v != null)
            {
                if (rbViajesPrecios.Checked)
                {
                    foreach (DataGridViewRow row in dgvViajeTrayectos.Rows)
                    {
                        for (int i = 0; i < dgvViajeTrayectos.Columns.Count; i++)
                        {
                            if (i > 0)
                            {
                                if (cbViajeHoraSalida.SelectedItem != null)
                                {
                                    int valor = ObtenerPrecio(v, row.Cells[0].Value.ToString(), dgvViajeTrayectos.Columns[row.Cells[i].ColumnIndex].HeaderText);

                                    List<string> siguientes = new List<string>();
                                    siguientes.Clear();

                                    MostrarSiguientes(v, siguientes, row.Cells[0].Value.ToString(), v.Destino.Nombre);
                                    siguientes.Add(v.Destino.Nombre);
                                    if (siguientes.Contains(dgvViajeTrayectos.Columns[row.Cells[i].ColumnIndex].HeaderText))
                                    {
                                        if (valor != 0)
                                        {
                                            row.Cells[i].Value = "$" + valor;
                                        }
                                        else row.Cells[i].Value = " - ";
                                    }
                                    else row.Cells[i].Value = " - ";
                                }
                            }
                        }
                    }
                }
                else if (rbViajesHorarios.Checked)
                {
                    if (!cbViajesHorariosTodos.Checked)
                    {
                        foreach (DataGridViewRow row in dgvViajeTrayectos.Rows)
                        {
                            for (int i = 0; i < dgvViajeTrayectos.Columns.Count; i++)
                            {
                                if (i > 0)
                                {
                                    DateTime horarios = DateTime.Parse(cbViajeHoraSalida.SelectedItem.ToString());
                                    DateTime tiempo = ObtenerTiempo(v, row.Cells[0].Value.ToString(), dgvViajeTrayectos.Columns[row.Cells[i].ColumnIndex].HeaderText);
                                    horarios = DateTime.Parse(horarios.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());
                                    string valor = horarios.ToShortTimeString();
                                    row.Cells[i].Value = valor;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int r = 0; r < dgvViajeTrayectos.Rows.Count; r++)
                        {
                            for (int c = 0; c < dgvViajeTrayectos.Columns.Count; c++)
                            {
                                if (c > 0)
                                {
                                    DateTime horarios = DateTime.Parse(v.ListaHorarios[r].Hora);
                                    DateTime tiempo = ObtenerTiempo(v, dgvViajeTrayectos.Rows[r].Cells[0].Value.ToString(), dgvViajeTrayectos.Columns[dgvViajeTrayectos.Rows[r].Cells[c].ColumnIndex].HeaderText);
                                    horarios = DateTime.Parse(horarios.Add(new TimeSpan(tiempo.Hour, tiempo.Minute, 0)).ToShortTimeString());
                                    string valor = horarios.ToShortTimeString();
                                    dgvViajeTrayectos.Rows[r].Cells[c].Value = valor;
                                }
                            }
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
        private void DrawDistribution(Distribucion distribucion)
        {
            const int ESPACIO_NULL = -1;
            const int ESPACIO_PASILLO = 1;
            const int ESPACIO_BUTACA = 2;
            const int ESPACIO_TV = 3;

            if (rbPB.Checked)
            {
                dgvAsientos.Rows.Clear();
                if (!EsDoblePiso(distribucion)) rbPA.Enabled = false;
                else rbPA.Enabled = true;

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
                ContarAsientos(distribucion);

            }
            else if (rbPA.Checked)
            {
                dgvAsientos.Rows.Clear();
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
                ContarAsientos(distribucion);
            }
        }
        private void ContarAsientos(Distribucion distribucion)
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
                            c.ToolTipText = "Butaca disponible";
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
        private void RecargarBoletos()
        {
            try
            {
                dgvBoletos.Rows.Clear();
                foreach (Boleto b in boletos.Lista)
                {
                    DibujarBoletoDataGridView(b);
                }
                foreach (DataGridViewRow row in dgvBoletos.Rows)
                {
                    switch (row.Cells["Estado"].Value.ToString())
                    {
                        case "PENDIENTE":
                            row.DefaultCellStyle.BackColor = Color.Gold;
                            break;
                        case "VENDIDO":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "EXPIRADO":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                        case "CANCELADO":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                    }
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Hay datos que son inválidos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                //dgvBoletos.Rows.GetLastRow(DataGridViewElementStates.Visible);
        }

        private void DibujarBoletoDataGridView(Boleto b)        
        {
            DateTime fecha = Convert.ToDateTime(b.Fecha);
            DateTime fecha_emision = Convert.ToDateTime(b.FechaEmision);
            if (DateTime.Now.Day > fecha.Day && DateTime.Now.Month >= fecha.Month || fecha.Year > DateTime.Now.Year)
            {
                b.Estado = "EXPIRADO";
            }
            if (rbFiltroTodos.Checked || rbFiltrosRecorrido.Checked && cbTrayecto.SelectedItem.ToString() == b.Recorrido.Nombre || rbFiltrosDiaHoy.Checked && fecha_emision.ToShortDateString() == DateTime.Now.ToShortDateString() || rbFiltrosVendidos.Checked && b.Estado == "VENDIDO" || rbFiltrosPendientes.Checked && b.Estado == "PENDIENTE" || rbFiltrosExpirados.Checked && b.Estado == "EXPIRADO")
            {
                string pago;
                if (b.Pago == null) pago = "Ninguno";
                else pago = b.Pago.Tipo;
                dgvBoletos.Rows.Add(b.ID, b.Recorrido.Nombre, b.Pasajero.Nombre, b.FechaEmision, b.Origen.Nombre, b.Destino.Nombre, b.Fecha, b.HoraSalidaAdicional,b.Asiento, b.Estado, pago);
            }
        }

        private void BuscarPasajeros()
        {
            if (cbPasNombre.Text != string.Empty)
            {
                Cliente c = clientes.Lista.Find(cliente => cliente.Nombre == cbPasNombre.Text);
                if (c != null)
                {
                    cbPasNombre.Text = c.Nombre;
                    cbPasDNI.Text = c.DNI;
                }
                else MessageBox.Show("No se encontró ningún pasajero.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbPasDNI.Text != string.Empty)
            {
                Cliente c = clientes.Lista.Find(cliente => cliente.DNI == cbPasDNI.Text);
                if (c != null)
                {
                    cbPasNombre.Text = c.Nombre;
                    cbPasDNI.Text = c.DNI;
                }
            }
        }
        private void DisableControls()
        {
            cbOrigen.Enabled = false;
            cbDestino.Enabled = false;
            lblOrigen.Enabled = false;
            lblDestino.Enabled = false;
            lblAsientoIda.Enabled = false;
            btnMasAsientosIda.Enabled = false;
            btnVender.Enabled = false;
            lblHoraSalidaIda.Enabled = false;
            cbHoraSalidaIda.Enabled = false;
            lblHoraLlegadaIda.Enabled = false;
            dtpHoraLlegadaIda.Value = Convert.ToDateTime("00:00:00");

            ttInfo.UseAnimation = true;
            ttInfo.SetToolTip(gbIda, "No se pueden vender pasajes ese día.");
           
            foreach(Control c in gbIda.Controls)
            {
                ttInfo.SetToolTip(c, "No se pueden vender pasajes ese día.");
                c.Cursor = Cursors.No;
            }
        }
        private void EnableControls()
        {
            cbOrigen.Enabled = true;
            cbDestino.Enabled = true;
            lblOrigen.Enabled = true;
            lblDestino.Enabled = true;
            lblAsientoIda.Enabled = true;
            btnMasAsientosIda.Enabled = true;
            btnVender.Enabled = true;
            lblHoraSalidaIda.Enabled = true;
            cbHoraSalidaIda.Enabled = true;
            lblHoraLlegadaIda.Enabled = true;

            ttInfo.SetToolTip(gbIda, "");
            foreach (Control c in gbIda.Controls)
            {
                ttInfo.SetToolTip(c, "");
                c.Cursor = Cursors.Arrow;
            }
        }

        private void cbViajesHorariosTodos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            RecargarDataGridView();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmCuenta form = new frmCuenta(cuentas, cuentaUso);
            form.ShowDialog();
        }

        private void editorDeRecorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDestinos form = new frmDestinos(directory, grafo, viajes, boletos, distribuciones);
            if (form.ShowDialog() != DialogResult.None)
            {
                try
                {
                    RecargarViajes();
                    viajes.Guardar();
                    boletos.Guardar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error inesperado: No se pudo recargar las modificaciones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void verInfoItem_Click(object sender, EventArgs e)
        {

        }

        private void tpPasajes_Click(object sender, EventArgs e)
        {

        }

        private void PasajerosFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && (sender as RadioButton).Checked)
            {
                if((sender as RadioButton).Tag != null)
                {
                    cbBuscarPasajes.AutoCompleteCustomSource.Clear();
                    switch ((sender as RadioButton).Tag.ToString())
                    {
                        case "pasajero":
                            foreach (Boleto b in boletos.Lista) cbBuscarPasajes.AutoCompleteCustomSource.Add(b.Pasajero.Nombre);
                            break;
                        case "dni":
                            foreach (Boleto b in boletos.Lista) cbBuscarPasajes.AutoCompleteCustomSource.Add(b.Pasajero.DNI);
                            break;
                        case "origen":
                            foreach (Boleto b in boletos.Lista) cbBuscarPasajes.AutoCompleteCustomSource.Add(b.Origen.Nombre);
                            break;
                        case "destino":
                            foreach (Boleto b in boletos.Lista) cbBuscarPasajes.AutoCompleteCustomSource.Add(b.Destino.Nombre);

                            break;
                        case "fecha":
                            foreach (Boleto b in boletos.Lista) cbBuscarPasajes.AutoCompleteCustomSource.Add(b.Fecha);

                            break;
                    }
                }
            }

        }

        private void BuscarPasajes()
        {
            rbFiltroTodos.Checked = true;
            dgvBoletos.Rows.Clear();

            foreach (Control c in gbBuscarPasaje.Controls)
            {
                if (c is RadioButton && (c as RadioButton).Checked)
                {
                    if(c.Tag != null)
                    {
                        switch(c.Tag.ToString())
                        {
                            case "pasajero":
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Pasajero.Nombre == cbBuscarPasajes.SelectedText)
                                        DibujarBoletoDataGridView(b);
                                }
                                break;
                            case "dni":
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Pasajero.DNI == cbBuscarPasajes.SelectedText)
                                        DibujarBoletoDataGridView(b);
                                }
                                break;
                            case "origen":
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Origen.Nombre == cbBuscarPasajes.SelectedText)
                                        DibujarBoletoDataGridView(b);
                                }
                                break;
                            case "destino":
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Destino.Nombre == cbBuscarPasajes.SelectedText)
                                        DibujarBoletoDataGridView(b);
                                }
                                break;
                            case "fecha":
                                foreach (Boleto b in boletos.Lista)
                                {
                                    if (b.Fecha == cbBuscarPasajes.SelectedText)
                                        DibujarBoletoDataGridView(b);
                                }
                                break;
                        }
                        foreach (DataGridViewRow row in dgvBoletos.Rows)
                        {
                            switch (row.Cells["Estado"].Value.ToString())
                            {
                                case "PENDIENTE":
                                    row.DefaultCellStyle.BackColor = Color.Gold;
                                    break;
                                case "VENDIDO":
                                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                                    break;
                                case "EXPIRADO":
                                    row.DefaultCellStyle.BackColor = Color.LightGray;
                                    break;
                                case "CANCELADO":
                                    row.DefaultCellStyle.BackColor = Color.LightGray;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void cbPasNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBuscarPasajes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPasajes();
            }
        }

        private void apartadosAdministrativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(apartadosAdministrativosToolStripMenuItem.Checked)
            {

            }
            else
            {

            }
        }
    }
}
