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
    public partial class AgregaFiado : Form
    {
        private int numVenta;
        public bool compruebaFiado = false;
        public int NumVenta { get => numVenta; set => numVenta = value; }

        public AgregaFiado()
        {
            InitializeComponent();
        }

        public AgregaFiado(int totalVenta, int numVenta)
        {
            InitializeComponent();
            lblTv.Text = totalVenta.ToString();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceVenta.ServiceVentasSoapClient auxServ = new ServiceVenta.ServiceVentasSoapClient();
            ServiceVenta.Cliente cli = new ServiceVenta.Cliente();
            cli = auxServ.buscaCliente(txtBuscarC.Text);

            lblRut.Text = cli.Rut;
            lblNombre.Text = cli.Nombre;
            lblDireccion.Text = cli.Direccion;
            lblTd.Text = cli.TotalDeuda.ToString();
            lblTf.Text = (Convert.ToInt32(lblTd) + Convert.ToInt32(lblTv)).ToString();
        }

        private void btnFiar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceVenta.ServiceVentasSoapClient auxServ = new ServiceVenta.ServiceVentasSoapClient();
                ServiceVenta.Cliente_Deuda cd = new ServiceVenta.Cliente_Deuda();

                cd.Rut = lblRut.Text;
                cd.IdVenta = NumVenta;
                cd.Credito = Convert.ToInt32(lblTv.Text);

                auxServ.ingresarFiado(cd);
                auxServ.ingresarDeuda(Convert.ToInt32(lblTf.Text), cd.Rut);

                MessageBox.Show("Fiado Completo.");
                compruebaFiado = true;
                this.Close();
            }catch(Exception exe)
            {
                MessageBox.Show("No se pudo Completar el Fiado");
            }
        }        
    }
}
