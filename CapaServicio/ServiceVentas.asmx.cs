using DTO;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de ServiceVentas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceVentas : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean comprobarSQL(string campo)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.comprobarSQL(campo);
        }

        [WebMethod]
        public Vendedor buscaVendedorServ(String rut, String pass)
        {
            NegocioSI auxNegocio = new NegocioSI();
            Vendedor veVenta = new Vendedor();
            veVenta = auxNegocio.buscaVendedor(rut, pass);
            return veVenta;
        }

        [WebMethod]
        public DataSet consultarProductosServ()
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarProductos();
        }

        [WebMethod]
        public DataSet consultarVentasCompletaServ()
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarVentasCompleta();
        }

        [WebMethod]
        public DataSet consultarProductosDeVenta(int num)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarProductosDeVenta(num);
        }


        [WebMethod]
        public DataSet filtrarProductoMarcaServ(String filtro)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.filtrarProductoMarca(filtro);
        }

        [WebMethod]
        public Producto SeleccionarProductoServ(String nombre)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.SeleccionarProducto(nombre);
        }

        [WebMethod]
        public void ingresarBoletaCabeceraServ(Venta_Cabecera vc)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.ingresarBoletaCabecera(vc);
        }

        [WebMethod]
        public void ingresarBoletaDetalleServ(Venta_Detalle vd)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.ingresarBoletaDetalle(vd);
        }

        [WebMethod]
        public int ultimaVenta()
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.ultimaVenta();
        }

        [WebMethod]
        public void actualizarStock(int cantidad, int idProducto)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.actualizarStock(cantidad,idProducto);
        }

        [WebMethod]
        public void anularBoleta(int numVenta)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.anularBoleta(numVenta);
        }

        [WebMethod]
        public bool consultarPorAdmin(string pass)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarPorAdmin(pass);
        }

        [WebMethod]
        public void ingresarFiado(Cliente_Deuda cd)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.ingresarFiado(cd);
        }

        [WebMethod]
        public void ingresarDeuda(int deudaTotal, String rutCliente)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.ingresarDeuda(deudaTotal,rutCliente);
        }

        [WebMethod]
        public Cliente buscaCliente(String rutCliente)
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.buscaCliente(rutCliente);
        }

        [WebMethod]
        public void eliminarUltimaVentaCabecera(int numVenta)
        {
            NegocioSI auxNegocio = new NegocioSI();
            auxNegocio.eliminarUltimaVentaCabecera(numVenta);
        }

        [WebMethod]
        public DataSet consultarVentaCabecera()
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarVentaCabecera();
        }

        [WebMethod]
        public DataSet consultarVentaDetalle()
        {
            NegocioSI auxNegocio = new NegocioSI();
            return auxNegocio.consultarVentas();
        }
    }
}
