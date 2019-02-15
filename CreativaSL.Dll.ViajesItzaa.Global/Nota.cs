using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Nota
    {
        private string _Conexion;
        private DateTime _FechaNota;
        private DateTime _FechaNotificacion;
        private string _IDNota;
        private string _IDSolicitud;
        private string _IDUsuario;
        private bool _Notificar;
        private string _NotificarText;
        private int _Opcion;
        private string _TextoNota;
        private bool _Validador;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public DateTime FechaNota
        {
            get { return _FechaNota; }
            set { _FechaNota = value; }
        }
        public DateTime FechaNotificacion
        {
            get { return _FechaNotificacion; }
            set { _FechaNotificacion = value; }
        }
        public string IDNota
        {
            get { return _IDNota; }
            set { _IDNota = value; }
        }
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public bool Notificar
        {
            get { return _Notificar; }
            set { _Notificar = value; }
        }
        public string NotificarText
        {
            get { return _NotificarText; }
            set { _NotificarText = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public string TextoNota
        {
            get { return _TextoNota; }
            set { _TextoNota = value; }
        }
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
    }
}
