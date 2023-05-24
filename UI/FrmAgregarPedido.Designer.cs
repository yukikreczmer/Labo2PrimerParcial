namespace UI
{
    partial class FrmAgregarPedido
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
            this.dgvProductosGenerales = new System.Windows.Forms.DataGridView();
            this.txbProductoABuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nmcCantidadAAgregar = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvProductosAAgregar = new System.Windows.Forms.DataGridView();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.lblProductosAAgregar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosGenerales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidadAAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosGenerales
            // 
            this.dgvProductosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosGenerales.Location = new System.Drawing.Point(27, 98);
            this.dgvProductosGenerales.Name = "dgvProductosGenerales";
            this.dgvProductosGenerales.ReadOnly = true;
            this.dgvProductosGenerales.RowTemplate.Height = 25;
            this.dgvProductosGenerales.Size = new System.Drawing.Size(417, 276);
            this.dgvProductosGenerales.TabIndex = 0;
            // 
            // txbProductoABuscar
            // 
            this.txbProductoABuscar.Location = new System.Drawing.Point(27, 43);
            this.txbProductoABuscar.Multiline = true;
            this.txbProductoABuscar.Name = "txbProductoABuscar";
            this.txbProductoABuscar.Size = new System.Drawing.Size(332, 32);
            this.txbProductoABuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::UI.Properties.Resources.lupaPng;
            this.btnBuscar.Location = new System.Drawing.Point(365, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nmcCantidadAAgregar
            // 
            this.nmcCantidadAAgregar.Location = new System.Drawing.Point(27, 417);
            this.nmcCantidadAAgregar.Name = "nmcCantidadAAgregar";
            this.nmcCantidadAAgregar.Size = new System.Drawing.Size(120, 23);
            this.nmcCantidadAAgregar.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 29);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(477, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(642, 497);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 42);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 399);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvProductosAAgregar
            // 
            this.dgvProductosAAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAAgregar.Location = new System.Drawing.Point(477, 98);
            this.dgvProductosAAgregar.Name = "dgvProductosAAgregar";
            this.dgvProductosAAgregar.ReadOnly = true;
            this.dgvProductosAAgregar.RowTemplate.Height = 25;
            this.dgvProductosAAgregar.Size = new System.Drawing.Size(297, 276);
            this.dgvProductosAAgregar.TabIndex = 8;
            this.dgvProductosAAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosAAgregar_CellContentClick);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(44, 497);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(32, 15);
            this.lblMensajeError.TabIndex = 9;
            this.lblMensajeError.Text = "Error";
            this.lblMensajeError.Visible = false;
            // 
            // lblProductosAAgregar
            // 
            this.lblProductosAAgregar.AutoSize = true;
            this.lblProductosAAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductosAAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProductosAAgregar.Location = new System.Drawing.Point(527, 70);
            this.lblProductosAAgregar.Name = "lblProductosAAgregar";
            this.lblProductosAAgregar.Size = new System.Drawing.Size(197, 25);
            this.lblProductosAAgregar.TabIndex = 10;
            this.lblProductosAAgregar.Text = "Productos a Agregar";
            // 
            // FrmAgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 566);
            this.Controls.Add(this.lblProductosAAgregar);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.dgvProductosAAgregar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nmcCantidadAAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbProductoABuscar);
            this.Controls.Add(this.dgvProductosGenerales);
            this.Name = "FrmAgregarPedido";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FrmAgregarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosGenerales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidadAAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProductosGenerales;
        private TextBox txbProductoABuscar;
        private Button btnBuscar;
        private NumericUpDown nmcCantidadAAgregar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnConfirmar;
        private Label lblCantidad;
        private DataGridView dgvProductosAAgregar;
        private Label lblMensajeError;
        private Label lblProductosAAgregar;
    }
}