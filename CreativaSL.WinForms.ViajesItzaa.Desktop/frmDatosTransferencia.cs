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
using System.Threading;
using System.Globalization;
using System.Collections;
using System.IO;


namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmDatosTransferencia : Form_Creativa
    {

        #region Variables

        private FormaPago _datos;
        public FormaPago datos
        {
            get { return _datos; }
            set { _datos = value; }
        }
        int opcion = 0;

        #endregion

        #region Constructor

        public frmDatosTransferencia()
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosTransferencia");
            }
        }

        public frmDatosTransferencia(FormaPago fp, int op)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-MX");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");
                InitializeComponent();
                datos = fp;
                opcion = op;
                this.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosTransferencia");
            }
        }

        #endregion

        #region Eventos

        #region Evento Click

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = new Hashtable();
                errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.ObtenerDatos();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.MostrarMensajeError(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptar_Click");
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
            }
        }

        #endregion

        #region Eventos KeyPress

        private void cmbBancos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.txtMonto.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbBancos_KeyPress");
            }
        }

        private void txtIFE_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.cmbBancos.Focus();
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.SoloTexto(e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtIFE_KeyPress");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.btnAceptar_Click(null, null);
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.PermitirSoloNumerosDecimales(e, this.txtMonto.Text);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_KeyPress");
            }
        }

        private void txtNumAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.cmbBancos.Focus();
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.SoloNumerico(e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNumAutorizacion_KeyPress");
            }
        }

        #endregion

        #region Evento Load

        private void frmDatosCheque_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Datos Transferencia";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosCheque_Load (Transferencia)");
            }
        }

        #endregion

        #region Eventos Validating

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

        private void txtNumCheque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ValidarFolioTransaccion()) //Si el folio de transaccion ya existe, informar.
                {
                    this.txt_mensaje.Visible = true;
                    this.txt_mensaje.Text = "El folio de transacción ya ha sido ingresado previamente. Verifique la información.";
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNumCheque_Validating");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarComboBancos()
        {
            try
            {
                Banco_Negocio bn = new Banco_Negocio();
                Banco datos = new Banco();
                datos.Conexion = Comun.Conexion;
                List<Banco> bancos = bn.LlenarComboBancos(datos);
                this.cmbBancos.DisplayMember = "NombreBanco";
                this.cmbBancos.ValueMember = "IDBanco";
                this.cmbBancos.DataSource = bancos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarDatos()
        {
            try
            {
                if (opcion == 1)
                {
                    if (datos != null)
                    {
                        this.txtNumCheque.Text = datos.Autorizacion;
                        this.cmbBancos.SelectedItem = datos.BancoAux;
                        this.txtMonto.Text = string.Format("{0:F2}", datos.Monto);
                    }
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
                this.CargarComboBancos();
                this.ActiveControl = this.txtNumCheque;
                this.txtNumCheque.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError(Hashtable errores)
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
                if (this.cmbBancos.SelectedIndex == -1)
                    datos.BancoAux = new Banco();
                else
                {
                    Banco banco = new Banco();
                    banco = (Banco)this.cmbBancos.SelectedItem;
                    if (banco.IDBanco == 0)
                        datos.BancoAux = new Banco();
                    else
                        datos.BancoAux = banco;
                }
                if (string.IsNullOrEmpty(this.txtNumCheque.Text))
                    datos.Autorizacion = string.Empty;
                else
                    datos.Autorizacion = this.txtNumCheque.Text;
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                datos.Monto = monto;
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
                if (this.cmbBancos.SelectedIndex == -1)
                    errores.Add(1, "Seleccione una banco de la lista. ");
                else
                {
                    Banco banco = new Banco();
                    banco = (Banco)this.cmbBancos.SelectedItem;
                    if (banco.IDBanco == 0)
                        errores.Add(1, "Seleccione una banco de la lista. ");
                }
                if (string.IsNullOrEmpty(this.txtNumCheque.Text))
                    errores.Add(2, "Ingrese el número de autorización. ");
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                if (monto <= 0)
                    errores.Add(4, "Ingrese un monto válido mayor a " + string.Format("{0:c}", 0) + ".");
                else
                    if (opcion == 0)
                    {
                        if (monto > datos.Monto)
                        {
                            errores.Add(4, "Ingrese un monto menor a " + string.Format("{0:c}", datos.Monto) + ".");
                        }
                    }
                if (this.ValidarFolioTransaccion())
                    errores.Add(5, "El folio de transacción ya ha sido ingresado previamente. Verifique la información.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFolioTransaccion()
        {
            try
            {
                //Busqueda datos = new Busqueda(Comun.Conexion);
                //Busqueda_Negocio bn = new Busqueda_Negocio();
                //datos = bn.ValidarFolioTransferencia(this.txtNumCheque.Text, datos.strcnx);
                //return datos.Validador;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
