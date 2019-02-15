using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Busqueda
    {
        private string _ApellidoMaterno;
        private string _ApellidoPaterno;
        private string _Conexion;
        private DateTime _FechaLlegadaFin;
        private DateTime _FechaLlegadaInicio;
        private DateTime _FechaNotasFin;
        private DateTime _FechaNotasInicio;
        private DateTime _FechaSolicitudFin;
        private DateTime _FechaSolicitudInicio;
        private string _FolioSolicitud;
        private string _IDEmpresa;
        private int _IDTipoBusqueda;
        private string _IDUsuarioRecibido;
        private string _Nombre;
        private int _Opcion;

        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
        }

        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        public DateTime FechaLlegadaFin
        {
            get { return _FechaLlegadaFin; }
            set { _FechaLlegadaFin = value; }
        }

        public DateTime FechaLlegadaInicio
        {
            get { return _FechaLlegadaInicio; }
            set { _FechaLlegadaInicio = value; }
        }

        public DateTime FechaNotasFin
        {
            get { return _FechaNotasFin; }
            set { _FechaNotasFin = value; }
        }

        public DateTime FechanotasInicio
        {
            get { return _FechaNotasInicio; }
            set { _FechaNotasInicio = value; }
        }

        public DateTime FechaSolicitudFin
        {
            get { return _FechaSolicitudFin; }
            set { _FechaSolicitudFin = value; }
        }

        public DateTime FechaSolicitudInicio
        {
            get { return _FechaSolicitudInicio; }
            set { _FechaSolicitudInicio = value; }
        }

        public string FolioSolicitud
        {
            get { return _FolioSolicitud; }
            set { _FolioSolicitud = value; }
        }

        public string IDEmpresa
        {
            get { return _IDEmpresa; }
            set { _IDEmpresa = value; }
        }

        public int IDTipoBusqueda
        {
            get { return _IDTipoBusqueda; }
            set { _IDTipoBusqueda = value; }
        }

        public string IDUsuarioRecibido
        {
            get { return _IDUsuarioRecibido; }
            set { _IDUsuarioRecibido = value; }
        }
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

    }
}
