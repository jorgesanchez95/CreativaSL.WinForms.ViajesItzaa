namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmElegirProducto
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
            this.panelObservaciones = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa3 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnContinuar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelProductoPrincipal = new System.Windows.Forms.Panel();
            this.panelProducto = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelObservaciones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle_Creativa3.SuspendLayout();
            this.panelProductoPrincipal.SuspendLayout();
            this.panelProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelObservaciones);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelProductoPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 421);
            this.panel1.TabIndex = 0;
            // 
            // panelObservaciones
            // 
            this.panelObservaciones.BackColor = System.Drawing.Color.White;
            this.panelObservaciones.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelObservaciones.Controls.Add(this.txtObservaciones);
            this.panelObservaciones.Controls.Add(this.label1);
            this.panelObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelObservaciones.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelObservaciones.Location = new System.Drawing.Point(0, 100);
            this.panelObservaciones.Name = "panelObservaciones";
            this.panelObservaciones.Size = new System.Drawing.Size(634, 236);
            this.panelObservaciones.SizeLine = 3;
            this.panelObservaciones.SizeTitle = 30;
            this.panelObservaciones.TabIndex = 1;
            this.panelObservaciones.Title = "OBSERVACIONES";
            this.panelObservaciones.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(220, 50);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(350, 150);
            this.txtObservaciones.TabIndex = 1;
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Observaciones:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTitle_Creativa3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 85);
            this.panel3.TabIndex = 1;
            // 
            // panelTitle_Creativa3
            // 
            this.panelTitle_Creativa3.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa3.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa3.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa3.Controls.Add(this.btnRegresar);
            this.panelTitle_Creativa3.Controls.Add(this.btnContinuar);
            this.panelTitle_Creativa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa3.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa3.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa3.Name = "panelTitle_Creativa3";
            this.panelTitle_Creativa3.Size = new System.Drawing.Size(634, 85);
            this.panelTitle_Creativa3.SizeLine = 3;
            this.panelTitle_Creativa3.SizeTitle = 0;
            this.panelTitle_Creativa3.TabIndex = 2;
            this.panelTitle_Creativa3.Title = "";
            this.panelTitle_Creativa3.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(34, 6);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(372, 70);
            this.txt_mensaje.TabIndex = 32;
            this.txt_mensaje.TabStop = false;
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
            this.btnRegresar.Location = new System.Drawing.Point(430, 10);
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
            this.btnContinuar.Location = new System.Drawing.Point(530, 10);
            this.btnContinuar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnContinuar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.OffsetPressedContent = true;
            this.btnContinuar.Size = new System.Drawing.Size(75, 65);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContinuar.TextDropShadow = true;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // panelProductoPrincipal
            // 
            this.panelProductoPrincipal.Controls.Add(this.panelProducto);
            this.panelProductoPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelProductoPrincipal.Name = "panelProductoPrincipal";
            this.panelProductoPrincipal.Size = new System.Drawing.Size(634, 100);
            this.panelProductoPrincipal.TabIndex = 0;
            // 
            // panelProducto
            // 
            this.panelProducto.BackColor = System.Drawing.Color.White;
            this.panelProducto.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelProducto.Controls.Add(this.lblProducto);
            this.panelProducto.Controls.Add(this.cmbProducto);
            this.panelProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelProducto.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelProducto.Location = new System.Drawing.Point(0, 0);
            this.panelProducto.Name = "panelProducto";
            this.panelProducto.Size = new System.Drawing.Size(634, 100);
            this.panelProducto.SizeLine = 3;
            this.panelProducto.SizeTitle = 30;
            this.panelProducto.TabIndex = 0;
            this.panelProducto.Title = "SELECCIONE UN PRODUCTO";
            this.panelProducto.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // lblProducto
            // 
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(47, 50);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(167, 24);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Cliente:";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(220, 50);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(350, 24);
            this.cmbProducto.TabIndex = 0;
            // 
            // frmElegirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(650, 460);
            this.MinimumSize = new System.Drawing.Size(650, 460);
            this.Name = "frmElegirProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmElegirProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panelObservaciones.ResumeLayout(false);
            this.panelObservaciones.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelTitle_Creativa3.ResumeLayout(false);
            this.panelTitle_Creativa3.PerformLayout();
            this.panelProductoPrincipal.ResumeLayout(false);
            this.panelProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelProductoPrincipal;
        private LibControls.WinForms.PanelTitle_Creativa panelObservaciones;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa3;
        private LibControls.WinForms.PanelTitle_Creativa panelProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private LibControls.WinForms.Button_Creativa btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}