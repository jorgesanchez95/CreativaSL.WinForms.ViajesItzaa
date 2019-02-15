using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class DepositoRetiro
    {
        private string _Conexion;
        private DateTime _FechaHora;
        private string _IDCaja;
        private string _IDDepositoRetiro;
        private string _IDSucursal;
        private int _IDTipoDepositoRetiro;
        private string _IDUsuario;
        private decimal _Monto;
        private string _Motivo;
        private int _Opcion;
        private bool _Validador;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public DateTime FechaHora
        {
            get { return _FechaHora; }
            set { _FechaHora = value; }
        }
        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }
        public string IDDepositoRetiro
        {
            get { return _IDDepositoRetiro; }
            set { _IDDepositoRetiro = value; }
        }
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        public int IDTipoDepositoRetiro
        {
            get { return _IDTipoDepositoRetiro; }
            set { _IDTipoDepositoRetiro = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
        public string Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
    }
}
