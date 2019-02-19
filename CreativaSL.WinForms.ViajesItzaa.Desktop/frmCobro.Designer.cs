namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmCobro
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
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.chkPagoPaypal = new System.Windows.Forms.CheckBox();
            this.chkTransferencia = new System.Windows.Forms.CheckBox();
            this.txtPagoTransfrencia = new System.Windows.Forms.TextBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.txtPagoTarjeta = new System.Windows.Forms.TextBox();
            this.txtPagoPaypal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPagoEfectivo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.bgwEnvioCorreo = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle_Creativa2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 711);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTitle_Creativa2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 626);
            this.panel3.TabIndex = 1;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.AutoScroll = true;
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.chkPagoPaypal);
            this.panelTitle_Creativa2.Controls.Add(this.chkTransferencia);
            this.panelTitle_Creativa2.Controls.Add(this.txtPagoTransfrencia);
            this.panelTitle_Creativa2.Controls.Add(this.chkTarjeta);
            this.panelTitle_Creativa2.Controls.Add(this.txtPagoTarjeta);
            this.panelTitle_Creativa2.Controls.Add(this.txtPagoPaypal);
            this.panelTitle_Creativa2.Controls.Add(this.label3);
            this.panelTitle_Creativa2.Controls.Add(this.txtMontoAPagar);
            this.panelTitle_Creativa2.Controls.Add(this.label2);
            this.panelTitle_Creativa2.Controls.Add(this.txtCambio);
            this.panelTitle_Creativa2.Controls.Add(this.label1);
            this.panelTitle_Creativa2.Controls.Add(this.txtPagoEfectivo);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(884, 626);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 30;
            this.panelTitle_Creativa2.TabIndex = 0;
            this.panelTitle_Creativa2.Title = "DATOS DEL COBRO";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // chkPagoPaypal
            // 
            this.chkPagoPaypal.BackColor = System.Drawing.Color.Transparent;
            this.chkPagoPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.chkPagoPaypal.ForeColor = System.Drawing.Color.Navy;
            this.chkPagoPaypal.Location = new System.Drawing.Point(483, 235);
            this.chkPagoPaypal.Name = "chkPagoPaypal";
            this.chkPagoPaypal.Size = new System.Drawing.Size(360, 45);
            this.chkPagoPaypal.TabIndex = 2;
            this.chkPagoPaypal.Text = "Pago PayPal";
            this.chkPagoPaypal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPagoPaypal.UseVisualStyleBackColor = false;
            this.chkPagoPaypal.CheckedChanged += new System.EventHandler(this.chkPagoPaypal_CheckedChanged);
            // 
            // chkTransferencia
            // 
            this.chkTransferencia.BackColor = System.Drawing.Color.Transparent;
            this.chkTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.chkTransferencia.ForeColor = System.Drawing.Color.Navy;
            this.chkTransferencia.Location = new System.Drawing.Point(483, 365);
            this.chkTransferencia.Name = "chkTransferencia";
            this.chkTransferencia.Size = new System.Drawing.Size(360, 45);
            this.chkTransferencia.TabIndex = 4;
            this.chkTransferencia.Text = "Pago Transf / Dep";
            this.chkTransferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTransferencia.UseVisualStyleBackColor = false;
            this.chkTransferencia.CheckedChanged += new System.EventHandler(this.chkTransferencia_CheckedChanged);
            // 
            // txtPagoTransfrencia
            // 
            this.txtPagoTransfrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoTransfrencia.Location = new System.Drawing.Point(483, 410);
            this.txtPagoTransfrencia.MaxLength = 10;
            this.txtPagoTransfrencia.Name = "txtPagoTransfrencia";
            this.txtPagoTransfrencia.ReadOnly = true;
            this.txtPagoTransfrencia.Size = new System.Drawing.Size(360, 74);
            this.txtPagoTransfrencia.TabIndex = 150;
            this.txtPagoTransfrencia.TabStop = false;
            this.txtPagoTransfrencia.Tag = "5";
            this.txtPagoTransfrencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.chkTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.chkTarjeta.ForeColor = System.Drawing.Color.Navy;
            this.chkTarjeta.Location = new System.Drawing.Point(41, 365);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(360, 45);
            this.chkTarjeta.TabIndex = 3;
            this.chkTarjeta.Text = "Pago Tarjeta";
            this.chkTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTarjeta.UseVisualStyleBackColor = false;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.chkTarjeta_CheckedChanged);
            // 
            // txtPagoTarjeta
            // 
            this.txtPagoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoTarjeta.Location = new System.Drawing.Point(41, 410);
            this.txtPagoTarjeta.MaxLength = 10;
            this.txtPagoTarjeta.Name = "txtPagoTarjeta";
            this.txtPagoTarjeta.ReadOnly = true;
            this.txtPagoTarjeta.Size = new System.Drawing.Size(360, 74);
            this.txtPagoTarjeta.TabIndex = 148;
            this.txtPagoTarjeta.TabStop = false;
            this.txtPagoTarjeta.Tag = "6";
            this.txtPagoTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPagoPaypal
            // 
            this.txtPagoPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoPaypal.Location = new System.Drawing.Point(483, 280);
            this.txtPagoPaypal.MaxLength = 10;
            this.txtPagoPaypal.Name = "txtPagoPaypal";
            this.txtPagoPaypal.ReadOnly = true;
            this.txtPagoPaypal.Size = new System.Drawing.Size(360, 74);
            this.txtPagoPaypal.TabIndex = 147;
            this.txtPagoPaypal.TabStop = false;
            this.txtPagoPaypal.Tag = "2";
            this.txtPagoPaypal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(290, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 45);
            this.label3.TabIndex = 145;
            this.label3.Text = "Pagar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtMontoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAPagar.Location = new System.Drawing.Point(290, 120);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.ReadOnly = true;
            this.txtMontoAPagar.Size = new System.Drawing.Size(320, 74);
            this.txtMontoAPagar.TabIndex = 144;
            this.txtMontoAPagar.TabStop = false;
            this.txtMontoAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(290, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 40);
            this.label2.TabIndex = 143;
            this.label2.Text = "Cambio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.OrangeRed;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(290, 540);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(320, 74);
            this.txtCambio.TabIndex = 141;
            this.txtCambio.TabStop = false;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(41, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 142;
            this.label1.Tag = "1";
            this.label1.Text = "Pago Efectivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPagoEfectivo
            // 
            this.txtPagoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoEfectivo.Location = new System.Drawing.Point(41, 280);
            this.txtPagoEfectivo.MaxLength = 10;
            this.txtPagoEfectivo.Name = "txtPagoEfectivo";
            this.txtPagoEfectivo.Size = new System.Drawing.Size(360, 74);
            this.txtPagoEfectivo.TabIndex = 1;
            this.txtPagoEfectivo.Tag = "1";
            this.txtPagoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPagoEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoEfectivo_KeyPress);
            this.txtPagoEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPagoEfectivo_KeyUp);
            this.txtPagoEfectivo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPagoEfectivo_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTitle_Creativa1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 85);
            this.panel2.TabIndex = 0;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoScroll = true;
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa1.Controls.Add(this.btnRegresar);
            this.panelTitle_Creativa1.Controls.Add(this.btnGuardar);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.ShowTitle = false;
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(884, 85);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "Título Panel";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(27, 7);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(540, 70);
            this.txt_mensaje.TabIndex = 41;
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
            this.btnRegresar.Location = new System.Drawing.Point(679, 9);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 6;
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
            this.btnGuardar.Location = new System.Drawing.Point(764, 9);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 65);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bgwEnvioCorreo
            // 
            this.bgwEnvioCorreo.WorkerReportsProgress = true;
            this.bgwEnvioCorreo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEnvioCorreo_DoWork);
            this.bgwEnvioCorreo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwEnvioCorreo_ProgressChanged);
            this.bgwEnvioCorreo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEnvioCorreo_RunWorkerCompleted);
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 750);
            this.MinimumSize = new System.Drawing.Size(900, 736);
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCobro_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.panelTitle_Creativa2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox txt_mensaje;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private System.Windows.Forms.CheckBox chkTransferencia;
        private System.Windows.Forms.TextBox txtPagoTransfrencia;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.TextBox txtPagoTarjeta;
        private System.Windows.Forms.TextBox txtPagoPaypal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagoEfectivo;
        private System.Windows.Forms.CheckBox chkPagoPaypal;
        private System.ComponentModel.BackgroundWorker bgwEnvioCorreo;
    }
}