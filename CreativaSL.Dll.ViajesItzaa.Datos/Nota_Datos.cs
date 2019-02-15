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
    public class Nota_Datos
    {
        public void ABCNotas(Nota datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDNota, datos.IDSolicitud, datos.Notificar, datos.FechaNotificacion, datos.TextoNota, datos.IDUsuario };
                object IDNota = SqlHelper.ExecuteScalar(datos.Conexion, "spCSLDB_abc_Notas_CH", parametros);
                datos.Validador = false;
                if (IDNota != null)
                {
                    if (!string.IsNullOrEmpty(IDNota.ToString()))
                    {
                        datos.Validador = true;
                        datos.IDNota = IDNota.ToString();
                    }
                }
                datos.Validador = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Nota> ObtenerNotasXIDSolicitud(Nota datos)
        {
            try
            {
                Nota item;
                SqlDataReader dr;
                List<Nota> lista = new List<Nota>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_Notas", datos.Opcion, datos.IDSolicitud, datos.FechaNota);
                while (dr.Read())
                {
                    item = new Nota();
                    item.IDNota = dr.GetString(dr.GetOrdinal("IDNota"));
                    item.Notificar = dr.GetBoolean(dr.GetOrdinal("Notificar"));
                    item.NotificarText = dr.GetString(dr.GetOrdinal("NotificarText"));
                    item.FechaNotificacion = dr.GetDateTime(dr.GetOrdinal("FechaNotificacion"));
                    item.TextoNota = dr.GetString(dr.GetOrdinal("TextoNota"));
                    item.IDSolicitud = datos.IDSolicitud;
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
