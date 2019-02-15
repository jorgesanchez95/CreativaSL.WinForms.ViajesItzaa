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
using System.Threading;
using System.Globalization;
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmDepositosRetiros : Form_Creativa
    {

        #region Declaración de variables

        int TipoForm = 0;

        #endregion

        #region Constructor

        public frmDepositosRetiros(int op)
        {
            try
            {
                InitializeComponent();
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
                TipoForm = op;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDepositosRetiros");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Métodos

        private void Iniciar()
        {
            try
            {
                this.TipoFormDatos();
                this.ActiveControl = this.txtMonto;
                this.txtMonto.Text = string.Format("{0:F2}", 0);
                this.txtMonto.Focus();
                this.txtMonto.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError(int error)
        {
            try
            {
                string mensaje = "";
                switch (error)
                {
                    case 1: mensaje = "Ingrese un dato válido y mayor a 0.";
                        this.ActiveControl = this.txtMonto;
                        this.txtMonto.Focus();
                        break;
                    case 2: mensaje = "Ingrese concepto.";
                        this.ActiveControl = this.txtConcepto;
                        this.txtConcepto.Focus();
                        break;
                    default: break;
                }
                this.txt_mensajeError.Visible = true;
                this.txt_mensajeError.Text = mensaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DepositoRetiro ObtenerDatos()
        {
            try
            {
                DepositoRetiro movimiento = new DepositoRetiro();
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                movimiento.IDUsuario = Comun.IDUsuario;
                movimiento.IDCaja = Comun.IDCaja;
                movimiento.Conexion = Comun.Conexion;
                movimiento.IDSucursal = Comun.IDSucursalCaja;
                movimiento.IDDepositoRetiro = string.Empty;
                movimiento.Opcion = 1;
                movimiento.IDTipoDepositoRetiro = this.TipoForm;
                movimiento.Monto = monto;
                movimiento.Motivo = this.txtConcepto.Text;
                return movimiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PermitirSoloNumerosDecimales(KeyPressEventArgs e, string cadena)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (e.KeyChar == (char)'.')
                        {
                            if (cadena.IndexOf('.') == -1)
                                e.Handled = false;
                            else
                                e.Handled = true;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TipoFormDatos()
        {
            try
            {
                switch (TipoForm)
                {
                    case 1:
                        this.Text = Comun.CaptionSystem + " - Depósito";
                        panelDeposito.Title = "Depósito de Efectivo a Caja";
                        break;
                    case 2:
                        this.Text = Comun.CaptionSystem + " - Retiro";
                        panelDeposito.Title = "Retiro de Efectivo";
                        //this.txtConcepto.Visible = false;
                        //this.label2.Visible = false;
                        this.txtConcepto.ReadOnly = true;
                        this.txtConcepto.Text = "Retiro por caja llena";
                        break;
                    case 3:
                        this.Text = Comun.CaptionSystem + " - Retiro";
                        panelDeposito.Title = "Retiro de Efectivo, por concepto de pago";
                        break;
                }
                this.txtMonto.Text = string.Format("{0:F2}", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarDatos()
        {
            try
            {
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                if (monto <= 0)
                    return 1;
                if (string.IsNullOrEmpty(this.txtConcepto.Text) || string.IsNullOrWhiteSpace(this.txtConcepto.Text))
                    return 2;
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensajeError.Visible = false;
                int error = this.ValidarDatos();
                if (error == 0)
                {
                    DepositoRetiro movimiento = new DepositoRetiro();
                    movimiento = this.ObtenerDatos();
                    Caja_Negocio cajneg = new Caja_Negocio();
                    switch (TipoForm)
                    {
                        case 1: //deposito
                            cajneg.AgregarDeposito(movimiento);
                            break;
                        case 2: //retiro caja llena
                            movimiento.IDTipoDepositoRetiro = 1;
                            cajneg.AgregarRetiro(movimiento);
                            break;
                        case 3: //retiro pago
                            movimiento.IDTipoDepositoRetiro = 2;
                            cajneg.AgregarRetiro(movimiento);
                            break;
                    }
                    if (movimiento.Validador)
                    {
                        MessageBox.Show("Se ha agregado correctamento el movimiento. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el movimiento. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    this.MostrarMensajeError(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
                this.DialogResult = DialogResult.Abort;
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
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void frmDepositosRetiros_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 27)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "frmDepositosRetiros_KeyUp");
            }
        }

        private void frmDepositosRetiros_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.Iniciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDepositosRetiros_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    this.btnAceptar_Click(this.btnAceptar, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtConcepto_KeyPress");
            }
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtMonto.SelectAll();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Enter");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (TipoForm == 2)
                        this.btnAceptar_Click(this.btnAceptar, new EventArgs());
                    else
                    {
                        this.txtConcepto.Focus();
                        this.txtConcepto.SelectAll();
                    }
                }
                else
                    this.PermitirSoloNumerosDecimales(e, this.txtMonto.Text);
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
                decimal aux = 0;
                decimal.TryParse(this.txtMonto.Text, out aux);
                this.txtMonto.Text = string.Format("{0:F2}", aux);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Validating");
            }
        }

        #endregion

    }
}
