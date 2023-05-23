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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBajarProducto
            // 
            this.btnBajarProducto.Location = new System.Drawing.Point(38, 240);
            this.btnBajarProducto.Name = "btnBajarProducto";
            this.btnBajarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnBajarProducto.TabIndex = 22;
            this.btnBajarProducto.Text = "Bajar";
            this.btnBajarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(38, 180);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnModificarProducto.TabIndex = 21;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(38, 120);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 52);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
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
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoComida2;
            this.ClientSize = new System.Drawing.Size(1651, 814);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBajarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvProductos;
        private Label lblTituloProductos;
    }
}