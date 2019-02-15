using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Tour
    {
        private string _Conexion;
        private string _IDTour;
        private string _NombreTour;
        private int _Opcion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string IDTour
        {
            get { return _IDTour; }
            set { _IDTour = value; }
        }
        public string NombreTour
        {
            get { return _NombreTour; }
            set { _NombreTour = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        
    }
}
