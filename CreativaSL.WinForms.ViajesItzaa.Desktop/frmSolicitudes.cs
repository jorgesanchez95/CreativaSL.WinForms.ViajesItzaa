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
using System.Configuration;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmSolicitudes : Form_Creativa
    {
        #region Propiedades
        private bool EsBusqueda = false;
        private Busqueda BusquedaActual = new Busqueda();
        private frmWait Espere = new frmWait();
        private bool Tab01 = false;
        private bool Tab02 = false;
        private bool Tab03 = false;
        private bool Tab04 = false;
        private int IDTipoSolicitud = 0;
        #endregion

        #region Constructor

        public frmSolicitudes()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmSolicitudes()");
                this.Close();
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Mis solicitudes";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.EstablecerToolTipsBotones();
                this.IniciarForm();
                this.IniciarDatosBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmSolicitudes_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Click

        #region Eventos Click Menú de Opciones

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripNuevaSolicitud.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                MenuStripNuevaSolicitud.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevaSolicitud_Click");
            }
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Aux = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Aux.IDSolicitud))
                {
                    if (Aux.IDStatusSolicitud == 2)
                    {
                        frmCotizaciones cotizar = new frmCotizaciones(Aux);
                        this.Visible = false;
                        cotizar.ShowDialog();
                        this.Visible = true;
                        cotizar.Dispose();
                        this.CargarGridTramite();
                        this.EstablecerImagenGridTramite();
                        this.CargarGridCotizacionesXSolicitud(this.ObtenerDatosSolicitud());
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite el envío de Cotizaciones.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCotizaciones_Click");
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    //if (Datos.IDStatusSolicitud == 2 || 
                    if (Datos.IDStatusSolicitud == 4)
                    {
                        frmConfirmarVenta Confirmar = new frmConfirmarVenta(Datos, 1);
                        Confirmar.ShowDialog();
                        Confirmar.Dispose();
                        if (Confirmar.DialogResult == DialogResult.OK)
                        {
                            this.CargarGridTramite();
                            this.CargarGridVendidas();
                            this.EstablecerImagenGridTramite();
                            this.EstablecerImagenGridVendidas();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnConfirmarVenta_Click");
            }
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripPagar.Show(btn, btn.Width / 2, btn.Location.Y + btn.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnConfirmarPago_Click");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripCancelar.Show(btn, btn.Width / 2, btn.Location.Y + btn.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 7 && Datos.IDStatusSolicitud <= 8)
                    {
                        frmAsignarRecursos recursos = new frmAsignarRecursos(Datos);
                        recursos.ShowDialog();
                        recursos.Dispose();
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAsignar_Click");
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    Nota DatosNota = new Nota();
                    DatosNota.IDSolicitud = datos.IDSolicitud;
                    frmNotas Notas = new frmNotas(DatosNota, 1);
                    Notas.ShowDialog();
                    Notas.Dispose();
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNotas_Click");
            }
        }        

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud <= 7)
                    {
                        frmPersonal personal = new frmPersonal(Datos);
                        personal.ShowDialog();
                        personal.Dispose();
                        if (personal.DialogResult == DialogResult.OK)
                        {
                            this.CargarGrid();
                            this.EstablecerImagenGrid();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnPersonal_Click");
            }
        }

        private void btnEnEspera_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 7 && Datos.IDStatusSolicitud <= 8)
                    {
                        Solicitud_Negocio sn = new Solicitud_Negocio();
                        Datos.Conexion = Comun.Conexion;
                        Datos.IDUsuario = Comun.IDUsuario;
                        sn.SolicitudEnEspera(Datos);
                        if (Datos.Validador)
                        {
                            MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CargarGridVendidas();
                            this.CargarGridPorConfirmar();
                            this.EstablecerImagenGridVendidas();
                            this.EstablecerImagenGridPorConfirmar();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al actualizar la solicitud. Intente nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEnEspera_Click");
            }
        }

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

        #endregion

        #region Eventos Click Menú Nueva Solicitud

        private void toolsmPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                frmElegirCliente ns = new frmElegirCliente(1);
                ns.ShowDialog();
                ns.Dispose();
                if (ns.DialogResult == DialogResult.OK)
                {
                    //Obtener los datos del Nuevo registro del objeto Solicitud
                    //Solicitud datos = ns.resultado;
                    //this.AgregarColumnaDataGridView(datos);
                    //this.EstablecerImagenGridTramite();
                    this.CargarGridTramite();
                    this.EstablecerImagenGridTramite();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "toolsmPaquete_Click");
            }
        }

        private void toolsmTour_Click(object sender, EventArgs e)
        {
            try
            {
                frmElegirCliente ns = new frmElegirCliente(2);
                ns.ShowDialog();
                ns.Dispose();
                if (ns.DialogResult == DialogResult.OK)
                {
                    this.CargarGridTramite();
                    this.EstablecerImagenGridTramite();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "toolsmTour_Click");
            }
        }

        private void toolsmHotel_Click(object sender, EventArgs e)
        {
            try
            {
                frmElegirCliente ns = new frmElegirCliente(3);
                ns.ShowDialog();
                ns.Dispose();
                if (ns.DialogResult == DialogResult.OK)
                {
                    this.CargarGridTramite();
                    this.EstablecerImagenGridTramite();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "toolsmHotel_Click");
            }
        }

        private void toolsmTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmElegirCliente ns = new frmElegirCliente(4);
                ns.ShowDialog();
                ns.Dispose();
                if (ns.DialogResult == DialogResult.OK)
                {
                    this.CargarGridTramite();
                    this.EstablecerImagenGridTramite();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "toolsmTransporte_Click");
            }
        }

        private void toolsmPaqueteVIP_Click(object sender, EventArgs e)
        {
            try
            {
                frmElegirCliente ns = new frmElegirCliente(5);
                ns.ShowDialog();
                ns.Dispose();
                if (ns.DialogResult == DialogResult.OK)
                {
                    this.CargarGridTramite();
                    this.EstablecerImagenGridTramite();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "toolsmPaqueteVIP_Click");
            }
        }

        #endregion

        #region Eventos Click Menú Pago

        private void MenuItemPagoAnticipo_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 5 && Datos.IDStatusSolicitud <= 6)
                    {
                        frmPagoInicial pagoinicial = new frmPagoInicial(Datos);
                        pagoinicial.ShowDialog();
                        pagoinicial.Dispose();
                        if (pagoinicial.DialogResult == DialogResult.OK)
                        {
                            this.CargarGridVendidas();
                            this.EstablecerImagenGridVendidas();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemPagoAnticipo_Click");
            }
        }

        private void MenuItemPagoTotal_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 7 && Datos.IDStatusSolicitud <= 7)
                    {
                        frmPagoAbono pagoAbono = new frmPagoAbono(Datos);
                        pagoAbono.ShowDialog();
                        pagoAbono.Dispose();
                        if (pagoAbono.DialogResult == DialogResult.OK)
                        {
                            this.CargarGridVendidas();
                            this.EstablecerImagenGridVendidas();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemPagoTotal_Click");
            }
        }

        private void MenuItemPaypal_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 5 && Datos.IDStatusSolicitud <= 7)
                    {
                        frmNuevaOrdenPago ordenpago = new frmNuevaOrdenPago(Datos);
                        ordenpago.ShowDialog(); 
                        ordenpago.Dispose();
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemPaypal_Click");
            }
        }

        #endregion

        #region Eventos Click Menú Cancelacion

        private void MenuItemCancelarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 1 && Datos.IDStatusSolicitud <= 6)
                    {
                        frmCancelaciones cancelar = new frmCancelaciones(1, Datos);
                        cancelar.ShowDialog();
                        cancelar.Dispose();
                        if (cancelar.DialogResult == DialogResult.OK)
                        {
                            this.CargarGrid();
                            this.EstablecerImagenGrid();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemCancelarSolicitud_Click");
            }
        }

        private void MenuItemCancelarConRecargo_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 7 && Datos.IDStatusSolicitud <= 8)
                    {
                        frmCancelaciones cancelar = new frmCancelaciones(2, Datos);
                        cancelar.ShowDialog();
                        cancelar.Dispose();
                        if (cancelar.DialogResult == DialogResult.OK)
                        {
                            this.CargarGrid();
                            this.EstablecerImagenGrid();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemCancelarConRecargo_Click");
            }
        }

        private void MenuItemCancelarSinRecargo_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud Datos = new Solicitud();
                Datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    if (Datos.IDStatusSolicitud >= 7 && Datos.IDStatusSolicitud <= 8)
                    {
                        frmCancelaciones cancelar = new frmCancelaciones(3, Datos);
                        cancelar.ShowDialog();
                        cancelar.Dispose();
                        if (cancelar.DialogResult == DialogResult.OK)
                        {
                            this.CargarGrid();
                            this.EstablecerImagenGrid();
                        }
                    }
                    else
                        MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "MenuItemCancelarSinRecargo_Click");
            }
        }

        #endregion

        #region Eventos Click Menú Idiomas

        private void tsmIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                bool band = false;
                bool.TryParse(item.Tag.ToString(), out band);
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    if (datos.IDTipoSolicitud == 1 || datos.IDTipoSolicitud == 2 || datos.IDTipoSolicitud == 5)
                    {
                        if (datos.IDStatusSolicitud <= 8 || datos.IDStatusSolicitud == 14)
                        {

                            frmViewReportes reporteador = new frmViewReportes(8, datos.IDSolicitud, band);
                            this.Visible = false;
                            reporteador.ShowDialog();
                            this.Visible = true;
                            reporteador.Dispose();

                        }
                        else
                            MessageBox.Show("El estatus de la solicitud no permite realizar ésta acción.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnImprimirItinerario_Click");
            }
        }

        #endregion

        #region Eventos Click Ver

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    frmNotasSolicitud Notas = new frmNotasSolicitud(datos.IDSolicitud);
                    Notas.ShowDialog();
                    Notas.Dispose();
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnVerNotas_Click");
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    frmDetalleSolicitud detalle = new frmDetalleSolicitud(datos, 1);
                    this.Visible = false;
                    detalle.ShowDialog();
                    this.Visible = true;
                    detalle.Dispose();
                    this.CargarGridVendidas();
                    this.CargarGridPorConfirmar();
                    this.CargarGridTramite();
                    this.EstablecerImagenGrid();
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnVerDetalles_Click");
            }
        }

        private void btnImprimirItinerario_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripIdioma.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                MenuStripIdioma.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnImprimirItinerario_Click");
            }
        }

        private void btnFichaSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    frmViewReportes Ficha = new frmViewReportes(10, datos.IDSolicitud, false);
                    this.Visible = false;
                    Ficha.ShowDialog();
                    this.Visible = true;
                    Ficha.Dispose();
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnFichaSolicitud_Click");
            }
        }

        #endregion

        #region Eventos Click Opciones de Búsqueda

        private void btnBusquedaFolio_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa aux = (Button_Creativa)sender;
                int tipo = 0;
                int.TryParse(aux.Tag.ToString(), out tipo);
                switch (tipo)
                {
                    case 3:
                        if (this.ValidarFechas(dtpBusqFechaSolicitudInicio.Value, dtpBusqFechaSolicitudFin.Value))
                        {
                            this.CargarGridBusqueda(tipo);
                            this.EsBusqueda = true;
                            this.BusquedaActual.IDTipoBusqueda = tipo;
                        }
                        else
                            MessageBox.Show("La fecha Final de Solicitud debe ser mayor o igual a la fecha Inicial de Solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        if (this.ValidarFechas(dtpBusqFechaLlegadaInicio.Value, dtpBusqFechaLlegadaFin.Value))
                        {
                            this.CargarGridBusqueda(tipo);
                            this.EsBusqueda = true;
                            this.BusquedaActual.IDTipoBusqueda = tipo;
                        }
                        else
                            MessageBox.Show("La fecha Final de Llegada debe ser mayor o igual a la fecha Inicial de Llegada.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 6:
                        if (this.ValidarFechas(dtpBusqFechaNotasInicio.Value, dtpBusqFechaNotasFin.Value))
                        {
                            this.CargarGridBusqueda(tipo);
                            this.EsBusqueda = true;
                            this.BusquedaActual.IDTipoBusqueda = tipo;
                        }
                        else
                            MessageBox.Show("La fecha Final de Notas debe ser mayor o igual a la fecha Inicial de Notas.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                    case 2:
                    case 4:
                        this.BusquedaActual.IDTipoBusqueda = tipo;
                        this.EsBusqueda = true;
                        this.CargarGridBusqueda(tipo);
                        break;
                    default: break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaFolio_Click");
            }
        }

        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaCliente_Click");
            }
        }

        private void btnBusquedaFechaSolicitud_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaFechaSolicitud_Click");
            }
        }

        private void btnBusquedaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaEmpresa_Click");
            }
        }

        private void btnBusquedaFechaLlegada_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaFechaLlegada_Click");
            }
        }

        private void btnBusquedaFechaNotas_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusquedaFechaNotas_Click");
            }

        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                this.EsBusqueda = false;
                this.BusquedaActual = new Busqueda();
                this.IniciarDatosBusqueda();
                this.CargarGrid();
                this.EstablecerImagenGrid();
                this.BusquedaActual = new Busqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnLimpiarBusqueda_Click");
            }
        }

        #endregion

        #endregion

        #region Eventos Configuracion

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                frmPerfilUsuario perfil = new frmPerfilUsuario();
                perfil.ShowDialog();
                if (perfil.DialogResult == DialogResult.OK)
                    this.DialogResult = DialogResult.Abort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "lblPerfil_Click");
            }
        }

        #endregion

        #region Eventos KeyPress

        #region Eventos KeyPress Búsqueda

        private void txtBusqFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaFolio_Click(this.btnBusquedaFolio, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtBusqFolio_KeyPress");
            }
        }

        private void txtBusqNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaCliente_Click(this.btnBusquedaCliente, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtBusqNombre_KeyPress");
            }
        }

        private void dtpBusqFechaSolicitudInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaFechaSolicitud_Click(this.btnBusquedaFechaSolicitud, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpBusqFechaSolicitudInicio_KeyPress");
            }
        }

        private void cmbBusqEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaEmpresa_Click(this.btnBusquedaEmpresa, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbBusqEmpresa_KeyPress");
            }
        }

        private void dtpBusqFechaLlegadaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaFechaLlegada_Click(this.btnBusquedaFechaLlegada, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpBusqFechaLlegadaInicio_KeyPress");
            }
        }

        private void dtpBusqFechaNotasInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.btnBusquedaFechaNotas_Click(this.btnBusquedaFechaNotas, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpBusqFechaLlegadaInicio_KeyPress");
            }
        }

        #endregion

        #endregion

        #region Eventos Notificaciones

        private void bgwNotificaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Usuario aux = new Usuario();
                aux.Conexion = Comun.Conexion;
                aux.IDUsuario = Comun.IDUsuario;
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosNot = sn.ObtenerNotificaciones(aux);
                e.Result = datosNot;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwNotificaciones_DoWork");
            }
        }

        private void bgwNotificaciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Result != null)
                {
                    Solicitud aux = (Solicitud)e.Result;
                    if (aux.BandNot_01)
                        this.pbNotifEnviosFaltantes.Visible = true;
                    if (aux.BandNot_02)
                    {
                        this.pbNotifCompraConfirmada.Visible = true;
                        this.CargarGridVendidas();
                        this.CargarGridTramite();
                        this.EstablecerImagenGridTramite();
                        this.EstablecerImagenGridVendidas();
                    }
                    if (aux.BandNot_03)
                        this.pbNotifPagoConfirmado.Visible = true;
                    if (aux.BandNot_04 || aux.BandNot_05)
                        this.pbNotifPagoVencido.Visible = true;
                    if (aux.BandNot_06)
                        this.pbNotifNotaProgramada.Visible = true;

                }
                this.timerNotificaciones.Enabled = true;
            }
            catch (Exception ex)
            {
                this.timerNotificaciones.Enabled = true;
                Comun_Negocio.AddExcFileTxt(ex, "bgwNotificaciones_RunWorkerCompleted");
            }
        }

        private void pbNotificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox aux = (PictureBox)sender;
                int TipoNot = 0;
                int.TryParse(aux.Tag.ToString(), out TipoNot);
                frmNotificaciones notificaciones = new frmNotificaciones(TipoNot);
                notificaciones.ShowDialog();
                notificaciones.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "pbNotificaciones_Click");
            }
        }

        private void timerNotificaciones_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timerNotificaciones.Enabled = false;
                this.bgwNotificaciones.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "timerNotificaciones_Tick");
            }
        }

        #endregion

        #region Eventos Para detalle de MiniGridCotizaciones

        private void dgv_Cotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    DataGridViewColumn Columna = this.dgv_Cotizaciones.Columns[e.ColumnIndex];
                    if (Columna.Name == "Ver")
                    {
                        Solicitud aux = this.ObtenerDatosSolicitud();
                        Cotizacion Datos = new Cotizacion();
                        Datos.IDSolicitud = aux.IDSolicitud;
                        Datos.IDCotizacion = this.dgv_Cotizaciones.Rows[e.RowIndex].Cells["IDCotizacion"].Value.ToString();
                        Datos.Comentarios = string.Empty;
                        frmNuevaCotizacion VerDetalle = new frmNuevaCotizacion(Datos, 3, aux.IDTipoSolicitud);
                        this.Visible = false;
                        VerDetalle.ShowDialog();
                        this.Visible = true;
                        VerDetalle.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgv_Cotizaciones_CellContentClick");
            }
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                this.CargarGridCotizacionesXSolicitud(datos);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgvSolicitudes_SelectionChanged");
            }
        }

        private void tcSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tcSolicitudes.Refresh();
                Solicitud datos = this.ObtenerDatosSolicitud();
                this.CargarGridCotizacionesXSolicitud(datos);
                switch (tcSolicitudes.SelectedIndex)
                {
                    case 0:
                        if (!Tab01)
                        {
                            this.CargarGridTramite();
                            Tab01 = true;
                        }
                        this.EstablecerImagenGridTramite();
                        break;
                    case 1:
                        if (!Tab02)
                        {
                            this.CargarGridVendidas();
                            Tab02 = true;
                        }
                        this.EstablecerImagenGridVendidas();
                        break;
                    case 2:
                        if (!Tab03)
                        {
                            this.CargarGridPorConfirmar();
                            Tab03 = true;
                        }
                        this.EstablecerImagenGridPorConfirmar();
                        break;
                    case 3:
                        if (!Tab04)
                        {
                            this.CargarGridCanceladas();
                            Tab04 = true;
                        }
                        this.EstablecerImagenGridCanceladas();
                        break;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "tcSolicitudes_SelectedIndexChanged");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void AgregarColumnaDataGridView(Solicitud datos)
        {
            try
            {
                object[] fila = {datos.IDSolicitud,
                                 datos.Folio,
                                 datos.IDStatusSolicitud,
                                 null,
                                 datos.FechaSolicitud,
                                 datos.HoraSolicitud,
                                 datos.IDTipoSolicitud,
                                 null,
                                 datos.NombreProducto};
                this.dgvSolicitudesEnTramite.Rows.Add(fila);
                this.dgvSolicitudesEnTramite.Sort(this.dgvSolicitudesEnTramite.Columns["FechaSolicitud"], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGrid()
        {
            try
            {
                if (!EsBusqueda)
                {
                    this.Tab01 = false;
                    this.Tab02 = false;
                    this.Tab03 = false;
                    this.Tab04 = false;
                    this.tcSolicitudes_SelectedIndexChanged(this.tcSolicitudes, new EventArgs());
                    //this.CargarGridTramite();
                    //this.CargarGridVendidas();
                    //this.CargarGridPorConfirmar();
                    //this.CargarGridCanceladas();
                }
                else
                {
                    this.CargarGridBusqueda(BusquedaActual.IDTipoBusqueda);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridCanceladas()
        {
            try
            {
                if (!EsBusqueda)
                {
                    Solicitud datos = new Solicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    datos.Conexion = Comun.Conexion;
                    datos.Opcion = 4;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                    this.dgvSolicitudesCanceladas.AutoGenerateColumns = false;
                    this.dgvSolicitudesCanceladas.DataSource = sn.ObtenerSolicitudes(datos);
                }
                else
                {
                    Busqueda aux = new Busqueda();
                    aux = this.ObtenerDatosBusqueda();
                    aux.IDTipoBusqueda = this.BusquedaActual.IDTipoBusqueda;
                    this.CargarGridBusquedaCanceladas(aux);
                    this.EstablecerImagenGrid();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridPorConfirmar()
        {
            try
            {
                if (!EsBusqueda)
                {
                    Solicitud datos = new Solicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    datos.Conexion = Comun.Conexion;
                    datos.Opcion = 3;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                    this.dgvSolicitudesPorConfirmar.AutoGenerateColumns = false;
                    this.dgvSolicitudesPorConfirmar.DataSource = sn.ObtenerSolicitudes(datos);
                }
                else
                {
                    Busqueda aux = new Busqueda();
                    aux = this.ObtenerDatosBusqueda();
                    aux.IDTipoBusqueda = this.BusquedaActual.IDTipoBusqueda;
                    this.CargarGridBusquedaPorConfirmar(aux);
                    this.EstablecerImagenGrid();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridTramite()
        {
            try
            {
                if (!EsBusqueda)
                {
                    Solicitud datos = new Solicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    datos.Conexion = Comun.Conexion;
                    datos.Opcion = 1;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                    this.dgvSolicitudesEnTramite.AutoGenerateColumns = false;
                    this.dgvSolicitudesEnTramite.DataSource = sn.ObtenerSolicitudes(datos);
                }
                else
                {
                    Busqueda aux = new Busqueda();
                    aux = this.ObtenerDatosBusqueda();
                    aux.IDTipoBusqueda = this.BusquedaActual.IDTipoBusqueda;
                    this.CargarGridBusquedaTramite(aux);
                    this.EstablecerImagenGrid();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridVendidas()
        {
            try
            {
                if (!EsBusqueda)
                {
                    Solicitud datos = new Solicitud();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    datos.Conexion = Comun.Conexion;
                    datos.Opcion = 2;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                    this.dgvSolicitudesVendidas.AutoGenerateColumns = false;
                    this.dgvSolicitudesVendidas.DataSource = sn.ObtenerSolicitudes(datos);
                }
                else
                {
                    Busqueda aux = new Busqueda();
                    aux = this.ObtenerDatosBusqueda();
                    aux.IDTipoBusqueda = this.BusquedaActual.IDTipoBusqueda;
                    this.CargarGridBusquedaVendidas(aux);
                    this.EstablecerImagenGrid();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridBusqueda(int Tipo)
        {
            try
            {
                Busqueda datos = this.ObtenerDatosBusqueda();
                datos.IDTipoBusqueda = Tipo;
                this.Tab01 = false;
                this.Tab02 = false;
                this.Tab03 = false;
                this.Tab04 = false;
                this.tcSolicitudes_SelectedIndexChanged(this.tcSolicitudes, new EventArgs());
                //this.CargarGridBusquedaTramite(datos);
                //this.CargarGridBusquedaVendidas(datos);
                //this.CargarGridBusquedaPorConfirmar(datos);
                //this.CargarGridBusquedaCanceladas(datos);
                this.EstablecerImagenGrid();
                this.BusquedaActual = datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridBusquedaCanceladas(Busqueda datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Opcion = 4;
                this.dgvSolicitudesCanceladas.AutoGenerateColumns = false;
                this.dgvSolicitudesCanceladas.DataSource = sn.ObtenerSolicitudesXBusqueda(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridBusquedaPorConfirmar(Busqueda datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Opcion = 3;
                this.dgvSolicitudesPorConfirmar.AutoGenerateColumns = false;
                this.dgvSolicitudesPorConfirmar.DataSource = sn.ObtenerSolicitudesXBusqueda(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridBusquedaTramite(Busqueda datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Opcion = 1;
                this.dgvSolicitudesEnTramite.AutoGenerateColumns = false;
                this.dgvSolicitudesEnTramite.DataSource = sn.ObtenerSolicitudesXBusqueda(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridBusquedaVendidas(Busqueda datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Opcion = 2;
                this.dgvSolicitudesVendidas.AutoGenerateColumns = false;
                this.dgvSolicitudesVendidas.DataSource = sn.ObtenerSolicitudesXBusqueda(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridCotizacionesXSolicitud(Solicitud Datos)
        {
            try
            {
                Cotizacion DatosCot = new Cotizacion();
                Cotizacion_Negocio cn = new Cotizacion_Negocio();
                DatosCot.IDSolicitud = Datos.IDSolicitud;
                DatosCot.Conexion = Comun.Conexion;
                this.dgv_Cotizaciones.DataSource = cn.ObtenerMiniGridCotizaciones(DatosCot);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerImagenGrid()
        {
            try
            {
                this.EstablecerImagenGridTramite();
                this.EstablecerImagenGridVendidas();
                this.EstablecerImagenGridPorConfirmar();
                this.EstablecerImagenGridCanceladas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerImagenGridCanceladas()
        {
            try
            {
                DataGridView dgv = this.dgvSolicitudesCanceladas;
                ConfiguracionDataGridView cdgv = new ConfiguracionDataGridView();
                cdgv.ImagenGrid(this.dgvSolicitudesCanceladas, dgv.Name + "IDTipoSolicitud", dgv.Name + "TipoSolicitud", dgv.Name + "IDStatusSolicitud", dgv.Name + "Estatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerImagenGridPorConfirmar()
        {
            try
            {
                DataGridView dgv = this.dgvSolicitudesPorConfirmar;
                ConfiguracionDataGridView cdgv = new ConfiguracionDataGridView();
                cdgv.ImagenGrid(this.dgvSolicitudesPorConfirmar, dgv.Name + "IDTipoSolicitud", dgv.Name + "TipoSolicitud", dgv.Name + "IDStatusSolicitud", dgv.Name + "Estatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerImagenGridTramite()
        {
            try
            {
                ConfiguracionDataGridView cdgv = new ConfiguracionDataGridView();
                DataGridView dgv = this.dgvSolicitudesEnTramite;
                cdgv.ImagenGrid(this.dgvSolicitudesEnTramite, dgv.Name + "IDTipoSolicitud", dgv.Name + "TipoSolicitud", dgv.Name + "IDStatusSolicitud", dgv.Name + "Estatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerImagenGridVendidas()
        {
            try
            {
                DataGridView dgv = this.dgvSolicitudesVendidas;
                ConfiguracionDataGridView cdgv = new ConfiguracionDataGridView();
                cdgv.ImagenGrid(this.dgvSolicitudesVendidas, dgv.Name + "IDTipoSolicitud", dgv.Name + "TipoSolicitud", dgv.Name + "IDStatusSolicitud", dgv.Name + "Estatus");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerToolTipsBotones()
        {
            try
            {
                ToolTip btnToolTip = new ToolTip();
                btnToolTip.SetToolTip(this.btnNuevaSolicitud, "Nueva Solicitud");
                btnToolTip.SetToolTip(this.btnCotizaciones, "Cotizaciones");
                btnToolTip.SetToolTip(this.btnConfirmarVenta, "Confirmar Venta");
                btnToolTip.SetToolTip(this.btnConfirmarPago, "Confirmar Pago");
                btnToolTip.SetToolTip(this.btnCancelar, "Cancelar Solicitud");
                btnToolTip.SetToolTip(this.btnAsignar, "Asignar recursos");
                btnToolTip.SetToolTip(this.btnNotas, "Agregar Notas");
                btnToolTip.SetToolTip(this.btnVerDetalles, "Ver Detalles");
                btnToolTip.SetToolTip(this.btnVerNotas, "Ver Notas");
                btnToolTip.SetToolTip(this.btnPersonal, "Cambiar personal");
                btnToolTip.SetToolTip(this.btnRegresar, "Regresar");
                btnToolTip.SetToolTip(this.btnBusquedaFolio, "Buscar por folio de solicitud");
                btnToolTip.SetToolTip(this.btnBusquedaCliente, "Buscar por nombre de cliente");
                btnToolTip.SetToolTip(this.btnBusquedaFechaSolicitud, "Buscar por fecha de solicitud");
                btnToolTip.SetToolTip(this.btnLimpiarBusqueda, "Limpiar Búsqueda");
                btnToolTip.SetToolTip(this.btnBusquedaEmpresa, "Buscar por empresa");
                btnToolTip.SetToolTip(this.btnBusquedaFechaLlegada, "Buscar por fecha de llegada");
                btnToolTip.SetToolTip(this.btnBusquedaFechaNotas, "Buscar por fecha de Notas");
                btnToolTip.SetToolTip(this.btnEnEspera, "Poner en estatus <<en espera>> una solicitud");
                btnToolTip.SetToolTip(this.pbNotifCompraConfirmada, "Compras confirmadas Vía web");
                btnToolTip.SetToolTip(this.pbNotifEnviosFaltantes, "Solicitudes sin envío de cotizaciones en 24 horas.");
                btnToolTip.SetToolTip(this.pbNotifNotaProgramada, "Notas prgramadas con recordatorio");
                btnToolTip.SetToolTip(this.pbNotifPagoConfirmado, "Pagos On-line confirmados");
                btnToolTip.SetToolTip(this.pbNotifPagoVencido, "Solicitudes con fechas de pago vencidas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatosBusqueda()
        {
            try
            {
                this.txtBusqFolio.Text = string.Empty;
                this.txtBusqNombre.Text = string.Empty;
                this.txtBusqApPat.Text = string.Empty;
                this.txtBusqApMat.Text = string.Empty;
                this.dtpBusqFechaSolicitudInicio.Value = DateTime.Today;
                this.dtpBusqFechaSolicitudFin.Value = DateTime.Today;
                if (this.cmbBusqEmpresa.Items.Count > 0)
                    this.cmbBusqEmpresa.SelectedIndex = 0;
                else
                    this.cmbBusqEmpresa.Text = "";
                this.dtpBusqFechaLlegadaInicio.Value = DateTime.Today;
                this.dtpBusqFechaLlegadaFin.Value = DateTime.Today;
                this.dtpBusqFechaNotasInicio.Value = DateTime.Today;
                this.dtpBusqFechaNotasFin.Value = DateTime.Today;
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
                this.txtNombreUsuario.Text = Comun.NombreUsuario + " " + Comun.ApellidoPaternoUsuario + " " + Comun.ApellidoMaternoUsuario;
                //this.IniciarGrid(this.dgvSolicitudesEnTramite, 9);
                //this.IniciarGrid(this.dgvSolicitudesVendidas, 9);
                //this.IniciarGrid(this.dgvSolicitudesPorConfirmar, 9);
                //this.IniciarGrid(this.dgvSolicitudesCanceladas, 9);
                this.IniciarGridCotizaciones(this.dgv_Cotizaciones, 6);
                this.CargarGrid();
                this.EstablecerImagenGrid();
                this.LlenarComboEmpresas();
                this.ActiveControl = this.txtBusqFolio;
                this.txtBusqFolio.Focus();
                this.timerNotificaciones_Tick(this.timerNotificaciones, new EventArgs());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarGrid(DataGridView actual, int numColumns)
        {
            try
            {
                ConfiguracionDataGridView dgvConf = new ConfiguracionDataGridView();
                dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnas(actual));
                actual.AutoSize = true;
                actual.AutoGenerateColumns = false;
                actual.AllowUserToAddRows = false;
                actual.AllowUserToDeleteRows = false;
                actual.AllowUserToOrderColumns = false;
                actual.AllowUserToResizeColumns = false;
                actual.MultiSelect = false;
                actual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                actual.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void IniciarGridCotizaciones(DataGridView actual, int numColumns)
        {
            try
            {
                ConfiguracionDataGridView dgvConf = new ConfiguracionDataGridView();
                dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasCotizaciones());
                actual.AutoSize = true;
                actual.AutoGenerateColumns = false;
                actual.AllowUserToAddRows = false;
                actual.AllowUserToDeleteRows = false;
                actual.AllowUserToOrderColumns = false;
                actual.AllowUserToResizeColumns = false;
                actual.MultiSelect = false;
                actual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                actual.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void LlenarComboEmpresas()
        {
            try
            {
                Empresa datos = new Empresa();
                Empresa_Negocio en = new Empresa_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbBusqEmpresa.DisplayMember = "NombreComercial";
                this.cmbBusqEmpresa.ValueMember = "IDEmpresa";
                this.cmbBusqEmpresa.DataSource = en.LlenarComboEmpresas(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Busqueda ObtenerDatosBusqueda()
        {
            try
            {
                Busqueda datos = new Busqueda();
                datos.Conexion = Comun.Conexion;
                datos.IDUsuarioRecibido = Comun.IDUsuario;
                datos.Opcion = 1;
                datos.FolioSolicitud = this.txtBusqFolio.Text;
                datos.Nombre = this.txtBusqNombre.Text.Trim();
                datos.ApellidoPaterno = this.txtBusqApPat.Text.Trim();
                datos.ApellidoMaterno = this.txtBusqApMat.Text;
                datos.FechaSolicitudInicio = this.dtpBusqFechaSolicitudInicio.Value;
                datos.FechaSolicitudFin = this.dtpBusqFechaSolicitudFin.Value;
                datos.IDEmpresa = this.ObtenerDatosEmpresa().IDEmpresa;
                datos.FechaLlegadaInicio = this.dtpBusqFechaLlegadaInicio.Value;
                datos.FechaLlegadaFin = this.dtpBusqFechaLlegadaFin.Value;
                datos.FechanotasInicio = this.dtpBusqFechaNotasInicio.Value;
                datos.FechaNotasFin = this.dtpBusqFechaNotasFin.Value;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Empresa ObtenerDatosEmpresa()
        {
            try
            {
                Empresa datos = new Empresa(); 
                datos.IDEmpresa = string.Empty;
                if (this.cmbBusqEmpresa.Items.Count > 0)
                {
                    if (this.cmbBusqEmpresa.SelectedIndex != -1)
                    {
                        datos = (Empresa)this.cmbBusqEmpresa.SelectedItem;
                    }
                }
                return datos;
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
                DataGridView dgv = new DataGridView();
                Solicitud datos = new Solicitud();
                switch (tcSolicitudes.SelectedIndex)
                {
                    case 0: dgv = this.dgvSolicitudesEnTramite;
                        break;
                    case 1: dgv = this.dgvSolicitudesVendidas;
                        break;
                    case 2: dgv = this.dgvSolicitudesPorConfirmar;
                        break;
                    case 3: dgv = this.dgvSolicitudesCanceladas;
                        break;
                }
                datos.IDSolicitud = string.Empty;
                if (dgv.Rows.Count > 0)
                {
                    if (dgv.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgv.SelectedRows[0];
                        datos.IDSolicitud = fila.Cells[dgv.Name + "IDSolicitud"].Value.ToString();
                        datos.Folio = fila.Cells[dgv.Name + "Folio"].Value.ToString();
                        datos.IDStatusSolicitud = Convert.ToInt32(fila.Cells[dgv.Name + "IDStatusSolicitud"].Value.ToString());
                        datos.IDTipoSolicitud = Convert.ToInt32(fila.Cells[dgv.Name + "IDTipoSolicitud"].Value.ToString());
                        datos.Conexion = Comun.Conexion;
                        datos.IDUsuarioRecibido = Comun.IDUsuario;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object[,] ObtenerPropiedadesColumnas(DataGridView Actual)
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          Actual.Name + "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                Actual.Name + "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    Actual.Name + "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     Actual.Name + "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha Solicitud",     "FechaSolicitud",       Actual.Name + "FechaSolicitud",   1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora Solicitud",      "HoraSolicitud",        Actual.Name + "HoraSolicitud",    1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      Actual.Name + "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     Actual.Name + "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "NombreProducto",       Actual.Name + "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object[,] ObtenerPropiedadesColumnasCotizaciones()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDCotizacion",        "IDCotizacion",         "IDCotizacion",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Descripción",         "Descripcion",          "Descripcion",       1,          true,           150,        DataGridViewContentAlignment.MiddleLeft,      ""},
                    {"IDStatusCotizacion",  "IDStatusCotizacion",   "IDStatusCotizacion",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",           2,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Monto",               "Subtotal",             "Subtotal",          1,          true,           90,        DataGridViewContentAlignment.MiddleRight,      "c"},
                    {"Ver",                 "",                     "Ver",               4,          true,           60,        DataGridViewContentAlignment.MiddleCenter,      ""},                    
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            try
            {
                if (FechaFinal >= FechaInicial)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void EnviarFicha_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if ((MessageBox.Show("¿Está seguro de enviar la ficha solicitud " + datos.Folio + "?",
                            Comun.CaptionSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(datos.IDSolicitud))
                    {
                        frmViewReportes Ficha = new frmViewReportes(11, datos.IDSolicitud, false);
                        this.Visible = true;
                        Ficha.Show();
                        this.Visible = true;
                        Ficha.Dispose();
                    }
                    else
                        MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEnviarFicha_Click");
            }
        }

        private void bgwReenvioCorreo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Solicitud aux = (Solicitud)e.Argument;
                List<Cotizacion> Enviadas = new List<Cotizacion>();
                aux.Conexion = Comun.Conexion;
                Cotizacion_Negocio cn = new Cotizacion_Negocio();
                Enviadas = cn.ObtenerCotizacionesAEnviar(aux);
                int TotalCot = Enviadas.Count;
                int cont = 0;
                foreach (Cotizacion item in Enviadas)
                {
                    item.IDSolicitud = aux.IDSolicitud;
                    this.EnviarCorreo(item);
                    cont++;
                    this.bgwReenvioCorreo.ReportProgress((cont * 100) / TotalCot);
                    if (cont == TotalCot)
                        System.Threading.Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_DoWork");
                throw ex;
            }
        }

        private void bgwReenvioCorreo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.Espere.ActualizarProgreso(e.ProgressPercentage);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_ProgressChanged");
            }
        }

        private void bgwReenvioCorreo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Espere.DialogResult = DialogResult.OK;
                this.Espere.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_RunWorkerCompleted");
            }
        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitud();
                if (datos.IDStatusSolicitud == 4)
                {
                    this.IDTipoSolicitud = datos.IDTipoSolicitud;
                    Solicitud aux = new Solicitud();
                    aux.IDSolicitud = datos.IDSolicitud;
                    aux.Conexion = Comun.Conexion;
                    aux.IDUsuario = Comun.IDUsuario;
                    //Cotizacion_Negocio cn = new Cotizacion_Negocio();
                    //cn.EnviarCotizacion(aux);
                    //if (aux.Validador)
                    //{
                        Solicitud_Negocio sn = new Solicitud_Negocio();
                        sn.ObtenerEsEmpresa(aux);
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!aux.EsEmpresa)
                        {
                            try
                            {
                                this.bgwReenvioCorreo.RunWorkerAsync(aux);
                                Espere.ShowDialog();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                    //}
                    //else
                    //    MessageBox.Show("Ocurrió un error al guardar los datos. Intente nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El estatus de la solicitud tiene que estar en enviadas", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEnviarCotizacion_Click");
            }
        }

        private bool EnviarCorreo(Cotizacion aux)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Solicitud datosCorreo = new Solicitud();
                aux.Conexion = Comun.Conexion;
                datosCorreo = sn.ObtenerDetalleSolicitudCotizacionExtra(aux);
                string contenido = string.Empty;
                switch (this.IDTipoSolicitud)
                {
                    case 1: contenido = EnvioCorreo.GenerarHtmlPaqueteCotizado(datosCorreo);
                        break;
                    case 2: contenido = EnvioCorreo.GenerarHtmlToursCotizado(datosCorreo);
                        break;
                    case 3: contenido = EnvioCorreo.GenerarHtmlHotelesCotizado(datosCorreo);
                        break;
                    case 4: contenido = EnvioCorreo.GenerarHtmlTransportacionCotizado(datosCorreo);
                        break;
                    case 5: contenido = EnvioCorreo.GenerarHtmlPaqueteVipCotizado(datosCorreo);
                        break;
                }
                //datosCorreo.Cliente.CorreoElectronico = "lackke.141727@gmail.com";
                return EnvioCorreo.EnviarCorreo(
                                         ConfigurationManager.AppSettings.Get("CorreoTxt")
                                        , ConfigurationManager.AppSettings.Get("PasswordTxt")
                                        , datosCorreo.Cliente.CorreoElectronico
                                        , datosCorreo.Cotizacion != null ? datosCorreo.Cotizacion.Descripcion : datosCorreo.AsuntoCorreo
                                        , contenido
                                        , false
                                        , ""
                                        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("HtmlTxt"))
                                        , ConfigurationManager.AppSettings.Get("HostTxt")
                                        , Convert.ToInt32(ConfigurationManager.AppSettings.Get("PortTxt"))
                                        , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("EnableSslTxt")));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
