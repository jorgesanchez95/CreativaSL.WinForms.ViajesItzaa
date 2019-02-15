using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.ViajesItzaa.Datos
{
    public class OrdenPago_Datos
    {
        public void InsertarNuevaOrdenPago(OrdenPago datos)
        {
            try
            {
                object [] parametros = {datos.IDSolicitud, datos.NombrePago, datos.DescripcionPago, datos.Pago, datos.IDUsuario};
                object dr = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_set_InsertarOrdenPago", parametros);
                if (dr != null)
                {
                    datos.IDOrdenPago = dr.ToString();
                    if (string.IsNullOrEmpty(datos.IDOrdenPago))
                        datos.Validador = false;
                    else
                        datos.Validador = true;
                }
                else
                {
                    datos.Validador = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
