using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Pago
    {
        private decimal _Cambio;
        private string _Conexion;
        private DataTable _DatosFormasPago;
        private DataTable _DatosExtraFormasPago;
        private DateTime _FechaPago;
        private string _FolioSolicitud;
        private string _FormasPagoText;
        private string _IDCaja;
        private string _IDCajero;
        private string _IDCotizacion;
        private string _IDPago;
        private string _IDSolicitud;
        private string _IDSucursal;
        private string _IDventa;
        private decimal _Iva;
        private decimal _MontoAnticipo;
        private decimal _MontoAPagar;
        private decimal _MontoInicial;
        private decimal _MontoMinimoPago;
        private decimal _MontoPagado;
        private decimal _MontoPendiente;
        private decimal _MontoTotal;
        private int _Opcion;
        private decimal _PagoEfectivo;
        private decimal _PagoPaypal;
        private decimal _PagoTarjeta;
        private decimal _PagoTransferencia;
        private decimal _PorcentajeAnticipo;
        private string _Producto;
        private bool _RequiereFactura;
        private decimal _Subtotal;
        private decimal _TotalCambio;
        private decimal _TotalPago;
        private bool _Validador;

        public decimal Cambio
        {
            get { return _Cambio; }
            set { _Cambio = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public DataTable DatosFormasPago
        {
            get { return _DatosFormasPago; }
            set { _DatosFormasPago = value; }
        }
        public DataTable DatosExtraFormasPago
        {
            get { return _DatosExtraFormasPago; }
            set { _DatosExtraFormasPago = value; }
        }
        public DateTime FechaPago
        {
            get { return _FechaPago; }
            set { _FechaPago = value; }
        }
        public string FolioSolicitud
        {
            get { return _FolioSolicitud; }
            set { _FolioSolicitud = value; }
        }
        public string FormasPagoText
        {
            get { return _FormasPagoText; }
            set { _FormasPagoText = value; }
        }
        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }
        public string IDCajero
        {
            get { return _IDCajero; }
            set { _IDCajero = value; }
        }
        public string IDCotizacion
        {
            get { return _IDCotizacion; }
            set { _IDCotizacion = value; }
        }
        public string IDPago
        {
            get { return _IDPago; }
            set { _IDPago = value; }
        }
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        public string IDVenta
        {
            get { return _IDventa; }
            set { _IDventa = value; }
        }
        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }
        public decimal MontoAnticipo
        {
            get { return _MontoAnticipo; }
            set { _MontoAnticipo = value; }
        }
        public decimal MontoAPagar
        {
            get { return _MontoAPagar; }
            set { _MontoAPagar = value; }
        }
        public decimal MontoInicial
        {
            get { return _MontoInicial; }
            set { _MontoInicial = value; }
        }
        public decimal MontoMinimoPago
        {
            get { return _MontoMinimoPago; }
            set { _MontoMinimoPago = value; }
        }
        public decimal MontoPagado
        {
            get { return _MontoPagado; }
            set { _MontoPagado = value; }
        }
        public decimal MontoPendiente
        {
            get { return _MontoPendiente; }
            set { _MontoPendiente = value; }
        }
        public decimal MontoTotal
        {
            get { return _MontoTotal; }
            set { _MontoTotal = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public decimal PagoEfectivo
        {
            get { return _PagoEfectivo; }
            set { _PagoEfectivo = value; }
        }
        public decimal PagoPaypal
        {
            get { return _PagoPaypal; }
            set { _PagoPaypal = value; }
        }
        public decimal PagoTarjeta
        {
            get { return _PagoTarjeta; }
            set { _PagoTarjeta = value; }
        }
        public decimal PagoTransferencia
        {
            get { return _PagoTransferencia; }
            set { _PagoTransferencia = value; }
        }
        public decimal PorcentajeAnticipo
        {
            get { return _PorcentajeAnticipo; }
            set { _PorcentajeAnticipo = value; }
        }
        public string Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        public bool RequiereFactura
        {
            get { return _RequiereFactura; }
            set { _RequiereFactura = value; }
        }
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }
        public decimal TotalCambio
        {
            get { return _TotalCambio; }
            set { _TotalCambio = value; }
        }
        public decimal TotalPago
        {
            get { return _TotalPago; }
            set { _TotalPago = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }

    }
}
