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
    public class Tour_Datos
    {
        public List<Tour> ObtenerComboTour(Tour datos)
        {
            try
            {
                SqlDataReader dr;
                Tour item;
                List<Tour> lista = new List<Tour>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboTours_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new Tour();
                    item.IDTour = dr.GetString(dr.GetOrdinal("IDTour"));
                    item.NombreTour = dr.GetString(dr.GetOrdinal("Descripcion"));
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
