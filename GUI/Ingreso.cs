using CapaServicio;
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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ServiceVenta.ServiceVentasSoapClient auxSrv = new ServiceVenta.ServiceVentasSoapClient();

            if(auxSrv.comprobarSQL(txtrut.Text)==true || auxSrv.comprobarSQL(txtpass.Text) == true)
            {
                MessageBox.Show("Ingreso de Caracteres no permitidos (=,'), vuelva a intentar.");
            }else
            {                
                try
                {
                    Vendedor v = new Vendedor();
                    if (auxSrv.buscaVendedorServ(txtrut.Text.Trim(),txtpass.Text.Trim()) != null)
                    {
                        v.IdVendedor = auxSrv.buscaVendedorServ(txtrut.Text.Trim(), txtpass.Text.Trim()).IdVendedor;
                        v.IdTipo = auxSrv.buscaVendedorServ(txtrut.Text.Trim(), txtpass.Text.Trim()).IdTipo;
                        PaginPrincipal pg = new PaginPrincipal(v.IdVendedor, v.IdTipo);
                        pg.ShowDialog();

                    }
                    else
                    {
                        txtrut.Text = String.Empty;
                        txtpass.Text = String.Empty;
                        txtrut.Focus();
                        txtpass.Focus();
                        MessageBox.Show("!Error¡... Usuario o contraseña Erroneos");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("No se Pudo Ingresar al sistema - error:" + ex);
                }
            }
           

        }
    }
}
