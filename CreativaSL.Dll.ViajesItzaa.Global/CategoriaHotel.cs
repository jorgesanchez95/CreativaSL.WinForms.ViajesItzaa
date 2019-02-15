using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class CategoriaHotel
    {
        private string _Conexion;
        private string _Descripcion;
        private float _IDCategoria;
        private int _Opcion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public float IDCategoria
        {
            get { return _IDCategoria; }
            set { _IDCategoria = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
    }
}
