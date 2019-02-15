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
    public partial class frmCatClientes : Form_Creativa
    {
        #region Propiedades

        private string _Busqueda;
        private Cliente _ClienteSeleccionado;
        private bool _ISBusqueda;

        public string Busqueda
        {
            get { return _Busqueda; }
            set { _Busqueda = value; }
        }
        public Cliente ClienteSeleccionado
        {
            get { return _ClienteSeleccionado; }
        }
        public bool ISBusqueda
        {            
            set { _ISBusqueda = value; }
        }

        #endregion

        #region Constructor

        public frmCatClientes()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmCatClientes");
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
                this.LlenarDetalleCliente(this.ObtenerDatosCliente());
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
                    this._ClienteSeleccionado = this.ObtenerDatosCliente();
                    if (!string.IsNullOrEmpty(this._ClienteSeleccionado.IDCliente) && !string.IsNullOrWhiteSpace(this._ClienteSeleccionado.IDCliente))
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

        private void frmCatClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Clientes";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarGrid(this.dgv_Clientes, 14);
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
                Comun_Negocio.AddExcFileTxt(ex, "frmCatClientes_Load");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion

        #region Eventos Menú Principal

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevoCliente cliente = new frmNuevoCliente();
                cliente.ShowDialog();
                cliente.Dispose();
                if (cliente.DialogResult == DialogResult.OK)
                {
                    this.CargarDatosGrid(string.Empty);
                    this.LlenarDetalleCliente(this.ObtenerDatosCliente());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevoCliente_Click");                
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente datos = this.ObtenerDatosCliente();
                if (!string.IsNullOrEmpty(datos.IDCliente))
                {
                    frmNuevoCliente modificar = new frmNuevoCliente(datos);
                    modificar.ShowDialog();
                    modificar.Dispose();
                    if (modificar.DialogResult == DialogResult.OK)
                    {
                        this.CargarDatosGrid(string.Empty);
                        this.LlenarDetalleCliente(this.ObtenerDatosCliente());
                    }
                }
                else
                    MessageBox.Show("Seleccione un cliente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnModificarCliente_Click");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente aux = this.ObtenerDatosCliente();
                if (!string.IsNullOrEmpty(aux.IDCliente))
                {                    
                    if ((MessageBox.Show("¿Está seguro de eliminar al cliente [ " + aux.Nombre + " " + aux.ApellidoPaterno + " " + aux.ApellidoMaterno  + "  ] ?",
                        Comun.CaptionSystem, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                    {
                        Cliente_Negocio cn = new Cliente_Negocio();
                        aux.Opcion = 3;
                        aux.Conexion = Comun.Conexion;
                        aux.IDUsuario = Comun.IDUsuario;
                        cn.CatClientesABC(aux);
                        if (aux.Validador)
                        {
                            MessageBox.Show("El registro ha sido eliminado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CargarDatosGrid(string.Empty);
                            this.LlenarDetalleCliente(this.ObtenerDatosCliente());
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
                Comun_Negocio.AddExcFileTxt(ex, "btnEliminarCliente_Click");
            }
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente datos = this.ObtenerDatosCliente();
                if (!string.IsNullOrEmpty(datos.IDCliente))
                {
                    frmCambiarPasswordCliente CambiarPassword = new frmCambiarPasswordCliente(datos);
                    CambiarPassword.ShowDialog();
                    CambiarPassword.Dispose();
                }
                else
                    MessageBox.Show("Seleccione un cliente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAsignarTarjeta_Click");
            }
        }

        private void btnAsignarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente datos = this.ObtenerDatosCliente();
                if (!string.IsNullOrEmpty(datos.IDCliente))
                {
                    frmAsignarEmpresa empresa = new frmAsignarEmpresa(datos);
                    empresa.ShowDialog();
                    empresa.Dispose();
                }
                else
                    MessageBox.Show("Seleccione un cliente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnAsignarEmpresa_Click");
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
                Cliente cliente = new Cliente();
                Cliente_Negocio cn = new Cliente_Negocio();
                cliente.Conexion = Comun.Conexion;
                cliente.Nombre = busqueda;
                this.dgv_Clientes.DataSource = cn.ObtenerCatClientes(cliente);
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

        private void LlenarDetalleCliente(Cliente datos)
        {
            try
            {
                if (!string.IsNullOrEmpty(datos.IDCliente))
                {
                    this.txtNombre.Text = datos.Nombre + " " + datos.ApellidoPaterno + " " + datos.ApellidoMaterno;
                    this.txtGenero.Text = datos.Genero;
                    this.txtCURP.Text = datos.Curp;
                    this.txtTelefono.Text = datos.Telefono;
                    this.txtCorreoElectronico.Text = datos.CorreoElectronico;
                    if (datos.FechaNacimiento != null)
                        this.txtFechaNacimiento.Text = datos.FechaNacimiento.ToShortDateString();
                    else
                        this.txtFechaNacimiento.Text = "";
                    this.txtColonia.Text = datos.Colonia;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Cliente ObtenerDatosCliente()
        {
            try
            {
                Cliente datos = new Cliente();
                DataGridView dgv = this.dgv_Clientes;
                if (dgv.SelectedRows.Count > 0)
                {
                    if (dgv.SelectedRows[0].Index != -1)
                    {
                        DateTime FechaNacimiento;
                        int Id;
                        DataGridViewRow fila = dgv.SelectedRows[0];
                        datos.IDCliente = fila.Cells["IDCliente"].Value.ToString();
                        datos.Nombre = fila.Cells["Nombre"].Value.ToString();
                        datos.ApellidoPaterno = fila.Cells["ApellidoPaterno"].Value.ToString();
                        datos.ApellidoMaterno = fila.Cells["ApellidoMaterno"].Value.ToString();
                        datos.Genero = fila.Cells["Genero"].Value.ToString();
                        datos.Curp = fila.Cells["Curp"].Value.ToString();
                        datos.Telefono = fila.Cells["Telefono"].Value.ToString();
                        if (DateTime.TryParse(fila.Cells["FechaNacimiento"].Value.ToString(), out FechaNacimiento))
                            datos.FechaNacimiento = FechaNacimiento;
                        datos.Colonia = fila.Cells["Colonia"].Value.ToString();
                        datos.CorreoElectronico = fila.Cells["CorreoElectronico"].Value.ToString();
                        if (int.TryParse(fila.Cells["IDPais"].Value.ToString(), out Id))
                            datos.IDPais = Id;
                        if (int.TryParse(fila.Cells["IDEstado"].Value.ToString(), out Id))
                            datos.IDEstado = Id;
                        if (int.TryParse(fila.Cells["IDMunicipio"].Value.ToString(), out Id))
                            datos.IDMunicipio = Id;
                        if (int.TryParse(fila.Cells["IDGenero"].Value.ToString(), out Id))
                            datos.IDGenero = Id;
                    }
                    else
                        datos.IDCliente = string.Empty;
                }
                else
                    datos.IDCliente = string.Empty;
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
                    {"IDCliente",           "IDCliente",            "IDCliente",        1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Nombre",              "Nombre",               "Nombre",           1,          true,           100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Ap. Paterno",         "ApellidoPaterno",      "ApellidoPaterno",  1,          true,           90,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Ap. Materno",         "ApellidoMaterno",      "ApellidoMaterno",  1,          true,           90,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Género",              "Genero",               "Genero",           1,          true,           65,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Curp",                "Curp",                 "Curp",             1,          true,           130,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Teléfono",            "Telefono",             "Telefono",         1,          true,           75,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Fec. de Nac.",        "FechaNacimiento",      "FechaNacimiento",  1,          true,           90,        DataGridViewContentAlignment.MiddleCenter,      "d"},
                    {"Colonia",             "Colonia",              "Colonia",          1,          true,           100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"E-Mail",              "CorreoElectronico",    "CorreoElectronico",    1,      true,           200,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"IDPais",              "IDPais",               "IDPais",           1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDEstado",            "IDEstado",             "IDEstado",         1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDMunicipio",         "IDMunicipio",          "IDMunicipio",      1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDGenero",            "IDGenero",             "IDGenero",         1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""}
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
