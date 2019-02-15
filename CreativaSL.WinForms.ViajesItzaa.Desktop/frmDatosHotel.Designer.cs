namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmDatosHotel
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.txtTotalHabitaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumMenores11 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumMenores4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumAdultos = new System.Windows.Forms.TextBox();
            this.txtTotalPersonas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaHotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnContinuar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(749, 558);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTitle_Creativa1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 473);
            this.panel3.TabIndex = 1;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoScroll = true;
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.dgvHabitaciones);
            this.panelTitle_Creativa1.Controls.Add(this.txtTotalHabitaciones);
            this.panelTitle_Creativa1.Controls.Add(this.label6);
            this.panelTitle_Creativa1.Controls.Add(this.txtNumMenores11);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.txtNumMenores4);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.txtNumAdultos);
            this.panelTitle_Creativa1.Controls.Add(this.txtTotalPersonas);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.cmbCategoriaHotel);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(749, 473);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 30;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "DATOS DEL HOTEL";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHabitaciones.Location = new System.Drawing.Point(126, 279);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(550, 176);
            this.dgvHabitaciones.TabIndex = 6;
            this.dgvHabitaciones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHabitaciones_CellValidating);
            // 
            // txtTotalHabitaciones
            // 
            this.txtTotalHabitaciones.Location = new System.Drawing.Point(607, 209);
            this.txtTotalHabitaciones.MaxLength = 4;
            this.txtTotalHabitaciones.Name = "txtTotalHabitaciones";
            this.txtTotalHabitaciones.Size = new System.Drawing.Size(100, 22);
            this.txtTotalHabitaciones.TabIndex = 5;
            this.txtTotalHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtTotalHabitaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalHabitaciones_KeyUp);
            this.txtTotalHabitaciones.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            this.txtTotalHabitaciones.Validated += new System.EventHandler(this.txtTotalHabitaciones_Validated);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total Habitaciones:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumMenores11
            // 
            this.txtNumMenores11.Location = new System.Drawing.Point(271, 146);
            this.txtNumMenores11.MaxLength = 4;
            this.txtNumMenores11.Name = "txtNumMenores11";
            this.txtNumMenores11.Size = new System.Drawing.Size(100, 22);
            this.txtNumMenores11.TabIndex = 4;
            this.txtNumMenores11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumMenores11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumMenores11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyUp);
            this.txtNumMenores11.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            this.txtNumMenores11.Validated += new System.EventHandler(this.txtNum_Validated);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Niño > 3 y < 10 años:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumMenores4
            // 
            this.txtNumMenores4.Location = new System.Drawing.Point(607, 118);
            this.txtNumMenores4.MaxLength = 4;
            this.txtNumMenores4.Name = "txtNumMenores4";
            this.txtNumMenores4.Size = new System.Drawing.Size(100, 22);
            this.txtNumMenores4.TabIndex = 3;
            this.txtNumMenores4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumMenores4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumMenores4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyUp);
            this.txtNumMenores4.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            this.txtNumMenores4.Validated += new System.EventHandler(this.txtNum_Validated);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Niño < 2 años:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumAdultos
            // 
            this.txtNumAdultos.Location = new System.Drawing.Point(271, 118);
            this.txtNumAdultos.MaxLength = 4;
            this.txtNumAdultos.Name = "txtNumAdultos";
            this.txtNumAdultos.Size = new System.Drawing.Size(100, 22);
            this.txtNumAdultos.TabIndex = 2;
            this.txtNumAdultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumAdultos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyUp);
            this.txtNumAdultos.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            this.txtNumAdultos.Validated += new System.EventHandler(this.txtNum_Validated);
            // 
            // txtTotalPersonas
            // 
            this.txtTotalPersonas.Location = new System.Drawing.Point(271, 207);
            this.txtTotalPersonas.Name = "txtTotalPersonas";
            this.txtTotalPersonas.ReadOnly = true;
            this.txtTotalPersonas.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPersonas.TabIndex = 24;
            this.txtTotalPersonas.TabStop = false;
            this.txtTotalPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adultos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Personas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategoriaHotel
            // 
            this.cmbCategoriaHotel.FormattingEnabled = true;
            this.cmbCategoriaHotel.Location = new System.Drawing.Point(271, 58);
            this.cmbCategoriaHotel.Name = "cmbCategoriaHotel";
            this.cmbCategoriaHotel.Size = new System.Drawing.Size(267, 24);
            this.cmbCategoriaHotel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categoría:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTitle_Creativa2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 85);
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
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(749, 85);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 20;
            this.panelTitle_Creativa2.TabIndex = 0;
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
            this.txt_mensaje.Size = new System.Drawing.Size(509, 70);
            this.txt_mensaje.TabIndex = 34;
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
            this.btnRegresar.Location = new System.Drawing.Point(546, 10);
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
            this.btnContinuar.Location = new System.Drawing.Point(646, 10);
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
            // frmDatosHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 558);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(765, 596);
            this.MinimumSize = new System.Drawing.Size(765, 596);
            this.Name = "frmDatosHotel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmDatosHotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.TextBox txtTotalHabitaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumMenores11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumMenores4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumAdultos;
        private System.Windows.Forms.TextBox txtTotalPersonas;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}