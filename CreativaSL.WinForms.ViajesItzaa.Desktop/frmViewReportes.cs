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
using Microsoft.Reporting.WinForms;
using System.Collections;
using System.Configuration;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmViewReportes : Form_Creativa
    {
        #region Variables
        private frmWait Espere = new frmWait();
        private int TipoReporte = 0;
        private string IDSolicitud = string.Empty;
        private bool band = false;
        #endregion

        #region Constructor

        public frmViewReportes(int tipo)
        {
            try
            {
                InitializeComponent();
                TipoReporte = tipo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmViewCorreo_Load");
            }
        }

        public frmViewReportes(int tipo, string ID, bool bn)
        {
            try
            {
                InitializeComponent();
                TipoReporte = tipo;
                this.IDSolicitud = ID;
                this.band = bn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmViewCorreo_Load");
            }
        }

        #endregion

        #region Eventos

        #region Eventos Click

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                 Hashtable errores = this.ValidarDatos();
                 if (errores.Count == 0)
                     this.CargarReporte();
                 else
                     this.MostrarMensajeError(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "btnGenerar_Click");
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

        #region Eventos DateTimePicker

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboCaja(this.dtpFechaInicial.Value);
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "dtpFechaInicial_ValueChanged");
            }
        }

        #endregion

        #region Eventos Del Formulario

        private void frmViewReportes_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Reportes";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.IniciarForm();
                if (TipoReporte == 8 || TipoReporte == 10 || TipoReporte == 11)
                    this.CargarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Comun.MensajeError, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Comun_Negocio.AddExcFileTxt(ex, "frmViewReportes_Load");
            }
        }

        #endregion

        #endregion

        #region Métodos

        private void CargarComboCaja(DateTime Fecha)
        {
            try
            {
                Caja aux = new Caja(Comun.Conexion);
                aux.FechaApertura = Fecha;
                Caja_Negocio cn = new Caja_Negocio();
                this.cmbDatos.DataSource = cn.LlenarComboCajaXSucursalXFecha(aux);
                this.cmbDatos.DisplayMember = "NombreCaja";
                this.cmbDatos.ValueMember = "IDCaja";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboEmpresas()
        {
            try
            {
                Empresa aux = new Empresa();
                Empresa_Negocio en = new Empresa_Negocio();
                aux.Conexion = Comun.Conexion;
                aux.Opcion = 1;

                this.cmbDatos.DataSource = en.LlenarComboEmpresas(aux);
                this.cmbDatos.DisplayMember = "NombreComercial";
                this.cmbDatos.ValueMember = "IDEmpresa";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboUsuario()
        {
            try
            {
                Usuario aux = new Usuario();
                aux.Conexion = Comun.Conexion;
                aux.Opcion = 1;
                Usuario_Negocio un = new Usuario_Negocio();
                this.cmbDatos.DataSource = un.ObtenerComboUsuario(aux);
                this.cmbDatos.DisplayMember = "Nombre";
                this.cmbDatos.ValueMember = "IDUsuario";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarReporte()
        {
            try
            {
                switch (TipoReporte)
                {
                    case 1: this.GenerarReporteSolicitudesRecibidas();
                        break;
                    case 2: this.GenerarReporteSolicitudesCanceladas();
                        break;
                    case 3: this.GenerarReporteSolicitudesEnTramite();
                        break;
                    case 4: this.GenerarReportePaquetesMasVendidos();
                        break;
                    case 5: this.GenerarReporteCaja();
                        break;
                    case 6: this.GenerarReporteRecursosXFechas();
                        break;
                    case 7: this.GenerarReporteEmpleadosVentas();
                        break;
                    case 8: this.GenerarReporteItinerario();
                        break;
                    case 9: this.GenerarReporteSolicitudesXEmpresa();
                        break;
                    case 10: this.GenerarReporteFichaTecnica();
                        break;
                    case 11: this.GenerarReporteFichaTecnicaCorreo();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteCaja()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstCancelaciones = new List<Solicitud>();
                List<Caja> lstCaja = new List<Caja>();
                List<Pago> lstPagos = new List<Pago>();
                List<DepositoRetiro> lstDeposito = new List<DepositoRetiro>();
                List<DepositoRetiro> lstRetiro = new List<DepositoRetiro>();
                List<FormaPago> lstFormasPago = new List<FormaPago>();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptCaja.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                Caja CajaAux = (Caja)this.cmbDatos.SelectedItem;
                datos.Conexion = Comun.Conexion;
                datos.IDUsuario = CajaAux.IDCaja;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                Caja_Negocio cn = new Caja_Negocio();
                Pago_Negocio pn = new Pago_Negocio();
                DepositoRetiro_Negocio drn = new DepositoRetiro_Negocio();
                
                CajaAux = cn.ObtenerResumenCaja(datos);
                lstCaja.Add(CajaAux);
                lstCancelaciones = sn.ObtenerReporteDesgloceCancelacion(datos);
                lstPagos = pn.ObtenerReportePagosXIDCaja(datos);
                datos.Opcion = 1;
                lstDeposito = drn.ObtenerDepositosRetirosXIDCaja(datos);
                datos.Opcion = 2;
                lstRetiro = drn.ObtenerDepositosRetirosXIDCaja(datos);
                lstFormasPago = pn.ObtenerReporteFormasPagoXIDCaja(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstCancelaciones));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Caja", lstCaja));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Pago", lstPagos));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Depositos", lstDeposito));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Retiros", lstRetiro));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("FormasPago", lstFormasPago));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteEmpleadosVentas()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptEmpleadosVentas.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteEmpleadoVentas(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteFichaTecnica()
        {
            try
            {
                Reporte datos = new Reporte();
                datos.IDSolicitud = this.IDSolicitud;
                datos.Conexion = Comun.Conexion;
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux = sn.ObtenerReporteFichaSolicitud(datos);
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[38];
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);

                parameters[4] = new ReportParameter("Folio", aux.Folio);
                parameters[5] = new ReportParameter("Estatus", aux.EstatusSolicitud.ToUpper());
                parameters[6] = new ReportParameter("Producto", aux.NombreProducto.ToUpper());
                parameters[7] = new ReportParameter("Tipo", aux.TipoSolicitud.ToUpper());
                parameters[8] = new ReportParameter("Cotizacion", aux.Cotizacion != null ? aux.Cotizacion.Descripcion.ToUpper():string.Empty);
                parameters[9] = new ReportParameter("Monto", aux.Cotizacion != null ? string.Format("{0:F2}", aux.Cotizacion.Subtotal):string.Format("{0:F2}", 0));
                parameters[10] = new ReportParameter("RequiereFactura", aux.RequiereFacturaTxt);
                parameters[11] = new ReportParameter("FechaSolicitud", aux.FechaSolicitud.ToShortDateString());
                parameters[12] = new ReportParameter("HoraSolicitud", aux.HoraSolicitud);
                parameters[13] = new ReportParameter("FechaLlegada", aux.FechaLlegada.ToShortDateString());
                parameters[14] = new ReportParameter("HoraLlegada", aux.HoraLlegada);
                parameters[15] = new ReportParameter("FechaSalida", aux.FechaSalida.ToShortDateString());
                parameters[16] = new ReportParameter("HoraSalida", aux.HoraSalida);
                parameters[17] = new ReportParameter("TieneBoleto", aux.TieneBoletosAvionTxt);
                parameters[18] = new ReportParameter("AptLlegada", aux.AeropueroLlegada.ToUpper());
                parameters[19] = new ReportParameter("AptSalida", aux.AeropuertoSalida.ToUpper());
                parameters[20] = new ReportParameter("NumAdultos", aux.NumAdultos.ToString());
                parameters[21] = new ReportParameter("NumMenores11", aux.NumMenores11.ToString());
                parameters[22] = new ReportParameter("NumMenores4", aux.NumMenores4.ToString());
                parameters[23] = new ReportParameter("RecursoChofer", aux.IDChofer.ToUpper());
                parameters[24] = new ReportParameter("RecursoHotel", aux.IDHotel.ToUpper());
                parameters[25] = new ReportParameter("RecursoVehiculo", aux.IDVehiculo.ToUpper());
                parameters[26] = new ReportParameter("Observaciones", aux.Observaciones.ToUpper());
                parameters[27] = new ReportParameter("MontoPagado", string.Format("{0:F2}", aux.MontoPagado));
                parameters[28] = new ReportParameter("MontoPendiente", string.Format("{0:F2}", aux.MontoPendiente));
                parameters[29] = new ReportParameter("Estrellas", string.Format("{0:F2}", aux.CategoriaHotel));
                parameters[30] = new ReportParameter("NumDias", aux.NumDias.ToString());
                parameters[31] = new ReportParameter("NumNoches", aux.NumNoches.ToString());
                parameters[32] = new ReportParameter("NumHabitaciones", aux.NumHabitaciones.ToString());
                parameters[33] = new ReportParameter("Motivo", aux.MotivoMontoInicial.ToUpper());
                parameters[34] = new ReportParameter("MontoPenalizacion", string.Format("{0:F2}", aux.MontoPenalizacion));
                parameters[35] = new ReportParameter("MotivoCancelacion", aux.MotivoCancelacion.ToUpper());
                parameters[36] = new ReportParameter("IDStatusSolicitud", aux.IDStatusSolicitud.ToString());
                parameters[37] = new ReportParameter("MontoInicial", string.Format("{0:F2}", aux.MontoInicial));
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                if (reportViewer1.LocalReport.DataSources != null)
                    reportViewer1.LocalReport.DataSources.Clear();
                switch(aux.IDTipoSolicitud)
                {
                    case 1:
                    case 5: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaPaquete.rdlc";
                        break;
                    case 2: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaTour.rdlc";
                        break;
                    case 3: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaHotel.rdlc";
                        break;
                    case 4: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaTransporte.rdlc";
                        break;
                    default: break;
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Habitaciones", aux.ListaHabitaciones != null ? aux.ListaHabitaciones : new List<Habitacion>()));
                this.reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteItinerario()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[7];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                if(reportViewer1.LocalReport.DataSources != null)
                    reportViewer1.LocalReport.DataSources.Clear();                                

                Reporte datos = new Reporte();
                datos.IDSolicitud = this.IDSolicitud;
                datos.Conexion = Comun.Conexion;
                datos.Band = this.band;
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux = sn.ObtenerReporteItinerario(datos);
                parameters[4] = new ReportParameter("txtTitulo", aux.TxtTitulo);
                parameters[5] = new ReportParameter("txtObservaciones", aux.TxtObservaciones);
                parameters[6] = new ReportParameter("txtRecomendaciones", aux.TxtRecomendaciones);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptItinerario.rdlc";
                this.reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Itinerario", aux.DetalleItinerario != null ? aux.DetalleItinerario : new List<LugarTuristico>()));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReportePaquetesMasVendidos()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptPaquetesMasVendidos.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReportePaquetesToursMasVendidos(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteRecursosXFechas()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptRecursosXSolicitud.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteRecursosXFechas(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteSolicitudesCanceladas()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptSolicitudesCanceladas.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteSolicitudesCanceladas(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteSolicitudesEnTramite()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptSolicitudesEnTramite.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;
                object aux = this.ObtenerObjetoSeleccionado();
                if (aux != null)
                {
                    Usuario DatosUsuario = (Usuario)aux;
                    datos.IDUsuario = DatosUsuario.IDUsuario;
                }
                else
                {
                    datos.IDUsuario = string.Empty;
                }
                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteSolicitudesEnTramite(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteSolicitudesRecibidas()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[6];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptSolicitudesRecibidas.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);

                Reporte datos = new Reporte();
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteSolicitudesRecibidas(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GenerarReporteSolicitudesXEmpresa()
        {
            try
            {
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[7];
                //Comun.RazonSocial = "Operadora Turística Viajes Itzaá";
                //Comun.RFC = "XXXX000000XXX";
                //Comun.Direccion = "9a Oriente, entre 2a y 3a Norte. #328. Col. Barrio Hidalgo. Tuxtla Gutiérrez, Chiapas, México.";
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicio", this.dtpFechaInicial.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFin", this.dtpFechaFinal.Value.ToShortDateString());                
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();

                List<Solicitud> lstReporteSolicitudes = new List<Solicitud>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptSolicitudesEmpresa.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
                

                Reporte datos = new Reporte();
                Empresa aux = new Empresa();
                aux = (Empresa)this.cmbDatos.SelectedItem;
                datos.IDUsuario = aux.IDEmpresa;
                datos.FechaInicio = this.dtpFechaInicial.Value;
                datos.FechaFin = this.dtpFechaFinal.Value;
                datos.Opcion = 1;
                datos.Conexion = Comun.Conexion;

                parameters[6] = new ReportParameter("nombrecomercial", aux.NombreComercial);
                Solicitud_Negocio sn = new Solicitud_Negocio();
                lstReporteSolicitudes = sn.ObtenerReporteSolicitudesXEmpresas(datos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Solicitudes", lstReporteSolicitudes));
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
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
                this.dtpFechaInicial.Value = DateTime.Today;
                this.dtpFechaFinal.Value = DateTime.Today;
                switch (TipoReporte)
                {
                    case 1:
                    case 2:
                    case 4:
                    case 6:
                    case 7:
                        break;
                    case 3: this.CargarComboUsuario();
                        break;
                    case 5: this.CargarComboCaja(this.dtpFechaInicial.Value);
                        this.dtpFechaFinal.Visible = false;
                        this.lblFechaFinal.Visible = false;
                        this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
                        break;
                    case 9: this.CargarComboEmpresas();
                        break;
                    default:
                        break;

                }
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
                switch (TipoReporte)
                {
                    case 1: this.panelReporte.Title = "REPORTE SOLICITUDES RECIBIDAS SIN ASIGNAR";
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 2: this.panelReporte.Title = "REPORTE SOLICITUDES CANCELADAS";
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 3: this.panelReporte.Title = "REPORTE SOLICITUDES EN TRÁMITE POR USUARIO";
                        break;
                    case 4: this.panelReporte.Title = "REPORTE PAQUETES / TOURS MÁS VENDIDOS";
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 5: this.panelReporte.Title = "REPORTE CAJA";                        
                        break;
                    case 6: this.panelReporte.Title = "REPORTE RECURSOS POR SOLICITUD";
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 7: this.panelReporte.Title = "REPORTE TOTALES POR VENDEDOR";
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 8: this.panelReporte.Title = "I T I N E R A R I O";
                        this.lblFechaInicial.Visible = false;
                        this.dtpFechaInicial.Visible = false;
                        this.lblFechaFinal.Visible = false;
                        this.dtpFechaFinal.Visible = false;
                        this.btnGenerar.Visible = false;
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 9: this.panelReporte.Title = "REPORTE SOLICITUDES POR EMPRESAS";
                        this.lblCombo.Text = "Empresa";
                        break;
                    case 10: this.panelReporte.Title = "F I C H A    D E    L A    S O L I C I T U D";
                        this.lblFechaInicial.Visible = false;
                        this.dtpFechaInicial.Visible = false;
                        this.lblFechaFinal.Visible = false;
                        this.dtpFechaFinal.Visible = false;
                        this.btnGenerar.Visible = false;
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    case 11: this.panelReporte.Title = "F I C H A    D E    L A    S O L I C I T U D";
                        this.lblFechaInicial.Visible = false;
                        this.dtpFechaInicial.Visible = false;
                        this.lblFechaFinal.Visible = false;
                        this.dtpFechaFinal.Visible = false;
                        this.btnGenerar.Visible = false;
                        this.lblCombo.Visible = false;
                        this.cmbDatos.Visible = false;
                        break;
                    default:
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
                this.IniciarDiseñoForm();
                this.IniciarDatos();
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
                cadenaErrores = "No se pudo generar el informe. Se presentaron los siguientes errores: \r\n";
                int aux = 1;

                foreach (DictionaryEntry de in errores)
                {
                    Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
                    cadenaErrores += aux + "\t" + de.Value + "\r\n"; ;
                    aux++;
                }
                MessageBox.Show(cadenaErrores, Comun.CaptionSystem, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.txt_mensaje.Text = cadenaErrores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ObtenerMensajeErrorFechas(int error)
        {
            try
            {
                string mensaje = string.Empty;
                switch (error)
                {
                    case 1: mensaje = "La fecha Final no puede ser menor a la fecha Inicial.";
                        break;
                    case 2: mensaje = "La fecha no puede ser menor a la fecha Actual.";
                        break;
                    case 3: mensaje = "El rango de fechas no puede ser mayor a 30 días.";
                        break;
                    default:
                        break;
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object ObtenerObjetoSeleccionado()
        {
            try
            {
                object resultado = null;
                if (this.cmbDatos.Items.Count > 0)
                {
                    if (this.cmbDatos.SelectedIndex != -1)
                    {
                        resultado = this.cmbDatos.SelectedItem;
                    }
                }
                return resultado;
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
                int aux = 0;
                Hashtable errores = new Hashtable();
                List<int> erroresFecha = new List<int>();
                erroresFecha = this.ValidarFechas();
                foreach (int error in erroresFecha)
                {
                    aux ++;
                    errores.Add(aux, this.ObtenerMensajeErrorFechas(error));
                }
                if (!ValidarSeleccionCombo())
                    errores.Add(aux++, "Seleccione un elemento de la lista desplegable.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<int> ValidarFechas()
        {
            try
            {
                List<int> errores = new List<int>();
                switch (TipoReporte)
                {
                    case 1: 
                    case 2:
                    case 3:
                    case 4:
                    case 6:
                    case 7:
                    case 9:
                        if (this.dtpFechaFinal.Value < this.dtpFechaInicial.Value)
                                errores.Add(1);
                            TimeSpan ts = this.dtpFechaFinal.Value - this.dtpFechaInicial.Value;
                            if (ts.Days > 31)
                                errores.Add(3);
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarSeleccionCombo()
        {
            try
            {
                bool band = true;
                object aux = this.ObtenerObjetoSeleccionado();
                switch (TipoReporte)
                {
                    case 1:
                    case 2:
                    case 4:
                    case 6:
                    case 7:
                        break;
                    case 3: 
                        if (aux == null)
                        {
                            band = false;
                        }                        
                        break;
                    case 5:
                        if (aux == null)
                        {
                            band = false;
                        }
                        else
                        {
                            Caja DatosCaja = (Caja)aux;
                            if (string.IsNullOrEmpty(DatosCaja.IDCaja))
                                band = false;
                        }
                        break;
                    case 9:
                        if (aux == null)
                        {
                            band = false;
                        }
                        else
                        {
                            Empresa DatosEmpresa = (Empresa)aux;
                            if (string.IsNullOrEmpty(DatosEmpresa.IDEmpresa))
                                band = false;
                        }
                        break;
                    default: 
                    //object aux = this.ObtenerObjetoSeleccionado();
                    //    if (aux != null)
                    //    {
                    //        Caja datos = (Caja)aux;
                    //        if (string.IsNullOrEmpty(datos.IDCaja))
                    //        {
                    //            band = false;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        band = false;
                    //    }                        
                        break;
                }
                return band;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void GenerarReporteFichaTecnicaCorreo()
        {
            try
            {
                this.Visible = false;
                Reporte datos = new Reporte();
                datos.IDSolicitud = this.IDSolicitud;
                datos.Conexion = Comun.Conexion;
                Solicitud aux = new Solicitud();
                Solicitud_Negocio sn = new Solicitud_Negocio();
                aux = sn.ObtenerReporteFichaSolicitud(datos);
                //Generar Parámetros del Informe
                ReportParameter[] parameters = new ReportParameter[38];
                parameters[0] = new ReportParameter("empresa", Comun.RazonSocial);
                parameters[1] = new ReportParameter("rfc", Comun.RFC);
                parameters[2] = new ReportParameter("direccion", Comun.Direccion);
                if (File.Exists(@"Resources\documents\" + Comun.UrlLogo.ToLower()))
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.UrlLogo.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("imglogo", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\viajes.jpg")).AbsoluteUri);

                parameters[4] = new ReportParameter("Folio", aux.Folio);
                parameters[5] = new ReportParameter("Estatus", aux.EstatusSolicitud.ToUpper());
                parameters[6] = new ReportParameter("Producto", aux.NombreProducto.ToUpper());
                parameters[7] = new ReportParameter("Tipo", aux.TipoSolicitud.ToUpper());
                parameters[8] = new ReportParameter("Cotizacion", aux.Cotizacion != null ? aux.Cotizacion.Descripcion.ToUpper() : string.Empty);
                parameters[9] = new ReportParameter("Monto", aux.Cotizacion != null ? string.Format("{0:F2}", aux.Cotizacion.Subtotal) : string.Format("{0:F2}", 0));
                parameters[10] = new ReportParameter("RequiereFactura", aux.RequiereFacturaTxt);
                parameters[11] = new ReportParameter("FechaSolicitud", aux.FechaSolicitud.ToShortDateString());
                parameters[12] = new ReportParameter("HoraSolicitud", aux.HoraSolicitud);
                parameters[13] = new ReportParameter("FechaLlegada", aux.FechaLlegada.ToShortDateString());
                parameters[14] = new ReportParameter("HoraLlegada", aux.HoraLlegada);
                parameters[15] = new ReportParameter("FechaSalida", aux.FechaSalida.ToShortDateString());
                parameters[16] = new ReportParameter("HoraSalida", aux.HoraSalida);
                parameters[17] = new ReportParameter("TieneBoleto", aux.TieneBoletosAvionTxt);
                parameters[18] = new ReportParameter("AptLlegada", aux.AeropueroLlegada.ToUpper());
                parameters[19] = new ReportParameter("AptSalida", aux.AeropuertoSalida.ToUpper());
                parameters[20] = new ReportParameter("NumAdultos", aux.NumAdultos.ToString());
                parameters[21] = new ReportParameter("NumMenores11", aux.NumMenores11.ToString());
                parameters[22] = new ReportParameter("NumMenores4", aux.NumMenores4.ToString());
                parameters[23] = new ReportParameter("RecursoChofer", aux.IDChofer.ToUpper());
                parameters[24] = new ReportParameter("RecursoHotel", aux.IDHotel.ToUpper());
                parameters[25] = new ReportParameter("RecursoVehiculo", aux.IDVehiculo.ToUpper());
                parameters[26] = new ReportParameter("Observaciones", aux.Observaciones.ToUpper());
                parameters[27] = new ReportParameter("MontoPagado", string.Format("{0:F2}", aux.MontoPagado));
                parameters[28] = new ReportParameter("MontoPendiente", string.Format("{0:F2}", aux.MontoPendiente));
                parameters[29] = new ReportParameter("Estrellas", string.Format("{0:F2}", aux.CategoriaHotel));
                parameters[30] = new ReportParameter("NumDias", aux.NumDias.ToString());
                parameters[31] = new ReportParameter("NumNoches", aux.NumNoches.ToString());
                parameters[32] = new ReportParameter("NumHabitaciones", aux.NumHabitaciones.ToString());
                parameters[33] = new ReportParameter("Motivo", aux.MotivoMontoInicial.ToUpper());
                parameters[34] = new ReportParameter("MontoPenalizacion", string.Format("{0:F2}", aux.MontoPenalizacion));
                parameters[35] = new ReportParameter("MotivoCancelacion", aux.MotivoCancelacion.ToUpper());
                parameters[36] = new ReportParameter("IDStatusSolicitud", aux.IDStatusSolicitud.ToString());
                parameters[37] = new ReportParameter("MontoInicial", string.Format("{0:F2}", aux.MontoInicial));
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                if (reportViewer1.LocalReport.DataSources != null)
                    reportViewer1.LocalReport.DataSources.Clear();
                switch (aux.IDTipoSolicitud)
                {
                    case 1:
                    case 5: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaPaquete.rdlc";
                        break;
                    case 2: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaTour.rdlc";
                        break;
                    case 3: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaHotel.rdlc";
                        break;
                    case 4: this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForms.ViajesItzaa.Desktop.Informes.rptFichaTransporte.rdlc";
                        break;
                    default: break;
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Habitaciones", aux.ListaHabitaciones != null ? aux.ListaHabitaciones : new List<Habitacion>()));
                this.reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string extension;
                string encoding;
                
                byte[] bytes = this.reportViewer1.LocalReport.Render("PDF", null, out mimeType,
                       out encoding, out extension, out streamids, out warnings);
                FileStream fs = new FileStream(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\FichasEnviadas\" + aux.Folio + @".pdf"), FileMode.Create);
                //FileStream fs = new FileStream(@"C:\FichasEnviadas\" + aux.Folio + @".pdf", FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                //string file = @"C:\FichasEnviadas\" + aux.Folio + @".pdf";
                string file = Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\FichasEnviadas\" + aux.Folio + @".pdf");
                fs.Close();
                if (!string.IsNullOrEmpty(aux.Cliente.CorreoElectronico))
                {
                    EnvioCorreo.EnviarCorreoArchivo(
                                ConfigurationManager.AppSettings.Get("CorreoTxt")
                            , ConfigurationManager.AppSettings.Get("PasswordTxt")
                            , aux.Cliente.CorreoElectronico
                            , "Viajes por chiapas. Ficha de Solicitud " + aux.Folio 
                            , ""
                            , true
                            , file
                            , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("HtmlTxt"))
                            , ConfigurationManager.AppSettings.Get("HostTxt")
                            , Convert.ToInt32(ConfigurationManager.AppSettings.Get("PortTxt"))
                            , Convert.ToBoolean(ConfigurationManager.AppSettings.Get("EnableSslTxt")));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
