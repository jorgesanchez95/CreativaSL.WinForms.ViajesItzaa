namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmCambiarPasswordCliente
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
            this.panelDatos = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelBotones = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnAceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelBotones.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(584, 246);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panelDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 161);
            this.panel3.TabIndex = 1;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.White;
            this.panelDatos.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.txtPassword);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Controls.Add(this.lblNombre);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDatos.Location = new System.Drawing.Point(0, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(584, 161);
            this.panelDatos.SizeLine = 3;
            this.panelDatos.SizeTitle = 20;
            this.panelDatos.TabIndex = 12;
            this.panelDatos.Title = "CAMBIAR PASSWORD";
            this.panelDatos.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 12148;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(170, 109);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(206, 24);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 50);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(300, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 22);
            this.lblNombre.TabIndex = 102;
            this.lblNombre.Text = "Cliente:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PanelBotones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 85);
            this.panel2.TabIndex = 0;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.White;
            this.PanelBotones.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.PanelBotones.Controls.Add(this.btnAceptar);
            this.PanelBotones.Controls.Add(this.btnCancelar);
            this.PanelBotones.Controls.Add(this.txt_mensaje);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.ShowTitle = false;
            this.PanelBotones.Size = new System.Drawing.Size(584, 85);
            this.PanelBotones.SizeLine = 0;
            this.PanelBotones.SizeTitle = 20;
            this.PanelBotones.TabIndex = 96;
            this.PanelBotones.Title = "Título Panel";
            this.PanelBotones.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.FocusRectangle = true;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            this.btnAceptar.Location = new System.Drawing.Point(19, 10);
            this.btnAceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OffsetPressedContent = true;
            this.btnAceptar.Size = new System.Drawing.Size(75, 65);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            this.btnCancelar.Location = new System.Drawing.Point(100, 10);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 65);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextDropShadow = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(198, 10);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(367, 65);
            this.txt_mensaje.TabIndex = 12132;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.Visible = false;
            // 
            // frmCambiarPasswordCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 246);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 285);
            this.Name = "frmCambiarPasswordCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCambiarPasswordCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.PanelBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private LibControls.WinForms.PanelTitle_Creativa panelDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa PanelBotones;
        private LibControls.WinForms.Button_Creativa btnAceptar;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private System.Windows.Forms.TextBox txt_mensaje;

    }
}