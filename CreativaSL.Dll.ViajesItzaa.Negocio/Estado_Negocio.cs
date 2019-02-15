using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Estado_Negocio
    {
        public List<Estado> LlenarComboEstados(Estado datos)
        {
            try
            {
                Estado_Datos ed = new Estado_Datos();
                return ed.LlenarComboEstados(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
