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
    public class Caja_Datos
    {
        public void AgregarDeposito(DepositoRetiro deposito)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(deposito.Conexion, "spCSLDB_abc_Depositos", deposito.Opcion, deposito.IDDepositoRetiro, deposito.IDCaja, deposito.IDUsuario, deposito.Monto, deposito.Motivo, deposito.IDSucursal) <= 0)
                {
                    deposito.Validador = false;
                }
                else
                {
                    deposito.Validador = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarRetiro(DepositoRetiro retiro)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(retiro.Conexion, "spCSLDB_abc_Retiros", retiro.Opcion, retiro.IDDepositoRetiro, retiro.IDCaja, retiro.IDUsuario, retiro.IDTipoDepositoRetiro, retiro.Monto, retiro.Motivo, retiro.IDSucursal) <= 0)
                {
                    retiro.Validador = false;
                }
                else
                {
                    retiro.Validador = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AsignarCajaMAC(Caja datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDCajaCat, datos.Mac, datos.NombreCaja, datos.IDSucursal };
                if (SqlHelper.ExecuteNonQuery(datos.CadConexion, "spCSLDB_set_CajaMac", parametros) > 0)
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GuardarAperturaCaja(Caja caja)
        {
            try
            {
                object[] valores = {    caja.IDCaja, 
                                        caja.IDCajaCat, 
                                        caja.IDSucursal,
                                        caja.M50C, 
                                        caja.M1P, 
                                        caja.M2P, 
                                        caja.M5P, 
                                        caja.M10P, 
                                        caja.M20P,
                                        caja.M100P, 
                                        caja.B20P, 
                                        caja.B50P, 
                                        caja.B100P, 
                                        caja.B200P, 
                                        caja.B500P,
                                        caja.B1000P, 
                                        caja.Apertura, 
                                        caja.IDUsuario, 
                                        caja.FechaIngreso, 
                                        caja.HoraIngreso};
                if (SqlHelper.ExecuteNonQuery(caja.CadConexion, "spCSLDB_set_AperturaCaja", valores) > 1)
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GuardarMontoTotalEnCaja(Caja caja)
        {
            try
            {
                object[] Valores = { caja.IDCaja, caja.IDSucursal, caja.M50C, caja.M1P, 
                                       caja.M2P, caja.M5P, caja.M10P, caja.M20P,
                                       caja.M100P, caja.B20P, caja.B50P, caja.B100P,
                                       caja.B200P, caja.B500P, caja.B1000P, caja.Cierre,
                                       caja.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(caja.CadConexion, "spCSLDB_set_CierreCaja", Valores) > 1)
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Caja> LlenarComboCajaXSucursalXFecha(Caja datos)
        {
            try
            {
                List<Caja> lista = new List<Caja>();
                Caja item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.CadConexion, "spCSLDB_get_ComboCajas_CH", datos.FechaApertura);
                while (dr.Read())
                {
                    item = new Caja(datos.CadConexion);
                    item.IDCaja = dr.GetString(dr.GetOrdinal("IDCaja"));
                    item.NombreCaja = dr.GetString(dr.GetOrdinal("Descripcion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Caja> LlenarComboCatCajas(Caja datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Caja> lista = new List<Caja>();
                Caja caja;
                dr = SqlHelper.ExecuteReader(datos.CadConexion, "spCSLDB_get_comboCatCajas", datos.Opcion);
                while (dr.Read())
                {
                    caja = new Caja(datos.CadConexion);
                    caja.IDCajaCat = dr.GetString(dr.GetOrdinal("id_caja"));
                    caja.CajaCat = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(caja);
                }
                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Caja ObtenerResumenCaja(Reporte datos)
        {
            try
            {
                Caja aux = new Caja(datos.Conexion);
                //IDUsuario tiene el valor de IDCaja
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptCajaResumen", datos.IDUsuario);
                while (dr.Read())
                {
                    aux.NombreCaja = dr.GetString(dr.GetOrdinal("Cajero"));
                    aux.FechaApertura = dr.GetDateTime(dr.GetOrdinal("FechaApertura"));
                    aux.HoraIngreso = dr.GetString(dr.GetOrdinal("HoraApertura"));
                    aux.Apertura = dr.GetDecimal(dr.GetOrdinal("MontoApertura"));
                    aux.TotalCobros = dr.GetDecimal(dr.GetOrdinal("TotalCobros"));
                    aux.TotalDepositos = dr.GetDecimal(dr.GetOrdinal("TotalDepositos"));
                    aux.TotalRetirosPagos = dr.GetDecimal(dr.GetOrdinal("TotalRetiros"));
                    aux.TotalPenalizacion = dr.GetDecimal(dr.GetOrdinal("TotalPenalizacion"));
                    aux.TotalDevolucion = dr.GetDecimal(dr.GetOrdinal("TotalDevolucion"));
                    aux.TotalComision = dr.GetDecimal(dr.GetOrdinal("TotalComision"));
                    aux.TotalCaja = dr.GetDecimal(dr.GetOrdinal("TotalCaja"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
