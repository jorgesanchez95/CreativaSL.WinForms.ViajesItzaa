using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Municipio
    {
        private string _Conexion;
        private int _IDEstado;
        private int _IDMunicipio;
        private int _IDPais;
        private string _Municipio;
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

        public int IDMunicipio
        {
            get { return _IDMunicipio; }
            set { _IDMunicipio = value; }
        }

        public int IDPais
        {
            get { return _IDPais; }
            set { _IDPais = value; }
        }

        public string NombreMunicipio
        {
            get { return _Municipio; }
            set { _Municipio = value; }
        }
        
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }

    }
}
