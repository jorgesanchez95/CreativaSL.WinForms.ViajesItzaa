using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Empresa
    {
        private string _Conexion;
        private string _Contacto;
        private string _Correo;
        private string _IDEmpresa;
        private string _IDUsuario;
        private string _NombreComercial;
        private int _Opcion;
        private string _Telefono;
        private bool _Validador;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public string Contacto
        {
            get { return _Contacto; }
            set { _Contacto = value; }
        }
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        public string IDEmpresa
        {
            get { return _IDEmpresa; }
            set { _IDEmpresa = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public string NombreComercial
        {
            get { return _NombreComercial; }
            set { _NombreComercial = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
        
    }
}
