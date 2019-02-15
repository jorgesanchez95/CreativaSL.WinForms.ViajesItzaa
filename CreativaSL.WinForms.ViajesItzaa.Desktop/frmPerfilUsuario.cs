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
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using CreativaSL.LibControls.WinForms;
using System.IO;
using System.Collections;
namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmPerfilUsuario : Form_Creativa
    {       
        #region Constructores

        public frmPerfilUsuario()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información. Contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPerfilUsuario");
            }
        }

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.LlenarDatosUsuario();
                this.ActiveControl = this.txtNombre;
                this.txtNombre.Focus();
            }
            catch (Exception ex)
            {
                this.MostrarMensaje(ex);
            }
        }

        private void LlenarDatosUsuario()
        {
            try
            {
                Usuario Usuario = new Usuario();
                Usuario.IDUsuario = Comun.IDUsuario;
                if (!string.IsNullOrEmpty(Usuario.IDUsuario))
                {
                    Usuario.Conexion = Comun.Conexion;
                    Usuario_Negocio un = new Usuario_Negocio();
                    Usuario = un.ObtenerDatosUsuario(Usuario);
                    if (!string.IsNullOrEmpty(Usuario.IDUsuario))
                    {
                        this.txtNombre.Text = Usuario.Nombre;
                        this.txtApePat.Text = Usuario.ApellidoPaterno;
                        this.txtApeMat.Text = Usuario.ApellidoMaterno;
                        this.dtpFecNac.Value = Usuario.FechaNacimiento;
                        this.txtDireccion.Text = Usuario.Direccion;
                        this.txtTelefono.Text = Usuario.Telefono;
                        this.txtCorreoElectronico.Text = Usuario.Correo;
                        this.txtPassword.Text = "";
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensaje(Exception ex)
        {
            try
            {
                MessageBox.Show("Ocurrió un error. Comuníquese a Soporte Técnico. Informe del Error: " + ex.Message
                    , Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void MostrarMensajeError(Hashtable error)
        {
            try
            {
                string cadenaErrores = string.Empty;
                cadenaErrores = "No se pudo guardar la información. Se presentaron los siguientes errores: \r\n";
                int aux = 1;
                foreach (DictionaryEntry de in error)
                {
                    Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
                    cadenaErrores += aux + "\t" + de.Value + "\r\n"; ;
                    aux++;
                }
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = cadenaErrores;
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
                Usuario Usuario = new Usuario();
                Usuario.Conexion = Comun.Conexion;
                Usuario.Validador = 1;
                Usuario.IDUsuario = Comun.IDUsuario;
                Usuario.Nombre = this.txtNombre.Text;
                Usuario.ApellidoPaterno = this.txtApePat.Text;
                Usuario.ApellidoMaterno = this.txtApeMat.Text;
                Usuario.FechaNacimiento = this.dtpFecNac.Value;
                Usuario.Telefono = this.txtTelefono.Text;
                Usuario.Direccion = this.txtDireccion.Text;
                Usuario.Correo = this.txtCorreoElectronico.Text;
                Usuario.UsuarioPassword = this.txtPassword.Text;
                return Usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Hashtable ValidarDatos()
        {
            try
            {
                Hashtable errores = new Hashtable();
                Validaciones validar = new Validaciones();
                if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtNombre.Text))
                    errores.Add(1, "Ingrese un Nombre. ");
                if (string.IsNullOrEmpty(this.txtApePat.Text))
                    errores.Add(2, "Ingrese Apellido Paterno. ");
                if (dtpFecNac.Value.AddYears(16) > DateTime.Now)
                    errores.Add(3, "Ingrese una Fecha de Nacimiento Válida (Edad Mínima: 16 años). ");
                if (!string.IsNullOrEmpty(this.txtPassword.Text))
                    if (this.txtPassword.Text.Length < 4)
                        errores.Add(4, "La contraseña debe contener al menos 4 caracteres.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable error = this.ValidarDatos();
                if (error.Count == 0)
                {
                    Usuario Usuario = this.ObtenerDatos();
                    Usuario_Negocio un = new Usuario_Negocio();
                    un.ActualizarDatosUsuario(Usuario);
                    if (Usuario.Validador == 1)
                    {
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ocurrió un error al registrar los datos. Contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    this.MostrarMensajeError(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información. Contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
                this.DialogResult = DialogResult.Abort;
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
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Perfil de Usuario ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información. Contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPerfilUsuario_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos TextBox

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones validar = new Validaciones();
                validar.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtTelefono_KeyPress");
            }
        }

        #endregion

        #endregion

    }
}