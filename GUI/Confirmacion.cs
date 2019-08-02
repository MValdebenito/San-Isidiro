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
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServiceVenta.ServiceVentasSoapClient auxSrv = new ServiceVenta.ServiceVentasSoapClient();

            if (!comprobarSQL())
            {
                MessageBox.Show("Ingreso de Caracteres no permitidos (=,'), vuelva a intentar.");
            }
            else
            {
                try
                {
                    Vendedor v = new Vendedor();
                    if (auxSrv.consultarPorAdmin(txtConf.Text) == true)
                    {
                        button1.Text = "";
                        this.Close();                                  
                    }
                    else
                    {                        
                        MessageBox.Show("!Error¡...Contraseña Erronea");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Pudo Ingresar al sistema - error:" + ex);
                }
            }
        }

        private Boolean comprobarSQL()
        {
            if (txtConf.Text.Contains("=") || txtConf.Text.Contains("'"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
