using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Datos;

namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Login_Negocio
    {
        public Usuario ValidarUsuario(Usuario usuario)
        {
            try
            {
                Login_Datos login_datos = new Login_Datos();
                login_datos.ValidarUsuario(usuario);
                return usuario;
            }
            catch (Exception ex)
            {

                throw new Exception("Error en negocios ValidarUsuario" + ex.Message);
            }
        }
    }
}
