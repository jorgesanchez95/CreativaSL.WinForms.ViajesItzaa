﻿using System;
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
using System.Globalization;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmPagoInicial : Form_Creativa
    {
        #region Variables / Propiedades

        private Solicitud Datos = new Solicitud();
        private Pago DatosPago = new Pago();

        #endregion

        #region Constructor

        public frmPagoInicial(Solicitud Aux)
        {
            try
            {
                InitializeComponent();
                Datos = Aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPagoInicial");
            }
        }

        #endregion

        #region Eventos

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
                    validar.PermitirSoloNumerosDecimales(e, this.txtMontoAPagar.Text);
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
                decimal.TryParse(this.txtMontoAPagar.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out monto);
                this.txtMontoAPagar.Text = string.Format("{0:c}", monto);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Validating");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmPagoInicial_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Pago Inicial";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmPagoInicial_Load");
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
                    Pago Aux = this.ObtenerDatosPago();
                    frmCobro cobrar = new frmCobro(Aux);
                    cobrar.ShowDialog();
                    cobrar.Dispose();
                    this.DialogResult = cobrar.DialogResult;
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
        
        private void IniciarForm()
        {
            try
            {
                this.IniciarDatosForm();
                this.ActiveControl = this.txtMontoAPagar;
                this.txtMontoAPagar.Focus();
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
                Pago_Negocio pagneg = new Pago_Negocio();
                Solicitud Aux = new Solicitud();
                Aux.IDSolicitud = this.Datos.IDSolicitud;
                Aux.IDSucursal = Comun.IDSucursalCaja;
                Aux.Conexion = Comun.Conexion;
                DatosPago = pagneg.ObtenerDatosPagoInicial(Aux);
                this.LlenarDatos();
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
                this.txtFolioSolicitud.Text = Datos.Folio;
                if (string.IsNullOrEmpty(DatosPago.IDCotizacion))
                {
                    this.txtMontoTotal.Text = string.Format("{0:c}", 0);
                    this.txtMontoInicial.Text = string.Format("{0:c}", 0);
                    this.txtMontoAnticipo.Text = string.Format("{0:c}", 0);
                    this.lblMontoAnticipo.Text = "Monto Anticipo 0%:";
                    this.txtMinimoaPagar.Text = string.Format("{0:c}", 0);
                    this.txtMontoAPagar.Text = string.Format("{0:c}", 0);
                }
                else
                {
                    this.txtMontoTotal.Text = string.Format("{0:c}", DatosPago.MontoTotal);
                    this.txtMontoInicial.Text = string.Format("{0:c}", DatosPago.MontoInicial);
                    this.txtMontoAnticipo.Text = string.Format("{0:c}", DatosPago.MontoAnticipo);
                    this.lblMontoAnticipo.Text = "Monto Anticipo (" + string.Format("{0:F2}", DatosPago.PorcentajeAnticipo) + "%):";
                    this.txtMinimoaPagar.Text = string.Format("{0:c}", DatosPago.MontoMinimoPago);
                    this.txtMontoAPagar.Text = string.Format("{0:c}", 0);
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

        private Pago ObtenerDatosPago()
        {
            try
            {
                Pago Aux = new Pago();
                Aux.IDSolicitud = Datos.IDSolicitud;
                Aux.MontoAPagar = this.ObtenerMontoAPagar();
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerMontoAPagar()
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMontoAPagar.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out aux);
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
                decimal MontoAPagar = this.ObtenerMontoAPagar();
                if (MontoAPagar <= 0)
                    errores.Add(1, "El monto a pagar debe ser mayor a 0.");
                if (MontoAPagar < DatosPago.MontoMinimoPago)
                    errores.Add(2, "El monto a pagar no cubre el mínimo de pago.");
                if(MontoAPagar + DatosPago.MontoInicial > DatosPago.MontoTotal)
                    errores.Add(3, "El monto a pagar más el monto inicial no puede ser mayor a " + string.Format("{0:c}", DatosPago.MontoTotal));
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
