using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Pais
    {
        private string _Conexion;
        private int _IDPais;
        private int _Opcion;
        private string _Pais;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        
        public int IDPais
        {
            get { return _IDPais; }
            set { _IDPais = value; }
        }

        public string NombrePais
        {
            get { return _Pais; }
            set { _Pais = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

    }
}
