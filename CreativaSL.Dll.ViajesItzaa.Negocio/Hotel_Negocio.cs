using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Hotel_Negocio
    {
        public List<Hotel> ObtenerComboHotel(Hotel datos)
        {
            try
            {
                Hotel_Datos hd = new Hotel_Datos();
                return hd.ObtenerComboHotel(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Hotel> ObtenerComboRecursoHotel(Solicitud datos)
        {
            try
            {
                Hotel_Datos hd = new Hotel_Datos();
                return hd.ObtenerComboRecursoHotel(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Hotel> ObtenerComboRecursoHotel(Hotel datos)
        {
            try
            {
                Hotel_Datos hd = new Hotel_Datos();
                return hd.ObtenerComboRecursoHotel(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
