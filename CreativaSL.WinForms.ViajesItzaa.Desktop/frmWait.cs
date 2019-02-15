using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;
using CreativaSL.LibControls.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmWait : Form_Creativa
    {
        #region Constructor

        public frmWait()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void frmWait_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Comun.CaptionSystem + " - Espere...";
                if (File.Exists(Comun.IconoSistema))
                    this.Icon = new Icon(Path.Combine(System.Windows.Forms.Application.StartupPath, Comun.IconoSistema));
                this.label1.Text = "Espere un momento. \r\nEnviando Correo electrónico.";
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "frmWait_Load");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion


        #region Métodos

        public void ActualizarProgreso(int Progreso)
        {
            try
            {
                this.lblPorcentaje.Text = Progreso + " %";
                this.Progreso.Value = Progreso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
