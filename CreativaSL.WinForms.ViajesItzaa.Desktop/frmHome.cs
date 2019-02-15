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
    public partial class frmHome : Form_Creativa
    {
        #region Constructor (es)

        public frmHome()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmHome()");
                this.Close();
            }
        }

        #endregion

        #region Eventos

        #region Eventos Botones

        private void btnMisSolicitudes_Click(object sender, EventArgs e)
        {
            try
            {
                frmSolicitudes solicitudes = new frmSolicitudes();
                this.Visible = false;
                solicitudes.ShowDialog();
                this.Visible = true;
                solicitudes.Dispose();
                if(solicitudes.DialogResult == DialogResult.Abort)
                    this.DialogResult = solicitudes.DialogResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnMisSolicitudes_Click");
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmCatClientes clientes = new frmCatClientes();
                this.Visible = false;
                clientes.ShowDialog(); 
                this.Visible = true;
                clientes.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnClientes_Click");
            }
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            try
            {
                frmCatEmpresas empresas = new frmCatEmpresas();
                this.Visible = false;
                empresas.ShowDialog();
                this.Visible = true;
                empresas.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnClientes_Click");
            }
        }
        
        private void btnCaja_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripCaja.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                MenuStripCaja.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCaja_Click");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Creativa btn = (Button_Creativa)sender;
                MenuStripReportes.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                MenuStripReportes.Focus();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnReportes_Click");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnSalir_Click");
            }
        }

        #endregion

        #region Eventos Click

        private void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitudSeleccionada();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                if (this.dgvSolicitudesPendientes.Rows.Count > 0)
                {
                    sn.AceptarSolicitud(datos);
                    if (!datos.Validador)
                    {
                        switch (datos.Opcion)
                        {
                            case 1: MessageBox.Show("No se puede Aceptar una solicitud si ya tiene alguna en estatus \"Recibido\".", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 2: MessageBox.Show("Ocurrió un error. La solicitud " + datos.Folio + " no se encuentra disponible.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.CargarGridSolicitudes();
                                this.EstablecerImagenGrid();
                                break;
                            default: break;
                        }
                    }
                    else
                    {
                        this.CargarGridSolicitudes();
                        this.EstablecerImagenGrid();
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra solicitudes para aceptar", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridSolicitudes();
                    this.EstablecerImagenGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAceptarSolicitud_Click");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarGridSolicitudes();
                this.EstablecerImagenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnActualizar_Click");
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud datos = this.ObtenerDatosSolicitudSeleccionada();
                if (!string.IsNullOrEmpty(datos.IDSolicitud))
                {
                    frmDetalleSolicitud detalle = new frmDetalleSolicitud(datos, 2);
                    this.Visible = false;
                    detalle.ShowDialog();
                    this.Visible = true;
                    detalle.Dispose();
                }
                else
                    MessageBox.Show("Seleccione una solicitud.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnVerDetalles_Click");
            }
        }

        #endregion

        #region Eventos Home

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem;
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarDiseñoForm();
                this.IniciarGrid(this.dgvSolicitudesPendientes, 9);
                this.CargarGridSolicitudes();
                this.EstablecerImagenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmHome_Load");
                this.Close();
            }
        }

        #endregion

        #region Eventos Menú Caja

        private void toolsm_caja_cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCaja_MontoEnCaja cerrarCaja = new frmCaja_MontoEnCaja();
                cerrarCaja.ShowDialog();
                cerrarCaja.Dispose();
                if (cerrarCaja.DialogResult == DialogResult.OK)
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "toolsm_caja_cerrar_Click");
            }
        }

        private void toolsm_caja_retiros_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositosRetiros retiros = new frmDepositosRetiros(3);
                retiros.ShowDialog();
                retiros.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "toolsm_caja_retiros_Click");
            }
        }

        private void toolsm_caja_depositos_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositosRetiros depositos = new frmDepositosRetiros(1);
                depositos.ShowDialog();
                depositos.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "toolsm_caja_depositos_Click");
            }
        }

        private void retiroCajaLlenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepositosRetiros retiros = new frmDepositosRetiros(2);
                retiros.ShowDialog();
                retiros.Dispose();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "retiroCajaLlenaToolStripMenuItem_Click");
            }
        }

        #endregion

        #region Eventos Menú Reportes

        private void tsCaja_Click(object sender, EventArgs e)
        {
            try
            {
                int aux = 0;
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                int.TryParse(item.Tag.ToString(), out aux);
                frmViewReportes reporteador = new frmViewReportes(aux);
                this.Visible = false;
                reporteador.ShowDialog();
                this.Visible = true;
                reporteador.Dispose();
            }
            catch (Exception ex)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                Comun_Negocio.AddExcFileTxt(ex, "tsCaja_Click" + item.Tag);
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Timer

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {

            try
            {
                DateTime fechaActual = new DateTime();
                fechaActual = DateTime.Now;
                this.txtFec_Actual.Text = fechaActual.ToShortDateString();
                this.txtHor_Actual.Text = fechaActual.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "timerFechaHora_Tick");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarGridSolicitudes()
        {
            try
            {
                Solicitud datos = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 0;
                datos.IDUsuarioRecibido = string.Empty;
                this.dgvSolicitudesPendientes.DataSource = sn.ObtenerSolicitudes(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridSolicitudesTodos()
        {
            try
            {
                Solicitud datos = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 5;
                datos.IDUsuarioRecibido = string.Empty;
                this.dgvSolicitudesPendientes.DataSource = sn.ObtenerSolicitudes(datos);
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
                cdgv.ImagenGrid(this.dgvSolicitudesPendientes, "IDTipoSolicitud", "TipoSolicitud", "IDStatusSolicitud", "Estatus");
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
                dgvConf.AddColumnsDataGridView(actual, numColumns, this.ObtenerPropiedadesColumnas());
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

        private void IniciarDiseñoForm()
        {
            try
            {
                if (Comun.IDTipoUsuario != 1)
                {
                    this.btnSalir.Location = this.btnReportes.Location;
                    this.btnReportes.Visible = false;
                }
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
                if (this.dgvSolicitudesPendientes.Rows.Count > 0)
                {
                    DataGridViewRow fila = this.dgvSolicitudesPendientes.Rows[0];
                    datos.IDSolicitud = fila.Cells["IDSolicitud"].Value.ToString();
                    datos.Folio = fila.Cells["Folio"].Value.ToString();
                    datos.IDStatusSolicitud = Convert.ToInt32(fila.Cells["IDStatusSolicitud"].Value.ToString());
                    datos.IDTipoSolicitud = Convert.ToInt32(fila.Cells["IDTipoSolicitud"].Value.ToString());
                    datos.Conexion = Comun.Conexion;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Solicitud ObtenerDatosSolicitudSeleccionada()
        {
            try
            {
                Solicitud datos = new Solicitud();
                datos.IDSolicitud = string.Empty;
                if (this.dgvSolicitudesPendientes.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = this.dgvSolicitudesPendientes.SelectedRows[0];
                    datos.IDSolicitud = fila.Cells["IDSolicitud"].Value.ToString();
                    datos.Folio = fila.Cells["Folio"].Value.ToString();
                    datos.IDStatusSolicitud = Convert.ToInt32(fila.Cells["IDStatusSolicitud"].Value.ToString());
                    datos.IDTipoSolicitud = Convert.ToInt32(fila.Cells["IDTipoSolicitud"].Value.ToString());
                    datos.Conexion = Comun.Conexion;
                    datos.IDUsuarioRecibido = Comun.IDUsuario;
                }
                return datos;
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
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Folio",               "Folio",                "Folio",            1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDStatusSolicitud",    "IDStatusSolicitud",1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Estatus",             "",                     "Estatus",          2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha Solicitud",     "FechaSolicitud",       "FechaSolicitud",   1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Hora Solicitud",      "HoraSolicitud",        "HoraSolicitud",    1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDStatusSolicitud",   "IDTipoSolicitud",      "IDTipoSolicitud",  1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Tipo Solicitud",      "",                     "TipoSolicitud",    2,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Producto",            "NombreProducto",       "NombreProducto",   1,          true,           330,        DataGridViewContentAlignment.MiddleLeft,        ""},
                };

                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
             try
            {
                this.CargarGridSolicitudesTodos();
                this.EstablecerImagenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnVerTodos_Click");
            }
        }

    }
}
