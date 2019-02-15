using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace CreativaSL.Dll.ViajesItzaa.Datos
{
    public class Solicitud_Datos
    {
        public void AceptarSolicitud(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDSolicitud, datos.IDUsuarioRecibido};
                object resultado = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_set_AceptarSolicitud", parametros);
                int aux = 0;
                if(int.TryParse(resultado.ToString(), out aux))
                if(aux == 0)
                    datos.Validador = true;
                else
                {
                    datos.Validador = false;
                    datos.Opcion = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void ActualizarDatosFechasLimPago(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDSolicitud, datos.FechaLimPagoInicial, datos.FechaLimPagoFinal, datos.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_ActualizarFechasLimPagos", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosFechasPago(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDSolicitud, datos.IDCotizacion, datos.FechaLimPagoInicial, datos.FechaLimPagoFinal, datos.RequiereFactura, datos.IDUsuario, datos.IDSucursal, datos.IDCaja };
                object result = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_set_ActualizarDatosFechasPagos", parametros);
                if (result != null)
                {
                    if (!string.IsNullOrEmpty(result.ToString()))
                        datos.Validador = true;
                    else
                        datos.Validador = false;
                }
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosHabitaciones(Solicitud datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, CommandType.StoredProcedure, "spCSLDB_set_ActualizarDatosHabitaciones",
                    new SqlParameter("@Opcion", datos.Opcion),
                    new SqlParameter("@IDSolicitud", datos.IDSolicitud),
                    new SqlParameter("@CategoriaHotel", datos.CategoriaHotel),
                    new SqlParameter("@NumHabitaciones", datos.NumHabitaciones),
                    new SqlParameter("@DHNumAdultos", datos.NumAdultos),
                    new SqlParameter("@DHNumMenores4", datos.NumMenores4),
                    new SqlParameter("@DHNumMenores11", datos.NumMenores11),
                    new SqlParameter("@IDUsuario", datos.IDUsuario),
                    new SqlParameter("@TblHabitaciones", datos.TablaHabitaciones)
                    ) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosItinerario(Solicitud datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, CommandType.StoredProcedure, "spCSLDB_set_ActualizarDatosItinerario",
                    new SqlParameter("@Opcion", datos.Opcion),
                    new SqlParameter("@IDSolicitud", datos.IDSolicitud),
                    new SqlParameter("@NumDiasItinerario", datos.NumDias),
                    new SqlParameter("@TblItinerario", datos.TablaItinerario),
                    new SqlParameter("@IDUsuario", datos.IDUsuario)
                    ) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosProducto(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDSolicitud, datos.IDProducto, datos.IDTipoVehiculo, datos.Observaciones, datos.IDUsuario };
                object aux = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_set_ActualizarProductoSolicitud", parametros);
                if (aux != null)
                {
                    if (!string.IsNullOrEmpty(aux.ToString()))
                        datos.Validador = true;
                    else
                        datos.Validador = false;
                }
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosViaje(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDSolicitud, datos.TieneBoletosAvion, 
                                        datos.AeropueroLlegada, datos.AeropuertoSalida, datos.FechaLlegada,
                                        datos.HoraLlegada, datos.FechaSalida, datos.HoraSalida, datos.IDUsuario };
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_ActualizarDatosViajeSolicitud", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarRecursos(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDSolicitud, datos.IDChofer, datos.IDHotel, datos.IDVehiculo, datos.IDUsuario };
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_set_ActualizarRecursos", parametros);
                while (dr.Read())
                {
                    datos.Opcion = dr.GetInt32(dr.GetOrdinal("result"));
                    if (datos.Opcion == 1)
                    {
                        datos.Validador = true;
                    }
                    else
                    {
                        datos.Validador = dr.GetBoolean(dr.GetOrdinal("BandChofer"));
                        if (!datos.Validador)
                        {
                            datos.Opcion = 1;
                        }
                        else
                        {
                            datos.Validador = dr.GetBoolean(dr.GetOrdinal("BandHotel"));
                            if (!datos.Validador)
                            {
                                datos.Opcion = 2;
                            }
                            else
                            {
                                datos.Validador = dr.GetBoolean(dr.GetOrdinal("BandVehiculo"));
                                if (!datos.Validador)
                                    datos.Opcion = 3;
                                else
                                    datos.Opcion = 0;
                            }
                        }
                        datos.Validador = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
        public void CambiarUsuarioSolicitud(Solicitud datos)
        {
            try
            {
                object[] parametros = {datos.IDSolicitud, datos.IDUsuarioRecibido, datos.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_CambiarUsuarioSolicitud", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CancelarSolicitud(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDSolicitud,datos.MotivoCancelacion, datos.MontoPenalizacion, datos.IDUsuario, datos.IDCaja };
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_InsertarCancelacion", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertarSolicitud(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDCliente, datos.IDTipoSolicitud, datos.MontoInicial, datos.MotivoMontoInicial, datos.IDUsuario, datos.EsEmpresa, datos.IDAutenticacion };
                object IDSolicitud = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_set_InsertarSolicitudPaso1", parametros);
                if(IDSolicitud != null)
                {
                    if(!string.IsNullOrEmpty(IDSolicitud.ToString()) && !string.IsNullOrWhiteSpace(IDSolicitud.ToString()))
                    {
                        datos.IDSolicitud = IDSolicitud.ToString();
                        datos.Validador = true;
                    }
                    else
                    {
                        datos.IDSolicitud = string.Empty;
                        datos.Validador = false;
                    }
                }
                else
                {
                    datos.IDSolicitud = string.Empty;
                    datos.Validador = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void NuevaSolicitud(Solicitud datos)
        {
            try
            {
                object IDSolicitud = SqlHelper.ExecuteScalar(datos.Conexion, CommandType.StoredProcedure, "spCSLDB_set_InsertarSolicitud",
                    new SqlParameter("@FechaLlegada", datos.FechaLlegada),
                    new SqlParameter("@HoraLlegada", datos.HoraLlegada),
                    new SqlParameter("@FechaSalida", datos.FechaSalida),
                    new SqlParameter("@HoraSalida", datos.HoraSalida),
                    new SqlParameter("@IDCliente", datos.IDCliente),
                    new SqlParameter("@EsEmpresaCliente", datos.EsEmpresa),
                    new SqlParameter("@IDTipoSolicitud", datos.IDTipoSolicitud),
                    new SqlParameter("@IDProducto", datos.IDProducto),
                    new SqlParameter("@IDTipoVehiculo", datos.IDTipoVehiculo),
                    new SqlParameter("@CategoriaHotel", datos.CategoriaHotel),
                    new SqlParameter("@NumHabitaciones", datos.NumHabitaciones),
                    new SqlParameter("@NumAdultos", datos.NumAdultos),
                    new SqlParameter("@NumMenores4", datos.NumMenores4),
                    new SqlParameter("@NumMenores11", datos.NumMenores11),
                    new SqlParameter("@DiasExtra", datos.DiasExtra),
                    new SqlParameter("@Observaciones", datos.Observaciones),
                    new SqlParameter("@FolioAnterior", datos.FolioAnterior),
                    new SqlParameter("@MontoInicial", datos.MontoInicial),
                    new SqlParameter("@MotivoMontoInicial", datos.MotivoMontoInicial),
                    new SqlParameter("@TieneBoletosAvion", datos.TieneBoletosAvion),
                    new SqlParameter("@AeropuertoLlegada", datos.AeropueroLlegada),
                    new SqlParameter("@AeropuertoSalida", datos.AeropuertoSalida),
                    new SqlParameter("@IDUsuario", datos.IDUsuario),
                    new SqlParameter("@IDAutenticacion", datos.IDAutenticacion),
                    new SqlParameter("@NumDiasItinerario", datos.NumDias),
                    new SqlParameter("@TblHabitaciones", datos.TablaHabitaciones),
                    new SqlParameter("@TblItinerario", datos.TablaItinerario)
                    );

                if (IDSolicitud != null)
                {
                    if (!string.IsNullOrEmpty(IDSolicitud.ToString()) && !string.IsNullOrWhiteSpace(IDSolicitud.ToString()))
                    {
                        datos.IDSolicitud = IDSolicitud.ToString();
                        datos.Validador = true;
                    }
                    else
                    {
                        datos.IDSolicitud = string.Empty;
                        datos.Validador = false;
                    }
                }
                else
                {
                    datos.IDSolicitud = string.Empty;
                    datos.Validador = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cotizacion> ObtenerCotizacionesXIDSolicitud(Solicitud datos)
        {
            try
            {
                List<Cotizacion> lista = new List<Cotizacion>();
                Cotizacion item;
                SqlDataReader dr;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCotizaciones_CH", datos.Opcion, datos.IDSolicitud);
                while (dr.Read())
                {
                    item = new Cotizacion();
                    item.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                    if(!string.IsNullOrEmpty(item.IDCotizacion))
                        item.Descripcion = item.Descripcion + " " + string.Format("{0:c}", item.Subtotal);
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosCorreoConfirmaCompra(Solicitud datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud aux = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DatosCorreoConfirmarCompra_CH", datos.IDSolicitud, datos.IDSucursal);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        dr = ds.Tables[0].CreateDataReader();
                        while (dr.Read())
                        {
                            aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                            aux.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                            aux.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                            aux.FechaLimPagoInicial = dr.GetDateTime(dr.GetOrdinal("FechaLimPagoInicial"));
                            aux.FechaLimPagoFinal = dr.GetDateTime(dr.GetOrdinal("FechaLimPagoFinal"));
                            aux.MontoInicial = dr.GetDecimal(dr.GetOrdinal("MontoInicial"));
                            aux.MotivoMontoInicial = dr.GetString(dr.GetOrdinal("MotivoMontoInicial"));
                            aux.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoTotal"));
                            aux.MontoAnticipo = dr.GetDecimal(dr.GetOrdinal("Anticipo"));
                            aux.MontoFinal = dr.GetDecimal(dr.GetOrdinal("Final"));
                            aux.Cliente = new Cliente();
                            aux.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                            aux.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                            if (!string.IsNullOrEmpty(aux.IDSolicitud))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    aux.TablaPaquetes = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosCorreoConfirmaPago(Pago pago)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud aux = new Solicitud();
                ds = SqlHelper.ExecuteDataset(pago.Conexion, "spCSLDB_get_DatosCorreoPago_CH", pago.IDSolicitud, pago.IDPago);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        dr = ds.Tables[0].CreateDataReader();
                        while (dr.Read())
                        {
                            aux.Pago = new Pago();
                            aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                            aux.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                            aux.Pago.IDPago = dr.GetString(dr.GetOrdinal("IDPago"));
                            aux.Pago.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPago"));
                            aux.Pago.FechaPago = dr.GetDateTime(dr.GetOrdinal("FechaPago"));
                            aux.Cliente = new Cliente();
                            aux.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                            aux.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                            if (!string.IsNullOrEmpty(aux.IDSolicitud))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    aux.TablaPaquetes = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosCorreoCancelacion(Solicitud datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud aux = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DatosCorreoCancelacion_CH", datos.IDSolicitud);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        dr = ds.Tables[0].CreateDataReader();
                        while (dr.Read())
                        {
                            aux.Pago = new Pago();
                            aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                            aux.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                            aux.Pago.MontoTotal = dr.GetDecimal(dr.GetOrdinal("Total"));
                            aux.MontoPenalizacion = dr.GetDecimal(dr.GetOrdinal("MontoPenalizacion"));
                            aux.MotivoCancelacion = dr.GetString(dr.GetOrdinal("MotivoCancelacion"));
                            aux.EstatusSolicitud = dr.GetString(dr.GetOrdinal("TipoCancelacion"));
                            aux.Cliente = new Cliente();
                            aux.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                            aux.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                            if (!string.IsNullOrEmpty(aux.IDSolicitud))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    aux.TablaPaquetes = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosCorreoOrdenPago(OrdenPago datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud aux = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DatosCorreoOrdenPago_CH", datos.IDSolicitud, datos.IDOrdenPago);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        dr = ds.Tables[0].CreateDataReader(); 
                        while (dr.Read())
                        {
                            aux.OrdenPago = new OrdenPago();
                            aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                            aux.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                            aux.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                            aux.NombreClienteAgencia = dr.GetString(dr.GetOrdinal("Cliente"));
                            aux.OrdenPago.NombrePago = dr.GetString(dr.GetOrdinal("NombrePago"));
                            aux.OrdenPago.DescripcionPago = dr.GetString(dr.GetOrdinal("Descripcion"));
                            aux.OrdenPago.LinkPago = dr.GetString(dr.GetOrdinal("LinkPago"));
                            aux.OrdenPago.Pago = dr.GetDecimal(dr.GetOrdinal("Pago"));
                            aux.Cliente = new Cliente();
                            aux.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                            aux.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                            if (!string.IsNullOrEmpty(aux.IDSolicitud))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    aux.TablaPaquetes = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosModificarDatosHotel(Solicitud datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DatosModificarHotel_CH", datos.IDSolicitud);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[0] != null)
                        {
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {
                                SolicitudResultado.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                                object aux = dr.GetValue(dr.GetOrdinal("CategoriaHotel")).ToString();
                                SolicitudResultado.CategoriaHotel = float.Parse(dr.GetValue(dr.GetOrdinal("CategoriaHotel")).ToString());
                                SolicitudResultado.NumHabitaciones = dr.GetInt32(dr.GetOrdinal("NumHabitaciones"));
                                SolicitudResultado.NumAdultos = dr.GetInt32(dr.GetOrdinal("NumAdultos"));
                                SolicitudResultado.NumMenores11 = dr.GetInt32(dr.GetOrdinal("NumMenores11"));
                                SolicitudResultado.NumMenores4 = dr.GetInt32(dr.GetOrdinal("NumMenores4"));
                            }
                            if (!string.IsNullOrEmpty(SolicitudResultado.IDSolicitud))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    SolicitudResultado.TablaHabitaciones = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return SolicitudResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosModificarFechasViaje(Solicitud datos)
        {
            try
            {                
                Solicitud aux = new Solicitud();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DatosModificarFechasViaje_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    aux.IDSolicitud = dr.GetString(dr.GetOrdinal("id_solicitud"));
                    aux.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("fechaLlegada"));
                    aux.HoraLlegada = dr.GetString(dr.GetOrdinal("horaLlegada"));
                    aux.FechaSalida = dr.GetDateTime(dr.GetOrdinal("fechaSalida"));
                    aux.HoraSalida = dr.GetString(dr.GetOrdinal("horaSalida"));
                    aux.TieneBoletosAvion = dr.GetBoolean(dr.GetOrdinal("tieneBoletosAvion"));
                    aux.AeropueroLlegada = dr.GetString(dr.GetOrdinal("aereoPuertoLlegada"));
                    aux.AeropuertoSalida = dr.GetString(dr.GetOrdinal("aereoPuertoSalida"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LugarTuristico> ObtenerDatosModificarItinerario(Solicitud datos)
        {
            try
            {
                LugarTuristico item = new LugarTuristico();
                List<LugarTuristico> lista = new List<LugarTuristico>();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DatosModificarItinerario_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    item = new LugarTuristico();
                    item.IDLugar = dr.GetString(dr.GetOrdinal("id_lugar"));
                    item.Lugar = dr.GetString(dr.GetOrdinal("nombre"));
                    item.NumeroDias = dr.GetInt32(dr.GetOrdinal("numdias"));
                    item.Orden = dr.GetInt32(dr.GetOrdinal("orden"));
                    item.Descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    item.DescripcionIngles = dr.GetString(dr.GetOrdinal("descripcionIngles"));
                    item.Observaciones = dr.GetString(dr.GetOrdinal("observaciones"));
                    item.ObservacionesIngles = dr.GetString(dr.GetOrdinal("observacionesIngles"));
                    item.Recomendaciones = dr.GetString(dr.GetOrdinal("recomendaciones"));
                    item.RecomendacionesIngles = dr.GetString(dr.GetOrdinal("recomendaciones_ingles"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosModificarProducto(Solicitud datos)
        {
            try
            {                
                Solicitud aux = new Solicitud();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DatosModificarProducto_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    aux.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
                    aux.IDProducto = dr.GetString(dr.GetOrdinal("IDProducto"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDatosSolicitudFechasPago(Solicitud datos)
        {
            try
            {
                Solicitud aux = new Solicitud();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DatosFechasPago_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    aux.IDSolicitud = datos.IDSolicitud;
                    aux.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    aux.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    aux.FechaLimPagoInicial = dr.GetDateTime(dr.GetOrdinal("FechaLimPagoInicial"));
                    aux.FechaLimPagoFinal = dr.GetDateTime(dr.GetOrdinal("FechaLimPagoFinal"));
                    aux.RequiereFactura = dr.GetBoolean(dr.GetOrdinal("RequiereFactura"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Solicitud ObtenerDetalleSolicitud(Solicitud datos)
        {
            try
            {
                SqlDataReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DetalleSolicitud_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    SolicitudResultado.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    SolicitudResultado.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    SolicitudResultado.TipoSolicitud = dr.GetString(dr.GetOrdinal("TipoSolicitud"));
                    SolicitudResultado.EstatusSolicitud = dr.GetString(dr.GetOrdinal("EstatusSolicitud"));
                    SolicitudResultado.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                    SolicitudResultado.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("FechaLlegada"));
                    SolicitudResultado.HoraLlegada = dr.GetString(dr.GetOrdinal("HoraLlegada"));
                    SolicitudResultado.FechaSalida = dr.GetDateTime(dr.GetOrdinal("FechaSalida"));
                    SolicitudResultado.HoraSalida = dr.GetString(dr.GetOrdinal("HoraSalida"));
                    SolicitudResultado.NumHabitaciones = dr.GetInt32(dr.GetOrdinal("TotalHabitaciones"));
                    SolicitudResultado.NumDias = dr.GetInt32(dr.GetOrdinal("NumDias"));
                    SolicitudResultado.NumNoches = dr.GetInt32(dr.GetOrdinal("NumNoches"));
                    SolicitudResultado.NumAdultos = dr.GetInt32(dr.GetOrdinal("NumAdultos"));
                    SolicitudResultado.NumMenores4 = dr.GetInt32(dr.GetOrdinal("NumMenores4"));
                    SolicitudResultado.NumMenores11 = dr.GetInt32(dr.GetOrdinal("NumMenores11"));
                    SolicitudResultado.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
                    SolicitudResultado.RequiereFactura = dr.GetBoolean(dr.GetOrdinal("RequiereFactura"));
                    SolicitudResultado.Cotizacion = new Cotizacion();
                    SolicitudResultado.Cotizacion.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                    SolicitudResultado.Cotizacion.Subtotal = dr.GetDecimal(dr.GetOrdinal("MontoCotizacion"));
                    SolicitudResultado.Cotizacion.Descripcion = dr.GetString(dr.GetOrdinal("NombreCotizacion"));
                    SolicitudResultado.Cliente = new Cliente();
                    SolicitudResultado.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                    SolicitudResultado.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                    SolicitudResultado.Cliente.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                }
                return SolicitudResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerDetalleSolicitudCotizacion(Solicitud datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DetalleSolicitudCotizacion", datos.IDSolicitud);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[0] != null)
                        {
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {
                                SolicitudResultado.IDSolicitud = datos.IDSolicitud;
                                SolicitudResultado.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                                SolicitudResultado.Cliente = new Cliente();
                                SolicitudResultado.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                                SolicitudResultado.Cliente.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                                SolicitudResultado.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("CorreoElectronico"));
                                SolicitudResultado.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                                SolicitudResultado.TieneBoletosAvion = dr.GetBoolean(dr.GetOrdinal("TieneBoleto"));
                                SolicitudResultado.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("FechaLlegada"));
                                SolicitudResultado.HoraLlegada = dr.GetString(dr.GetOrdinal("HoraLlegada"));
                                SolicitudResultado.FechaSalida = dr.GetDateTime(dr.GetOrdinal("FechaSalida"));
                                SolicitudResultado.HoraSalida = dr.GetString(dr.GetOrdinal("HoraSalida"));
                                SolicitudResultado.OtrosServicios = dr.GetString(dr.GetOrdinal("OtrosServicios"));
                                SolicitudResultado.NumHabitaciones = dr.GetInt32(dr.GetOrdinal("NumHabitaciones"));
                            }
                            if (!string.IsNullOrEmpty(SolicitudResultado.Folio))
                            {
                                if (ds.Tables[1] != null)
                                {
                                    SolicitudResultado.TablaHabitaciones = ds.Tables[1];
                                }
                            }
                        }
                    }
                }
                return SolicitudResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Solicitud ObtenerDetalleSolicitudCotizacionExtra(Cotizacion datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_DetalleSolicitudCotizacionCorreoPaquete", datos.IDSolicitud, datos.IDCotizacion);
                if (ds != null)
                {
                    if (ds.Tables.Count > 1)
                    {
                        if (ds.Tables[0] != null)
                        {
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {
                                SolicitudResultado.IDSolicitud = datos.IDSolicitud;
                                SolicitudResultado.IDProducto = dr.GetString(dr.GetOrdinal("IDProducto"));
                                SolicitudResultado.IDSeccion = dr.GetString(dr.GetOrdinal("IDSeccion"));
                                SolicitudResultado.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                                SolicitudResultado.NumDias = dr.GetInt32(dr.GetOrdinal("NumDias"));
                                SolicitudResultado.NumNoches = dr.GetInt32(dr.GetOrdinal("NumNoches"));
                                SolicitudResultado.CategoriaHotel = float.Parse(dr.GetValue(dr.GetOrdinal("CategoriaHotel")).ToString());
                                SolicitudResultado.NumTotalPersonas = dr.GetInt32(dr.GetOrdinal("TotalPersonas"));
                                SolicitudResultado.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("FechaLlegada"));
                                SolicitudResultado.HoraLlegada = dr.GetString(dr.GetOrdinal("HoraLlegada"));
                                SolicitudResultado.FechaSalida = dr.GetDateTime(dr.GetOrdinal("FechaSalida"));
                                SolicitudResultado.HoraSalida = dr.GetString(dr.GetOrdinal("HoraSalida"));
                                SolicitudResultado.AsuntoCorreo = dr.GetString(dr.GetOrdinal("AsuntoCorreo"));
                                SolicitudResultado.ImgProducto = dr.GetString(dr.GetOrdinal("ImagenProducto"));
                                SolicitudResultado.Cotizacion = new Cotizacion();
                                SolicitudResultado.Cotizacion.IDCotizacion = datos.IDCotizacion;
                                SolicitudResultado.Cotizacion.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                                SolicitudResultado.Cotizacion.Comentarios = dr.GetString(dr.GetOrdinal("ComentariosCot"));
                                SolicitudResultado.Cotizacion.Descripcion = dr.GetString(dr.GetOrdinal("DescripcionCot"));
                                SolicitudResultado.Cliente = new Cliente();
                                SolicitudResultado.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                                SolicitudResultado.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("CorreoElectronico"));
                                SolicitudResultado.Cliente.Password = dr.GetString(dr.GetOrdinal("Pass"));
                                SolicitudResultado.NombrePagina = dr.GetString(dr.GetOrdinal("NombrePagina"));
                            }
                            if (ds.Tables[1] != null)
                            {
                                //SolicitudResultado.TablaHabitaciones = ds.Tables[1];
                                dr = ds.Tables[1].CreateDataReader();
                                List<Habitacion> lista = new List<Habitacion>();
                                Habitacion item;
                                int i = 0;
                                while (dr.Read())
                                {
                                    item = new Habitacion();
                                    i++;
                                    item.Opcion = i;
                                    item.IDHabitacion = dr.GetString(dr.GetOrdinal("IDHabitacion"));
                                    item.NumCamas = dr.GetInt32(dr.GetOrdinal("NumCamas"));
                                    item.NumAdultos = dr.GetInt32(dr.GetOrdinal("NumAdultos"));
                                    item.NumMenores11 = dr.GetInt32(dr.GetOrdinal("NumMenores11"));
                                    item.NumMenores4 = dr.GetInt32(dr.GetOrdinal("NumMenores4"));
                                    item.CostoAdulto = dr.GetDecimal(dr.GetOrdinal("CostoAdulto"));
                                    item.CostoMenor11 = dr.GetDecimal(dr.GetOrdinal("CostoMenor11"));
                                    item.CostoMenor4 = dr.GetDecimal(dr.GetOrdinal("CostoMenor4"));
                                    item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                                    item.TipoHabitacion = dr.GetString(dr.GetOrdinal("TipoHabitacion"));
                                    lista.Add(item);
                                }
                                SolicitudResultado.ListaHabitaciones = lista;
                            }
                            if (ds.Tables[2] != null)
                            {
                                dr = ds.Tables[2].CreateDataReader();
                                List<LugarTuristico> lista = new List<LugarTuristico>();
                                LugarTuristico item;
                                int i = 0;
                                while (dr.Read())
                                {
                                    item = new LugarTuristico();
                                    i++;
                                    item.Orden = i;
                                    item.IDLugar = dr.GetString(dr.GetOrdinal("IDLugar"));
                                    item.Lugar = dr.GetString(dr.GetOrdinal("NombreLugar"));
                                    lista.Add(item);
                                }
                                SolicitudResultado.ListaItinerario = lista;
                            }
                            if (ds.Tables.Count == 4)
                            {
                                if (ds.Tables[3] != null)
                                {
                                    dr = ds.Tables[3].CreateDataReader();
                                    List<Paquete> Lista = new List<Paquete>();
                                    Paquete item;
                                    int i = 0;
                                    while (dr.Read())
                                    {
                                        item = new Paquete();
                                        i++;
                                        item.Orden = i;
                                        item.IDPaquete = dr.GetString(dr.GetOrdinal("IDPaquete"));
                                        item.NombrePaquete = dr.GetString(dr.GetOrdinal("NombrePaquete"));
                                        item.NombrePagina = dr.GetString(dr.GetOrdinal("NombrePagina"));
                                        Lista.Add(item);
                                    }
                                    SolicitudResultado.ListaPaquete = Lista;
                                }
                            }
                        }
                    }
                }
                return SolicitudResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerEsEmpresa(Solicitud datos)
        {
            try
            {
                object band = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_get_EsEmpresaXIDSolicitud", datos.IDSolicitud);
                if (band != null)
                    datos.EsEmpresa = Convert.ToBoolean(band.ToString());
                else
                    datos.EsEmpresa = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
        public Solicitud ObtenerMontoPagadoXIDSolicitud(Solicitud datos)
        {
            try
            {
                Solicitud resultado = new Solicitud();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_DatosMontoPagado_CH", datos.IDSolicitud);
                while (dr.Read())
                {
                    resultado.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    resultado.Pago = new Pago();
                    resultado.Pago.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPagado"));
                    resultado.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    resultado.MontoPenalizacion = 0;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerNotificaciones(Usuario datos)
        {
            try
            {
                Solicitud aux = new Solicitud();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_Notificaciones", datos.IDUsuario);
                while (dr.Read())
                {
                    aux.BandNot_01 = dr.GetBoolean(dr.GetOrdinal("BandNot_01"));
                    aux.BandNot_02 = dr.GetBoolean(dr.GetOrdinal("BandNot_02"));
                    aux.BandNot_03 = dr.GetBoolean(dr.GetOrdinal("BandNot_03"));
                    aux.BandNot_04 = dr.GetBoolean(dr.GetOrdinal("BandNot_04"));
                    aux.BandNot_05 = dr.GetBoolean(dr.GetOrdinal("BandNot_05"));
                    aux.BandNot_06 = dr.GetBoolean(dr.GetOrdinal("BandNot_06"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerNotificacionesDatos(Solicitud datos)
        {
            try
            {
                Solicitud aux = new Solicitud();
                DataSet ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_NotificacionesDatos", datos.Opcion, datos.IDUsuario);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0] != null)
                    {
                        aux.TablaNotificaciones = ds.Tables[0];
                    }
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[1] != null)
                        {
                            aux.TablaNotificaciones2 = ds.Tables[1];
                        }
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
       
        public Solicitud ObtenerRecursosAsignados(Solicitud datos)
        {
            try
            {
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RecursosAsignados_CH", datos.IDSolicitud);
                Solicitud aux = new Solicitud();
                while (dr.Read())
                {
                    aux.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    aux.IDChofer = dr.GetString(dr.GetOrdinal("IDChofer"));
                    aux.IDVehiculo = dr.GetString(dr.GetOrdinal("IDVehiculo"));
                    aux.IDHotel = dr.GetString(dr.GetOrdinal("IDHotel"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteDesgloceCancelacion(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptDesgloceCancelacionesXIDCaja", datos.IDUsuario);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaCancelacion"));
                    item.MotivoCancelacion = dr.GetString(dr.GetOrdinal("MotivoCancelacion"));
                    item.MontoPenalizacion = dr.GetDecimal(dr.GetOrdinal("MontoPenalizacion"));
                    item.IDUsuario = dr.GetString(dr.GetOrdinal("Usuario"));
                    item.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPagado"));
                    item.MontoDevolucion = dr.GetDecimal(dr.GetOrdinal("MontoDevolucion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteEmpleadoVentas(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptVendedores", datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.IDUsuario = dr.GetString(dr.GetOrdinal("Empleado"));
                    item.Opcion = dr.GetInt32(dr.GetOrdinal("CantidadVentas"));
                    item.MontoPagado = dr.GetDecimal(dr.GetOrdinal("TotalPagado"));
                    item.MontoInicial = dr.GetDecimal(dr.GetOrdinal("TotalVenta"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerReporteFichaSolicitud(Reporte datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_RptFichaTecnica", datos.IDSolicitud);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[0] != null)
                        {
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {
                                SolicitudResultado.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                                SolicitudResultado.IDStatusSolicitud = dr.GetInt32(dr.GetOrdinal("IDStatusSolicitud"));
                                SolicitudResultado.IDTipoSolicitud = dr.GetInt32(dr.GetOrdinal("IDTipoSolicitud"));
                                SolicitudResultado.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                                SolicitudResultado.TipoSolicitud = dr.GetString(dr.GetOrdinal("TipoSolicitud"));
                                SolicitudResultado.EstatusSolicitud = dr.GetString(dr.GetOrdinal("EstatusSolicitud"));
                                SolicitudResultado.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                                SolicitudResultado.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                                SolicitudResultado.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                                SolicitudResultado.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("FechaLlegada"));
                                SolicitudResultado.HoraLlegada = dr.GetString(dr.GetOrdinal("HoraLlegada"));
                                SolicitudResultado.FechaSalida = dr.GetDateTime(dr.GetOrdinal("FechaSalida"));
                                SolicitudResultado.HoraSalida = dr.GetString(dr.GetOrdinal("HoraSalida"));
                                SolicitudResultado.TieneBoletosAvion = dr.GetBoolean(dr.GetOrdinal("TieneBoleto"));
                                SolicitudResultado.TieneBoletosAvionTxt = dr.GetString(dr.GetOrdinal("TieneBoletoTxt"));
                                SolicitudResultado.AeropueroLlegada = dr.GetString(dr.GetOrdinal("AeropuertoLlegada"));
                                SolicitudResultado.AeropuertoSalida = dr.GetString(dr.GetOrdinal("AeropuertoSalida"));
                                SolicitudResultado.CategoriaHotel = float.Parse(dr.GetValue(dr.GetOrdinal("CategoriaHotel")).ToString());
                                SolicitudResultado.NumHabitaciones = dr.GetInt32(dr.GetOrdinal("TotalHabitaciones"));
                                SolicitudResultado.NumDias = dr.GetInt32(dr.GetOrdinal("NumDias"));
                                SolicitudResultado.NumNoches = dr.GetInt32(dr.GetOrdinal("NumNoches"));
                                SolicitudResultado.NumAdultos = dr.GetInt32(dr.GetOrdinal("NumAdultos"));
                                SolicitudResultado.NumMenores4 = dr.GetInt32(dr.GetOrdinal("NumMenores4"));
                                SolicitudResultado.NumMenores11 = dr.GetInt32(dr.GetOrdinal("NumMenores11"));
                                SolicitudResultado.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
                                SolicitudResultado.RequiereFactura = dr.GetBoolean(dr.GetOrdinal("RequiereFactura"));
                                SolicitudResultado.RequiereFacturaTxt = dr.GetString(dr.GetOrdinal("RequiereFacturaTxt"));
                                SolicitudResultado.MontoInicial = dr.GetDecimal(dr.GetOrdinal("MontoInicial"));
                                SolicitudResultado.MotivoMontoInicial = dr.GetString(dr.GetOrdinal("MotivoMontoInicial"));
                                SolicitudResultado.MotivoCancelacion = dr.GetString(dr.GetOrdinal("MotivoCancelacion"));
                                SolicitudResultado.MontoPenalizacion = dr.GetDecimal(dr.GetOrdinal("MontoPenalizacion"));
                                SolicitudResultado.IDChofer = dr.GetString(dr.GetOrdinal("RecursoChofer"));
                                SolicitudResultado.IDHotel = dr.GetString(dr.GetOrdinal("RecursoHotel"));
                                SolicitudResultado.IDVehiculo = dr.GetString(dr.GetOrdinal("RecursoVehiculo"));
                                SolicitudResultado.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPagado"));
                                SolicitudResultado.MontoPendiente = dr.GetDecimal(dr.GetOrdinal("Pendiente"));
                                SolicitudResultado.Cotizacion = new Cotizacion();
                                SolicitudResultado.Cotizacion.IDCotizacion = dr.GetString(dr.GetOrdinal("IDCotizacion"));
                                SolicitudResultado.Cotizacion.Subtotal = dr.GetDecimal(dr.GetOrdinal("MontoCotizacion"));
                                SolicitudResultado.Cotizacion.Descripcion = dr.GetString(dr.GetOrdinal("NombreCotizacion"));
                                SolicitudResultado.Cliente = new Cliente();
                                SolicitudResultado.Cliente.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                                SolicitudResultado.Cliente.CorreoElectronico = dr.GetString(dr.GetOrdinal("Correo"));
                                SolicitudResultado.Cliente.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                            }
                        }
                        if (ds.Tables[1] != null)
                        {
                            dr = ds.Tables[1].CreateDataReader();
                            List<Habitacion> lista = new List<Habitacion>();
                            Habitacion item;
                            int i = 0;
                            while (dr.Read())
                            {
                                item = new Habitacion();
                                i++;
                                item.Opcion = i;
                                item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                                item.IDHabitacion = dr.GetString(dr.GetOrdinal("IDHabitacion"));
                                item.NumCamas = dr.GetInt32(dr.GetOrdinal("NumCamas"));
                                item.NumAdultos = dr.GetInt32(dr.GetOrdinal("NumAdultos"));
                                item.NumMenores11 = dr.GetInt32(dr.GetOrdinal("NumMenores11"));
                                item.NumMenores4 = dr.GetInt32(dr.GetOrdinal("NumMenores4"));
                                item.CostoAdulto = dr.GetDecimal(dr.GetOrdinal("CostoAdulto"));
                                item.CostoMenor11 = dr.GetDecimal(dr.GetOrdinal("CostoMenor11"));
                                item.CostoMenor4 = dr.GetDecimal(dr.GetOrdinal("CostoMenor4"));
                                item.Subtotal = dr.GetDecimal(dr.GetOrdinal("Subtotal"));
                                item.TipoHabitacion = dr.GetString(dr.GetOrdinal("TipoHabitacion"));
                                lista.Add(item);
                            }
                            SolicitudResultado.ListaHabitaciones = lista;
                        }
                    }
                }
                return SolicitudResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Solicitud ObtenerReporteItinerario(Reporte datos)
        {
            try
            {
                DataSet ds;
                DataTableReader dr;
                Solicitud SolicitudResultado = new Solicitud();
                ds = SqlHelper.ExecuteDataset(datos.Conexion, "spCSLDB_get_RptItinerario", datos.IDSolicitud, datos.Band);
                if (ds != null)
                {
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[1] != null)
                        {
                            dr = ds.Tables[1].CreateDataReader();
                            while (dr.Read())
                            {
                                SolicitudResultado.TxtTitulo = dr.GetString(dr.GetOrdinal("TxtTitulo")).ToUpper();
                                SolicitudResultado.TxtObservaciones = dr.GetString(dr.GetOrdinal("TxtObservaciones")).ToUpper();
                                SolicitudResultado.TxtRecomendaciones = dr.GetString(dr.GetOrdinal("TxtRecomendaciones")).ToUpper();
                            }
                        }
                        if(ds.Tables[0] != null)
                        {
                            List<LugarTuristico> lista = new List<LugarTuristico>();
                            LugarTuristico item;
                            int i = 0;
                            dr = ds.Tables[0].CreateDataReader();
                            while (dr.Read())
                            {
                                i++;
                                item = new LugarTuristico();
                                item.Opcion = i;
                                item.Lugar = dr.GetString(dr.GetOrdinal("Lugar"));
                                item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                                item.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
                                item.Recomendaciones = dr.GetString(dr.GetOrdinal("Recomendaciones"));
                                lista.Add(item);
                            }
                            SolicitudResultado.DetalleItinerario = lista;
                        }
                    }
                }
                return SolicitudResultado;
            }            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReportePaquetesToursMasVendidos(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptPaquetesToursMasVendidos", datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                    item.Opcion = dr.GetInt32(dr.GetOrdinal("Total"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteRecursosXFechas(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptRecursosXFechas", datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.FechaLlegada = dr.GetDateTime(dr.GetOrdinal("fechaLlegada"));
                    item.FechaSalida = dr.GetDateTime(dr.GetOrdinal("fechaSalida"));
                    item.IDChofer = dr.GetString(dr.GetOrdinal("RecursoCofer")).ToUpper();
                    item.IDHotel = dr.GetString(dr.GetOrdinal("RecursoHotel")).ToUpper();
                    item.IDVehiculo = dr.GetString(dr.GetOrdinal("RecursoVehiculo")).ToUpper();
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                    item.EstatusSolicitud = dr.GetString(dr.GetOrdinal("Estatus"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteSolicitudesCanceladas(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                int aux = 0;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptSolicitudesCanceladas", datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    aux++;
                    item.Opcion = aux;
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                    item.MotivoCancelacion = dr.GetString(dr.GetOrdinal("MotivoCancelacion"));
                    item.MontoPenalizacion = dr.GetDecimal(dr.GetOrdinal("MontoPenalizacion"));
                    item.EstatusSolicitud = dr.GetString(dr.GetOrdinal("TipoCancelacion"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaCancelacion"));
                    item.NombreClienteAgencia = dr.GetString(dr.GetOrdinal("Cliente"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteSolicitudesEnTramite(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                int aux = 0;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptSolicitudesTramite", datos.IDUsuario, datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    aux++;
                    item.Opcion = aux;
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.EstatusSolicitud = dr.GetString(dr.GetOrdinal("EstatusSolicitud"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                    item.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                    item.NombreClienteAgencia = dr.GetString(dr.GetOrdinal("Cliente"));
                    item.IDUsuarioRecibido = dr.GetString(dr.GetOrdinal("Usuario"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteSolicitudesRecibidas(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                int aux = 0;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptSolicitudesRecibidas", datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    aux++;
                    item.Opcion = aux;
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.EstatusSolicitud = dr.GetString(dr.GetOrdinal("EstatusSolicitud"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                    item.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                    item.NombreClienteAgencia = dr.GetString(dr.GetOrdinal("Cliente"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteSolicitudesXEmpresas(Reporte datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                int aux = 0;
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_RptSolicitudesXEmpresa", datos.IDUsuario, datos.FechaInicio, datos.FechaFin);
                while (dr.Read())
                {
                    item = new Solicitud();
                    aux++;
                    item.Opcion = aux;
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.EstatusSolicitud = dr.GetString(dr.GetOrdinal("EstatusSolicitud"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                    item.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("Producto"));
                    item.NombreClienteAgencia = dr.GetString(dr.GetOrdinal("Cliente"));
                    item.IDUsuarioRecibido = dr.GetString(dr.GetOrdinal("Usuario"));
                    item.MontoPagado = dr.GetDecimal(dr.GetOrdinal("MontoPagado"));
                    item.MontoDevolucion = dr.GetDecimal(dr.GetOrdinal("MontoPendiente"));
                    item.MontoInicial = dr.GetDecimal(dr.GetOrdinal("MontoTotal"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerSolicitudes(Solicitud datos)
        {
            try
            {
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_SolicitudesXIDTipoSolicitud", datos.Opcion, datos.IDUsuarioRecibido);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.IDStatusSolicitud = dr.GetInt32(dr.GetOrdinal("IDStatusSolicitud"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                    item.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                    item.IDTipoSolicitud = dr.GetInt32(dr.GetOrdinal("IDTipoSolicitud"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerSolicitudesXBusqueda(Busqueda datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDTipoBusqueda, datos.IDUsuarioRecibido,
                                        datos.FolioSolicitud,
                                        datos.Nombre,
                                        datos.ApellidoPaterno,
                                        datos.ApellidoMaterno,
                                        datos.FechaSolicitudInicio,
                                        datos.FechaSolicitudFin,
                                        datos.IDEmpresa, 
                                        datos.FechaLlegadaInicio,
                                        datos.FechaLlegadaFin,
                                        datos.FechanotasInicio,
                                        datos.FechaNotasFin};
                List<Solicitud> lista = new List<Solicitud>();
                Solicitud item;
                SqlDataReader dr;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_SolicitudesXBusqueda", parametros);
                while (dr.Read())
                {
                    item = new Solicitud();
                    item.IDSolicitud = dr.GetString(dr.GetOrdinal("IDSolicitud"));
                    item.IDStatusSolicitud = dr.GetInt32(dr.GetOrdinal("IDStatusSolicitud"));
                    item.FechaSolicitud = dr.GetDateTime(dr.GetOrdinal("FechaSolicitud"));
                    item.HoraSolicitud = dr.GetString(dr.GetOrdinal("HoraSolicitud"));
                    item.IDTipoSolicitud = dr.GetInt32(dr.GetOrdinal("IDTipoSolicitud"));
                    item.NombreProducto = dr.GetString(dr.GetOrdinal("NombreProducto"));
                    item.Folio = dr.GetString(dr.GetOrdinal("Folio"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SolicitudEnEspera(Solicitud datos)
        {
            try
            {
                object[] parametros = { datos.IDSolicitud, datos.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_SolicitudEnEspera", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}


