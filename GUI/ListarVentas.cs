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
    public partial class ListarVentas : Form
    {
        public ListarVentas()
        {
            InitializeComponent();
        }

        private void cbActivas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
                this.grillaVentas.DataSource = auxServicio.consultarProductosServ();
                this.grillaVentas.DataMember = "Producto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion a la BD;" + ex);
            }


        }

        private void cbAnuladas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
