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
    public partial class frmCaja_AperturaCaja : Form_Creativa
    {
        #region Constructor

        public frmCaja_AperturaCaja()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCaja_AperturaCaja");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.GuardarAperturaCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "BtnContinuar_Click");
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
                this.txtTotal.Text = string.Format("{0:c}", this.CalcularTotal());
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

        private void frmCaja_AperturaCaja_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Apertura de Caja";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCaja_AperturaCaja_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Metodos

        private void Inicializar()
        {
            try
            {
                this.InicializarTextbox();
                this.TxtNomCajero.Text = Comun.NombreUsuario + " " + Comun.ApellidoPaternoUsuario + " " + Comun.ApellidoMaternoUsuario;
                this.TxtFecha.Text = DateTime.Now.ToShortDateString();
                this.TxtHora.Text = DateTime.Now.ToString("HH:mm:ss"); //HH FORMAT 24 HOURS
                this.TxtB1000P.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GuardarAperturaCaja()
        {
            try
            {
                Caja caja = new Caja(Comun.Conexion);
                caja = this.ObtenerDatos();
                Caja_Negocio caja_negocio = new Caja_Negocio();
                int verificador = caja_negocio.GuardarAperturaCaja(caja);
                if (verificador == 0)
                {
                    MessageBox.Show("Ocurrió un error al guardar los datos. Intente nuevamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
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
                this.InicializarTextbox();
                Caja caja = new Caja(Comun.Conexion);
                caja.IDCaja = Comun.IDCaja;
                caja.IDCajaCat = Comun.IDCajaCat;
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
                caja.Apertura = this.CalcularTotal();
                caja.IDUsuario = Comun.IDUsuario;
                caja.FechaIngreso = this.TxtFecha.Text;
                caja.HoraIngreso = this.TxtHora.Text;
                caja.IDSucursal = Comun.IDSucursalCaja;
                return caja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
                centavos = (decimal)(m50c * 0.5);
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
                if (this.txtTotal.Text == "" || this.txtTotal.Text == string.Empty)
                    this.txtTotal.Text = "0";
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