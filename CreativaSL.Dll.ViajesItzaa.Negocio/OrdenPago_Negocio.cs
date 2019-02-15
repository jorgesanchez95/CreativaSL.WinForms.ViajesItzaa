using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class OrdenPago_Negocio
    {
        public void InsertarNuevaOrdenPago(OrdenPago datos)
        {
            try
            {
                OrdenPago_Datos opd = new OrdenPago_Datos();
                opd.InsertarNuevaOrdenPago(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
