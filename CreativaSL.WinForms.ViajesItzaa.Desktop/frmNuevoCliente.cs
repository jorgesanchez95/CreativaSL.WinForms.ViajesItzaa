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
    public partial class frmNuevoCliente : Form_Creativa
    {
        #region Variables

        private int Opcion = 0;
        private Cliente cliente = new Cliente();

        #endregion

        #region Constructor

        public frmNuevoCliente()
        {
            try
            {
                InitializeComponent();
                this.Opcion = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevoCliente");
                this.DialogResult = DialogResult.Abort;
            }
        }

        public frmNuevoCliente(Cliente datos)
        {
            try
            {
                InitializeComponent();
                this.Opcion = 2;
                cliente = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevoCliente");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Nuevo Cliente";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.CargarCombos();
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmNuevoCliente");
                this.DialogResult = DialogResult.Abort;
            }
        }

        #endregion

        #region Eventos Click

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatosEntrada();
                if (errores.Count == 0)
                {
                    Cliente datos = this.ObtenerDatosCliente();
                    Cliente_Negocio cn = new Cliente_Negocio();
                    cn.CatClientesABC(datos);
                    if (datos.Validador)
                    {
                        MessageBox.Show("Datos registrados correctamente.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al guardar los datos. Es posible que el correo electrónico ya esté registrado.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.MostrarMensajeError(errores);
                }
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
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnCancelar_Click");
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbEstado.Items.Count > 0)
                {
                    if (this.cmbEstado.SelectedIndex >= 0)
                    {
                        try
                        {
                            Estado estado = (Estado)this.cmbEstado.SelectedItem;
                            this.CargarComboMunicipio(estado);
                        }
                        catch (Exception ax)
                        {
                            throw ax;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "cmbEstado_SelectedIndexChanged");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarComboEstado(Pais pais)
        {
            try
            {
                Estado datos = new Estado();
                Estado_Negocio en = new Estado_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                datos.IDPais = pais.IDPais;
                this.cmbEstado.DisplayMember = "NombreEstado";
                this.cmbEstado.ValueMember = "IDEstado";
                this.cmbEstado.DataSource = en.LlenarComboEstados(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboOcupaciones()
        {
            try
            {
                Ocupacion datos = new Ocupacion();
                Ocupacion_Negocio on = new Ocupacion_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbOcupacion.DataSource = on.LlenarComboOcupaciones(datos);
                this.cmbOcupacion.DisplayMember = "NombreOcupacion";
                this.cmbOcupacion.ValueMember = "IDOcupacion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboMunicipio(Estado estado)
        {
            try
            {
                Municipio datos = new Municipio();
                Municipio_Negocio mn = new Municipio_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                datos.IDPais = estado.IDPais;
                datos.IDEstado = estado.IDEstado;
                this.cmbMunicipio.DataSource = mn.LlenarComboMunicipios(datos);
                this.cmbMunicipio.DisplayMember = "NombreMunicipio";
                this.cmbMunicipio.ValueMember = "IDMunicipio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboPaises()
        {
            try
            {
                Pais datos = new Pais();
                Pais_Negocio Paisneg = new Pais_Negocio();
                datos.Conexion = Comun.Conexion;
                datos.Opcion = 1;
                this.cmbPais.DataSource = Paisneg.LlenarComboPaises(datos);
                this.cmbPais.DisplayMember = "NombrePais";
                this.cmbPais.ValueMember = "IDPais";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarCombos()
        {
            try
            {
                Pais pais = new Pais();
                pais.IDPais = 143;
                this.CargarComboEstado(pais);
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
                this.InicializarDatos();
                this.ActiveControl = this.txtNombre;
                this.txtNombre.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarDatos()
        {
            try
            {
                switch (this.Opcion)
                {
                    case 1: this.InicializarCampos();
                        break;
                    case 2: this.lblPassword.Text = "Password:";
                        this.LlenarDatosClienteModificar(cliente);
                        break;
                    default:
                        break;
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarCampos()
        {
            try
            {
                this.txtNombre.Text = string.Empty;
                this.txtApellidoPaterno.Text = string.Empty;
                this.txtApellidoMaterno.Text = string.Empty;
                this.txtCURP.Text = string.Empty;
                this.dtpFechaNacimiento.Value = DateTime.Today;
                this.txtTelefono.Text = string.Empty;
                this.rbGeneroFemenino.Checked = false;
                this.rbGeneroMasculino.Checked = true;
                if (this.cmbOcupacion.Items.Count > 0)
                    this.cmbOcupacion.SelectedIndex = 0;
                this.txtCorreoElectronico.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
                if (this.cmbPais.Items.Count > 0)
                    this.cmbPais.SelectedIndex = 0;
                if (this.cmbEstado.Items.Count > 0)
                    this.cmbEstado.SelectedIndex = 0;
                if (this.cmbMunicipio.Items.Count > 0)
                    this.cmbMunicipio.SelectedIndex = 0;
                this.txtColonia.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatosClienteModificar(Cliente datos)
        {
            try
            {
                this.txtNombre.Text = datos.Nombre;
                this.txtApellidoPaterno.Text = datos.ApellidoPaterno;
                this.txtApellidoMaterno.Text = datos.ApellidoMaterno;
                this.txtCURP.Text = datos.Curp;
                this.dtpFechaNacimiento.Value = datos.FechaNacimiento;
                this.txtTelefono.Text = datos.Telefono;
                switch (datos.IDGenero)
                {
                    case 1: this.rbGeneroMasculino.Checked = true;
                        this.rbGeneroFemenino.Checked = false;
                        break;
                    case 2: this.rbGeneroMasculino.Checked = false;
                        this.rbGeneroFemenino.Checked = true;
                        break;
                    default:
                        break;
                }
                if (this.cmbOcupacion.Items.Count > 0)
                    if (datos.IDOcupacion > 0)
                        this.cmbOcupacion.SelectedValue = datos.IDOcupacion;
                this.txtCorreoElectronico.Text = datos.CorreoElectronico;
                this.txtPassword.Text = string.Empty;
                if (this.cmbPais.Items.Count > 0)
                    if (datos.IDPais > 0)
                        this.cmbPais.SelectedValue = datos.IDPais;
                if (this.cmbEstado.Items.Count > 0)
                    if (datos.IDEstado > 0)
                        this.cmbEstado.SelectedValue = datos.IDEstado;
                if (this.cmbMunicipio.Items.Count > 0)
                    if (datos.IDMunicipio > 0)
                        this.cmbMunicipio.SelectedValue = datos.IDMunicipio;
                this.txtColonia.Text = datos.Colonia;
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

        private Cliente ObtenerDatosCliente()
        {
            try
            {
                Cliente datos = new Cliente();
                datos.Nombre = this.txtNombre.Text;
                datos.ApellidoPaterno = this.txtApellidoPaterno.Text;
                datos.ApellidoMaterno = this.txtApellidoMaterno.Text;
                datos.Curp = this.txtCURP.Text;
                datos.FechaNacimiento = this.dtpFechaNacimiento.Value;
                datos.Telefono = this.txtTelefono.Text;
                datos.IDGenero = this.ObtenerIDGenero();
                datos.IDOcupacion = this.ObtenerIDOcupacion();
                datos.CorreoElectronico = this.txtCorreoElectronico.Text;
                datos.IDPais = this.ObtenerIDPais();
                datos.IDEstado = this.ObtenerIDEstado();
                datos.IDMunicipio = this.ObtenerIDMunicipio();
                datos.IDTipoCliente = 1;
                datos.Colonia = this.txtColonia.Text;
                datos.Password = this.txtPassword.Text;
                datos.Conexion = Comun.Conexion;
                datos.IDUsuario = Comun.IDUsuario;
                datos.Opcion = this.Opcion;
                switch (this.Opcion)
                {
                    case 1: datos.IDCliente = string.Empty;
                        break;
                    case 2: datos.IDCliente = cliente.IDCliente;
                        break;
                    default: datos.IDCliente = string.Empty;
                        break;
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerIDEstado()
        {
            try
            {
                int IDEstado = 0;
                if (this.cmbEstado.Items.Count > 0)
                {
                    if (this.cmbEstado.SelectedIndex != -1)
                    {
                        try
                        {
                            Estado Seleccionado = (Estado)this.cmbEstado.SelectedItem;
                            IDEstado = Seleccionado.IDEstado;
                        }
                        catch (Exception)
                        {
                            IDEstado = 143;
                        }
                    }
                }
                return IDEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerIDGenero()
        {
            try
            {
                int auxGenero = 0;
                if (this.rbGeneroFemenino.Checked && this.rbGeneroMasculino.Checked)
                {
                    auxGenero = 0;
                }
                else
                {
                    if (!this.rbGeneroFemenino.Checked && !this.rbGeneroMasculino.Checked)
                    {
                        auxGenero = 0;
                    }
                    else
                    {
                        if (this.rbGeneroMasculino.Checked)
                        {
                            auxGenero = 1;
                        }
                        else
                        {
                            auxGenero = 2;
                        }
                    }
                }
                return auxGenero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerIDMunicipio()
        {
            try
            {
                int IDMunicipio = 0;
                if (this.cmbMunicipio.Items.Count > 0)
                {
                    if (this.cmbMunicipio.SelectedIndex != -1)
                    {
                        try
                        {
                            Municipio Seleccionado = (Municipio)this.cmbMunicipio.SelectedItem;
                            IDMunicipio = Seleccionado.IDMunicipio;
                        }
                        catch (Exception)
                        {
                            IDMunicipio = 0;
                        }
                    }
                }
                return IDMunicipio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerIDOcupacion()
        {
            try
            {
                int IDOcupacion = 0;
                if (this.cmbOcupacion.Items.Count > 0)
                {
                    if (this.cmbOcupacion.SelectedIndex != -1)
                    {
                        try
                        {
                            Ocupacion Seleccionada = (Ocupacion)this.cmbOcupacion.SelectedItem;
                            IDOcupacion = Seleccionada.IDOcupacion;
                        }
                        catch (Exception)
                        {
                            IDOcupacion = 0;
                        }
                    }
                }
                return IDOcupacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerIDPais()
        {
            try
            {
                int IDPais = 143;
                if (this.cmbPais.Items.Count > 0)
                {
                    if (this.cmbPais.SelectedIndex != -1)
                    {
                        try
                        {
                            Pais Seleccionado = (Pais)this.cmbPais.SelectedItem;
                            IDPais = Seleccionado.IDPais;
                        }
                        catch (Exception)
                        {
                            IDPais = 143;
                        }
                    }
                }
                return IDPais;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Hashtable ValidarDatosEntrada()
        {
            try
            {
                Hashtable errores = new Hashtable();
                Validaciones validar = new Validaciones();
                if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtNombre.Text))
                    errores.Add(1, "Ingrese el nombre del cliente. ");
                if (string.IsNullOrEmpty(this.txtApellidoPaterno.Text) || string.IsNullOrWhiteSpace(this.txtApellidoPaterno.Text))
                    errores.Add(2, "Ingrese el apellido paterno del cliente. ");
                if (!string.IsNullOrEmpty(this.txtCURP.Text))
                    if (!validar.ValidarCURP(this.txtCURP.Text))
                        errores.Add(3, "Ingrese una CURP válida. ");
                if (!string.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    if (!validar.ValidarNumeroTelefonico(this.txtTelefono.Text))
                        errores.Add(4, "Ingrese un número telefónico correcto. ");
                }
                else
                    errores.Add(9, "Ingrese un número Telefónico.");
                if((this.rbGeneroMasculino.Checked && this.rbGeneroFemenino.Checked) || (!rbGeneroFemenino.Checked && !rbGeneroMasculino.Checked))
                    errores.Add(5, "Seleccione el Género de la persona. ");
                if(string.IsNullOrEmpty(this.txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(this.txtCorreoElectronico.Text))
                    errores.Add(6, "Ingrese el correo electrónico del cliente. ");
                else
                    if(!validar.ValidarCorreoElectronico(this.txtCorreoElectronico.Text))
                        errores.Add(7, "El Correo ingresado no es válido. ");
                if(Opcion == 1)
                    if(string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
                        errores.Add(8,"Debe ingresar una contraseña. ");
                    else
                    {
                        if(this.txtPassword.Text.Length <4)
                            errores.Add(9, "La contraseña debe contener mínimo 4 caracteres. ");
                    }
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
