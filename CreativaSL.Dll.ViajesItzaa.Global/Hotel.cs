using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Hotel
    {
        private float _CategoriaHotel;
        private string _Conexion;
        private string _IDHotel;
        private string _NombreHotel;
        private int _Opcion;

        public float CategoriaHotel
        {
            get { return _CategoriaHotel; }
            set { _CategoriaHotel = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string IDHotel
        {
            get { return _IDHotel; }
            set { _IDHotel = value; }
        }
        public string NombreHotel
        {
            get { return _NombreHotel; }
            set { _NombreHotel = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
    }
}
