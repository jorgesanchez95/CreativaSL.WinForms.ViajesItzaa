using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Empresa_Negocio
    {
        public void CatEmpresasABC(Empresa datos)
        {
            try
            {
                Empresa_Datos ed = new Empresa_Datos();
                ed.CatEmpresasABC(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> LlenarComboEmpresas(Empresa datos)
        {
            try
            {
                Empresa_Datos ed = new Empresa_Datos();
                return ed.LlenarComboEmpresas(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> ObtenerCatEmpresas(Empresa datos)
        {
            try
            {
                Empresa_Datos ed = new Empresa_Datos();
                return ed.ObtenerCatEmpresas(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
