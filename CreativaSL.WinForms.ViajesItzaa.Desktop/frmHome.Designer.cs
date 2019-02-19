namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.dgvSolicitudesPendientes = new System.Windows.Forms.DataGridView();
            this.panelLateralDerecho = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExtra = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnActualizar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnDetalles = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnAceptarSolicitud = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelFechaHora = new System.Windows.Forms.Panel();
            this.panelFechaHoraCSL = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHor_Actual = new System.Windows.Forms.TextBox();
            this.txtFec_Actual = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuCSL = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnVerTodos = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEmpresas = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnReportes = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCaja = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnClientes = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnMisSolicitudes = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.MenuStripCaja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsm_caja_cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsm_caja_retiros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsm_caja_depositos = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroCajaLlenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripReportes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRecursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSolicitudesRecibidas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSolicitudesTramite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSolicitudesCanceladas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPaquetesVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSolicitudesXEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).BeginInit();
            this.panelLateralDerecho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExtra.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panelFechaHora.SuspendLayout();
            this.panelFechaHoraCSL.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMenuCSL.SuspendLayout();
            this.MenuStripCaja.SuspendLayout();
            this.MenuStripReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelCentral);
            this.panelGeneral.Controls.Add(this.panelLateralDerecho);
            this.panelGeneral.Controls.Add(this.panelMenu);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1264, 730);
            this.panelGeneral.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.dgvSolicitudesPendientes);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 100);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1007, 630);
            this.panelCentral.TabIndex = 2;
            // 
            // dgvSolicitudesPendientes
            // 
            this.dgvSolicitudesPendientes.AllowUserToAddRows = false;
            this.dgvSolicitudesPendientes.AllowUserToDeleteRows = false;
            this.dgvSolicitudesPendientes.AllowUserToResizeColumns = false;
            this.dgvSolicitudesPendientes.AllowUserToResizeRows = false;
            this.dgvSolicitudesPendientes.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudesPendientes.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSolicitudesPendientes.Location = new System.Drawing.Point(0, 0);
            this.dgvSolicitudesPendientes.Name = "dgvSolicitudesPendientes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudesPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudesPendientes.Size = new System.Drawing.Size(1007, 630);
            this.dgvSolicitudesPendientes.TabIndex = 0;
            // 
            // panelLateralDerecho
            // 
            this.panelLateralDerecho.Controls.Add(this.panel2);
            this.panelLateralDerecho.Controls.Add(this.panelBotones);
            this.panelLateralDerecho.Controls.Add(this.panelFechaHora);
            this.panelLateralDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateralDerecho.Location = new System.Drawing.Point(1007, 100);
            this.panelLateralDerecho.Name = "panelLateralDerecho";
            this.panelLateralDerecho.Size = new System.Drawing.Size(257, 630);
            this.panelLateralDerecho.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelExtra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 453);
            this.panel2.TabIndex = 2;
            // 
            // panelExtra
            // 
            this.panelExtra.Controls.Add(this.panelTitle_Creativa2);
            this.panelExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExtra.Location = new System.Drawing.Point(0, 0);
            this.panelExtra.Name = "panelExtra";
            this.panelExtra.Size = new System.Drawing.Size(257, 453);
            this.panelExtra.TabIndex = 0;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.AutoScroll = true;
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(257, 453);
            this.panelTitle_Creativa2.SizeLine = 2;
            this.panelTitle_Creativa2.SizeTitle = 0;
            this.panelTitle_Creativa2.TabIndex = 1;
            this.panelTitle_Creativa2.Title = "";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.panelTitle_Creativa1);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 453);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(257, 100);
            this.panelBotones.TabIndex = 1;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoScroll = true;
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.btnActualizar);
            this.panelTitle_Creativa1.Controls.Add(this.btnDetalles);
            this.panelTitle_Creativa1.Controls.Add(this.btnAceptarSolicitud);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(257, 100);
            this.panelTitle_Creativa1.SizeLine = 2;
            this.panelTitle_Creativa1.SizeTitle = 0;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnActualizar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnActualizar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnActualizar.FocusRectangle = true;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnActualizar.Image = null;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnActualizar.ImageFocused = null;
            this.btnActualizar.ImageInactive = null;
            this.btnActualizar.ImageMouseOver = null;
            this.btnActualizar.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._31modificar;
            this.btnActualizar.ImagePressed = null;
            this.btnActualizar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnActualizar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnActualizar.KeyButtonView = false;
            this.btnActualizar.Location = new System.Drawing.Point(171, 15);
            this.btnActualizar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnActualizar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OffsetPressedContent = true;
            this.btnActualizar.Size = new System.Drawing.Size(75, 65);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextDropShadow = true;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDetalles.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDetalles.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDetalles.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnDetalles.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnDetalles.FocusRectangle = true;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDetalles.Image = null;
            this.btnDetalles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDetalles.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnDetalles.ImageFocused = null;
            this.btnDetalles.ImageInactive = null;
            this.btnDetalles.ImageMouseOver = null;
            this.btnDetalles.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._12pedidos;
            this.btnDetalles.ImagePressed = null;
            this.btnDetalles.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetalles.KeyButton = System.Windows.Forms.Keys.None;
            this.btnDetalles.KeyButtonView = false;
            this.btnDetalles.Location = new System.Drawing.Point(90, 15);
            this.btnDetalles.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDetalles.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.OffsetPressedContent = true;
            this.btnDetalles.Size = new System.Drawing.Size(75, 65);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetalles.TextDropShadow = true;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnAceptarSolicitud
            // 
            this.btnAceptarSolicitud.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptarSolicitud.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptarSolicitud.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptarSolicitud.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptarSolicitud.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptarSolicitud.FocusRectangle = true;
            this.btnAceptarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAceptarSolicitud.Image = null;
            this.btnAceptarSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptarSolicitud.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAceptarSolicitud.ImageFocused = null;
            this.btnAceptarSolicitud.ImageInactive = null;
            this.btnAceptarSolicitud.ImageMouseOver = null;
            this.btnAceptarSolicitud.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._35aceptar;
            this.btnAceptarSolicitud.ImagePressed = null;
            this.btnAceptarSolicitud.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAceptarSolicitud.KeyButton = System.Windows.Forms.Keys.None;
            this.btnAceptarSolicitud.KeyButtonView = false;
            this.btnAceptarSolicitud.Location = new System.Drawing.Point(6, 15);
            this.btnAceptarSolicitud.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptarSolicitud.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptarSolicitud.Name = "btnAceptarSolicitud";
            this.btnAceptarSolicitud.OffsetPressedContent = true;
            this.btnAceptarSolicitud.Size = new System.Drawing.Size(75, 65);
            this.btnAceptarSolicitud.TabIndex = 0;
            this.btnAceptarSolicitud.Text = "Aceptar";
            this.btnAceptarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarSolicitud.TextDropShadow = true;
            this.btnAceptarSolicitud.UseVisualStyleBackColor = false;
            this.btnAceptarSolicitud.Click += new System.EventHandler(this.btnAceptarSolicitud_Click);
            // 
            // panelFechaHora
            // 
            this.panelFechaHora.Controls.Add(this.panelFechaHoraCSL);
            this.panelFechaHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFechaHora.Location = new System.Drawing.Point(0, 553);
            this.panelFechaHora.Name = "panelFechaHora";
            this.panelFechaHora.Size = new System.Drawing.Size(257, 77);
            this.panelFechaHora.TabIndex = 0;
            // 
            // panelFechaHoraCSL
            // 
            this.panelFechaHoraCSL.AutoScroll = true;
            this.panelFechaHoraCSL.BorderRound = true;
            this.panelFechaHoraCSL.Controls.Add(this.label7);
            this.panelFechaHoraCSL.Controls.Add(this.label1);
            this.panelFechaHoraCSL.Controls.Add(this.txtHor_Actual);
            this.panelFechaHoraCSL.Controls.Add(this.txtFec_Actual);
            this.panelFechaHoraCSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFechaHoraCSL.DrawGradient = true;
            this.panelFechaHoraCSL.GradientTop = true;
            this.panelFechaHoraCSL.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelFechaHoraCSL.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panelFechaHoraCSL.Location = new System.Drawing.Point(0, 0);
            this.panelFechaHoraCSL.Margin = new System.Windows.Forms.Padding(0);
            this.panelFechaHoraCSL.Name = "panelFechaHoraCSL";
            this.panelFechaHoraCSL.Size = new System.Drawing.Size(257, 77);
            this.panelFechaHoraCSL.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha:";
            // 
            // txtHor_Actual
            // 
            this.txtHor_Actual.BackColor = System.Drawing.Color.White;
            this.txtHor_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHor_Actual.Location = new System.Drawing.Point(100, 45);
            this.txtHor_Actual.Name = "txtHor_Actual";
            this.txtHor_Actual.ReadOnly = true;
            this.txtHor_Actual.Size = new System.Drawing.Size(129, 27);
            this.txtHor_Actual.TabIndex = 8;
            this.txtHor_Actual.TabStop = false;
            this.txtHor_Actual.Text = "12:00:10";
            this.txtHor_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFec_Actual
            // 
            this.txtFec_Actual.BackColor = System.Drawing.Color.White;
            this.txtFec_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFec_Actual.Location = new System.Drawing.Point(100, 10);
            this.txtFec_Actual.Name = "txtFec_Actual";
            this.txtFec_Actual.ReadOnly = true;
            this.txtFec_Actual.Size = new System.Drawing.Size(129, 27);
            this.txtFec_Actual.TabIndex = 6;
            this.txtFec_Actual.TabStop = false;
            this.txtFec_Actual.Text = "12:00:10";
            this.txtFec_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelMenuCSL);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1264, 100);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMenuCSL
            // 
            this.panelMenuCSL.AutoScroll = true;
            this.panelMenuCSL.BackColor = System.Drawing.Color.White;
            this.panelMenuCSL.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenuCSL.Controls.Add(this.btnVerTodos);
            this.panelMenuCSL.Controls.Add(this.btnEmpresas);
            this.panelMenuCSL.Controls.Add(this.btnSalir);
            this.panelMenuCSL.Controls.Add(this.btnReportes);
            this.panelMenuCSL.Controls.Add(this.btnCaja);
            this.panelMenuCSL.Controls.Add(this.btnClientes);
            this.panelMenuCSL.Controls.Add(this.btnMisSolicitudes);
            this.panelMenuCSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuCSL.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMenuCSL.Location = new System.Drawing.Point(0, 0);
            this.panelMenuCSL.Name = "panelMenuCSL";
            this.panelMenuCSL.Size = new System.Drawing.Size(1264, 100);
            this.panelMenuCSL.SizeLine = 0;
            this.panelMenuCSL.SizeTitle = 0;
            this.panelMenuCSL.TabIndex = 0;
            this.panelMenuCSL.Title = "";
            this.panelMenuCSL.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTodos.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVerTodos.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerTodos.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerTodos.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnVerTodos.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnVerTodos.FocusRectangle = true;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnVerTodos.Image = null;
            this.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerTodos.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnVerTodos.ImageFocused = null;
            this.btnVerTodos.ImageInactive = null;
            this.btnVerTodos.ImageMouseOver = null;
            this.btnVerTodos.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._31modificar;
            this.btnVerTodos.ImagePressed = null;
            this.btnVerTodos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnVerTodos.KeyButton = System.Windows.Forms.Keys.None;
            this.btnVerTodos.KeyButtonView = false;
            this.btnVerTodos.Location = new System.Drawing.Point(1146, 15);
            this.btnVerTodos.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnVerTodos.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.OffsetPressedContent = true;
            this.btnVerTodos.Size = new System.Drawing.Size(90, 75);
            this.btnVerTodos.TabIndex = 7;
            this.btnVerTodos.Text = "Ver Todo";
            this.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerTodos.TextDropShadow = true;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEmpresas.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmpresas.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmpresas.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEmpresas.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEmpresas.FocusRectangle = true;
            this.btnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEmpresas.Image = null;
            this.btnEmpresas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpresas.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEmpresas.ImageFocused = null;
            this.btnEmpresas.ImageInactive = null;
            this.btnEmpresas.ImageMouseOver = null;
            this.btnEmpresas.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._9sucursales;
            this.btnEmpresas.ImagePressed = null;
            this.btnEmpresas.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEmpresas.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEmpresas.KeyButtonView = false;
            this.btnEmpresas.Location = new System.Drawing.Point(205, 15);
            this.btnEmpresas.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEmpresas.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.OffsetPressedContent = true;
            this.btnEmpresas.Size = new System.Drawing.Size(90, 75);
            this.btnEmpresas.TabIndex = 6;
            this.btnEmpresas.Text = "Empresas";
            this.btnEmpresas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresas.TextDropShadow = true;
            this.btnEmpresas.UseVisualStyleBackColor = false;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalir.Image = null;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnSalir.ImageFocused = null;
            this.btnSalir.ImageInactive = null;
            this.btnSalir.ImageMouseOver = null;
            this.btnSalir.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._11salir;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.None;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(490, 15);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(90, 75);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReportes.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReportes.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReportes.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnReportes.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnReportes.FocusRectangle = true;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnReportes.Image = null;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnReportes.ImageFocused = null;
            this.btnReportes.ImageInactive = null;
            this.btnReportes.ImageMouseOver = null;
            this.btnReportes.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.btnReportes.ImagePressed = null;
            this.btnReportes.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReportes.KeyButton = System.Windows.Forms.Keys.None;
            this.btnReportes.KeyButtonView = false;
            this.btnReportes.Location = new System.Drawing.Point(395, 15);
            this.btnReportes.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnReportes.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.OffsetPressedContent = true;
            this.btnReportes.Size = new System.Drawing.Size(90, 75);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextDropShadow = true;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCaja.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCaja.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCaja.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCaja.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCaja.FocusRectangle = true;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCaja.Image = null;
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaja.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCaja.ImageFocused = null;
            this.btnCaja.ImageInactive = null;
            this.btnCaja.ImageMouseOver = null;
            this.btnCaja.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._28caja;
            this.btnCaja.ImagePressed = null;
            this.btnCaja.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCaja.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCaja.KeyButtonView = false;
            this.btnCaja.Location = new System.Drawing.Point(300, 15);
            this.btnCaja.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCaja.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.OffsetPressedContent = true;
            this.btnCaja.Size = new System.Drawing.Size(90, 75);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaja.TextDropShadow = true;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClientes.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnClientes.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnClientes.FocusRectangle = true;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClientes.Image = null;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnClientes.ImageFocused = null;
            this.btnClientes.ImageInactive = null;
            this.btnClientes.ImageMouseOver = null;
            this.btnClientes.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._21clientes;
            this.btnClientes.ImagePressed = null;
            this.btnClientes.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClientes.KeyButton = System.Windows.Forms.Keys.None;
            this.btnClientes.KeyButtonView = false;
            this.btnClientes.Location = new System.Drawing.Point(110, 15);
            this.btnClientes.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClientes.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OffsetPressedContent = true;
            this.btnClientes.Size = new System.Drawing.Size(90, 75);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextDropShadow = true;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMisSolicitudes
            // 
            this.btnMisSolicitudes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMisSolicitudes.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMisSolicitudes.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMisSolicitudes.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnMisSolicitudes.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnMisSolicitudes.FocusRectangle = true;
            this.btnMisSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnMisSolicitudes.Image = null;
            this.btnMisSolicitudes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMisSolicitudes.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnMisSolicitudes.ImageFocused = null;
            this.btnMisSolicitudes.ImageInactive = null;
            this.btnMisSolicitudes.ImageMouseOver = null;
            this.btnMisSolicitudes.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._29trabajo;
            this.btnMisSolicitudes.ImagePressed = null;
            this.btnMisSolicitudes.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMisSolicitudes.KeyButton = System.Windows.Forms.Keys.None;
            this.btnMisSolicitudes.KeyButtonView = false;
            this.btnMisSolicitudes.Location = new System.Drawing.Point(15, 15);
            this.btnMisSolicitudes.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnMisSolicitudes.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnMisSolicitudes.Name = "btnMisSolicitudes";
            this.btnMisSolicitudes.OffsetPressedContent = true;
            this.btnMisSolicitudes.Size = new System.Drawing.Size(90, 75);
            this.btnMisSolicitudes.TabIndex = 1;
            this.btnMisSolicitudes.Text = "Mis Solicitudes";
            this.btnMisSolicitudes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMisSolicitudes.TextDropShadow = true;
            this.btnMisSolicitudes.UseVisualStyleBackColor = false;
            this.btnMisSolicitudes.Click += new System.EventHandler(this.btnMisSolicitudes_Click);
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Interval = 1000;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // MenuStripCaja
            // 
            this.MenuStripCaja.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuStripCaja.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuStripCaja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsm_caja_cerrar,
            this.toolsm_caja_retiros,
            this.toolsm_caja_depositos,
            this.retiroCajaLlenaToolStripMenuItem,
            this.abrirCajaToolStripMenuItem});
            this.MenuStripCaja.Name = "MenuStripEscaneos";
            this.MenuStripCaja.Size = new System.Drawing.Size(213, 134);
            this.MenuStripCaja.Text = "Escaneos";
            // 
            // toolsm_caja_cerrar
            // 
            this.toolsm_caja_cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolsm_caja_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolsm_caja_cerrar.Name = "toolsm_caja_cerrar";
            this.toolsm_caja_cerrar.Size = new System.Drawing.Size(212, 26);
            this.toolsm_caja_cerrar.Text = "Cerrar Turno";
            this.toolsm_caja_cerrar.Click += new System.EventHandler(this.toolsm_caja_cerrar_Click);
            // 
            // toolsm_caja_retiros
            // 
            this.toolsm_caja_retiros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolsm_caja_retiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolsm_caja_retiros.Name = "toolsm_caja_retiros";
            this.toolsm_caja_retiros.Size = new System.Drawing.Size(212, 26);
            this.toolsm_caja_retiros.Text = "Retiros";
            this.toolsm_caja_retiros.Click += new System.EventHandler(this.toolsm_caja_retiros_Click);
            // 
            // toolsm_caja_depositos
            // 
            this.toolsm_caja_depositos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolsm_caja_depositos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolsm_caja_depositos.Name = "toolsm_caja_depositos";
            this.toolsm_caja_depositos.Size = new System.Drawing.Size(212, 26);
            this.toolsm_caja_depositos.Text = "Depositos";
            this.toolsm_caja_depositos.Click += new System.EventHandler(this.toolsm_caja_depositos_Click);
            // 
            // retiroCajaLlenaToolStripMenuItem
            // 
            this.retiroCajaLlenaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retiroCajaLlenaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.retiroCajaLlenaToolStripMenuItem.Name = "retiroCajaLlenaToolStripMenuItem";
            this.retiroCajaLlenaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.retiroCajaLlenaToolStripMenuItem.Text = "Retiro Caja Llena";
            this.retiroCajaLlenaToolStripMenuItem.Click += new System.EventHandler(this.retiroCajaLlenaToolStripMenuItem_Click);
            // 
            // abrirCajaToolStripMenuItem
            // 
            this.abrirCajaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirCajaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abrirCajaToolStripMenuItem.Name = "abrirCajaToolStripMenuItem";
            this.abrirCajaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.abrirCajaToolStripMenuItem.Text = "Abrir CashDrawer";
            this.abrirCajaToolStripMenuItem.Visible = false;
            // 
            // MenuStripReportes
            // 
            this.MenuStripReportes.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuStripReportes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuStripReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCaja,
            this.tsRecursos,
            this.tsSolicitudesRecibidas,
            this.tsSolicitudesTramite,
            this.tsSolicitudesCanceladas,
            this.tsPaquetesVendidos,
            this.tsEmpleados,
            this.tsSolicitudesXEmpresa});
            this.MenuStripReportes.Name = "MenuStripEscaneos";
            this.MenuStripReportes.Size = new System.Drawing.Size(316, 212);
            this.MenuStripReportes.Text = "Escaneos";
            // 
            // tsCaja
            // 
            this.tsCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsCaja.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsCaja.Name = "tsCaja";
            this.tsCaja.Size = new System.Drawing.Size(315, 26);
            this.tsCaja.Tag = "5";
            this.tsCaja.Text = "Caja";
            this.tsCaja.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsRecursos
            // 
            this.tsRecursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsRecursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsRecursos.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsRecursos.Name = "tsRecursos";
            this.tsRecursos.Size = new System.Drawing.Size(315, 26);
            this.tsRecursos.Tag = "6";
            this.tsRecursos.Text = "Recursos";
            this.tsRecursos.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsSolicitudesRecibidas
            // 
            this.tsSolicitudesRecibidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsSolicitudesRecibidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsSolicitudesRecibidas.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsSolicitudesRecibidas.Name = "tsSolicitudesRecibidas";
            this.tsSolicitudesRecibidas.Size = new System.Drawing.Size(315, 26);
            this.tsSolicitudesRecibidas.Tag = "1";
            this.tsSolicitudesRecibidas.Text = "Solicitudes Recibidas";
            this.tsSolicitudesRecibidas.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsSolicitudesTramite
            // 
            this.tsSolicitudesTramite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsSolicitudesTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsSolicitudesTramite.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsSolicitudesTramite.Name = "tsSolicitudesTramite";
            this.tsSolicitudesTramite.Size = new System.Drawing.Size(315, 26);
            this.tsSolicitudesTramite.Tag = "3";
            this.tsSolicitudesTramite.Text = "Solicitudes en Trámite";
            this.tsSolicitudesTramite.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsSolicitudesCanceladas
            // 
            this.tsSolicitudesCanceladas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSolicitudesCanceladas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsSolicitudesCanceladas.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsSolicitudesCanceladas.Name = "tsSolicitudesCanceladas";
            this.tsSolicitudesCanceladas.Size = new System.Drawing.Size(315, 26);
            this.tsSolicitudesCanceladas.Tag = "2";
            this.tsSolicitudesCanceladas.Text = "Solicitudes Canceladas";
            this.tsSolicitudesCanceladas.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsPaquetesVendidos
            // 
            this.tsPaquetesVendidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPaquetesVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsPaquetesVendidos.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsPaquetesVendidos.Name = "tsPaquetesVendidos";
            this.tsPaquetesVendidos.Size = new System.Drawing.Size(315, 26);
            this.tsPaquetesVendidos.Tag = "4";
            this.tsPaquetesVendidos.Text = "Paquetes / Tours más Vendidos";
            this.tsPaquetesVendidos.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsEmpleados
            // 
            this.tsEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsEmpleados.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsEmpleados.Name = "tsEmpleados";
            this.tsEmpleados.Size = new System.Drawing.Size(315, 26);
            this.tsEmpleados.Tag = "7";
            this.tsEmpleados.Text = "Totales de empleados";
            this.tsEmpleados.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // tsSolicitudesXEmpresa
            // 
            this.tsSolicitudesXEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsSolicitudesXEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsSolicitudesXEmpresa.Image = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._13reporte;
            this.tsSolicitudesXEmpresa.Name = "tsSolicitudesXEmpresa";
            this.tsSolicitudesXEmpresa.Size = new System.Drawing.Size(315, 26);
            this.tsSolicitudesXEmpresa.Tag = "9";
            this.tsSolicitudesXEmpresa.Text = "Solicitudes por empresa";
            this.tsSolicitudesXEmpresa.Click += new System.EventHandler(this.tsCaja_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.ControlBox = true;
            this.Controls.Add(this.panelGeneral);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1280, 726);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).EndInit();
            this.panelLateralDerecho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelExtra.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelFechaHora.ResumeLayout(false);
            this.panelFechaHoraCSL.ResumeLayout(false);
            this.panelFechaHoraCSL.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenuCSL.ResumeLayout(false);
            this.MenuStripCaja.ResumeLayout(false);
            this.MenuStripReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridView dgvSolicitudesPendientes;
        private System.Windows.Forms.Panel panelLateralDerecho;
        private System.Windows.Forms.Panel panelMenu;
        private LibControls.WinForms.PanelTitle_Creativa panelMenuCSL;
        private System.Windows.Forms.Panel panelFechaHora;
        private LibControls.WinForms.Panel_Creativa panelFechaHoraCSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHor_Actual;
        private System.Windows.Forms.TextBox txtFec_Actual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelExtra;
        private System.Windows.Forms.Panel panelBotones;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private LibControls.WinForms.Button_Creativa btnAceptarSolicitud;
        private LibControls.WinForms.Button_Creativa btnMisSolicitudes;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnReportes;
        private LibControls.WinForms.Button_Creativa btnCaja;
        private LibControls.WinForms.Button_Creativa btnClientes;
        private LibControls.WinForms.Button_Creativa btnDetalles;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.ContextMenuStrip MenuStripCaja;
        private System.Windows.Forms.ToolStripMenuItem toolsm_caja_cerrar;
        private System.Windows.Forms.ToolStripMenuItem toolsm_caja_retiros;
        private System.Windows.Forms.ToolStripMenuItem toolsm_caja_depositos;
        private System.Windows.Forms.ToolStripMenuItem retiroCajaLlenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCajaToolStripMenuItem;
        private LibControls.WinForms.Button_Creativa btnEmpresas;
        private System.Windows.Forms.ContextMenuStrip MenuStripReportes;
        private System.Windows.Forms.ToolStripMenuItem tsCaja;
        private System.Windows.Forms.ToolStripMenuItem tsSolicitudesRecibidas;
        private System.Windows.Forms.ToolStripMenuItem tsSolicitudesTramite;
        private System.Windows.Forms.ToolStripMenuItem tsSolicitudesCanceladas;
        private System.Windows.Forms.ToolStripMenuItem tsPaquetesVendidos;
        private LibControls.WinForms.Button_Creativa btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem tsRecursos;
        private System.Windows.Forms.ToolStripMenuItem tsEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsSolicitudesXEmpresa;
        private LibControls.WinForms.Button_Creativa btnVerTodos;
    }
}