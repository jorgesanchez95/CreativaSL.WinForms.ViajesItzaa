namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmDatosTarjeta
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
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnAceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelDeposito = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtNumTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumAutorizacion = new System.Windows.Forms.TextBox();
            this.panel_Creativa1.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.White;
            this.panel_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panel_Creativa1.Controls.Add(this.txt_mensaje);
            this.panel_Creativa1.Controls.Add(this.btnAceptar);
            this.panel_Creativa1.Controls.Add(this.btnCancelar);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 326);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.ShowTitle = false;
            this.panel_Creativa1.Size = new System.Drawing.Size(684, 85);
            this.panel_Creativa1.SizeLine = 3;
            this.panel_Creativa1.SizeTitle = 20;
            this.panel_Creativa1.TabIndex = 1;
            this.panel_Creativa1.Title = "Título Panel";
            this.panel_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_mensaje.Location = new System.Drawing.Point(12, 6);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(461, 76);
            this.txt_mensaje.TabIndex = 30;
            this.txt_mensaje.TabStop = false;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.FocusRectangle = true;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAceptar.ImageFocused = null;
            this.btnAceptar.ImageInactive = null;
            this.btnAceptar.ImageMouseOver = null;
            this.btnAceptar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._19guardar;
            this.btnAceptar.ImagePressed = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnAceptar.KeyButtonView = false;
            this.btnAceptar.Location = new System.Drawing.Point(590, 10);
            this.btnAceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OffsetPressedContent = true;
            this.btnAceptar.Size = new System.Drawing.Size(75, 65);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.TextDropShadow = true;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = null;
            this.btnCancelar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._16regresar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(500, 10);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 65);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextDropShadow = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelDeposito
            // 
            this.panelDeposito.BackColor = System.Drawing.Color.White;
            this.panelDeposito.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelDeposito.Controls.Add(this.txtDNI);
            this.panelDeposito.Controls.Add(this.txtNumTarjeta);
            this.panelDeposito.Controls.Add(this.cmbDocumento);
            this.panelDeposito.Controls.Add(this.label6);
            this.panelDeposito.Controls.Add(this.label5);
            this.panelDeposito.Controls.Add(this.cmbBancos);
            this.panelDeposito.Controls.Add(this.label4);
            this.panelDeposito.Controls.Add(this.txtMonto);
            this.panelDeposito.Controls.Add(this.label3);
            this.panelDeposito.Controls.Add(this.label2);
            this.panelDeposito.Controls.Add(this.label1);
            this.panelDeposito.Controls.Add(this.txtNumAutorizacion);
            this.panelDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDeposito.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDeposito.Location = new System.Drawing.Point(0, 0);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(684, 326);
            this.panelDeposito.SizeLine = 3;
            this.panelDeposito.SizeTitle = 20;
            this.panelDeposito.TabIndex = 26;
            this.panelDeposito.Title = "Datos de la tarjeta de crédito/débito";
            this.panelDeposito.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(230, 127);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(286, 26);
            this.txtDNI.TabIndex = 2;
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Location = new System.Drawing.Point(230, 170);
            this.txtNumTarjeta.Mask = "0000-0000-0000-0000";
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(286, 26);
            this.txtNumTarjeta.TabIndex = 3;
            this.txtNumTarjeta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(230, 90);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(286, 28);
            this.cmbDocumento.TabIndex = 1;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbDocumento_SelectedIndexChanged);
            this.cmbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDocumento_KeyPress);
            this.cmbDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDocumento_Validating);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Identificación:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num. Tarjeta:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(230, 210);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(286, 28);
            this.cmbBancos.TabIndex = 4;
            this.cmbBancos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBancos_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(230, 250);
            this.txtMonto.MaxLength = 12;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(172, 27);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Text = "0.00";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Banco:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num. Autorización:";
            // 
            // txtNumAutorizacion
            // 
            this.txtNumAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAutorizacion.Location = new System.Drawing.Point(230, 50);
            this.txtNumAutorizacion.MaxLength = 30;
            this.txtNumAutorizacion.Name = "txtNumAutorizacion";
            this.txtNumAutorizacion.Size = new System.Drawing.Size(286, 27);
            this.txtNumAutorizacion.TabIndex = 0;
            this.txtNumAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAutorizacion_KeyPress);
            // 
            // frmDatosTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = true;
            this.Controls.Add(this.panelDeposito);
            this.Controls.Add(this.panel_Creativa1);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmDatosTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmDatosTarjeta_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panel_Creativa1.PerformLayout();
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private LibControls.WinForms.Button_Creativa btnAceptar;
        private LibControls.WinForms.PanelTitle_Creativa panelDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAutorizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNumTarjeta;
        private System.Windows.Forms.MaskedTextBox txtDNI;
    }
}