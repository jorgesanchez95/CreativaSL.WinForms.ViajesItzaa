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
using CreativaSL.WinForms.ViajesItzaa.Desktop;
using System.IO;
using System.Collections;
namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmAsignarRecursos : Form_Creativa
    {
        #region Variables

        private Solicitud Datos = new Solicitud();

        #endregion

        #region Constructor

        public frmAsignarRecursos(Solicitud aux)
        {
            try
            {
                InitializeComponent();
                Datos = aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarRecursos");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnRegresar_Click(object sender, EventArgs e)
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
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    Solicitud aux = this.ObtenerDatosRecursos();
                    Solicitud_Negocio sn = new Solicitud_Negocio();
                    sn.ActualizarRecursos(aux);
                    if (aux.Validador)
                    {
                        MessageBox.Show("Recursos actualizados correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        //MessageBox.Show("Ocurrió un error al actualizar los recursos. Intente Nuevamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MostarMensajeError(aux.Opcion);
                    }
                }
                else
                    this.MostarMensajeErrorValidacion(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmAsignarRecursos_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Asignar Recursos";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarRecursos_Load");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarComboChofer(string IDChofer)
        {
            try
            {
                Solicitud aux = new Solicitud();
                aux.Conexion = Comun.Conexion;
                aux.IDChofer = IDChofer;
                aux.IDSolicitud = this.Datos.IDSolicitud;
                Chofer_Negocio cn = new Chofer_Negocio();
                this.cmbChofer.DataSource = cn.ObtenerComboRecursoChofer(aux);
                this.cmbChofer.DisplayMember = "NombreChofer";
                this.cmbChofer.ValueMember = "IDChofer";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboHotel(string IDHotel)
        {
            try
            {
                Solicitud aux = new Solicitud();
                aux.Conexion = Comun.Conexion;
                aux.IDHotel = IDHotel;
                aux.IDSolicitud = this.Datos.IDSolicitud;
                Hotel_Negocio hn = new Hotel_Negocio();
                this.cmbHotel.DataSource = hn.ObtenerComboRecursoHotel(aux);
                this.cmbHotel.DisplayMember = "NombreHotel";
                this.cmbHotel.ValueMember = "IDHotel";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboHotel2()
        {
            try
            {
                Hotel aux = new Hotel();
                aux.Conexion = Comun.Conexion;
                Hotel_Negocio hn = new Hotel_Negocio();
                this.cmbHotel.DataSource = hn.ObtenerComboRecursoHotel(aux);
                this.cmbHotel.DisplayMember = "NombreHotel";
                this.cmbHotel.ValueMember = "IDHotel";
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
                aux.IDSolicitud = this.Datos.IDSolicitud;
                TipoVehiculo_Negocio tvn = new TipoVehiculo_Negocio();
                this.cmbVehiculo.DataSource = tvn.ObtenerComboRecursoVehiculo(aux);
                this.cmbVehiculo.DisplayMember = "TipoVehiculoDescripcion";
                this.cmbVehiculo.ValueMember = "IDVehiculo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnCombo(int i, string ID)
        {
            try
            {
                bool band = false;
                switch (i)
                {

                    case 1:
                        foreach (Chofer item in this.cmbChofer.Items)
                        {
                            if (item.IDChofer == ID)
                            {
                                band = true;
                                break;
                            }
                        }
                        break;
                    case 2:
                        foreach (Hotel item in this.cmbHotel.Items)
                        {
                            if (item.IDHotel == ID)
                            {
                                band = true;
                                break;
                            }
                        }
                        break;
                    case 3: 
                        foreach (TipoVehiculo item in this.cmbVehiculo.Items)
                        {
                            if (item.IDVehiculo == ID)
                            {
                                band = true;
                                break;
                            }
                        }
                        break;
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatos(Solicitud aux)
        {
            try
            {
                if (this.ExisteItemEnCombo(1, aux.IDChofer))
                {
                    this.cmbChofer.SelectedValue = aux.IDChofer;
                }
                //if (this.Datos.IDTipoSolicitud != 3)
                //{
                //    if (this.ExisteItemEnCombo(2, aux.IDHotel))
                //    {
                //        this.cmbHotel.SelectedValue = aux.IDHotel;
                //    }
                //}
                //else
                //{
                //    if (string.IsNullOrEmpty(aux.IDHotel))
                //    {
                //        this.cmbHotel.SelectedValue = "No";
                //    }
                //    else
                //    {
                //        this.cmbHotel.SelectedValue = "Si";
                //    }
                //}
                this.txtRecursoHotel.Text = aux.IDHotel;
                if (this.ExisteItemEnCombo(3, aux.IDVehiculo))
                {
                    this.cmbVehiculo.SelectedValue = aux.IDVehiculo;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDiseñoForm(Solicitud aux)
        {
            try
            {
                switch (this.Datos.IDTipoSolicitud)
                {
                    case 1:
                    case 5: this.CargarComboChofer(aux.IDChofer);
                        //this.CargarComboHotel(aux.IDHotel);
                        this.CargarComboVehiculo(aux.IDVehiculo);
                        break;
                    case 2:
                    case 4: this.CargarComboChofer(aux.IDChofer);
                        this.CargarComboVehiculo(aux.IDVehiculo);
                        this.cmbHotel.Enabled = false;
                        this.txtRecursoHotel.Enabled = false;
                        break;
                    case 3: //this.CargarComboHotel2();
                        this.cmbChofer.Enabled = false;
                        this.cmbVehiculo.Enabled = false;
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
                Solicitud aux = new Solicitud();
                aux = this.ObtenerDatosActuales();
                if (!string.IsNullOrEmpty(aux.IDSolicitud))
                {
                    this.Datos.IDHotel = aux.IDHotel;
                    this.Datos.IDChofer = aux.IDChofer;
                    this.Datos.IDVehiculo = aux.IDVehiculo;
                    this.IniciarDiseñoForm(aux);
                    this.IniciarDatos(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostarMensajeError(int opcion)
        {
            try
            {
                this.txt_mensaje.Visible = true;
                switch (opcion)
                {
                    case 1: this.txt_mensaje.Text = "El chofer seleccionado no está disponible para las fechas de la solicitud.";
                        break;
                    case 2: this.txt_mensaje.Text = "No se pudo actualizar el hotel.";
                        break;
                    case 3: this.txt_mensaje.Text = "El vehiculo seleccionado no está disponible para las fechas de la solicitud.";
                        break;
                    default: this.txt_mensaje.Text = "Ocurrió un error al actualizar los datos. Contacte a Soporte Técnico.";
                        break;
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
                aux.Conexion = Comun.Conexion;
                aux.IDSolicitud = this.Datos.IDSolicitud;
                aux = sn.ObtenerRecursosAsignados(aux);
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Solicitud ObtenerDatosRecursos()
        {
            try
            {
                Solicitud Aux = new Solicitud();
                Aux.IDChofer = this.ObtenerItemChofer().IDChofer;
                //Aux.IDHotel = this.ObtenerItemHotel().IDHotel;
                Aux.IDHotel = this.txtRecursoHotel.Text;
                Aux.IDVehiculo = this.ObtenerItemVehiculo().IDVehiculo;
                Aux.IDSolicitud = this.Datos.IDSolicitud;
                Aux.IDUsuario = Comun.IDUsuario;
                Aux.Conexion = Comun.Conexion;                
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Chofer ObtenerItemChofer()
        {
            try
            {
                Chofer aux = new Chofer();
                if (this.cmbChofer.Items.Count > 0)
                {
                    if (this.cmbChofer.SelectedIndex != -1)
                    {
                        aux = (Chofer)this.cmbChofer.SelectedItem;
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Hotel ObtenerItemHotel()
        {
            try
            {
                Hotel aux = new Hotel();
                if (this.cmbHotel.Items.Count > 0)
                {
                    if (this.cmbHotel.SelectedIndex != -1)
                    {
                        aux = (Hotel)this.cmbHotel.SelectedItem;
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TipoVehiculo ObtenerItemVehiculo()
        {
            try
            {
                TipoVehiculo aux = new TipoVehiculo();
                if (this.cmbVehiculo.Items.Count > 0)
                {
                    if (this.cmbVehiculo.SelectedIndex != -1)
                    {
                        aux = (TipoVehiculo)this.cmbVehiculo.SelectedItem;
                    }
                }
                return aux;
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
                //if (this.Datos.IDTipoSolicitud == 1 || this.Datos.IDTipoSolicitud == 2
                //    || this.Datos.IDTipoSolicitud == 4 || this.Datos.IDTipoSolicitud == 5)
                //{
                //    Chofer auxChofer = this.ObtenerItemChofer();
                //    if (string.IsNullOrEmpty(auxChofer.IDChofer))
                //        errores.Add(1, "Seleccione un chofer. ");
                //    TipoVehiculo auxVehiculo = this.ObtenerItemVehiculo();
                //    if (string.IsNullOrEmpty(auxVehiculo.IDVehiculo))
                //        errores.Add(2, "Seleccione un Vehículo. ");
                //}
                //if (this.Datos.IDTipoSolicitud == 1 || this.Datos.IDTipoSolicitud == 2
                //    || this.Datos.IDTipoSolicitud == 4 || this.Datos.IDTipoSolicitud == 5)
                //{
                //    Hotel auxHotel = this.ObtenerItemHotel();
                //    if (string.IsNullOrEmpty(auxHotel.IDHotel))
                //        errores.Add(1, "Seleccione un chofer.");
                //}
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
