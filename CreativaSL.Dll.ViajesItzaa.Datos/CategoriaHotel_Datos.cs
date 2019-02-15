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
    public class CategoriaHotel_Datos
    {
        public List<CategoriaHotel> ObtenerCategoriasHotel(CategoriaHotel datos)
        {
            try
            {
                SqlDataReader dr;
                List<CategoriaHotel> lista = new List<CategoriaHotel>();
                CategoriaHotel item;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCategoriaHotel_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new CategoriaHotel();
                    item.IDCategoria = (float)dr.GetDecimal(dr.GetOrdinal("IDCategoria"));
                    item.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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
