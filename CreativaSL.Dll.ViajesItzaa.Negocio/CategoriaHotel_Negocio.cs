using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class CategoriaHotel_Negocio
    {
        public List<CategoriaHotel> ObtenerCategoriasHotel(CategoriaHotel datos)
        {
            try
            {
                CategoriaHotel_Datos chd = new CategoriaHotel_Datos();
                return chd.ObtenerCategoriasHotel(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
