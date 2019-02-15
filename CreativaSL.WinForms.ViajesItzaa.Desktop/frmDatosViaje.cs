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
using System.Globalization;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmDatosViaje : Form_Creativa
    {

        #region Variables

        private int TipoSolicitud = 0;
        private int TipoForm = 0;
        private Solicitud _Solicitud = new Solicitud();

        #endregion

        #region Constructor

        public frmDatosViaje(int TipoSol, Solicitud Datos, int Opcion)
        {
            try
            {
                InitializeComponent();
                TipoSolicitud = TipoSol;
                TipoForm = Opcion;
                _Solicitud = Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosViaje()");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.AccionAvanzar();
                }
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

        #region Eventos DateTime 

        private void dtpFechaLlegada_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TipoSolicitud)
                {
                    case 2: this.dtpFechaSalida.Value = this.dtpFechaLlegada.Value;
                        break;
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpFechaLlegada_ValueChanged");
            }
        }

        private void dtpHoraLlegada_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TipoSolicitud)
                {
                    case 2: this.dtpHoraSalida.Value = this.dtpHoraLlegada.Value;
                        break;
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpHoraLlegada_ValueChanged");
            }
        }

        #endregion

        #region Eventos del Formulario

        private void frmDatosViaje_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Datos del Viaje ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosViaje_Load");
            }
        }

        #endregion

        #region Eventos Radio Button

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.rbNo.Checked)
                {
                    this.txtAeropuertoLlegada.Text = string.Empty;
                    this.txtAeropuertoSalida.Text = string.Empty;
                    this.txtAeropuertoLlegada.Enabled = false;
                    this.txtAeropuertoLlegada.TabStop = false;
                    this.txtAeropuertoSalida.Enabled = false;
                    this.txtAeropuertoSalida.TabStop = false;
                }
                else
                {
                    this.txtAeropuertoLlegada.Enabled = true;
                    this.txtAeropuertoLlegada.TabStop = true;
                    this.txtAeropuertoSalida.Enabled = true;
                    this.txtAeropuertoSalida.TabStop = true;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "rbNo_CheckedChanged");
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
                if(hotel.DialogResult ==DialogResult.OK)
                    this.DialogResult = hotel.DialogResult;
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
                    this.DialogResult = producto.DialogResult;
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
                        this.SiguienteFormulario();                   
                        break;
                case 2: 
                    if (this.GuardarDatos())
                    {
                        MessageBox.Show("Datos actualizados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al actualizar los datos. No se puede modificar una solicitud cuya fecha de llegada es menor a la Fecha actual", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default: this.DialogResult = DialogResult.Abort;
                    break;
            }
        }

        private bool ActualizarDatosViaje(Solicitud datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.ActualizarDatosViaje(datos);
                return datos.Validador;
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
                        if (TipoSolicitud == 2 || TipoSolicitud == 4)
                        {
                            band = this.RegistarNuevaSolicitud();
                        }
                        break;
                    case 2: band = this.ActualizarDatosViaje(_Solicitud);
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

        private void InicializarDatos()
        {
            try
            {
                this.rbSi.Checked = false;
                this.rbNo.Checked = true;
                this.txtAeropuertoLlegada.Text = string.Empty;
                this.txtAeropuertoSalida.Text = string.Empty;
                this.dtpFechaLlegada.Value = DateTime.Today;
                DateTime FechaActual = DateTime.Now;
                this.dtpHoraLlegada.Value = FechaActual.AddSeconds(FechaActual.Second * -1);
                this.dtpFechaSalida.Value = DateTime.Today;
                this.dtpHoraSalida.Value = FechaActual.AddSeconds(FechaActual.Second * -1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarDiseño()
        {
            try
            {
                switch (TipoSolicitud)
                {
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                        if (this.rbSi.Checked)
                        {
                            this.ActiveControl = this.rbSi;
                            this.rbSi.Focus();
                        }
                        else
                        {
                            this.ActiveControl = this.rbNo;
                            this.rbNo.Focus();
                        }
                        
                        break;
                    case 2: this.panelBoletos.Enabled = false;
                        this.dtpFechaSalida.Enabled = false;
                        this.dtpHoraSalida.Enabled = false;
                        this.ActiveControl = this.dtpFechaLlegada;
                        this.dtpFechaLlegada.Focus();
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

        private void IniciarForm()
        {
            try
            {
                switch (TipoForm)
                {
                    case 1: this.InicializarDatos();
                        break;
                    case 2: Solicitud aux = this.ObtenerDatosActuales();
                        this.LlenarDatosModificar(aux);
                        break;
                    default: this.InicializarDatos();
                        break;
                }
                this.InicializarDiseño();

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
                    if (aux.TieneBoletosAvion)
                    {
                        this.rbSi.Checked = true;
                        this.rbNo.Checked = false;
                    }
                    else
                    {
                        this.rbSi.Checked = false;
                        this.rbNo.Checked = true;
                    }
                    this.txtAeropuertoLlegada.Text = aux.AeropueroLlegada;
                    this.txtAeropuertoSalida.Text = aux.AeropuertoSalida;
                    this.dtpFechaLlegada.Value = aux.FechaLlegada;
                    DateTime FechaActual;
                    FechaActual = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + aux.HoraLlegada, CultureInfo.CurrentCulture);
                    this.dtpHoraLlegada.Value = FechaActual;
                    this.dtpFechaSalida.Value = aux.FechaSalida;
                    FechaActual = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + aux.HoraSalida, CultureInfo.CurrentCulture);
                    this.dtpHoraSalida.Value = FechaActual;
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
                aux = sn.ObtenerDatosModificarFechasViaje(aux);
                return aux;
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
                this._Solicitud.TieneBoletosAvion = this.TieneBoletoAvion();
                this._Solicitud.AeropueroLlegada = this.txtAeropuertoLlegada.Text;
                this._Solicitud.AeropuertoSalida = this.txtAeropuertoSalida.Text;
                this._Solicitud.FechaLlegada = this.dtpFechaLlegada.Value;
                this._Solicitud.FechaSalida = this.dtpFechaSalida.Value;
                this._Solicitud.HoraLlegada = this.dtpHoraLlegada.Value.ToString("HH:mm:ss");
                this._Solicitud.HoraSalida = this.dtpHoraSalida.Value.ToString("HH:mm:ss");
                this._Solicitud.IDUsuario = Comun.IDUsuario;
                this._Solicitud.Conexion = Comun.Conexion;
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
                    case 4: 
                    case 5: this.AbrirFormElegirProducto();
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

        private bool TieneBoletoAvion()
        {
            try
            {
                bool band = false;
                if ((this.rbSi.Checked && this.rbNo.Checked) || (!this.rbSi.Checked && !this.rbNo.Checked))
                    band = false;
                else
                    band = this.rbSi.Checked;
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarFechas()
        {
            try
            {
                DateTime FechaLlegada, FechaSalida;
                FechaLlegada = DateTime.Parse(this.dtpFechaLlegada.Value.ToShortDateString() + " " + this.dtpHoraLlegada.Value.ToString("HH:mm:ss"));
                FechaSalida = DateTime.Parse(this.dtpFechaSalida.Value.ToShortDateString() + " " + this.dtpHoraSalida.Value.ToString("HH:mm:ss"));
                if (FechaLlegada < DateTime.Now)
                    return 1;
                else
                {
                    if (FechaSalida < FechaLlegada)
                        return 2;
                    else
                        return 0;
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
                if ((this.rbSi.Checked && this.rbNo.Checked) || (!this.rbSi.Checked && !this.rbNo.Checked))
                {
                    errores.Add(1, "Responda a la pregunta ¿Tiene Boleto de avión? ");
                }
                switch (this.ValidarFechas())
                {
                    case 1: errores.Add(2, "La fecha de Llegada no puede ser menor a la fecha actual.");
                        break;
                    case 2: errores.Add(3, "La fecha de Salida no puede ser menor a la fecha de Llegada.");
                        break;
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
