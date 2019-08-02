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
    public partial class PrePago : Form
    {
        private int totalVenta;
        private int numVenta;
        public bool compruebaPago;
        public int TotalVenta { get => totalVenta; set => totalVenta = value; }
        public int NumVenta { get => numVenta; set => numVenta = value; }

        public PrePago()
        {
            InitializeComponent();
        }

        public PrePago(int totalVenta, int numVenta)
        {
            InitializeComponent();
            TotalVenta = totalVenta;
            NumVenta = numVenta;
        }

        private void PrePago_Load(object sender, EventArgs e)
        {
            txtTotalVenta.Enabled = false;
            txtTotalVenta.Text = TotalVenta.ToString();
            txtPago.Enabled = false;
            txtVuelto.Enabled = false;
            AgregaFiado af = new AgregaFiado();
            if (af.compruebaFiado == true)
            {
                MessageBox.Show("Venta Correctamente Pagadas");
                compruebaPago = true;
                this.Close();
            }
           
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago Cancelado");
            compruebaPago = false;
            this.Close();
        }        

        public void LimpiarPrePago()
        {
            txtTotalVenta.Text = String.Empty;
            txtPago.Text = String.Empty;
            txtVuelto.Text = String.Empty;
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(txtPago.Text) - TotalVenta) < 0)
                {
                    lblDebe.Text = ((Convert.ToInt32(txtPago.Text) - TotalVenta) * -1).ToString();
                    txtVuelto.Text = "0";
                }else
                {
                    txtVuelto.Text = (Convert.ToInt32(txtPago.Text) - TotalVenta).ToString();
                    lblDebe.Text = "0";
                    btnPagar.Enabled = true;
                }
            }
            catch(Exception)
            {
                txtPago.Text = String.Empty;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtVuelto.Text)< 0)
            {
                MessageBox.Show("Debe Cancelar $"+ Convert.ToInt32(txtVuelto.Text) * -1 + " más antes de continuar.");
            }
            else
            {
                MessageBox.Show("Venta Correctamente Pagadas");
                compruebaPago = true;
                this.Close();
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            txtPago.Enabled = true;
        }

        private void btnFiado_Click(object sender, EventArgs e)
        {
            try
            {
                AgregaFiado af = new AgregaFiado(TotalVenta, NumVenta);
                txtVuelto.Text = "0";
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede fiar en este momento");
            }
        }
    }
}
