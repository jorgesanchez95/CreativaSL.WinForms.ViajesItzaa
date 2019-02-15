using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;
using CreativaSL.LibControls.WinForms;
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using System.Configuration;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmNuevaOrdenPago : Form_Creativa
    {
        #region Variables / Propiedades

        private Solicitud Datos = new Solicitud();
        private frmWait Espere = new frmWait();

        #endregion

        #region Constructor

        public frmNuevaOrdenPago(Solicitud Aux)
        {
            try
            {
                InitializeComponent();
                Datos = Aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaOrdenPago");
            }
        }

        #endregion

        #region Eventos

        #region Eventos BackGroundWorker

        #region Eventos Enviar Correo

        private void bgwEnvioCorreo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                OrdenPago aux = (OrdenPago)e.Argument;
                this.EnviarCorreo(aux);
                this.bgwEnvioCorreo.ReportProgress(100);
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_DoWork");
                throw ex;
            }
        }

        private void bgwEnvioCorreo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Espere.DialogResult = DialogResult.OK;
                this.Espere.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_RunWorkerCompleted");
            }
        }

        private void bgwEnvioCorreo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.Espere.ActualizarProgreso(e.ProgressPercentage);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_ProgressChanged");
            }
        }

        #endregion

        #endregion

        #region Eventos Control TextBox

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.btnGuardar.Focus();
                }
                else
                {
                    Validaciones validar = new Validaciones();
                    validar.PermitirSoloNumerosDecimales(e, this.txtMonto.Text);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_KeyPress");
            }
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out monto);
                this.txtMonto.Text = string.Format("{0:c}", monto);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Validating");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmNuevaOrdenPago_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - generar Orden de pago Paypal";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPagoAbono_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

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
                    OrdenPago_Negocio opn = new OrdenPago_Negocio();
                    OrdenPago Aux = this.ObtenerDatos();
                    opn.InsertarNuevaOrdenPago(Aux);
                    if (Aux.Validador)
                    {                        
                        MessageBox.Show("Datos Guardados Correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            this.bgwEnvioCorreo.RunWorkerAsync(Aux);
                            Espere.ShowDialog();
                        }
                        catch (Exception)
                        {
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intente nuevamente. Si el problema persiste, contacte a soporte técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Métodos

        private bool EnviarCorreo(OrdenPago aux)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosCorreo = new Solicitud();
                datosCorreo = sn.ObtenerDatosCorreoOrdenPago(aux);
                string contenido = EnvioCorreo.GenerarHtmlOrdenPago(datosCorreo);
                return EnvioCorreo.EnviarCorreo(
                                         ConfigurationManager.AppSettings.Get("CorreoTxt")
                                        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                                        , datosCorreo.Cliente.CorreoElectronico
                                        , "Orden de pago Paypal - " + datosCorreo.NombreProducto
                                        , contenido
                                        , false
                                        , ""
                                        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("HtmlTxt"))
                                        , ConfigurationManager.AppSettings.Get("HostTxt")
                                        , Convert.ToInt32(ConfigurationManager.AppSettings.Get("PortTxt"))
                                        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("EnableSslTxt")));
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
                this.IniciarDatosForm();
                this.ActiveControl = this.txtNombreOrdenPago;
                this.txtNombreOrdenPago.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatosForm()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Datos.IDSolicitud))
                {
                    this.txtFolioSolicitud.Text = this.Datos.Folio;
                    this.txtNombreOrdenPago.Text = string.Empty;
                    this.txtDescripcion.Text = string.Empty;
                    this.txtMonto.Text = string.Format("{0:c}", 0);
                }
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

        private OrdenPago ObtenerDatos()
        {
            try
            {
                OrdenPago Aux = new OrdenPago();
                Aux.IDSolicitud = Datos.IDSolicitud;
                Aux.NombrePago = this.txtNombreOrdenPago.Text;
                Aux.DescripcionPago = this.txtDescripcion.Text;
                Aux.Pago = this.ObtenerMonto();
                Aux.Conexion = Comun.Conexion;
                Aux.IDUsuario = Comun.IDUsuario;
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerMonto()
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out aux);
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
                if (string.IsNullOrEmpty(this.txtNombreOrdenPago.Text) || string.IsNullOrWhiteSpace(this.txtNombreOrdenPago.Text))
                    errores.Add(1, "Ingrese un nombre para la orden de pago.");
                if (this.ObtenerMonto() <= 0)
                    errores.Add(2, "Ingrese un monto mayor a 0.");
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
