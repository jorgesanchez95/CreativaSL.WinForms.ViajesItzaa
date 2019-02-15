using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Ocupacion_Negocio
    {
        public List<Ocupacion> LlenarComboOcupaciones(Ocupacion datos)
        {
            try
            {
                Ocupacion_Datos od = new Ocupacion_Datos();
                return od.LlenarComboOcupaciones(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
