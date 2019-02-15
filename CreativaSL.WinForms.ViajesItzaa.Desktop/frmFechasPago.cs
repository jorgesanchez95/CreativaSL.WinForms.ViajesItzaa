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

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmFechasPago : Form_Creativa
    {
        public frmFechasPago()
        {
            InitializeComponent();
        }

        #region Variables

        private int TipoForm = 0;
        private Solicitud _DatosSolicitud;

        public Solicitud DatosSolicitud
        {
            get { return _DatosSolicitud; }
            set { _DatosSolicitud = value; }
        }
        
        #endregion

        #region Constructor

        public frmFechasPago(Solicitud Datos, int TipoF)
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
                Comun_Negocio.AddExcFileTxt(ex, "frmFechasPago");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Del Formulario

        private void frmFechasPago_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cambiar Fechas de Pago";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmFechasPago_Load");
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
                    sn.ActualizarDatosFechasLimPago(Datos);
                    if (Datos.Validador)
                    {
                        MessageBox.Show("Datos actualizados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("No se pudo actualizar la información. Intente Nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void IniciarDatos()
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datos = new Solicitud();
                datos.Conexion = Comun.Conexion;
                datos.IDSolicitud = this._DatosSolicitud.IDSolicitud;
                datos = sn.ObtenerDatosSolicitudFechasPago(datos);
                if (datos.FechaLimPagoInicial != null)
                    this.dtpFechaLimPagoInicial.Value = datos.FechaLimPagoInicial;
                else
                    this.dtpFechaLimPagoInicial.Value = DateTime.Today;
                if (datos.FechaLimPagoFinal != null)
                    this.dtpFechaLimPagoFinal.Value = datos.FechaLimPagoFinal;
                else
                    this.dtpFechaLimPagoFinal.Value = DateTime.Today;
                this.txtFolioSolicitud.Text = datos.Folio;
                if (this._DatosSolicitud.IDStatusSolicitud == 7)
                {
                    this.dtpFechaLimPagoInicial.Enabled = false;
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
                this.IniciarDatos();
                if (this._DatosSolicitud.IDStatusSolicitud == 7)
                {
                    this.ActiveControl = this.dtpFechaLimPagoFinal;
                    this.dtpFechaLimPagoFinal.Focus();
                }
                else
                {
                    this.ActiveControl = this.dtpFechaLimPagoInicial;
                    this.dtpFechaLimPagoInicial.Focus();
                }
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
                Datos.IDSolicitud = this._DatosSolicitud.IDSolicitud;
                Datos.FechaLimPagoInicial = this.dtpFechaLimPagoInicial.Value;
                Datos.FechaLimPagoFinal = this.dtpFechaLimPagoFinal.Value;
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
                if (this._DatosSolicitud.IDStatusSolicitud >= 5 &&  this._DatosSolicitud.IDStatusSolicitud <= 6)
                {
                    if (!this.ValidarFechas(this.dtpFechaLimPagoInicial.Value))
                        errores.Add(1, "La fecha límite de pago Inicial no puede ser menor a la fecha actual.");
                }
                if (!this.ValidarFechas(this.dtpFechaLimPagoFinal.Value))
                    errores.Add(2, "La fecha límite de pago Final no puede ser menor a la fecha actual.");
                if (!this.ValidarFechas())
                    errores.Add(3, "La fecha límite de pago Final no puede ser menor a la fecha límite de pago Inicial.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFechas()
        {
            try
            {
                DateTime FechaInicio = DateTime.Parse(this.dtpFechaLimPagoInicial.Value.ToShortDateString(), CultureInfo.CurrentCulture);
                DateTime FechaFinal = DateTime.Parse(this.dtpFechaLimPagoFinal.Value.ToShortDateString(), CultureInfo.CurrentCulture);
                if (FechaFinal < FechaInicio)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFechas(DateTime fecha)
        {
            try
            {
                if (fecha < DateTime.Today)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
