using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Municipio_Negocio
    {
        public List<Municipio> LlenarComboMunicipios(Municipio datos)
        {
            try
            {
                Municipio_Datos md = new Municipio_Datos();
                return md.LlenarComboMunicipios(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
