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
using System.Collections;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmDatosHotel : Form_Creativa
    {

        #region Variables

        private int TipoSolicitud = 0;
        private int TipoForm = 0;
        private Solicitud _Solicitud = new Solicitud();
        #endregion

        #region Constructor

        public frmDatosHotel(int TipoSol, Solicitud datos, int Opcion)
        {
            try
            {
                InitializeComponent();
                TipoSolicitud = TipoSol;
                TipoForm = Opcion;
                _Solicitud = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosHotel()");
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

        private void frmDatosHotel_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Datos del Hotel ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmDatosHotel_Load");
            }
        }

        #endregion

        #region Eventos Control TextBox

        private void dgvHabitaciones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                this.dgvHabitaciones.Rows[e.RowIndex].ErrorText = "";
                int newInteger;
                if (this.dgvHabitaciones.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgvHabitaciones_CellValidating");
            }
        }

        private void txtTotalHabitaciones_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.AgregarColumnasGrid(this.ObtenerTotalHabitaciones());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtTotalHabitaciones_KeyUp");
            }
        }

        private void txtTotalHabitaciones_Validated(object sender, EventArgs e)
        {
            try
            {
                this.AgregarColumnasGrid(this.ObtenerTotalHabitaciones());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtTotalHabitaciones_Validated");
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.dgvHabitaciones.Focus();
                }
                else
                {
                    Validaciones validar = new Validaciones();
                    validar.SoloNumerico(e);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNumero_KeyPress");
            }
        }

        private void txtNum_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.DibujarTotalPersonas();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNum_KeyUp");
            }
        }

        private void txtNum_Validated(object sender, EventArgs e)
        {
            try
            {
                this.DibujarTotalPersonas();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNum_Validated");
            }
        }

        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextBox aux = (TextBox)sender;
                if (string.IsNullOrEmpty(aux.Text) || string.IsNullOrWhiteSpace(aux.Text))
                {
                    aux.Text = "0";
                }
                else
                {
                    int total = 0;
                    if (!int.TryParse(aux.Text, out total))
                    {
                        aux.Text = "0";
                    }
                    else
                    {
                        if (total < 0)
                        {
                            aux.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtNum_Validating");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void AbrirFormItinerario()
        {
            try
            {
                frmItinerario itinerario = new frmItinerario(TipoSolicitud, _Solicitud, TipoForm);
                this.Visible = false;
                itinerario.ShowDialog();
                itinerario.Dispose();
                this.Visible = true;
                if (itinerario.DialogResult == DialogResult.OK)
                    this.DialogResult = itinerario.DialogResult;
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
                    if (TipoSolicitud != 1 && TipoSolicitud != 2 && TipoSolicitud != 3)
                    {
                        this.SiguienteFormulario();
                    }
                    else
                    {
                        if (this.GuardarDatos())
                            this.DialogResult = DialogResult.OK;
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
                        MessageBox.Show("Ocurrió un error al actualizar los datos. No se puede modificar una solicitud cuya fecha de llegada es menor a la Fecha actual", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default: this.DialogResult = DialogResult.Abort;
                    break;
            }
        }

        private bool ActualizarDatosHotel(Solicitud datos)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.ActualizarDatosHabitaciones(datos);
                return datos.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AgregarColumnasGrid(int Columnas)
        {
            try
            {
                if (TipoForm == 1)
                {
                    this.dgvHabitaciones.Rows.Clear();
                    if (Columnas > 0)
                    {
                        this.dgvHabitaciones.Rows.Add(Columnas);
                    }
                    foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                    {
                        fila.Cells["Adultos"].Value = "0";
                        fila.Cells["Menores4"].Value = "0";
                        fila.Cells["Menores11"].Value = "0";
                        fila.Cells["Camas"].Value = "0";
                    }
                }
                else if(TipoForm == 2)
                {
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("Camas", typeof(int));
                    tabla.Columns.Add("Adultos", typeof(int));
                    tabla.Columns.Add("Menores4", typeof(int));
                    tabla.Columns.Add("Menores11", typeof(int));
                    for (int i = 0; i < Columnas; i++)
                    {
                        tabla.Rows.Add(new Object[] { 
                                "0",
                                "0",
                                "0",
                                "0"
                            });
                    }
                    BindingSource datos = new BindingSource();
                    datos.DataSource = tabla;
                    this.dgvHabitaciones.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DibujarTotalPersonas()
        {
            try
            {
                this.txtTotalPersonas.Text = this.ObtenerTotalPersonas().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteItemEnCombo(float valor)
        {
            try
            {
                bool band = false;
                foreach (CategoriaHotel item in this.cmbCategoriaHotel.Items)
                {
                    if (item.IDCategoria == (float)valor)
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
                            if (TipoSolicitud == 1 || TipoSolicitud == 2 || TipoSolicitud == 3)
                            {
                                band = this.RegistarNuevaSolicitud();
                            }
                            break;
                    case 2: band = this.ActualizarDatosHotel(_Solicitud);
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
                this.IniciarGrid(this.dgvHabitaciones, 4);
                this.LlenarComboCategoriaHotel();
                switch (TipoForm)
                {
                    case 1: this.IniciarObjetosForm();
                        this.btnContinuar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._14continuar;
                        break;
                    case 2: Solicitud aux = this.ObtenerDatosActuales();
                        this.LlenarDatosModificar(aux);
                        this.btnContinuar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._19guardar;
                        break;
                    default: this.IniciarObjetosForm();
                        break;
                }
                if (TipoSolicitud != 3)
                {
                    this.ActiveControl = this.cmbCategoriaHotel;
                    this.cmbCategoriaHotel.Focus();
                }
                else
                {
                    this.ActiveControl = this.txtNumAdultos;
                    this.txtNumAdultos.Focus();
                }
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
                if (TipoForm == 1)
                {
                    dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnas());
                }
                else if (TipoForm == 2)
                {
                    dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasDatos());
                }
                actual.AutoSize = false;
                actual.AutoGenerateColumns = false;
                actual.AllowUserToAddRows = false;
                actual.AllowUserToDeleteRows = false;
                actual.AllowUserToOrderColumns = false;
                actual.AllowUserToResizeColumns = false;
                actual.MultiSelect = false;
                actual.SelectionMode = DataGridViewSelectionMode.CellSelect;
                actual.ReadOnly = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }      

        private void IniciarObjetosForm()
        {
            try
            {
                this.txtNumAdultos.Text = "0";
                this.txtNumMenores4.Text = "0";
                this.txtNumMenores11.Text = "0";
                this.txtTotalHabitaciones.Text = "0";
                this.txtTotalPersonas.Text = "0";
                if (TipoSolicitud == 2)
                {
                    this.txtTotalHabitaciones.ReadOnly = true;
                    this.txtTotalHabitaciones.TabStop = false;
                    this.dgvHabitaciones.ReadOnly = true;
                    this.dgvHabitaciones.TabStop = false;
                }
                if (TipoSolicitud == 3)
                {
                    if (this.cmbCategoriaHotel.Items.Count > 0)
                    {                        
                        if (this.ExisteItemEnCombo((float)this._Solicitud.CategoriaHotel))
                        {
                            this.cmbCategoriaHotel.SelectedValue = (float)this._Solicitud.CategoriaHotel;
                            this.cmbCategoriaHotel.Enabled = false;
                            this.cmbCategoriaHotel.TabStop = false;
                        }
                    }
                }
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
                    this.txtTotalHabitaciones.KeyUp -= new System.Windows.Forms.KeyEventHandler(this.txtTotalHabitaciones_KeyUp);
                    this.txtTotalHabitaciones.Validated -= new System.EventHandler(this.txtTotalHabitaciones_Validated);
                    if (TipoSolicitud == 2)
                    {
                        this.txtTotalHabitaciones.ReadOnly = true;
                        this.txtTotalHabitaciones.TabStop = false;
                        this.dgvHabitaciones.ReadOnly = true;
                        this.dgvHabitaciones.TabStop = false;
                    }
                    this.txtNumAdultos.Text = aux.NumAdultos.ToString();
                    this.txtNumMenores4.Text = aux.NumMenores4.ToString();
                    this.txtNumMenores11.Text = aux.NumMenores11.ToString();
                    this.txtTotalHabitaciones.Text = aux.NumHabitaciones.ToString();
                    this.txtTotalPersonas.Text = (aux.NumAdultos + aux.NumMenores4 + aux.NumMenores11).ToString();
                    if (this.cmbCategoriaHotel.Items.Count > 0)
                    {
                        if (this.ExisteItemEnCombo((float)aux.CategoriaHotel))
                        {
                            this.cmbCategoriaHotel.SelectedValue = (float)aux.CategoriaHotel;
                        }
                    }
                    if (TipoSolicitud == 3)
                    {
                        this.cmbCategoriaHotel.Enabled = false;
                        this.cmbCategoriaHotel.TabStop = false;
                    }
                    this.dgvHabitaciones.Rows.Clear();
                    this.dgvHabitaciones.DataSource = aux.TablaHabitaciones;

                    if (TipoSolicitud != 2)
                    {
                        this.txtTotalHabitaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalHabitaciones_KeyUp);
                        this.txtTotalHabitaciones.Validated += new System.EventHandler(this.txtTotalHabitaciones_Validated);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void LlenarComboCategoriaHotel()
        {
            try
            {
                CategoriaHotel CatHotel = new CategoriaHotel();
                CategoriaHotel_Negocio chn = new CategoriaHotel_Negocio();
                CatHotel.Conexion = Comun.Conexion;
                CatHotel.Opcion = 1;
                this.cmbCategoriaHotel.DataSource = chn.ObtenerCategoriasHotel(CatHotel);
                this.cmbCategoriaHotel.DisplayMember = "Descripcion";
                this.cmbCategoriaHotel.ValueMember = "IDCategoria";
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

        private float ObtenerCategoriaHotel()
        {
            try
            {
                CategoriaHotel datos = new CategoriaHotel();
                datos.IDCategoria = 0F;
                if (this.cmbCategoriaHotel.Items.Count > 0)
                {
                    if (this.cmbCategoriaHotel.SelectedIndex != -1)
                    {
                        datos = (CategoriaHotel)this.cmbCategoriaHotel.SelectedItem;                        
                    }
                }
                return datos.IDCategoria;
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
                aux = sn.ObtenerDatosModificarDatosHotel(aux);
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
                this._Solicitud.NumAdultos = this.ObtenerNumAdultos();
                this._Solicitud.NumMenores11 = this.ObtenerNumMenores11();
                this._Solicitud.NumMenores4 = this.ObtenerNumMenores4();
                this._Solicitud.NumHabitaciones = this.ObtenerTotalHabitaciones();
                this._Solicitud.TablaHabitaciones = this.ObtenerDatosTablaHabitaciones();
                this._Solicitud.CategoriaHotel = this.ObtenerCategoriaHotel();
                this._Solicitud.IDUsuario = Comun.IDUsuario;
                this._Solicitud.Conexion = Comun.Conexion;
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
                foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                {
                    tabla.Rows.Add(new Object[] { 
                                this.ObtenerNumCamasFila(fila),
                                this.ObtenerNumAdultosFila(fila),
                                this.ObtenerNumMenores4Fila(fila),
                                this.ObtenerNumMenores11Fila(fila)
                            });
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumAdultos()
        {
            try
            {
                int cantidad;
                if (!int.TryParse(this.txtNumAdultos.Text, out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumAdultosFila(DataGridViewRow fila)
        {
            try
            {
                int cantidad;
                if (!int.TryParse(fila.Cells["Adultos"].Value.ToString(), out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumCamasFila(DataGridViewRow fila)
        {
            try
            {
                int cantidad;
                if (!int.TryParse(fila.Cells["Camas"].Value.ToString(), out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumMenores4()
        {
            try
            {
                int cantidad;
                if (!int.TryParse(this.txtNumMenores4.Text, out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumMenores4Fila(DataGridViewRow fila)
        {
            try
            {
                int cantidad;
                if (!int.TryParse(fila.Cells["Menores4"].Value.ToString(), out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumMenores11()
        {
            try
            {
                int cantidad;
                if (!int.TryParse(this.txtNumMenores11.Text, out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerNumMenores11Fila(DataGridViewRow fila)
        {
            try
            {
                int cantidad;
                if (!int.TryParse(fila.Cells["Menores11"].Value.ToString(), out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object[,] ObtenerPropiedadesColumnas()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"Adultos",             "",                     "Adultos",          1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 2",           "",                     "Menores4",         1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 10",          "",                     "Menores11",        1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Camas",               "",                     "Camas",            1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object[,] ObtenerPropiedadesColumnasDatos()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"Adultos",             "Adultos",              "Adultos",          1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 2",           "Menores4",             "Menores4",         1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 10",          "Menores11",            "Menores11",        1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Camas",               "Camas",                "Camas",            1,          true,           125,        DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerTotalHabitaciones()
        {
            try
            {
                int cantidad;
                if (!int.TryParse(this.txtTotalHabitaciones.Text, out cantidad))
                {
                    cantidad = 0;
                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerTotalPersonas()
        {
            try
            {
                return this.ObtenerNumAdultos() + this.ObtenerNumMenores11() + this.ObtenerNumMenores4();
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
                    case 1: this.DialogResult = DialogResult.OK;
                        break;
                    case 2: this.DialogResult = DialogResult.OK;
                        break;
                    case 3: this.DialogResult = DialogResult.OK;
                        break;
                    case 4: this.DialogResult = DialogResult.OK;
                        break;
                    case 5: this.AbrirFormItinerario();
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
                if (this.cmbCategoriaHotel.Items.Count > 0)
                {
                    if (this.cmbCategoriaHotel.SelectedIndex != -1)
                    {
                        CategoriaHotel datos = (CategoriaHotel)this.cmbCategoriaHotel.SelectedItem;
                        if (datos.IDCategoria <= 0)
                            errores.Add(1, "Seleccione una Categoría de la lista.");
                    }
                    else
                    {
                        errores.Add(1, "Seleccione una Categoría de la lista.");
                    }
                }
                else
                {
                    errores.Add(1,"Seleccione una Categoría de hotel.");
                }
                if(TipoSolicitud != 2)
                    if (!this.ValidarDatosEntero(this.txtTotalHabitaciones.Text))
                        errores.Add(2, "Ingrese una cantidad válida para Habitaciones.");
                if (this.ObtenerNumAdultos() + this.ObtenerNumMenores11() + this.ObtenerNumMenores4() == 0)
                    errores.Add(3, "El número de personas debe ser mayor a 0.");
                if (TipoSolicitud != 2)
                {
                    if (!this.ValidarTotalAdultos())
                        errores.Add(4, "El número de adultos no coincide.");
                    if (!this.ValidarTotalMenores11())
                        errores.Add(5, "El número de Menores de 10 años no coincide.");
                    if (!this.ValidarTotalMenores4())
                        errores.Add(6, "El número de Menores de 2 años no coincide.");

                    int aux = 7;
                    int filaindex = 1;
                    foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                    {
                        if (!this.ValidarFilaPersonas(fila))
                        {
                            errores.Add(aux, "El total de personas mayores de 2 años debe ser mayor a 0. Fila: " + filaindex);
                            aux++;
                        }
                        if (!this.ValidarFilaCamas(fila))
                        {
                            errores.Add(aux, "El número de camas debe ser mayor a 0. Fila: " + filaindex);
                            aux++;
                        }
                        filaindex++;
                    }
                }
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarDatosEntero(string cadena)
        {
            try
            {
                int x = 0;
                if (string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena))
                {
                    return false;
                }
                else
                {
                    if (int.TryParse(cadena, out x))
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFilaPersonas(DataGridViewRow fila)
        {
            try
            {
                if (this.ObtenerNumAdultosFila(fila) + this.ObtenerNumMenores11Fila(fila) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFilaCamas(DataGridViewRow fila)
        {
            try
            {
                if (this.ObtenerNumCamasFila(fila) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarTotalAdultos()
        {
            try
            {
                int TotalAdultos = 0;
                foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                {
                    TotalAdultos += this.ObtenerNumAdultosFila(fila);
                }
                if (TotalAdultos == this.ObtenerNumAdultos())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarTotalMenores11()
        {
            try
            {
                int TotalMenores11 = 0;
                foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                {
                    TotalMenores11 += this.ObtenerNumMenores11Fila(fila);
                }
                if (TotalMenores11 == this.ObtenerNumMenores11())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarTotalMenores4()
        {
            try
            {
                int TotalMenores4 = 0;
                foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                {
                    TotalMenores4 += this.ObtenerNumMenores4Fila(fila);
                }
                if (TotalMenores4 == this.ObtenerNumMenores4())
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

    }
}
