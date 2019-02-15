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
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using System.Collections;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmAgregarLugarItinerario : Form_Creativa
    {
        #region Variables

        private int TipoForm = 0;

        private LugarTuristico _Lugar;
        public LugarTuristico Lugar
        {
            get { return _Lugar; }
            set { _Lugar = value; }
        }

        private List<LugarTuristico> Lista = new List<LugarTuristico>();

        #endregion

        #region Constructor

        public frmAgregarLugarItinerario(int Opcion, LugarTuristico Datos, List<LugarTuristico> Itinerario)
        {
            try
            {
                InitializeComponent();
                this.TipoForm = Opcion;
                this._Lugar = Datos;
                this.Lista = Itinerario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAgregarLugarItinerario()");
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmAgregarLugarItinerario_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Lugares Turísticos ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAgregarLugarItinerario_Load");
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
                Hashtable errores = this.ValidarDatos();
                if(errores.Count == 0)
                {
                    LugarTuristico LugarDatos = this.ObtenerDatos();
                    if (this.ExisteLugar(LugarDatos) && TipoForm == 1)
                    {
                        if (MessageBox.Show("El Lugar ya está dentro del Itinerario. \r\n ¿Desea Agregarlo Nuevamente?", Comun.CaptionSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this._Lugar = LugarDatos;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        this._Lugar = LugarDatos;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                    this.MostrarMensajeError(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
            }
        }

        #endregion

        #region Eventos Control TextBox

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                Validaciones validar = new Validaciones();
                validar.PermitirSoloNumerosDecimales(e, txt.Text);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtOrden_KeyPress");
            }
        }

        private void txtOrden_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int aux = 0;
                TextBox txt = (TextBox)sender;
                int.TryParse(txt.Text, out aux);
                txt.Text = aux.ToString();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtOrden_Validating");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarComboLugares()
        {
            try
            {
                LugarTuristico datos = new LugarTuristico();
                LugarTuristico_Negocio ltn = new LugarTuristico_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbLugares.DisplayMember = "Lugar";
                this.cmbLugares.ValueMember = "IDLugar";
                this.cmbLugares.DataSource = ltn.LlenarComboLugaresTuristicos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnCombo(string valor)
        {
            try
            {
                bool band = false;
                foreach (LugarTuristico item in this.cmbLugares.Items)
                {
                    if (item.IDLugar == valor)
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

        private bool ExisteLugar(LugarTuristico Nuevo)
        {
            try
            {
                bool band = false;
                foreach (LugarTuristico LugarDatos in this.Lista)
                {
                    if (LugarDatos.IDLugar == Nuevo.IDLugar)
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

        private bool ExisteNumOrden(LugarTuristico Nuevo)
        {
            try
            {
                bool band = false;
                if (Nuevo.OrdenAnterior != Nuevo.Orden)
                {
                    foreach (LugarTuristico LugarDatos in this.Lista)
                    {
                        if (LugarDatos.Orden == Nuevo.Orden)
                        {
                            band = true;
                            break;
                        }
                    }
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
                this.CargarComboLugares();
                this.IniciarDatos(this._Lugar);
                switch(TipoForm)
                {
                    case 1: this.ActiveControl = this.cmbLugares;
                            this.cmbLugares.Focus();
                            break;
                    case 2: this.ActiveControl = this.txtOrden;
                            this.txtOrden.Focus();
                            break;
                    default: break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatos(LugarTuristico Datos)
        {
            try
            {
                if (string.IsNullOrEmpty(Datos.IDLugar))
                {
                    this.txtOrden.Text = "0";
                    this.txtNumDias.Text = "0";
                    this.txtDescripcion.Text = string.Empty;
                    this.txtDescripcion.Text = string.Empty;
                    this.txtObservaciones.Text = string.Empty;
                    this.txtObservacionesIngles.Text = string.Empty;
                    this.txtRecomendaciones.Text = string.Empty;
                    this.txtRecomendacionesIngles.Text = string.Empty;
                }
                else
                {
                    if (this.ExisteItemEnCombo(Datos.IDLugar))
                    {
                        this.cmbLugares.Enabled = false;
                        this.cmbLugares.SelectedValue = Datos.IDLugar;
                    }
                    this.txtOrden.Text = Datos.Orden.ToString();
                    this.txtNumDias.Text = Datos.NumeroDias.ToString();
                    this.txtDescripcion.Text = Datos.Descripcion;
                    this.txtDescripcion.Text = Datos.DescripcionIngles;
                    this.txtObservaciones.Text = Datos.Observaciones;
                    this.txtObservacionesIngles.Text = Datos.ObservacionesIngles;
                    this.txtRecomendaciones.Text = Datos.Recomendaciones;
                    this.txtRecomendacionesIngles.Text = Datos.RecomendacionesIngles;
                }
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

        private int ObtenerDatoEntero(string texto)
        {
            try
            {
                int aux = 0;
                int.TryParse(texto, out aux);
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LugarTuristico ObtenerDatos()
        {
            try
            {
                LugarTuristico LugarDatos = new LugarTuristico();
                //LugarTuristico Aux =  new LugarTuristico();
                LugarDatos = this.ObtenerLugarSeleccionado();
                LugarDatos.Orden = this.ObtenerDatoEntero(this.txtOrden.Text);
                LugarDatos.NumeroDias = this.ObtenerDatoEntero(this.txtNumDias.Text);
                LugarDatos.Descripcion = this.txtDescripcion.Text;
                LugarDatos.DescripcionIngles = this.txtDescripcionIngles.Text;
                LugarDatos.Observaciones = this.txtObservaciones.Text;
                LugarDatos.ObservacionesIngles = this.txtObservacionesIngles.Text;
                LugarDatos.Recomendaciones = this.txtRecomendaciones.Text;
                LugarDatos.RecomendacionesIngles = this.txtRecomendacionesIngles.Text;
                return LugarDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LugarTuristico ObtenerLugarSeleccionado()
        {
            try
            {
                LugarTuristico datos = new LugarTuristico();
                datos.IDLugar = string.Empty;
                if (this.cmbLugares.Items.Count > 0)
                {
                    if (this.cmbLugares.SelectedIndex != -1)
                    {
                        datos = (LugarTuristico)this.cmbLugares.SelectedItem;
                    }
                }
                return datos;
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
                if (!this.ValidarSeleccionLugar())
                    errores.Add(1, "Seleccione un lugar Turístico de la lista desplegable");
                if (!this.ValidarDatoEntero(this.txtOrden.Text))
                    errores.Add(2, "Ingrese un dato válido para el campo Orden.");
                if (this.ObtenerDatoEntero(this.txtOrden.Text) <= 0)
                    errores.Add(3, "Ingrese un número mayor a 0 para el campo Orden.");
                LugarTuristico Datos = this.ObtenerLugarSeleccionado();
                Datos.Orden = this.ObtenerDatoEntero(this.txtOrden.Text);
                Datos.OrdenAnterior = this._Lugar.OrdenAnterior;
                if(this.ExisteNumOrden(Datos))
                    errores.Add(4, "El Número ingresado para Orden ya existe.");
                if(!this.ValidarDatoEntero(this.txtNumDias.Text))
                    errores.Add(5, "Ingrese un dato válido para el campo Número de Días.");
                if (this.ObtenerDatoEntero(this.txtNumDias.Text) <= 0)
                    errores.Add(6, "Ingrese un número mayor a 0 para el campo Número de Días.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarSeleccionLugar()
        {
            try
            {
                bool band = false;
                if (this.cmbLugares.Items.Count > 0)
                {
                    if (this.cmbLugares.SelectedIndex != -1)
                    {
                        LugarTuristico LugarDatos = (LugarTuristico)this.cmbLugares.SelectedItem;
                        if (!string.IsNullOrEmpty(LugarDatos.IDLugar))
                        {
                            band = true;
                        }
                    }
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarDatoEntero(string texto)
        {
            try
            {
                int aux = 0;
                return int.TryParse(texto, out aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        
    }
}
