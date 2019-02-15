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
using System.Collections;
using System.IO;
using System.Globalization;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmNuevaCotizacion : Form_Creativa
    {
        #region Variables

        private Cotizacion _DatosCotizacion;
        public Cotizacion DatosCotizacion
        {
            get { return _DatosCotizacion; }
        }
        private int TipoForm = 0;
        private int TipoSolicitud = 0;

        #endregion

        #region Constructor

        public frmNuevaCotizacion(Cotizacion Datos, int tipo, int tiposol)
        {
            try
            {
                InitializeComponent();
                this._DatosCotizacion = Datos;
                this.TipoForm = tipo;
                this.TipoSolicitud = tiposol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaCotizacion");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    Cotizacion Datos = this.ObtenerDatosCotizacion();
                    Cotizacion_Negocio cn = new Cotizacion_Negocio();
                    cn.AbcCotizaciones(Datos);
                    if (Datos.Validador)
                    {
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intenete nuevamente. Si el problema persiste, comuníquese a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }

        private void btnViewCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud aux = new Solicitud();
                aux.IDSolicitud = this._DatosCotizacion.IDSolicitud;
                aux.IDCotizacion = this._DatosCotizacion.IDCotizacion;
                aux.IDTipoSolicitud = this.TipoSolicitud;
                frmViewCorreo Correo = new frmViewCorreo(aux);
                this.Visible = false;
                Correo.ShowDialog();
                this.Visible = true;
                Correo.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
            }
        }

        #endregion

        #region Eventos De Control Textbox

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones validar = new Validaciones();
                validar.PermitirSoloNumerosDecimales(e, this.txtMonto.Text);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Validating");
            }
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out aux);
                this.txtMonto.Text = string.Format("{0:F2}", aux);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtMonto_Validating");
            }
        }

        #endregion

        #region Eventos del Datatgrid Habitaciones

        private void dgvHabitaciones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                this.dgvHabitaciones.Rows[e.RowIndex].ErrorText = "";
                decimal aux;
                if (this.dgvHabitaciones.Rows[e.RowIndex].IsNewRow) { return; }
                DataGridViewColumn columna = this.dgvHabitaciones.Columns[e.ColumnIndex];
                if (columna.Name == "CostoAdulto" || columna.Name == "CostoMenor4" || columna.Name == "CostoMenor11")
                {
                    if (!decimal.TryParse(e.FormattedValue.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out aux) || aux < 0)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgvHabitaciones_CellValidating");
            }
        }

        private void dgvHabitaciones_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewColumn columna = this.dgvHabitaciones.Columns[e.ColumnIndex];
                if (columna.Name == "CostoAdulto" || columna.Name == "CostoMenor4" || columna.Name == "CostoMenor11")
                {
                    this.dgvHabitaciones.Rows[e.RowIndex].Cells["Total"].Value = this.CalcularSubtotal(this.dgvHabitaciones.Rows[e.RowIndex]);
                    this.DibujarTotal();
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgvHabitaciones_CellValidated");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmNuevaCotizacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cotización";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                //this.dgvHabitaciones.CellValidating -= new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHabitaciones_CellValidating);
                this.IniciarForm();
                //this.dgvHabitaciones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHabitaciones_CellValidating);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevaCotizacion_Load");
            }
        }

        #endregion

        #region Eventos del RichTextBox

        private void txtComentarios_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tb_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton btn = (ToolStripButton)sender;
                switch (btn.ToolTipText)
                {
                    case "Bold":
                        {
                            if (this.txtComentarios.SelectionFont != null)
                            {
                                this.txtComentarios.SelectionFont = new Font(this.txtComentarios.SelectionFont, this.txtComentarios.SelectionFont.Style ^ FontStyle.Bold);
                            }
                        }
                        break;
                    case "Italic":
                        {
                            if (this.txtComentarios.SelectionFont != null)
                            {
                                this.txtComentarios.SelectionFont = new Font(this.txtComentarios.SelectionFont, this.txtComentarios.SelectionFont.Style ^ FontStyle.Italic);
                            }
                        }
                        break;
                    case "Underline":
                        {
                            if (this.txtComentarios.SelectionFont != null)
                            {
                                this.txtComentarios.SelectionFont = new Font(this.txtComentarios.SelectionFont, this.txtComentarios.SelectionFont.Style ^ FontStyle.Underline);
                            }
                        }
                        break;
                    case "Strikeout":
                        {
                            if (this.txtComentarios.SelectionFont != null)
                            {
                                this.txtComentarios.SelectionFont = new Font(this.txtComentarios.SelectionFont, this.txtComentarios.SelectionFont.Style ^ FontStyle.Strikeout);
                            }
                        }
                        break;
                    case "Super":
                        {
                            this.tbbSuperScript.Checked = !this.tbbSuperScript.Checked;
                            if (tbbSuperScript.Checked)
                            {
                                this.txtComentarios.SetSuperScript(true);
                                this.txtComentarios.SetSubScript(false);
                            }
                            else
                            {
                                this.txtComentarios.SetSuperScript(false);
                            }
                        }
                        break;

                    case "Sub":
                        {
                            this.tbbSubScript.Checked = !this.tbbSubScript.Checked;
                            if (tbbSubScript.Checked)
                            {
                                this.txtComentarios.SetSubScript(true);
                                this.txtComentarios.SetSuperScript(false);
                            }
                            else
                            {
                                this.txtComentarios.SetSubScript(false);
                            }
                        }
                        break;
                    case "Left":
                        {
                            //change horizontal alignment to left
                            this.txtComentarios.SelectionAlignment = HorizontalAlignment.Left;
                        }
                        break;
                    case "Right":
                        {
                            //change horizontal alignment to right
                            this.txtComentarios.SelectionAlignment = HorizontalAlignment.Right;
                        }
                        break;
                    case "Center":
                        {
                            //change horizontal alignment to center
                            this.txtComentarios.SelectionAlignment = HorizontalAlignment.Center;
                        }
                        break;
                    case "Font":
                        {
                            if (this.txtComentarios.SelectionFont != null)
                                fontDialog1.Font = this.txtComentarios.SelectionFont;
                            else
                                fontDialog1.Font = this.txtComentarios.Font;

                            if (fontDialog1.ShowDialog() == DialogResult.OK)
                            {
                                if (this.txtComentarios.SelectionFont != null)
                                    this.txtComentarios.SelectionFont = fontDialog1.Font;
                                else
                                    this.txtComentarios.Font = fontDialog1.Font;
                            }
                        }
                        break;
                    case "Color":
                        {
                            colorDialog1.Color = this.txtComentarios.SelectionColor;

                            if (colorDialog1.ShowDialog() == DialogResult.OK)
                            {
                                this.txtComentarios.SelectionColor = colorDialog1.Color;
                            }
                        }
                        break;
                }
                UpdateToolbar();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "tb_Click");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private decimal CalcularSubtotal(DataGridViewRow fila)
        {
            try
            {
                decimal Subtotal = 0, PrecioAdulto = 0, PrecioMenor4 = 0, PrecioMenor11 = 0;
                int NumAdultos = 0, NumMenor4 = 0, NumMenor11 = 0;
                int.TryParse(fila.Cells["NumAdultos"].Value.ToString(), out NumAdultos);
                int.TryParse(fila.Cells["NumMenores4"].Value.ToString(), out NumMenor4);
                int.TryParse(fila.Cells["NumMenores11"].Value.ToString(), out NumMenor11);
                decimal.TryParse(fila.Cells["CostoAdulto"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out PrecioAdulto);
                decimal.TryParse(fila.Cells["CostoMenor4"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out PrecioMenor4);
                decimal.TryParse(fila.Cells["CostoMenor11"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out PrecioMenor11);
                Subtotal = (NumAdultos * PrecioAdulto) + (NumMenor4 * PrecioMenor4) + (NumMenor11 * PrecioMenor11);
                return Subtotal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal CalcularTotal()
        {
            try
            {
                decimal Total = 0;
                foreach (DataGridViewRow fila in this.dgvHabitaciones.Rows)
                {
                    Total += this.CalcularSubtotal(fila);
                }
                return Total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGrid(DataTable Tabla)
        {
            try
            {
                this.dgvHabitaciones.DataSource = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DibujarTotal()
        {
            try
            {
                this.txtMonto.Text = string.Format("{0:c}", this.CalcularTotal());
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
                switch (TipoForm)
                {
                    case 1:
                        this.btnViewCorreo.Visible = false;
                        this.ActiveControl = this.txtDescripcion;
                        this.txtDescripcion.Focus();
                        break;
                    case 2: this.ActiveControl = this.txtDescripcion;
                        this.txtDescripcion.Focus();
                        break;
                    case 3:
                        this.dgvHabitaciones.CellValidating -= new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHabitaciones_CellValidating);
                        this.dgvHabitaciones.ReadOnly = true;
                        this.dgvHabitaciones.TabStop = false;
                        this.txtDescripcion.ReadOnly = true;
                        this.txtDescripcion.TabStop = false;
                        this.txtMonto.ReadOnly = true;
                        this.txtMonto.TabStop = false;
                        this.txtComentarios.ReadOnly = true;
                        this.txtComentarios.TabStop = false;
                        this.btnCancelar.Location = this.btnViewCorreo.Location;
                        this.btnViewCorreo.Location = this.btnGuardar.Location;
                        this.btnGuardar.Visible = false;
                        this.btnViewCorreo.Visible = true;
                        this.txtComentarios.Enabled = false;
                        this.tb1.Enabled = false;
                        this.ActiveControl = this.btnCancelar;
                        this.btnCancelar.Focus();
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
                Cotizacion aux = new Cotizacion();
                aux = this.ObtenerDetalleCotizacion();
                this.IniciarGrid(this.dgvHabitaciones, 11);
                this.LlenarDatosCotizacion(aux);
                this.IniciarDiseñoForm();
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
                dgvConf.AddColumnsDataGridViewReadOnly(actual, numColumns, this.ObtenerPropiedadesColumnas());
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

        private void LlenarDatosCotizacion(Cotizacion DatosAux)
        {
            try
            {
                this.txtDescripcion.Text = DatosAux.Descripcion;
                this.txtMonto.Text = string.Format("{0:F2}", DatosAux.Subtotal);
                this.txtComentarios.AddHTML(DatosAux.Comentarios);
                this.CargarGrid(DatosAux.TablaHabitaciones);
                //this.viewHTMLCorreo.DocumentText = DatosAux.HtmlCorreo;
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

        private Cotizacion ObtenerDatosCotizacion()
        {
            try
            {
                Cotizacion DatosAux = new Cotizacion();
                DatosAux.IDCotizacion = string.IsNullOrEmpty(this._DatosCotizacion.IDCotizacion) ? string.Empty: this._DatosCotizacion.IDCotizacion;
                DatosAux.IDSolicitud = this._DatosCotizacion.IDSolicitud;
                DatosAux.Descripcion = this.txtDescripcion.Text;
                DatosAux.Subtotal = this.CalcularTotal();
                DatosAux.Comentarios = this.txtComentarios.GetHTML(true, true);
                DatosAux.TablaHabitaciones = (DataTable)this.dgvHabitaciones.DataSource;
                DatosAux.IDUsuario = Comun.IDUsuario;
                DatosAux.Conexion = Comun.Conexion;
                DatosAux.IDSucursal = Comun.IDSucursalCaja;
                DatosAux.Opcion = this.TipoForm;
                return DatosAux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Cotizacion ObtenerDetalleCotizacion()
        {
            try
            {
                Cotizacion Aux = new Cotizacion();
                Cotizacion_Negocio cn = new Cotizacion_Negocio();
                Aux.IDSolicitud = this._DatosCotizacion.IDSolicitud;
                Aux.IDCotizacion = this._DatosCotizacion.IDCotizacion;
                Aux.Conexion = Comun.Conexion;  
                Aux = cn.ObtenerDetalleSolicitudCotizacion(Aux);
                if (Aux == null)
                {
                    Aux = new Cotizacion();
                }
                return Aux;
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
                bool band1 = false, band2 = false, band3 = false, band4 = false, band5 = false,
                band6 = false, band7 = false, band8 = false, band9 = false, band10 = false;
                string textAdultos = "Adultos";
                string textPrecioAdulto = "Precio Adulto";
                switch (TipoSolicitud)
                {
                    case 1:
                    case 5:
                    case 3: 
                        band2 = band3 = band4 = band5 = band6 = band7 = band8 = band9 = band10 = true;
                        break;
                    case 2:
                        band3 = band4 = band5 = band7 = band8 = band9 = band10 = true;
                        break;
                    case 4:
                        textAdultos = "Servicios";
                        textPrecioAdulto = "Costo del Servicio";
                        band3 = band7 = band10 = true;
                        break;
                    default: break;
                }
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad   //Ancho     //Alignment                                     //Format    ReadOnly
                    {"IDHabitacionCot",     "IDHabitacionCot",      "IDHabitacionCot",  1,          band1,          125,        DataGridViewContentAlignment.MiddleCenter,      "",         true},
                    {"IDHabitacion",        "IDHabitacion",         "IDHabitacion",     1,          band1,          125,        DataGridViewContentAlignment.MiddleCenter,      "",         true},
                    {"Tipo Habitación",     "TipoHabitacion",       "TipoHabitacion",   1,          band2,           105,        DataGridViewContentAlignment.MiddleLeft,        "",         true},
                    {textAdultos,           "NumAdultos",           "NumAdultos",       1,          band3,           95,        DataGridViewContentAlignment.MiddleCenter,      "",         true},
                    {"Menores 2",           "NumMenores4",          "NumMenores4",      1,          band4,           95,        DataGridViewContentAlignment.MiddleCenter,      "",         true},
                    {"Menores 10",          "NumMenores11",         "NumMenores11",     1,          band5,           95,        DataGridViewContentAlignment.MiddleCenter,      "",         true},
                    {"Camas",               "NumCamas",             "NumCamas",         1,          band6,           70,        DataGridViewContentAlignment.MiddleCenter,      "",          true},
                    {textPrecioAdulto,      "CostoAdulto",          "CostoAdulto",      1,          band7,           90,        DataGridViewContentAlignment.MiddleRight,       "c",         false},
                    {"Precio Menor 2",      "CostoMenor4",          "CostoMenor4",      1,          band8,           90,        DataGridViewContentAlignment.MiddleRight,       "c",         false},
                    {"Precio Menor 10",     "CostoMenor11",         "CostoMenor11",     1,          band9,           90,        DataGridViewContentAlignment.MiddleRight,       "c",         false},
                    {"Subtotal",            "Total",                "Total",            1,          band10,           90,        DataGridViewContentAlignment.MiddleRight,       "c",         true}
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private decimal ObtenerSubtotal()
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out aux);
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateToolbar()
        {
            try
            {
                Font fnt;
                if (this.txtComentarios.SelectionFont != null)
                    fnt = this.txtComentarios.SelectionFont;
                else
                    fnt = this.txtComentarios.Font;

                //Do all the toolbar button checks
                tbbBold.Checked = fnt.Bold; //bold button
                tbbItalic.Checked = fnt.Italic; //italic button
                tbbUnderline.Checked = fnt.Underline; //underline button
                tbbStrikeout.Checked = fnt.Strikeout; //strikeout button
                tbbLeft.Checked = (this.txtComentarios.SelectionAlignment == HorizontalAlignment.Left); //justify left
                tbbCenter.Checked = (this.txtComentarios.SelectionAlignment == HorizontalAlignment.Center); //justify center
                tbbRight.Checked = (this.txtComentarios.SelectionAlignment == HorizontalAlignment.Right); //justify right

                tbbSuperScript.Checked = this.txtComentarios.IsSuperScript();
                tbbSubScript.Checked = this.txtComentarios.IsSubScript();
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
                if (string.IsNullOrEmpty(this.txtDescripcion.Text) || string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
                    errores.Add(1, "Debe ingresar la descripción de la Cotización.");
                if (this.CalcularTotal() <= 0)
                    errores.Add(2, "El Monto debe ser mayor a 0.");
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
