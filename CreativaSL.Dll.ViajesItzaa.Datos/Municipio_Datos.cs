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
    public class Municipio_Datos
    {
        public List<Municipio> LlenarComboMunicipios(Municipio datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Municipio> lista = new List<Municipio>();
                Municipio municipio;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatMunicipios_CH", datos.Opcion, datos.IDPais, datos.IDEstado);
                while (dr.Read())
                {
                    municipio = new Municipio();
                    municipio.IDPais = datos.IDPais;
                    municipio.IDEstado = datos.IDEstado;
                    municipio.IDMunicipio = dr.GetInt32(dr.GetOrdinal("id_municipio"));
                    municipio.NombreMunicipio = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(municipio);
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
