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
    public partial class frmNotas : Form_Creativa
    {
        #region Variables 

        private int TipoForm = 0;
        private Nota DatosNota = new Nota();

        #endregion

        #region Constructor

        public frmNotas(Nota nota, int tipo)
        {
            try
            {
                InitializeComponent();
                DatosNota = nota;
                TipoForm = tipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotas");
            }
        }        

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmNotas_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Notas";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.LlenarDatosNota();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotas_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.ObtenerDatosNota();
                    Nota_Negocio nn = new Nota_Negocio();
                    nn.ABCNotas(DatosNota);
                    if (DatosNota.Validador)
                    {
                        MessageBox.Show("La nota ha sido agregada exitosamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar la nota. Intente Nuevamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    this.MostrarMensajeError(errores);
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

        #region Eventos Checked Changed

        private void chkNotificacion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkNotificacion.Checked)
                    this.dtpFechaNotificacion.Enabled = true;
                else
                {
                    this.dtpFechaNotificacion.Enabled = false;
                    this.dtpFechaNotificacion.Value = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "chkNotificacion_CheckedChanged");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.LlenarDatosNota(); // Llena los datos o Inicializa los datos
                this.ActiveControl = this.chkNotificacion;
                this.chkNotificacion.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatosNota()
        {
            try
            {
                if (string.IsNullOrEmpty(DatosNota.IDNota))
                {
                    this.chkNotificacion.Checked = false;
                    this.dtpFechaNotificacion.Value = DateTime.Today;
                    this.txtNotas.Text = string.Empty;
                }
                else
                {
                    this.chkNotificacion.Checked = DatosNota.Notificar;
                    if (DatosNota.Notificar)
                        this.dtpFechaNotificacion.Value = DatosNota.FechaNotificacion;
                    else
                        this.dtpFechaNotificacion.Value = DateTime.Today;
                    this.txtNotas.Text = DatosNota.TextoNota;
                }
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

        private void ObtenerDatosNota()
        {
            try
            {                
                DatosNota.Conexion = Comun.Conexion;
                DatosNota.Opcion = TipoForm;
                DatosNota.IDUsuario = Comun.IDUsuario;
                DatosNota.Notificar = this.chkNotificacion.Checked;
                DatosNota.FechaNotificacion = this.dtpFechaNotificacion.Value;
                DatosNota.TextoNota = this.txtNotas.Text;
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
                if (string.IsNullOrEmpty(this.txtNotas.Text) || string.IsNullOrWhiteSpace(this.txtNotas.Text))
                    errores.Add(1, "Ingrese el texto de la nota.");
                if (this.chkNotificacion.Checked)
                {
                    if (this.dtpFechaNotificacion.Value < DateTime.Today)
                        errores.Add(2, "La fecha de Notificación no puede ser menor a la fecha Actual.");
                }
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
