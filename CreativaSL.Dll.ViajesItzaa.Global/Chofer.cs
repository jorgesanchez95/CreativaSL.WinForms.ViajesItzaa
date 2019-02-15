using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Chofer
    {
        private string _Conexion;
        private string _IDChofer;
        private string _NombreChofer;
        private int _Opcion;

        public string IDChofer
        {
            get { return _IDChofer; }
            set { _IDChofer = value; }
        }

        public string NombreChofer
        {
            get { return _NombreChofer; }
            set { _NombreChofer = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        
    }
}
