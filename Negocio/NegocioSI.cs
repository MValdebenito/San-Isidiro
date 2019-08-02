using CapaConexion;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSI
    {

        private Conexion conex;
        public Conexion Conex { get => conex; set => conex = value; }

        public void confConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "SanIsidroDB";
            this.Conex.CadenaConexion = "Data Source=DESKTOP-H56SQ3P\\SQLEXPRESS02;Initial Catalog=SanIsidroDB;Integrated Security=True"; 
        }

        //METODO APOYO PARA VALIDAR AL CLIENTE
        public Vendedor buscaVendedor(String rut, String pass)
        {
            this.confConexion();
            this.Conex.NombreTabla = "Vendedor";
            this.Conex.CadenaSQL = "SELECT * FROM Vendedor " +
                                   "WHERE rut = '"+ rut +"' AND pass = '"+ pass +"';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet1.Tables[0];

            Vendedor auxV = new Vendedor();
            try
            {
                auxV.IdVendedor = (int)dt.Rows[0]["idVendedor"];
                auxV.Rut = (String)dt.Rows[0]["rut"];
                auxV.Pass = (String)dt.Rows[0]["pass"];
                auxV.IdTipo = Convert.ToInt32(dt.Rows[0]["idTipo"]);
                return auxV;
            }
            catch(Exception)
            {
                return null;
            }            
        }//Fin buscaVendedor()

        //Para Listar Productos
        public DataSet consultarProductos()
        {
            try
            {
                this.confConexion();
                this.Conex.NombreTabla = "Producto";
                this.Conex.CadenaSQL = "SELECT idProducto,nombre,precioUnitario, stock FROM PRODUCTO WHERE idEstado = 1";
                this.Conex.EsSelect = true;
                this.Conex.conectar();
                return this.Conex.DbDataSet1;
            }catch(Exception)
            {
                return null;
            }
        }

        //Para Listar Venta Cabecera
        public DataSet consultarVentaCabecera(int activa, int anulada)
        {
            try
            {
                string treminación;
                if (activa == 0 &&  anulada == 0 )
                {
                    this.confConexion();
                    this.Conex.NombreTabla = "Producto";
                    this.Conex.CadenaSQL = "SELECT vc.idVenta, vc.fecha, vc.hora, v.nombre, vc.totalNeto, e.nombre " +
                                            "FROM SanIsidroDB.dbo.VentaCabecera vc " +
                                            "INNER JOIN SanIsidroDB.dbo.Vendedor v " +
                                            "ON vc.idVendedor = v.idVendedor " +
                                            "INNER JOIN SanIsidroDB.dbo.Estado e " +
                                            "ON vc.idEstado = e.idEstado;";
                    this.Conex.EsSelect = true;
                    this.Conex.conectar();
                    return this.Conex.DbDataSet1;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Para Listar Ventas Detalle
        public DataSet consultarVentas()
        {
            try
            {
                this.confConexion();
                this.Conex.NombreTabla = "";
                this.Conex.CadenaSQL = "SELECT vd.idVenta, p.nombre, p.precioUnitario, vd.cantidad, vd.subtotal " +
                                       "FROM SanIsidroDB.dbo.VentaDetalle vd INNER JOIN SanIsidroDB.dbo.Producto p " +
                                       "ON vd.idProducto = p.idProducto; ";
                this.Conex.EsSelect = true;
                this.Conex.conectar();
                return this.Conex.DbDataSet1;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet consultarVentasCompleta()
        {
            try
            {
                this.confConexion();
                this.Conex.NombreTabla = "VentaCabecera";
                this.Conex.CadenaSQL = "SELECT VC.idVenta AS NUM_VENTA,V.nombre AS VENDEDOR,Convert(Varchar(10),VC.fecha,103) AS FECHA,VC.iva AS IVA, VC.totalNeto AS TOTAL" +
                                       " FROM VentaCabecera VC INNER JOIN Vendedor V "+
                                       " ON VC.idVendedor = V.idVendedor" +
                                       " WHERE VC.idEstado = 1";
                this.Conex.EsSelect = true;
                this.Conex.conectar();
                return this.Conex.DbDataSet1;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet consultarProductosDeVenta(int num)
        {
            try
            {
                this.confConexion();
                this.Conex.NombreTabla = "VentaDetalle";
                this.Conex.CadenaSQL = "SELECT P.nombre as Nombre, vd.cantidad as Cantidad, vd.subtotal as Subtotal " +
                                       "FROM VentaDetalle VD INNER JOIN Producto P ON   VD.idProducto = P.idProducto" +
                                       " WHERE idVenta = "+ num;
                this.Conex.EsSelect = true;
                this.Conex.conectar();
                return this.Conex.DbDataSet1;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //USADO EN LA CONFIRMACIÓN POR CONTRASEÑA EN PANTALLA ANULAR BOLETA
        public bool consultarPorAdmin(string pass)
        {
            try
            {
                this.confConexion();
                this.Conex.NombreTabla = "Vendedor";
                this.Conex.CadenaSQL = "SELECT idTipo FROM Vendedor WHERE pass = "+pass;
                this.Conex.EsSelect = true;
                this.Conex.conectar();
                DataTable dt = new DataTable();
                dt = this.Conex.DbDataSet1.Tables["Vendedor"];
                int idTipoV = Convert.ToInt32(dt.Rows[0]["idTipo"]);
                if(idTipoV == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;                
            }
        }

        public DataSet filtrarProductoMarca(String filtro)
        {
            try
            {
                this.confConexion();                
                this.Conex.NombreTabla = "Producto";
                this.Conex.CadenaSQL = "SELECT idProducto,nombre,precioUnitario FROM Producto p"+
                                       "WHERE p.nombre LIKE '%" + filtro + "%' OR p.marca LIKE '%" + filtro + "%';";
                this.Conex.EsSelect = true;
                
                this.Conex.conectar();
                return this.Conex.DbDataSet1;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Producto SeleccionarProducto(String nombre)
        {
            this.confConexion();
            this.Conex.NombreTabla = "Producto";
            this.Conex.CadenaSQL = "SELECT idProducto, nombre, precioUnitario, stock FROM Producto" +
                                   "WHERE nombre = '" + nombre + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet1.Tables["Producto"];

            Producto auxProd = new Producto();
            try
            {
                auxProd.IdProducto = Convert.ToInt32(dt.Rows[0]["idProducto"]);
                auxProd.Nombre = dt.Rows[0]["nombre"].ToString();
                auxProd.PrecioUnitario = Convert.ToInt32(dt.Rows[0]["precioUnitario"]);
                auxProd.Stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            }
            catch (Exception)
            {
                auxProd.IdProducto = 33;
                auxProd.Nombre = "NOUP";
                auxProd.PrecioUnitario = 33;
                auxProd.Stock = 33;
            }
            return auxProd;
        }

        public void actualizarStock(int cantidad, int idProducto)
        {
            this.confConexion();
            this.Conex.NombreTabla = "Producto";
            this.Conex.CadenaSQL = "UPDATE Producto "
                                 + "SET stock = (stock -" + cantidad +")"
                                 + "WHERE idProducto = " + idProducto + ";";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void anularBoleta(int numVenta)
        {
            this.confConexion();
            this.Conex.NombreTabla = "VentaCabecera";
            this.Conex.CadenaSQL = "UPDATE VentaCabecera "
                                 + "SET idEstado = 3"
                                 + "WHERE idVenta = "+ numVenta+ ";";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void ingresarBoletaCabecera(Venta_Cabecera vc)
        {            
            this.confConexion();
            this.Conex.NombreTabla = "VentaCabecera";
            this.Conex.CadenaSQL = "INSERT INTO VentaCabecera"
                                 + "(fecha,hora,idVendedor,iva,totalNeto,idEstado) VALUES ('"
                                 + vc.Fecha+"','"+vc.Hora+"',"+vc.IdVendedor
                                 +","+vc.Iva+","+vc.TotalNeto+","+vc.IdEstado+");";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void eliminarUltimaVentaCabecera(int numVenta)
        {
            this.confConexion();
            this.Conex.NombreTabla = "VentaCabecera";
            this.Conex.CadenaSQL = "DELETE FROM VentaCabecera " +
                                   "WHERE idVenta = "+ numVenta;
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }


        public void ingresarBoletaDetalle(Venta_Detalle vd)
        {
            this.confConexion();
            this.Conex.NombreTabla = "VentaDetalle";
            this.Conex.CadenaSQL = "INSERT INTO VentaDetalle "
                                 + "(idVenta,idProducto,cantidad,subtotal) VALUES ("
                                 + vd.IdVenta + ", "+vd.IdProducto+", "+vd.Cantidad+", "+vd.Subtotal+");";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void ingresarFiado(Cliente_Deuda cd)
        {
            this.confConexion();
            this.Conex.NombreTabla = "ClienteDeuda";
            this.Conex.CadenaSQL = "INSERT INTO ClienteDeuda(rut, idVenta, deudaVenda) "+
                                   "VALUES('"+cd.Rut+"',"+cd.IdVenta+","+cd.Credito+");";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public void ingresarDeuda(int deudaTotal, String rutCliente)
        {
            this.confConexion();
            this.Conex.NombreTabla = "Cliente";
            this.Conex.CadenaSQL = "UPDATE Cliente "
                                 + "SET totalDeuda = " + deudaTotal
                                 + "WHERE idCliente = " + rutCliente + ";";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }

        public Cliente buscaCliente(String rutCliente)
        {
            this.confConexion();
            this.Conex.NombreTabla = "Cliente";
            this.Conex.CadenaSQL = "SELECT * FROM Cliente " +
                                   "WHERE rut = '"+rutCliente+"';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet1.Tables[0];

            Cliente cli = new Cliente();
            try
            {
                cli.Rut = (String)dt.Rows[0]["rut"];
                cli.Nombre = (String)dt.Rows[0]["nombre"];
                cli.Direccion = (String)dt.Rows[0]["direccion"];
                cli.TotalDeuda = (int)dt.Rows[0]["totalDeuda"];
                return cli;
            }
            catch (Exception)
            {
                return null;
            }
        }//Fin buscaCliente()

        public int ultimaVenta()
        {
            this.confConexion();
            this.Conex.NombreTabla = "VentaCabecera";
            this.Conex.CadenaSQL = "SELECT TOP 1 idVenta AS idVenta FROM VentaCabecera ORDER BY idVenta DESC";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet1.Tables["VentaCabecera"];

            int ultimaVenta;
            try
            {
               ultimaVenta = Convert.ToInt32(dt.Rows[0]["idVenta"]);
               return ultimaVenta;

            }catch(Exception ex)
            {
                return ultimaVenta = 0 ;
            }

        }

        

        public bool comprobarSQL(string campo)
        {
            if (campo.Contains("=") || campo.Contains("'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//Fin Clase
}//Fin NameSpace
