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
    public class Banco_Datos
    {
        public List<Banco> LlenarComboBancos(Banco datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Banco> bancos = new List<Banco>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboBancos_CH");
                while (dr.Read())
                {
                    
                    Banco banco = new Banco();
                    banco.IDBanco = dr.GetInt32(dr.GetOrdinal("IDBanco"));
                    if (Convert.IsDBNull(dr.GetValue(dr.GetOrdinal("Descripcion"))))
                    {
                        banco.NombreBanco = string.Empty;
                    }
                    else
                    {
                        banco.NombreBanco = dr.GetString(dr.GetOrdinal("Descripcion"));
                    }
                    bancos.Add(banco);
                }
                return bancos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
