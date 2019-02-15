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
using System.Collections;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmElegirProducto : Form_Creativa
    {
        #region Variables

        private int TipoForm = 0;
        private int TipoSolicitud = 0;
        private Solicitud _Solicitud = new Solicitud();

        #endregion

        #region Constructor

        public frmElegirProducto(int TipoSol, Solicitud datos, int TForm)
        {
            try
            {
                InitializeComponent();
                TipoSolicitud = TipoSol;
                TipoForm = TForm;
                _Solicitud = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmElegirProducto()");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                    this.AccionAvanzar();
                else
                    this.MostarMensajeErrorValidacion(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnContinuar_Click");
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

        #region Eventos del Formulario

        private void frmElegirProducto_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Elegir Producto ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmElegirProducto_Load");
            }
        }

        #endregion

        #region Eventos KeyPress

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btnContinuar.Focus();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtObservaciones_KeyPress");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void AbrirFormDatosHotel()
        {
            try
            {
                frmDatosHotel hotel = new frmDatosHotel(TipoSolicitud, _Solicitud, TipoForm);
                this.Visible = false;
                hotel.ShowDialog();
                hotel.Dispose();
                this.Visible = true;
                if (hotel.DialogResult == DialogResult.OK)
                    this.DialogResult = hotel.DialogResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AbrirFormDatosViaje()
        {
            try
            {
                frmDatosViaje viaje = new frmDatosViaje(TipoSolicitud, _Solicitud, TipoForm);
                this.Visible = false;
                viaje.ShowDialog();
                viaje.Dispose();
                this.Visible = true;
                if (viaje.DialogResult == DialogResult.OK)
                    this.DialogResult = viaje.DialogResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AccionAvanzar()
        {
            switch (TipoForm)
            {
                case 1: this.ObtenerDatosSolicitud();
                    if (TipoSolicitud != 4)
                    {
                        this.SiguienteFormulario();
                    }
                    else
                    {
                        if (this.GuardarDatos())
                            this.DialogResult = DialogResult.OK;
                        else
                            MessageBox.Show("El Vehículo no está disponible para la fecha Especificada.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (this.GuardarDatos())
                    {
                        MessageBox.Show("Datos actualizados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        if (TipoSolicitud == 4)
                            MessageBox.Show("Ocurrió un error al actualizar los datos. Es probable que el Vehículo no está disponible para la fecha Especificada. Recuerde que no se puede modificar una solicitud cuya fecha de llegada es menor a la Fecha actual", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Ocurrió un error al actualizar los datos. No se puede modificar una solicitud cuya fecha de llegada es menor a la Fecha actual", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default: this.DialogResult = DialogResult.Abort;
                    break;
            }
        }

        private bool ActualizarDatosProducto(Solicitud datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.ActualizarDatosProducto(datos);
                return datos.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboVehiculo(string IDVehiculo)
        {
            try
            {
                Solicitud aux = new Solicitud();
                aux.Conexion = Comun.Conexion;
                aux.IDVehiculo = IDVehiculo;
                aux.IDSolicitud = this._Solicitud.IDSolicitud;
                TipoVehiculo_Negocio tvn = new TipoVehiculo_Negocio();
                this.cmbProducto.DataSource = tvn.ObtenerComboRecursoVehiculo(aux);
                this.cmbProducto.DisplayMember = "TipoVehiculoDescripcion";
                this.cmbProducto.ValueMember = "IDVehiculo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnComboHotel(string IDProducto)
        {
            try
            {
                bool band = false;

                foreach (Hotel item in this.cmbProducto.Items)
                {
                    if (item.IDHotel == IDProducto)
                    {
                        band = true;
                        break;
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnComboPaquete(string IDProducto)
        {
            try
            {
                bool band = false;

                foreach (Paquete item in this.cmbProducto.Items)
                {
                    if (item.IDPaquete == IDProducto)
                    {
                        band = true;
                        break;
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnComboTour(string IDProducto)
        {
            try
            {
                bool band = false;

                foreach (Tour item in this.cmbProducto.Items)
                {
                    if (item.IDTour == IDProducto)
                    {
                        band = true;
                        break;
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnComboVehiculo(string IDProducto)
        {
            try
            {
                bool band = false;

                foreach (TipoVehiculo item in this.cmbProducto.Items)
                {
                    if (item.IDVehiculo == IDProducto)
                    {
                        band = true;
                        break;
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool GuardarDatos()
        {
            try
            {
                bool band = false;
                this.ObtenerDatosSolicitud();
                switch (TipoForm)
                {
                    case 1: 
                        if (TipoSolicitud == 4)
                        {
                            band = this.RegistarNuevaSolicitud();
                        }
                        break;
                    case 2: band = this.ActualizarDatosProducto(this._Solicitud);
                        break;
                    default: band = false;
                        break;
                }
                return band;
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
                this.InicializarDatos();
                if (TipoForm == 2)
                {
                    Solicitud aux = this.ObtenerDatosActuales();
                    if(this._Solicitud.IDTipoSolicitud == 4)
                        this.CargarComboVehiculo(aux.IDProducto);
                    this.LlenarDatosModificar(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarDatos()
        {
            try
            {
                switch (TipoSolicitud)
                {
                    case 1: this.lblProducto.Text = "Paquete:";
                        this.LlenarComboPaquetes();
                        this.ActiveControl = this.cmbProducto;
                        this.cmbProducto.Focus();
                        break;
                    case 2: this.lblProducto.Text = "Tour:";
                        this.LlenarComboTour();
                        this.ActiveControl = this.cmbProducto;
                        this.cmbProducto.Focus();
                        break;
                    case 3: this.lblProducto.Text = "Hotel:";
                        this.LlenarComboHotel();
                        this.ActiveControl = this.cmbProducto;
                        this.cmbProducto.Focus();
                        break;
                    case 4: this.lblProducto.Text = "Tipo Vehículo:";
                        this.LlenarComboTipoVehiculo();
                        this.ActiveControl = this.cmbProducto;
                        this.cmbProducto.Focus();
                        break;
                    case 5: this.panelProductoPrincipal.Visible = false;
                        this.ActiveControl = this.txtObservaciones;
                        this.txtObservaciones.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboHotel()
        {
            try
            {
                Hotel datos = new Hotel();
                Hotel_Negocio hn = new Hotel_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbProducto.DataSource = hn.ObtenerComboHotel(datos);
                this.cmbProducto.DisplayMember = "NombreHotel";
                this.cmbProducto.ValueMember = "IDHotel";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboPaquetes()
        {
            try
            {
                Paquete datos = new Paquete();
                Paquete_Negocio paqneg = new Paquete_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbProducto.DataSource = paqneg.ObtenerComboPaquete(datos);
                this.cmbProducto.DisplayMember = "NombrePaquete";
                this.cmbProducto.ValueMember = "IDPaquete";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboTipoVehiculo()
        {
            try
            {
                TipoVehiculo datos = new TipoVehiculo();
                TipoVehiculo_Negocio tvn = new TipoVehiculo_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                datos.FechaInicio = _Solicitud.FechaLlegada;
                datos.FechaFin = _Solicitud.FechaSalida;
                this.cmbProducto.DataSource = tvn.ObtenerComboTipoVehiculo(datos);
                this.cmbProducto.DisplayMember = "TipoVehiculoDescripcion";
                this.cmbProducto.ValueMember = "IDVehiculo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboTour()
        {
            try
            {
                Tour datos = new Tour();
                Tour_Negocio tn = new Tour_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbProducto.DataSource = tn.ObtenerComboTour(datos);
                this.cmbProducto.DisplayMember = "NombreTour";
                this.cmbProducto.ValueMember = "IDTour";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatosModificar(Solicitud aux)
        {
            try
            {
                if (!string.IsNullOrEmpty(aux.IDSolicitud))
                {
                    switch (this._Solicitud.IDTipoSolicitud)
                    {
                        case 1: if (this.ExisteItemEnComboPaquete(aux.IDProducto))
                                this.cmbProducto.SelectedValue = aux.IDProducto;
                            break;
                        case 2: if (this.ExisteItemEnComboTour(aux.IDProducto))
                                this.cmbProducto.SelectedValue = aux.IDProducto;
                            break;
                        case 3: if (this.ExisteItemEnComboHotel(aux.IDProducto))
                                this.cmbProducto.SelectedValue = aux.IDProducto;
                            break;
                        case 4: if (this.ExisteItemEnComboVehiculo(aux.IDProducto))
                                this.cmbProducto.SelectedValue = aux.IDProducto;
                            break;
                    }
                    this.txtObservaciones.Text = aux.Observaciones;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostarMensajeErrorValidacion(Hashtable errores)
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

        private Solicitud ObtenerDatosActuales()
        {
            try
            {
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux.IDSolicitud = this._Solicitud.IDSolicitud;
                aux.Conexion = Comun.Conexion;
                aux = sn.ObtenerDatosModificarProducto(aux);
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Hotel ObtenerDatosHotel()
        {
            try
            {
                Hotel datos = new Hotel();
                if (this.cmbProducto.Items.Count > 0)
                {
                    if (this.cmbProducto.SelectedIndex != -1)
                    {
                        datos = (Hotel)this.cmbProducto.SelectedItem;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Paquete ObtenerDatosPaquete()
        {
            try
            {
                Paquete datos = new Paquete();
                if (this.cmbProducto.Items.Count > 0)
                {
                    if (this.cmbProducto.SelectedIndex != -1)
                    {
                        datos = (Paquete)this.cmbProducto.SelectedItem;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatosSolicitud()
        {
            try
            {   
                this._Solicitud.Opcion = TipoForm;
                this._Solicitud.Observaciones = this.txtObservaciones.Text;
                this._Solicitud.IDSolicitud = _Solicitud.IDSolicitud;
                this._Solicitud.IDTipoVehiculo = string.Empty;
                this._Solicitud.IDUsuario = Comun.IDUsuario;
                this._Solicitud.Conexion = Comun.Conexion;
                switch (TipoSolicitud)
                {
                    case 1: Paquete paquete = this.ObtenerDatosPaquete();
                        this._Solicitud.IDProducto = paquete.IDPaquete;                        
                        break;
                    case 2: Tour tour = this.ObtenerDatosTour();
                        this._Solicitud.IDProducto = tour.IDTour;
                        break;
                    case 3: Hotel hotel = this.ObtenerDatosHotel();
                        this._Solicitud.IDProducto = hotel.IDHotel;
                        this._Solicitud.CategoriaHotel = hotel.CategoriaHotel;
                        break;
                    case 4: TipoVehiculo tipoVehiculo = this.ObtenerDatosTipoVehiculo();
                        this._Solicitud.IDProducto = tipoVehiculo.IDVehiculo;
                        this._Solicitud.IDTipoVehiculo = tipoVehiculo.IDTipoVehiculo;
                        break;
                    case 5: this._Solicitud.IDProducto = string.Empty;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TipoVehiculo ObtenerDatosTipoVehiculo()
        {
            try
            {
                TipoVehiculo datos = new TipoVehiculo();
                if (this.cmbProducto.Items.Count > 0)
                {
                    if (this.cmbProducto.SelectedIndex != -1)
                    {
                        datos = (TipoVehiculo)this.cmbProducto.SelectedItem;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Tour ObtenerDatosTour()
        {
            try
            {
                Tour datos = new Tour();
                if (this.cmbProducto.Items.Count > 0)
                {
                    if (this.cmbProducto.SelectedIndex != -1)
                    {
                        datos = (Tour)this.cmbProducto.SelectedItem;
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool RegistarNuevaSolicitud()
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.NuevaSolicitud(this._Solicitud);
                return this._Solicitud.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SiguienteFormulario()
        {
            try
            {
                switch (TipoSolicitud)
                {
                    case 1: 
                    case 2:
                    case 3: 
                    case 5: this.AbrirFormDatosHotel();
                        break;
                    default: this.DialogResult = DialogResult.OK;
                        break;
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
                if (this.cmbProducto.Items.Count > 0)
                {
                    if (this.cmbProducto.SelectedIndex != -1)
                    {
                        object seleccionado = this.cmbProducto.SelectedItem;
                        switch (TipoSolicitud)
                        {
                            case 1: Paquete paquete = (Paquete)seleccionado;
                                if (string.IsNullOrEmpty(paquete.IDPaquete))
                                    errores.Add(1, "Seleccione un Paquete. ");
                                break;
                            case 2: Tour tour = (Tour)seleccionado;
                                if (string.IsNullOrEmpty(tour.IDTour))
                                    errores.Add(1, "Seleccione un Tour. ");
                                break;
                            case 3: Hotel hotel = (Hotel)seleccionado;
                                if (string.IsNullOrEmpty(hotel.IDHotel))
                                    errores.Add(1, "Seleccione un Hotel. ");
                                break;
                            case 4: TipoVehiculo tipoVehiculo = (TipoVehiculo)seleccionado;
                                if (string.IsNullOrEmpty(tipoVehiculo.IDVehiculo))
                                    errores.Add(1, "Seleccione un Vehiculo. ");
                                break;                            
                            default:
                                break;
                        }
                    }
                    else
                    {
                        errores.Add(1, "Seleccione un elemento de la lista.");
                    }
                }
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
