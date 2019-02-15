using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class OrdenPago
    {
        private string _Conexion;
        private Solicitud _DatosSolicitud;
        private string _DescripcionPago;
        private string _IDOrdenPago;
        private string _IDSolicitud;
        private int _IDTipoPago;
        private string _IDUsuario;
        private string _LinkPago;
        private string _NombrePago;
        private int _Opcion;
        private bool _Pagado;
        private decimal _Pago;
        private bool _Validador;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public Solicitud DatosSolicitud
        {
            get { return _DatosSolicitud; }
            set { _DatosSolicitud = value; }
        }
        public string DescripcionPago
        {
            get { return _DescripcionPago; }
            set { _DescripcionPago = value; }
        }
        public string IDOrdenPago
        {
            get { return _IDOrdenPago; }
            set { _IDOrdenPago = value; }
        }
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public int IDTipoPago
        {
            get { return _IDTipoPago; }
            set { _IDTipoPago = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public string LinkPago
        {
            get { return _LinkPago; }
            set { _LinkPago = value; }
        }
        public string NombrePago
        {
            get { return _NombrePago; }
            set { _NombrePago = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public bool Pagado
        {
            get { return _Pagado; }
            set { _Pagado = value; }
        }
        public decimal Pago
        {
            get { return _Pago; }
            set { _Pago = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
    }
}
