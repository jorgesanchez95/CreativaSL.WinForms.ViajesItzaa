using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Paquete_Negocio
    {
        public List<Paquete> ObtenerComboPaquete(Paquete datos)
        {
            try
            {
                Paquete_Datos pd = new Paquete_Datos();
                return pd.ObtenerComboPaquete(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
