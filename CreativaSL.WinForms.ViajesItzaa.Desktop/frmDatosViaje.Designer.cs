namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmDatosViaje
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
            this.panelBoletos = new System.Windows.Forms.Panel();
            this.txtAeropuertoSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAeropuertoLlegada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnContinuar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panelBoletos.SuspendLayout();
            this.panelFechas.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(634, 421);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTitle_Creativa1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 336);
            this.panel3.TabIndex = 1;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.panelBoletos);
            this.panelTitle_Creativa1.Controls.Add(this.panelFechas);
            this.panelTitle_Creativa1.Controls.Add(this.panel4);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(634, 336);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 30;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "DATOS DEL VIAJE";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panelBoletos
            // 
            this.panelBoletos.BackColor = System.Drawing.Color.Transparent;
            this.panelBoletos.Controls.Add(this.txtAeropuertoSalida);
            this.panelBoletos.Controls.Add(this.label3);
            this.panelBoletos.Controls.Add(this.txtAeropuertoLlegada);
            this.panelBoletos.Controls.Add(this.label2);
            this.panelBoletos.Controls.Add(this.rbNo);
            this.panelBoletos.Controls.Add(this.rbSi);
            this.panelBoletos.Controls.Add(this.label1);
            this.panelBoletos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoletos.Location = new System.Drawing.Point(0, 33);
            this.panelBoletos.Name = "panelBoletos";
            this.panelBoletos.Size = new System.Drawing.Size(634, 179);
            this.panelBoletos.TabIndex = 1;
            // 
            // txtAeropuertoSalida
            // 
            this.txtAeropuertoSalida.Location = new System.Drawing.Point(260, 122);
            this.txtAeropuertoSalida.MaxLength = 70;
            this.txtAeropuertoSalida.Name = "txtAeropuertoSalida";
            this.txtAeropuertoSalida.Size = new System.Drawing.Size(300, 22);
            this.txtAeropuertoSalida.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Aeropuerto Salida:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAeropuertoLlegada
            // 
            this.txtAeropuertoLlegada.Location = new System.Drawing.Point(260, 82);
            this.txtAeropuertoLlegada.MaxLength = 70;
            this.txtAeropuertoLlegada.Name = "txtAeropuertoLlegada";
            this.txtAeropuertoLlegada.Size = new System.Drawing.Size(300, 22);
            this.txtAeropuertoLlegada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Aeropuerto Llegada:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbNo
            // 
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Location = new System.Drawing.Point(360, 28);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(85, 24);
            this.rbNo.TabIndex = 2;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbSi
            // 
            this.rbSi.BackColor = System.Drawing.Color.Transparent;
            this.rbSi.Location = new System.Drawing.Point(260, 28);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(85, 24);
            this.rbSi.TabIndex = 1;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "¿Tiene Boleto de Avión?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.Color.Transparent;
            this.panelFechas.Controls.Add(this.dtpHoraSalida);
            this.panelFechas.Controls.Add(this.label6);
            this.panelFechas.Controls.Add(this.dtpFechaSalida);
            this.panelFechas.Controls.Add(this.label7);
            this.panelFechas.Controls.Add(this.dtpHoraLlegada);
            this.panelFechas.Controls.Add(this.label5);
            this.panelFechas.Controls.Add(this.dtpFechaLlegada);
            this.panelFechas.Controls.Add(this.label4);
            this.panelFechas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFechas.Location = new System.Drawing.Point(0, 212);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(634, 124);
            this.panelFechas.TabIndex = 2;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(480, 70);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(76, 22);
            this.dtpHoraSalida.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Hora Salida:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(200, 70);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(116, 22);
            this.dtpFechaSalida.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha Salida:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.CustomFormat = "HH:mm";
            this.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraLlegada.Location = new System.Drawing.Point(480, 30);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.ShowUpDown = true;
            this.dtpHoraLlegada.Size = new System.Drawing.Size(76, 22);
            this.dtpHoraLlegada.TabIndex = 6;
            this.dtpHoraLlegada.ValueChanged += new System.EventHandler(this.dtpHoraLlegada_ValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hora Llegada:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(200, 29);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(116, 22);
            this.dtpFechaLlegada.TabIndex = 5;
            this.dtpFechaLlegada.ValueChanged += new System.EventHandler(this.dtpFechaLlegada_ValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha Llegada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 33);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTitle_Creativa2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 85);
            this.panel2.TabIndex = 0;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa2.Controls.Add(this.btnRegresar);
            this.panelTitle_Creativa2.Controls.Add(this.btnContinuar);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.ShowTitle = false;
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(634, 85);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 20;
            this.panelTitle_Creativa2.TabIndex = 3;
            this.panelTitle_Creativa2.Title = "";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(12, 10);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(372, 70);
            this.txt_mensaje.TabIndex = 33;
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
            this.btnRegresar.Location = new System.Drawing.Point(400, 10);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Cancelar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.TextDropShadow = true;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnContinuar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContinuar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContinuar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnContinuar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnContinuar.FocusRectangle = true;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnContinuar.Image = null;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContinuar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnContinuar.ImageFocused = null;
            this.btnContinuar.ImageInactive = null;
            this.btnContinuar.ImageMouseOver = null;
            this.btnContinuar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._14continuar;
            this.btnContinuar.ImagePressed = null;
            this.btnContinuar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnContinuar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnContinuar.KeyButtonView = false;
            this.btnContinuar.Location = new System.Drawing.Point(500, 10);
            this.btnContinuar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnContinuar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.OffsetPressedContent = true;
            this.btnContinuar.Size = new System.Drawing.Size(75, 65);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContinuar.TextDropShadow = true;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmDatosViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(650, 460);
            this.MinimumSize = new System.Drawing.Size(650, 460);
            this.Name = "frmDatosViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmDatosViaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelBoletos.ResumeLayout(false);
            this.panelBoletos.PerformLayout();
            this.panelFechas.ResumeLayout(false);
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
        private LibControls.WinForms.Button_Creativa btnContinuar;
        private System.Windows.Forms.Panel panelBoletos;
        private System.Windows.Forms.TextBox txtAeropuertoSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAeropuertoLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFechas;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}