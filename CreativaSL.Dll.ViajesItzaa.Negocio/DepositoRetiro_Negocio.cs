using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class DepositoRetiro_Negocio
    {
        public List<DepositoRetiro> ObtenerDepositosRetirosXIDCaja(Reporte datos)
        {
            try
            {
                DepositoRetiro_Datos drd = new DepositoRetiro_Datos();
                return drd.ObtenerDepositosRetirosXIDCaja(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
