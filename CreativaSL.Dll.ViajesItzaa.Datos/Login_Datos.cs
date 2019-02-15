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
    public class Login_Datos
    {
        public Usuario ValidarUsuario(Usuario usuario)
        {
            try
            {
                SqlDataReader SqlDr = null;
                string[] valores = { usuario.UsuarioCuenta, usuario.UsuarioPassword, Comun.MACAddress };
                SqlDr = SqlHelper.ExecuteReader(usuario.Conexion, "spCSLDB_get_Login", valores);
                if (SqlDr.HasRows == true)
                {
                    SqlDr.Read();
                    usuario.Validador = SqlDr.GetInt32(0);
                    if (usuario.Validador == 1)
                    {
                        usuario.IDUsuario = SqlDr.GetString(SqlDr.GetOrdinal("IDUsuario"));
                        usuario.Nombre = SqlDr.GetString(SqlDr.GetOrdinal("NombreUsuario"));
                        usuario.ApellidoPaterno = SqlDr.GetString(SqlDr.GetOrdinal("ApellidoPaterno"));
                        usuario.ApellidoMaterno = SqlDr.GetString(SqlDr.GetOrdinal("ApellidoMaterno"));
                        usuario.IDTipoUsuario = SqlDr.GetInt32(SqlDr.GetOrdinal("IDTipoUsuario"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("CuentaEstatus"))))
                            usuario.CuentaEstatus = false;
                        else
                            usuario.CuentaEstatus = SqlDr.GetBoolean(SqlDr.GetOrdinal("CuentaEstatus"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("CuentaCaducada"))))
                            usuario.CuentaCaducada = false;
                        else
                            usuario.CuentaCaducada = Convert.ToBoolean(SqlDr.GetValue(SqlDr.GetOrdinal("CuentaCaducada")));
                        usuario.IDSucursal = SqlDr.GetString(SqlDr.GetOrdinal("IDSucursal"));
                        usuario.CrearIDCaja = SqlDr.GetBoolean(SqlDr.GetOrdinal("Crearid_caja"));
                        usuario.IDCaja = SqlDr.GetString(SqlDr.GetOrdinal("IDCaja"));
                        //Llenamos datos necesarios para otras pantallas
                        Comun.IDUsuario = usuario.IDUsuario;
                        Comun.IDTipoUsuario = usuario.IDTipoUsuario;
                        Comun.NombreUsuario = usuario.Nombre;
                        Comun.ApellidoPaternoUsuario = usuario.ApellidoPaterno;
                        Comun.ApellidoMaternoUsuario = usuario.ApellidoMaterno;
                        Comun.IDCaja = usuario.IDCaja;
                        Comun.Impresora = SqlDr.GetString(SqlDr.GetOrdinal("Impresora"));
                        Comun.TipoUsuario = SqlDr.GetString(SqlDr.GetOrdinal("TipoUsuario"));
                        Comun.UsuarioCuenta = SqlDr.GetString(SqlDr.GetOrdinal("UsuarioCuenta"));
                        Comun.IDCajaCat = SqlDr.GetString(SqlDr.GetOrdinal("IDCatCaja"));
                        Comun.UrlFacebook = SqlDr.GetString(SqlDr.GetOrdinal("URLFacebook"));
                        Comun.UrlTwitter = SqlDr.GetString(SqlDr.GetOrdinal("URLTwitter"));
                        Comun.UrlGoogle = SqlDr.GetString(SqlDr.GetOrdinal("URLGoogle"));
                        Comun.CorreoEmpresa = SqlDr.GetString(SqlDr.GetOrdinal("CorreoEmpresa"));
                        Comun.UrlInstagram = SqlDr.GetString(SqlDr.GetOrdinal("URLInstagram"));
                        Comun.Dominio = SqlDr.GetString(SqlDr.GetOrdinal("URLDominio"));
                        Comun.PorcentajeAnticipo = SqlDr.GetDecimal(SqlDr.GetOrdinal("PorcentajeAnticipo"));
                        Comun.RazonSocial = SqlDr.GetString(SqlDr.GetOrdinal("RazonSocial"));
                        Comun.Direccion = SqlDr.GetString(SqlDr.GetOrdinal("Direccion"));
                        Comun.RFC = SqlDr.GetString(SqlDr.GetOrdinal("RFC"));
                        Comun.UrlLogo = SqlDr.GetString(SqlDr.GetOrdinal("UrlLogo"));
                        Comun.UrlYoutube = SqlDr.GetString(SqlDr.GetOrdinal("URLYoutube"));
                        Comun.RegistroNacional = SqlDr.GetString(SqlDr.GetOrdinal("ResgistroNacional"));
                        Comun.Telefono2 = SqlDr.GetString(SqlDr.GetOrdinal("NumeroTe"));
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede obtener la información" + ex.Message);
            }
        }
    }
}
