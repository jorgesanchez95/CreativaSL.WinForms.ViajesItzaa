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
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using System.IO;
using System.Collections;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCambiarPasswordCliente : Form_Creativa
    {

        #region Variables

        private Cliente DatosCliente = new Cliente();

        #endregion

        #region Constructores

        public frmCambiarPasswordCliente(Cliente Datos)
        {
            try
            {
                InitializeComponent();
                DatosCliente = Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la información. Contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCambiarPasswordCliente");
            }
        }

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.LlenarDatosUsuario();
                this.ActiveControl = this.txtPassword;
                this.txtPassword.Focus();
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
                if (!string.IsNullOrEmpty(DatosCliente.IDCliente))
                {
                    this.txtNombre.Text = DatosCliente.Nombre;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
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

        private Cliente ObtenerDatos()
        {
            try
            {
                Cliente Aux = new Cliente();
                Aux.IDCliente = this.DatosCliente.IDCliente;
                Aux.Conexion = Comun.Conexion;
                Aux.IDUsuario = Comun.IDUsuario;
                Aux.Password = this.txtPassword.Text;
                return Aux;
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
                if (string.IsNullOrEmpty(this.txtPassword.Text))
                    errores.Add(1, "Ingrese la contraseña.");
                 else if (this.txtPassword.Text.Length < 4)
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
                    Cliente Aux = this.ObtenerDatos();
                    Cliente_Negocio cn = new Cliente_Negocio();
                    cn.ActualizarPasswordCliente(Aux);
                    if (Aux.Validador)
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

        private void frmCambiarPasswordCliente_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cambiar Password Cliente ";
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btnAceptar.Focus();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtPassword_KeyPress");
            }
        }

        #endregion

        #endregion

    }
}