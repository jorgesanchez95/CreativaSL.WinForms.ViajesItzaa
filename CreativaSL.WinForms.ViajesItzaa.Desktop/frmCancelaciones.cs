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
using System.Configuration;
using System.Globalization;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCancelaciones : Form_Creativa
    {
        #region Variables

        private int TipoCancelacion = 0;
        Solicitud DatosSolicitud = new Solicitud();
        private frmWait Espere = new frmWait();

        #endregion

        #region Constructor 

        public frmCancelaciones(int TipoCanc, Solicitud Datos)
        {
            try
            {
                InitializeComponent();
                this.TipoCancelacion = TipoCanc;
                this.DatosSolicitud = Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCancelaciones");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Control TextBox

        private void txtMontoPenalizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btnGuardar.Focus();
                }
                else
                {
                    Validaciones validar = new Validaciones();
                    validar.PermitirSoloNumerosDecimales(e, this.txtMontoPenalizacion.Text);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMontoPenalizacion_KeyPress");
            }
        }

        private void txtMontoPenalizacion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.txtMontoPenalizacion.Text = string.Format("{0:c}", this.ObtenerMontoPenalizacion());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMontoPenalizacion_Validating");
            }
        }

        #endregion

        #region Eventos Click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    Solicitud Aux = this.ObtenerDatosSolicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    sn.CancelarSolicitud(Aux);
                    if (Aux.Validador)
                    {
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intente nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Eventos del Formulario

        private void frmCancelaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cancelaciones";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCancelaciones_Load");
            }
        }

        #endregion

        #region Eventos Enviar Correo

        private void bgwEnvioCorreo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Solicitud aux = (Solicitud)e.Argument;
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

        #region Métodos

        private bool EnviarCorreo(Solicitud aux)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosCorreo = new Solicitud();
                datosCorreo = sn.ObtenerDatosCorreoCancelacion(aux);
                string contenido = EnvioCorreo.GenerarHtmlCancelacion(datosCorreo);
                return EnvioCorreo.EnviarCorreo(
                                         ConfigurationManager.AppSettings.Get("CorreoTxt")
                                        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                                        , datosCorreo.Cliente.CorreoElectronico
                                        , "Cancelación - " + datosCorreo.NombreProducto
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

        private void IniciarDatosForm(Solicitud aux)
        {
            try
            {
                this.txtFolioSolicitud.Text = aux.Folio;
                this.txtMotivoCancelacion.Text = aux.MotivoCancelacion;
                this.txtMontoPagado.Text = string.Format("{0:c}", aux.Pago != null ? aux.Pago.MontoPagado : 0);
                this.txtMontoPenalizacion.Text = string.Format("{0:c}", aux.MontoPenalizacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDiseñoForm()
        {
            try
            {
                switch (TipoCancelacion)
                {
                    case 1:
                        this.txtMontoPagado.ReadOnly = true;
                        this.txtMontoPenalizacion.ReadOnly = true;
                        this.txtMontoPenalizacion.TabStop = false;
                        break;
                    case 2:
                        this.txtMontoPagado.ReadOnly = true;
                        this.txtMontoPenalizacion.ReadOnly = false;
                        break;
                    case 3:
                        this.txtMontoPagado.ReadOnly = true;
                        this.txtMontoPenalizacion.ReadOnly = true;
                        this.txtMontoPenalizacion.TabStop = false;
                        break;
                    default:
                        break;
                }
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
                this.IniciarDiseñoForm();
                Solicitud aux = new Solicitud();
                switch (TipoCancelacion)
                {
                    case 1: 
                        aux.MotivoCancelacion = string.Empty;
                        aux.Folio = this.DatosSolicitud.Folio;
                        aux.Pago = new Pago();
                        aux.Pago.MontoPagado = 0;
                        aux.MontoPenalizacion = 0;
                        break;
                    case 2:
                    case 3:
                        aux = this.ObtenerDatosInicioForm();
                        break;
                    default:
                        break;
                }
                this.IniciarDatosForm(aux);
                this.DatosSolicitud.Pago = new Pago();
                this.DatosSolicitud.Pago.MontoPagado = aux.Pago != null ? aux.Pago.MontoPagado : 0;
                this.ActiveControl = this.txtMotivoCancelacion;
                this.txtMotivoCancelacion.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Solicitud ObtenerDatosInicioForm()
        {
            try
            {
                Solicitud aux = new Solicitud();
                aux.IDSolicitud = this.DatosSolicitud.IDSolicitud;
                aux.Conexion = Comun.Conexion;
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux = sn.ObtenerMontoPagadoXIDSolicitud(aux);
                return aux;
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
                Aux.Opcion = TipoCancelacion;
                Aux.IDSolicitud = this.DatosSolicitud.IDSolicitud;
                Aux.MotivoCancelacion = this.txtMotivoCancelacion.Text;
                Aux.MontoPenalizacion = this.ObtenerMontoPenalizacion();
                Aux.IDUsuario = Comun.IDUsuario;
                Aux.IDCaja = Comun.IDCaja;
                Aux.IDSucursal = Comun.IDSucursalCaja;
                Aux.Conexion = Comun.Conexion;
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerMontoPenalizacion()
        {
            try
            {
                decimal MontoPenalizacion = 0;
                decimal.TryParse(this.txtMontoPenalizacion.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out MontoPenalizacion);
                return MontoPenalizacion;
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

        private Hashtable ValidarDatos()
        {
            try
            {
                Hashtable errores = new Hashtable();
                if (this.DatosSolicitud.Pago.MontoPagado < this.ObtenerMontoPenalizacion())
                {
                    errores.Add(1, "El monto de penalización debe ser menor o igual al Monto Pagado.");
                }
                if (TipoCancelacion == 2)
                {
                    if (this.ObtenerMontoPenalizacion() <= 0)
                        errores.Add(2, "El monto de penalización debe ser mayor a $ 0.00.");
                }
                if(string.IsNullOrEmpty(this.txtMotivoCancelacion.Text) || string.IsNullOrWhiteSpace(this.txtMotivoCancelacion.Text))
                {
                    errores.Add(3, "Ingrese un motivo de cancelación.");
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
