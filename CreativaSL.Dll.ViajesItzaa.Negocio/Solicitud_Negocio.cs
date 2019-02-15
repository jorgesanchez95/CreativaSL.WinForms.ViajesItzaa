using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Solicitud_Negocio
    {

        public void AceptarSolicitud(Solicitud datos)
        {
            try
            {
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.AceptarSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosFechasLimPago(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosFechasPago(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosHabitaciones(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosItinerario(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosProducto(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarDatosViaje(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ActualizarRecursos(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.CambiarUsuarioSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.CancelarSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.InsertarSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.NuevaSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerCotizacionesXIDSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosCorreoConfirmaCompra(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosCorreoConfirmaPago(pago);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosCorreoCancelacion(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosCorreoOrdenPago(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosModificarDatosHotel(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosModificarFechasViaje(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosModificarItinerario(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosModificarProducto(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerNotificaciones(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerNotificacionesDatos(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDatosSolicitudFechasPago(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDetalleSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDetalleSolicitudCotizacion(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerDetalleSolicitudCotizacionExtra(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.ObtenerEsEmpresa(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerMontoPagadoXIDSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerRecursosAsignados(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteDesgloceCancelacion(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Solicitud> ObtenerReporteEmpleadoVentas(Reporte datos)
        {
            try
            {
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteEmpleadoVentas(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteFichaSolicitud(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteItinerario(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReportePaquetesToursMasVendidos(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteRecursosXFechas(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteSolicitudesCanceladas(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteSolicitudesEnTramite(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteSolicitudesRecibidas(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerReporteSolicitudesXEmpresas(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerSolicitudes(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                return sd.ObtenerSolicitudesXBusqueda(datos);
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
                Solicitud_Datos sd = new Solicitud_Datos();
                sd.SolicitudEnEspera(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
