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
    public class Empresa_Datos
    {
        public void CatEmpresasABC(Empresa datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDEmpresa, datos.NombreComercial, datos.Contacto, 
                                        datos.Telefono, datos.Correo, datos.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_abc_CatEmpresas_CH", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> LlenarComboEmpresas(Empresa datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Empresa> lista = new List<Empresa>();
                Empresa item;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatAgencias_CH", datos.Opcion);
                while (dr.Read())
                {
                    item = new Empresa();
                    item.IDEmpresa = dr.GetString(dr.GetOrdinal("IDEmpresa"));
                    item.NombreComercial = dr.GetString(dr.GetOrdinal("NombreComercial"));
                    lista.Add(item);
                }
                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> LlenarComboEmpresasExcluyente(Empresa datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Empresa> lista = new List<Empresa>();
                Empresa item;
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_ComboCatAgencias_CH", datos.Opcion, datos.IDEmpresa);
                while (dr.Read())
                {
                    item = new Empresa();
                    item.IDEmpresa = dr.GetString(dr.GetOrdinal("IDEmpresa"));
                    item.NombreComercial = dr.GetString(dr.GetOrdinal("NombreComercial"));
                    lista.Add(item);
                }
                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> ObtenerCatEmpresas(Empresa datos)
        {
            try
            {
                SqlDataReader dr;
                Empresa item;
                List<Empresa> lista = new List<Empresa>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_CatEmpresas", datos.NombreComercial);
                while (dr.Read())
                {
                    item = new Empresa();
                    item.IDEmpresa = dr.GetString(dr.GetOrdinal("IDEmpresa"));
                    item.Correo = dr.GetString(dr.GetOrdinal("Correo"));
                    item.NombreComercial = dr.GetString(dr.GetOrdinal("NombreComercial")).ToUpper();
                    item.Contacto = dr.GetString(dr.GetOrdinal("Contacto")).ToUpper();
                    item.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
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
