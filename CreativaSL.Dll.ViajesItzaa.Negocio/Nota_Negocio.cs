using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Nota_Negocio
    {
        public void ABCNotas(Nota datos)
        {
            try
            {
                Nota_Datos nd = new Nota_Datos();
                nd.ABCNotas(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Nota> ObtenerNotasXIDSolicitud(Nota datos)
        {
            try
            {
                Nota_Datos nd = new Nota_Datos();
                return nd.ObtenerNotasXIDSolicitud(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
