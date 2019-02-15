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
using CreativaSL.WinForms.ViajesItzaa.Desktop;
using System.IO;
using System.Collections;
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using System.Configuration;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmConfirmarVenta : Form_Creativa
    {
        #region Variables

        private int TipoForm = 0;
        private Solicitud _DatosSolicitud;
        public Solicitud DatosSolicitud
        {
            get { return _DatosSolicitud; }
            set { _DatosSolicitud = value; }
        }
        private frmWait Espere = new frmWait();

        #endregion

        #region Constructor

        public frmConfirmarVenta(Solicitud Datos, int TipoF)
        {
            try
            {
                InitializeComponent();
                this._DatosSolicitud = Datos;
                this.TipoForm = TipoF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmConfirmarVenta");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Del Formulario

        private void frmConfirmarVenta_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Confirmar Venta";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmConfirmarVenta_Load");
            }
        }

        #endregion

        #region Evento Click

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
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    Solicitud Datos = this.ObtenerDatosSolicitud();
                    sn.ActualizarDatosFechasPago(Datos);
                    if (Datos.Validador)
                    {                        
                        MessageBox.Show("Datos actualizados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sn.ObtenerEsEmpresa(Datos);
                        if (!Datos.EsEmpresa)
                        {
                            try
                            {
                                this.bgwEnvioCorreo.RunWorkerAsync(Datos);
                                Espere.ShowDialog();
                            }
                            catch (Exception ax)
                            {
                                Comun_Negocio.AddExcFileTxt(ax, "EnvioCorreo_confirmarVenta");
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("No se pudo actualizar la información. Verifique que el monto de la cotización sea mayor a 0. Intente Nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarCombo()
        {
            try
            {
                Solicitud Aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Aux.IDSolicitud = this._DatosSolicitud.IDSolicitud;
                Aux.Conexion = Comun.Conexion;
                Aux.Opcion = 1;
                this.cmbCotizacion.DataSource = sn.ObtenerCotizacionesXIDSolicitud(Aux);
                this.cmbCotizacion.DisplayMember ="Descripcion";
                this.cmbCotizacion.ValueMember = "IDCotizacion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool EnviarCorreo(Solicitud aux)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosCorreo = new Solicitud();
                datosCorreo = sn.ObtenerDatosCorreoConfirmaCompra(aux);
                string contenido = EnvioCorreo.GenerarHtmlConfirmacionCompra(datosCorreo);
                return EnvioCorreo.EnviarCorreo(
                                         ConfigurationManager.AppSettings.Get("CorreoTxt")
                                        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                                        , datosCorreo.Cliente.CorreoElectronico
                                        , "Confirmación de compra - " + datosCorreo.NombreProducto
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

        private bool ExisteItemEnCombo(string IDCotizacion)
        {
            try
            {
                bool band = false;
                foreach (Cotizacion item in this.cmbCotizacion.Items)
                {
                    if (item.IDCotizacion == IDCotizacion)
                    {
                        band = true;
                        break;
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatos()
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datos = new Solicitud();
                datos.Conexion = Comun.Conexion;
                datos.IDSolicitud = this._DatosSolicitud.IDSolicitud;
                datos = sn.ObtenerDatosSolicitudFechasPago(datos);
                
                if (this.ExisteItemEnCombo(datos.IDCotizacion))
                {
                    this.cmbCotizacion.SelectedValue = datos.IDCotizacion;
                }
                if (datos.FechaLimPagoInicial != null)
                {
                    DateTime FechaInicial = DateTime.Parse(datos.FechaLimPagoInicial.ToShortDateString());
                    if (FechaInicial < DateTime.Today)
                        this.dtpFechaLimPagoInicial.Value = DateTime.Today;
                    else
                        this.dtpFechaLimPagoInicial.Value = FechaInicial;
                }
                else
                {
                    this.dtpFechaLimPagoInicial.Value = DateTime.Today;
                }
                if (datos.FechaLimPagoFinal != null)
                {
                    DateTime FechaFinal = DateTime.Parse(datos.FechaLimPagoFinal.ToShortDateString());
                    if (FechaFinal < DateTime.Today)
                        this.dtpFechaLimPagoFinal.Value = DateTime.Today;
                    else
                        this.dtpFechaLimPagoFinal.Value = FechaFinal;
                }
                else
                {
                    this.dtpFechaLimPagoFinal.Value = DateTime.Today;
                }
                this.chkRequiereFactura.Checked = datos.RequiereFactura;
                this.txtFolioSolicitud.Text = datos.Folio;
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
                this.CargarCombo();
                this.IniciarDatos();
                this.ActiveControl = this.cmbCotizacion;
                this.cmbCotizacion.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Cotizacion ObtenerCotizacionSeleccionada()
        {
            try
            {
                Cotizacion Seleccionada = new Cotizacion();
                if (this.cmbCotizacion.Items.Count > 0)
                {
                    if (this.cmbCotizacion.SelectedIndex != -1)
                    {
                        Seleccionada = (Cotizacion)this.cmbCotizacion.SelectedItem;
                    }
                }
                return Seleccionada;
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
                Solicitud Datos = new Solicitud();
                Datos.Opcion = 1;
                Datos.Conexion = Comun.Conexion;
                Datos.IDUsuario = Comun.IDUsuario;
                Datos.IDCaja = Comun.IDCaja;
                Datos.IDSucursal = Comun.IDSucursalCaja;
                Datos.IDSolicitud = this._DatosSolicitud.IDSolicitud;
                Datos.IDCotizacion = this.ObtenerCotizacionSeleccionada().IDCotizacion;
                Datos.FechaLimPagoInicial = this.dtpFechaLimPagoInicial.Value;
                Datos.FechaLimPagoFinal = this.dtpFechaLimPagoFinal.Value;
                Datos.RequiereFactura = this.chkRequiereFactura.Checked;
                return Datos;
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
                if(string.IsNullOrEmpty(this.ObtenerCotizacionSeleccionada().IDCotizacion))
                {
                    errores.Add(1, "Seleccione una Cotización. ");
                }
                switch (this.ValidarFechas())
                {
                    case 1: errores.Add(2, "La fecha Límite de Pago Inicial no puede ser menor a la fecha actual. ");
                        break;
                    case 2: errores.Add(2, "La fecha Límite de Pago Final no puede ser menor a la fecha Límite de Pago Inicial. ");
                        break;
                    default:
                        break;
                }
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarFechas()
        {
            try
            {
                DateTime FechaInicio = DateTime.Parse(this.dtpFechaLimPagoInicial.Value.ToShortDateString());
                DateTime FechaFinal = DateTime.Parse(this.dtpFechaLimPagoFinal.Value.ToShortDateString());

                if (FechaInicio < DateTime.Today)
                    return 1;
                else
                {
                    if (FechaFinal < FechaInicio)
                        return 2;
                    else
                        return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
