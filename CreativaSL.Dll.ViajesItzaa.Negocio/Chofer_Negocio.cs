using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Chofer_Negocio
    {
        public List<Chofer> ObtenerComboRecursoChofer(Solicitud datos)
        {
            try
            {
                Chofer_Datos cd = new Chofer_Datos();
                return cd.ObtenerComboRecursoChofer(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
