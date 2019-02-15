using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Ocupacion
    {
        private string _Conexion;
        private int _IDOcupacion;
        private string _Ocupacion;
        private int _Opcion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        
        public int IDOcupacion
        {
            get { return _IDOcupacion; }
            set { _IDOcupacion = value; }
        }

        public string NombreOcupacion
        {
            get { return _Ocupacion; }
            set { _Ocupacion = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        
    }
}
