using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public static class Comun
    {
        #region Datos de uso General
        private static string _ApellidoMaternoUsuario;
        private static string _ApellidoPaternoUsuario;
        private static string _CaptionSystem;
        private static int _CodigoPostal;
        private static string _Conexion;
        private static string _Direccion;
        private static DateTime _FechaIngreso;
        private static string _HostName;
        private static string _IconoSistema;
        private static string _IDCaja;
        private static string _IDCajaCat;
        private static int _IDEstado;
        private static int _IDMunicipio;
        private static int _IDPais;
        private static string _IDSucursalCaja;
        private static int _IDTipoUsuario;
        private static string _IDUsuario;
        private static string _Impresora;
        private static string _MACAddress;
        private static string _MensajeError;
        private static string _NombreSucursal;
        private static string _NombreUsuario;
        private static decimal _PorcentajeAnticipo;
        private static decimal _PorcentajeIVA;
        private static decimal _PorcentajeMonedero;
        private static string _RazonSocial;
        private static string _RFC;
        private static string _Telefono;
        private static string _TipoUsuario;
        private static string _Turno;
        private static string _UrlAyuda;
        private static string _UrlLogo;
        private static string _UrlTxtLog;
        private static string _UsuarioCuenta;
    
        public static string ApellidoMaternoUsuario
        {
            get { return _ApellidoMaternoUsuario; }
            set { _ApellidoMaternoUsuario = value; }
        }
        public static string ApellidoPaternoUsuario
        {
            get { return _ApellidoPaternoUsuario; }
            set { _ApellidoPaternoUsuario = value; }
        }
        public static string CaptionSystem
        {
            get { return _CaptionSystem; }
            set { _CaptionSystem = value; }
        }
        public static int CodigoPostal
        {
            get { return _CodigoPostal; }
            set { _CodigoPostal = value; }
        }
        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public static string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public static DateTime FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }
        public static string HostName
        {
            get { return _HostName; }
            set { _HostName = value; }
        }
        public static string IconoSistema
        {
            get { return _IconoSistema; }
            set { _IconoSistema = value; }
        }
        public static string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }
        public static string IDCajaCat
        {
            get { return _IDCajaCat; }
            set { _IDCajaCat = value; }
        }
        public static int IDEstado
        {
            get { return _IDEstado; }
            set { _IDEstado = value; }
        }
        public static int IDMunicipio
        {
            get { return _IDMunicipio; }
            set { _IDMunicipio = value; }
        }
        public static int IDPais
        {
            get { return _IDPais; }
            set { _IDPais = value; }
        }
        public static string IDSucursalCaja
        {
            get { return _IDSucursalCaja; }
            set { _IDSucursalCaja = value; }
        }
        public static int IDTipoUsuario
        {
            get { return _IDTipoUsuario; }
            set { _IDTipoUsuario = value; }
        }
        public static string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public static string Impresora
        {
            get { return _Impresora; }
            set { _Impresora = value; }
        }
        public static string MACAddress
        {
            get { return _MACAddress; }
            set { _MACAddress = value; }
        }
        public static string MensajeError
        {
            get { return _MensajeError; }
            set { _MensajeError = value; }
        }
        public static string NombreSucursal
        {
            get { return _NombreSucursal; }
            set { _NombreSucursal = value; }
        }
        public static string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        public static decimal PorcentajeAnticipo
        {
            get { return _PorcentajeAnticipo; }
            set { _PorcentajeAnticipo = value; }
        }
        public static decimal PorcentajeIVA
        {
            get { return _PorcentajeIVA; }
            set { _PorcentajeIVA = value; }
        }
        public static decimal PorcentajeMonedero
        {
            get { return _PorcentajeMonedero; }
            set { _PorcentajeMonedero = value; }
        }
        public static string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
        public static string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
        public static string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public static string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }
        public static string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }
        public static string UrlAyuda
        {
            get { return _UrlAyuda; }
            set { _UrlAyuda = value; }
        }
        public static string UrlLogo
        {
            get { return _UrlLogo; }
            set { _UrlLogo = value; }
        }
        public static string UrlTxtLog
        {
            get { return _UrlTxtLog; }
            set { _UrlTxtLog = value; }
        }
        public static string UsuarioCuenta
        {
            get { return _UsuarioCuenta; }
            set { _UsuarioCuenta = value; }
        }

        #region Permisos

        private static bool _ModI;

        public static bool ModI
        {
            get { return _ModI; }
            set { _ModI = value; }
        }

        private static bool _ModII;

        public static bool ModII
        {
            get { return _ModII; }
            set { _ModII = value; }
        }

        private static bool _ModIII;

        public static bool ModIII
        {
            get { return _ModIII; }
            set { _ModIII = value; }
        }

        private static bool _ModIV;

        public static bool ModIV
        {
            get { return _ModIV; }
            set { _ModIV = value; }
        }

        private static bool _ModV;

        public static bool ModV
        {
            get { return _ModV; }
            set { _ModV = value; }
        }

        private static bool _ModVI;

        public static bool ModVI
        {
            get { return _ModVI; }
            set { _ModVI = value; }
        }
        #endregion

        #region Datos/url's  para envío de correo

        private static string _Dominio;

        public static string Dominio
        {
            get { return _Dominio; }
            set { _Dominio = value; }
        }

        private static string _UrlFacebook;

        public static string UrlFacebook
        {
            get { return _UrlFacebook; }
            set { _UrlFacebook = value; }
        }

        private static string _UrlTwitter;

        public static string UrlTwitter
        {
            get { return _UrlTwitter; }
            set { _UrlTwitter = value; }
        }

        private static string _UrlGoogle;

        public static string UrlGoogle
        {
            get { return _UrlGoogle; }
            set { _UrlGoogle = value; }
        }

        private static string _UrlYoutube;

        public static string UrlYoutube
        {
            get { return _UrlYoutube; }
            set { _UrlYoutube = value; }
        }

        private static string _ResgistroNacional;

        public static string RegistroNacional
        {
            get { return _ResgistroNacional; }
            set { _ResgistroNacional = value; }
        }
        private static string _UrlInstagram;

        public static string UrlInstagram
        {
            get { return _UrlInstagram; }
            set { _UrlInstagram = value; }
        }
        

        private static string _CorreoEmpresa;

        public static string CorreoEmpresa
        {
            get { return _CorreoEmpresa; }
            set { _CorreoEmpresa = value; }
        }

        private static string _Telefono2;

        public static string Telefono2
        {
            get { return _Telefono2; }
            set { _Telefono2 = value; }
        }
        
        #endregion

        #endregion

    }
}
