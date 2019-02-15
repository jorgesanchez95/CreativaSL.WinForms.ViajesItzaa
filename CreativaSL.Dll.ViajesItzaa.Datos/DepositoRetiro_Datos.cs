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
    public class DepositoRetiro_Datos
    {
        public List<DepositoRetiro> ObtenerDepositosRetirosXIDCaja(Reporte datos)
        {
            try
            {
                List<DepositoRetiro> lista = new List<DepositoRetiro>();
                DepositoRetiro item;
                int aux = 0;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptDesgloceDepositosRetiros", datos.Opcion, datos.IDUsuario);
                while (dr.Read())
                {
                    item = new DepositoRetiro();
                    aux++;
                    item.Opcion = aux;
                    item.Motivo = dr.GetString(dr.GetOrdinal("Motivo"));
                    item.Monto = dr.GetDecimal(dr.GetOrdinal("Monto"));
                    object Fecha = dr.GetValue(dr.GetOrdinal("FechaHora"));
                    if (Fecha != null)
                    {
                        if (!string.IsNullOrEmpty(Fecha.ToString()))
                            item.FechaHora = dr.GetDateTime(dr.GetOrdinal("FechaHora"));
                    }
                    item.IDUsuario = dr.GetString(dr.GetOrdinal("Usuario"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
