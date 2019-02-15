using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Cotizacion_Negocio
    {
        public void AbcCotizaciones(Cotizacion datos)
        {
            try
            {
                Cotizacion_Datos cd = new Cotizacion_Datos();
                cd.AbcCotizaciones(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                cd.ActualizarEstatusCotizacion(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                cd.EnviarCotizacion(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                return cd.ObtenerCotizacionesAEnviar(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                return cd.ObtenerDetalleSolicitudCotizacion(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                return cd.ObtenerGridCotizaciones(datos);
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
                Cotizacion_Datos cd = new Cotizacion_Datos();
                return cd.ObtenerGridCotizaciones(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
