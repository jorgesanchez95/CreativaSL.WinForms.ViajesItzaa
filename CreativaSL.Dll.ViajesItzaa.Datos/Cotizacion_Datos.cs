using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.ViajesItzaa.Datos
{
    public class Cotizacion_Datos
    {
        public void AbcCotizaciones(Cotizacion datos)
        {
            try
            {
                object[] parametros = {datos.Opcion, datos.IDCotizacion, datos.IDSolicitud, datos.Descripcion,
                                      datos.Subtotal, datos.Comentarios, datos.IDUsuario, datos.IDSucursal};
                object result = SqlHelper.ExecuteScalar(datos.Conexion, CommandType.StoredProcedure, "spCSLDB_abc_Cotizaciones_CH",
                        new SqlParameter("@Opcion", datos.Opcion),
                        new SqlParameter("@IDCotizacion", datos.IDCotizacion),
                        new SqlParameter("@IDSolicitud", datos.IDSolicitud),
                        new SqlParameter("@Descripcion", datos.Descripcion),
                        new SqlParameter("@Subtotal", datos.Subtotal),
                        new SqlParameter("@Comentarios", datos.Comentarios),
                        new SqlParameter("@IDUsuario", datos.IDUsuario),
                        new SqlParameter("@IDSucursal", datos.IDSucursal),
                        new SqlParameter("@Habitaciones", datos.TablaHabitaciones));

                if (result != null)
                {
                    if(!string.IsNullOrEmpty(result.ToString()))
                    {
                        datos.Validador = true;
                        datos.IDCotizacion = result.ToString();
                    }
                    else
                    {
                        datos.Validador = false;
                        datos.IDCotizacion = string.Empty;
                    }
                }
                else
                {
                    datos.Validador = false;
                    datos.IDCotizacion = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEstatusCotizacion(Cotizacion datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_DisponibilidadCotizacion", datos.IDCotizacion, datos.IDStatusCotizacion, datos.IDUsuario) > 0)
                {
                    datos.Validador = true;
                }
                else
                {
                    datos.Validador = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EnviarCotizacion(Solicitud datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_EnviarCotizaciones", datos.IDSolicitud, datos.IDUsuario) > 1)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cotizacion> ObtenerCotizacionesAEnviar(Solicitud datos)
        {
            try
            {
                List<Cotizacion> lista = new List<Cotizacion>();
                Cotizacion item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_CotizacionesAEnviar_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    item = new Cotizacion();
                    item.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cotizacion ObtenerDetalleSolicitudCotizacion(Cotizacion datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Cotizacion CotizacionResultado = new Cotizacion();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DetalleCotizacionCH", datos.IDSolicitud, datos.IDCotizacion);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[0] != null)
                        {
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {

                                CotizacionResultado.IDCotizacion = dr.GetString(dr.GetOrdinal("id_cotizacion"));
                                CotizacionResultado.Subtotal = dr.GetDecimal(dr.GetOrdinal("subtotal"));
                                CotizacionResultado.Comentarios = dr.GetString(dr.GetOrdinal("comentarios"));
                                CotizacionResultado.Descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                            }
                            if (ds.Tables[1] != null)
                            {
                                CotizacionResultado.TablaHabitaciones = ds.Tables[1];
                            }
                        }
                    }
                }
                return CotizacionResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cotizacion> ObtenerMiniGridCotizaciones(Cotizacion datos)
        {
            try
            {
                SqlDataReader dr;
                Cotizacion item;
                List<Cotizacion> lista = new List<Cotizacion>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_MiniGridCotizacionesXIDSolicitud", datos.IDSolicitud);
                while (dr.Read())
                {
                    item = new Cotizacion();
                    item.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    item.IDStatusCotizacion = dr.GetInt32(dr.GetOrdinal("IDStatus"));
                    item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cotizacion> ObtenerGridCotizaciones(Cotizacion datos)
        {
            try
            {
                SqlDataReader dr;
                Cotizacion item;
                List<Cotizacion> lista = new List<Cotizacion>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_CotizacionesXIDSolicitud", datos.IDSolicitud);
                while (dr.Read())
                {
                    item = new Cotizacion();
                    item.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    item.IDStatusCotizacion = dr.GetInt32(dr.GetOrdinal("IDStatus"));
                    item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                    item.FechaCotizacion = dr.GetDateTime(dr.GetOrdinal("FechaCotizacion"));
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
