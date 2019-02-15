using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.ViajesItzaa.Datos
{
    public class Usuario_Datos
    {

        public void ActualizarDatosUsuario(Usuario datos)
        {
            try
            {
                object[] parametros = { 
                        datos.IDUsuario, datos.Nombre, datos.ApellidoPaterno, datos.ApellidoMaterno, 
                        datos.FechaNacimiento, datos.Direccion, datos.Telefono, datos.Correo, 
                        datos.UsuarioPassword };
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_ActualizarDatosUsuario", parametros) > 0)
                    datos.Validador = 1;
                else
                    datos.Validador = 0;
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
                object[] parametros = { datos.UsuarioCuenta, datos.UsuarioPassword, IDTabla, NombreTabla, Texto };
                SqlDataReader dtr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_AutorizacionAdmin", parametros);
                while (dtr.Read())
                {
                    datos.Validador = dtr.GetInt32(0);
                    if (datos.Validador == 1)
                    {
                        datos.IDAutenticacion = dtr.GetString(dtr.GetOrdinal("IDUsuario"));
                    }
                }
                return datos;
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
                Usuario item;
                SqlDataReader dr;
                List<Usuario> lista = new List<Usuario>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboUsuarios_CH", datos.IDUsuario);
                while (dr.Read())
                {
                    item = new Usuario();
                    item.IDUsuario = dr.GetString(dr.GetOrdinal("IDUsuario"));
                    item.Nombre = dr.GetString(dr.GetOrdinal("NombreUsuario"));
                    lista.Add(item);
                }
                return lista;
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
                Usuario item;
                SqlDataReader dr;
                List<Usuario> lista = new List<Usuario>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboUsuariosRpt_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new Usuario();
                    item.IDUsuario = dr.GetString(dr.GetOrdinal("IDUsuario"));
                    item.Nombre = dr.GetString(dr.GetOrdinal("NombreUsuario"));
                    lista.Add(item);
                }
                return lista;
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
                object[] parametros = { datos.IDUsuario};
                SqlDataReader dtr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_UsuarioIDConfig", parametros);
                while (dtr.Read())
                {
                    datos.IDUsuario = dtr.GetString(dtr.GetOrdinal("IDUsuario"));
                    datos.Nombre = dtr.GetString(dtr.GetOrdinal("Nombre"));
                    datos.ApellidoPaterno = dtr.GetString(dtr.GetOrdinal("ApellidoPaterno"));
                    datos.ApellidoMaterno = dtr.GetString(dtr.GetOrdinal("ApellidoMaterno"));
                    if (!Convert.IsDBNull(dtr.GetValue(dtr.GetOrdinal("FechaNacimiento"))))
                    {
                        datos.FechaNacimiento = dtr.GetDateTime(dtr.GetOrdinal("FechaNacimiento"));
                    }
                    datos.Direccion = dtr.GetString(dtr.GetOrdinal("Direccion"));
                    datos.Telefono = dtr.GetString(dtr.GetOrdinal("Telefono"));
                    datos.Correo = dtr.GetString(dtr.GetOrdinal("CorreoElectronico"));
                }
                return datos;
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
                Usuario resultado = new Usuario();
                object[] parametros = { datos.IDSolicitud };
                SqlDataReader dtr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_UsuarioXIDSolicitud_CH", parametros);
                while (dtr.Read())
                {
                    resultado.IDUsuario = dtr.GetString(dtr.GetOrdinal("IDUsuario"));
                    resultado.Nombre = dtr.GetString(dtr.GetOrdinal("NombreUsuario"));                    
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
