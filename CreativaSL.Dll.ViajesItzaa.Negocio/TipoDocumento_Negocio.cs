using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class TipoDocumento_Negocio
    {
        public List<TipoDocumento> LlenarComboDocumentos(TipoDocumento datos)
        {
            try
            {
                TipoDocumento_Datos td = new TipoDocumento_Datos();
                return td.LlenarComboDocumentos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
