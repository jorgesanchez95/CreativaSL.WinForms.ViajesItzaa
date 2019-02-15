using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Pago_Negocio
    {
        public void InsertarPago(Pago datos)
        {
            try
            {
                Pago_Datos pd = new Pago_Datos();
                pd.InsertarPago(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pago ObtenerDatosPagoAbono(Solicitud Datos)
        {
            try
            {
                Pago_Datos pd = new Pago_Datos();
                return pd.ObtenerDatosPagoAbono(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pago ObtenerDatosPagoInicial(Solicitud Datos)
        {
            try
            {
                Pago_Datos pd = new Pago_Datos();
                return pd.ObtenerDatosPagoInicial(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FormaPago> ObtenerReporteFormasPagoXIDCaja(Reporte Datos)
        {
            try
            {
                Pago_Datos pd = new Pago_Datos();
                return pd.ObtenerReporteFormasPagoXIDCaja(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pago> ObtenerReportePagosXIDCaja(Reporte Datos)
        {
            try
            {
                Pago_Datos pd = new Pago_Datos();
                return pd.ObtenerReportePagosXIDCaja(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
