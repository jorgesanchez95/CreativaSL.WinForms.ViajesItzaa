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
    public class LugarTuristico_Datos
    {
        public List<LugarTuristico> LlenarComboLugaresTuristicos(LugarTuristico datos)
        {
            try
            {
                SqlDataReader dr;
                LugarTuristico item;
                List<LugarTuristico> lista = new List<LugarTuristico>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_LugaresTuristicos_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new LugarTuristico();
                    item.IDLugar = dr.GetString(dr.GetOrdinal("IDLugar"));
                    item.Lugar = dr.GetString(dr.GetOrdinal("Descripcion"));
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
