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
using System.Configuration;
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmAsignarCaja : Form_Creativa
    {        

        #region Constructor

        public frmAsignarCaja()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarCaja");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Métodos

        private void CargarCombos()
        {
            try
            {
                this.LLenarComboCajas();
                this.LlenarComboSucursales();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GuardarMac()
        {
            try
            {
                int Verificador = 0;
                Caja_Negocio cajaNegocio = new Caja_Negocio();
                Caja caja = new Caja(Comun.Conexion);
                this.ObtenerDatos(caja);
                if (string.IsNullOrEmpty(Comun.MACAddress))
                    caja.Opcion = 0;
                else
                    caja.Opcion = 1;
                Verificador = cajaNegocio.AsignarCajaMAC(caja);
                if (Verificador == 1)
                {                    
                    MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("No se pudo actualizar la información. Es probable que la dirección MAC ya esté registrada.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Inicializar()
        {
            try
            {
                this.CargarCombos();
                this.mktxtMac.Text = Comun.MACAddress;
                this.txtNombreCaja.Text = Comun.HostName;
                if (string.IsNullOrEmpty(Comun.MACAddress))
                {
                    this.mktxtMac.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboSucursales()
        {
            try
            {
                Sucursal datos = new Sucursal();
                Sucursal_Negocio sn = new Sucursal_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbSucCaja.DataSource = sn.LlenarComboSucursales(datos);
                this.cmbSucCaja.ValueMember = "IDSucursal";
                this.cmbSucCaja.DisplayMember = "NombreSucursal";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LLenarComboCajas()
        {
            try
            {
                Caja datos = new Caja(Comun.Conexion);
                Caja_Negocio cn = new Caja_Negocio();
                datos.Opcion = 1;
                this.cmbCajas.DataSource = cn.LlenarComboCatCajas(datos);
                this.cmbCajas.ValueMember = "IDCajaCat";
                this.cmbCajas.DisplayMember = "CajaCat";

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
                this.txt_mensaje.Visible = true;
                switch (error)
                {
                    case 1: this.txt_mensaje.Text = "Ingrese una dirección MAC válida.";
                        this.ActiveControl = this.mktxtMac;
                        this.mktxtMac.Focus();
                        break;
                    case 2: this.txt_mensaje.Text = "Seleccione un número de caja.";
                        this.ActiveControl = this.cmbCajas;
                        this.cmbCajas.Focus();
                        break;
                    case 3: this.txt_mensaje.Text = "Seleccione una sucursal para la caja.";
                        this.ActiveControl = this.cmbSucCaja;
                        this.cmbSucCaja.Focus();
                        break;
                    case 4: this.txt_mensaje.Text = "Asigne un nombre a la caja.";
                        this.ActiveControl = this.txtNombreCaja;
                        this.txtNombreCaja.Focus();
                        break;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatos(Caja caja)
        {
            try
            {
                Caja cajaSeleccionada = new Caja(Comun.Conexion);
                Sucursal sucSeleccionada = new Sucursal();
                if(this.cmbCajas.SelectedIndex != -1)
                    cajaSeleccionada = (Caja)this.cmbCajas.SelectedItem;
                if(this.cmbSucCaja.SelectedIndex != -1)
                    sucSeleccionada = (Sucursal)this.cmbSucCaja.SelectedItem;
                caja.IDCajaCat = cajaSeleccionada.IDCajaCat;
                caja.Mac = this.mktxtMac.Text;
                caja.NombreCaja = this.txtNombreCaja.Text;
                caja.IDSucursal = sucSeleccionada.IDSucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarCampos()
        {
            try
            {
                Validaciones validar = new Validaciones();
                if (string.IsNullOrEmpty(this.mktxtMac.Text) || string.IsNullOrWhiteSpace(this.mktxtMac.Text))
                    return 1;
                if (!validar.ValidarDireccionMAC(this.mktxtMac.Text))
                    return 1;
                if (this.cmbCajas.SelectedIndex == -1)
                    return 2;
                Caja cajaseleccionada = (Caja)this.cmbCajas.SelectedItem;
                if (string.IsNullOrEmpty(cajaseleccionada.IDCajaCat))
                    return 2;
                if (this.cmbSucCaja.SelectedIndex == -1)
                    return 3;
                Sucursal sucseleccionada = (Sucursal)this.cmbSucCaja.SelectedItem;
                if (string.IsNullOrEmpty(sucseleccionada.IDSucursal))
                    return 3;
                if (string.IsNullOrEmpty(this.txtNombreCaja.Text) || string.IsNullOrWhiteSpace(this.txtNombreCaja.Text))
                    return 4;
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btn_Cancelar_Click");
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int error = ValidarCampos();
                if (error == 0)
                {
                    this.GuardarMac();
                }
                else
                {
                    this.MostrarMensajeError(error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btn_Guardar_Click");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void frmAsignarCaja_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Asignar Caja";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarCaja_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

    }
}
