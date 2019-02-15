using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Cotizacion
    {
        private string _Comentarios;
        private string _Conexion;
        private string _Descripcion;
        private DateTime _FechaCotizacion;
        private DateTime _FechaEnvio;
        private string _HoraEnvio;
        private string _HtmlCorreo;
        private string _IDCotizacion;
        private string _IDSolicitud;
        private int _IDStatusCotizacion;
        private string _IDSucursal;
        private string _IDUsuario;
        private decimal _Iva;
        private int _Opcion;
        private decimal _Subtotal;
        private DataTable _TablaHabitaciones;
        private bool _Validador;

        public string Comentarios
        {
            get { return _Comentarios; }
            set { _Comentarios = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public DateTime FechaCotizacion
        {
            get { return _FechaCotizacion; }
            set { _FechaCotizacion = value; }
        }
        public DateTime FechaEnvio
        {
            get { return _FechaEnvio; }
            set { _FechaEnvio = value; }
        }
        public string HoraEnvio
        {
            get { return _HoraEnvio; }
            set { _HoraEnvio = value; }
        }
        public string HtmlCorreo
        {
            get { return _HtmlCorreo; }
            set { _HtmlCorreo = value; }
        }
        public string IDCotizacion
        {
            get { return _IDCotizacion; }
            set { _IDCotizacion = value; }
        }
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public int IDStatusCotizacion
        {
            get { return _IDStatusCotizacion; }
            set { _IDStatusCotizacion = value; }
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
        public decimal Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }
        public DataTable TablaHabitaciones
        {
            get { return _TablaHabitaciones; }
            set { _TablaHabitaciones = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }

    }
}
