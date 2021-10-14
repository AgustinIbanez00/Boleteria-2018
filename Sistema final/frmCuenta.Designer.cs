namespace Sistema_final
{
    partial class frmCuenta
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
            this.lblUsario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.lblTuContraseña = new System.Windows.Forms.Label();
            this.gbCambiarContraseña = new System.Windows.Forms.GroupBox();
            this.lblRepetirNueva = new System.Windows.Forms.Label();
            this.tbRepetirContraseña = new System.Windows.Forms.TextBox();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbCambiarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsario
            // 
            this.lblUsario.AutoSize = true;
            this.lblUsario.Location = new System.Drawing.Point(23, 91);
            this.lblUsario.Name = "lblUsario";
            this.lblUsario.Size = new System.Drawing.Size(116, 15);
            this.lblUsario.TabIndex = 0;
            this.lblUsario.Text = "Nombre de usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(154, 88);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(223, 21);
            this.tbUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(23, 145);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(73, 15);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbContraseña.HideSelection = false;
            this.tbContraseña.Location = new System.Drawing.Point(128, 20);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(207, 21);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.UseSystemPasswordChar = true;
            this.tbContraseña.TextChanged += new System.EventHandler(this.tbContraseña_TextChanged);
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(154, 142);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.ReadOnly = true;
            this.tbContrasena.Size = new System.Drawing.Size(192, 21);
            this.tbContrasena.TabIndex = 5;
            this.tbContrasena.UseSystemPasswordChar = true;
            // 
            // lblTuContraseña
            // 
            this.lblTuContraseña.AutoSize = true;
            this.lblTuContraseña.Location = new System.Drawing.Point(15, 26);
            this.lblTuContraseña.Name = "lblTuContraseña";
            this.lblTuContraseña.Size = new System.Drawing.Size(88, 15);
            this.lblTuContraseña.TabIndex = 19;
            this.lblTuContraseña.Text = "Tu contraseña:";
            // 
            // gbCambiarContraseña
            // 
            this.gbCambiarContraseña.Controls.Add(this.btnGuardarCambios);
            this.gbCambiarContraseña.Controls.Add(this.lblRepetirNueva);
            this.gbCambiarContraseña.Controls.Add(this.tbRepetirContraseña);
            this.gbCambiarContraseña.Controls.Add(this.tbNuevaContraseña);
            this.gbCambiarContraseña.Controls.Add(this.lblNueva);
            this.gbCambiarContraseña.Controls.Add(this.lblTuContraseña);
            this.gbCambiarContraseña.Controls.Add(this.tbContraseña);
            this.gbCambiarContraseña.Location = new System.Drawing.Point(26, 169);
            this.gbCambiarContraseña.Name = "gbCambiarContraseña";
            this.gbCambiarContraseña.Size = new System.Drawing.Size(351, 131);
            this.gbCambiarContraseña.TabIndex = 20;
            this.gbCambiarContraseña.TabStop = false;
            this.gbCambiarContraseña.Text = "Cambia tu contraseña:";
            this.gbCambiarContraseña.Visible = false;
            // 
            // lblRepetirNueva
            // 
            this.lblRepetirNueva.AutoSize = true;
            this.lblRepetirNueva.Location = new System.Drawing.Point(15, 80);
            this.lblRepetirNueva.Name = "lblRepetirNueva";
            this.lblRepetirNueva.Size = new System.Drawing.Size(86, 15);
            this.lblRepetirNueva.TabIndex = 26;
            this.lblRepetirNueva.Text = "Repetir nueva:";
            // 
            // tbRepetirContraseña
            // 
            this.tbRepetirContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRepetirContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRepetirContraseña.HideSelection = false;
            this.tbRepetirContraseña.Location = new System.Drawing.Point(128, 74);
            this.tbRepetirContraseña.Name = "tbRepetirContraseña";
            this.tbRepetirContraseña.Size = new System.Drawing.Size(207, 21);
            this.tbRepetirContraseña.TabIndex = 25;
            this.tbRepetirContraseña.UseSystemPasswordChar = true;
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNuevaContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNuevaContraseña.HideSelection = false;
            this.tbNuevaContraseña.Location = new System.Drawing.Point(128, 47);
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.Size = new System.Drawing.Size(207, 21);
            this.tbNuevaContraseña.TabIndex = 24;
            this.tbNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Location = new System.Drawing.Point(15, 53);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(45, 15);
            this.lblNueva.TabIndex = 23;
            this.lblNueva.Text = "Nueva:";
            // 
            // pbPerfil
            // 
            this.pbPerfil.BackgroundImage = global::Sistema_final.Properties.Resources.usuario_x;
            this.pbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(12, 12);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(100, 66);
            this.pbPerfil.TabIndex = 21;
            this.pbPerfil.TabStop = false;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.AutoSize = true;
            this.btnCambiarContraseña.BackgroundImage = global::Sistema_final.Properties.Resources.edit;
            this.btnCambiarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCambiarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(352, 140);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(25, 25);
            this.btnCambiarContraseña.TabIndex = 18;
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(23, 118);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 15);
            this.lblCorreo.TabIndex = 22;
            this.lblCorreo.Text = "Correo:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(154, 115);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(223, 21);
            this.tbCorreo.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(310, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Aplicar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(148, 306);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(222, 101);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(113, 23);
            this.btnGuardarCambios.TabIndex = 26;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(229, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.gbCambiarContraseña);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tu cuenta";
            this.Load += new System.EventHandler(this.frmCuenta_Load);
            this.gbCambiarContraseña.ResumeLayout(false);
            this.gbCambiarContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label lblTuContraseña;
        private System.Windows.Forms.GroupBox gbCambiarContraseña;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.Label lblRepetirNueva;
        private System.Windows.Forms.TextBox tbRepetirContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button button1;
    }
}