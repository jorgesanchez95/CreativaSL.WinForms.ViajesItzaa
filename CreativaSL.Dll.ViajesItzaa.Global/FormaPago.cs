using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class FormaPago
    {
        private string _Autorizacion;
        private Banco _Banco;
        private decimal _Comision;
        private string _FolioIFE;
        private string _FolioSolicitud;
        private string _FormaPago;
        private int _IDBanco;
        private int _IDFormaPago;
        private decimal _Monto;
        private string _NombreBanco;
        private string _NumTarjeta;
        private decimal _Subtotal;
        private TipoDocumento _TipoDocumento;

        public string Autorizacion
        {
            get { return _Autorizacion; }
            set { _Autorizacion = value; }
        }
        public Banco BancoAux
        {
            get { return _Banco; }
            set { _Banco = value; }
        }
        public decimal Comision
        {
            get { return _Comision; }
            set { _Comision = value; }
        }
        public string FolioIFE
        {
            get { return _FolioIFE; }
            set { _FolioIFE = value; }
        }
        public string FolioSolicitud
        {
            get { return _FolioSolicitud; }
            set { _FolioSolicitud = value; }
        }
        public string FormaPagoAux
        {
            get { return _FormaPago; }
            set { _FormaPago = value; }
        }
        public int IDBanco
        {
            get { return _IDBanco; }
            set { _IDBanco = value; }
        }
        public int IDFormaPago
        {
            get { return _IDFormaPago; }
            set { _IDFormaPago = value; }
        }
        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
        public string NombreBanco
        {
            get { return _NombreBanco; }
            set { _NombreBanco = value; }
        }
        public string NumTarjeta
        {
            get { return _NumTarjeta; }
            set { _NumTarjeta = value; }
        }
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }
        public TipoDocumento TipoDocumentoAux
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
    }
}
