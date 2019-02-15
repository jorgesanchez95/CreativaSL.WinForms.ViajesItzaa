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
    public partial class frmDisponibilidad : Form_Creativa
    {
        #region Variables

        private Cotizacion DatosCotizacion = new Cotizacion();

        #endregion

        #region Constructor

        public frmDisponibilidad(Cotizacion datos)
        {
            try
            {
                InitializeComponent();
                DatosCotizacion = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDisponibilidad");
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Disponibilidad";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDisponibilidad_Load");
            }
        }

        #endregion

        #region Eventos Click

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ObtenerDisponibilidad();
                DatosCotizacion.Conexion = Comun.Conexion;
                DatosCotizacion.IDUsuario = Comun.IDUsuario;
                Cotizacion_Negocio cn = new Cotizacion_Negocio();
                cn.ActualizarEstatusCotizacion(DatosCotizacion);
                if (DatosCotizacion.Validador)
                {
                    MessageBox.Show("Datos actualizados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ocurrió un error al actualizar los datos. El monto de la cotización debe ser mayor a $ 0.00.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.txtDescripcion.Text = DatosCotizacion.Descripcion;
                if (DatosCotizacion.IDStatusCotizacion == 2)
                    this.chkDisponibilidad.Checked = true;
                else
                    this.chkDisponibilidad.Checked = false;
                this.ActiveControl = this.chkDisponibilidad;
                this.chkDisponibilidad.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDisponibilidad()
        {
            try
            {
                if (this.chkDisponibilidad.Checked)
                    DatosCotizacion.IDStatusCotizacion = 2;
                else
                    DatosCotizacion.IDStatusCotizacion = 3;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
