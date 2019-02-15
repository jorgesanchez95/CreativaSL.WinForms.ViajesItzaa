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
    public class Hotel_Datos
    {
        public List<Hotel> ObtenerComboHotel(Hotel datos)
        {
            try
            {
                SqlDataReader dr;
                Hotel item;
                List<Hotel> lista = new List<Hotel>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboHoteles_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new Hotel();
                    item.IDHotel = dr.GetString(dr.GetOrdinal("IDHotel"));
                    item.NombreHotel = dr.GetString(dr.GetOrdinal("Descripcion"));
                    item.CategoriaHotel = float.Parse(dr.GetValue(dr.GetOrdinal("Categoria")).ToString());
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Hotel> ObtenerComboRecursoHotel(Solicitud datos)
        {
            try
            {
                SqlDataReader dr;
                Hotel item;
                List<Hotel> lista = new List<Hotel>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboRecursosHotel_CH", datos.IDSolicitud, datos.IDHotel);
                while (dr.Read())
                {
                    item = new Hotel();
                    item.IDHotel = dr.GetString(dr.GetOrdinal("IDHotel"));
                    item.NombreHotel = dr.GetString(dr.GetOrdinal("Descripcion"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Hotel> ObtenerComboRecursoHotel(Hotel datos)
        {
            try
            {
                SqlDataReader dr;
                Hotel item;
                List<Hotel> lista = new List<Hotel>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboRecursosHotel2_CH");
                while (dr.Read())
                {
                    item = new Hotel();
                    item.IDHotel = dr.GetString(dr.GetOrdinal("IDHotel"));
                    item.NombreHotel = dr.GetString(dr.GetOrdinal("Descripcion"));
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
