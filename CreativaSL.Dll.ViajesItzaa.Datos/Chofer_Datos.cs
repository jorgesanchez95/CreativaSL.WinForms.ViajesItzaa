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
    public class Chofer_Datos
    {
        public List<Chofer> ObtenerComboRecursoChofer(Solicitud datos)
        {
            try
            {
                SqlDataReader dr;
                Chofer item;
                List<Chofer> lista = new List<Chofer>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboRecursosChofer_CH", datos.IDSolicitud, datos.IDChofer);
                while (dr.Read())
                {
                    item = new Chofer();
                    item.IDChofer = dr.GetString(dr.GetOrdinal("IDChofer"));
                    item.NombreChofer = dr.GetString(dr.GetOrdinal("NombreChofer"));
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
