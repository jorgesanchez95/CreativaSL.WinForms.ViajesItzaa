using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Solicitud
    {
        private string _AeropuertoLlegada;
        private string _AeropuertoSalida;
        private string _AsesorAgencia;
        private float _CategoriaHotel;
        private Cliente _Cliente;
        private Cotizacion _Cotizacion;
        private string _Conexion;
        private List<LugarTuristico> _DetalleItinerario;
        private int _DiasExtra;
        private bool _EsEmpresa;
        private string _EstatusSolicitud;
        private DateTime _FechaLimPagoFinal;
        private DateTime _FechaLimPagoInicial;
        private DateTime _FechaLlegada;
        private DateTime _FechaSalida;
        private DateTime _FechaSolicitud;
        private string _Folio;
        private string _FolioAnterior;
        private string _HoraLlegada;
        private string _HoraSalida;
        private string _HoraSolicitud;
        private string _IDAutenticacion;
        private string _IDCaja;
        private string _IDCajaCancela;
        private string _IDChofer;
        private string _IDCliente;
        private string _IDCotizacion;
        private string _IDHotel;
        private string _IDProducto;
        private string _IDSeccion;
        private string _IDSolicitud;
        private int _IDStatusSolicitud;
        private string _IDSucursal;
        private int _IDTipoSolicitud;
        private string _IDTipoVehiculo;
        private string _IDUsuario;
        private string _IDUsuarioRecibido;
        private string _IDVehiculo;
        private string _IDVenta;
        private List<Habitacion> _ListaHabitaciones;
        private List<LugarTuristico> _ListaItinerario;
        private List<Paquete> _ListaPaquete;
        private bool _MSI;
        private decimal _MontoAnticipo;
        private decimal _MontoDevolucion;
        private decimal _MontoFinal;
        private decimal _MontoInicial;
        private decimal _MontoPagado;
        private decimal _MontoPenalizacion;
        private decimal _MontoPendiente;
        private string _MotivoCancelacion;
        private string _MotivoMontoInicial;
        private string _NombreClienteAgencia;
        private string _NombreProducto;
        private int _NumAdultos;
        private int _NumDias;
        private int _NumHabitaciones;
        private int _NumMenores11;
        private int _NumMenores4;
        private int _NumNoches;
        private string _Observaciones;
        private int _Opcion;
        private OrdenPago _OrdenPago;
        private string _OtrosServicios;
        private Pago _Pago;
        private bool _RequiereFactura;
        private string _RequiereFacturaTxt;
        private DataTable _TablaHabitaciones;
        private DataTable _TablaItinerario;
        private DataTable _TablaPaquetes;
        private bool _TieneBoletosAvion;
        private string _TieneBoletosAcionTxt;
        private string _TipoSolicitud;
        private string _TxtObservaciones;
        private string _TxtRecomendaciones;
        private string _TxtTitulo;
        private bool _Validador;


        public string AeropueroLlegada
        {
            get { return _AeropuertoLlegada; }
            set { _AeropuertoLlegada = value; }
        }
        public string AeropuertoSalida
        {
            get { return _AeropuertoSalida; }
            set { _AeropuertoSalida = value; }
        }
        public string AsesorAgencia
        {
            get { return _AsesorAgencia; }
            set { _AsesorAgencia = value; }
        }
        public float CategoriaHotel
        {
            get { return _CategoriaHotel; }
            set { _CategoriaHotel = value; }
        }
        public Cliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }        
        public Cotizacion Cotizacion
        {
            get { return _Cotizacion; }
            set { _Cotizacion = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public List<LugarTuristico> DetalleItinerario
        {
            get { return _DetalleItinerario; }
            set { _DetalleItinerario = value; }
        }
        public int DiasExtra
        {
            get { return _DiasExtra; }
            set { _DiasExtra = value; }
        }
        public bool EsEmpresa
        {
            get { return _EsEmpresa; }
            set { _EsEmpresa = value; }
        }
        public string EstatusSolicitud
        {
            get { return _EstatusSolicitud; }
            set { _EstatusSolicitud = value; }
        }
        public DateTime FechaLimPagoFinal
        {
            get { return _FechaLimPagoFinal; }
            set { _FechaLimPagoFinal = value; }
        }
        public DateTime FechaLimPagoInicial
        {
            get { return _FechaLimPagoInicial; }
            set { _FechaLimPagoInicial = value; }
        }
        public DateTime FechaLlegada
        {
            get { return _FechaLlegada; }
            set { _FechaLlegada = value; }
        }
        public DateTime FechaSalida
        {
            get { return _FechaSalida; }
            set { _FechaSalida = value; }
        }
        public DateTime FechaSolicitud
        {
            get { return _FechaSolicitud; }
            set { _FechaSolicitud = value; }
        }
        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }
        public string FolioAnterior
        {
            get { return _FolioAnterior; }
            set { _FolioAnterior = value; }
        }
        public string HoraLlegada
        {
            get { return _HoraLlegada; }
            set { _HoraLlegada = value; }
        }
        public string HoraSalida
        {
            get { return _HoraSalida; }
            set { _HoraSalida = value; }
        }
        public string HoraSolicitud
        {
            get { return _HoraSolicitud; }
            set { _HoraSolicitud = value; }
        }
        public string IDAutenticacion
        {
            get { return _IDAutenticacion; }
            set { _IDAutenticacion = value; }
        }
        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }        
        public string IDCajaCancela
        {
            get { return _IDCajaCancela; }
            set { _IDCajaCancela = value; }
        }
        public string IDChofer
        {
            get { return _IDChofer; }
            set { _IDChofer = value; }
        }
        public string IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }
        public string IDCotizacion
        {
            get { return _IDCotizacion; }
            set { _IDCotizacion = value; }
        }
        public string IDHotel
        {
            get { return _IDHotel; }
            set { _IDHotel = value; }
        }
        public string IDProducto
        {
            get { return _IDProducto; }
            set { _IDProducto = value; }
        }
        public string IDSeccion
        {
            get { return _IDSeccion; }
            set { _IDSeccion = value; }
        }        
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public int IDStatusSolicitud
        {
            get { return _IDStatusSolicitud; }
            set { _IDStatusSolicitud = value; }
        }
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }
        public int IDTipoSolicitud
        {
            get { return _IDTipoSolicitud; }
            set { _IDTipoSolicitud = value; }
        }
        public string IDTipoVehiculo
        {
            get { return _IDTipoVehiculo; }
            set { _IDTipoVehiculo = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public string IDUsuarioRecibido
        {
            get { return _IDUsuarioRecibido; }
            set { _IDUsuarioRecibido = value; }
        }
        public string IDVehiculo
        {
            get { return _IDVehiculo; }
            set { _IDVehiculo = value; }
        }
        public string IDVenta
        {
            get { return _IDVenta; }
            set { _IDVenta = value; }
        }
        public List<Habitacion> ListaHabitaciones
        {
            get { return _ListaHabitaciones; }
            set { _ListaHabitaciones = value; }
        }
        public List<LugarTuristico> ListaItinerario
        {
            get { return _ListaItinerario; }
            set { _ListaItinerario = value; }
        }

        public List<Paquete> ListaPaquete
        {
            get { return _ListaPaquete; }
            set { _ListaPaquete = value; }
        }
        
        public bool MSI
        {
            get { return _MSI; }
            set { _MSI = value; }
        }
        public decimal MontoAnticipo
        {
            get { return _MontoAnticipo; }
            set { _MontoAnticipo = value; }
        }
        public decimal MontoDevolucion
        {
            get { return _MontoDevolucion; }
            set { _MontoDevolucion = value; }
        }
        public decimal MontoFinal
        {
            get { return _MontoFinal; }
            set { _MontoFinal = value; }
        }
        public decimal MontoInicial
        {
            get { return _MontoInicial; }
            set { _MontoInicial = value; }
        }
        public decimal MontoPagado
        {
            get { return _MontoPagado; }
            set { _MontoPagado = value; }
        }
        public decimal MontoPenalizacion
        {
            get { return _MontoPenalizacion; }
            set { _MontoPenalizacion = value; }
        }
        public decimal MontoPendiente
        {
            get { return _MontoPendiente; }
            set { _MontoPendiente = value; }
        }
        public string MotivoCancelacion
        {
            get { return _MotivoCancelacion; }
            set { _MotivoCancelacion = value; }
        }
        public string MotivoMontoInicial
        {
            get { return _MotivoMontoInicial; }
            set { _MotivoMontoInicial = value; }
        }
        public string NombreClienteAgencia
        {
            get { return _NombreClienteAgencia; }
            set { _NombreClienteAgencia = value; }
        }
        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        public int NumAdultos
        {
            get { return _NumAdultos; }
            set { _NumAdultos = value; }
        }
        public int NumDias
        {
            get { return _NumDias; }
            set { _NumDias = value; }
        }
        public int NumHabitaciones
        {
            get { return _NumHabitaciones; }
            set { _NumHabitaciones = value; }
        }
        public int NumMenores11
        {
            get { return _NumMenores11; }
            set { _NumMenores11 = value; }
        }
        public int NumMenores4
        {
            get { return _NumMenores4; }
            set { _NumMenores4 = value; }
        }
        public int NumNoches
        {
            get { return _NumNoches; }
            set { _NumNoches = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public OrdenPago OrdenPago
        {
            get { return _OrdenPago; }
            set { _OrdenPago = value; }
        }
        public string OtrosServicios
        {
            get { return _OtrosServicios; }
            set { _OtrosServicios = value; }
        }
        public Pago Pago
        {
            get { return _Pago; }
            set { _Pago = value; }
        }
        public bool RequiereFactura
        {
            get { return _RequiereFactura; }
            set { _RequiereFactura = value; }
        }
        public string RequiereFacturaTxt
        {
            get { return _RequiereFacturaTxt; }
            set { _RequiereFacturaTxt = value; }
        }
        public DataTable TablaHabitaciones
        {
            get { return _TablaHabitaciones; }
            set { _TablaHabitaciones = value; }
        }
        public DataTable TablaItinerario
        {
            get { return _TablaItinerario; }
            set { _TablaItinerario = value; }
        }
        public DataTable TablaPaquetes
        {
            get { return _TablaPaquetes; }
            set { _TablaPaquetes = value; }
        }
        
        public bool TieneBoletosAvion
        {
            get { return _TieneBoletosAvion; }
            set { _TieneBoletosAvion = value; }
        }
        public string TieneBoletosAvionTxt
        {
            get { return _TieneBoletosAcionTxt; }
            set { _TieneBoletosAcionTxt = value; }
        }
        public string TipoSolicitud
        {
            get { return _TipoSolicitud; }
            set { _TipoSolicitud = value; }
        }
        public string TxtObservaciones
        {
            get { return _TxtObservaciones; }
            set { _TxtObservaciones = value; }
        }
        public string TxtRecomendaciones
        {
            get { return _TxtRecomendaciones; }
            set { _TxtRecomendaciones = value; }
        }
        public string TxtTitulo
        {
            get { return _TxtTitulo; }
            set { _TxtTitulo = value; }
        }
        
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }

        private string _NombrePagina;

        public string NombrePagina
        {
            get { return _NombrePagina; }
            set { _NombrePagina = value; }
        }
        
        #region Datos para el correo

        private string _AsuntoCorreo;
        public string AsuntoCorreo
        {
            get { return _AsuntoCorreo; }
            set { _AsuntoCorreo = value; }
        }
        private string _ImgProducto;
        public string ImgProducto
        {
            get { return _ImgProducto; }
            set { _ImgProducto = value; }
        }
        private int _NumTotalPersonas;
        public int NumTotalPersonas
        {
            get { return _NumTotalPersonas; }
            set { _NumTotalPersonas = value; }
        }
        private string _Remitente;
        public string Remitente
        {
            get { return _Remitente; }
            set { _Remitente = value; }
        }
        private string _PasswordRemitente;
        public string PasswordRemitente
        {
            get { return _PasswordRemitente; }
            set { _PasswordRemitente = value; }
        }

        private string _LinkFacebook;

        public string LinkFacebook
        {
            get { return _LinkFacebook; }
            set { _LinkFacebook = value; }
        }

        private string _LinkGoogle;

        public string LinkGoogle
        {
            get { return _LinkGoogle; }
            set { _LinkGoogle = value; }
        }

        private string _LinkTwitter;

        public string LinkTwitter
        {
            get { return _LinkTwitter; }
            set { _LinkTwitter = value; }
        }
        
        
        #endregion

        #region Datos para Notificaciones

        private bool _BandNot_01;
        private bool _BandNot_02;
        private bool _BandNot_03;
        private bool _BandNot_04;
        private bool _BandNot_05;
        private bool _BandNot_06;
        private DataTable _TablaNotificaciones;
        private DataTable _TablaNotificaciones2;

        public bool BandNot_01
        {
            get { return _BandNot_01; }
            set { _BandNot_01 = value; }
        }
        public bool BandNot_02
        {
            get { return _BandNot_02; }
            set { _BandNot_02 = value; }
        }
        public bool BandNot_03
        {
            get { return _BandNot_03; }
            set { _BandNot_03 = value; }
        }
        public bool BandNot_04
        {
            get { return _BandNot_04; }
            set { _BandNot_04 = value; }
        }
        public bool BandNot_05
        {
            get { return _BandNot_05; }
            set { _BandNot_05 = value; }
        }
        public bool BandNot_06
        {
            get { return _BandNot_06; }
            set { _BandNot_06 = value; }
        }
        public DataTable TablaNotificaciones
        {
            get { return _TablaNotificaciones; }
            set { _TablaNotificaciones = value; }
        }
        public DataTable TablaNotificaciones2
        {
            get { return _TablaNotificaciones2; }
            set { _TablaNotificaciones2 = value; }
        }
        
        #endregion
    }
}
