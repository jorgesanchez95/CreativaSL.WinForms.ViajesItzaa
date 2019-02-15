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
    public partial class frmMontoInicial : Form_Creativa
    {
        #region Propiedades

        private Solicitud _Solicitud;

        public Solicitud Datos
        {
            get { return _Solicitud; }
            set { _Solicitud = value; }
        }

        #endregion

        #region Constructor
        
        public frmMontoInicial()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmMontoInicial_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Monto Inicial ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
                this.LlenarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmMontoInicial_Load");
            }
        }

        #endregion

        #region Eventos Control Textbox

        private void txtMontoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.txtMotivo.Focus();
                }
                else
                {
                    Validaciones validar = new Validaciones();
                    validar.PermitirSoloNumerosDecimales(e, this.txtMontoInicial.Text);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMontoInicial_KeyPress");
            }
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btnAceptar_Click(this.btnAceptar, e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMontoInicial_KeyPress");
            }
        }

        private void txtMontoInicial_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMontoInicial.Text, out aux);
                this.txtMontoInicial.Text = string.Format("{0:F2}", aux);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMontoInicial_Validating");
            }
        }

        #endregion

        #region Eventos Click

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.ObtenerDatos();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.MostarMensajeErrorValidacion(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.txtMontoInicial.Text = string.Format("{0:F2}", 0);
                this.txtMotivo.Text = string.Empty;
                this.ActiveControl = this.txtMontoInicial;
                this.txtMontoInicial.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatos()
        {
            try
            {
                this.txtMontoInicial.Text = string.Format("{0:F2}", this._Solicitud.MontoInicial);
                this.txtMotivo.Text = this._Solicitud.MotivoMontoInicial;
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

        private void ObtenerDatos()
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMontoInicial.Text, out aux);
                this._Solicitud.MontoInicial = aux;
                this._Solicitud.MotivoMontoInicial = this.txtMotivo.Text;
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
                decimal aux = 0;
                decimal.TryParse(this.txtMontoInicial.Text, out aux);
                if (aux <= 0)
                    errores.Add(1, "El monto Incial debe ser mayor a " + string.Format("{0:c}", 0));
                if (string.IsNullOrEmpty(this.txtMotivo.Text) || string.IsNullOrWhiteSpace(this.txtMotivo.Text))
                    errores.Add(2, "Ingrese el motivo del Monto Inicial.");
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
