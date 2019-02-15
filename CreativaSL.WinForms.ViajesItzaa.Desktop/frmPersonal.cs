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
    public partial class frmPersonal : Form_Creativa
    {
        #region Variables

        private Solicitud Datos = new Solicitud();

        #endregion

        #region Constructor

        public frmPersonal(Solicitud aux)
        {
            try
            {
                InitializeComponent();
                this.Datos = aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPersonal");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnRegresar_Click");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    Solicitud aux = this.ObtenerDatosSolicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    sn.CambiarUsuarioSolicitud(aux);
                    if(aux.Validador)
                    {
                        MessageBox.Show("Datos guardados correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intente Nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    this.MostarMensajeErrorValidacion(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Personal";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPersonal_Load");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarDatos()
        {
            try
            {
                Usuario datosUser = new Usuario();
                Solicitud aux = new Solicitud();
                Usuario_Negocio un = new Usuario_Negocio();
                aux.IDSolicitud = this.Datos.IDSolicitud;
                aux.Conexion = Comun.Conexion;
                datosUser = un.ObtenerUsuarioXIDSolicitud(aux);
                this.txtFolioSolicitud.Text = this.Datos.Folio;
                this.txtUsuarioActual.Text = datosUser.Nombre;
                this.LlenarComboUsuarios(datosUser.IDUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarForm()
        {
            try
            {
                this.IniciarDatos();
                this.ActiveControl = this.cmbUsuario;
                this.cmbUsuario.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboUsuarios(string IDUsuario)
        {
            try
            {
                Usuario user = new Usuario();
                Usuario_Negocio un = new Usuario_Negocio();
                user.Conexion = Comun.Conexion;
                user.IDUsuario = IDUsuario;
                this.cmbUsuario.DataSource = un.ObtenerComboCambioUsuario(user);
                this.cmbUsuario.DisplayMember = "Nombre";
                this.cmbUsuario.ValueMember = "IDUsuario";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostarMensajeErrorValidacion(Hashtable errores)
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

        private Solicitud ObtenerDatosSolicitud()
        {
            try
            {
                Solicitud Aux = new Solicitud();
                Aux.IDSolicitud = this.Datos.IDSolicitud;
                Aux.IDUsuarioRecibido = this.ObtenerUsuarioSeleccionado().IDUsuario;
                Aux.IDUsuario = Comun.IDUsuario;
                Aux.Conexion = Comun.Conexion;
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Usuario ObtenerUsuarioSeleccionado()
        {
            try
            {
                Usuario aux = new Usuario();
                if (this.cmbUsuario.SelectedIndex != -1)
                {
                    aux = (Usuario)this.cmbUsuario.SelectedItem;
                }
                return aux;
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
                if (string.IsNullOrEmpty(this.ObtenerUsuarioSeleccionado().IDUsuario))
                    errores.Add(1, "Seleccione el usuario que atenderá la solicitud.");
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
