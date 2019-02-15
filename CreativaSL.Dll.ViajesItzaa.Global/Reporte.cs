using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Reporte
    {
        private string _Conexion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        private string _IDUsuario;

        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        private int _Opcion;

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

        private DateTime _FechaInicio;

        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        private DateTime _FechaFin;

        public DateTime FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }

        private string _IDSolicitud;

        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }

        private bool _Band;

        public bool Band
        {
            get { return _Band; }
            set { _Band = value; }
        }
        
        
        
    }
}
