namespace Sistema_final
{
    partial class frmAsientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsientos));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tcAsientos = new System.Windows.Forms.TabControl();
            this.tpAsientosPer = new System.Windows.Forms.TabPage();
            this.gbAsientosAdmin = new System.Windows.Forms.GroupBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.lblDistrNota = new System.Windows.Forms.Label();
            this.gbPBModEspacio = new System.Windows.Forms.GroupBox();
            this.gbDistrTipos = new System.Windows.Forms.GroupBox();
            this.rbPBModENinguno = new System.Windows.Forms.RadioButton();
            this.rbPBModEAsiento = new System.Windows.Forms.RadioButton();
            this.rbPBModETelevision = new System.Windows.Forms.RadioButton();
            this.rbPBModEPasillo = new System.Windows.Forms.RadioButton();
            this.rbPA = new System.Windows.Forms.RadioButton();
            this.btnPBModEGuardar = new System.Windows.Forms.Button();
            this.btnDistrCrear = new System.Windows.Forms.Button();
            this.rbPB = new System.Windows.Forms.RadioButton();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPBDistrCant = new System.Windows.Forms.Label();
            this.nudDistrCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbDistrPisos = new System.Windows.Forms.ComboBox();
            this.lblDistrPisos = new System.Windows.Forms.Label();
            this.lblDistr = new System.Windows.Forms.Label();
            this.cbDistrDistribucion = new System.Windows.Forms.ComboBox();
            this.rbDistrMod = new System.Windows.Forms.RadioButton();
            this.rbDistrCrear = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcAsientos.SuspendLayout();
            this.tpAsientosPer.SuspendLayout();
            this.gbAsientosAdmin.SuspendLayout();
            this.gbPBModEspacio.SuspendLayout();
            this.gbDistrTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistrCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccionar.Location = new System.Drawing.Point(685, 401);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 27);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(590, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tcAsientos
            // 
            this.tcAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAsientos.Controls.Add(this.tpAsientosPer);
            this.tcAsientos.Controls.Add(this.tabPage1);
            this.tcAsientos.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcAsientos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tcAsientos.Location = new System.Drawing.Point(12, 12);
            this.tcAsientos.Name = "tcAsientos";
            this.tcAsientos.SelectedIndex = 0;
            this.tcAsientos.Size = new System.Drawing.Size(753, 383);
            this.tcAsientos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAsientos.TabIndex = 10;
            this.tcAsientos.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAsientos_Selecting);
            // 
            // tpAsientosPer
            // 
            this.tpAsientosPer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tpAsientosPer.Controls.Add(this.gbAsientosAdmin);
            this.tpAsientosPer.Location = new System.Drawing.Point(4, 24);
            this.tpAsientosPer.Name = "tpAsientosPer";
            this.tpAsientosPer.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsientosPer.Size = new System.Drawing.Size(745, 355);
            this.tpAsientosPer.TabIndex = 4;
            this.tpAsientosPer.Text = "tabPage1";
            this.tpAsientosPer.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gbAsientosAdmin
            // 
            this.gbAsientosAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAsientosAdmin.Controls.Add(this.tbNota);
            this.gbAsientosAdmin.Controls.Add(this.lblDistrNota);
            this.gbAsientosAdmin.Controls.Add(this.gbPBModEspacio);
            this.gbAsientosAdmin.Controls.Add(this.cbDistrPisos);
            this.gbAsientosAdmin.Controls.Add(this.lblDistrPisos);
            this.gbAsientosAdmin.Controls.Add(this.lblDistr);
            this.gbAsientosAdmin.Controls.Add(this.cbDistrDistribucion);
            this.gbAsientosAdmin.Controls.Add(this.rbDistrMod);
            this.gbAsientosAdmin.Controls.Add(this.rbDistrCrear);
            this.gbAsientosAdmin.Location = new System.Drawing.Point(7, 7);
            this.gbAsientosAdmin.Name = "gbAsientosAdmin";
            this.gbAsientosAdmin.Size = new System.Drawing.Size(732, 345);
            this.gbAsientosAdmin.TabIndex = 1;
            this.gbAsientosAdmin.TabStop = false;
            this.gbAsientosAdmin.Text = "Administración - Distribución de asientos";
            this.gbAsientosAdmin.Enter += new System.EventHandler(this.gbAsientosAdmin_Enter);
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(90, 77);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(140, 21);
            this.tbNota.TabIndex = 13;
            // 
            // lblDistrNota
            // 
            this.lblDistrNota.AutoSize = true;
            this.lblDistrNota.Location = new System.Drawing.Point(9, 79);
            this.lblDistrNota.Name = "lblDistrNota";
            this.lblDistrNota.Size = new System.Drawing.Size(36, 15);
            this.lblDistrNota.TabIndex = 12;
            this.lblDistrNota.Text = "Nota:";
            // 
            // gbPBModEspacio
            // 
            this.gbPBModEspacio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPBModEspacio.Controls.Add(this.gbDistrTipos);
            this.gbPBModEspacio.Controls.Add(this.rbPA);
            this.gbPBModEspacio.Controls.Add(this.btnPBModEGuardar);
            this.gbPBModEspacio.Controls.Add(this.btnDistrCrear);
            this.gbPBModEspacio.Controls.Add(this.rbPB);
            this.gbPBModEspacio.Controls.Add(this.dgvAsientos);
            this.gbPBModEspacio.Controls.Add(this.lblPBDistrCant);
            this.gbPBModEspacio.Controls.Add(this.nudDistrCantidad);
            this.gbPBModEspacio.Location = new System.Drawing.Point(236, 20);
            this.gbPBModEspacio.Name = "gbPBModEspacio";
            this.gbPBModEspacio.Size = new System.Drawing.Size(476, 319);
            this.gbPBModEspacio.TabIndex = 6;
            this.gbPBModEspacio.TabStop = false;
            this.gbPBModEspacio.Text = "Distribución:";
            // 
            // gbDistrTipos
            // 
            this.gbDistrTipos.Controls.Add(this.rbPBModENinguno);
            this.gbDistrTipos.Controls.Add(this.rbPBModEAsiento);
            this.gbDistrTipos.Controls.Add(this.rbPBModETelevision);
            this.gbDistrTipos.Controls.Add(this.rbPBModEPasillo);
            this.gbDistrTipos.Location = new System.Drawing.Point(241, 70);
            this.gbDistrTipos.Name = "gbDistrTipos";
            this.gbDistrTipos.Size = new System.Drawing.Size(229, 198);
            this.gbDistrTipos.TabIndex = 12;
            this.gbDistrTipos.TabStop = false;
            this.gbDistrTipos.Text = "Tipos";
            // 
            // rbPBModENinguno
            // 
            this.rbPBModENinguno.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPBModENinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPBModENinguno.Location = new System.Drawing.Point(17, 20);
            this.rbPBModENinguno.Name = "rbPBModENinguno";
            this.rbPBModENinguno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPBModENinguno.Size = new System.Drawing.Size(190, 38);
            this.rbPBModENinguno.TabIndex = 3;
            this.rbPBModENinguno.TabStop = true;
            this.rbPBModENinguno.Text = "Ninguno";
            this.rbPBModENinguno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPBModENinguno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPBModENinguno.UseVisualStyleBackColor = true;
            this.rbPBModENinguno.Click += new System.EventHandler(this.btnModEGuardar_Click);
            // 
            // rbPBModEAsiento
            // 
            this.rbPBModEAsiento.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPBModEAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPBModEAsiento.Image = global::Sistema_final.Properties.Resources.butaca1;
            this.rbPBModEAsiento.Location = new System.Drawing.Point(17, 64);
            this.rbPBModEAsiento.Name = "rbPBModEAsiento";
            this.rbPBModEAsiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPBModEAsiento.Size = new System.Drawing.Size(190, 38);
            this.rbPBModEAsiento.TabIndex = 0;
            this.rbPBModEAsiento.TabStop = true;
            this.rbPBModEAsiento.Text = "Butaca";
            this.rbPBModEAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPBModEAsiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPBModEAsiento.UseVisualStyleBackColor = true;
            this.rbPBModEAsiento.Click += new System.EventHandler(this.btnModEGuardar_Click);
            // 
            // rbPBModETelevision
            // 
            this.rbPBModETelevision.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPBModETelevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPBModETelevision.Image = global::Sistema_final.Properties.Resources.tele21;
            this.rbPBModETelevision.Location = new System.Drawing.Point(17, 108);
            this.rbPBModETelevision.Name = "rbPBModETelevision";
            this.rbPBModETelevision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPBModETelevision.Size = new System.Drawing.Size(190, 38);
            this.rbPBModETelevision.TabIndex = 1;
            this.rbPBModETelevision.TabStop = true;
            this.rbPBModETelevision.Text = "Televisión";
            this.rbPBModETelevision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPBModETelevision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPBModETelevision.UseVisualStyleBackColor = true;
            this.rbPBModETelevision.Click += new System.EventHandler(this.btnModEGuardar_Click);
            // 
            // rbPBModEPasillo
            // 
            this.rbPBModEPasillo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPBModEPasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPBModEPasillo.Image = global::Sistema_final.Properties.Resources.pasillo_asiento;
            this.rbPBModEPasillo.Location = new System.Drawing.Point(17, 152);
            this.rbPBModEPasillo.Name = "rbPBModEPasillo";
            this.rbPBModEPasillo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPBModEPasillo.Size = new System.Drawing.Size(190, 38);
            this.rbPBModEPasillo.TabIndex = 2;
            this.rbPBModEPasillo.TabStop = true;
            this.rbPBModEPasillo.Text = "Pasillo";
            this.rbPBModEPasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPBModEPasillo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPBModEPasillo.UseVisualStyleBackColor = true;
            this.rbPBModEPasillo.Click += new System.EventHandler(this.btnModEGuardar_Click);
            // 
            // rbPA
            // 
            this.rbPA.AutoSize = true;
            this.rbPA.Location = new System.Drawing.Point(99, 20);
            this.rbPA.Name = "rbPA";
            this.rbPA.Size = new System.Drawing.Size(83, 19);
            this.rbPA.TabIndex = 13;
            this.rbPA.Text = "Planta alta";
            this.rbPA.UseVisualStyleBackColor = true;
            this.rbPA.CheckedChanged += new System.EventHandler(this.rbPA_CheckedChanged);
            // 
            // btnPBModEGuardar
            // 
            this.btnPBModEGuardar.AutoSize = true;
            this.btnPBModEGuardar.Image = global::Sistema_final.Properties.Resources.guardar;
            this.btnPBModEGuardar.Location = new System.Drawing.Point(431, 13);
            this.btnPBModEGuardar.Name = "btnPBModEGuardar";
            this.btnPBModEGuardar.Size = new System.Drawing.Size(39, 38);
            this.btnPBModEGuardar.TabIndex = 4;
            this.btnPBModEGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPBModEGuardar.UseVisualStyleBackColor = true;
            this.btnPBModEGuardar.Visible = false;
            this.btnPBModEGuardar.Click += new System.EventHandler(this.btnModEGuardar_Click);
            // 
            // btnDistrCrear
            // 
            this.btnDistrCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistrCrear.Image = global::Sistema_final.Properties.Resources.crear1;
            this.btnDistrCrear.Location = new System.Drawing.Point(346, 272);
            this.btnDistrCrear.Name = "btnDistrCrear";
            this.btnDistrCrear.Size = new System.Drawing.Size(124, 41);
            this.btnDistrCrear.TabIndex = 11;
            this.btnDistrCrear.Text = "Crear";
            this.btnDistrCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDistrCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistrCrear.UseVisualStyleBackColor = true;
            this.btnDistrCrear.Click += new System.EventHandler(this.btnDistrCrear_Click);
            // 
            // rbPB
            // 
            this.rbPB.AutoSize = true;
            this.rbPB.Checked = true;
            this.rbPB.Location = new System.Drawing.Point(6, 20);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAsientos.GridColor = System.Drawing.Color.White;
            this.dgvAsientos.Location = new System.Drawing.Point(6, 45);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsientos.RowHeadersVisible = false;
            this.dgvAsientos.RowHeadersWidth = 60;
            this.dgvAsientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvAsientos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsientos.RowTemplate.Height = 50;
            this.dgvAsientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsientos.Size = new System.Drawing.Size(229, 266);
            this.dgvAsientos.TabIndex = 0;
            this.dgvAsientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsientosTOdos_CellClick);
            this.dgvAsientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsientosTOdos_CellContentClick);
            this.dgvAsientos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsientosTOdos_CellMouseUp);
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
            // lblPBDistrCant
            // 
            this.lblPBDistrCant.AutoSize = true;
            this.lblPBDistrCant.Location = new System.Drawing.Point(241, 45);
            this.lblPBDistrCant.Name = "lblPBDistrCant";
            this.lblPBDistrCant.Size = new System.Drawing.Size(60, 15);
            this.lblPBDistrCant.TabIndex = 4;
            this.lblPBDistrCant.Text = "Espacios:";
            // 
            // nudDistrCantidad
            // 
            this.nudDistrCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDistrCantidad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDistrCantidad.Location = new System.Drawing.Point(306, 43);
            this.nudDistrCantidad.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDistrCantidad.Name = "nudDistrCantidad";
            this.nudDistrCantidad.ReadOnly = true;
            this.nudDistrCantidad.Size = new System.Drawing.Size(74, 21);
            this.nudDistrCantidad.TabIndex = 5;
            this.nudDistrCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDistrCantidad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDistrCantidad.ValueChanged += new System.EventHandler(this.nudDistrPBCant_ValueChanged);
            // 
            // cbDistrPisos
            // 
            this.cbDistrPisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrPisos.FormattingEnabled = true;
            this.cbDistrPisos.Items.AddRange(new object[] {
            "UNO",
            "DOS"});
            this.cbDistrPisos.Location = new System.Drawing.Point(90, 104);
            this.cbDistrPisos.Name = "cbDistrPisos";
            this.cbDistrPisos.Size = new System.Drawing.Size(74, 23);
            this.cbDistrPisos.TabIndex = 9;
            this.cbDistrPisos.SelectedIndexChanged += new System.EventHandler(this.cbDistrPisos_SelectedIndexChanged);
            // 
            // lblDistrPisos
            // 
            this.lblDistrPisos.AutoSize = true;
            this.lblDistrPisos.Location = new System.Drawing.Point(9, 107);
            this.lblDistrPisos.Name = "lblDistrPisos";
            this.lblDistrPisos.Size = new System.Drawing.Size(40, 15);
            this.lblDistrPisos.TabIndex = 8;
            this.lblDistrPisos.Text = "Pisos:";
            // 
            // lblDistr
            // 
            this.lblDistr.AutoSize = true;
            this.lblDistr.Enabled = false;
            this.lblDistr.Location = new System.Drawing.Point(9, 51);
            this.lblDistr.Name = "lblDistr";
            this.lblDistr.Size = new System.Drawing.Size(75, 15);
            this.lblDistr.TabIndex = 3;
            this.lblDistr.Text = "Distribución:";
            // 
            // cbDistrDistribucion
            // 
            this.cbDistrDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrDistribucion.Enabled = false;
            this.cbDistrDistribucion.FormattingEnabled = true;
            this.cbDistrDistribucion.Location = new System.Drawing.Point(90, 48);
            this.cbDistrDistribucion.Name = "cbDistrDistribucion";
            this.cbDistrDistribucion.Size = new System.Drawing.Size(140, 23);
            this.cbDistrDistribucion.TabIndex = 2;
            this.cbDistrDistribucion.SelectedIndexChanged += new System.EventHandler(this.cbDistrDistribucion_SelectedIndexChanged);
            // 
            // rbDistrMod
            // 
            this.rbDistrMod.AutoSize = true;
            this.rbDistrMod.Enabled = false;
            this.rbDistrMod.Location = new System.Drawing.Point(77, 20);
            this.rbDistrMod.Name = "rbDistrMod";
            this.rbDistrMod.Size = new System.Drawing.Size(76, 19);
            this.rbDistrMod.TabIndex = 1;
            this.rbDistrMod.Text = "Modificar";
            this.rbDistrMod.UseVisualStyleBackColor = true;
            this.rbDistrMod.CheckedChanged += new System.EventHandler(this.rbDistrMod_CheckedChanged);
            // 
            // rbDistrCrear
            // 
            this.rbDistrCrear.AutoSize = true;
            this.rbDistrCrear.Checked = true;
            this.rbDistrCrear.Location = new System.Drawing.Point(12, 20);
            this.rbDistrCrear.Name = "rbDistrCrear";
            this.rbDistrCrear.Size = new System.Drawing.Size(55, 19);
            this.rbDistrCrear.TabIndex = 0;
            this.rbDistrCrear.TabStop = true;
            this.rbDistrCrear.Text = "Crear";
            this.rbDistrCrear.UseVisualStyleBackColor = true;
            this.rbDistrCrear.CheckedChanged += new System.EventHandler(this.rbDistrCrear_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 355);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            // 
            // frmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 432);
            this.Controls.Add(this.tcAsientos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asientos";
            this.Load += new System.EventHandler(this.frmAsientos_Load);
            this.tcAsientos.ResumeLayout(false);
            this.tpAsientosPer.ResumeLayout(false);
            this.gbAsientosAdmin.ResumeLayout(false);
            this.gbAsientosAdmin.PerformLayout();
            this.gbPBModEspacio.ResumeLayout(false);
            this.gbPBModEspacio.PerformLayout();
            this.gbDistrTipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistrCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tcAsientos;
        private System.Windows.Forms.TabPage tpAsientosPer;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.DataGridViewButtonColumn C1;
        private System.Windows.Forms.DataGridViewButtonColumn C4;
        private System.Windows.Forms.DataGridViewButtonColumn C5;
        private System.Windows.Forms.DataGridViewButtonColumn C2;
        private System.Windows.Forms.DataGridViewButtonColumn C3;
        private System.Windows.Forms.GroupBox gbAsientosAdmin;
        private System.Windows.Forms.GroupBox gbPBModEspacio;
        private System.Windows.Forms.RadioButton rbPBModEAsiento;
        private System.Windows.Forms.NumericUpDown nudDistrCantidad;
        private System.Windows.Forms.Label lblPBDistrCant;
        private System.Windows.Forms.Label lblDistr;
        private System.Windows.Forms.ComboBox cbDistrDistribucion;
        private System.Windows.Forms.RadioButton rbDistrMod;
        private System.Windows.Forms.RadioButton rbDistrCrear;
        private System.Windows.Forms.RadioButton rbPBModETelevision;
        private System.Windows.Forms.RadioButton rbPBModEPasillo;
        private System.Windows.Forms.Button btnPBModEGuardar;
        private System.Windows.Forms.RadioButton rbPBModENinguno;
        private System.Windows.Forms.ComboBox cbDistrPisos;
        private System.Windows.Forms.Label lblDistrPisos;
        private System.Windows.Forms.Button btnDistrCrear;
        private System.Windows.Forms.RadioButton rbPA;
        private System.Windows.Forms.RadioButton rbPB;
        private System.Windows.Forms.GroupBox gbDistrTipos;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label lblDistrNota;
        private System.Windows.Forms.TabPage tabPage1;
    }
}