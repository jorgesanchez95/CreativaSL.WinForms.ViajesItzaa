using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Caja
    {
        private decimal _Apertura;
        private int _B20P;
        private int _B50P;
        private int _B100P;
        private int _B1000P;
        private int _B200P;
        private int _B500P;
        private string _CajaCat;
        private string _CadConexion;
        private decimal _Cierre;
        private string _FechaIngreso;
        private string _HoraIngreso;
        private string _IDCaja;
        private string _IDCajaCat;
        private string _IDSucursal;
        private string _IDUsuario;
        private int _M50C;
        private int _M1P;
        private int _M2P;
        private int _M5P;
        private int _M10P;
        private int _M20P;
        private int _M100P;
        private string _Mac;
        private string _NombreCaja;
        private string _NombreUsuario;
        private int _Opcion;
        private int _Tickets;
        private decimal _TotalCaja;
        private decimal _TotalDepositos;
        private decimal _TotalRetiroCajaLlena;
        private decimal _TotalRetirosPagos;
        private decimal _TotalVentas;
        private string _Turno;
        private int _Vales;

        public Caja(string cad)
        {
            _CadConexion = cad;
        }

        public decimal Apertura
        {
            get { return _Apertura; }
            set { _Apertura = value; }
        }

        public int B20P
        {
            get { return _B20P; }
            set { _B20P = value; }
        }

        public int B50P
        {
            get { return _B50P; }
            set { _B50P = value; }
        }

        public int B100P
        {
            get { return _B100P; }
            set { _B100P = value; }
        }        

        public int B200P
        {
            get { return _B200P; }
            set { _B200P = value; }
        }

        public int B500P
        {
            get { return _B500P; }
            set { _B500P = value; }
        }

        public int B1000P
        {
            get { return _B1000P; }
            set { _B1000P = value; }
        }

        public string CadConexion
        {
            get { return _CadConexion; }
        }

        public string CajaCat
        {
            get { return _CajaCat; }
            set { _CajaCat = value; }
        }

        public decimal Cierre
        {
            get { return _Cierre; }
            set { _Cierre = value; }
        }
        
        public string FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        public string HoraIngreso
        {
            get { return _HoraIngreso; }
            set { _HoraIngreso = value; }
        }

        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }

        public string IDCajaCat
        {
            get { return _IDCajaCat; }
            set { _IDCajaCat = value; }
        }

        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        
        public int M50C
        {
            get { return _M50C; }
            set { _M50C = value; }
        }

        public int M1P
        {
            get { return _M1P; }
            set { _M1P = value; }
        }

        public int M2P
        {
            get { return _M2P; }
            set { _M2P = value; }
        }

        public int M5P
        {
            get { return _M5P; }
            set { _M5P = value; }
        }

        public int M10P
        {
            get { return _M10P; }
            set { _M10P = value; }
        }

        public int M20P
        {
            get { return _M20P; }
            set { _M20P = value; }
        }

        public int M100P
        {
            get { return _M100P; }
            set { _M100P = value; }
        }

        public string Mac
        {
            get { return _Mac; }
            set { _Mac = value; }
        }

        public string NombreCaja
        {
            get { return _NombreCaja; }
            set { _NombreCaja = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

        public int Tickets
        {
            get { return _Tickets; }
            set { _Tickets = value; }
        }
        
        public decimal TotalCaja
        {
            get { return _TotalCaja; }
            set { _TotalCaja = value; }
        }

        public decimal TotalDepositos
        {
            get { return _TotalDepositos; }
            set { _TotalDepositos = value; }
        }

        public decimal TotalRetirosCajaLlena
        {
            get { return _TotalRetiroCajaLlena; }
            set { _TotalRetiroCajaLlena = value; }
        }

        public decimal TotalRetirosPagos
        {
            get { return _TotalRetirosPagos; }
            set { _TotalRetirosPagos = value; }
        }

        public decimal TotalVentas
        {
            get { return _TotalVentas; }
            set { _TotalVentas = value; }
        }

        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }

        public int Vales
        {
            get { return _Vales; }
            set { _Vales = value; }
        }

        private DateTime _FechaApertura;

        public DateTime FechaApertura
        {
            get { return _FechaApertura; }
            set { _FechaApertura = value; }
        }

        private decimal _TotalCobros;

        public decimal TotalCobros
        {
            get { return _TotalCobros; }
            set { _TotalCobros = value; }
        }
        private decimal _TotalPenalizacion;

        public decimal TotalPenalizacion
        {
            get { return _TotalPenalizacion; }
            set { _TotalPenalizacion = value; }
        }

        private decimal _TotalDevolucion;

        public decimal TotalDevolucion
        {
            get { return _TotalDevolucion; }
            set { _TotalDevolucion = value; }
        }

        private decimal _TotalComision;

        public decimal TotalComision
        {
            get { return _TotalComision; }
            set { _TotalComision = value; }
        }
        
    }
}
