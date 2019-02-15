namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmCancelaciones
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
            this.panelCancelaciones = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
            this.lblMotivoCancelacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPenalizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolioSolicitud = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.bgwEnvioCorreo = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCancelaciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(634, 552);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panelCancelaciones);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 467);
            this.panel3.TabIndex = 1;
            // 
            // panelCancelaciones
            // 
            this.panelCancelaciones.AutoScroll = true;
            this.panelCancelaciones.BackColor = System.Drawing.Color.White;
            this.panelCancelaciones.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelCancelaciones.Controls.Add(this.txtMotivoCancelacion);
            this.panelCancelaciones.Controls.Add(this.lblMotivoCancelacion);
            this.panelCancelaciones.Controls.Add(this.label2);
            this.panelCancelaciones.Controls.Add(this.lblNota);
            this.panelCancelaciones.Controls.Add(this.label4);
            this.panelCancelaciones.Controls.Add(this.txtMontoPagado);
            this.panelCancelaciones.Controls.Add(this.label3);
            this.panelCancelaciones.Controls.Add(this.txtMontoPenalizacion);
            this.panelCancelaciones.Controls.Add(this.label1);
            this.panelCancelaciones.Controls.Add(this.txtFolioSolicitud);
            this.panelCancelaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCancelaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCancelaciones.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelCancelaciones.Location = new System.Drawing.Point(0, 0);
            this.panelCancelaciones.Name = "panelCancelaciones";
            this.panelCancelaciones.Size = new System.Drawing.Size(634, 467);
            this.panelCancelaciones.SizeLine = 0;
            this.panelCancelaciones.SizeTitle = 30;
            this.panelCancelaciones.TabIndex = 2;
            this.panelCancelaciones.Title = "CANCELAR SOLICITUD";
            this.panelCancelaciones.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(260, 180);
            this.txtMotivoCancelacion.MaxLength = 350;
            this.txtMotivoCancelacion.Multiline = true;
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(300, 130);
            this.txtMotivoCancelacion.TabIndex = 0;
            // 
            // lblMotivoCancelacion
            // 
            this.lblMotivoCancelacion.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelacion.Location = new System.Drawing.Point(60, 180);
            this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
            this.lblMotivoCancelacion.Size = new System.Drawing.Size(180, 24);
            this.lblMotivoCancelacion.TabIndex = 95;
            this.lblMotivoCancelacion.Text = "Motivo:";
            this.lblMotivoCancelacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 94;
            this.label2.Text = "NOTA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNota
            // 
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(260, 120);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(300, 40);
            this.lblNota.TabIndex = 93;
            this.lblNota.Text = "Al cancelar la solicitud, el registro ya no podrá ser modificado.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Monto Penalización:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPagado.Location = new System.Drawing.Point(260, 345);
            this.txtMontoPagado.MaxLength = 30;
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.ReadOnly = true;
            this.txtMontoPagado.Size = new System.Drawing.Size(150, 24);
            this.txtMontoPagado.TabIndex = 48;
            this.txtMontoPagado.TabStop = false;
            this.txtMontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Monto Pagado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontoPenalizacion
            // 
            this.txtMontoPenalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPenalizacion.Location = new System.Drawing.Point(260, 400);
            this.txtMontoPenalizacion.MaxLength = 30;
            this.txtMontoPenalizacion.Name = "txtMontoPenalizacion";
            this.txtMontoPenalizacion.ReadOnly = true;
            this.txtMontoPenalizacion.Size = new System.Drawing.Size(150, 24);
            this.txtMontoPenalizacion.TabIndex = 1;
            this.txtMontoPenalizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoPenalizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPenalizacion_KeyPress);
            this.txtMontoPenalizacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtMontoPenalizacion_Validating);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Folio de Solicitud:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolioSolicitud
            // 
            this.txtFolioSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioSolicitud.Location = new System.Drawing.Point(260, 60);
            this.txtFolioSolicitud.MaxLength = 30;
            this.txtFolioSolicitud.Name = "txtFolioSolicitud";
            this.txtFolioSolicitud.ReadOnly = true;
            this.txtFolioSolicitud.Size = new System.Drawing.Size(300, 24);
            this.txtFolioSolicitud.TabIndex = 44;
            this.txtFolioSolicitud.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelTitle_Creativa1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 85);
            this.panel2.TabIndex = 0;
            // 
            // panelTitle_Creativa1
            // 
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
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(634, 85);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 1;
            this.panelTitle_Creativa1.Title = "Título Panel";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(12, 8);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(431, 70);
            this.txt_mensaje.TabIndex = 38;
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
            this.btnRegresar.Location = new System.Drawing.Point(450, 10);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 3;
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
            this.btnGuardar.Location = new System.Drawing.Point(540, 10);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 65);
            this.btnGuardar.TabIndex = 2;
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
            // frmCancelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 552);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "frmCancelaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCancelaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCancelaciones.ResumeLayout(false);
            this.panelCancelaciones.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox txt_mensaje;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private LibControls.WinForms.PanelTitle_Creativa panelCancelaciones;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.Label lblMotivoCancelacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoPenalizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolioSolicitud;
        private System.ComponentModel.BackgroundWorker bgwEnvioCorreo;
    }
}