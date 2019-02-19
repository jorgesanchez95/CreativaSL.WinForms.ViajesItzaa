using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;
using CreativaSL.LibControls.WinForms;
using System.Management;
using System.Configuration;
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmLogin : Form_Creativa
    {
        #region Variables Globales

        private Usuario usuario;

        #endregion

        #region Constructor

        public frmLogin()
        {
            try
            {
                InitializeComponent();
                this.CargarDatosIniciales();
                this.txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmLogin");
                this.Close();
            }
        }

        #endregion

        #region Eventos

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatosEntrada())
                {
                    IniciarSistema();
                    usuario = new Usuario();
                    usuario.Validador = 1;
                    usuario.IDSucursal = Comun.IDSucursalCaja;
                    usuario = this.ObtenerDatosUsuario(usuario);
                    usuario.Conexion = Comun.Conexion;
                    //string carpeta = @"C:\FichasEnviadas";
                    if (!string.IsNullOrEmpty(Comun.MACAddress))
                    {
                        usuario = this.Ingresar(usuario);
                        //if (!(Directory.Exists(carpeta)))
                        //{
                        //    Directory.CreateDirectory(carpeta);
                        //} 
                        if (usuario.Validador == 1)
                        {
                            if (usuario.IDSucursal == Comun.IDSucursalCaja)
                            {
                                if (usuario.IDTipoUsuario > 0)
                                {
                                    if (usuario.CrearIDCaja == false)
                                    {
                                        frmCaja_AperturaCaja aperturaCaja = new frmCaja_AperturaCaja();
                                        aperturaCaja.ShowDialog();
                                        aperturaCaja.Dispose();
                                        if (aperturaCaja.DialogResult == DialogResult.OK)
                                        {
                                            this.Visible = false;
                                            frmHome home = new frmHome();
                                            home.ShowDialog();
                                            home.Dispose();
                                            this.Visible = true;
                                            this.txtUsuario.Focus();
                                            this.txtUsuario.Text = "";
                                            this.txtContraseña.Text = "";
                                            this.txt_mensaje.Text = "";
                                            this.txt_mensaje.Visible = false;
                                        }
                                    }
                                    else
                                    {
                                        this.Visible = false;
                                        frmHome home = new frmHome();
                                        home.ShowDialog();
                                        home.Dispose();
                                        this.Visible = true;
                                        this.txtUsuario.Focus();
                                        this.txtUsuario.Text = "";
                                        this.txtContraseña.Text = "";
                                        this.txt_mensaje.Text = "";
                                        this.txt_mensaje.Visible = false;
                                    }
                                }
                                else
                                {
                                    DatosIncorrectos(7);
                                }
                            }
                            else
                                this.DatosIncorrectos(4);
                        }
                        else
                        {
                            this.DatosIncorrectos(usuario.Validador);
                            if (usuario.Validador == 8)
                            {
                                frmAsignarCaja frmac = new frmAsignarCaja();
                                frmac.ShowDialog();
                                frmac.Dispose();
                                if (frmac.DialogResult != DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No se pudo obtener la configuración del Equipo. El sistema debe cerrarse.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 27)
                {
                    if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "frmLogin_KeyUp");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Login";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmLogin_Load");
            }
        }        

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtContraseña.SelectAll();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtContraseña_Enter");
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.btnAceptar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtContraseña_KeyPress");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtUsuario.SelectAll();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtUsuario_Enter");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtUsuario_KeyPress");
            }
        }

        #endregion

        #region Metodos

        private void CargarDatosIniciales()
        {
            try
            {
                Comun.Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                Comun.MensajeError = "Error al cargar los datos. Contacte a Soporte Técnico.";
                Comun.CaptionSystem = "Agencia Viajes";
                Comun.IconoSistema = @"Resources\documents\icono.ico";
                Comun.UrlTxtLog = @"Resources\documents\LogErrorFile.txt";
                //Comun.UrlLogo = "logo.png";
                Comun.UrlAyuda = @"Resources\documents\Ayuda.pdf";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private void DatosIncorrectos(int opcion)
        {
            try
            {
                switch (opcion)
                {
                    case 2:
                        this.Mensaje("Su cuenta ha caducado. Comuníquese con un Administrador.");
                        break;
                    case 3:
                        this.Mensaje("Su cuenta está bloqueada. Comuníquese con un Administrador.");
                        break;
                    case 4:
                        this.Mensaje("El usuario no está registrado para ésta Sucursal.");
                        break;
                    case 5:
                        this.Mensaje("No existe la cuenta.");
                        break;
                    case 6:
                        this.Mensaje("Ha excedido el número de intentos. Su cuenta fue bloqueada. Comuníquese con un Administrador.");
                        break;
                    case 7:
                        this.Mensaje("Contraseña Incorrecta. Intente nuevamente.");
                        break;
                    case 8:
                        this.Mensaje("No fue Localizada la caja. Asigne una caja.");
                        break;
                    case 10:
                        this.Mensaje("No se pudo obtener la configuración del Equipo. El sistema debe cerrarse");
                        break;
                    case 15:
                        this.Mensaje("No se pudo conectar al servidor.");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Datos incorrectos" + ex.Message);
            }
        }

        private string GetHostName()
        {
            try
            {
                ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                ManagementObjectCollection objMOC = objMOS.Get();
                string HostName = String.Empty;
                foreach (ManagementObject objMO in objMOC)
                {
                    if (HostName == String.Empty)
                    {
                        HostName = objMO["DNSHostName"].ToString();
                        break;
                    }
                    objMO.Dispose();
                }               
                return HostName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetMACAddress()
        {
            try
            {
                string MACAddress = String.Empty;
                if (Convert.ToBoolean(ConfigurationManager.AppSettings.Get("strBanMac")))
                {
                    MACAddress = ConfigurationManager.AppSettings.Get("strMac");
                }
                else
                {

                    ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                    ManagementObjectCollection objMOC = objMOS.Get();
                    foreach (ManagementObject objMO in objMOC)
                    {
                        if (MACAddress == String.Empty)
                        {
                            MACAddress = objMO["MacAddress"].ToString();
                            break;
                        }
                        objMO.Dispose();
                    }
                }
                return MACAddress;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarSistema()
        {
            try
            {                
                Comun.MACAddress = this.GetMACAddress();
                Comun.HostName = this.GetHostName();
                if (string.IsNullOrEmpty(Comun.HostName))
                    Comun.HostName = string.Empty;
                if (!string.IsNullOrEmpty(Comun.MACAddress) && !string.IsNullOrWhiteSpace(Comun.MACAddress))
                {
                    Comun_Negocio cm = new Comun_Negocio();
                    cm.ObtenerSucursal(Comun.Conexion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario Ingresar(Usuario usuario)
        {
            try
            {
                Login_Negocio login_negocio = new Login_Negocio();
                return (login_negocio.ValidarUsuario(usuario));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar" + ex.Message);
            }
        }

        private void Mensaje(string msj)
        {
            try
            {
                this.txt_mensaje.Text = msj;
                this.txt_mensaje.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario ObtenerDatosUsuario(Usuario usuario)
        {
            try
            {
                usuario.UsuarioCuenta = this.txtUsuario.Text;
                usuario.UsuarioPassword = this.txtContraseña.Text;
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarDatosEntrada()
        {
            try
            {
                if (this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
                {
                    if (this.txtUsuario.Text == "")
                    {
                        this.txtUsuario.Focus();
                        this.Mensaje("Debes ingresar usuario");
                    }
                    else if (this.txtContraseña.Text == "")
                    {
                        this.txtContraseña.Focus();
                        this.Mensaje("Debes ingresar contraseña");
                    }
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        #endregion

    }
}

