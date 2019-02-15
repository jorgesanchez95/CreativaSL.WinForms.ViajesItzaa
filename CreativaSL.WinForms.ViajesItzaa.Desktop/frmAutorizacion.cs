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
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmAutorizacion : Form_Creativa
    {
        #region Propiedades

        public Usuario usuarioAutoriza = new Usuario();
        private string _IDTabla;
        private string _NombreTabla;
        private string _Texto;

        public string IDTabla
        {
            set { _IDTabla = value; }
        }
        public string NombreTabla
        {
            set { _NombreTabla = value; }
        }
        public string Texto
        {
            set { _Texto = value; }
        }
        
        #endregion

        #region Constructor

        public frmAutorizacion()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAutorizacion_Load");
                this.Close();
            }
        }

        #endregion

        #region Métodos

        private void MostrarMensajeError(int error)
        {
            try
            {
                this.txt_mensaje.Visible = true;
                switch (error)
                {
                    case 2: this.txt_mensaje.Text = "La cuenta está bloqueada.";
                        this.ActiveControl = this.txtUsuario;
                        this.txtUsuario.Focus();
                        break;
                    case 3: this.txt_mensaje.Text = "La cuenta NO es de tipo Administrador.";
                        this.ActiveControl = this.txtUsuario;
                        this.txtUsuario.Focus();
                        break;
                    case 4: this.txt_mensaje.Text = "La contraseña es incorrecta.";
                        this.ActiveControl = this.txtContraseña;
                        this.txtContraseña.Focus();
                        break;
                    case 5: this.txt_mensaje.Text = "La cuenta no existe.";
                        this.ActiveControl = this.txtUsuario;
                        this.txtUsuario.Focus();
                        break;
                    case 20: this.txt_mensaje.Text = "Ingrese cuenta de Usuario.";
                        this.ActiveControl = this.txtUsuario;
                        this.txtUsuario.Focus();
                        break;
                    case 21: this.txt_mensaje.Text = "Ingrese Password.";
                        this.ActiveControl = this.txtContraseña;
                        this.txtContraseña.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario ObtenerDatos()
        {
            try
            {
                Usuario datos = new Usuario();
                datos.UsuarioCuenta = this.txtUsuario.Text;
                datos.UsuarioPassword = this.txtContraseña.Text;
                datos.Conexion = Comun.Conexion;
                datos.IDUsuario = Comun.IDUsuario;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarDatos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrWhiteSpace(this.txtUsuario.Text))
                    return 20;
                if (string.IsNullOrEmpty(this.txtContraseña.Text) || string.IsNullOrWhiteSpace(this.txtContraseña.Text))
                    return 21;
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void frmAutorizacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem;
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAutorizacion_Load");
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                int error = this.ValidarDatos();
                if (error == 0)
                {
                    Usuario datos = new Usuario();
                    Usuario_Negocio un = new Usuario_Negocio();
                    datos = un.AutorizacionAdmin(this.ObtenerDatos(), this._IDTabla, this._NombreTabla, this._Texto);
                    if (datos.Validador == 1)
                    {
                        usuarioAutoriza = datos;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.MostrarMensajeError(datos.Validador);
                    }
                }
                else
                    this.MostrarMensajeError(error);

            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.btnAceptar_Click(this.btnAceptar, e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtContraseña_KeyPress");
            }
        }

        #endregion

        
    }
}
