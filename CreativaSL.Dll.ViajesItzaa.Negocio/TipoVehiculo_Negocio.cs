using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class TipoVehiculo_Negocio
    {
        public List<TipoVehiculo> ObtenerComboRecursoVehiculo(Solicitud datos)
        {
            try
            {
                TipoVehiculo_Datos tvd = new TipoVehiculo_Datos();
                return tvd.ObtenerComboRecursoVehiculo(datos);
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
                TipoVehiculo_Datos tvd = new TipoVehiculo_Datos();
                return tvd.ObtenerComboTipoVehiculo(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
