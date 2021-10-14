namespace Sistema_final
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.venderItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.tcOpciones = new System.Windows.Forms.TabControl();
            this.tpPasajes = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlPasajes = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rbFiltrosExpirados = new System.Windows.Forms.RadioButton();
            this.rbFiltrosRecorrido = new System.Windows.Forms.RadioButton();
            this.rbFiltrosVendidos = new System.Windows.Forms.RadioButton();
            this.rbFiltrosPendientes = new System.Windows.Forms.RadioButton();
            this.rbFiltrosDiaHoy = new System.Windows.Forms.RadioButton();
            this.rbFiltroTodos = new System.Windows.Forms.RadioButton();
            this.gbVuelta = new System.Windows.Forms.GroupBox();
            this.cbHoraSalidaVuelta = new System.Windows.Forms.ComboBox();
            this.dtpHoraLlegadVuelta = new System.Windows.Forms.DateTimePicker();
            this.tbAsientoVuelta = new System.Windows.Forms.TextBox();
            this.dtpFechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVuelta = new System.Windows.Forms.Label();
            this.lblAsientoVuelta = new System.Windows.Forms.Label();
            this.btnMasAsientosVuelta = new System.Windows.Forms.Button();
            this.lblHoraLLegadaVuelta = new System.Windows.Forms.Label();
            this.lblHoraSalidaVuelta = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dgvBoletos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trayecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIda = new System.Windows.Forms.GroupBox();
            this.cbHoraSalidaIda = new System.Windows.Forms.ComboBox();
            this.dtpHoraLlegadaIda = new System.Windows.Forms.DateTimePicker();
            this.tbAsientoIda = new System.Windows.Forms.TextBox();
            this.dtpFechaIda = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIda = new System.Windows.Forms.Label();
            this.lblAsientoIda = new System.Windows.Forms.Label();
            this.btnMasAsientosIda = new System.Windows.Forms.Button();
            this.lblHoraLlegadaIda = new System.Windows.Forms.Label();
            this.lblHoraSalidaIda = new System.Windows.Forms.Label();
            this.cbTrayecto = new System.Windows.Forms.ComboBox();
            this.lblTrayecto = new System.Windows.Forms.Label();
            this.gbBuscarPasaje = new System.Windows.Forms.GroupBox();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.cbBuscarPasajes = new System.Windows.Forms.ComboBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbDestino = new System.Windows.Forms.RadioButton();
            this.rbOrigen = new System.Windows.Forms.RadioButton();
            this.rbPasajero = new System.Windows.Forms.RadioButton();
            this.gbPasajeros = new System.Windows.Forms.GroupBox();
            this.cbPasDNI = new System.Windows.Forms.ComboBox();
            this.cbPasNombre = new System.Windows.Forms.ComboBox();
            this.btnBuscarPasajeros = new System.Windows.Forms.Button();
            this.btnMasPasajeros = new System.Windows.Forms.Button();
            this.lblPasDNI = new System.Windows.Forms.Label();
            this.lblPasNombre = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbBoleto = new System.Windows.Forms.ComboBox();
            this.btnMasOrigen = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.tpViajes = new System.Windows.Forms.TabPage();
            this.gbViajesHorarios = new System.Windows.Forms.GroupBox();
            this.pnlViajeHorariosTodos = new System.Windows.Forms.Panel();
            this.cbViajesHorariosTodos = new System.Windows.Forms.CheckBox();
            this.rbViajesPrecios = new System.Windows.Forms.RadioButton();
            this.rbViajesHorarios = new System.Windows.Forms.RadioButton();
            this.dgvViajeTrayectos = new System.Windows.Forms.DataGridView();
            this.gbPBModEspacio = new System.Windows.Forms.GroupBox();
            this.rbPA = new System.Windows.Forms.RadioButton();
            this.rbPB = new System.Windows.Forms.RadioButton();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblViajeFrecuencia = new System.Windows.Forms.Label();
            this.clbViajeFrecuencia = new System.Windows.Forms.CheckedListBox();
            this.lblViajeHorario = new System.Windows.Forms.Label();
            this.lblViajeRecorrido = new System.Windows.Forms.Label();
            this.cbViajeHoraSalida = new System.Windows.Forms.ComboBox();
            this.cbViajeTrayecto = new System.Windows.Forms.ComboBox();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFuenteDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartadosAdministrativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeRecorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDePasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDirectorioPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idaYVueltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cmsOpciones.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.tcOpciones.SuspendLayout();
            this.tpPasajes.SuspendLayout();
            this.pnlPasajes.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.gbVuelta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).BeginInit();
            this.gbIda.SuspendLayout();
            this.gbBuscarPasaje.SuspendLayout();
            this.gbPasajeros.SuspendLayout();
            this.tpViajes.SuspendLayout();
            this.gbViajesHorarios.SuspendLayout();
            this.pnlViajeHorariosTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeTrayectos)).BeginInit();
            this.gbPBModEspacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verInfoItem,
            this.separador,
            this.venderItem,
            this.cancelarItem});
            this.cmsOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(231, 76);
            // 
            // verInfoItem
            // 
            this.verInfoItem.Image = global::Sistema_final.Properties.Resources.nuevo1;
            this.verInfoItem.Name = "verInfoItem";
            this.verInfoItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.verInfoItem.Size = new System.Drawing.Size(230, 22);
            this.verInfoItem.Text = "Ver información completa";
            this.verInfoItem.Click += new System.EventHandler(this.verInfoItem_Click);
            // 
            // separador
            // 
            this.separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separador.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(227, 6);
            // 
            // venderItem
            // 
            this.venderItem.Image = global::Sistema_final.Properties.Resources.carrito;
            this.venderItem.Name = "venderItem";
            this.venderItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.venderItem.Size = new System.Drawing.Size(230, 22);
            this.venderItem.Text = "Vender";
            this.venderItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // cancelarItem
            // 
            this.cancelarItem.Image = global::Sistema_final.Properties.Resources.borrar;
            this.cancelarItem.Name = "cancelarItem";
            this.cancelarItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cancelarItem.Size = new System.Drawing.Size(230, 22);
            this.cancelarItem.Text = "Cancelar";
            this.cancelarItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.Controls.Add(this.btnPerfil);
            this.pnlPrincipal.Controls.Add(this.tcOpciones);
            this.pnlPrincipal.Controls.Add(this.msPrincipal);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1069, 525);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.AutoSize = true;
            this.btnPerfil.BackgroundImage = global::Sistema_final.Properties.Resources.usuario_hombre;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerfil.FlatAppearance.BorderSize = 10;
            this.btnPerfil.Location = new System.Drawing.Point(1019, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(38, 36);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // tcOpciones
            // 
            this.tcOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOpciones.Controls.Add(this.tpPasajes);
            this.tcOpciones.Controls.Add(this.tpViajes);
            this.tcOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOpciones.Location = new System.Drawing.Point(12, 34);
            this.tcOpciones.Multiline = true;
            this.tcOpciones.Name = "tcOpciones";
            this.tcOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcOpciones.SelectedIndex = 0;
            this.tcOpciones.Size = new System.Drawing.Size(1045, 479);
            this.tcOpciones.TabIndex = 7;
            // 
            // tpPasajes
            // 
            this.tpPasajes.Controls.Add(this.lblInfo);
            this.tpPasajes.Controls.Add(this.pnlPasajes);
            this.tpPasajes.Location = new System.Drawing.Point(4, 24);
            this.tpPasajes.Name = "tpPasajes";
            this.tpPasajes.Padding = new System.Windows.Forms.Padding(3);
            this.tpPasajes.Size = new System.Drawing.Size(1037, 451);
            this.tpPasajes.TabIndex = 1;
            this.tpPasajes.Text = "Pasajes";
            this.tpPasajes.UseVisualStyleBackColor = true;
            this.tpPasajes.Click += new System.EventHandler(this.tpPasajes_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Location = new System.Drawing.Point(3, 433);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(68, 15);
            this.lblInfo.TabIndex = 29;
            this.lblInfo.Text = "Destinos: 0";
            // 
            // pnlPasajes
            // 
            this.pnlPasajes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlPasajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPasajes.Controls.Add(this.gbFiltros);
            this.pnlPasajes.Controls.Add(this.gbVuelta);
            this.pnlPasajes.Controls.Add(this.lblPrecio);
            this.pnlPasajes.Controls.Add(this.dgvBoletos);
            this.pnlPasajes.Controls.Add(this.gbIda);
            this.pnlPasajes.Controls.Add(this.cbTrayecto);
            this.pnlPasajes.Controls.Add(this.lblTrayecto);
            this.pnlPasajes.Controls.Add(this.gbBuscarPasaje);
            this.pnlPasajes.Controls.Add(this.gbPasajeros);
            this.pnlPasajes.Controls.Add(this.btnVender);
            this.pnlPasajes.Controls.Add(this.lblTipo);
            this.pnlPasajes.Controls.Add(this.cbBoleto);
            this.pnlPasajes.Controls.Add(this.btnMasOrigen);
            this.pnlPasajes.Controls.Add(this.lblOrigen);
            this.pnlPasajes.Controls.Add(this.cbOrigen);
            this.pnlPasajes.Controls.Add(this.lblDestino);
            this.pnlPasajes.Controls.Add(this.cbDestino);
            this.pnlPasajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPasajes.Location = new System.Drawing.Point(3, 3);
            this.pnlPasajes.Name = "pnlPasajes";
            this.pnlPasajes.Size = new System.Drawing.Size(1031, 445);
            this.pnlPasajes.TabIndex = 30;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rbFiltrosExpirados);
            this.gbFiltros.Controls.Add(this.rbFiltrosRecorrido);
            this.gbFiltros.Controls.Add(this.rbFiltrosVendidos);
            this.gbFiltros.Controls.Add(this.rbFiltrosPendientes);
            this.gbFiltros.Controls.Add(this.rbFiltrosDiaHoy);
            this.gbFiltros.Controls.Add(this.rbFiltroTodos);
            this.gbFiltros.Location = new System.Drawing.Point(23, 233);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(508, 44);
            this.gbFiltros.TabIndex = 42;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // rbFiltrosExpirados
            // 
            this.rbFiltrosExpirados.AutoSize = true;
            this.rbFiltrosExpirados.Location = new System.Drawing.Point(235, 20);
            this.rbFiltrosExpirados.Name = "rbFiltrosExpirados";
            this.rbFiltrosExpirados.Size = new System.Drawing.Size(80, 19);
            this.rbFiltrosExpirados.TabIndex = 5;
            this.rbFiltrosExpirados.TabStop = true;
            this.rbFiltrosExpirados.Text = "Expirados";
            this.rbFiltrosExpirados.UseVisualStyleBackColor = true;
            this.rbFiltrosExpirados.CheckedChanged += new System.EventHandler(this.rbFiltrosExpirados_CheckedChanged);
            // 
            // rbFiltrosRecorrido
            // 
            this.rbFiltrosRecorrido.AutoSize = true;
            this.rbFiltrosRecorrido.Location = new System.Drawing.Point(139, 20);
            this.rbFiltrosRecorrido.Name = "rbFiltrosRecorrido";
            this.rbFiltrosRecorrido.Size = new System.Drawing.Size(85, 19);
            this.rbFiltrosRecorrido.TabIndex = 4;
            this.rbFiltrosRecorrido.TabStop = true;
            this.rbFiltrosRecorrido.Text = "Recorridos";
            this.rbFiltrosRecorrido.UseVisualStyleBackColor = true;
            this.rbFiltrosRecorrido.CheckedChanged += new System.EventHandler(this.rbFiltrosRecorrido_CheckedChanged);
            // 
            // rbFiltrosVendidos
            // 
            this.rbFiltrosVendidos.AutoSize = true;
            this.rbFiltrosVendidos.Location = new System.Drawing.Point(424, 20);
            this.rbFiltrosVendidos.Name = "rbFiltrosVendidos";
            this.rbFiltrosVendidos.Size = new System.Drawing.Size(76, 19);
            this.rbFiltrosVendidos.TabIndex = 3;
            this.rbFiltrosVendidos.TabStop = true;
            this.rbFiltrosVendidos.Text = "Vendidos";
            this.rbFiltrosVendidos.UseVisualStyleBackColor = true;
            this.rbFiltrosVendidos.CheckedChanged += new System.EventHandler(this.rbFiltrosVendidos_CheckedChanged);
            // 
            // rbFiltrosPendientes
            // 
            this.rbFiltrosPendientes.AutoSize = true;
            this.rbFiltrosPendientes.Location = new System.Drawing.Point(326, 20);
            this.rbFiltrosPendientes.Name = "rbFiltrosPendientes";
            this.rbFiltrosPendientes.Size = new System.Drawing.Size(87, 19);
            this.rbFiltrosPendientes.TabIndex = 2;
            this.rbFiltrosPendientes.TabStop = true;
            this.rbFiltrosPendientes.Text = "Pendientes";
            this.rbFiltrosPendientes.UseVisualStyleBackColor = true;
            this.rbFiltrosPendientes.CheckedChanged += new System.EventHandler(this.rbFiltrosPendientes_CheckedChanged);
            // 
            // rbFiltrosDiaHoy
            // 
            this.rbFiltrosDiaHoy.AutoSize = true;
            this.rbFiltrosDiaHoy.Location = new System.Drawing.Point(82, 20);
            this.rbFiltrosDiaHoy.Name = "rbFiltrosDiaHoy";
            this.rbFiltrosDiaHoy.Size = new System.Drawing.Size(46, 19);
            this.rbFiltrosDiaHoy.TabIndex = 1;
            this.rbFiltrosDiaHoy.TabStop = true;
            this.rbFiltrosDiaHoy.Text = "Hoy";
            this.rbFiltrosDiaHoy.UseVisualStyleBackColor = true;
            this.rbFiltrosDiaHoy.CheckedChanged += new System.EventHandler(this.rbFiltrosDiaHoy_CheckedChanged);
            // 
            // rbFiltroTodos
            // 
            this.rbFiltroTodos.AutoSize = true;
            this.rbFiltroTodos.Location = new System.Drawing.Point(12, 20);
            this.rbFiltroTodos.Name = "rbFiltroTodos";
            this.rbFiltroTodos.Size = new System.Drawing.Size(59, 19);
            this.rbFiltroTodos.TabIndex = 0;
            this.rbFiltroTodos.TabStop = true;
            this.rbFiltroTodos.Text = "Todos";
            this.rbFiltroTodos.UseVisualStyleBackColor = true;
            this.rbFiltroTodos.CheckedChanged += new System.EventHandler(this.rbFiltroTodos_CheckedChanged);
            // 
            // gbVuelta
            // 
            this.gbVuelta.Controls.Add(this.cbHoraSalidaVuelta);
            this.gbVuelta.Controls.Add(this.dtpHoraLlegadVuelta);
            this.gbVuelta.Controls.Add(this.tbAsientoVuelta);
            this.gbVuelta.Controls.Add(this.dtpFechaVuelta);
            this.gbVuelta.Controls.Add(this.lblFechaVuelta);
            this.gbVuelta.Controls.Add(this.lblAsientoVuelta);
            this.gbVuelta.Controls.Add(this.btnMasAsientosVuelta);
            this.gbVuelta.Controls.Add(this.lblHoraLLegadaVuelta);
            this.gbVuelta.Controls.Add(this.lblHoraSalidaVuelta);
            this.gbVuelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVuelta.Location = new System.Drawing.Point(743, 141);
            this.gbVuelta.Name = "gbVuelta";
            this.gbVuelta.Size = new System.Drawing.Size(200, 136);
            this.gbVuelta.TabIndex = 40;
            this.gbVuelta.TabStop = false;
            this.gbVuelta.Text = "Vuelta";
            this.gbVuelta.Visible = false;
            // 
            // cbHoraSalidaVuelta
            // 
            this.cbHoraSalidaVuelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraSalidaVuelta.FormattingEnabled = true;
            this.cbHoraSalidaVuelta.Location = new System.Drawing.Point(91, 79);
            this.cbHoraSalidaVuelta.Name = "cbHoraSalidaVuelta";
            this.cbHoraSalidaVuelta.Size = new System.Drawing.Size(74, 23);
            this.cbHoraSalidaVuelta.TabIndex = 39;
            // 
            // dtpHoraLlegadVuelta
            // 
            this.dtpHoraLlegadVuelta.Enabled = false;
            this.dtpHoraLlegadVuelta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadVuelta.Location = new System.Drawing.Point(91, 109);
            this.dtpHoraLlegadVuelta.Name = "dtpHoraLlegadVuelta";
            this.dtpHoraLlegadVuelta.ShowUpDown = true;
            this.dtpHoraLlegadVuelta.Size = new System.Drawing.Size(74, 21);
            this.dtpHoraLlegadVuelta.TabIndex = 38;
            this.dtpHoraLlegadVuelta.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            // 
            // tbAsientoVuelta
            // 
            this.tbAsientoVuelta.Enabled = false;
            this.tbAsientoVuelta.Location = new System.Drawing.Point(91, 51);
            this.tbAsientoVuelta.Name = "tbAsientoVuelta";
            this.tbAsientoVuelta.Size = new System.Drawing.Size(35, 21);
            this.tbAsientoVuelta.TabIndex = 36;
            this.tbAsientoVuelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaVuelta
            // 
            this.dtpFechaVuelta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVuelta.Location = new System.Drawing.Point(91, 23);
            this.dtpFechaVuelta.Name = "dtpFechaVuelta";
            this.dtpFechaVuelta.Size = new System.Drawing.Size(103, 21);
            this.dtpFechaVuelta.TabIndex = 28;
            // 
            // lblFechaVuelta
            // 
            this.lblFechaVuelta.AutoSize = true;
            this.lblFechaVuelta.Location = new System.Drawing.Point(6, 24);
            this.lblFechaVuelta.Name = "lblFechaVuelta";
            this.lblFechaVuelta.Size = new System.Drawing.Size(44, 15);
            this.lblFechaVuelta.TabIndex = 27;
            this.lblFechaVuelta.Text = "Fecha:";
            // 
            // lblAsientoVuelta
            // 
            this.lblAsientoVuelta.AutoSize = true;
            this.lblAsientoVuelta.Location = new System.Drawing.Point(6, 53);
            this.lblAsientoVuelta.Name = "lblAsientoVuelta";
            this.lblAsientoVuelta.Size = new System.Drawing.Size(50, 15);
            this.lblAsientoVuelta.TabIndex = 25;
            this.lblAsientoVuelta.Text = "Asiento:";
            // 
            // btnMasAsientosVuelta
            // 
            this.btnMasAsientosVuelta.AutoSize = true;
            this.btnMasAsientosVuelta.BackColor = System.Drawing.Color.Transparent;
            this.btnMasAsientosVuelta.BackgroundImage = global::Sistema_final.Properties.Resources.agregar1;
            this.btnMasAsientosVuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasAsientosVuelta.Location = new System.Drawing.Point(132, 51);
            this.btnMasAsientosVuelta.Name = "btnMasAsientosVuelta";
            this.btnMasAsientosVuelta.Size = new System.Drawing.Size(23, 23);
            this.btnMasAsientosVuelta.TabIndex = 26;
            this.btnMasAsientosVuelta.UseVisualStyleBackColor = false;
            // 
            // lblHoraLLegadaVuelta
            // 
            this.lblHoraLLegadaVuelta.AutoSize = true;
            this.lblHoraLLegadaVuelta.Location = new System.Drawing.Point(6, 111);
            this.lblHoraLLegadaVuelta.Name = "lblHoraLLegadaVuelta";
            this.lblHoraLLegadaVuelta.Size = new System.Drawing.Size(81, 15);
            this.lblHoraLLegadaVuelta.TabIndex = 35;
            this.lblHoraLLegadaVuelta.Text = "Hora llegada:";
            // 
            // lblHoraSalidaVuelta
            // 
            this.lblHoraSalidaVuelta.AutoSize = true;
            this.lblHoraSalidaVuelta.Location = new System.Drawing.Point(6, 82);
            this.lblHoraSalidaVuelta.Name = "lblHoraSalidaVuelta";
            this.lblHoraSalidaVuelta.Size = new System.Drawing.Size(73, 15);
            this.lblHoraSalidaVuelta.TabIndex = 34;
            this.lblHoraSalidaVuelta.Text = "Hora salida:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(543, 18);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(82, 17);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio: $0";
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.AllowUserToAddRows = false;
            this.dgvBoletos.AllowUserToDeleteRows = false;
            this.dgvBoletos.AllowUserToResizeColumns = false;
            this.dgvBoletos.AllowUserToResizeRows = false;
            this.dgvBoletos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoletos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBoletos.BackgroundColor = System.Drawing.Color.White;
            this.dgvBoletos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Trayecto,
            this.Pasajero,
            this.Emitido,
            this.Origen,
            this.Destino,
            this.Fecha,
            this.HoraSalida,
            this.Asiento,
            this.Estado,
            this.Pago});
            this.dgvBoletos.ContextMenuStrip = this.cmsOpciones;
            this.dgvBoletos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBoletos.EnableHeadersVisualStyles = false;
            this.dgvBoletos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBoletos.Location = new System.Drawing.Point(23, 287);
            this.dgvBoletos.MultiSelect = false;
            this.dgvBoletos.Name = "dgvBoletos";
            this.dgvBoletos.ReadOnly = true;
            this.dgvBoletos.RowHeadersVisible = false;
            this.dgvBoletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletos.Size = new System.Drawing.Size(850, 140);
            this.dgvBoletos.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 44;
            // 
            // Trayecto
            // 
            this.Trayecto.HeaderText = "Recorrido";
            this.Trayecto.Name = "Trayecto";
            this.Trayecto.ReadOnly = true;
            this.Trayecto.Width = 86;
            // 
            // Pasajero
            // 
            this.Pasajero.HeaderText = "Pasajero";
            this.Pasajero.Name = "Pasajero";
            this.Pasajero.ReadOnly = true;
            this.Pasajero.Width = 81;
            // 
            // Emitido
            // 
            this.Emitido.HeaderText = "Emitido";
            this.Emitido.Name = "Emitido";
            this.Emitido.ReadOnly = true;
            this.Emitido.Width = 74;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Sale de";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 74;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Llega a";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 73;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 66;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Sale a la(s)";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            this.HoraSalida.Width = 94;
            // 
            // Asiento
            // 
            this.Asiento.HeaderText = "Butaca";
            this.Asiento.Name = "Asiento";
            this.Asiento.ReadOnly = true;
            this.Asiento.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pagado con";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 98;
            // 
            // gbIda
            // 
            this.gbIda.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbIda.Controls.Add(this.cbHoraSalidaIda);
            this.gbIda.Controls.Add(this.dtpHoraLlegadaIda);
            this.gbIda.Controls.Add(this.tbAsientoIda);
            this.gbIda.Controls.Add(this.dtpFechaIda);
            this.gbIda.Controls.Add(this.lblFechaIda);
            this.gbIda.Controls.Add(this.lblAsientoIda);
            this.gbIda.Controls.Add(this.btnMasAsientosIda);
            this.gbIda.Controls.Add(this.lblHoraLlegadaIda);
            this.gbIda.Controls.Add(this.lblHoraSalidaIda);
            this.gbIda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIda.Location = new System.Drawing.Point(537, 141);
            this.gbIda.Name = "gbIda";
            this.gbIda.Size = new System.Drawing.Size(200, 136);
            this.gbIda.TabIndex = 39;
            this.gbIda.TabStop = false;
            this.gbIda.Text = "Ida";
            // 
            // cbHoraSalidaIda
            // 
            this.cbHoraSalidaIda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraSalidaIda.FormattingEnabled = true;
            this.cbHoraSalidaIda.Location = new System.Drawing.Point(91, 79);
            this.cbHoraSalidaIda.Name = "cbHoraSalidaIda";
            this.cbHoraSalidaIda.Size = new System.Drawing.Size(74, 23);
            this.cbHoraSalidaIda.TabIndex = 39;
            this.cbHoraSalidaIda.SelectedIndexChanged += new System.EventHandler(this.cbHoraSalidaIda_SelectedIndexChanged);
            // 
            // dtpHoraLlegadaIda
            // 
            this.dtpHoraLlegadaIda.Enabled = false;
            this.dtpHoraLlegadaIda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraLlegadaIda.Location = new System.Drawing.Point(91, 109);
            this.dtpHoraLlegadaIda.Name = "dtpHoraLlegadaIda";
            this.dtpHoraLlegadaIda.ShowUpDown = true;
            this.dtpHoraLlegadaIda.Size = new System.Drawing.Size(74, 21);
            this.dtpHoraLlegadaIda.TabIndex = 38;
            this.dtpHoraLlegadaIda.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            // 
            // tbAsientoIda
            // 
            this.tbAsientoIda.Enabled = false;
            this.tbAsientoIda.Location = new System.Drawing.Point(91, 51);
            this.tbAsientoIda.Name = "tbAsientoIda";
            this.tbAsientoIda.Size = new System.Drawing.Size(35, 21);
            this.tbAsientoIda.TabIndex = 36;
            this.tbAsientoIda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaIda
            // 
            this.dtpFechaIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIda.Location = new System.Drawing.Point(91, 23);
            this.dtpFechaIda.Name = "dtpFechaIda";
            this.dtpFechaIda.Size = new System.Drawing.Size(103, 21);
            this.dtpFechaIda.TabIndex = 28;
            this.dtpFechaIda.ValueChanged += new System.EventHandler(this.dtpFechaIda_ValueChanged);
            // 
            // lblFechaIda
            // 
            this.lblFechaIda.AutoSize = true;
            this.lblFechaIda.Location = new System.Drawing.Point(6, 24);
            this.lblFechaIda.Name = "lblFechaIda";
            this.lblFechaIda.Size = new System.Drawing.Size(44, 15);
            this.lblFechaIda.TabIndex = 27;
            this.lblFechaIda.Text = "Fecha:";
            // 
            // lblAsientoIda
            // 
            this.lblAsientoIda.AutoSize = true;
            this.lblAsientoIda.Location = new System.Drawing.Point(6, 53);
            this.lblAsientoIda.Name = "lblAsientoIda";
            this.lblAsientoIda.Size = new System.Drawing.Size(50, 15);
            this.lblAsientoIda.TabIndex = 25;
            this.lblAsientoIda.Text = "Asiento:";
            // 
            // btnMasAsientosIda
            // 
            this.btnMasAsientosIda.AutoSize = true;
            this.btnMasAsientosIda.BackColor = System.Drawing.Color.Transparent;
            this.btnMasAsientosIda.BackgroundImage = global::Sistema_final.Properties.Resources.agregar1;
            this.btnMasAsientosIda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasAsientosIda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasAsientosIda.Location = new System.Drawing.Point(132, 51);
            this.btnMasAsientosIda.Name = "btnMasAsientosIda";
            this.btnMasAsientosIda.Size = new System.Drawing.Size(23, 23);
            this.btnMasAsientosIda.TabIndex = 26;
            this.btnMasAsientosIda.UseVisualStyleBackColor = false;
            this.btnMasAsientosIda.Click += new System.EventHandler(this.btnMasAsientos_Click);
            // 
            // lblHoraLlegadaIda
            // 
            this.lblHoraLlegadaIda.AutoSize = true;
            this.lblHoraLlegadaIda.Location = new System.Drawing.Point(6, 111);
            this.lblHoraLlegadaIda.Name = "lblHoraLlegadaIda";
            this.lblHoraLlegadaIda.Size = new System.Drawing.Size(81, 15);
            this.lblHoraLlegadaIda.TabIndex = 35;
            this.lblHoraLlegadaIda.Text = "Hora llegada:";
            // 
            // lblHoraSalidaIda
            // 
            this.lblHoraSalidaIda.AutoSize = true;
            this.lblHoraSalidaIda.Location = new System.Drawing.Point(6, 82);
            this.lblHoraSalidaIda.Name = "lblHoraSalidaIda";
            this.lblHoraSalidaIda.Size = new System.Drawing.Size(73, 15);
            this.lblHoraSalidaIda.TabIndex = 34;
            this.lblHoraSalidaIda.Text = "Hora salida:";
            // 
            // cbTrayecto
            // 
            this.cbTrayecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrayecto.FormattingEnabled = true;
            this.cbTrayecto.Location = new System.Drawing.Point(613, 45);
            this.cbTrayecto.Name = "cbTrayecto";
            this.cbTrayecto.Size = new System.Drawing.Size(324, 23);
            this.cbTrayecto.TabIndex = 38;
            this.cbTrayecto.Tag = "destinos";
            this.cbTrayecto.SelectedIndexChanged += new System.EventHandler(this.cbTrayecto_SelectedIndexChanged);
            // 
            // lblTrayecto
            // 
            this.lblTrayecto.AutoSize = true;
            this.lblTrayecto.Location = new System.Drawing.Point(543, 53);
            this.lblTrayecto.Name = "lblTrayecto";
            this.lblTrayecto.Size = new System.Drawing.Size(64, 15);
            this.lblTrayecto.TabIndex = 37;
            this.lblTrayecto.Text = "Recorrido:";
            // 
            // gbBuscarPasaje
            // 
            this.gbBuscarPasaje.AutoSize = true;
            this.gbBuscarPasaje.Controls.Add(this.rbDNI);
            this.gbBuscarPasaje.Controls.Add(this.cbBuscarPasajes);
            this.gbBuscarPasaje.Controls.Add(this.rbFecha);
            this.gbBuscarPasaje.Controls.Add(this.rbDestino);
            this.gbBuscarPasaje.Controls.Add(this.rbOrigen);
            this.gbBuscarPasaje.Controls.Add(this.rbPasajero);
            this.gbBuscarPasaje.Location = new System.Drawing.Point(23, 141);
            this.gbBuscarPasaje.Name = "gbBuscarPasaje";
            this.gbBuscarPasaje.Size = new System.Drawing.Size(508, 88);
            this.gbBuscarPasaje.TabIndex = 34;
            this.gbBuscarPasaje.TabStop = false;
            this.gbBuscarPasaje.Text = "Búsqueda de pasajes";
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(92, 20);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(46, 19);
            this.rbDNI.TabIndex = 45;
            this.rbDNI.Tag = "dni";
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.CheckedChanged += new System.EventHandler(this.PasajerosFiltros_CheckedChanged);
            // 
            // cbBuscarPasajes
            // 
            this.cbBuscarPasajes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBuscarPasajes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbBuscarPasajes.FormattingEnabled = true;
            this.cbBuscarPasajes.Location = new System.Drawing.Point(6, 45);
            this.cbBuscarPasajes.Name = "cbBuscarPasajes";
            this.cbBuscarPasajes.Size = new System.Drawing.Size(407, 23);
            this.cbBuscarPasajes.TabIndex = 44;
            this.cbBuscarPasajes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarPasajes_KeyDown);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(294, 20);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(59, 19);
            this.rbFecha.TabIndex = 4;
            this.rbFecha.Tag = "fecha";
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.PasajerosFiltros_CheckedChanged);
            // 
            // rbDestino
            // 
            this.rbDestino.AutoSize = true;
            this.rbDestino.Location = new System.Drawing.Point(218, 20);
            this.rbDestino.Name = "rbDestino";
            this.rbDestino.Size = new System.Drawing.Size(67, 19);
            this.rbDestino.TabIndex = 3;
            this.rbDestino.Tag = "destino";
            this.rbDestino.Text = "Destino";
            this.rbDestino.UseVisualStyleBackColor = true;
            this.rbDestino.CheckedChanged += new System.EventHandler(this.PasajerosFiltros_CheckedChanged);
            // 
            // rbOrigen
            // 
            this.rbOrigen.AutoSize = true;
            this.rbOrigen.Location = new System.Drawing.Point(147, 20);
            this.rbOrigen.Name = "rbOrigen";
            this.rbOrigen.Size = new System.Drawing.Size(62, 19);
            this.rbOrigen.TabIndex = 2;
            this.rbOrigen.Tag = "origen";
            this.rbOrigen.Text = "Origen";
            this.rbOrigen.UseVisualStyleBackColor = true;
            this.rbOrigen.CheckedChanged += new System.EventHandler(this.PasajerosFiltros_CheckedChanged);
            // 
            // rbPasajero
            // 
            this.rbPasajero.AutoSize = true;
            this.rbPasajero.Location = new System.Drawing.Point(9, 20);
            this.rbPasajero.Name = "rbPasajero";
            this.rbPasajero.Size = new System.Drawing.Size(74, 19);
            this.rbPasajero.TabIndex = 1;
            this.rbPasajero.Tag = "pasajero";
            this.rbPasajero.Text = "Pasajero";
            this.rbPasajero.UseVisualStyleBackColor = true;
            this.rbPasajero.CheckedChanged += new System.EventHandler(this.PasajerosFiltros_CheckedChanged);
            // 
            // gbPasajeros
            // 
            this.gbPasajeros.AutoSize = true;
            this.gbPasajeros.Controls.Add(this.cbPasDNI);
            this.gbPasajeros.Controls.Add(this.cbPasNombre);
            this.gbPasajeros.Controls.Add(this.btnBuscarPasajeros);
            this.gbPasajeros.Controls.Add(this.btnMasPasajeros);
            this.gbPasajeros.Controls.Add(this.lblPasDNI);
            this.gbPasajeros.Controls.Add(this.lblPasNombre);
            this.gbPasajeros.Location = new System.Drawing.Point(23, 44);
            this.gbPasajeros.Name = "gbPasajeros";
            this.gbPasajeros.Size = new System.Drawing.Size(508, 91);
            this.gbPasajeros.TabIndex = 33;
            this.gbPasajeros.TabStop = false;
            this.gbPasajeros.Text = "Pasajero";
            // 
            // cbPasDNI
            // 
            this.cbPasDNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPasDNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPasDNI.FormattingEnabled = true;
            this.cbPasDNI.Location = new System.Drawing.Point(77, 48);
            this.cbPasDNI.MaxLength = 8;
            this.cbPasDNI.Name = "cbPasDNI";
            this.cbPasDNI.Size = new System.Drawing.Size(164, 23);
            this.cbPasDNI.TabIndex = 43;
            this.cbPasDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPasDNI_KeyDown);
            this.cbPasDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPasDNI_KeyPress);
            // 
            // cbPasNombre
            // 
            this.cbPasNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPasNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPasNombre.FormattingEnabled = true;
            this.cbPasNombre.Location = new System.Drawing.Point(77, 19);
            this.cbPasNombre.Name = "cbPasNombre";
            this.cbPasNombre.Size = new System.Drawing.Size(360, 23);
            this.cbPasNombre.TabIndex = 42;
            this.cbPasNombre.SelectedIndexChanged += new System.EventHandler(this.cbPasNombre_SelectedIndexChanged);
            this.cbPasNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPasNombre_KeyDown);
            // 
            // btnBuscarPasajeros
            // 
            this.btnBuscarPasajeros.AutoSize = true;
            this.btnBuscarPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPasajeros.BackgroundImage = global::Sistema_final.Properties.Resources._698873_icon_136_document_edit_512;
            this.btnBuscarPasajeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPasajeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPasajeros.Location = new System.Drawing.Point(443, 19);
            this.btnBuscarPasajeros.Name = "btnBuscarPasajeros";
            this.btnBuscarPasajeros.Size = new System.Drawing.Size(23, 23);
            this.btnBuscarPasajeros.TabIndex = 41;
            this.ttInfo.SetToolTip(this.btnBuscarPasajeros, "Buscar pasajeros");
            this.btnBuscarPasajeros.UseVisualStyleBackColor = false;
            this.btnBuscarPasajeros.Click += new System.EventHandler(this.btnBuscarPasajeros_Click);
            // 
            // btnMasPasajeros
            // 
            this.btnMasPasajeros.AutoSize = true;
            this.btnMasPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.btnMasPasajeros.BackgroundImage = global::Sistema_final.Properties.Resources.agregar1;
            this.btnMasPasajeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasPasajeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasPasajeros.Location = new System.Drawing.Point(472, 19);
            this.btnMasPasajeros.Name = "btnMasPasajeros";
            this.btnMasPasajeros.Size = new System.Drawing.Size(23, 23);
            this.btnMasPasajeros.TabIndex = 40;
            this.ttInfo.SetToolTip(this.btnMasPasajeros, "Registrar un nuevo pasajero");
            this.btnMasPasajeros.UseVisualStyleBackColor = false;
            this.btnMasPasajeros.Click += new System.EventHandler(this.btnMasPasajeros_Click);
            // 
            // lblPasDNI
            // 
            this.lblPasDNI.AutoSize = true;
            this.lblPasDNI.Location = new System.Drawing.Point(9, 51);
            this.lblPasDNI.Name = "lblPasDNI";
            this.lblPasDNI.Size = new System.Drawing.Size(31, 15);
            this.lblPasDNI.TabIndex = 32;
            this.lblPasDNI.Text = "DNI:";
            // 
            // lblPasNombre
            // 
            this.lblPasNombre.AutoSize = true;
            this.lblPasNombre.Location = new System.Drawing.Point(9, 22);
            this.lblPasNombre.Name = "lblPasNombre";
            this.lblPasNombre.Size = new System.Drawing.Size(55, 15);
            this.lblPasNombre.TabIndex = 31;
            this.lblPasNombre.Text = "Nombre:";
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.AutoSize = true;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(884, 378);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(139, 49);
            this.btnVender.TabIndex = 29;
            this.btnVender.Text = "Confirmar";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click_1);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(32, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(45, 15);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Boleto:";
            // 
            // cbBoleto
            // 
            this.cbBoleto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoleto.Enabled = false;
            this.cbBoleto.FormattingEnabled = true;
            this.cbBoleto.Items.AddRange(new object[] {
            "IDA",
            "IDA Y VUELTA"});
            this.cbBoleto.Location = new System.Drawing.Point(100, 15);
            this.cbBoleto.Name = "cbBoleto";
            this.cbBoleto.Size = new System.Drawing.Size(129, 23);
            this.cbBoleto.TabIndex = 16;
            // 
            // btnMasOrigen
            // 
            this.btnMasOrigen.AutoSize = true;
            this.btnMasOrigen.BackgroundImage = global::Sistema_final.Properties.Resources.edit;
            this.btnMasOrigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasOrigen.Location = new System.Drawing.Point(943, 45);
            this.btnMasOrigen.Name = "btnMasOrigen";
            this.btnMasOrigen.Size = new System.Drawing.Size(25, 25);
            this.btnMasOrigen.TabIndex = 17;
            this.ttInfo.SetToolTip(this.btnMasOrigen, "Editar todos los recorridos, sus horarios y destinos");
            this.btnMasOrigen.UseVisualStyleBackColor = true;
            this.btnMasOrigen.Visible = false;
            this.btnMasOrigen.Click += new System.EventHandler(this.btnMasOrigen_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(543, 81);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 15);
            this.lblOrigen.TabIndex = 18;
            this.lblOrigen.Text = "Origen:";
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(613, 74);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(324, 23);
            this.cbOrigen.Sorted = true;
            this.cbOrigen.TabIndex = 19;
            this.cbOrigen.Tag = "destinos";
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged_1);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(543, 106);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(52, 15);
            this.lblDestino.TabIndex = 20;
            this.lblDestino.Text = "Destino:";
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(613, 103);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(324, 23);
            this.cbDestino.Sorted = true;
            this.cbDestino.TabIndex = 21;
            this.cbDestino.Tag = "destinos";
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged_1);
            // 
            // tpViajes
            // 
            this.tpViajes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tpViajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpViajes.Controls.Add(this.gbViajesHorarios);
            this.tpViajes.Controls.Add(this.gbPBModEspacio);
            this.tpViajes.Controls.Add(this.lblViajeFrecuencia);
            this.tpViajes.Controls.Add(this.clbViajeFrecuencia);
            this.tpViajes.Controls.Add(this.lblViajeHorario);
            this.tpViajes.Controls.Add(this.lblViajeRecorrido);
            this.tpViajes.Controls.Add(this.cbViajeHoraSalida);
            this.tpViajes.Controls.Add(this.cbViajeTrayecto);
            this.tpViajes.Location = new System.Drawing.Point(4, 24);
            this.tpViajes.Name = "tpViajes";
            this.tpViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tpViajes.Size = new System.Drawing.Size(1037, 451);
            this.tpViajes.TabIndex = 2;
            this.tpViajes.Text = "Viajes";
            // 
            // gbViajesHorarios
            // 
            this.gbViajesHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbViajesHorarios.AutoSize = true;
            this.gbViajesHorarios.Controls.Add(this.pnlViajeHorariosTodos);
            this.gbViajesHorarios.Controls.Add(this.rbViajesPrecios);
            this.gbViajesHorarios.Controls.Add(this.rbViajesHorarios);
            this.gbViajesHorarios.Controls.Add(this.dgvViajeTrayectos);
            this.gbViajesHorarios.Location = new System.Drawing.Point(6, 78);
            this.gbViajesHorarios.Name = "gbViajesHorarios";
            this.gbViajesHorarios.Size = new System.Drawing.Size(608, 358);
            this.gbViajesHorarios.TabIndex = 52;
            this.gbViajesHorarios.TabStop = false;
            this.gbViajesHorarios.Text = "Todos los horarios y tarifas";
            // 
            // pnlViajeHorariosTodos
            // 
            this.pnlViajeHorariosTodos.BackColor = System.Drawing.SystemColors.Control;
            this.pnlViajeHorariosTodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViajeHorariosTodos.Controls.Add(this.cbViajesHorariosTodos);
            this.pnlViajeHorariosTodos.Location = new System.Drawing.Point(140, 20);
            this.pnlViajeHorariosTodos.Name = "pnlViajeHorariosTodos";
            this.pnlViajeHorariosTodos.Size = new System.Drawing.Size(72, 25);
            this.pnlViajeHorariosTodos.TabIndex = 56;
            // 
            // cbViajesHorariosTodos
            // 
            this.cbViajesHorariosTodos.AutoSize = true;
            this.cbViajesHorariosTodos.Location = new System.Drawing.Point(3, 4);
            this.cbViajesHorariosTodos.Name = "cbViajesHorariosTodos";
            this.cbViajesHorariosTodos.Size = new System.Drawing.Size(60, 19);
            this.cbViajesHorariosTodos.TabIndex = 57;
            this.cbViajesHorariosTodos.Text = "Todos";
            this.cbViajesHorariosTodos.UseVisualStyleBackColor = true;
            this.cbViajesHorariosTodos.CheckedChanged += new System.EventHandler(this.cbViajesHorariosTodos_CheckedChanged);
            // 
            // rbViajesPrecios
            // 
            this.rbViajesPrecios.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbViajesPrecios.AutoSize = true;
            this.rbViajesPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbViajesPrecios.Location = new System.Drawing.Point(76, 20);
            this.rbViajesPrecios.Name = "rbViajesPrecios";
            this.rbViajesPrecios.Size = new System.Drawing.Size(58, 25);
            this.rbViajesPrecios.TabIndex = 54;
            this.rbViajesPrecios.Text = "Precios";
            this.rbViajesPrecios.UseVisualStyleBackColor = true;
            this.rbViajesPrecios.CheckedChanged += new System.EventHandler(this.rbViajesPrecios_CheckedChanged);
            // 
            // rbViajesHorarios
            // 
            this.rbViajesHorarios.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbViajesHorarios.AutoSize = true;
            this.rbViajesHorarios.Checked = true;
            this.rbViajesHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbViajesHorarios.Location = new System.Drawing.Point(6, 20);
            this.rbViajesHorarios.Name = "rbViajesHorarios";
            this.rbViajesHorarios.Size = new System.Drawing.Size(64, 25);
            this.rbViajesHorarios.TabIndex = 53;
            this.rbViajesHorarios.TabStop = true;
            this.rbViajesHorarios.Text = "Horarios";
            this.rbViajesHorarios.UseVisualStyleBackColor = true;
            this.rbViajesHorarios.CheckedChanged += new System.EventHandler(this.rbViajesHorarios_CheckedChanged);
            // 
            // dgvViajeTrayectos
            // 
            this.dgvViajeTrayectos.AllowUserToAddRows = false;
            this.dgvViajeTrayectos.AllowUserToDeleteRows = false;
            this.dgvViajeTrayectos.AllowUserToResizeColumns = false;
            this.dgvViajeTrayectos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajeTrayectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajeTrayectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViajeTrayectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViajeTrayectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViajeTrayectos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViajeTrayectos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViajeTrayectos.Location = new System.Drawing.Point(5, 52);
            this.dgvViajeTrayectos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViajeTrayectos.MultiSelect = false;
            this.dgvViajeTrayectos.Name = "dgvViajeTrayectos";
            this.dgvViajeTrayectos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViajeTrayectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViajeTrayectos.RowHeadersVisible = false;
            this.dgvViajeTrayectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvViajeTrayectos.RowTemplate.Height = 24;
            this.dgvViajeTrayectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvViajeTrayectos.Size = new System.Drawing.Size(594, 284);
            this.dgvViajeTrayectos.TabIndex = 40;
            // 
            // gbPBModEspacio
            // 
            this.gbPBModEspacio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPBModEspacio.AutoSize = true;
            this.gbPBModEspacio.Controls.Add(this.rbPA);
            this.gbPBModEspacio.Controls.Add(this.rbPB);
            this.gbPBModEspacio.Controls.Add(this.dgvAsientos);
            this.gbPBModEspacio.Location = new System.Drawing.Point(620, 78);
            this.gbPBModEspacio.Name = "gbPBModEspacio";
            this.gbPBModEspacio.Size = new System.Drawing.Size(244, 358);
            this.gbPBModEspacio.TabIndex = 51;
            this.gbPBModEspacio.TabStop = false;
            this.gbPBModEspacio.Text = "Distribución de asientos";
            // 
            // rbPA
            // 
            this.rbPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPA.AutoSize = true;
            this.rbPA.Location = new System.Drawing.Point(99, 26);
            this.rbPA.Name = "rbPA";
            this.rbPA.Size = new System.Drawing.Size(83, 19);
            this.rbPA.TabIndex = 13;
            this.rbPA.Text = "Planta alta";
            this.rbPA.UseVisualStyleBackColor = true;
            this.rbPA.CheckedChanged += new System.EventHandler(this.rbPA_CheckedChanged);
            // 
            // rbPB
            // 
            this.rbPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPB.AutoSize = true;
            this.rbPB.Checked = true;
            this.rbPB.Location = new System.Drawing.Point(6, 26);
            this.rbPB.Name = "rbPB";
            this.rbPB.Size = new System.Drawing.Size(87, 19);
            this.rbPB.TabIndex = 12;
            this.rbPB.TabStop = true;
            this.rbPB.Text = "Planta baja";
            this.rbPB.UseVisualStyleBackColor = true;
            this.rbPB.CheckedChanged += new System.EventHandler(this.rbPB_CheckedChanged);
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AllowUserToResizeColumns = false;
            this.dgvAsientos.AllowUserToResizeRows = false;
            this.dgvAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAsientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.ColumnHeadersVisible = false;
            this.dgvAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C4,
            this.C5,
            this.C2,
            this.C3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsientos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAsientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAsientos.GridColor = System.Drawing.Color.White;
            this.dgvAsientos.Location = new System.Drawing.Point(6, 77);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAsientos.RowHeadersVisible = false;
            this.dgvAsientos.RowHeadersWidth = 60;
            this.dgvAsientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvAsientos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAsientos.RowTemplate.Height = 50;
            this.dgvAsientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsientos.Size = new System.Drawing.Size(229, 259);
            this.dgvAsientos.TabIndex = 0;
            // 
            // C1
            // 
            this.C1.HeaderText = "";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // C4
            // 
            this.C4.HeaderText = "";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            // 
            // C5
            // 
            this.C5.HeaderText = "";
            this.C5.Name = "C5";
            this.C5.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // C3
            // 
            this.C3.HeaderText = "";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            // 
            // lblViajeFrecuencia
            // 
            this.lblViajeFrecuencia.AutoSize = true;
            this.lblViajeFrecuencia.Location = new System.Drawing.Point(418, 40);
            this.lblViajeFrecuencia.Name = "lblViajeFrecuencia";
            this.lblViajeFrecuencia.Size = new System.Drawing.Size(71, 15);
            this.lblViajeFrecuencia.TabIndex = 50;
            this.lblViajeFrecuencia.Text = "Frecuencia:";
            // 
            // clbViajeFrecuencia
            // 
            this.clbViajeFrecuencia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clbViajeFrecuencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbViajeFrecuencia.CheckOnClick = true;
            this.clbViajeFrecuencia.ColumnWidth = 80;
            this.clbViajeFrecuencia.FormattingEnabled = true;
            this.clbViajeFrecuencia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.clbViajeFrecuencia.Location = new System.Drawing.Point(495, 40);
            this.clbViajeFrecuencia.MultiColumn = true;
            this.clbViajeFrecuencia.Name = "clbViajeFrecuencia";
            this.clbViajeFrecuencia.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbViajeFrecuencia.Size = new System.Drawing.Size(324, 32);
            this.clbViajeFrecuencia.TabIndex = 49;
            // 
            // lblViajeHorario
            // 
            this.lblViajeHorario.AutoSize = true;
            this.lblViajeHorario.Location = new System.Drawing.Point(6, 43);
            this.lblViajeHorario.Name = "lblViajeHorario";
            this.lblViajeHorario.Size = new System.Drawing.Size(51, 15);
            this.lblViajeHorario.TabIndex = 43;
            this.lblViajeHorario.Text = "Horario:";
            // 
            // lblViajeRecorrido
            // 
            this.lblViajeRecorrido.AutoSize = true;
            this.lblViajeRecorrido.Location = new System.Drawing.Point(6, 14);
            this.lblViajeRecorrido.Name = "lblViajeRecorrido";
            this.lblViajeRecorrido.Size = new System.Drawing.Size(64, 15);
            this.lblViajeRecorrido.TabIndex = 42;
            this.lblViajeRecorrido.Text = "Recorrido:";
            // 
            // cbViajeHoraSalida
            // 
            this.cbViajeHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViajeHoraSalida.FormattingEnabled = true;
            this.cbViajeHoraSalida.Location = new System.Drawing.Point(83, 40);
            this.cbViajeHoraSalida.Name = "cbViajeHoraSalida";
            this.cbViajeHoraSalida.Size = new System.Drawing.Size(74, 23);
            this.cbViajeHoraSalida.TabIndex = 41;
            this.cbViajeHoraSalida.SelectedIndexChanged += new System.EventHandler(this.cbViajeHoraSalida_SelectedIndexChanged);
            // 
            // cbViajeTrayecto
            // 
            this.cbViajeTrayecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViajeTrayecto.FormattingEnabled = true;
            this.cbViajeTrayecto.Location = new System.Drawing.Point(83, 11);
            this.cbViajeTrayecto.Name = "cbViajeTrayecto";
            this.cbViajeTrayecto.Size = new System.Drawing.Size(324, 23);
            this.cbViajeTrayecto.TabIndex = 39;
            this.cbViajeTrayecto.Tag = "destinos";
            this.cbViajeTrayecto.SelectedIndexChanged += new System.EventHandler(this.cbViajeTrayecto_SelectedIndexChanged);
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.configuracionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1069, 24);
            this.msPrincipal.TabIndex = 8;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFuenteDeDatosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.borrar1;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirFuenteDeDatosToolStripMenuItem
            // 
            this.abrirFuenteDeDatosToolStripMenuItem.Name = "abrirFuenteDeDatosToolStripMenuItem";
            this.abrirFuenteDeDatosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.abrirFuenteDeDatosToolStripMenuItem.Text = "Abrir fuente de datos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartadosAdministrativosToolStripMenuItem,
            this.boletosToolStripMenuItem});
            this.verToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.tarjeta;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // apartadosAdministrativosToolStripMenuItem
            // 
            this.apartadosAdministrativosToolStripMenuItem.Name = "apartadosAdministrativosToolStripMenuItem";
            this.apartadosAdministrativosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.apartadosAdministrativosToolStripMenuItem.Text = "Apartados administrativos";
            this.apartadosAdministrativosToolStripMenuItem.Click += new System.EventHandler(this.apartadosAdministrativosToolStripMenuItem_Click);
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.Checked = true;
            this.boletosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.boletosToolStripMenuItem.Text = "Boletos";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeRecorridosToolStripMenuItem,
            this.editorDePasajerosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.herramientas;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // editorDeRecorridosToolStripMenuItem
            // 
            this.editorDeRecorridosToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.rango;
            this.editorDeRecorridosToolStripMenuItem.Name = "editorDeRecorridosToolStripMenuItem";
            this.editorDeRecorridosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.editorDeRecorridosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editorDeRecorridosToolStripMenuItem.Text = "Editor de viajes";
            this.editorDeRecorridosToolStripMenuItem.Click += new System.EventHandler(this.editorDeRecorridosToolStripMenuItem_Click);
            // 
            // editorDePasajerosToolStripMenuItem
            // 
            this.editorDePasajerosToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.inventario;
            this.editorDePasajerosToolStripMenuItem.Name = "editorDePasajerosToolStripMenuItem";
            this.editorDePasajerosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editorDePasajerosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editorDePasajerosToolStripMenuItem.Text = "Editor de pasajeros";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDirectorioPrincipalToolStripMenuItem,
            this.idaYVueltaToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.configuracion_16;
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // cambiarDirectorioPrincipalToolStripMenuItem
            // 
            this.cambiarDirectorioPrincipalToolStripMenuItem.Name = "cambiarDirectorioPrincipalToolStripMenuItem";
            this.cambiarDirectorioPrincipalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cambiarDirectorioPrincipalToolStripMenuItem.Text = "Cambiar directorios";
            // 
            // idaYVueltaToolStripMenuItem
            // 
            this.idaYVueltaToolStripMenuItem.Checked = true;
            this.idaYVueltaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idaYVueltaToolStripMenuItem.Name = "idaYVueltaToolStripMenuItem";
            this.idaYVueltaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.idaYVueltaToolStripMenuItem.Text = "Ida y vuelta";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.info;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Image = global::Sistema_final.Properties.Resources.assist;
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la ayuda";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_final.Properties.Resources.fondo_textura_pared_cemento_grunge_blanco_banner_color_azul_7190_429;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 525);
            this.Controls.Add(this.pnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleteria - BETA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.cmsOpciones.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.tcOpciones.ResumeLayout(false);
            this.tpPasajes.ResumeLayout(false);
            this.tpPasajes.PerformLayout();
            this.pnlPasajes.ResumeLayout(false);
            this.pnlPasajes.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbVuelta.ResumeLayout(false);
            this.gbVuelta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).EndInit();
            this.gbIda.ResumeLayout(false);
            this.gbIda.PerformLayout();
            this.gbBuscarPasaje.ResumeLayout(false);
            this.gbBuscarPasaje.PerformLayout();
            this.gbPasajeros.ResumeLayout(false);
            this.gbPasajeros.PerformLayout();
            this.tpViajes.ResumeLayout(false);
            this.tpViajes.PerformLayout();
            this.gbViajesHorarios.ResumeLayout(false);
            this.gbViajesHorarios.PerformLayout();
            this.pnlViajeHorariosTodos.ResumeLayout(false);
            this.pnlViajeHorariosTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeTrayectos)).EndInit();
            this.gbPBModEspacio.ResumeLayout(false);
            this.gbPBModEspacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.TabControl tcOpciones;
        private System.Windows.Forms.TabPage tpPasajes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlPasajes;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dtpFechaIda;
        private System.Windows.Forms.ComboBox cbBoleto;
        private System.Windows.Forms.Label lblFechaIda;
        private System.Windows.Forms.Button btnMasOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblAsientoIda;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.GroupBox gbPasajeros;
        private System.Windows.Forms.Label lblPasDNI;
        private System.Windows.Forms.Label lblPasNombre;
        private System.Windows.Forms.Label lblHoraLlegadaIda;
        private System.Windows.Forms.Label lblHoraSalidaIda;
        public System.Windows.Forms.DataGridView dgvBoletos;
        private System.Windows.Forms.GroupBox gbBuscarPasaje;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbDestino;
        private System.Windows.Forms.RadioButton rbOrigen;
        private System.Windows.Forms.RadioButton rbPasajero;
        private System.Windows.Forms.ComboBox cbTrayecto;
        private System.Windows.Forms.Label lblTrayecto;
        private System.Windows.Forms.GroupBox gbIda;
        private System.Windows.Forms.Button btnMasAsientosIda;
        private System.Windows.Forms.TextBox tbAsientoIda;
        private System.Windows.Forms.GroupBox gbVuelta;
        private System.Windows.Forms.ComboBox cbHoraSalidaVuelta;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegadVuelta;
        private System.Windows.Forms.TextBox tbAsientoVuelta;
        private System.Windows.Forms.DateTimePicker dtpFechaVuelta;
        private System.Windows.Forms.Label lblFechaVuelta;
        private System.Windows.Forms.Label lblAsientoVuelta;
        private System.Windows.Forms.Label lblHoraLLegadaVuelta;
        private System.Windows.Forms.Label lblHoraSalidaVuelta;
        private System.Windows.Forms.ComboBox cbHoraSalidaIda;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegadaIda;
        private System.Windows.Forms.Button btnMasPasajeros;
        private System.Windows.Forms.TabPage tpViajes;
        private System.Windows.Forms.Button btnMasAsientosVuelta;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rbFiltrosVendidos;
        private System.Windows.Forms.RadioButton rbFiltrosPendientes;
        private System.Windows.Forms.RadioButton rbFiltrosDiaHoy;
        private System.Windows.Forms.RadioButton rbFiltroTodos;
        private System.Windows.Forms.RadioButton rbFiltrosExpirados;
        private System.Windows.Forms.RadioButton rbFiltrosRecorrido;
        private System.Windows.Forms.ToolStripMenuItem venderItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarItem;
        private System.Windows.Forms.Button btnBuscarPasajeros;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.ComboBox cbPasNombre;
        private System.Windows.Forms.ComboBox cbPasDNI;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ComboBox cbViajeTrayecto;
        private System.Windows.Forms.DataGridView dgvViajeTrayectos;
        private System.Windows.Forms.ComboBox cbViajeHoraSalida;
        private System.Windows.Forms.Label lblViajeHorario;
        private System.Windows.Forms.Label lblViajeRecorrido;
        private System.Windows.Forms.Label lblViajeFrecuencia;
        private System.Windows.Forms.CheckedListBox clbViajeFrecuencia;
        private System.Windows.Forms.GroupBox gbViajesHorarios;
        private System.Windows.Forms.GroupBox gbPBModEspacio;
        private System.Windows.Forms.RadioButton rbPA;
        private System.Windows.Forms.RadioButton rbPB;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.DataGridViewButtonColumn C1;
        private System.Windows.Forms.DataGridViewButtonColumn C4;
        private System.Windows.Forms.DataGridViewButtonColumn C5;
        private System.Windows.Forms.DataGridViewButtonColumn C2;
        private System.Windows.Forms.DataGridViewButtonColumn C3;
        private System.Windows.Forms.RadioButton rbViajesPrecios;
        private System.Windows.Forms.RadioButton rbViajesHorarios;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.Panel pnlViajeHorariosTodos;
        private System.Windows.Forms.CheckBox cbViajesHorariosTodos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFuenteDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartadosAdministrativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeRecorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDePasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDirectorioPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idaYVueltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInfoItem;
        private System.Windows.Forms.ComboBox cbBuscarPasajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trayecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.RadioButton rbDNI;
    }
}

