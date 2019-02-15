namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmNotasSolicitud
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
            this.PanelMenu = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnRegresar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEliminarNota = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnModificarNota = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnNuevaNota = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.dgv_Notas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.PanelMenu.Controls.Add(this.btnRegresar);
            this.PanelMenu.Controls.Add(this.btnEliminarNota);
            this.PanelMenu.Controls.Add(this.btnModificarNota);
            this.PanelMenu.Controls.Add(this.btnNuevaNota);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1264, 79);
            this.PanelMenu.SizeLine = 0;
            this.PanelMenu.SizeTitle = 0;
            this.PanelMenu.TabIndex = 15;
            this.PanelMenu.Title = "";
            this.PanelMenu.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegresar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegresar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegresar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRegresar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRegresar.FocusRectangle = true;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = null;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegresar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRegresar.ImageFocused = null;
            this.btnRegresar.ImageInactive = null;
            this.btnRegresar.ImageMouseOver = null;
            this.btnRegresar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._16regresar;
            this.btnRegresar.ImagePressed = null;
            this.btnRegresar.ImageSize = new System.Drawing.Size(50, 50);
            this.btnRegresar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRegresar.KeyButtonView = false;
            this.btnRegresar.Location = new System.Drawing.Point(270, 2);
            this.btnRegresar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRegresar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OffsetPressedContent = true;
            this.btnRegresar.Size = new System.Drawing.Size(88, 74);
            this.btnRegresar.TabIndex = 30;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.TextDropShadow = true;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarNota.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarNota.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarNota.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEliminarNota.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarNota.FocusRectangle = true;
            this.btnEliminarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNota.Image = null;
            this.btnEliminarNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarNota.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEliminarNota.ImageFocused = null;
            this.btnEliminarNota.ImageInactive = null;
            this.btnEliminarNota.ImageMouseOver = null;
            this.btnEliminarNota.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._7eliminar;
            this.btnEliminarNota.ImagePressed = null;
            this.btnEliminarNota.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEliminarNota.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEliminarNota.KeyButtonView = false;
            this.btnEliminarNota.Location = new System.Drawing.Point(180, 2);
            this.btnEliminarNota.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminarNota.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.OffsetPressedContent = true;
            this.btnEliminarNota.Size = new System.Drawing.Size(88, 74);
            this.btnEliminarNota.TabIndex = 29;
            this.btnEliminarNota.Text = "Eliminar";
            this.btnEliminarNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarNota.TextDropShadow = true;
            this.btnEliminarNota.UseVisualStyleBackColor = false;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarNota.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarNota.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarNota.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnModificarNota.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnModificarNota.FocusRectangle = true;
            this.btnModificarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarNota.Image = null;
            this.btnModificarNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarNota.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnModificarNota.ImageFocused = null;
            this.btnModificarNota.ImageInactive = null;
            this.btnModificarNota.ImageMouseOver = null;
            this.btnModificarNota.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._31modificar;
            this.btnModificarNota.ImagePressed = null;
            this.btnModificarNota.ImageSize = new System.Drawing.Size(50, 50);
            this.btnModificarNota.KeyButton = System.Windows.Forms.Keys.None;
            this.btnModificarNota.KeyButtonView = false;
            this.btnModificarNota.Location = new System.Drawing.Point(90, 2);
            this.btnModificarNota.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnModificarNota.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.OffsetPressedContent = true;
            this.btnModificarNota.Size = new System.Drawing.Size(88, 74);
            this.btnModificarNota.TabIndex = 15;
            this.btnModificarNota.Text = "Modificar";
            this.btnModificarNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarNota.TextDropShadow = true;
            this.btnModificarNota.UseVisualStyleBackColor = false;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnNuevaNota
            // 
            this.btnNuevaNota.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevaNota.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaNota.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaNota.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnNuevaNota.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnNuevaNota.FocusRectangle = true;
            this.btnNuevaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaNota.Image = null;
            this.btnNuevaNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaNota.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnNuevaNota.ImageFocused = null;
            this.btnNuevaNota.ImageInactive = null;
            this.btnNuevaNota.ImageMouseOver = null;
            this.btnNuevaNota.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._30apartado;
            this.btnNuevaNota.ImagePressed = null;
            this.btnNuevaNota.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNuevaNota.KeyButton = System.Windows.Forms.Keys.None;
            this.btnNuevaNota.KeyButtonView = false;
            this.btnNuevaNota.Location = new System.Drawing.Point(3, 2);
            this.btnNuevaNota.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevaNota.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevaNota.Name = "btnNuevaNota";
            this.btnNuevaNota.OffsetPressedContent = true;
            this.btnNuevaNota.Size = new System.Drawing.Size(85, 74);
            this.btnNuevaNota.TabIndex = 1;
            this.btnNuevaNota.Text = "Nuevo";
            this.btnNuevaNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaNota.TextDropShadow = true;
            this.btnNuevaNota.UseVisualStyleBackColor = false;
            this.btnNuevaNota.Click += new System.EventHandler(this.btnNuevaNota_Click);
            // 
            // dgv_Notas
            // 
            this.dgv_Notas.AllowUserToAddRows = false;
            this.dgv_Notas.AllowUserToDeleteRows = false;
            this.dgv_Notas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Notas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_Notas.Location = new System.Drawing.Point(0, 0);
            this.dgv_Notas.MultiSelect = false;
            this.dgv_Notas.Name = "dgv_Notas";
            this.dgv_Notas.ReadOnly = true;
            this.dgv_Notas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Notas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Notas.Size = new System.Drawing.Size(1264, 651);
            this.dgv_Notas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 730);
            this.panel1.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Notas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 651);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 79);
            this.panel2.TabIndex = 0;
            // 
            // frmNotasSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.ControlBox = true;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = true;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 766);
            this.Name = "frmNotasSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.frmNotasSolicitud_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CreativaSL.LibControls.WinForms.PanelTitle_Creativa PanelMenu;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnModificarNota;
        private CreativaSL.LibControls.WinForms.Button_Creativa btnNuevaNota;
        private System.Windows.Forms.DataGridView dgv_Notas;
        private LibControls.WinForms.Button_Creativa btnEliminarNota;
        private LibControls.WinForms.Button_Creativa btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}