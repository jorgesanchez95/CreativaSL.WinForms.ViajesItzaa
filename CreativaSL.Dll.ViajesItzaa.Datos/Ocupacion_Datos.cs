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
    public class Ocupacion_Datos
    {
        public List<Ocupacion> LlenarComboOcupaciones(Ocupacion datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Ocupacion> lista = new List<Ocupacion>();
                Ocupacion ocupacion;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatOcupaciones_CH", datos.Opcion);
                while (dr.Read())
                {
                    ocupacion = new Ocupacion();
                    ocupacion.IDOcupacion = dr.GetInt32(dr.GetOrdinal("id_ocupacion"));
                    ocupacion.NombreOcupacion = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(ocupacion);
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
