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
using System.Collections;
using System.IO;
using System.Globalization;
using System.Configuration;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCobro : Form_Creativa
    {
        #region Variables

        Pago DatosPago = new Pago();
        private FormaPago DatosTarjeta = new FormaPago();
        private FormaPago DatosTransferencia = new FormaPago();
        private FormaPago DatosPaypal = new FormaPago();
        private frmWait Espere = new frmWait();
        #endregion

        #region Constructor

        public frmCobro(Pago Aux)
        {
            try
            {
                InitializeComponent();
                DatosPago = Aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCobro");
            }
        }

        #endregion

        #region Eventos

        #region Eventos CheckedChanged

        private void chkPagoPaypal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkPagoPaypal.Checked)
                {
                    this.DatosPaypal.Monto = this.DatosPago.MontoAPagar;
                    frmDatosPaypal dpp = new frmDatosPaypal(DatosPaypal, 0);
                    dpp.ShowDialog();
                    dpp.Dispose();
                    if (dpp.DialogResult == DialogResult.OK)
                    {
                        this.DatosPaypal = dpp.datos;
                        this.txtPagoPaypal.Text = string.Format("{0:c}", DatosPaypal.Monto);
                        this.DrawCambio();
                    }
                    else
                    {
                        this.txtPagoPaypal.Text = string.Format("{0:c}", 0);
                        this.DatosPaypal = new FormaPago();
                        this.DrawCambio();
                        this.chkPagoPaypal.Checked = false;
                    }
                }
                else
                {
                    this.txtPagoPaypal.Text = string.Format("{0:c}", 0);
                    this.DatosPaypal = new FormaPago();
                    this.DrawCambio();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "chkPagoPaypal_CheckedChanged");
            }
        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkTarjeta.Checked)
                {
                    this.DatosTarjeta.Monto = this.DatosPago.MontoAPagar;
                    frmDatosTarjeta dt = new frmDatosTarjeta(DatosTarjeta, 0);
                    dt.ShowDialog();
                    dt.Dispose();
                    if (dt.DialogResult == DialogResult.OK)
                    {
                        this.DatosTarjeta = dt.datos;
                        this.txtPagoTarjeta.Text = string.Format("{0:c}", DatosTarjeta.Monto);
                        this.DrawCambio();
                    }
                    else
                    {
                        this.txtPagoTarjeta.Text = string.Format("{0:c}", 0);
                        this.DatosTarjeta = new FormaPago();
                        this.DrawCambio();
                        this.chkTarjeta.Checked = false;
                    }
                }
                else
                {
                    this.txtPagoTarjeta.Text = string.Format("{0:c}", 0);
                    this.DatosTarjeta = new FormaPago();
                    this.DrawCambio();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "chkTarjeta_CheckedChanged");
            }
        }

        private void chkTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkTransferencia.Checked)
                {
                    this.DatosTransferencia.Monto = this.DatosPago.MontoAPagar;
                    frmDatosTransferencia dt = new frmDatosTransferencia(DatosTransferencia, 0);
                    dt.ShowDialog();
                    dt.Dispose();
                    if (dt.DialogResult == DialogResult.OK)
                    {
                        this.DatosTransferencia = dt.datos;
                        this.txtPagoTransfrencia.Text = string.Format("{0:c}", DatosTransferencia.Monto);
                        this.DrawCambio();
                    }
                    else
                    {
                        this.txtPagoTransfrencia.Text = string.Format("{0:c}", 0);
                        this.DatosTransferencia = new FormaPago();
                        this.DrawCambio();
                        this.chkTransferencia.Checked = false;
                    }
                }
                else
                {
                    this.txtPagoTransfrencia.Text = string.Format("{0:c}", 0);
                    this.DatosTransferencia = new FormaPago();
                    this.DrawCambio();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "chkTransferencia_CheckedChanged");
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
                    Pago datos = this.ObtenerDatosPago();
                    Pago_Negocio pagneg = new Pago_Negocio();
                    pagneg.InsertarPago(datos);
                    if (!string.IsNullOrEmpty(datos.IDPago))
                    {
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            this.bgwEnvioCorreo.RunWorkerAsync(datos);
                            Espere.ShowDialog();
                        }
                        catch (Exception ax)
                        {
                            Comun_Negocio.AddExcFileTxt(ax, "EnvioCorreo_NuevoPago");
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

        #endregion

        #region Eventos Control TextBox

        private void txtPagoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.ActiveControl = this.btnGuardar;
                    this.btnGuardar.Focus();
                }
                else
                {
                    Validaciones Val = new Validaciones();
                    Val.PermitirSoloNumerosDecimales(e, txt.Text);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtPagoEfectivo_KeyPress");
            }
        }

        private void txtPagoEfectivo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.DrawCambio();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtPagoEfectivo_KeyUp");
            }
        }

        private void txtPagoEfectivo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal aux = 0;
                TextBox txt = (TextBox)sender;
                decimal.TryParse(txt.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out aux);
                txt.Text = string.Format("{0:c}", aux);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtPagoEfectivo_Validating");
            }
        }

        #endregion

        #region Eventos del Formulario
        
        private void frmCobro_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cobro";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCobro_Load");
            }
        }

        #endregion

        #region Eventos Enviar Correo

        private void bgwEnvioCorreo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Pago aux = (Pago)e.Argument;
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

        private void DrawCambio()
        {
            try
            {
                decimal cambio = this.ObtenerCambio();
                if (cambio <= 0)
                {
                    this.txtCambio.BackColor = Color.MediumSpringGreen;
                    this.txtCambio.Text = string.Format("{0:c}", cambio * -1);
                    this.label2.Text = "Cambio:";
                }
                else
                {
                    this.txtCambio.BackColor = Color.OrangeRed;
                    this.txtCambio.Text = string.Format("{0:c}", cambio);
                    this.label2.Text = "  Debe:";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool EnviarCorreo(Pago aux)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosCorreo = new Solicitud();
                datosCorreo = sn.ObtenerDatosCorreoConfirmaPago(aux);
                string contenido = EnvioCorreo.GenerarHtmlConfirmacionPago(datosCorreo);                
                return EnvioCorreo.EnviarCorreo(
                                         ConfigurationManager.AppSettings.Get("CorreoTxt")
                                        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                                        , datosCorreo.Cliente.CorreoElectronico
                                        , "Confirmación de pago - " + datosCorreo.NombreProducto
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

        private void IniciarCampos()
        {
            try
            {
                this.txtMontoAPagar.Text = string.Format("{0:c}", this.DatosPago.MontoAPagar);
                this.txtPagoEfectivo.Text = string.Format("{0:c}", 0);
                this.txtPagoPaypal.Text = string.Format("{0:c}", 0);
                this.txtPagoTarjeta.Text = string.Format("{0:c}", 0);
                this.txtPagoTransfrencia.Text = string.Format("{0:c}", 0);
                this.DrawCambio();
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
                this.IniciarCampos();
                this.ActiveControl = this.txtPagoEfectivo;
                this.txtPagoEfectivo.Focus();
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

        private decimal ObtenerCambio()
        {
            try
            {
                return this.DatosPago.MontoAPagar - this.ObtenerPagoTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private Pago ObtenerDatosPago()
        {
            try
            {
                Pago Aux = new Pago();
                Aux.IDSolicitud = this.DatosPago.IDSolicitud;
                Aux.PagoEfectivo = this.ObtenerPagoEfectivo();
                Aux.PagoTransferencia = this.ObtenerPagoTransferencia();
                Aux.PagoPaypal = this.ObtenerPagoPaypal();
                Aux.PagoTarjeta = this.ObtenerPagoTarjeta();
                Aux.TotalPago = this.ObtenerPagoTotal();
                Aux.TotalCambio = (this.ObtenerCambio() * -1);
                Aux.MontoTotal = Aux.TotalPago - Aux.TotalCambio; //Es el pago real
                Aux.DatosFormasPago = this.ObtenerTablaDetalleCobro();
                Aux.DatosExtraFormasPago = this.ObtenerTablaDatosCobro();
                Aux.IDCaja = Comun.IDCaja;
                Aux.IDCajero = Comun.IDUsuario;
                Aux.Conexion = Comun.Conexion;
                Aux.IDSucursal = Comun.IDSucursalCaja;
                Aux.RequiereFactura = false;
                Aux.Opcion = 1;
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoTotal()
        {
            try
            {
                return this.ObtenerPagoEfectivo() + this.ObtenerPagoPaypal() + this.ObtenerPagoTarjeta() + this.ObtenerPagoTransferencia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoEfectivo()
        {
            try
            {
                decimal PagoEfectivo = 0;
                decimal.TryParse(this.txtPagoEfectivo.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out PagoEfectivo);
                return PagoEfectivo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoNoEfectivo()
        {
            try
            {
                return this.ObtenerPagoPaypal() + this.ObtenerPagoTarjeta() + this.ObtenerPagoTransferencia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoPaypal()
        {
            try
            {
                decimal PagoPaypal = 0;
                if (this.DatosPaypal != null)                    
                    PagoPaypal = DatosPaypal.Monto;
                return PagoPaypal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoTarjeta()
        {
            try
            {
                decimal PagoTarjeta = 0;
                if (this.DatosTarjeta != null)
                    PagoTarjeta = DatosTarjeta.Monto;
                return PagoTarjeta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerPagoTransferencia()
        {
            try
            {
                decimal PagoTransferencia = 0;
                if (this.DatosTransferencia != null)
                    PagoTransferencia = DatosTransferencia.Monto;
                return PagoTransferencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerTablaDetalleCobro()
        {
            try
            {
                //Para llenar tabla detalle del cobro
                DataTable tabla = new DataTable();
                tabla.Columns.Add("idTipoPago", typeof(int));
                tabla.Columns.Add("monto", typeof(decimal));
                if (this.ObtenerPagoEfectivo() > 0)
                {
                    tabla.Rows.Add(
                        new Object[] { 
                        Convert.ToInt32(this.txtPagoEfectivo.Tag),
                        this.ObtenerPagoEfectivo()});
                }
                if (this.ObtenerPagoPaypal() > 0)
                {
                    tabla.Rows.Add(
                        new Object[] { 
                        Convert.ToInt32(this.txtPagoPaypal.Tag),
                        this.ObtenerPagoPaypal()});
                }
                if (this.ObtenerPagoTarjeta() > 0)
                {
                    tabla.Rows.Add(
                        new Object[] { 
                        Convert.ToInt32(this.txtPagoTarjeta.Tag),
                        this.ObtenerPagoTarjeta()});
                }
                if (this.ObtenerPagoTransferencia() > 0)
                {
                    tabla.Rows.Add(
                        new Object[] { 
                        Convert.ToInt32(this.txtPagoTransfrencia.Tag),
                        this.ObtenerPagoTransferencia()});
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerTablaDatosCobro()
        {
            try
            {
                //Para llenar tabla detalle del cobro
                DataTable tabla = new DataTable();
                tabla.Columns.Add("idtipoPago", typeof(int));
                tabla.Columns.Add("autorizacion", typeof(string));
                tabla.Columns.Add("tipoDocumento", typeof(int));
                tabla.Columns.Add("folioDNI", typeof(string));
                tabla.Columns.Add("numTarjeta", typeof(string));
                tabla.Columns.Add("id_banco", typeof(int));
                tabla.Columns.Add("monto", typeof(decimal));
                tabla.Columns.Add("comision", typeof(decimal));
                if (this.DatosPaypal != null)
                {
                    if (this.DatosPaypal.Monto > 0)
                    {

                        tabla.Rows.Add(new Object[] { 
                            Convert.ToInt32(this.txtPagoPaypal.Tag),
                            DatosPaypal.Autorizacion,
                            0,
                            string.Empty,
                            string.Empty,
                            0,
                            DatosPaypal.Monto,
                            DatosPaypal.Comision});

                    }
                }
                if (this.DatosTarjeta != null)
                {
                    if (this.DatosTarjeta.Monto > 0)
                    {
                        tabla.Rows.Add(new Object[] { 
                            Convert.ToInt32(this.txtPagoTarjeta.Tag),
                            DatosTarjeta.Autorizacion,
                            DatosTarjeta.TipoDocumentoAux != null ? DatosTarjeta.TipoDocumentoAux.IDTipoDocumento : 0,
                            DatosTarjeta.FolioIFE,
                            DatosTarjeta.NumTarjeta,
                            DatosTarjeta.BancoAux != null ? DatosTarjeta.BancoAux.IDBanco : 0,
                            DatosTarjeta.Monto,
                            0});
                    }
                }
                if (this.DatosTransferencia != null)
                {
                    if (this.DatosTransferencia.Monto > 0)
                    {
                        tabla.Rows.Add(new Object[] { 
                            Convert.ToInt32(this.txtPagoTransfrencia.Tag),
                            DatosTransferencia.Autorizacion,
                            0,
                            string.Empty,
                            string.Empty,
                            DatosTransferencia.BancoAux != null ? DatosTransferencia.BancoAux.IDBanco : 0,
                            DatosTransferencia.Monto,
                            0});
                    }
                }
                return tabla;
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
                if (this.ObtenerPagoTotal() <= 0)
                    errores.Add(1, "El pago debe ser mayor a 0.");
                if (this.ObtenerPagoNoEfectivo() > this.DatosPago.MontoAPagar)
                    errores.Add(2, "La suma de las formas de pago distintas a efectivo deben ser menor al monto a pagar. ");
                if (this.ObtenerPagoTotal() < this.DatosPago.MontoAPagar)
                    errores.Add(3, "El pago no cubre el total. ");
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
