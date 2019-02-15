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
    public class Sucursal_Datos
    {
        public List<Sucursal> LlenarComboSucursales(Sucursal datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Sucursal> lista = new List<Sucursal>();
                Sucursal sucursal;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatSucursales", datos.Opcion);
                while (dr.Read())
                {
                    sucursal = new Sucursal();
                    sucursal.IDSucursal = dr.GetString(dr.GetOrdinal("id_sucursal"));
                    sucursal.NombreSucursal = dr.GetString(dr.GetOrdinal("Nombre_Sucursal"));
                    lista.Add(sucursal);
                }
                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
