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
    public partial class frmNotasSolicitud : Form_Creativa
    {

        #region Variables

        private Nota DatosNota = new Nota();
        
        #endregion

        #region Constructor

        public frmNotasSolicitud(string IDSolicitud)
        {
            try
            {
                InitializeComponent();
                DatosNota.IDSolicitud = IDSolicitud;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotasSolicitud");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmNotasSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Notas";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarGrid(this.dgv_Notas, 6);
                this.CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNotasSolicitud_Load");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Click

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotas NuevaNota = new frmNotas(DatosNota, 1);
                NuevaNota.ShowDialog();
                NuevaNota.Dispose();
                if (NuevaNota.DialogResult == DialogResult.OK)
                {
                    this.CargarDatosGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevaNota_Click");
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            try
            {
                Nota aux = this.ObtenerDatosNota();
                if (!string.IsNullOrEmpty(aux.IDNota))
                {
                    frmNotas ModificarNota = new frmNotas(aux, 2);
                    ModificarNota.ShowDialog();
                    ModificarNota.Dispose();
                    if (ModificarNota.DialogResult == DialogResult.OK)
                    {
                        this.CargarDatosGrid();
                    }
                }
                else
                    MessageBox.Show("Seleccione una nota. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnModificarNota_Click");
            }
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            try
            {
                Nota aux = this.ObtenerDatosNota();
                if (!string.IsNullOrEmpty(aux.IDNota))
                {
                    if ((MessageBox.Show("¿Está seguro de eliminar ésta nota?",
                        Comun.CaptionSystem, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                    {
                        Nota_Negocio nn = new Nota_Negocio();
                        aux.Opcion = 3;
                        aux.Conexion = Comun.Conexion;
                        aux.IDUsuario = Comun.IDUsuario;
                        nn.ABCNotas(aux);
                        if (aux.Validador)
                        {
                            MessageBox.Show("El registro ha sido eliminado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CargarDatosGrid();
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el registro. Intente nuevamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Seleccione una nota. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEliminarNota_Click");
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

        #endregion

        #region Métodos

        private void CargarDatosGrid()
        {
            try
            {
                Nota nota = new Nota();
                Nota_Negocio nn = new Nota_Negocio();
                nota.Conexion = Comun.Conexion;
                nota.Opcion = 0;
                nota.FechaNota = DateTime.Today;
                nota.IDSolicitud = DatosNota.IDSolicitud;
                this.dgv_Notas.DataSource = nn.ObtenerNotasXIDSolicitud(nota);
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

        private Nota ObtenerDatosNota()
        {
            try
            {
                Nota datos = new Nota();
                DataGridView dgv = this.dgv_Notas;
                if (dgv.SelectedRows.Count > 0)
                {
                    if (dgv.SelectedRows[0].Index != -1)
                    {
                        DataGridViewRow fila = dgv.SelectedRows[0];
                        datos.IDNota = fila.Cells["IDNota"].Value.ToString();
                        datos.Notificar = bool.Parse(fila.Cells["Notificar"].Value.ToString());
                        if (datos.Notificar)
                            datos.FechaNotificacion = DateTime.Parse(fila.Cells["FechaNotificacion"].Value.ToString());
                        else
                            datos.FechaNotificacion = DateTime.Today;
                        datos.TextoNota = fila.Cells["TextoNota"].Value.ToString();
                        datos.IDSolicitud = fila.Cells["IDSolicitud"].Value.ToString();
                    }
                    else
                        datos.IDNota = string.Empty;
                }
                else
                    datos.IDNota = string.Empty;
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
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad   //Ancho    //Formato
                    {"IDNota",              "IDNota",               "IDNota",           1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Notificar",           "Notificar",            "Notificar",        1,          false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Notificar",           "NotificarText",        "NotificarText",    1,          true,           100,         DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fecha de Notificacion","FechaNotificacion",   "FechaNotificacion",1,          true,           150,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Detalle Nota",        "TextoNota",            "TextoNota",        1,          true,           900,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"IDSolicitud",         "IDSolicitud",          "IDSolicitud",      1,          false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
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
