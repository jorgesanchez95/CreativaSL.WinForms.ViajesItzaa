using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;
namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Cliente_Negocio
    {
        public void ActualizarEmpresaCliente(Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                cd.ActualizarEmpresaCliente(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarPasswordCliente(Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                cd.ActualizarPasswordCliente(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CatClientesABC(Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                cd.CatClientesABC(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> ObtenerCatClientes(Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                return cd.ObtenerCatClientes(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Cliente ObtenerDatosEmpresaCliente(Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                return cd.ObtenerDatosEmpresaCliente(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
