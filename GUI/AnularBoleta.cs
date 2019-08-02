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
    public partial class AnularBoleta : Form
    {
        private bool comp1;
        public AnularBoleta()
        {
            InitializeComponent();
        }

        public AnularBoleta(bool comp)
        {
            InitializeComponent();
            if(comp == true)
            {
                comp1 = true;
            }
            else
            {
                comp1 = false;
            }
        }

        private void AnularBoleta_Load(object sender, EventArgs e)
        {
            try
            {
                ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
                this.grillaVenta.DataSource = auxServicio.consultarVentasCompletaServ();
                this.grillaVenta.DataMember = "VentaCabecera";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion a la BD;" + ex);
            }
        } 

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Confirmacion c = new Confirmacion();
            if (txtNumBoleta.Text != String.Empty)
            {
                c.ShowDialog();
                if (c.button1.Text == "")
                {
                    try
                    {
                        ServiceVenta.ServiceVentasSoapClient auxSrv = new ServiceVenta.ServiceVentasSoapClient();
                        auxSrv.anularBoleta(Convert.ToInt32(grillaVenta.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("Boleta Anulada");
                        grillaVenta.DataSource = null;
                        grillaVenta.Refresh();
                        this.grillaVenta.DataSource = auxSrv.consultarVentasCompletaServ();
                        this.grillaVenta.DataMember = "VentaCabecera";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo Anular la Boleta o es Boleta no existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("NO HAY BOLETA SELECCIONADA");
            }
        }

        private void grillaVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int num_venta = Convert.ToInt32(grillaVenta.CurrentRow.Cells[0].Value.ToString());
                txtNumBoleta.Text = num_venta.ToString();
                ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
                this.grillaProdutosV.DataSource = auxServicio.consultarProductosDeVenta(num_venta);
                this.grillaProdutosV.DataMember = "VentaDetalle";
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay Boleta Activa por el momento, Seleccion Nula");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
