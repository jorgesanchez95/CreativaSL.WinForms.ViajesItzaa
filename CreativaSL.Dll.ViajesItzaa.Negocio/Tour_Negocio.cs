using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Tour_Negocio
    {
        public List<Tour> ObtenerComboTour(Tour datos)
        {
            try
            {
                Tour_Datos td = new Tour_Datos();
                return td.ObtenerComboTour(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
