﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmProductos : Form
    {       
        private static FrmProductos _instancia = null!;
        private FrmMenuPrincipal _frmMenuPrincipal = null!;
        public FrmProductos(FrmMenuPrincipal frmMenuPrincipal)
        {
            this._frmMenuPrincipal = frmMenuPrincipal;
            InitializeComponent();            
        }
        public static FrmProductos InstanciarVentanaUnica(FrmMenuPrincipal frmMenuPrincipal)
        {
            if (_instancia is null)
            {
                _instancia = new FrmProductos(frmMenuPrincipal);
            }
            return _instancia;            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            List<Parser> productines = new List<Parser>();
            productines.Add(new Producto("aver", 10, 1, 10));
            productines.Add(new Producto("aver2", 13, 2, 100));
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Producto.VerListaComoProductos();
        }
    }
}
