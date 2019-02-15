using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Usuario_Negocio
    {

        public void ActualizarDatosUsuario(Usuario datos)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                ud.ActualizarDatosUsuario(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario AutorizacionAdmin(Usuario datos, string IDTabla, string NombreTabla, string Texto)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                return ud.AutorizacionAdmin(datos, IDTabla, NombreTabla, Texto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ObtenerComboCambioUsuario(Usuario datos)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                return ud.ObtenerComboCambioUsuario(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ObtenerComboUsuario(Usuario datos)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                return ud.ObtenerComboUsuario(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerDatosUsuario(Usuario datos)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                return ud.ObtenerDatosUsuario(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerUsuarioXIDSolicitud(Solicitud datos)
        {
            try
            {
                Usuario_Datos ud = new Usuario_Datos();
                return ud.ObtenerUsuarioXIDSolicitud(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
