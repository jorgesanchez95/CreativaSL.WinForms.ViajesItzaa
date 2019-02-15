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
    public class Pais_Datos
    {
        public List<Pais> LlenarComboPaises(Pais datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Pais> lista = new List<Pais>();
                Pais pais;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatPaises_CH", datos.Opcion);
                while (dr.Read())
                {
                    pais = new Pais();
                    pais.IDPais = dr.GetInt32(dr.GetOrdinal("id_pais"));
                    pais.NombrePais = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(pais);
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
