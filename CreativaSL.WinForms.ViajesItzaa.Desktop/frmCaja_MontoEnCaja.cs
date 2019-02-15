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
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCaja_MontoEnCaja : Form_Creativa
    {
        #region Constructor

        public frmCaja_MontoEnCaja()
        {
            try
            {
                InitializeComponent();
                this.InicializarTextbox();
                this.ActiveControl = this.TxtVales;
                this.TxtVales.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCaja_MontoEnCaja");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                this.GuardarMontoEnCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "BtnSiguiente_Click");
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void cajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.PermitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cajas_KeyPress");
            }
        }

        private void cajas_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.TxtTotal.Text = string.Format("{0:c}", this.CalcularTotal());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cajas_KeyUp");
            }
        }

        private void txtNotNull_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                int aux = 0;
                int.TryParse(txt.Text, out aux);
                txt.Text = aux.ToString();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNotNull_Validating");
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

        private void frmCaja_MontoEnCaja_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cierre de Caja";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCaja_MontoEnCaja_Load");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion

        #region Metodos

        private decimal CalcularTotal()
        {
            try
            {
                // Declaración de variables
                decimal centavos = 0, total = 0;
                int m50c, m1p, m2p, m5p, m10p, m20p, m100p, b20p, b50p, b100p, b200p, b500p, b1000p;
                m1p = m50c = m2p = m5p = m10p = m20p = m100p = b20p = b50p = b100p = b200p = b500p = b1000p = 0;
                // Obtener cantidades por denominación
                int.TryParse(this.TxtM1P.Text, out m1p);
                int.TryParse(this.TxtM2P.Text, out m2p);
                int.TryParse(this.TxtM5P.Text, out m5p);
                int.TryParse(this.TxtM10P.Text, out m10p);
                int.TryParse(this.TxtM20P.Text, out m20p);
                int.TryParse(this.TxtM100P.Text, out m100p);
                int.TryParse(this.TxtB20P.Text, out b20p);
                int.TryParse(this.TxtB50P.Text, out b50p);
                int.TryParse(this.TxtB100P.Text, out b100p);
                int.TryParse(this.TxtB200P.Text, out b200p);
                int.TryParse(this.TxtB500P.Text, out b500p);
                int.TryParse(this.TxtB1000P.Text, out b1000p);
                int.TryParse(this.TxtM50C.Text, out m50c);
                // Obtener Monto de los centavos
                centavos = (decimal)(m50c * 0.5F);
                // Calcular Monto Total
                total = centavos + m1p + (m2p * 2) +
                    (m5p * 5) + (m10p * 10) +
                    ((m20p + b20p) * 20) +
                    ((m100p + b100p) * 100) +
                    (b50p * 50) + (b200p * 200) +
                    (b500p * 500) + (b1000p * 1000);
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GuardarMontoEnCaja()
        {
            try
            {
                Caja caja = new Caja(Comun.Conexion);
                Caja_Negocio cajaNegocio = new Caja_Negocio();
                caja = this.ObtenerDatos();
                if (cajaNegocio.GuardarMontoTotalEnCaja(caja) == 1)
                {
                    MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Error al guardar los datos. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarTextbox()
        {
            try
            {
                if (this.TxtM50C.Text == "" || this.TxtM50C.Text == string.Empty)
                    this.TxtM50C.Text = "0";
                if (this.TxtM1P.Text == "" || this.TxtM1P.Text == string.Empty)
                    this.TxtM1P.Text = "0";
                if (this.TxtM2P.Text == "" || this.TxtM2P.Text == string.Empty)
                    this.TxtM2P.Text = "0";
                if (this.TxtM5P.Text == "" || this.TxtM5P.Text == string.Empty)
                    this.TxtM5P.Text = "0";
                if (this.TxtM10P.Text == "" || this.TxtM10P.Text == string.Empty)
                    this.TxtM10P.Text = "0";
                if (this.TxtM20P.Text == "" || this.TxtM20P.Text == string.Empty)
                    this.TxtM20P.Text = "0";
                if (this.TxtM100P.Text == "" || this.TxtM100P.Text == string.Empty)
                    this.TxtM100P.Text = "0";
                if (this.TxtB20P.Text == "" || this.TxtB20P.Text == string.Empty)
                    this.TxtB20P.Text = "0";
                if (this.TxtB50P.Text == "" || this.TxtB50P.Text == string.Empty)
                    this.TxtB50P.Text = "0";
                if (this.TxtB100P.Text == "" || this.TxtB100P.Text == string.Empty)
                    this.TxtB100P.Text = "0";
                if (this.TxtB200P.Text == "" || this.TxtB200P.Text == string.Empty)
                    this.TxtB200P.Text = "0";
                if (this.TxtB500P.Text == "" || this.TxtB500P.Text == string.Empty)
                    this.TxtB500P.Text = "0";
                if (this.TxtB1000P.Text == "" || this.TxtB1000P.Text == string.Empty)
                    this.TxtB1000P.Text = "0";
                if (this.TxtTickets.Text == "" || this.TxtTickets.Text == string.Empty)
                    this.TxtTickets.Text = "0";
                if (this.TxtVales.Text == "" || this.TxtVales.Text == string.Empty)
                    this.TxtVales.Text = "0";
                if (this.TxtTotal.Text == "" || this.TxtTotal.Text == string.Empty)
                    this.TxtTotal.Text = "0";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Caja ObtenerDatos()
        {
            try
            {
                Caja caja = new Caja(Comun.Conexion);
                this.InicializarTextbox();
                caja.IDCaja = Comun.IDCaja;
                caja.Tickets = Convert.ToInt32(this.TxtTickets.Text);
                caja.Vales = Convert.ToInt32(this.TxtVales.Text);
                caja.M50C = Convert.ToInt32(this.TxtM50C.Text);
                caja.M1P = Convert.ToInt32(this.TxtM1P.Text);
                caja.M2P = Convert.ToInt32(this.TxtM2P.Text);
                caja.M5P = Convert.ToInt32(this.TxtM5P.Text);
                caja.M10P = Convert.ToInt32(this.TxtM10P.Text);
                caja.M20P = Convert.ToInt32(this.TxtM20P.Text);
                caja.M100P = Convert.ToInt32(this.TxtM100P.Text);
                caja.B20P = Convert.ToInt32(this.TxtB20P.Text);
                caja.B50P = Convert.ToInt32(this.TxtB50P.Text);
                caja.B100P = Convert.ToInt32(this.TxtB100P.Text);
                caja.B200P = Convert.ToInt32(this.TxtB200P.Text);
                caja.B500P = Convert.ToInt32(this.TxtB500P.Text);
                caja.B1000P = Convert.ToInt32(this.TxtB1000P.Text);
                caja.Cierre = this.CalcularTotal();
                caja.IDUsuario = Comun.IDUsuario;
                caja.IDSucursal = Comun.IDSucursalCaja;
                return caja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PermitirSoloNumeros(KeyPressEventArgs e)
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
                        e.Handled = true;
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
