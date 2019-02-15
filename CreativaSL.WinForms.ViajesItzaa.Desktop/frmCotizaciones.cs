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
    public partial class frmCotizaciones : Form_Creativa
    {
        #region Variables / Propiedades

        private Solicitud SolicitudDatos = new Solicitud();
        private frmWait Espere = new frmWait();

        #endregion

        #region Constructor

        public frmCotizaciones(Solicitud solicitud)
        {
            try
            {
                InitializeComponent();
                this.SolicitudDatos = solicitud;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCotizaciones");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        #region Eventos del DataGridView

        private void dgvCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    DataGridViewColumn Columna = this.dgvCotizaciones.Columns[e.ColumnIndex];
                    if (Columna.Name == "Ver")
                    {
                        Cotizacion Datos = new Cotizacion();
                        Datos.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                        Datos.IDCotizacion = this.dgvCotizaciones.Rows[e.RowIndex].Cells["IDCotizacion"].Value.ToString();
                        Datos.Comentarios = string.Empty;
                        frmNuevaCotizacion VerDetalle = new frmNuevaCotizacion(Datos, 3, this.SolicitudDatos.IDTipoSolicitud);
                        this.Visible = false;
                        VerDetalle.ShowDialog();
                        this.Visible = true;
                        VerDetalle.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgvCotizaciones_CellContentClick");
            }
        }

        #endregion

        #region Eventos del Formulario

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Cotizaciones" ;
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCotizaciones_Load");
                this.Close();
            }
        }

        #endregion

        #region Eventos del Menú de Opciones

        private void btnNuevaCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCotizaciones.Rows.Count < 5)
                {
                    Cotizacion Aux = new Cotizacion();
                    Aux.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                    frmNuevaCotizacion Cotizacion = new frmNuevaCotizacion(Aux, 1, this.SolicitudDatos.IDTipoSolicitud);
                    this.Visible = false;
                    Cotizacion.ShowDialog();
                    this.Visible = true;
                    Cotizacion.Dispose();
                    if (Cotizacion.DialogResult == DialogResult.OK)
                    {
                        this.CargarGridCotizaciones();
                        this.EstablecerImagenGrid();
                    }
                }
                else
                    MessageBox.Show("Sólo se pueden generar 5 cotizaciones máximo por Solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevaCotizacion_Click");
            }
        }

        private void btnModificarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                Cotizacion Aux = this.ObtenerDatosCotizacion();
                if (!string.IsNullOrEmpty(Aux.IDCotizacion))
                {
                    frmNuevaCotizacion Cotizacion = new frmNuevaCotizacion(Aux, 2, this.SolicitudDatos.IDTipoSolicitud);
                    this.Visible = false;
                    Cotizacion.ShowDialog();
                    this.Visible = true;
                    Cotizacion.Dispose();
                    if (Cotizacion.DialogResult == DialogResult.OK)
                    {
                        this.CargarGridCotizaciones();
                        this.EstablecerImagenGrid();
                    }
                }
                else
                    MessageBox.Show("Seleccione una cotización.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnModificarCotizacion_Click");
            }
        }

        private void btnEliminarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Cotizacion Aux = this.ObtenerDatosCotizacion();
                    if (!string.IsNullOrEmpty(Aux.IDCotizacion))
                    {
                        if ((MessageBox.Show("¿Está seguro de eliminar la cotización [ " + Aux.Descripcion + "  ] ?",
                            Comun.CaptionSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                        {
                            Cotizacion_Negocio cn = new Cotizacion_Negocio();
                            Aux.Opcion = 3;
                            Aux.TablaHabitaciones = GenerarTabla();
                            Aux.Conexion = Comun.Conexion;
                            Aux.IDUsuario = Comun.IDUsuario;
                            cn.AbcCotizaciones(Aux);
                            if (Aux.Validador)
                            {
                                MessageBox.Show("El registro ha sido eliminado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.CargarGridCotizaciones();
                                this.EstablecerImagenGrid();
                            }
                            else
                                MessageBox.Show("No se pudo eliminar el registro. Intente nuevamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("Seleccione una cotización. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Comun_Negocio.AddExcFileTxt(ex, "btnEliminarCliente_Click");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEliminarCotizacion_Click");
            }
        }

        private DataTable GenerarTabla()
        {
            try
            {
                DataTable Aux = new DataTable();
                Aux.Columns.Add("IDHabitacionCot", typeof(string));
                Aux.Columns.Add("IDHabitacion", typeof(string));
                Aux.Columns.Add("NumCamas", typeof(int));
                Aux.Columns.Add("NumAdultos", typeof(int));
                Aux.Columns.Add("NumMenores4", typeof(int));
                Aux.Columns.Add("NumMenores11", typeof(int));
                Aux.Columns.Add("CostoAdulto", typeof(decimal));
                Aux.Columns.Add("CostoMenor4", typeof(decimal));
                Aux.Columns.Add("CostoMenor11", typeof(decimal));
                Aux.Columns.Add("Total", typeof(decimal));
                Aux.Columns.Add("TipoHab", typeof(string));
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEnviarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                int error = this.ValidarCotizaciones();
                if (error == 1)
                {
                    Solicitud aux = new Solicitud();
                    aux.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                    aux.Conexion = Comun.Conexion;
                    aux.IDUsuario = Comun.IDUsuario;
                    Cotizacion_Negocio cn = new Cotizacion_Negocio();
                    cn.EnviarCotizacion(aux);
                    if (aux.Validador)
                    {
                        Solicitud_Negocio sn = new Solicitud_Negocio();
                        sn.ObtenerEsEmpresa(aux);
                        MessageBox.Show("Datos guardados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!aux.EsEmpresa)
                        {
                            try
                            {
                                this.bgwEnvioCorreo.RunWorkerAsync(aux);
                                Espere.ShowDialog();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intente nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    this.MostrarMensajeError(error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEnviarCotizacion_Click");
            }
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            try
            {
                Cotizacion Aux = this.ObtenerDatosCotizacion();
                if (!string.IsNullOrEmpty(Aux.IDCotizacion))
                {
                    if (Aux.IDStatusCotizacion != 4)
                    {
                        frmDisponibilidad Disponible = new frmDisponibilidad(Aux);
                        Disponible.ShowDialog();
                        Disponible.Dispose();
                        if (Disponible.DialogResult == DialogResult.OK)
                        {
                            this.CargarGridCotizaciones();
                            this.EstablecerImagenGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El estatus de la cotización no permite realizar esta acción. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Seleccione una cotización. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnDisponibilidad_Click");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnSalir_Click");
            }
        }

        #endregion

        #region Eventos Enviar Correo

        private void bgwEnvioCorreo_DoWork(object sender, DoWorkEventArgs e)
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
                    cont ++;
                    this.bgwEnvioCorreo.ReportProgress((cont * 100) / TotalCot);
                    if(cont == TotalCot)
                        System.Threading.Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "bgwEnvioCorreo_DoWork");
                throw ex;
            }
        }

        private void bgwEnvioCorreo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        private void bgwEnvioCorreo_ProgressChanged(object sender, ProgressChangedEventArgs e)
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

        #endregion

        #endregion

        #region Métodos

        private void CargarGridCotizaciones()
        {
            try
            {
                this.dgvCotizaciones.DataSource = this.ObtenerCotizaciones();
            }
            catch (Exception ex)
            {
                throw ex;
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
                switch (this.SolicitudDatos.IDTipoSolicitud)
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

        private void EstablecerImagenGrid()
        {
            try
            {
                ConfiguracionDataGridView cdgv = new ConfiguracionDataGridView();
                cdgv.ImagenGrid(this.dgvCotizaciones, "IDStatusCotizacion", "Estatus");
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
                this.IniciarGridCotizaciones(this.dgvCotizaciones, 8);
                this.CargarGridCotizaciones();
                this.EstablecerImagenGrid();
                this.IniciarGridHabitaciones(this.dgvHabitaciones, 4);                
                this.LlenarDatosSolicitud(this.ObtenerDetalleSolicitud());
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
                actual.AutoSize = false;
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

        private void IniciarGridHabitaciones(DataGridView actual, int numColumns)
        {
            try
            {
                ConfiguracionDataGridView dgvConf = new ConfiguracionDataGridView();
                dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasHabitaciones());
                actual.AutoSize = false;
                actual.AutoGenerateColumns = false;
                actual.AllowUserToAddRows = false;
                actual.AllowUserToDeleteRows = false;
                actual.AllowUserToOrderColumns = false;
                actual.AllowUserToResizeColumns = false;
                actual.MultiSelect = false;
                actual.SelectionMode = DataGridViewSelectionMode.CellSelect;
                actual.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      

        private void LlenarDatosSolicitud(Solicitud Datos)
        {
            try
            {
                if (string.IsNullOrEmpty(Datos.IDSolicitud))
                {
                    this.txtFolio.Text = string.Empty;
                    this.txtCliente.Text = string.Empty;
                    this.txtTelefono.Text = string.Empty; ;
                    this.txtCorreoElectronico.Text = string.Empty;
                    this.txtProducto.Text = string.Empty;
                    this.chkTieneBoletos.Checked = false;
                    this.txtFechaLlegada.Text = string.Empty;
                    this.txtHoraLlegada.Text = string.Empty;
                    this.txtFechaSalida.Text = string.Empty;
                    this.txtHoraSalida.Text = string.Empty;
                    this.txtOtrosServicios.Text = string.Empty;
                    this.lblNumHabitaciones.Text = "0";
                    this.dgvHabitaciones.DataSource = new DataTable();
                }
                else
                {
                    this.txtFolio.Text = Datos.Folio;
                    if(Datos.Cliente != null)
                    {
                        this.txtCliente.Text = Datos.Cliente.Nombre;
                        this.txtTelefono.Text = Datos.Cliente.Telefono;
                        this.txtCorreoElectronico.Text = Datos.Cliente.CorreoElectronico;
                    }
                    this.txtProducto.Text = Datos.NombreProducto;
                    this.chkTieneBoletos.Checked = Datos.TieneBoletosAvion;
                    this.txtFechaLlegada.Text = Datos.FechaLlegada.ToShortDateString();
                    this.txtHoraLlegada.Text = Datos.HoraLlegada;
                    this.txtFechaSalida.Text = Datos.FechaSalida.ToShortDateString();
                    this.txtHoraSalida.Text = Datos.HoraSalida;
                    this.txtOtrosServicios.Text = Datos.OtrosServicios;
                    this.lblNumHabitaciones.Text = Datos.NumHabitaciones.ToString();
                    this.dgvHabitaciones.DataSource = Datos.TablaHabitaciones;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError(int error)
        {
            try
            {
                string mensaje = "";
                switch (error)
                {
                    case 2: mensaje = "Al menos una solicitud marcada como disponible tiene monto $ 0.00.";
                        break;
                    case 3: mensaje = "Ninguna solicitud está disponible para envío.";
                        break;
                    case 4: mensaje = "Debe realizar al menos una cotización. ";
                        break;
                }
                if (error >= 2 && error <= 4)
                {
                    MessageBox.Show(mensaje, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Cotizacion> ObtenerCotizaciones()
        {
            try
            {
                Cotizacion datos = new Cotizacion();
                datos.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                datos.Conexion = Comun.Conexion;
                Cotizacion_Negocio cn = new Cotizacion_Negocio();
                return cn.ObtenerGridCotizaciones(datos);
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
                Cotizacion aux = new Cotizacion();
                aux.IDCotizacion = string.Empty;
                if (this.dgvCotizaciones.Rows.Count > 0)
                {
                    if (this.dgvCotizaciones.SelectedRows.Count > 0)
                    {
                        int intaux = 0;
                        decimal decaux = 0;
                        DataGridViewRow fila = this.dgvCotizaciones.SelectedRows[0];
                        aux.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                        aux.IDCotizacion = fila.Cells["IDCotizacion"].Value.ToString();
                        aux.IDStatusCotizacion = int.TryParse(fila.Cells["IDStatusCotizacion"].Value.ToString(), out intaux) ? intaux : 0;
                        aux.Subtotal = decimal.TryParse(fila.Cells["Subtotal"].Value.ToString(), out decaux) ? decaux : 0;
                        aux.Descripcion = fila.Cells["Descripcion"].Value.ToString();
                        aux.Comentarios = string.Empty;
                    }
                }                             
                return aux;
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
                Solicitud Aux = new Solicitud();
                Aux.Conexion = Comun.Conexion;
                Aux.IDSolicitud = this.SolicitudDatos.IDSolicitud;
                Solicitud_Negocio sn = new Solicitud_Negocio();
                Aux = sn.ObtenerDetalleSolicitudCotizacion(Aux);
                return Aux;
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
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad   //Ancho    //Formato
                    {"IDCotizacion",        "IDCotizacion",         "IDCotizacion",     1,          false,          80,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusCotizacion",  "IDStatusCotizacion",   "IDStatusCotizacion",1,         false,          80,        DataGridViewContentAlignment.MiddleCenter,     ""},
                    {"Descripcion",         "Descripcion",          "Descripcion",      1,          true,           350,       DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Fecha",               "FechaCotizacion",      "FechaCotizacion",  1,          true,           100,       DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora",                "FechaCotizacion",      "HoraCotizacion",   1,          true,           100,       DataGridViewContentAlignment.MiddleCenter,     "HH:mm:ss"},
                    {"Estatus",             "Estatus",              "Estatus",          2,          true,           100,       DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Monto",               "Subtotal",             "Subtotal",         1,          true,           95,       DataGridViewContentAlignment.MiddleRight,       "c"},
                    {"Ver",                 "",                     "Ver",              4,          true,           90,       DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object[,] ObtenerPropiedadesColumnasHabitaciones()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"Adultos",             "NumAdultos",           "NumAdultos",          1,          true,           80,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 2",           "NumMenores4",          "NumMenores4",         1,          true,           80,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Menores 10",          "NumMenores11",         "NumMenores11",        1,          true,           80,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Camas",               "NumCamas",             "NumCamas",     1,          true,           75,        DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ValidarCotizaciones()
        {
            try
            {
                if (this.ValidarNumTotalCotizaciones())
                {
                    if (this.ValidarStatusCotizacion())
                    {
                        if (this.ValidarMontoMayor0())
                        {
                            return 1; //OK
                        }
                        else
                        {
                            return 2;  //"Al menos una solicitud va con montos 0."
                        }
                    }
                    else
                    {
                        return 3; //"No hay ninguna solicitud disponible para envío. "
                    }
                }
                else
                {
                    return 4; //"No hay cotizaciones"
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarMontoMayor0()
        {
            try
            {
                bool band = false;                
                if (this.dgvCotizaciones.Rows.Count > 0)
                {
                    band = true;
                    foreach (DataGridViewRow fila in this.dgvCotizaciones.Rows)
                    {
                        decimal monto = 0;
                        int IDStatus = 0;
                        decimal.TryParse(fila.Cells["Subtotal"].Value.ToString(), out monto);
                        int.TryParse(fila.Cells["IDStatusCotizacion"].Value.ToString(), out IDStatus);
                        if (IDStatus == 2)
                        {
                            if (monto <= 0)
                            {
                                band = false;
                                break;
                            }
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

        private bool ValidarStatusCotizacion()
        {
            try
            {
                bool band = false;
                if (this.dgvCotizaciones.Rows.Count > 0)
                {
                    foreach (DataGridViewRow fila in this.dgvCotizaciones.Rows)
                    {
                        int IDStatus = 0;
                        int.TryParse(fila.Cells["IDStatusCotizacion"].Value.ToString(), out IDStatus);
                        if (IDStatus == 2)
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

        private bool ValidarNumTotalCotizaciones()
        {
            try
            {
                bool band = false;
                if (this.dgvCotizaciones.Rows.Count > 0 && this.dgvCotizaciones.Rows.Count <= 5)
                    band = true;
                else
                    band = false;
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
