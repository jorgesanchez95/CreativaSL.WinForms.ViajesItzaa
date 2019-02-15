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
    public class Comun_Datos
    {
        public void ObtenerConfiguracion(string conexion)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(conexion, "spCSLDB_get_IDSucursalEquipo", Comun.MACAddress);
                Comun.IDSucursalCaja = Convert.ToString(res);
                if (!string.IsNullOrEmpty(Comun.IDSucursalCaja) && !string.IsNullOrWhiteSpace(Comun.IDSucursalCaja))
                {
                    SqlDataReader SqlDr = null;
                    SqlDr = SqlHelper.ExecuteReader(conexion, "spCSLDB_get_ConfiguracionInicial", Comun.IDSucursalCaja);
                    if (SqlDr.HasRows == true)
                    {
                        SqlDr.Read();
                        Comun.IDSucursalCaja = SqlDr.GetString(SqlDr.GetOrdinal("id_sucursal"));
                        Comun.NombreSucursal = SqlDr.GetString(SqlDr.GetOrdinal("nombre_Sucursal"));
                        //Comun.Direccion = SqlDr.GetString(SqlDr.GetOrdinal("direccion"));
                        Comun.Telefono = SqlDr.GetString(SqlDr.GetOrdinal("telefono"));
                        Comun.IDMunicipio = SqlDr.GetInt32(SqlDr.GetOrdinal("id_municipio"));
                        Comun.IDEstado = SqlDr.GetInt32(SqlDr.GetOrdinal("id_estado"));
                        Comun.IDPais = SqlDr.GetInt32(SqlDr.GetOrdinal("id_pais"));
                        Comun.CodigoPostal = SqlDr.GetInt32(SqlDr.GetOrdinal("codigopostal"));
                        Comun.PorcentajeMonedero = SqlDr.GetDecimal(SqlDr.GetOrdinal("porcentajeMonedero"));
                        Comun.PorcentajeIVA = SqlDr.GetDecimal(SqlDr.GetOrdinal("porcentajeIVA"));
                    }
                    else
                        throw new Exception("No se pudo cargar la configuracion inicial. Informe a su administrador");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
