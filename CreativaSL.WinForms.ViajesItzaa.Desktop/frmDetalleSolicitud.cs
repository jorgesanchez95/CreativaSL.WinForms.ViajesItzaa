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
    public partial class frmDetalleSolicitud : Form_Creativa
    {

        #region Variables/Propiedades

        Solicitud DatosSolicitud = new Solicitud();
        int TipoForm = 0;
        #endregion

        #region Constructor

        public frmDetalleSolicitud(Solicitud Datos, int Tipo)
        {
            try
            {
                InitializeComponent();
                this.DatosSolicitud = Datos;
                this.TipoForm = Tipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDetalleSolicitud");
            }
        }

        #endregion

        #region Eventos 

        #region Eventos Click

        private void btnItinerario_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarEstatusSolicitud(1) && this.DatosSolicitud.IDTipoSolicitud == 5)
                {
                    frmAutorizacion autorizar = new frmAutorizacion();
                    autorizar.IDTabla = string.Empty;
                    autorizar.NombreTabla = "tbl_SolicitudCotizaciones";
                    autorizar.Texto = "Formulario de Modificación de Habitaciones.";
                    autorizar.IDTabla = this.DatosSolicitud.IDSolicitud;
                    autorizar.ShowDialog();
                    autorizar.Dispose();
                    if (autorizar.DialogResult == DialogResult.OK)
                    {
                        frmItinerario moditinerario = new frmItinerario(this.DatosSolicitud.IDTipoSolicitud, this.DatosSolicitud, 2);
                        moditinerario.ShowDialog();
                        moditinerario.Dispose();
                        if (moditinerario.DialogResult == DialogResult.OK)
                        {
                            this.IniciarForm();
                        }
                    }
                }
                else
                    MessageBox.Show("El estatus de la solicitud no permite cambiar el itinerario del servicio.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnItinerario_Click");
            }
        }

        private void btnFechasPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarEstatusSolicitud(2))
                {
                    Solicitud aux = new Solicitud();
                    aux.IDSolicitud = this.DatosSolicitud.IDSolicitud;
                    aux.IDStatusSolicitud = this.DatosSolicitud.IDStatusSolicitud;
                    frmFechasPago cambiarfechas = new frmFechasPago(aux, 2);
                    cambiarfechas.ShowDialog();
                    cambiarfechas.Dispose();
                }
                else
                {
                    MessageBox.Show("El estatus de la solicitud no permite establecer fechas de pago.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnFechasPago_Click");
            }
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCotizacion_Click");
            }
        }

        private void btnFechasViaje_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarEstatusSolicitud(1))
                {
                    frmAutorizacion autorizar = new frmAutorizacion();
                    autorizar.IDTabla = string.Empty;
                    autorizar.NombreTabla = "tbl_SolicitudCotizaciones";
                    autorizar.Texto = "Formulario de Modificación de Fechas Viajes.";
                    autorizar.IDTabla = this.DatosSolicitud.IDSolicitud;
                    autorizar.ShowDialog();
                    autorizar.Dispose();
                    if (autorizar.DialogResult == DialogResult.OK)
                    {
                        frmDatosViaje modfechaViaje = new frmDatosViaje(this.DatosSolicitud.IDTipoSolicitud, this.DatosSolicitud, 2);
                        modfechaViaje.ShowDialog();
                        modfechaViaje.Dispose();
                        if (modfechaViaje.DialogResult == DialogResult.OK)
                        {
                            this.IniciarForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El estatus de la solicitud no permite cambiar el Producto.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnFechasViaje_Click");
            }
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarEstatusSolicitud(1))
                {
                    frmAutorizacion autorizar = new frmAutorizacion();
                    autorizar.IDTabla = string.Empty;
                    autorizar.NombreTabla = "tbl_SolicitudCotizaciones";
                    autorizar.Texto = "Formulario de Modificación de Habitaciones.";
                    autorizar.IDTabla = this.DatosSolicitud.IDSolicitud;
                    autorizar.ShowDialog();
                    autorizar.Dispose();
                    if (autorizar.DialogResult == DialogResult.OK)
                    {
                        frmDatosHotel modHotel = new frmDatosHotel(this.DatosSolicitud.IDTipoSolicitud, this.DatosSolicitud, 2);
                        modHotel.ShowDialog();
                        modHotel.Dispose();
                        if (modHotel.DialogResult == DialogResult.OK)
                            this.IniciarForm();
                    }
                }
                else
                    MessageBox.Show("El estatus de la solicitud no permite cambiar las habitaciones.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnHabitaciones_Click");
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarEstatusSolicitud(1) && this.DatosSolicitud.IDTipoSolicitud != 5)
                {
                    frmAutorizacion autorizar = new frmAutorizacion();
                    autorizar.IDTabla = string.Empty;
                    autorizar.NombreTabla = "tbl_SolicitudCotizaciones";
                    autorizar.Texto = "Formulario de Modificación de Producto.";
                    autorizar.IDTabla = this.DatosSolicitud.IDSolicitud;
                    autorizar.ShowDialog();
                    autorizar.Dispose();
                    if (autorizar.DialogResult == DialogResult.OK)
                    {
                        frmElegirProducto modProducto = new frmElegirProducto(this.DatosSolicitud.IDTipoSolicitud, this.DatosSolicitud, 2);
                        modProducto.ShowDialog();
                        modProducto.Dispose();
                        if (modProducto.DialogResult == DialogResult.OK)
                        {
                            this.IniciarForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El estatus de la solicitud no permite cambiar el Producto.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnProducto_Click");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnRegresar_Click");
            }
        }

        #endregion

        #region Eventos del Formulario

        private void frmDetalleSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Detalles de Solicitud";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDetalleSolicitud_Load");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void IniciarDatosCampos(Solicitud aux)
        {
            try
            {
                //Datos Generales de la solicitud
                this.txtFolioSolicitud.Text = aux.Folio;
                this.txtTipoProducto.Text = aux.TipoSolicitud;
                this.txtStatusSolicitud.Text = aux.EstatusSolicitud;
                this.txtNombreProducto.Text = aux.NombreProducto;
                //Informacion de la solicitud
                this.txtFechaLlegada.Text = aux.FechaLlegada.ToShortDateString();
                this.txtHoraLlegada.Text = aux.HoraLlegada;
                this.txtFechaSalida.Text = aux.FechaSalida.ToShortDateString();
                this.txtHoraSalida.Text = aux.HoraSalida;
                this.txtNumAdultos.Text = aux.NumAdultos.ToString();
                this.txtNumMenores11.Text = aux.NumMenores11.ToString();
                this.txtNumMenores4.Text = aux.NumMenores4.ToString();
                this.txtObservaciones.Text = aux.Observaciones;
                this.chlRequiereFactura.Checked = aux.RequiereFactura;
                //Datos del cliente
                this.txtNombreCliente.Text = aux.Cliente != null ? aux.Cliente.Nombre : string.Empty;
                this.txtCorreo.Text = aux.Cliente != null ? aux.Cliente.CorreoElectronico : string.Empty;
                this.txtTelefono.Text = aux.Cliente != null ? aux.Cliente.Telefono : string.Empty;
                //Datos de la solicitud
                if (!string.IsNullOrEmpty(aux.Cotizacion != null ? aux.Cotizacion.IDCotizacion : string.Empty))
                {
                    this.txtCotizacion.Text = aux.Cotizacion != null ? aux.Cotizacion.Descripcion : string.Empty;
                    this.txtMontoCotizacion.Text = aux.Cotizacion != null ? (aux.Cotizacion.Subtotal > 0 ? string.Format("{0:c}", aux.Cotizacion.Subtotal) : "Sin asignar") : string.Empty;
                }
                else
                {
                    this.txtCotizacion.Text = "NO SELECCIONADA";
                    this.txtMontoCotizacion.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDiseñoForm()
        {
            try
            {
                if (TipoForm == 1)
                {
                    switch (this.DatosSolicitud.IDTipoSolicitud)
                    {
                        case 1: this.btnProducto.Text = "Paquete";
                            this.btnProducto.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources.solicitud01;
                            this.btnItinerario.Visible = false;
                            break;
                        case 2: this.btnProducto.Text = "Tour";
                            this.btnProducto.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources.solicitud02;
                            this.btnItinerario.Visible = false;
                            this.lblFechaSalida.Visible = false;
                            this.txtFechaSalida.Visible = false;
                            this.lblHoraSalida.Visible = false;
                            this.txtHoraSalida.Visible = false;
                            this.lblFechaLlegada.Text = "Fecha Viaje:";
                            this.lblHoraLlegada.Text = "Hora Viaje:";
                            this.lblObservaciones.Location = this.lblHoraSalida.Location;
                            this.txtObservaciones.Location = this.txtHoraSalida.Location;
                            break;
                        case 3: this.btnProducto.Text = "Hotel";
                            this.btnProducto.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources.solicitud03;
                            this.btnItinerario.Visible = false;
                            break;
                        case 4: this.btnProducto.Text = "Vehículo";
                            this.btnProducto.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources.solicitud04;
                            this.btnItinerario.Visible = false;
                            this.lblNumAdultos.Visible = false;
                            this.txtNumAdultos.Visible = false;
                            this.lblNumMenores11.Visible = false;
                            this.txtNumMenores11.Visible = false;
                            this.lblNumMenores4.Visible = false;
                            this.txtNumMenores4.Visible = false;
                            break;
                        case 5: this.btnProducto.Visible = false;
                            this.btnItinerario.Location = this.btnFechasPago.Location;
                            this.btnFechasPago.Location = this.btnFechasViaje.Location;
                            this.btnFechasViaje.Location = this.btnHabitaciones.Location;
                            this.btnHabitaciones.Location = this.btnProducto.Location;
                            break;
                        default: this.btnProducto.Visible = false;
                            break;
                    }
                }
                else
                {
                    this.btnCotizacion.Visible = false;
                    this.btnFechasPago.Visible = false;
                    this.btnFechasViaje.Visible = false;
                    this.btnHabitaciones.Visible = false;
                    this.btnItinerario.Visible = false;
                    this.btnProducto.Visible = false;
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
                this.IniciarDiseñoForm();
                Solicitud aux = this.ObtenerDetalleSolicitud();
                this.IniciarDatosCampos(aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Solicitud ObtenerDetalleSolicitud()
        {
            try
            {
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux.IDSolicitud = this.DatosSolicitud.IDSolicitud;
                aux.Conexion = Comun.Conexion;
                aux = sn.ObtenerDetalleSolicitud(aux);
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarEstatusSolicitud(int op)
        {
            try
            {
                bool band = false;
                switch (op)
                {
                    case 1: if ((this.DatosSolicitud.IDStatusSolicitud >= 2 && this.DatosSolicitud.IDStatusSolicitud <= 8) || (this.DatosSolicitud.IDStatusSolicitud == 14))
                            band = true;
                        break;
                    case 2: if (this.DatosSolicitud.IDStatusSolicitud >= 5 && this.DatosSolicitud.IDStatusSolicitud <= 7)
                            band = true;
                        break;
                }
                return band;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
