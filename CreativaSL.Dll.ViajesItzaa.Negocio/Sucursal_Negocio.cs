using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Sucursal_Negocio
    {
        public List<Sucursal> LlenarComboSucursales(Sucursal datos)
        {
            try
            {
                Sucursal_Datos sd = new Sucursal_Datos();
                return sd.LlenarComboSucursales(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
