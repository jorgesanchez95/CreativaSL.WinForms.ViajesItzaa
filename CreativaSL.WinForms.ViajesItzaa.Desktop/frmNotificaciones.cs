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
    public partial class frmNotificaciones : Form_Creativa
    {
        #region Variables
        private int TipoForm = 0;
        #endregion

        #region Constructor

        public frmNotificaciones(int opcion)
        {
            try
            {
                InitializeComponent();
                this.TipoForm = opcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotificaciones");
            }
        }

        #endregion

        #region Eventos 

        #region Eventos Click

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

        #endregion

        #region Eventos del Formulario

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem;
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();                
                this.CargarGridSolicitudes();
                this.EstablecerImagenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotificaciones_Load");
            }
        }

        #endregion

        #region Eventos del TabControl

        private void tcSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CargarGridSolicitudes();
                //if (this.tcSolicitudes.SelectedIndex == 1)
                //    this.dgvNotificaciones02.DataSource = this.dgvNotificaciones02.DataSource;
                this.EstablecerImagenGrid();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "tcSolicitudes_SelectedIndexChanged");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarGridSolicitudes()
        {
            try
            {
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux.Conexion = Comun.Conexion;
                aux.Opcion = this.TipoForm;
                aux.IDUsuario = Comun.IDUsuario;
                aux = sn.ObtenerNotificacionesDatos(aux);
                this.dgvNotificaciones01.DataSource = aux.TablaNotificaciones;
                if (this.TipoForm == 4)
                {
                    this.dgvNotificaciones02.DataSource = aux.TablaNotificaciones2;
                }
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
                switch (TipoForm)
                {
                    case 1: cdgv.ImagenGrid(this.dgvNotificaciones01, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
                        break;
                    case 2: cdgv.ImagenGrid(this.dgvNotificaciones01, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
                        break;
                    case 3: cdgv.ImagenGrid(this.dgvNotificaciones01, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
                        break;
                    case 4: cdgv.ImagenGrid(this.dgvNotificaciones01, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
                            cdgv.ImagenGrid(this.dgvNotificaciones02, "IDTipoSolicitud2", "TipoSolicitud2", "IDStatusSolicitud2", "Estatus2");
                        break;
                    case 5: cdgv.ImagenGrid(this.dgvNotificaciones01, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
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
                this.tpNotificaciones1.Text = "SOLICITUDES";
                this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                switch (this.TipoForm)
                {
                    case 1: this.panelTitle_Creativa1.Title = "SOLICITUDES RECIBIDAS CON 48 HORAS SIN ENVIAR CONTIZACION";
                        this.IniciarGrid(this.dgvNotificaciones01, 10);
                        this.tcSolicitudes.TabPages.Remove(this.tpNotificaciones2);
                        break;
                    case 2: this.panelTitle_Creativa1.Title = "COMPRAS CONFIRMADAS VÍA WEB";
                        this.IniciarGrid(this.dgvNotificaciones01, 8);
                        this.tcSolicitudes.TabPages.Remove(this.tpNotificaciones2);
                        break;
                    case 3: this.panelTitle_Creativa1.Title = "PAGO CONFIRMADO PAYPAL";
                        this.IniciarGrid(this.dgvNotificaciones01, 10);
                        this.tcSolicitudes.TabPages.Remove(this.tpNotificaciones2);
                        break;
                    case 4: this.panelTitle_Creativa1.Title = "SOLICITUDES CON FECHAS LÍMITES DE PAGO VENCIDAS";
                        this.IniciarGrid(this.dgvNotificaciones01, 10);
                        this.IniciarGrid2(this.dgvNotificaciones02, 10);
                        this.tpNotificaciones1.Text = "PAGO INICIAL";
                        this.tpNotificaciones2.Text = "PAGO FINAL";
                        break;
                    case 5: this.panelTitle_Creativa1.Title = "NOTAS AGENDADAS";
                        this.IniciarGrid(this.dgvNotificaciones01, 9);
                        this.tcSolicitudes.TabPages.Remove(this.tpNotificaciones2);
                        break;
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
                switch (this.TipoForm)
                {
                    case 1: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasSinRespuesta());
                        break;
                    case 2: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasVentasWeb());
                        break;
                    case 3: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasPagosWeb());
                        break;
                    case 4: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasFechaPagoInicial());
                        break;
                    case 5: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasNotasProgramadas());
                        break;
                }
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

        private void IniciarGrid2(DataGridView actual, int numColumns)
        {
            try
            {
                ConfiguracionDataGridView dgvConf = new ConfiguracionDataGridView();
                switch (this.TipoForm)
                {
                    case 1: 
                    case 2:
                    case 3:
                    case 5:
                        break;
                    case 4: dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnasFechaPagoFinal());
                        break;
                }
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

        //Propiedades Grid Fechas Lim. pago Inicial
        private object[,] ObtenerPropiedadesColumnasFechaPagoInicial()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha Solicitud",     "FechaSolicitud",       "FechaSolicitud",   1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora Solicitud",      "HoraSolicitud",        "HoraSolicitud",    1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Fecha Lim. Pago Inicial",     "FechaLimite",  "FechaLimite1",     1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Propiedades Grid Fechas Lim. pago Final
        private object[,] ObtenerPropiedadesColumnasFechaPagoFinal()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud2",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio2",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud2",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus2",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha Solicitud",     "FechaSolicitud",       "FechaSolicitud2",   1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora Solicitud",      "HoraSolicitud",        "HoraSolicitud2",    1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud2",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud2",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto2",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Fecha Lim. Pago Final",     "FechaLimite",  "FechaLimite2",     1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Propiedades Grid Solicitudes sin respuesta
        private object[,] ObtenerPropiedadesColumnasSinRespuesta()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha Solicitud",     "FechaSolicitud",       "FechaSolicitud",   1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora Solicitud",      "HoraSolicitud",        "HoraSolicitud",    1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Fecha de recepción",  "FechaRecepcion",       "FechaRecepcion",   1,          true,           180,        DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Propiedades Grid Notas Programadas
        private object[,] ObtenerPropiedadesColumnasNotasProgramadas()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto",   1,          true,           250,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"IDNota",              "IDNota",               "IDNota",           1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Nota",                "Nota",                 "Nota",             1,          true,           550,        DataGridViewContentAlignment.MiddleLeft,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Propiedades Grid Solicitudes Vendidas en línea
        private object[,] ObtenerPropiedadesColumnasVentasWeb()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Fecha y Hora Venta",  "FechaHoraVenta",       "FechaVenta",       1,          true,           180,        DataGridViewContentAlignment.MiddleCenter,      ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Propiedades Grid Solicitudes Pagadas en línea
        private object[,] ObtenerPropiedadesColumnasPagosWeb()
        {
            try
            {
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDTipoSolicitud",     "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "Producto",             "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Descripcion",         "NombrePago",           "NombrePago",       1,          true,           150,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Monto",               "MontoPago",            "MontoPago",        1,          true,           90,         DataGridViewContentAlignment.MiddleRight,       "c"},
                    {"Fecha y Hora Pago",   "FechaPago",            "FechaPago",        1,          true,           180,        DataGridViewContentAlignment.MiddleCenter,      "dd/mm/yyyy HH:mm:ss"},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
