using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Pais_Negocio
    {
        public List<Pais> LlenarComboPaises(Pais datos)
        {
            try
            {
                Pais_Datos pd = new Pais_Datos();
                return pd.LlenarComboPaises(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
