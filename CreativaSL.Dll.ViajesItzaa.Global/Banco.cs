using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Banco
    {
        private string _Conexion;
        private int _IDBanco;
        private string _NombreBanco;
        private int _Opcion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public int IDBanco
        {
            get { return _IDBanco; }
            set { _IDBanco = value; }
        }
        public string NombreBanco
        {
            get { return _NombreBanco; }
            set { _NombreBanco = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        
    }
}
