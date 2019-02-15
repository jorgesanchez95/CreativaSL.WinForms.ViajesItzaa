namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmFechasPago
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txtFolioSolicitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaLimPagoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLimPagoInicial = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle_Creativa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 341);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panelTitle_Creativa1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 256);
            this.panel3.TabIndex = 1;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoScroll = true;
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.txtFolioSolicitud);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.dtpFechaLimPagoFinal);
            this.panelTitle_Creativa1.Controls.Add(this.dtpFechaLimPagoInicial);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(864, 256);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 30;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "DATOS PARA CONFIRMAR VENTA";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txtFolioSolicitud
            // 
            this.txtFolioSolicitud.Location = new System.Drawing.Point(332, 68);
            this.txtFolioSolicitud.MaxLength = 30;
            this.txtFolioSolicitud.Name = "txtFolioSolicitud";
            this.txtFolioSolicitud.ReadOnly = true;
            this.txtFolioSolicitud.Size = new System.Drawing.Size(300, 24);
            this.txtFolioSolicitud.TabIndex = 29;
            this.txtFolioSolicitud.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Folio de Solicitud:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha Límite de Pago Final:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha Límite de Pago Inicial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaLimPagoFinal
            // 
            this.dtpFechaLimPagoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimPagoFinal.Location = new System.Drawing.Point(332, 183);
            this.dtpFechaLimPagoFinal.Name = "dtpFechaLimPagoFinal";
            this.dtpFechaLimPagoFinal.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaLimPagoFinal.TabIndex = 2;
            // 
            // dtpFechaLimPagoInicial
            // 
            this.dtpFechaLimPagoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimPagoInicial.Location = new System.Drawing.Point(332, 126);
            this.dtpFechaLimPagoInicial.Name = "dtpFechaLimPagoInicial";
            this.dtpFechaLimPagoInicial.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaLimPagoInicial.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelTitle_Creativa2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 85);
            this.panel2.TabIndex = 0;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.AutoScroll = true;
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa2.Controls.Add(this.btnRegresar);
            this.panelTitle_Creativa2.Controls.Add(this.btnGuardar);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.ShowTitle = false;
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(864, 85);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 20;
            this.panelTitle_Creativa2.TabIndex = 0;
            this.panelTitle_Creativa2.Title = "Título Panel";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(56, 7);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(553, 70);
            this.txt_mensaje.TabIndex = 35;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.Visible = false;
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
            this.btnRegresar.Location = new System.Drawing.Point(657, 10);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Cancelar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.TextDropShadow = true;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnGuardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FocusRectangle = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnGuardar.ImageFocused = null;
            this.btnGuardar.ImageInactive = null;
            this.btnGuardar.ImageMouseOver = null;
            this.btnGuardar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._19guardar;
            this.btnGuardar.ImagePressed = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGuardar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnGuardar.KeyButtonView = false;
            this.btnGuardar.Location = new System.Drawing.Point(757, 10);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 65);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFechasPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 341);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(880, 380);
            this.MinimumSize = new System.Drawing.Size(880, 380);
            this.Name = "frmFechasPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmFechasPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.panelTitle_Creativa2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.DateTimePicker dtpFechaLimPagoFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaLimPagoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioSolicitud;
    }
}