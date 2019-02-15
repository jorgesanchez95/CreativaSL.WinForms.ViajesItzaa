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
using System.IO;
using CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux;
using System.Collections;


namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmItinerario : Form_Creativa
    {
        #region Variables

        private int TipoForm = 0;
        private int TipoSolicitud = 0;
        private Solicitud _Solicitud = new Solicitud();
        private List<LugarTuristico> ListaItinerario = new List<LugarTuristico>();
        #endregion

        #region Constructor

        public frmItinerario(int TipoSol, Solicitud Datos, int Opcion)
        {
            try
            {
                InitializeComponent();
                TipoForm = Opcion;
                TipoSolicitud = TipoSol;
                this._Solicitud = Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmItinerario()");
            }
        }

        #endregion

        #region Eventos

        #region Eventos del Formulario

        private void frmItinerario_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Itinerario ";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarGrid(this.dgvItinerario, 10);
                this.IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmItinerario_Load");
            }
        }

        #endregion

        #region Eventos Click

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.AccionAvanzar();
                }
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

        private void btnNuevoLugar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarLugarItinerario NuevoLugar = new frmAgregarLugarItinerario(1, new LugarTuristico(), this.ListaItinerario);
                NuevoLugar.ShowDialog();
                NuevoLugar.Dispose();
                if (NuevoLugar.DialogResult == DialogResult.OK)
                {
                    if (!this.ExisteNumOrden(NuevoLugar.Lugar))
                    {
                        this.AgregarLugarLista(NuevoLugar.Lugar);
                        this.CargarGrid();
                    }
                    else
                        MessageBox.Show("El número del campo Orden no está disponible.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnNuevoLugar_Click");
            }
        }

        private void btnModificarLugar_Click(object sender, EventArgs e)
        {
            try
            {
                LugarTuristico LugarAux = this.ObtenerDatosLugar();
                if (!string.IsNullOrEmpty(LugarAux.IDLugar))
                {
                    frmAgregarLugarItinerario Modificar = new frmAgregarLugarItinerario(2, LugarAux, this.ListaItinerario);
                    Modificar.ShowDialog();
                    Modificar.Dispose();
                    if (Modificar.DialogResult == DialogResult.OK)
                    {
                        this.ModificarLugarLista(Modificar.Lugar);
                        this.CargarGrid();
                    }
                }
                else
                    MessageBox.Show("Seleccione el lugar turístico que desea eliminar del recorrido. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnModificarLugar_Click");
            }
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            try
            {
                LugarTuristico LugarAux = this.ObtenerDatosLugar();
                if (!string.IsNullOrEmpty(LugarAux.IDLugar))
                {
                    if (MessageBox.Show("¿Está seguro de eliminar [ " + LugarAux.Lugar + " con Orden " + LugarAux.Orden + "  ] ?",
                        Comun.CaptionSystem, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.EliminarLugarLista(LugarAux);
                        this.CargarGrid();
                    }
                }
                else
                    MessageBox.Show("Seleccione el lugar turístico que desea eliminar del recorrido. ", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnEliminarLugar_Click");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void AccionAvanzar()
        {
            switch (TipoForm)
            {
                case 1: this.ObtenerDatosSolicitud();
                    if (TipoSolicitud == 5)
                    {
                        if (this.GuardarDatos())
                            this.DialogResult = DialogResult.OK;
                        else
                            MessageBox.Show("La cantidad de días de las fechas establecidas no coincide con la cantidad de días del Itinerario.", Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool ActualizarItinerario(Solicitud DatosActualizar)
        {
            try
            {
                Solicitud_Negocio sn = new Solicitud_Negocio();
                sn.ActualizarDatosItinerario(DatosActualizar);
                return DatosActualizar.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AgregarLugarLista(LugarTuristico Nuevo)
        {
            try
            {
                this.ListaItinerario.Add(Nuevo);
                this.OrdenarListaItinerario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGrid()
        {
            try
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = this.ListaItinerario;
                this.dgvItinerario.DataSource = binding;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarLugarLista(LugarTuristico Eliminar)
        {
            try
            {
                LugarTuristico Borrar = new LugarTuristico();
                foreach (LugarTuristico Aux in this.ListaItinerario)
                {
                    if (Aux.IDLugar == Eliminar.IDLugar && Aux.Orden == Eliminar.Orden)
                    {
                        Borrar = Aux;
                        break;
                    }
                }
                this.ListaItinerario.Remove(Borrar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ExisteLugar(LugarTuristico Nuevo)
        {
            try
            {
                bool band = false;
                foreach (LugarTuristico Lugar in this.ListaItinerario)
                {
                    if (Lugar.IDLugar == Nuevo.IDLugar)
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

        private bool ExisteNumOrden(LugarTuristico Nuevo)
        {
            try
            {
                bool band = false;
                foreach (LugarTuristico Lugar in this.ListaItinerario)
                {
                    if (Lugar.Orden == Nuevo.Orden)
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
                        if (TipoSolicitud == 5)
                        {
                            band = this.RegistarNuevaSolicitud();
                        }
                        break;
                    case 2: band = this.ActualizarItinerario(_Solicitud);
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
                if (TipoForm == 2)
                {
                    this.ObtenerListaItinerario();
                }
                this.CargarGrid();
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

        private void ModificarLugarLista(LugarTuristico DatosAux)
        {
            try
            {
                LugarTuristico anterior = new LugarTuristico();
                foreach (LugarTuristico aux in this.ListaItinerario)
                {
                    if ((DatosAux.IDLugar == aux.IDLugar) && (DatosAux.OrdenAnterior == aux.Orden))
                    {
                        anterior = aux;
                        break;
                    }
                }
                if(!string.IsNullOrEmpty(anterior.IDLugar))
                {
                    this.ListaItinerario.Remove(anterior);
                    this.ListaItinerario.Add(DatosAux);
                    this.OrdenarListaItinerario();                    
                }
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

        private List<LugarTuristico> ObtenerDatosItinerarioActual()
        {
            try
            {
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux.IDSolicitud = this._Solicitud.IDSolicitud;
                aux.Conexion = Comun.Conexion;
                return sn.ObtenerDatosModificarItinerario(aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LugarTuristico ObtenerDatosLugar()
        {
            try
            {
                LugarTuristico DatosAux = new LugarTuristico();
                if (this.dgvItinerario.Rows.Count > 0)
                {
                    if (this.dgvItinerario.SelectedRows.Count > 0)
                    {
                        DatosAux = this.ObtenerLugarFila(this.dgvItinerario.SelectedRows[0]);
                        DatosAux.OrdenAnterior = DatosAux.Orden;
                    }
                }
                return DatosAux;
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
                this._Solicitud.TablaItinerario = this.ObtenerDatosTablaItinerario();
                this._Solicitud.NumDias = this.ObtenerTotalDias();
                this._Solicitud.IDUsuario = Comun.IDUsuario;
                this._Solicitud.Conexion = Comun.Conexion;
                this._Solicitud.Opcion = this.TipoForm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerDatosTablaItinerario()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Orden", typeof(int));
                tabla.Columns.Add("NumeroDias", typeof(int));
                tabla.Columns.Add("IDLugar", typeof(string));
                tabla.Columns.Add("Lugar", typeof(string));
                tabla.Columns.Add("Descripcion", typeof(string));
                tabla.Columns.Add("DescripcionIngles", typeof(string));
                tabla.Columns.Add("Observaciones", typeof(string));
                tabla.Columns.Add("ObservacionesIngles", typeof(string));
                tabla.Columns.Add("Recomendaciones", typeof(string));
                tabla.Columns.Add("RecomendacionesIngles", typeof(string));
                foreach (DataGridViewRow fila in this.dgvItinerario.Rows)
                {
                    LugarTuristico LugarAux = this.ObtenerLugarFila(fila);
                    tabla.Rows.Add(new Object[] { 
                                LugarAux.Orden,
                                LugarAux.NumeroDias,
                                LugarAux.IDLugar,
                                LugarAux.Lugar,
                                LugarAux.Descripcion,
                                LugarAux.DescripcionIngles,
                                LugarAux.Observaciones,
                                LugarAux.ObservacionesIngles,
                                LugarAux.Recomendaciones,
                                LugarAux.RecomendacionesIngles
                            });
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerListaItinerario()
        {
            try
            {
                this.ListaItinerario = this.ObtenerDatosItinerarioActual();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LugarTuristico ObtenerLugarFila(DataGridViewRow fila)
        {
            try
            {
                LugarTuristico FilaLugar = new LugarTuristico();
                FilaLugar.Orden = Convert.ToInt32(fila.Cells["Orden"].Value.ToString());
                FilaLugar.NumeroDias = Convert.ToInt32(fila.Cells["NumeroDias"].Value.ToString());
                FilaLugar.IDLugar = fila.Cells["IDLugar"].Value.ToString();
                FilaLugar.Lugar = fila.Cells["Lugar"].Value.ToString();
                FilaLugar.Descripcion = fila.Cells["Descripcion"].Value.ToString();
                FilaLugar.DescripcionIngles = fila.Cells["DescripcionIngles"].Value.ToString();
                FilaLugar.Observaciones = fila.Cells["Observaciones"].Value.ToString();
                FilaLugar.ObservacionesIngles = fila.Cells["ObservacionesIngles"].Value.ToString();
                FilaLugar.Recomendaciones = fila.Cells["Recomendaciones"].Value.ToString();
                FilaLugar.RecomendacionesIngles = fila.Cells["RecomendacionesIngles"].Value.ToString();
                return FilaLugar;
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
                LugarTuristico lugaqr = new LugarTuristico();
                object[,] propiedades = new object[,] 
                { 
                    //Encabezado            //DataProperty          //Name              //TipoCol   //Visibilidad    //Ancho    //Formato
                    {"Orden",               "Orden",                "Orden",            1,          true,           100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Número de Días",      "NumeroDias",           "NumeroDias",       1,          true,           120,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"IDLugar",             "IDLugar",              "IDLugar",          1,          false,          100,        DataGridViewContentAlignment.MiddleCenter,      ""},
                    {"Lugar",               "Lugar",                "Lugar",            1,          true,           380,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Decripción",          "Descripcion",          "Descripcion",      1,          false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Decripción Inglés",   "DescripcionIngles",    "DescripcionIngles",1,          false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Observaciones",       "Observaciones",        "Observaciones",      1,        false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Observaciones Inglés","ObservacionesIngles",  "ObservacionesIngles",1,        false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"Recomendaciones",     "Recomendaciones",      "Recomendaciones",      1,      false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                    {"RecomendacionesIngles","RecomendacionesIngles","RecomendacionesIngles",1,     false,          100,        DataGridViewContentAlignment.MiddleLeft,        ""},
                };
                return propiedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObtenerTotalDias()
        {
            try
            {
                int TotalDias = 0;
                foreach (LugarTuristico Aux in this.ListaItinerario)
                {
                    TotalDias += Aux.NumeroDias;
                }
                return TotalDias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OrdenarListaItinerario()
        {
            try
            {
                this.ListaItinerario = this.ListaItinerario.OrderBy(A => A.Orden).ToList<LugarTuristico>(); ;
                //this.ListaItinerario.Sort(delegate(LugarTuristico x, LugarTuristico y)
                //{
                //    if (x.IDLugar == null && y.IDLugar == null) return 0;
                //    else return this.CompararLugares(x, y);
                //});
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

        private Hashtable ValidarDatos()
        {
            try
            {
                Hashtable errores = new Hashtable();
                if (this.dgvItinerario.Rows.Count <= 0)
                    errores.Add(1, "Debe agregar al menos un lugar al Itinerario");
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
