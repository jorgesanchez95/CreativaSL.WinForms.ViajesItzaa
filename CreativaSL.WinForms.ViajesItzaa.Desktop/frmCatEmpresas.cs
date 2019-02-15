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
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using CreativaSL.LibControls.WinForms;
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCatEmpresas : Form_Creativa
    {       
        #region Propiedades

        private string _Busqueda;
        private Empresa _EmpresaSeleccionada;
        private bool _ISBusqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set { _Busqueda = value; }
        }
        public Empresa EmpresaSeleccionada
        {
            get { return _EmpresaSeleccionada; }
        }
        public bool ISBusqueda
        {            
            set { _ISBusqueda = value; }
        }

        #endregion

        #region Constructor

        public frmCatEmpresas()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCatEmpresas");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion

        #region Eventos

        #region Eventos Búsqueda

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarDatosGrid(this.txtBusqueda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnBusqueda_Click");
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (Char)Keys.Enter)
                    this.btnBusqueda_Click(this.btnBusqueda, new EventArgs());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "txtBusqueda_KeyPress");
            }
        }

        #endregion

        #region Eventos DataGridView

        private void dgv_Clientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.LlenarDetalleEmpresa(this.ObtenerDatosEmpresa());
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgv_Clientes_SelectionChanged");
            }
        }

        private void dgv_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this._ISBusqueda)
                {
                    this._EmpresaSeleccionada = this.ObtenerDatosEmpresa();
                    if (!string.IsNullOrEmpty(this._EmpresaSeleccionada.IDEmpresa) && !string.IsNullOrWhiteSpace(this._EmpresaSeleccionada.IDEmpresa))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dgv_Clientes_CellDoubleClick");
            }
        }

        #endregion

        #region Eventos del Formulario

        private void frmCatEmpresas_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Empresas";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarGrid(this.dgv_Empresas, 5);
                if(this._ISBusqueda)
                    this.CargarDatosGrid(this._Busqueda);
                else
                    this.CargarDatosGrid(string.Empty);
                this.ActiveControl = this.txtBusqueda;
                this.txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCatEmpresas_Load");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion

        #region Eventos Menú Principal

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevaEmpresa empresa = new frmNuevaEmpresa();
                empresa.ShowDialog();
                empresa.Dispose();
                if (empresa.DialogResult == DialogResult.OK)
                {
                    this.CargarDatosGrid(string.Empty);
                    this.LlenarDetalleEmpresa(this.ObtenerDatosEmpresa());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevaEmpresa_Click");                
            }
        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa datos = this.ObtenerDatosEmpresa();
                if (!string.IsNullOrEmpty(datos.IDEmpresa))
                {
                    frmNuevaEmpresa modificar = new frmNuevaEmpresa(datos);
                    modificar.ShowDialog();
                    modificar.Dispose();
                    if (modificar.DialogResult == DialogResult.OK)
                    {
                        this.CargarDatosGrid(string.Empty);
                        this.LlenarDetalleEmpresa(this.ObtenerDatosEmpresa());
                    }
                }
                else
                    MessageBox.Show("Seleccione una empresa. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnModificarEmpresa_Click");
            }
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa aux = this.ObtenerDatosEmpresa();
                if (!string.IsNullOrEmpty(aux.IDEmpresa))
                {                    
                    if ((MessageBox.Show("¿Está seguro de eliminar la empresa [ " + aux.NombreComercial + "  ] ?",
                        Comun.CaptionSystem, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                    {
                        Empresa_Negocio en = new Empresa_Negocio();
                        aux.Opcion = 3;
                        aux.Conexion = Comun.Conexion;
                        aux.IDUsuario = Comun.IDUsuario;
                        en.CatEmpresasABC(aux);
                        if (aux.Validador)
                        {
                            MessageBox.Show("El registro ha sido eliminado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CargarDatosGrid(string.Empty);
                            this.LlenarDetalleEmpresa(this.ObtenerDatosEmpresa());
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el registro. Intente nuevamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Seleccione un cliente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEliminarEmpresa_Click");
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

        private void CargarDatosGrid(string busqueda)
        {
            try
            {
                Empresa empresa = new Empresa();
                Empresa_Negocio en = new Empresa_Negocio();
                empresa.Conexion = Comun.Conexion;
                empresa.NombreComercial = busqueda;
                this.dgv_Empresas.DataSource = en.ObtenerCatEmpresas(empresa);
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

        private void LlenarDetalleEmpresa(Empresa datos)
        {
            try
            {
                if (!string.IsNullOrEmpty(datos.IDEmpresa))
                {
                    this.txtNombre.Text = datos.NombreComercial;
                    this.txtContacto.Text = datos.Contacto;
                    this.txtTelefono.Text = datos.Telefono;
                    this.txtCorreoElectronico.Text = datos.Correo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Empresa ObtenerDatosEmpresa()
        {
            try
            {
                Empresa datos = new Empresa();
                DataGridView dgv = this.dgv_Empresas;
                if (dgv.SelectedRows.Count > 0)
                {
                    if (dgv.SelectedRows[0].Index != -1)
                    {
                        DataGridViewRow fila = dgv.SelectedRows[0];
                        datos.IDEmpresa = fila.Cells["IDEmpresa"].Value.ToString();
                        datos.NombreComercial = fila.Cells["NombreComercial"].Value.ToString();
                        datos.Telefono = fila.Cells["Telefono"].Value.ToString();
                        datos.Correo = fila.Cells["Correo"].Value.ToString();
                        datos.Contacto = fila.Cells["Contacto"].Value.ToString();
                    }
                    else
                        datos.IDEmpresa = string.Empty;
                }
                else
                    datos.IDEmpresa = string.Empty;
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
                    {"IDEmpresa",           "IDEmpresa",            "IDEmpresa",        1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Nombre Comercial",    "NombreComercial",      "NombreComercial",  1,          true,           280,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Contacto",            "Contacto",             "Contacto",         1,          true,           280,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Teléfono",            "Telefono",             "Telefono",         1,          true,           85,        DataGridViewContentAlignment.MiddleCenter,       ""},
                    {"E-Mail",              "Correo",               "Correo",           1,          true,           200,        DataGridViewContentAlignment.MiddleLeft,        ""},
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
