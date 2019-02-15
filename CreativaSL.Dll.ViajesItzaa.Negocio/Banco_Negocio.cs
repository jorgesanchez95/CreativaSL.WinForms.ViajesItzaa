using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Banco_Negocio
    {
        public List<Banco> LlenarComboBancos(Banco datos)
        {
            try
            {
                Banco_Datos bd = new Banco_Datos();
                return bd.LlenarComboBancos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
