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
using System.Globalization;
namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmElegirCliente : Form_Creativa
    {
        #region Variables

        private int TipoForm = 0;
        private int TipoSolicitud = 0;
        private Cliente Cliente = new Cliente();
        private Solicitud _Solicitud = new Solicitud();
        public Solicitud resultado = new Solicitud();
        #endregion

        #region Constructor

        public frmElegirCliente(int tipo)
        {
            try
            {
                InitializeComponent();
                TipoSolicitud = tipo;
                TipoForm = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmElegirCliente()");
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmElegirCliente_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Elegir Cliente ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmElegirCliente_Load");
            }
        }

        #endregion

        #region Eventos Click

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ObtenerEsEmpresaCliente())
                {
                    frmCatEmpresas empresas = new frmCatEmpresas();
                    empresas.ISBusqueda = true;
                    if (string.IsNullOrWhiteSpace(this.txtBusquedaCliente.Text) || string.IsNullOrEmpty(this.txtBusquedaCliente.Text))
                        empresas.Busqueda = string.Empty;
                    else
                        empresas.Busqueda = this.txtBusquedaCliente.Text;
                    empresas.ShowDialog();
                    empresas.Dispose();
                    if (empresas.DialogResult == DialogResult.OK)
                    {
                        Cliente.IDCliente = empresas.EmpresaSeleccionada.IDEmpresa;
                        Cliente.Nombre = empresas.EmpresaSeleccionada.NombreComercial;
                        Cliente.Telefono = empresas.EmpresaSeleccionada.Telefono;
                        Cliente.CorreoElectronico = empresas.EmpresaSeleccionada.Correo;
                    }
                    else
                        Cliente = new Cliente();
                }
                else
                {
                    frmCatClientes clientes = new frmCatClientes();
                    clientes.ISBusqueda = true;
                    if (string.IsNullOrWhiteSpace(this.txtBusquedaCliente.Text) || string.IsNullOrEmpty(this.txtBusquedaCliente.Text))
                        clientes.Busqueda = string.Empty;
                    else
                        clientes.Busqueda = this.txtBusquedaCliente.Text;
                    clientes.ShowDialog();
                    clientes.Dispose();
                    if (clientes.DialogResult == DialogResult.OK)
                        Cliente = clientes.ClienteSeleccionado;
                    else
                        Cliente = new Cliente();
                }
                this.LlenarDatosCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusqueda_Click");
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatos())
                    this.AccionAvanzar();
                else
                    this.MostrarMensajeError();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnContinuar_Click");
            }
        }

        private void btnMontoInicial_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutorizacion autorizar = new frmAutorizacion();
                autorizar.IDTabla = string.Empty;
                autorizar.NombreTabla = "tbl_SolicitudCotizaciones";
                autorizar.Texto = "Formulario de Captura de Cliente.";
                autorizar.ShowDialog();
                autorizar.Dispose();
                if (autorizar.DialogResult == DialogResult.OK)
                {
                    frmMontoInicial monto = new frmMontoInicial();
                    monto.Datos = this._Solicitud;
                    monto.ShowDialog();
                    monto.Dispose();
                    if (monto.DialogResult == DialogResult.OK)
                    {
                        this._Solicitud = monto.Datos;
                        this._Solicitud.IDAutenticacion = autorizar.usuarioAutoriza.IDAutenticacion;
                        this.txtMontoInicial.Text = string.Format("{0:c}", _Solicitud.MontoInicial);
                        this.txtMotivoMontoInicial.Text = _Solicitud.MotivoMontoInicial;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnMontoInicial_Click");
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

        #region Eventos KeyPress

        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btnBusqueda_Click(this.btnBusqueda, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtBusquedaCliente_KeyPress");
            }
        }

        #endregion

        #region Eventos RadioButton

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.rbCliente.Checked)
                    this.label4.Text = "Cliente:";                
                else
                    if (this.rbEmpresa.Checked)
                        this.label4.Text = "Empresa:";
                this.Cliente = new Cliente();
                this.LlenarDatosCliente();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "rbCliente_CheckedChanged");
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
                this.Visible = true;
                hotel.Dispose();
                this.DialogResult = hotel.DialogResult;
                if (hotel.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.resultado = this._Solicitud;
                    MessageBox.Show("Solicitud registrada correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                this.Visible = true;
                viaje.Dispose();
                this.DialogResult = viaje.DialogResult;
                if (viaje.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.resultado = this._Solicitud;
                    MessageBox.Show("Solicitud registrada correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AbrirFormElegirProducto()
        {
            try
            {
                frmElegirProducto producto = new frmElegirProducto(TipoSolicitud, this._Solicitud, TipoForm);
                this.Visible = false;
                producto.ShowDialog();
                this.Visible = true;
                producto.Dispose();                
                if (producto.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.resultado = this._Solicitud;
                    MessageBox.Show("Solicitud registrada correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                case 1:
                    this._Solicitud = this.ObtenerDatosSolicitud();
                    this.SiguienteFormulario();
                    break;
                case 2:
                    if (this.GuardarDatos())
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    break;
                default: this.DialogResult = DialogResult.Abort;
                    break;
            }
        }

        private bool GuardarDatos()
        {
            try
            {
                bool band = false;
                this._Solicitud = this.ObtenerDatosSolicitud();
                switch (TipoForm)
                {
                    case 1:
                    case 2: 
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
                this.txtMontoInicial.Text = string.Format("{0:C}", 0);
                this.txtMotivoMontoInicial.Text = string.Empty;
                this.rbCliente.Checked = true;
                this.rbEmpresa.Checked = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool InsertarSolicitud(Solicitud datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.InsertarSolicitud(datos);
                if (datos.Validador)
                    _Solicitud.IDSolicitud = datos.IDSolicitud;
                else
                    _Solicitud.IDSolicitud = string.Empty;
                return datos.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatosCliente()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Cliente.IDCliente))
                {
                    this.txtNombreCliente.Text = (this.Cliente.Nombre + " " + this.Cliente.ApellidoPaterno + " " + this.Cliente.ApellidoMaterno).ToUpper();
                    this.txtCorreo.Text = this.Cliente.CorreoElectronico.ToUpper();
                    this.txtTelefono.Text = this.Cliente.Telefono;
                }
                else
                {
                    this.txtNombreCliente.Text = string.Empty;
                    this.txtCorreo.Text = string.Empty;
                    this.txtTelefono.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError()
        {
            try
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = "Debe seleccionar un cliente.";
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
                Solicitud datos = new Solicitud();
                datos.IDSolicitud = string.Empty;
                datos.IDStatusSolicitud = 1;
                datos.FechaLlegada = DateTime.Today;
                datos.HoraLlegada = string.Empty;
                datos.FechaSalida = DateTime.Today;
                datos.HoraSalida = string.Empty;
                datos.IDProducto = string.Empty;
                datos.IDTipoVehiculo = string.Empty;
                datos.CategoriaHotel = 0;
                datos.NumHabitaciones = 0;
                datos.NumDias = 0;
                datos.NumNoches = 0;
                datos.NumAdultos = 0;
                datos.NumMenores4 = 0;
                datos.NumMenores11 = 0;
                datos.DiasExtra = 0;
                datos.OtrosServicios = string.Empty;
                datos.Observaciones = string.Empty;
                datos.FolioAnterior = string.Empty;
                datos.AeropueroLlegada = string.Empty;
                datos.AeropuertoSalida = string.Empty;
                //Datos del Formulario
                datos.IDCliente = Cliente.IDCliente;
                datos.IDTipoSolicitud = TipoSolicitud;
                decimal MontoInicial = 0;
                decimal.TryParse(this.txtMontoInicial.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out MontoInicial);
                datos.MontoInicial = MontoInicial;
                datos.MotivoMontoInicial = this.txtMotivoMontoInicial.Text;
                datos.EsEmpresa = this.ObtenerEsEmpresaCliente();
                datos.TablaHabitaciones = this.ObtenerDatosTablaHabitaciones();
                datos.TablaItinerario = this.ObtenerDatosTablaItinerario();
                datos.IDUsuario = Comun.IDUsuario;
                datos.Conexion = Comun.Conexion;
                datos.IDAutenticacion = _Solicitud.IDAutenticacion;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerDatosTablaHabitaciones()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("NumCamas", typeof(int));
                tabla.Columns.Add("NumAdultos", typeof(int));
                tabla.Columns.Add("NumMenores4", typeof(int));
                tabla.Columns.Add("NumMenores11", typeof(int));
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerDatosTablaItinerario()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Orden", typeof(int));
                tabla.Columns.Add("NumeroDias", typeof(int));
                tabla.Columns.Add("IDLugar", typeof(string));
                tabla.Columns.Add("Lugar", typeof(string));
                tabla.Columns.Add("Descripcion", typeof(string));
                tabla.Columns.Add("DescripcionIngles", typeof(string));
                tabla.Columns.Add("Observaciones", typeof(string));
                tabla.Columns.Add("ObservacionesIngles", typeof(string));
                tabla.Columns.Add("Recomendaciones", typeof(string));
                tabla.Columns.Add("RecomendacionesIngles", typeof(string));                
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ObtenerEsEmpresaCliente()
        {
            try
            {
                return this.rbEmpresa.Checked;
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
                    case 4:
                    case 5: this.AbrirFormDatosViaje();
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

        private bool ValidarDatos()
        {
            try
            {
                if (string.IsNullOrEmpty(Cliente.IDCliente) || string.IsNullOrWhiteSpace(Cliente.IDCliente))
                {
                    return false;
                }
                else
                {
                    return true;
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
