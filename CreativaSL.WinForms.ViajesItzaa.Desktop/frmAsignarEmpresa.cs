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
    public partial class frmAsignarEmpresa : Form_Creativa
    {
        
        #region Variables

        private Cliente Datos = new Cliente();

        #endregion

        #region Constructor

        public frmAsignarEmpresa(Cliente aux)
        {
            try
            {
                InitializeComponent();
                Datos = aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarEmpresa");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    Cliente aux = this.ObtenerDatosCliente();
                    Cliente_Negocio cn = new Cliente_Negocio();
                    cn.ActualizarEmpresaCliente(aux);
                    if(aux.Validador)
                    {
                        MessageBox.Show("Datos guardados correctamente. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al guardar los datos. Intente Nuevamente. Si el problema persiste, contacte a Soporte Técnico.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    this.MostarMensajeErrorValidacion(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGuardar_Click");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmAsignarEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Asignar Empresa";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmAsignarEmpresa_Load");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private bool ExisteItemEnCombo(string IDEmpresa)
        {
            try
            {
                bool band = false;
                foreach (Empresa item in this.cmbEmpresa.Items)
                {
                    if (item.IDEmpresa == IDEmpresa)
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

        private void IniciarDatos()
        {
            try
            {
                Cliente aux = new Cliente();
                Cliente_Negocio cn = new Cliente_Negocio();
                aux.IDCliente = this.Datos.IDCliente;
                aux.Conexion = Comun.Conexion;
                aux = cn.ObtenerDatosEmpresaCliente(aux);
                if (!string.IsNullOrEmpty(aux.IDCliente))
                {
                    this.txtNombreCliente.Text = aux.Nombre;
                    this.txtEmpresa.Text = aux.Empresa;
                    this.LlenarComboEmpresa();
                    if (this.ExisteItemEnCombo(aux.IDEmpresa))
                    {
                        this.cmbEmpresa.SelectedValue = aux.IDEmpresa;
                    }
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
                this.IniciarDatos();
                this.ActiveControl = this.cmbEmpresa;
                this.cmbEmpresa.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboEmpresa()
        {
            try
            {
                Empresa emp = new Empresa();
                Empresa_Negocio en = new Empresa_Negocio();
                emp.Conexion = Comun.Conexion;
                emp.Opcion = 1;
                this.cmbEmpresa.DataSource = en.LlenarComboEmpresas(emp);
                this.cmbEmpresa.DisplayMember = "NombreComercial";
                this.cmbEmpresa.ValueMember = "IDEmpresa";
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

        private Cliente ObtenerDatosCliente()
        {
            try
            {
                Cliente Aux = new Cliente();
                Aux.IDCliente = this.Datos.IDCliente;
                Aux.IDEmpresa = this.ObtenerEmpresaSeleccionada().IDEmpresa;
                Aux.IDUsuario = Comun.IDUsuario;
                Aux.Conexion = Comun.Conexion;
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Empresa ObtenerEmpresaSeleccionada()
        {
            try
            {
                Empresa aux = new Empresa();
                if (this.cmbEmpresa.SelectedIndex != -1)
                {
                    aux = (Empresa)this.cmbEmpresa.SelectedItem;
                }
                return aux;
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
                if (string.IsNullOrEmpty(this.ObtenerEmpresaSeleccionada().IDEmpresa))
                    errores.Add(1, "Seleccione la empresa asociada al cliente.");
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
