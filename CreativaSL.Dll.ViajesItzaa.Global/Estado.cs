using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Estado
    {
        private string _Conexion;
        private string _Estado;
        private int _IDEstado;
        private int _IDPais;
        private int _Opcion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
       
        public int IDEstado
        {
            get { return _IDEstado; }
            set { _IDEstado = value; }
        }

        public int IDPais
        {
            get { return _IDPais; }
            set { _IDPais = value; }
        }

        public string NombreEstado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
    }
}
