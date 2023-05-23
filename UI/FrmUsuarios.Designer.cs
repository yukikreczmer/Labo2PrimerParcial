namespace UI
{
    partial class FrmUsuarios
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
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnBajarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTituloUsuarios = new System.Windows.Forms.Label();
            this.gpbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.txbContraseniaRepetida = new System.Windows.Forms.TextBox();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.chbSuperUsuario = new System.Windows.Forms.CheckBox();
            this.txbContrasenia = new System.Windows.Forms.TextBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gpbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(37, 122);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(126, 48);
            this.btnAgregarUsuario.TabIndex = 17;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(37, 188);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(126, 48);
            this.btnModificarUsuario.TabIndex = 16;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBajarUsuario
            // 
            this.btnBajarUsuario.Location = new System.Drawing.Point(37, 252);
            this.btnBajarUsuario.Name = "btnBajarUsuario";
            this.btnBajarUsuario.Size = new System.Drawing.Size(126, 48);
            this.btnBajarUsuario.TabIndex = 15;
            this.btnBajarUsuario.Text = "Bajar";
            this.btnBajarUsuario.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(253, 182);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(656, 597);
            this.dgvUsuarios.TabIndex = 18;
            // 
            // lblTituloUsuarios
            // 
            this.lblTituloUsuarios.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTituloUsuarios.Location = new System.Drawing.Point(253, 110);
            this.lblTituloUsuarios.Name = "lblTituloUsuarios";
            this.lblTituloUsuarios.Size = new System.Drawing.Size(656, 62);
            this.lblTituloUsuarios.TabIndex = 25;
            this.lblTituloUsuarios.Text = "DETALLE DE USUARIOS";
            this.lblTituloUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbDatosUsuario
            // 
            this.gpbDatosUsuario.Controls.Add(this.lblMensajeError);
            this.gpbDatosUsuario.Controls.Add(this.txbContraseniaRepetida);
            this.gpbDatosUsuario.Controls.Add(this.lblRepetirContraseña);
            this.gpbDatosUsuario.Controls.Add(this.lblContrasenia);
            this.gpbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.gpbDatosUsuario.Controls.Add(this.lblDni);
            this.gpbDatosUsuario.Controls.Add(this.lblNombre);
            this.gpbDatosUsuario.Controls.Add(this.lblApellido);
            this.gpbDatosUsuario.Controls.Add(this.chbSuperUsuario);
            this.gpbDatosUsuario.Controls.Add(this.txbContrasenia);
            this.gpbDatosUsuario.Controls.Add(this.txbNombreUsuario);
            this.gpbDatosUsuario.Controls.Add(this.txbDni);
            this.gpbDatosUsuario.Controls.Add(this.txbNombre);
            this.gpbDatosUsuario.Controls.Add(this.txbApellido);
            this.gpbDatosUsuario.Location = new System.Drawing.Point(996, 110);
            this.gpbDatosUsuario.Name = "gpbDatosUsuario";
            this.gpbDatosUsuario.Size = new System.Drawing.Size(494, 378);
            this.gpbDatosUsuario.TabIndex = 26;
            this.gpbDatosUsuario.TabStop = false;
            this.gpbDatosUsuario.Text = "Datos del Usuario";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(203, 321);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(32, 15);
            this.lblMensajeError.TabIndex = 13;
            this.lblMensajeError.Text = "Error";
            this.lblMensajeError.Visible = false;
            // 
            // txbContraseniaRepetida
            // 
            this.txbContraseniaRepetida.Location = new System.Drawing.Point(257, 255);
            this.txbContraseniaRepetida.Name = "txbContraseniaRepetida";
            this.txbContraseniaRepetida.Size = new System.Drawing.Size(146, 23);
            this.txbContraseniaRepetida.TabIndex = 12;
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Location = new System.Drawing.Point(257, 237);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(107, 15);
            this.lblRepetirContraseña.TabIndex = 11;
            this.lblRepetirContraseña.Text = "Repetir Contraseña";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(257, 175);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(67, 15);
            this.lblContrasenia.TabIndex = 10;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 175);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(110, 15);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 104);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(257, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 47);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // chbSuperUsuario
            // 
            this.chbSuperUsuario.AutoSize = true;
            this.chbSuperUsuario.Location = new System.Drawing.Point(37, 321);
            this.chbSuperUsuario.Name = "chbSuperUsuario";
            this.chbSuperUsuario.Size = new System.Drawing.Size(111, 19);
            this.chbSuperUsuario.TabIndex = 5;
            this.chbSuperUsuario.Text = "Es super usuario";
            this.chbSuperUsuario.UseVisualStyleBackColor = true;
            // 
            // txbContrasenia
            // 
            this.txbContrasenia.Location = new System.Drawing.Point(257, 195);
            this.txbContrasenia.Name = "txbContrasenia";
            this.txbContrasenia.Size = new System.Drawing.Size(146, 23);
            this.txbContrasenia.TabIndex = 4;
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(37, 195);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(146, 23);
            this.txbNombreUsuario.TabIndex = 3;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(37, 122);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(119, 23);
            this.txbDni.TabIndex = 2;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(257, 63);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(119, 23);
            this.txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(37, 65);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(119, 23);
            this.txbApellido.TabIndex = 0;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoComida2;
            this.ClientSize = new System.Drawing.Size(1583, 791);
            this.Controls.Add(this.gpbDatosUsuario);
            this.Controls.Add(this.lblTituloUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnBajarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gpbDatosUsuario.ResumeLayout(false);
            this.gpbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregarUsuario;
        private Button btnModificarUsuario;
        private Button btnBajarUsuario;
        private DataGridView dgvUsuarios;
        private Label lblTituloUsuarios;
        private GroupBox gpbDatosUsuario;
        private TextBox txbContraseniaRepetida;
        private Label lblRepetirContraseña;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private CheckBox chbSuperUsuario;
        private TextBox txbContrasenia;
        private TextBox txbNombreUsuario;
        private TextBox txbDni;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private Label lblMensajeError;
    }
}