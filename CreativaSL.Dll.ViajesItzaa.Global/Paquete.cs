using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Paquete
    {        
        private string _Conexion;
        private string _IDPaquete;
        private string _NombrePaquete;
        private string _NombrePagina;
        private int _Opcion;
        private int _Orden;


        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string IDPaquete
        {
            get { return _IDPaquete; }
            set { _IDPaquete = value; }
        }
        public string NombrePaquete
        {
            get { return _NombrePaquete; }
            set { _NombrePaquete = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

        public string NombrePagina
        {
            get { return _NombrePagina; }
            set { _NombrePagina = value; }
        }

        public int Orden
        {
            get { return _Orden; }
            set { _Orden = value; }
        }
        
    }
}
