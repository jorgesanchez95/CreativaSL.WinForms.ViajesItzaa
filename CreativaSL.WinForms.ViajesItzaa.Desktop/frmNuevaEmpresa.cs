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
    public partial class frmNuevaEmpresa : Form_Creativa
    {
        #region Variables

        private int Opcion = 0;
        private Empresa empresa = new Empresa();

        #endregion

        #region Constructor

        public frmNuevaEmpresa()
        {
            try
            {
                InitializeComponent();
                this.Opcion = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaEmpresa");
                this.DialogResult = DialogResult.Abort;
            }
        }

        public frmNuevaEmpresa(Empresa datos)
        {
            try
            {
                InitializeComponent();
                this.Opcion = 2;
                empresa = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaEmpresa");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmNuevaEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Nueva Empresa";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaEmpresa_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatosEntrada();
                if (errores.Count == 0)
                {
                    Empresa datos = this.ObtenerDatosEmpresa();
                    Empresa_Negocio en = new Empresa_Negocio();
                    en.CatEmpresasABC(datos);
                    if (datos.Validador)
                    {
                        MessageBox.Show("Datos registrados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al guardar los datos. Es posible que el correo electrónico ya esté registrado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.MostrarMensajeError(errores);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
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
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }        

        #endregion

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.InicializarDatos();
                this.ActiveControl = this.txtNombreEmpresa;
                this.txtNombreEmpresa.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarDatos()
        {
            try
            {
                switch (this.Opcion)
                {
                    case 1: this.InicializarCampos();
                        break;
                    case 2: this.LlenarDatosEmpresaModificar(empresa);
                        break;
                    default:
                        break;
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarCampos()
        {
            try
            {
                this.txtNombreEmpresa.Text = string.Empty;
                this.txtContacto.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;
                this.txtCorreoElectronico.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatosEmpresaModificar(Empresa datos)
        {
            try
            {
                this.txtNombreEmpresa.Text = datos.NombreComercial;
                this.txtContacto.Text = datos.Contacto;
                this.txtTelefono.Text = datos.Telefono;
                this.txtCorreoElectronico.Text = datos.Correo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError(Hashtable errores)
        {
            try
            {
                string cadenaErrores = string.Empty;
                cadenaErrores = "No se pudo guardar la información. Se presentaron los siguientes errores: \r\n";
                int aux = 1;
                
                foreach (DictionaryEntry de in errores)
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

        private Empresa ObtenerDatosEmpresa()
        {
            try
            {
                Empresa datos = new Empresa();
                datos.NombreComercial = this.txtNombreEmpresa.Text;
                datos.Contacto = this.txtContacto.Text;
                datos.Telefono = this.txtTelefono.Text;
                datos.Correo = this.txtCorreoElectronico.Text;
                datos.Conexion = Comun.Conexion;
                datos.IDUsuario = Comun.IDUsuario;
                datos.Opcion = this.Opcion;
                switch (this.Opcion)
                {
                    case 1: datos.IDEmpresa = string.Empty;
                        break;
                    case 2: datos.IDEmpresa = empresa.IDEmpresa;
                        break;
                    default: datos.IDEmpresa = string.Empty;
                        break;
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private Hashtable ValidarDatosEntrada()
        {
            try
            {
                Hashtable errores = new Hashtable();
                Validaciones validar = new Validaciones();
                if (string.IsNullOrEmpty(this.txtNombreEmpresa.Text) || string.IsNullOrWhiteSpace(this.txtNombreEmpresa.Text))
                    errores.Add(1, "Ingrese el nombre de la empresa. ");
                if (string.IsNullOrEmpty(this.txtContacto.Text) || string.IsNullOrWhiteSpace(this.txtContacto.Text))
                    errores.Add(2, "Ingrese nombre del contacto de la empresa. ");
                if (!string.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    if (!validar.ValidarNumeroTelefonico(this.txtTelefono.Text))
                        errores.Add(4, "Ingrese un número telefónico correcto. ");
                }
                else
                    errores.Add(9, "Ingrese un número Telefónico.");
                if(string.IsNullOrEmpty(this.txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(this.txtCorreoElectronico.Text))
                    errores.Add(6, "Ingrese el correo electrónico de la empresa. ");
                else
                    if(!validar.ValidarCorreoElectronico(this.txtCorreoElectronico.Text))
                        errores.Add(7, "El Correo ingresado no es válido. ");                
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
