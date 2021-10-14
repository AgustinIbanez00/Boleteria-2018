namespace Sistema_final
{
    partial class frmMetodoDePago
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
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.gbMetodos = new System.Windows.Forms.GroupBox();
            this.rbPaypal = new System.Windows.Forms.RadioButton();
            this.rbRapiPago = new System.Windows.Forms.RadioButton();
            this.rbPagoFacil = new System.Windows.Forms.RadioButton();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.tbNroTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbMetodos.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.BackColor = System.Drawing.Color.LimeGreen;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(6, 20);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(67, 25);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Tag = "metodos";
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = false;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbMetodos_CheckedChanged);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.BackColor = System.Drawing.Color.DarkOrange;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(81, 22);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(130, 25);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Tag = "metodos";
            this.rbTarjeta.Text = "Tarjeta de crédito";
            this.rbTarjeta.UseVisualStyleBackColor = false;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbMetodos_CheckedChanged);
            // 
            // gbMetodos
            // 
            this.gbMetodos.Controls.Add(this.rbPaypal);
            this.gbMetodos.Controls.Add(this.rbRapiPago);
            this.gbMetodos.Controls.Add(this.rbPagoFacil);
            this.gbMetodos.Controls.Add(this.rbEfectivo);
            this.gbMetodos.Controls.Add(this.rbTarjeta);
            this.gbMetodos.Location = new System.Drawing.Point(12, 12);
            this.gbMetodos.Name = "gbMetodos";
            this.gbMetodos.Size = new System.Drawing.Size(288, 86);
            this.gbMetodos.TabIndex = 3;
            this.gbMetodos.TabStop = false;
            this.gbMetodos.Text = "Métodos de pago";
            // 
            // rbPaypal
            // 
            this.rbPaypal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPaypal.AutoSize = true;
            this.rbPaypal.BackColor = System.Drawing.Color.AliceBlue;
            this.rbPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaypal.Location = new System.Drawing.Point(187, 53);
            this.rbPaypal.Name = "rbPaypal";
            this.rbPaypal.Size = new System.Drawing.Size(60, 25);
            this.rbPaypal.TabIndex = 4;
            this.rbPaypal.TabStop = true;
            this.rbPaypal.Tag = "metodos";
            this.rbPaypal.Text = "Paypal";
            this.rbPaypal.UseVisualStyleBackColor = false;
            // 
            // rbRapiPago
            // 
            this.rbRapiPago.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRapiPago.AutoSize = true;
            this.rbRapiPago.BackColor = System.Drawing.Color.Tomato;
            this.rbRapiPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRapiPago.Location = new System.Drawing.Point(6, 51);
            this.rbRapiPago.Name = "rbRapiPago";
            this.rbRapiPago.Size = new System.Drawing.Size(80, 25);
            this.rbRapiPago.TabIndex = 3;
            this.rbRapiPago.TabStop = true;
            this.rbRapiPago.Tag = "metodos";
            this.rbRapiPago.Text = "RapiPago";
            this.rbRapiPago.UseVisualStyleBackColor = false;
            this.rbRapiPago.CheckedChanged += new System.EventHandler(this.rbMetodos_CheckedChanged);
            // 
            // rbPagoFacil
            // 
            this.rbPagoFacil.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPagoFacil.AutoSize = true;
            this.rbPagoFacil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbPagoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagoFacil.Location = new System.Drawing.Point(94, 53);
            this.rbPagoFacil.Name = "rbPagoFacil";
            this.rbPagoFacil.Size = new System.Drawing.Size(85, 25);
            this.rbPagoFacil.TabIndex = 2;
            this.rbPagoFacil.TabStop = true;
            this.rbPagoFacil.Tag = "metodos";
            this.rbPagoFacil.Text = "Pago Fácil";
            this.rbPagoFacil.UseVisualStyleBackColor = false;
            this.rbPagoFacil.CheckedChanged += new System.EventHandler(this.rbMetodos_CheckedChanged);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.tbCorreo);
            this.gbInformacion.Controls.Add(this.lblCorreo);
            this.gbInformacion.Controls.Add(this.tbDNI);
            this.gbInformacion.Controls.Add(this.lblDNI);
            this.gbInformacion.Controls.Add(this.dtpFechaVencimiento);
            this.gbInformacion.Controls.Add(this.lblFechaVencimiento);
            this.gbInformacion.Controls.Add(this.cbTarjeta);
            this.gbInformacion.Controls.Add(this.tbNroTarjeta);
            this.gbInformacion.Controls.Add(this.lblTarjeta);
            this.gbInformacion.Controls.Add(this.lblCodigo);
            this.gbInformacion.Controls.Add(this.tbTitular);
            this.gbInformacion.Controls.Add(this.lblNombre);
            this.gbInformacion.Location = new System.Drawing.Point(13, 104);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(287, 184);
            this.gbInformacion.TabIndex = 4;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información del comprador:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(118, 72);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(148, 21);
            this.tbCorreo.TabIndex = 15;
            this.tbCorreo.Tag = "paypal";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(11, 75);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 15);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Tag = "paypal";
            this.lblCorreo.Text = "Correo:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(118, 45);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(148, 21);
            this.tbDNI.TabIndex = 13;
            this.tbDNI.Tag = "pagofacil";
            this.tbDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(11, 48);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 15);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Tag = "pagofacil";
            this.lblDNI.Text = "DNI:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.AllowDrop = true;
            this.dtpFechaVencimiento.CustomFormat = "MM/yyyy";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(118, 156);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVencimiento.MinDate = new System.DateTime(2019, 1, 13, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(148, 21);
            this.dtpFechaVencimiento.TabIndex = 11;
            this.dtpFechaVencimiento.Tag = "tarjeta";
            this.dtpFechaVencimiento.Value = new System.DateTime(2019, 1, 13, 0, 0, 0, 0);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(11, 156);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(89, 15);
            this.lblFechaVencimiento.TabIndex = 7;
            this.lblFechaVencimiento.Tag = "tarjeta";
            this.lblFechaVencimiento.Text = "Fecha de venc.";
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Items.AddRange(new object[] {
            "Visa",
            "Naranja",
            "MasterCard"});
            this.cbTarjeta.Location = new System.Drawing.Point(118, 99);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(148, 23);
            this.cbTarjeta.TabIndex = 6;
            this.cbTarjeta.Tag = "tarjeta";
            // 
            // tbNroTarjeta
            // 
            this.tbNroTarjeta.Location = new System.Drawing.Point(118, 128);
            this.tbNroTarjeta.MaxLength = 14;
            this.tbNroTarjeta.Name = "tbNroTarjeta";
            this.tbNroTarjeta.Size = new System.Drawing.Size(148, 21);
            this.tbNroTarjeta.TabIndex = 5;
            this.tbNroTarjeta.Tag = "tarjeta";
            this.tbNroTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroTarjeta_KeyPress);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(11, 102);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(48, 15);
            this.lblTarjeta.TabIndex = 4;
            this.lblTarjeta.Tag = "tarjeta";
            this.lblTarjeta.Text = "Tarjeta:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 129);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Tag = "tarjeta";
            this.lblCodigo.Text = "Nro. de tarjeta.";
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(118, 18);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(148, 21);
            this.tbTitular.TabIndex = 1;
            this.tbTitular.Tag = "pagofacil";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Tag = "pagofacil";
            this.lblNombre.Text = "Titular:";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(165, 327);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(136, 25);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Crear cupón de pago";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.White;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.Black;
            this.tbTotal.Location = new System.Drawing.Point(131, 294);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(148, 21);
            this.tbTotal.TabIndex = 10;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 297);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 48);
            this.panel1.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(144, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinalizar.Location = new System.Drawing.Point(225, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // frmMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.gbMetodos);
            this.Controls.Add(this.lblTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de pago";
            this.Load += new System.EventHandler(this.frmMetodoDePago_Load);
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox gbMetodos;
        private System.Windows.Forms.RadioButton rbRapiPago;
        private System.Windows.Forms.RadioButton rbPagoFacil;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.ComboBox cbTarjeta;
        private System.Windows.Forms.TextBox tbNroTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.RadioButton rbPaypal;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lblCorreo;
    }
}