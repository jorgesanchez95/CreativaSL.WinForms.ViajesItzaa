using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class TipoVehiculo
    {
        private string _Conexion;
        private DateTime _FechaFin;
        private DateTime _FechaInicio;
        private string _IDTipoVehiculo;
        private string _IDVehiculo;
        private int _Opcion;
        private string _TipoVehiculoDescripcion;
        
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public DateTime FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        public string IDTipoVehiculo
        {
            get { return _IDTipoVehiculo; }
            set { _IDTipoVehiculo = value; }
        }
        public string IDVehiculo
        {
            get { return _IDVehiculo; }
            set { _IDVehiculo = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public string TipoVehiculoDescripcion
        {
            get { return _TipoVehiculoDescripcion; }
            set { _TipoVehiculoDescripcion = value; }
        }
    }
}
