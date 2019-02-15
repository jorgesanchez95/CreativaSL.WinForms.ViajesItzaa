using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Caja_Negocio
    {
        public void AgregarDeposito(DepositoRetiro deposito)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                cd.AgregarDeposito(deposito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarRetiro(DepositoRetiro retiro)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                cd.AgregarRetiro(retiro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AsignarCajaMAC(Caja datos)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.AsignarCajaMAC(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GuardarAperturaCaja(Caja caja)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.GuardarAperturaCaja(caja);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GuardarMontoTotalEnCaja(Caja caja)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.GuardarMontoTotalEnCaja(caja);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Caja> LlenarComboCajaXSucursalXFecha(Caja datos)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.LlenarComboCajaXSucursalXFecha(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Caja> LlenarComboCatCajas(Caja datos)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.LlenarComboCatCajas(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Caja ObtenerResumenCaja(Reporte datos)
        {
            try
            {
                Caja_Datos cd = new Caja_Datos();
                return cd.ObtenerResumenCaja(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
