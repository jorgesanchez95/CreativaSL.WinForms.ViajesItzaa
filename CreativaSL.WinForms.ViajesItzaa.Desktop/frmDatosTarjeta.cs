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
    public partial class frmDatosTarjeta : Form_Creativa
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

        public frmDatosTarjeta()
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
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosTarjeta");
            }
        }

        public frmDatosTarjeta(FormaPago fp, int op)
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
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosTarjeta");
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
                    this.txtNumTarjeta.Focus();
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.SoloNumerico(e);
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
                    this.btnAceptar.Focus();
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
                    this.cmbDocumento.Focus();
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

        private void cmbDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.txtDNI.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbDocumento_KeyPress");
            }
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
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
                Comun_Negocio.AddExcFileTxt(ex, "txtNumTarjeta_KeyPress");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmDatosTarjeta_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Datos Tarjeta";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosTarjeta_Load");
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

        #endregion

        #region Eventos ComboBox

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string maskLicencia = "";
                string maskINE = "0000000000000";
                string maskCedula = "0000000";

                if (cmbDocumento.SelectedIndex != -1)
                {
                    TipoDocumento td = new TipoDocumento();
                    td = (TipoDocumento)this.cmbDocumento.SelectedItem;
                    if (td.IDTipoDocumento != 0)
                    {
                        switch (td.IDTipoDocumento)
                        {
                            case 1:
                                this.txtDNI.Mask = maskINE;
                                break;
                            case 2:
                                this.txtDNI.Mask = maskLicencia;
                                break;
                            case 3:
                                this.txtDNI.Mask = maskCedula;
                                break;
                            default:
                                this.txtDNI.Mask = string.Empty;
                                break;
                        }
                    }
                }
                else
                {
                    this.txtDNI.Mask = string.Empty;
                }

            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbDocumento_SelectedIndexChanged");
            }
        }

        private void cmbDocumento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (cmbDocumento.SelectedIndex == -1)
                {
                    this.txtDNI.Mask = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbDocumento_SelectedIndexChanged");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                this.CargarComboBancos();
                this.LlenarComboDocumentos();
                this.ActiveControl = this.txtNumAutorizacion;
                this.txtNumAutorizacion.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        private void LlenarComboDocumentos()
        {
            try
            {
                TipoDocumento datos = new TipoDocumento();
                TipoDocumento_Negocio tn = new TipoDocumento_Negocio();
                datos.Conexion = Comun.Conexion;
                this.cmbDocumento.ValueMember = "IDTipoDocumento";
                this.cmbDocumento.DisplayMember = "Descripcion";
                this.cmbDocumento.DataSource = tn.LlenarComboDocumentos(datos);
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
                        this.txtDNI.Text = datos.FolioIFE;
                        this.txtNumAutorizacion.Text = datos.Autorizacion;
                        this.cmbBancos.SelectedItem = datos.BancoAux;
                        this.txtMonto.Text = string.Format("{0:F2}", datos.Monto);
                        this.txtMonto.ReadOnly = true;
                    }
                    else
                    {
                        datos = new FormaPago();
                    }
                }
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
                Validaciones val = new Validaciones();
                if (string.IsNullOrEmpty(this.txtNumAutorizacion.Text))
                    errores.Add(1, "Ingrese el número de autorización. ");
                if (this.cmbDocumento.SelectedIndex == -1)
                    errores.Add(2, "Seleccione un tipo de Identificación. ");
                else
                {
                    TipoDocumento td = new TipoDocumento();
                    td = (TipoDocumento)this.cmbDocumento.SelectedItem;
                    if (td.IDTipoDocumento == 0)
                        errores.Add(2, "Seleccione un tipo de Identificación. ");
                }

                if (string.IsNullOrEmpty(this.txtDNI.Text) || string.IsNullOrWhiteSpace(this.txtDNI.Text))
                    errores.Add(3, "Ingrese el núm. de Identificación. ");
                else
                {
                    TipoDocumento td = new TipoDocumento();
                    td = (TipoDocumento)this.cmbDocumento.SelectedItem;
                    if (!(td.IDTipoDocumento == 0))
                    {
                        switch (td.IDTipoDocumento)
                        {
                            case 1:
                                if (!val.ValidarIFE(this.txtDNI.Text))
                                    errores.Add(3, "Núm. de INE no válido.");
                                break;
                            case 2:
                                if (!val.ValidarLicenciaConducir(this.txtDNI.Text))
                                    errores.Add(3, "Núm. de Licencia no válido.");
                                break;
                            case 3:
                                if (!val.ValidarCedulaProfesional(this.txtDNI.Text))
                                    errores.Add(3, "Núm. de Cédula Profesional no válido.");
                                break;
                        }
                    }
                }

                if (string.IsNullOrEmpty(this.txtNumTarjeta.Text) || string.IsNullOrWhiteSpace(this.txtNumTarjeta.Text))
                    errores.Add(4, "Ingrese el núm. de la tarjeta. ");
                else
                {
                    if (!val.ValidarTarjetaCreditoDebito(this.txtNumTarjeta.Text))
                        errores.Add(4, "El número de la tarjeta no es correcto. ");
                }
                if (this.cmbBancos.SelectedIndex == -1)
                    errores.Add(5, "Seleccione una banco de la lista. ");
                else
                {
                    Banco banco = new Banco();
                    banco = (Banco)this.cmbBancos.SelectedItem;
                    if (banco.IDBanco == 0)
                        errores.Add(5, "Seleccione una banco de la lista. ");
                }
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                if (monto <= 0)
                    errores.Add(6, "Ingrese un monto válido mayor a 0. ");
                else
                    if (opcion == 0)
                    {
                        if (monto > datos.Monto)
                        {
                            errores.Add(6, "Ingrese un monto menor o igual a " + string.Format("{0:c}", datos.Monto) + ".");
                        }
                    }
                return errores;
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
                datos = new FormaPago();
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
                if (this.cmbDocumento.SelectedIndex == -1)
                    datos.TipoDocumentoAux = new TipoDocumento();
                else
                {
                    TipoDocumento td = new TipoDocumento();
                    td = (TipoDocumento)this.cmbDocumento.SelectedItem;
                    if (td.IDTipoDocumento == 0)
                        datos.TipoDocumentoAux = new TipoDocumento();
                    else
                        datos.TipoDocumentoAux = td;
                }
                if (string.IsNullOrEmpty(this.txtNumAutorizacion.Text))
                    datos.Autorizacion = string.Empty;
                else
                    datos.Autorizacion = this.txtNumAutorizacion.Text;
                if (string.IsNullOrEmpty(this.txtDNI.Text) || string.IsNullOrWhiteSpace(this.txtDNI.Text))
                    datos.FolioIFE = string.Empty;
                else
                    datos.FolioIFE = this.txtDNI.Text;
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                datos.Monto = monto;
                if (string.IsNullOrEmpty(this.txtNumTarjeta.Text) || string.IsNullOrWhiteSpace(this.txtNumTarjeta.Text))
                    datos.NumTarjeta = string.Empty;
                else
                    datos.NumTarjeta = this.txtNumTarjeta.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
