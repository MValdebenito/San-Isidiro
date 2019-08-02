using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PaginPrincipal : Form
    {
        private int idVendedoVenta;
        private int tipoVendedor;

        public PaginPrincipal()
        {
            InitializeComponent();
        }

        public PaginPrincipal(int id, int tipo)
        {
            InitializeComponent();
            idVendedoVenta = id;
            tipoVendedor = tipo;

            if(id != 1)
            {
                btnAB.Enabled = false;
                btnLV.Enabled = false;
                btnAP.Enabled = false;
                btnLP.Enabled = false;
                btnAProd.Enabled = false;
                btnLProd.Enabled = false;
                btnAC.Enabled = false;
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas(idVendedoVenta, tipoVendedor);
            v.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            AnularBoleta ab = new AnularBoleta();
            ab.ShowDialog();
        }

        private void PaginPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
