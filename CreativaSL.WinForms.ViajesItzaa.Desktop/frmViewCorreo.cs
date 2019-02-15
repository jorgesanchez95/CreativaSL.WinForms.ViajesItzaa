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
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmViewCorreo : Form_Creativa
    {

        #region Variables
        private Solicitud Datos = new Solicitud();
        #endregion

        #region Constructor

        public frmViewCorreo(Solicitud Solic)
        {
            try
            {
                InitializeComponent();
                Datos = Solic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmViewCorreo_Load");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Del Formulario

        private void frmViewCorreo_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Correo Cotización";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmViewCorreo_Load");
            }
        }

        #endregion

        #region Eventos Click

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.IniciarForm();
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarForm()
        {
            try
            {
                Solicitud Aux = new Solicitud();
                Aux = this.ObtenerDetalleCotizacion();
                if (Aux != null)
                {
                    if (Aux.Cotizacion != null)
                    {
                        switch (this.Datos.IDTipoSolicitud)
                        {
                            case 1: Aux.Cotizacion.HtmlCorreo = EnvioCorreo.GenerarHtmlPaqueteCotizado(Aux);
                                break;
                            case 2: Aux.Cotizacion.HtmlCorreo = EnvioCorreo.GenerarHtmlToursCotizado(Aux);
                                break;
                            case 3: Aux.Cotizacion.HtmlCorreo = EnvioCorreo.GenerarHtmlHotelesCotizado(Aux);
                                break;
                            case 4: Aux.Cotizacion.HtmlCorreo = EnvioCorreo.GenerarHtmlTransportacionCotizado(Aux);
                                break;
                            case 5: Aux.Cotizacion.HtmlCorreo = EnvioCorreo.GenerarHtmlPaqueteVipCotizado(Aux);
                                break;
                        }
                        
                        this.viewHTMLCorreo.DocumentText = Aux.Cotizacion.HtmlCorreo;
                    }
                }
                this.ActiveControl = this.btnCancelar;
                this.btnCancelar.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Solicitud ObtenerDetalleCotizacion()
        {
            try
            {
                Cotizacion Aux = new Cotizacion();
                Solicitud AuxSol = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Aux.IDSolicitud = Datos.IDSolicitud;
                Aux.IDCotizacion = Datos.IDCotizacion;
                Aux.Conexion = Comun.Conexion;
                AuxSol = sn.ObtenerDetalleSolicitudCotizacionExtra(Aux);
                return AuxSol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
