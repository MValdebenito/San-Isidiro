using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Ventas : Form
    {
        private Producto auxProd;
        private Venta_Detalle vd;
        private Vendedor vendedorVenta;
        private int idVendedorVenta;
        private int tipoVendedor;
        private int contadorProductos;
        private int auxStock;

        public Producto AuxProd { get => auxProd; set => auxProd = value; }
        public Venta_Detalle Vd { get => vd; set => vd = value; }
        public Vendedor VendedorVenta { get => vendedorVenta; set => vendedorVenta = value; }
        public int IdVendedorVenta { get => idVendedorVenta; set => idVendedorVenta = value; }
        public int TipoVendedor { get => tipoVendedor; set => tipoVendedor = value; }
        public int ContadorProductos { get => contadorProductos; set => contadorProductos = value; }
        public int AuxStock { get => auxStock; set => auxStock = value; }

        public Ventas()
        {
            InitializeComponent();
        }

        public Ventas(int id, int tipo)
        {
            InitializeComponent();            
            IdVendedorVenta = id;
            TipoVendedor = tipo;
            
        }

        private void Ventas_Load(object sender, EventArgs e)
        {            
            try
            {
                ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
                this.grillaProductos.DataSource = auxServicio.consultarProductosServ();
                this.grillaProductos.DataMember = "Producto";
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error de Conexion a la BD;" + ex);
            }
            
        }

        private void btnSalirV_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void grillaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidProd.Text = grillaProductos.CurrentRow.Cells[0].Value.ToString();
            txtProducto.Text = grillaProductos.CurrentRow.Cells[1].Value.ToString();                
            txtPrecio.Text   = grillaProductos.CurrentRow.Cells[2].Value.ToString();
            txtIva.Text      = (Convert.ToInt32(grillaProductos.CurrentRow.Cells[2].Value) * 0.19).ToString();
            AuxStock = Convert.ToInt32(grillaProductos.CurrentRow.Cells[3].Value);
            txtCantidad.Focus();            
        }

        private void grillaBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidProd.Text = grillaBoleta.CurrentRow.Cells[0].Value.ToString();
            txtProducto.Text = grillaBoleta.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = grillaBoleta.CurrentRow.Cells[2].Value.ToString();
            txtIva.Text = (Convert.ToInt32(grillaBoleta.CurrentRow.Cells[2].Value) * 0.19).ToString();
            txtCantidad.Focus();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
            bool compruebaStock = false;
            foreach (DataGridViewRow fila in grillaBoleta.Rows)
            {
                if(txtidProd.Text == fila.Cells[0].Value.ToString())
                {
                    if(AuxStock < Convert.ToInt32(fila.Cells[3].Value) + Convert.ToInt32(txtCantidad.Text))
                    {
                        compruebaStock = true;   
                    }
                }
            }
            if (Convert.ToInt32(txtCantidad.Text) > AuxStock || AuxStock.Equals(0) || compruebaStock == true)
            {
                MessageBox.Show("Lo sentimos, Stock insuficiente eliga menos cantidad");
                txtidProd.Text = String.Empty;
                txtPrecio.Text = String.Empty;
                txtIva.Text = String.Empty;
                txtProducto.Text = String.Empty;
            }
            else
            {
                try
                {
                    ContadorProductos = 0;
                    int suma = 0;
                    bool aux = false;
                    int auxPrecio = 0;
                    //Evito que me boten el txt
                    if (txtCantidad.Text == String.Empty || Convert.ToInt32(txtCantidad.Text) <= 0)
                    {
                        txtCantidad.Focus();
                        MessageBox.Show("Ingresar cantidad; debe ser mayor a cero");
                    }
                    else
                    {
                        ContadorProductos += Convert.ToInt32(txtCantidad.Text);
                        auxPrecio = Convert.ToInt32(txtPrecio.Text);
                        vd = new Venta_Detalle();
                        vd.IdProducto = Convert.ToInt32(txtidProd.Text);
                        vd.Nombre = txtProducto.Text;
                        vd.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        vd.Subtotal = vd.Cantidad * auxPrecio;


                        //Nombro las columnas de la grilla
                        grillaBoleta.ColumnCount = 5;
                        grillaBoleta.Columns[0].Name = "Cod";
                        grillaBoleta.Columns[1].Name = "Nombre Producto";
                        grillaBoleta.Columns[2].Name = "Precio Unitario";
                        grillaBoleta.Columns[3].Name = "Cantidad";
                        grillaBoleta.Columns[4].Name = "Subtotal";


                        //Comprueba Existencia de Elemento en la grilla                   
                        if (grillaBoleta.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in grillaBoleta.Rows)
                            {
                                if (row.Cells[1].Value.Equals(vd.Nombre))
                                {
                                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + vd.Cantidad;
                                    row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value) + vd.Subtotal;
                                    vd.Cantidad = Convert.ToInt32(row.Cells[3].Value);
                                    vd.Subtotal = Convert.ToInt32(row.Cells[4].Value);
                                    aux = true;
                                    break;
                                }
                            }
                        }

                        //Se pasa el objeto a un array
                        string[] filaBoleta =
                        { vd.IdProducto.ToString() ,vd.Nombre, auxPrecio.ToString() , vd.Cantidad.ToString(), vd.Subtotal.ToString() };

                        //Se agrega dicho array a la grilla
                        if (aux == false)
                        {
                            grillaBoleta.Rows.Add(filaBoleta);
                        }

                        //Se suma el total de los productos en la boleta
                        foreach (DataGridViewRow row in grillaBoleta.Rows)
                        {
                            suma += Convert.ToInt32(row.Cells[4].Value);
                        }

                        //Se establecen los totales temporales
                        txtSubTotal.Text = (suma - (suma * 0.19)).ToString();
                        txtIvaTotal.Text = (suma * 0.19).ToString();
                        txtVentaTotal.Text = suma.ToString();

                        txtCantidad.Text = String.Empty;
                        btnBoleta.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingresar el producto a la boleta: " + ex);
                }                
            }
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            ServiceVenta.ServiceVentasSoapClient auxServicio = new ServiceVenta.ServiceVentasSoapClient();
            try
            {
                //INGRESA VENTA CABECERA
                ServiceVenta.Venta_Cabecera auxVC = new ServiceVenta.Venta_Cabecera();
                //auxVC.IdVendedor = this.IdVendedorVenta;
                auxVC.IdVendedor = 1;
                auxVC.Iva = Convert.ToInt32(Math.Round(Convert.ToDouble(txtIvaTotal.Text)));
                auxVC.TotalNeto = Convert.ToInt32(Math.Round(Convert.ToDouble(txtSubTotal.Text)));
                auxVC.Fecha = (DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("ja-JP"))).ToString();
                auxVC.Hora = (DateTime.Now.ToString("t", CultureInfo.CreateSpecificCulture("hr-HR"))).ToString();
                auxVC.IdEstado = 1;
                auxServicio.ingresarBoletaCabeceraServ(auxVC);

                PrePago pp = new PrePago(Convert.ToInt32(txtVentaTotal.Text), auxServicio.ultimaVenta());
                if (ContadorProductos == 0)
                {
                    MessageBox.Show("No puedes generar la venta Pues no hay Productos");
                }
                else
                {                    
                    pp.ShowDialog();
                }

                if (pp.compruebaPago == true)
                {                                                        
                    //INGRESA VENTA DETALLE                  
                    ServiceVenta.Venta_Detalle boleta = new ServiceVenta.Venta_Detalle();
                    foreach (DataGridViewRow fila in grillaBoleta.Rows)
                    {
                        boleta.IdVenta = auxServicio.ultimaVenta();
                        boleta.IdProducto = Convert.ToInt32(fila.Cells[0].Value);
                        boleta.Cantidad = Convert.ToInt32(fila.Cells[3].Value);
                        boleta.Subtotal = Convert.ToInt32(fila.Cells[4].Value);
                        auxServicio.ingresarBoletaDetalleServ(boleta);
                        //Actualiza Stock
                        auxServicio.actualizarStock(boleta.Cantidad, boleta.IdProducto);
                    }
                    MessageBox.Show("Venta Correctamente Ingresada!");
                    this.Dispose();
                    System.GC.Collect();
                    grillaProductos.DataSource = null;
                    grillaProductos.Refresh();
                    this.grillaProductos.DataSource = auxServicio.consultarVentasCompletaServ();
                    this.grillaProductos.DataMember = "Producto";
                }else
                {
                    auxServicio.eliminarUltimaVentaCabecera(auxServicio.ultimaVenta());
                    MessageBox.Show("Venta Cancelada, Reintente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Venta No Ingresada = Error de Sistema --> " + ex);
            }
        }

        //CONTROLES EXTRA
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnLimpair_Click(object sender, EventArgs e)
        {
            txtidProd.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtIva.Text = String.Empty;
            txtProducto.Text =String.Empty;
            grillaBoleta.DataSource = null;
            this.grillaBoleta.Rows.Clear();
            txtSubTotal.Text = String.Empty;
            txtIvaTotal.Text = String.Empty;
            txtVentaTotal.Text = String.Empty;
            btnBoleta.Enabled = false;
        }

        private void btn_RemoverProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaBoleta.Rows.Count > 0)
                {
                    foreach (DataGridViewRow fila in grillaBoleta.Rows)
                    {
                        if (txtidProd.Text == fila.Cells[0].Value.ToString())
                        {
                            fila.Cells[3].Value = Convert.ToInt32(fila.Cells[3].Value)  - Convert.ToInt32(txtCantidad.Text);
                            ContadorProductos -= Convert.ToInt32(txtCantidad.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Hay Nada que Eliminar.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo Eliminar el Producto.");
            }
        }

        private void grillaBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ContadorProductos == 0 || e.RowIndex == 0)
            {
                txtSubTotal.Text = String.Empty;
                txtIvaTotal.Text = String.Empty;
                txtVentaTotal.Text = String.Empty;
                btnBoleta.Enabled = false;
            }
        }
    }
}
