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
    public class TipoVehiculo_Datos
    {
        public List<TipoVehiculo> ObtenerComboRecursoVehiculo(Solicitud datos)
        {
            try
            {
                SqlDataReader dr;
                TipoVehiculo item;
                List<TipoVehiculo> lista = new List<TipoVehiculo>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboRecursosVehiculo_CH", datos.IDSolicitud, datos.IDVehiculo);
                while (dr.Read())
                {
                    item = new TipoVehiculo();
                    item.IDVehiculo = dr.GetString(dr.GetOrdinal("IDVehiculo"));
                    item.TipoVehiculoDescripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoVehiculo> ObtenerComboTipoVehiculo(TipoVehiculo datos)
        {
            try
            {
                SqlDataReader dr;
                TipoVehiculo item;
                List<TipoVehiculo> lista = new List<TipoVehiculo>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboVehiculos_CH", datos.Opcion, datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new TipoVehiculo();
                    item.IDTipoVehiculo = dr.GetString(dr.GetOrdinal("IDTipoVehiculo"));
                    item.IDVehiculo = dr.GetString(dr.GetOrdinal("IDVehiculo"));
                    item.TipoVehiculoDescripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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
