using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.ViajesItzaa.Datos
{
    public class Pago_Datos
    {
        public void InsertarPago(Pago datos)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(datos.Conexion, CommandType.StoredProcedure, "spCSLDB_set_InsertarPago",
                    new SqlParameter("@IDSolicitud", datos.IDSolicitud),
                    new SqlParameter("@IDSucursal", datos.IDSucursal),
                    new SqlParameter("@IDCaja", datos.IDCaja),
                    new SqlParameter("@IDCajero", datos.IDCajero),
                    new SqlParameter("@TotalPago", datos.MontoTotal),
                    new SqlParameter("@Pago", datos.TotalPago),
                    new SqlParameter("@Cambio", datos.TotalCambio),
                    new SqlParameter("@RequiereFactura", datos.RequiereFactura),
                    new SqlParameter("@TblFormasPago", datos.DatosFormasPago),
                    new SqlParameter("@TblDatosFormasPago", datos.DatosExtraFormasPago));
                if (result != null)
                    datos.IDPago = result.ToString();
                else
                    datos.IDPago = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pago ObtenerDatosPagoAbono(Solicitud Datos)
        {
            try
            {
                Pago DatosPago = new Pago();
                SqlDataReader dr = SqlHelper.ExecuteReader(Datos.Conexion, "spCSLDB_get_DatosPagoAbono_CH", Datos.IDSolicitud);
                while (dr.Read())
                {
                    DatosPago.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    DatosPago.MontoTotal = dr.GetDecimal(dr.GetOrdinal("MontoTotal"));
                    DatosPago.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPagado"));
                    DatosPago.MontoPendiente = dr.GetDecimal(dr.GetOrdinal("MontoPendiente"));
                }
                return DatosPago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pago ObtenerDatosPagoInicial(Solicitud Datos)
        {
            try
            {
                Pago DatosPago = new Pago();
                SqlDataReader dr = SqlHelper.ExecuteReader(Datos.Conexion, "spCSLDB_get_DatosPagoInicial_CH", Datos.IDSolicitud, Datos.IDSucursal);
                while (dr.Read())
                {
                    DatosPago.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    DatosPago.MontoTotal = dr.GetDecimal(dr.GetOrdinal("MontoTotal"));
                    DatosPago.MontoInicial = dr.GetDecimal(dr.GetOrdinal("MontoInicial"));
                    DatosPago.MontoAnticipo = dr.GetDecimal(dr.GetOrdinal("MontoAnticipo"));
                    DatosPago.PorcentajeAnticipo = dr.GetDecimal(dr.GetOrdinal("PorcentajeAnticipo"));
                    DatosPago.MontoMinimoPago = dr.GetDecimal(dr.GetOrdinal("MontoMinimoPago"));                    
                }
                return DatosPago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FormaPago> ObtenerReporteFormasPagoXIDCaja(Reporte Datos)
        {
            try
            {
                List<FormaPago> lista = new List<FormaPago>();
                FormaPago item;
                SqlDataReader dr = SqlHelper.ExecuteReader(Datos.Conexion, "spCSLDB_get_RptDesgloceFormasPagoXIDCaja", Datos.IDUsuario);
                while (dr.Read())
                {
                    item = new FormaPago();
                    item.FormaPagoAux = dr.GetString(dr.GetOrdinal("FormaPago"));
                    item.Monto = dr.GetDecimal(dr.GetOrdinal("MontoTotal"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pago> ObtenerReportePagosXIDCaja(Reporte Datos)
        {
            try
            {
                List<Pago> lista = new List<Pago>();
                Pago item;
                SqlDataReader dr = SqlHelper.ExecuteReader(Datos.Conexion, "spCSLDB_get_RptDesglocePagos", Datos.IDUsuario);
                while (dr.Read())
                {
                    item = new Pago();
                    item.FolioSolicitud = dr.GetString(dr.GetOrdinal("FolioSolicitud"));
                    item.Producto = dr.GetString(dr.GetOrdinal("Producto"));
                    item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                    item.Iva = dr.GetDecimal(dr.GetOrdinal("Iva"));
                    item.TotalPago = dr.GetDecimal(dr.GetOrdinal("Total"));
                    object Fecha = dr.GetValue(dr.GetOrdinal("FechaPago"));
                    if (Fecha != null)
                    {
                        if (!string.IsNullOrEmpty(Fecha.ToString()))
                            item.FechaPago = dr.GetDateTime(dr.GetOrdinal("FechaPago"));
                    }
                    item.FormasPagoText = dr.GetString(dr.GetOrdinal("FormasPago"));
                    item.IDCajero = dr.GetString(dr.GetOrdinal("Usuario"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
