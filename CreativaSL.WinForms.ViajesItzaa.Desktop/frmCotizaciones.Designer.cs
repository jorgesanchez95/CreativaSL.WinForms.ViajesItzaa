namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    partial class frmCotizaciones
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelCentralGrid = new System.Windows.Forms.Panel();
            this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
            this.panelCentralDerecho = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtOtrosServicios = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoraLlegada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTieneBoletos = new System.Windows.Forms.CheckBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbl34 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumHabitaciones = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnDisponibilidad = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEnviarCotizacion = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEliminarCotizacion = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnModificarCotizacion = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnNuevaCotizacion = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.bgwEnvioCorreo = new System.ComponentModel.BackgroundWorker();
            this.panelPrincipal.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panelCentralGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
            this.panelCentralDerecho.SuspendLayout();
            this.panelTitle_Creativa2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelCentral);
            this.panelPrincipal.Controls.Add(this.panelSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1264, 730);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.panelCentralGrid);
            this.panelCentral.Controls.Add(this.panelCentralDerecho);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 75);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1264, 655);
            this.panelCentral.TabIndex = 1;
            // 
            // panelCentralGrid
            // 
            this.panelCentralGrid.Controls.Add(this.dgvCotizaciones);
            this.panelCentralGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentralGrid.Location = new System.Drawing.Point(0, 0);
            this.panelCentralGrid.Name = "panelCentralGrid";
            this.panelCentralGrid.Size = new System.Drawing.Size(887, 655);
            this.panelCentralGrid.TabIndex = 1;
            // 
            // dgvCotizaciones
            // 
            this.dgvCotizaciones.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCotizaciones.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvCotizaciones.Name = "dgvCotizaciones";
            this.dgvCotizaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCotizaciones.Size = new System.Drawing.Size(887, 655);
            this.dgvCotizaciones.TabIndex = 0;
            this.dgvCotizaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCotizaciones_CellContentClick);
            // 
            // panelCentralDerecho
            // 
            this.panelCentralDerecho.Controls.Add(this.panelTitle_Creativa2);
            this.panelCentralDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCentralDerecho.Location = new System.Drawing.Point(887, 0);
            this.panelCentralDerecho.Name = "panelCentralDerecho";
            this.panelCentralDerecho.Size = new System.Drawing.Size(377, 655);
            this.panelCentralDerecho.TabIndex = 0;
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.AutoScroll = true;
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.panel3);
            this.panelTitle_Creativa2.Controls.Add(this.panel2);
            this.panelTitle_Creativa2.Controls.Add(this.panel1);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(377, 655);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 40;
            this.panelTitle_Creativa2.TabIndex = 0;
            this.panelTitle_Creativa2.Title = "DATOS DE LA SOLICITUD";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtOtrosServicios);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtHoraSalida);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtFechaSalida);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtHoraLlegada);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtFechaLlegada);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.chkTieneBoletos);
            this.panel3.Controls.Add(this.txtProducto);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCorreoElectronico);
            this.panel3.Controls.Add(this.lblCorreoElectronico);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.lbl34);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtFolio);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 436);
            this.panel3.TabIndex = 2;
            // 
            // txtOtrosServicios
            // 
            this.txtOtrosServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtrosServicios.Location = new System.Drawing.Point(20, 370);
            this.txtOtrosServicios.MaxLength = 30;
            this.txtOtrosServicios.Multiline = true;
            this.txtOtrosServicios.Name = "txtOtrosServicios";
            this.txtOtrosServicios.ReadOnly = true;
            this.txtOtrosServicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOtrosServicios.Size = new System.Drawing.Size(337, 60);
            this.txtOtrosServicios.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(20, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Otros Servicios:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSalida.Location = new System.Drawing.Point(227, 325);
            this.txtHoraSalida.MaxLength = 30;
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.ReadOnly = true;
            this.txtHoraSalida.Size = new System.Drawing.Size(130, 22);
            this.txtHoraSalida.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(227, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hora Salida:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaSalida.Location = new System.Drawing.Point(20, 325);
            this.txtFechaSalida.MaxLength = 30;
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.ReadOnly = true;
            this.txtFechaSalida.Size = new System.Drawing.Size(130, 22);
            this.txtFechaSalida.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(20, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha Salida:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoraLlegada
            // 
            this.txtHoraLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraLlegada.Location = new System.Drawing.Point(227, 280);
            this.txtHoraLlegada.MaxLength = 30;
            this.txtHoraLlegada.Name = "txtHoraLlegada";
            this.txtHoraLlegada.ReadOnly = true;
            this.txtHoraLlegada.Size = new System.Drawing.Size(130, 22);
            this.txtHoraLlegada.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(227, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hora Llegada:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaLlegada.Location = new System.Drawing.Point(20, 280);
            this.txtFechaLlegada.MaxLength = 30;
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.ReadOnly = true;
            this.txtFechaLlegada.Size = new System.Drawing.Size(130, 22);
            this.txtFechaLlegada.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Llegada:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTieneBoletos
            // 
            this.chkTieneBoletos.Enabled = false;
            this.chkTieneBoletos.Location = new System.Drawing.Point(20, 235);
            this.chkTieneBoletos.Name = "chkTieneBoletos";
            this.chkTieneBoletos.Size = new System.Drawing.Size(250, 20);
            this.chkTieneBoletos.TabIndex = 12;
            this.chkTieneBoletos.Text = "¿Tiene boletos de avión?";
            this.chkTieneBoletos.UseVisualStyleBackColor = true;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(20, 210);
            this.txtProducto.MaxLength = 30;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(337, 22);
            this.txtProducto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Producto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(20, 165);
            this.txtCorreoElectronico.MaxLength = 30;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.ReadOnly = true;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(337, 22);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(20, 145);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(200, 20);
            this.lblCorreoElectronico.TabIndex = 8;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            this.lblCorreoElectronico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(20, 120);
            this.txtTelefono.MaxLength = 30;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(180, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // lbl34
            // 
            this.lbl34.BackColor = System.Drawing.Color.Transparent;
            this.lbl34.Location = new System.Drawing.Point(20, 100);
            this.lbl34.Name = "lbl34";
            this.lbl34.Size = new System.Drawing.Size(200, 20);
            this.lbl34.TabIndex = 6;
            this.lbl34.Text = "Teléfono:";
            this.lbl34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(20, 75);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(337, 22);
            this.txtCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(20, 30);
            this.txtFolio.MaxLength = 30;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(180, 22);
            this.txtFolio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 179);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 149);
            this.panel6.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvHabitaciones);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(20, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 149);
            this.panel9.TabIndex = 2;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitaciones.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.Size = new System.Drawing.Size(337, 149);
            this.dgvHabitaciones.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(357, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 149);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 149);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 10);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblNumHabitaciones);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 20);
            this.panel4.TabIndex = 0;
            // 
            // lblNumHabitaciones
            // 
            this.lblNumHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblNumHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHabitaciones.Location = new System.Drawing.Point(140, 0);
            this.lblNumHabitaciones.Name = "lblNumHabitaciones";
            this.lblNumHabitaciones.Size = new System.Drawing.Size(60, 20);
            this.lblNumHabitaciones.TabIndex = 24;
            this.lblNumHabitaciones.Text = "0";
            this.lblNumHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(20, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Habitaciones:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 40);
            this.panel1.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.panelTitle_Creativa1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1264, 75);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoScroll = true;
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa1.Controls.Add(this.btnDisponibilidad);
            this.panelTitle_Creativa1.Controls.Add(this.btnSalir);
            this.panelTitle_Creativa1.Controls.Add(this.btnEnviarCotizacion);
            this.panelTitle_Creativa1.Controls.Add(this.btnEliminarCotizacion);
            this.panelTitle_Creativa1.Controls.Add(this.btnModificarCotizacion);
            this.panelTitle_Creativa1.Controls.Add(this.btnNuevaCotizacion);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(1264, 75);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 0;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDisponibilidad.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisponibilidad.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisponibilidad.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnDisponibilidad.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnDisponibilidad.FocusRectangle = true;
            this.btnDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDisponibilidad.Image = null;
            this.btnDisponibilidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisponibilidad.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnDisponibilidad.ImageFocused = null;
            this.btnDisponibilidad.ImageInactive = null;
            this.btnDisponibilidad.ImageMouseOver = null;
            this.btnDisponibilidad.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._2entregar;
            this.btnDisponibilidad.ImagePressed = null;
            this.btnDisponibilidad.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDisponibilidad.KeyButton = System.Windows.Forms.Keys.None;
            this.btnDisponibilidad.KeyButtonView = false;
            this.btnDisponibilidad.Location = new System.Drawing.Point(350, 6);
            this.btnDisponibilidad.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDisponibilidad.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.OffsetPressedContent = true;
            this.btnDisponibilidad.Size = new System.Drawing.Size(85, 65);
            this.btnDisponibilidad.TabIndex = 7;
            this.btnDisponibilidad.Text = "Disponibilidad";
            this.btnDisponibilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisponibilidad.TextDropShadow = true;
            this.btnDisponibilidad.UseVisualStyleBackColor = false;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
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
            this.btnSalir.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._16regresar;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.None;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(445, 6);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 65);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEnviarCotizacion
            // 
            this.btnEnviarCotizacion.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEnviarCotizacion.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnviarCotizacion.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnviarCotizacion.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEnviarCotizacion.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEnviarCotizacion.FocusRectangle = true;
            this.btnEnviarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEnviarCotizacion.Image = null;
            this.btnEnviarCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarCotizacion.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEnviarCotizacion.ImageFocused = null;
            this.btnEnviarCotizacion.ImageInactive = null;
            this.btnEnviarCotizacion.ImageMouseOver = null;
            this.btnEnviarCotizacion.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._14continuar;
            this.btnEnviarCotizacion.ImagePressed = null;
            this.btnEnviarCotizacion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEnviarCotizacion.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEnviarCotizacion.KeyButtonView = false;
            this.btnEnviarCotizacion.Location = new System.Drawing.Point(265, 6);
            this.btnEnviarCotizacion.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEnviarCotizacion.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEnviarCotizacion.Name = "btnEnviarCotizacion";
            this.btnEnviarCotizacion.OffsetPressedContent = true;
            this.btnEnviarCotizacion.Size = new System.Drawing.Size(75, 65);
            this.btnEnviarCotizacion.TabIndex = 5;
            this.btnEnviarCotizacion.Text = "Enviar";
            this.btnEnviarCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarCotizacion.TextDropShadow = true;
            this.btnEnviarCotizacion.UseVisualStyleBackColor = false;
            this.btnEnviarCotizacion.Click += new System.EventHandler(this.btnEnviarCotizacion_Click);
            // 
            // btnEliminarCotizacion
            // 
            this.btnEliminarCotizacion.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarCotizacion.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarCotizacion.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarCotizacion.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEliminarCotizacion.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarCotizacion.FocusRectangle = true;
            this.btnEliminarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEliminarCotizacion.Image = null;
            this.btnEliminarCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCotizacion.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEliminarCotizacion.ImageFocused = null;
            this.btnEliminarCotizacion.ImageInactive = null;
            this.btnEliminarCotizacion.ImageMouseOver = null;
            this.btnEliminarCotizacion.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._7eliminar;
            this.btnEliminarCotizacion.ImagePressed = null;
            this.btnEliminarCotizacion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEliminarCotizacion.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEliminarCotizacion.KeyButtonView = false;
            this.btnEliminarCotizacion.Location = new System.Drawing.Point(180, 6);
            this.btnEliminarCotizacion.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminarCotizacion.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarCotizacion.Name = "btnEliminarCotizacion";
            this.btnEliminarCotizacion.OffsetPressedContent = true;
            this.btnEliminarCotizacion.Size = new System.Drawing.Size(75, 65);
            this.btnEliminarCotizacion.TabIndex = 4;
            this.btnEliminarCotizacion.Text = "Eliminar";
            this.btnEliminarCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCotizacion.TextDropShadow = true;
            this.btnEliminarCotizacion.UseVisualStyleBackColor = false;
            this.btnEliminarCotizacion.Click += new System.EventHandler(this.btnEliminarCotizacion_Click);
            // 
            // btnModificarCotizacion
            // 
            this.btnModificarCotizacion.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarCotizacion.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarCotizacion.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarCotizacion.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnModificarCotizacion.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnModificarCotizacion.FocusRectangle = true;
            this.btnModificarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnModificarCotizacion.Image = null;
            this.btnModificarCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarCotizacion.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnModificarCotizacion.ImageFocused = null;
            this.btnModificarCotizacion.ImageInactive = null;
            this.btnModificarCotizacion.ImageMouseOver = null;
            this.btnModificarCotizacion.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._31modificar;
            this.btnModificarCotizacion.ImagePressed = null;
            this.btnModificarCotizacion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnModificarCotizacion.KeyButton = System.Windows.Forms.Keys.None;
            this.btnModificarCotizacion.KeyButtonView = false;
            this.btnModificarCotizacion.Location = new System.Drawing.Point(95, 6);
            this.btnModificarCotizacion.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnModificarCotizacion.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnModificarCotizacion.Name = "btnModificarCotizacion";
            this.btnModificarCotizacion.OffsetPressedContent = true;
            this.btnModificarCotizacion.Size = new System.Drawing.Size(75, 65);
            this.btnModificarCotizacion.TabIndex = 3;
            this.btnModificarCotizacion.Text = "Modificar";
            this.btnModificarCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarCotizacion.TextDropShadow = true;
            this.btnModificarCotizacion.UseVisualStyleBackColor = false;
            this.btnModificarCotizacion.Click += new System.EventHandler(this.btnModificarCotizacion_Click);
            // 
            // btnNuevaCotizacion
            // 
            this.btnNuevaCotizacion.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevaCotizacion.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaCotizacion.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaCotizacion.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnNuevaCotizacion.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnNuevaCotizacion.FocusRectangle = true;
            this.btnNuevaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNuevaCotizacion.Image = null;
            this.btnNuevaCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaCotizacion.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnNuevaCotizacion.ImageFocused = null;
            this.btnNuevaCotizacion.ImageInactive = null;
            this.btnNuevaCotizacion.ImageMouseOver = null;
            this.btnNuevaCotizacion.ImageNormal = global::CreativaSL.WinForms.ViajesItzaa.Desktop.Properties.Resources._27servicios;
            this.btnNuevaCotizacion.ImagePressed = null;
            this.btnNuevaCotizacion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNuevaCotizacion.KeyButton = System.Windows.Forms.Keys.None;
            this.btnNuevaCotizacion.KeyButtonView = false;
            this.btnNuevaCotizacion.Location = new System.Drawing.Point(10, 6);
            this.btnNuevaCotizacion.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevaCotizacion.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevaCotizacion.Name = "btnNuevaCotizacion";
            this.btnNuevaCotizacion.OffsetPressedContent = true;
            this.btnNuevaCotizacion.Size = new System.Drawing.Size(75, 65);
            this.btnNuevaCotizacion.TabIndex = 2;
            this.btnNuevaCotizacion.Text = "Nueva";
            this.btnNuevaCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaCotizacion.TextDropShadow = true;
            this.btnNuevaCotizacion.UseVisualStyleBackColor = false;
            this.btnNuevaCotizacion.Click += new System.EventHandler(this.btnNuevaCotizacion_Click);
            // 
            // bgwEnvioCorreo
            // 
            this.bgwEnvioCorreo.WorkerReportsProgress = true;
            this.bgwEnvioCorreo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEnvioCorreo_DoWork);
            this.bgwEnvioCorreo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwEnvioCorreo_ProgressChanged);
            this.bgwEnvioCorreo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEnvioCorreo_RunWorkerCompleted);
            // 
            // frmCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.ControlBox = true;
            this.Controls.Add(this.panelPrincipal);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.frmCotizaciones_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentralGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
            this.panelCentralDerecho.ResumeLayout(false);
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelCentralGrid;
        private System.Windows.Forms.DataGridView dgvCotizaciones;
        private System.Windows.Forms.Panel panelCentralDerecho;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSuperior;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnEnviarCotizacion;
        private LibControls.WinForms.Button_Creativa btnEliminarCotizacion;
        private LibControls.WinForms.Button_Creativa btnModificarCotizacion;
        private LibControls.WinForms.Button_Creativa btnNuevaCotizacion;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtOtrosServicios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoraLlegada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTieneBoletos;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbl34;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNumHabitaciones;
        private LibControls.WinForms.Button_Creativa btnDisponibilidad;
        private System.ComponentModel.BackgroundWorker bgwEnvioCorreo;
    }
}