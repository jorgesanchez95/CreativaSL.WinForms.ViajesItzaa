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
    public class Paquete_Datos
    {
        public List<Paquete> ObtenerComboPaquete(Paquete datos)
        {
            try
            {
                SqlDataReader dr;
                Paquete item;
                List<Paquete> lista = new List<Paquete>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboPaquetes_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new Paquete();
                    item.IDPaquete = dr.GetString(dr.GetOrdinal("IDPaquete"));
                    item.NombrePaquete = dr.GetString(dr.GetOrdinal("Descripcion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
