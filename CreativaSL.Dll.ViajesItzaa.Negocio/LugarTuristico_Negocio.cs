using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;
namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class LugarTuristico_Negocio
    {
        public List<LugarTuristico> LlenarComboLugaresTuristicos(LugarTuristico datos)
        {
            try
            {
                LugarTuristico_Datos ltd = new LugarTuristico_Datos();
                return ltd.LlenarComboLugaresTuristicos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
