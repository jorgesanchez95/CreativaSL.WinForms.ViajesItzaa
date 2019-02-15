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
    public class Estado_Datos
    {
        public List<Estado> LlenarComboEstados(Estado datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Estado> lista = new List<Estado>();
                Estado estado;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatEstados_CH", datos.Opcion, datos.IDPais);
                while (dr.Read())
                {
                    estado = new Estado();
                    estado.IDPais = datos.IDPais;
                    estado.IDEstado = dr.GetInt32(dr.GetOrdinal("id_estado"));
                    estado.NombreEstado = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(estado);
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
