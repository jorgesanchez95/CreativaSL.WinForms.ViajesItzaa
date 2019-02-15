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
    public class Cliente_Datos
    {
        public void ActualizarEmpresaCliente(Cliente datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_ActualizarEmpresaCliente", datos.IDCliente, datos.IDEmpresa, datos.IDUsuario) > 0)
                {
                    datos.Validador = true;
                }
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarPasswordCliente(Cliente datos)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_set_ActualizarPasswordCliente", datos.IDCliente, datos.Password, datos.IDUsuario) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CatClientesABC(Cliente datos)
        {
            try
            {
                object[] parametros = { datos.Opcion, datos.IDCliente, datos.IDTipoCliente, datos.Nombre, 
                                        datos.ApellidoPaterno, datos.ApellidoMaterno, datos.Curp, 
                                        datos.FechaNacimiento, datos.Telefono, datos.IDGenero, 
                                        datos.CorreoElectronico, datos.Password, datos.IDOcupacion, datos.IDPais,
                                        datos.IDEstado, datos.IDMunicipio, datos.Colonia, datos.IDUsuario};
                if (SqlHelper.ExecuteNonQuery(datos.Conexion, "spCSLDB_abc_CatClientes_CH", parametros) > 0)
                    datos.Validador = true;
                else
                    datos.Validador = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> ObtenerCatClientes(Cliente datos)
        {
            try
            {
                SqlDataReader dr;
                Cliente item;
                List<Cliente> lista = new List<Cliente>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_CatClientes", datos.Nombre);
                while (dr.Read())
                {
                    item = new Cliente();
                    item.IDCliente = dr.GetString(dr.GetOrdinal("id_cliente"));
                    item.CorreoElectronico = dr.GetString(dr.GetOrdinal("correoelectronico"));
                    item.Nombre = dr.GetString(dr.GetOrdinal("nombre")).ToUpper();
                    item.ApellidoPaterno = dr.GetString(dr.GetOrdinal("apePat")).ToUpper();
                    item.ApellidoMaterno = dr.GetString(dr.GetOrdinal("apeMat")).ToUpper();
                    item.IDPais = dr.GetInt32(dr.GetOrdinal("id_pais"));
                    item.IDEstado = dr.GetInt32(dr.GetOrdinal("id_estado"));
                    item.IDMunicipio = dr.GetInt32(dr.GetOrdinal("id_municipio"));
                    item.Colonia = dr.GetString(dr.GetOrdinal("colonia"));
                    item.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("fechaNacimiento"));
                    item.IDGenero = dr.GetInt32(dr.GetOrdinal("id_genero"));
                    item.Curp = dr.GetString(dr.GetOrdinal("curp"));
                    item.Telefono = dr.GetString(dr.GetOrdinal("telefono"));
                    item.Genero = dr.GetString(dr.GetOrdinal("genero"));
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente ObtenerDatosEmpresaCliente(Cliente datos)
        {
            try
            {
                Cliente aux = new Cliente();
                SqlDataReader dr = SqlHelper.ExecuteReader(datos.Conexion, "spCSLDB_get_EmpresaXIDCliente", datos.IDCliente);
                while (dr.Read())
                {
                    aux.IDCliente = dr.GetString(dr.GetOrdinal("IDCliente"));
                    aux.IDEmpresa = dr.GetString(dr.GetOrdinal("IDEmpresa"));
                    aux.Empresa = dr.GetString(dr.GetOrdinal("Empresa"));
                    aux.Nombre = dr.GetString(dr.GetOrdinal("Cliente"));
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
