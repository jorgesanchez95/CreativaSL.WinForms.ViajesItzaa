namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmItinerario
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvItinerario = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnEliminarLugar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnNuevoLugar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnModificarLugar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa3 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnContinuar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelTitle_Creativa2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle_Creativa3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(634, 422);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 337);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panelTitle_Creativa1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 252);
            this.panel5.TabIndex = 1;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.panel7);
            this.panelTitle_Creativa1.Controls.Add(this.panel6);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(634, 252);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 30;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "Detalle del Itinerario";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.dgvItinerario);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(634, 219);
            this.panel7.TabIndex = 1;
            // 
            // dgvItinerario
            // 
            this.dgvItinerario.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvItinerario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItinerario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItinerario.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvItinerario.Location = new System.Drawing.Point(0, 0);
            this.dgvItinerario.Name = "dgvItinerario";
            this.dgvItinerario.Size = new System.Drawing.Size(634, 219);
            this.dgvItinerario.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(634, 33);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panelTitle_Creativa2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 85);
            this.panel4.TabIndex = 0;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.btnEliminarLugar);
            this.panelTitle_Creativa2.Controls.Add(this.btnNuevoLugar);
            this.panelTitle_Creativa2.Controls.Add(this.btnModificarLugar);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.ShowTitle = false;
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(634, 85);
            this.panelTitle_Creativa2.SizeLine = 0;
            this.panelTitle_Creativa2.SizeTitle = 0;
            this.panelTitle_Creativa2.TabIndex = 0;
            this.panelTitle_Creativa2.Title = "Título Panel";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarLugar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarLugar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarLugar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEliminarLugar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarLugar.FocusRectangle = true;
            this.btnEliminarLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEliminarLugar.Image = null;
            this.btnEliminarLugar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarLugar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEliminarLugar.ImageFocused = null;
            this.btnEliminarLugar.ImageInactive = null;
            this.btnEliminarLugar.ImageMouseOver = null;
            this.btnEliminarLugar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._7eliminar;
            this.btnEliminarLugar.ImagePressed = null;
            this.btnEliminarLugar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEliminarLugar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEliminarLugar.KeyButtonView = false;
            this.btnEliminarLugar.Location = new System.Drawing.Point(174, 12);
            this.btnEliminarLugar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminarLugar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.OffsetPressedContent = true;
            this.btnEliminarLugar.Size = new System.Drawing.Size(75, 65);
            this.btnEliminarLugar.TabIndex = 11;
            this.btnEliminarLugar.Text = "Eliminar";
            this.btnEliminarLugar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarLugar.TextDropShadow = true;
            this.btnEliminarLugar.UseVisualStyleBackColor = false;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // btnNuevoLugar
            // 
            this.btnNuevoLugar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevoLugar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevoLugar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevoLugar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnNuevoLugar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnNuevoLugar.FocusRectangle = true;
            this.btnNuevoLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNuevoLugar.Image = null;
            this.btnNuevoLugar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoLugar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnNuevoLugar.ImageFocused = null;
            this.btnNuevoLugar.ImageInactive = null;
            this.btnNuevoLugar.ImageMouseOver = null;
            this.btnNuevoLugar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._4agregar;
            this.btnNuevoLugar.ImagePressed = null;
            this.btnNuevoLugar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNuevoLugar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnNuevoLugar.KeyButtonView = false;
            this.btnNuevoLugar.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoLugar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevoLugar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevoLugar.Name = "btnNuevoLugar";
            this.btnNuevoLugar.OffsetPressedContent = true;
            this.btnNuevoLugar.Size = new System.Drawing.Size(75, 65);
            this.btnNuevoLugar.TabIndex = 9;
            this.btnNuevoLugar.Text = "Agregar";
            this.btnNuevoLugar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoLugar.TextDropShadow = true;
            this.btnNuevoLugar.UseVisualStyleBackColor = false;
            this.btnNuevoLugar.Click += new System.EventHandler(this.btnNuevoLugar_Click);
            // 
            // btnModificarLugar
            // 
            this.btnModificarLugar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarLugar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarLugar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarLugar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnModificarLugar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnModificarLugar.FocusRectangle = true;
            this.btnModificarLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnModificarLugar.Image = null;
            this.btnModificarLugar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarLugar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnModificarLugar.ImageFocused = null;
            this.btnModificarLugar.ImageInactive = null;
            this.btnModificarLugar.ImageMouseOver = null;
            this.btnModificarLugar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._31modificar;
            this.btnModificarLugar.ImagePressed = null;
            this.btnModificarLugar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnModificarLugar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnModificarLugar.KeyButtonView = false;
            this.btnModificarLugar.Location = new System.Drawing.Point(93, 12);
            this.btnModificarLugar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnModificarLugar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnModificarLugar.Name = "btnModificarLugar";
            this.btnModificarLugar.OffsetPressedContent = true;
            this.btnModificarLugar.Size = new System.Drawing.Size(75, 65);
            this.btnModificarLugar.TabIndex = 10;
            this.btnModificarLugar.Text = "Modificar";
            this.btnModificarLugar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarLugar.TextDropShadow = true;
            this.btnModificarLugar.UseVisualStyleBackColor = false;
            this.btnModificarLugar.Click += new System.EventHandler(this.btnModificarLugar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panelTitle_Creativa3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 85);
            this.panel2.TabIndex = 0;
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
            this.panelTitle_Creativa3.ShowTitle = false;
            this.panelTitle_Creativa3.Size = new System.Drawing.Size(634, 85);
            this.panelTitle_Creativa3.SizeLine = 0;
            this.panelTitle_Creativa3.SizeTitle = 0;
            this.panelTitle_Creativa3.TabIndex = 0;
            this.panelTitle_Creativa3.Title = "";
            this.panelTitle_Creativa3.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(33, 8);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(372, 70);
            this.txt_mensaje.TabIndex = 33;
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
            this.btnRegresar.Location = new System.Drawing.Point(442, 8);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(75, 65);
            this.btnRegresar.TabIndex = 7;
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
            this.btnContinuar.Location = new System.Drawing.Point(523, 8);
            this.btnContinuar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnContinuar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.OffsetPressedContent = true;
            this.btnContinuar.Size = new System.Drawing.Size(75, 65);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContinuar.TextDropShadow = true;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmItinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 422);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.Name = "frmItinerario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmItinerario_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitle_Creativa3.ResumeLayout(false);
            this.panelTitle_Creativa3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvItinerario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa3;
        private LibControls.WinForms.Button_Creativa btnEliminarLugar;
        private LibControls.WinForms.Button_Creativa btnNuevoLugar;
        private LibControls.WinForms.Button_Creativa btnModificarLugar;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private LibControls.WinForms.Button_Creativa btnContinuar;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}