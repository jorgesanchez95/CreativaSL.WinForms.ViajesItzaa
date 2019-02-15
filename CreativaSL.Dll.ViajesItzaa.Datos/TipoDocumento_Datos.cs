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
    public class TipoDocumento_Datos
    {
        public List<TipoDocumento> LlenarComboDocumentos(TipoDocumento datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<TipoDocumento> lista = new List<TipoDocumento>();
                TipoDocumento docto;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboTipoDocumento_CH");
                while (dr.Read())
                {
                    docto = new TipoDocumento();
                    docto.IDTipoDocumento = dr.GetInt32(dr.GetOrdinal("IDTipoDocumento"));
                    docto.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    lista.Add(docto);
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
