namespace UI
{
    partial class FrmProductos
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
            this.btnBajarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.gpbDatosProducto = new System.Windows.Forms.GroupBox();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbDatosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBajarProducto
            // 
            this.btnBajarProducto.Location = new System.Drawing.Point(38, 240);
            this.btnBajarProducto.Name = "btnBajarProducto";
            this.btnBajarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnBajarProducto.TabIndex = 22;
            this.btnBajarProducto.Text = "Bajar Producto";
            this.btnBajarProducto.UseVisualStyleBackColor = true;
            this.btnBajarProducto.Click += new System.EventHandler(this.btnBajarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(38, 180);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnModificarProducto.TabIndex = 21;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(38, 120);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(252, 194);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(609, 501);
            this.dgvProductos.TabIndex = 23;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloProductos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTituloProductos.Location = new System.Drawing.Point(252, 120);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(609, 62);
            this.lblTituloProductos.TabIndex = 24;
            this.lblTituloProductos.Text = "DETALLE DE PRODUCTOS";
            this.lblTituloProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbDatosProducto
            // 
            this.gpbDatosProducto.Controls.Add(this.lblMensajeError);
            this.gpbDatosProducto.Controls.Add(this.lblStock);
            this.gpbDatosProducto.Controls.Add(this.lblPrecio);
            this.gpbDatosProducto.Controls.Add(this.lblNombre);
            this.gpbDatosProducto.Controls.Add(this.txbStock);
            this.gpbDatosProducto.Controls.Add(this.txbPrecio);
            this.gpbDatosProducto.Controls.Add(this.txbNombre);
            this.gpbDatosProducto.Location = new System.Drawing.Point(991, 120);
            this.gpbDatosProducto.Name = "gpbDatosProducto";
            this.gpbDatosProducto.Size = new System.Drawing.Size(467, 269);
            this.gpbDatosProducto.TabIndex = 25;
            this.gpbDatosProducto.TabStop = false;
            this.gpbDatosProducto.Text = "Datos del Producto";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(64, 235);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(32, 15);
            this.lblMensajeError.TabIndex = 6;
            this.lblMensajeError.Text = "Error";
            this.lblMensajeError.Visible = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(64, 157);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(262, 60);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(64, 181);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(100, 23);
            this.txbStock.TabIndex = 2;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(262, 89);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 23);
            this.txbPrecio.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(64, 89);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 23);
            this.txbNombre.TabIndex = 0;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoComida2;
            this.ClientSize = new System.Drawing.Size(1651, 814);
            this.Controls.Add(this.gpbDatosProducto);
            this.Controls.Add(this.lblTituloProductos);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBajarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbDatosProducto.ResumeLayout(false);
            this.gpbDatosProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBajarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvProductos;
        private Label lblTituloProductos;
        private GroupBox gpbDatosProducto;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txbStock;
        private TextBox txbPrecio;
        private TextBox txbNombre;
        private Label lblMensajeError;
    }
}