namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmViewReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBienvenidoDiseño = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnGenerar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblCombo = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelReporte = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBienvenidoDiseño.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelReporte.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelBienvenidoDiseño);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelBienvenidoDiseño
            // 
            this.panelBienvenidoDiseño.AutoScroll = true;
            this.panelBienvenidoDiseño.BackColor = System.Drawing.Color.White;
            this.panelBienvenidoDiseño.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelBienvenidoDiseño.Controls.Add(this.btnGenerar);
            this.panelBienvenidoDiseño.Controls.Add(this.cmbDatos);
            this.panelBienvenidoDiseño.Controls.Add(this.dtpFechaFinal);
            this.panelBienvenidoDiseño.Controls.Add(this.dtpFechaInicial);
            this.panelBienvenidoDiseño.Controls.Add(this.lblCombo);
            this.panelBienvenidoDiseño.Controls.Add(this.lblFechaFinal);
            this.panelBienvenidoDiseño.Controls.Add(this.lblFechaInicial);
            this.panelBienvenidoDiseño.Controls.Add(this.btnRegresar);
            this.panelBienvenidoDiseño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBienvenidoDiseño.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBienvenidoDiseño.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenidoDiseño.Margin = new System.Windows.Forms.Padding(0);
            this.panelBienvenidoDiseño.Name = "panelBienvenidoDiseño";
            this.panelBienvenidoDiseño.Size = new System.Drawing.Size(1264, 100);
            this.panelBienvenidoDiseño.SizeLine = 3;
            this.panelBienvenidoDiseño.SizeTitle = 0;
            this.panelBienvenidoDiseño.TabIndex = 1;
            this.panelBienvenidoDiseño.Title = "";
            this.panelBienvenidoDiseño.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGenerar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnGenerar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnGenerar.FocusRectangle = true;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGenerar.Image = null;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnGenerar.ImageFocused = null;
            this.btnGenerar.ImageInactive = null;
            this.btnGenerar.ImageMouseOver = null;
            this.btnGenerar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.btnGenerar.ImagePressed = null;
            this.btnGenerar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGenerar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnGenerar.KeyButtonView = false;
            this.btnGenerar.Location = new System.Drawing.Point(1100, 20);
            this.btnGenerar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGenerar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.OffsetPressedContent = true;
            this.btnGenerar.Size = new System.Drawing.Size(75, 65);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.TextDropShadow = true;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbDatos
            // 
            this.cmbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Location = new System.Drawing.Point(650, 20);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(350, 26);
            this.cmbDatos.TabIndex = 21;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(300, 50);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaFinal.TabIndex = 20;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(300, 20);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaInicial.TabIndex = 19;
            // 
            // lblCombo
            // 
            this.lblCombo.BackColor = System.Drawing.Color.Transparent;
            this.lblCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo.Location = new System.Drawing.Point(500, 20);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(140, 23);
            this.lblCombo.TabIndex = 18;
            this.lblCombo.Text = "Cajero / Caja:";
            this.lblCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(150, 50);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(140, 23);
            this.lblFechaFinal.TabIndex = 17;
            this.lblFechaFinal.Text = "Fecha Final:";
            this.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(150, 20);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(140, 23);
            this.lblFechaInicial.TabIndex = 16;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            this.lblFechaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegresar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegresar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegresar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRegresar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRegresar.FocusRectangle = true;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnRegresar.Image = null;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegresar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRegresar.ImageFocused = null;
            this.btnRegresar.ImageInactive = null;
            this.btnRegresar.ImageMouseOver = null;
            this.btnRegresar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._16regresar;
            this.btnRegresar.ImagePressed = null;
            this.btnRegresar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRegresar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRegresar.KeyButtonView = false;
            this.btnRegresar.Location = new System.Drawing.Point(25, 20);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.TextDropShadow = true;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelReporte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 630);
            this.panel2.TabIndex = 1;
            // 
            // panelReporte
            // 
            this.panelReporte.AutoScroll = true;
            this.panelReporte.BackColor = System.Drawing.Color.White;
            this.panelReporte.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelReporte.Controls.Add(this.panel4);
            this.panelReporte.Controls.Add(this.panel3);
            this.panelReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReporte.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelReporte.Location = new System.Drawing.Point(0, 0);
            this.panelReporte.Margin = new System.Windows.Forms.Padding(0);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(1264, 630);
            this.panelReporte.SizeLine = 3;
            this.panelReporte.SizeTitle = 30;
            this.panelReporte.TabIndex = 2;
            this.panelReporte.Title = "";
            this.panelReporte.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.reportViewer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 596);
            this.panel4.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1264, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 34);
            this.panel3.TabIndex = 0;
            // 
            // frmViewReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.ControlBox = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "frmViewReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.frmViewReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panelBienvenidoDiseño.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelReporte.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa panelBienvenidoDiseño;
        private LibControls.WinForms.PanelTitle_Creativa panelReporte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private System.Windows.Forms.ComboBox cmbDatos;
        private LibControls.WinForms.Button_Creativa btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}