namespace GestorDeBiblioteca
{
    partial class FrmGestionDePrestamos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelregistroLibros = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Autor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Estado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAutorLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEstadoLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTituloLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelregistroUsuarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Nombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Carnet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCarnetUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaPrestamo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelregistroLibros.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelregistroUsuarios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.BotonesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BotonesLayout);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panelregistroLibros);
            this.panel3.Controls.Add(this.panelregistroUsuarios);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtpFechaDevolucion);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.FechaPrestamo);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 580);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrestamos);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 418);
            this.panel1.TabIndex = 60;
            // 
            // panelregistroLibros
            // 
            this.panelregistroLibros.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroLibros.BorderRadius = 20;
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel2);
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel4);
            this.panelregistroLibros.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroLibros.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroLibros.Location = new System.Drawing.Point(674, 288);
            this.panelregistroLibros.Name = "panelregistroLibros";
            this.panelregistroLibros.ShadowDecoration.Parent = this.panelregistroLibros;
            this.panelregistroLibros.Size = new System.Drawing.Size(385, 195);
            this.panelregistroLibros.TabIndex = 62;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Titulo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Autor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Estado, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblAutorLibro, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEstadoLibro, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloLibro, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86207F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.58621F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 154);
            this.tableLayoutPanel2.TabIndex = 55;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(3, 27);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(62, 25);
            this.Titulo.TabIndex = 61;
            this.Titulo.Text = "Titulo:";
            // 
            // Autor
            // 
            this.Autor.BackColor = System.Drawing.Color.Transparent;
            this.Autor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(3, 70);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(59, 25);
            this.Autor.TabIndex = 62;
            this.Autor.Text = "Autor:";
            // 
            // Estado
            // 
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(3, 112);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(68, 25);
            this.Estado.TabIndex = 63;
            this.Estado.Text = "Estado:";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutorLibro.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(127, 70);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(108, 21);
            this.lblAutorLibro.TabIndex = 57;
            this.lblAutorLibro.Text = "lblAutorLibro";
            // 
            // lblEstadoLibro
            // 
            this.lblEstadoLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoLibro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEstadoLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLibro.Location = new System.Drawing.Point(127, 112);
            this.lblEstadoLibro.Name = "lblEstadoLibro";
            this.lblEstadoLibro.Size = new System.Drawing.Size(116, 21);
            this.lblEstadoLibro.TabIndex = 58;
            this.lblEstadoLibro.Text = "lblEstadoLibro";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloLibro.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(127, 27);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(110, 21);
            this.lblTituloLibro.TabIndex = 56;
            this.lblTituloLibro.Text = "lblTituloLibro";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel4.Controls.Add(this.txtBuscarLibro, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(385, 41);
            this.tableLayoutPanel4.TabIndex = 61;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // panelregistroUsuarios
            // 
            this.panelregistroUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroUsuarios.BorderRadius = 20;
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel1);
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel3);
            this.panelregistroUsuarios.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroUsuarios.Location = new System.Drawing.Point(678, 75);
            this.panelregistroUsuarios.Name = "panelregistroUsuarios";
            this.panelregistroUsuarios.ShadowDecoration.Parent = this.panelregistroUsuarios;
            this.panelregistroUsuarios.Size = new System.Drawing.Size(381, 167);
            this.panelregistroUsuarios.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Carnet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarnetUsuario, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 121);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(3, 63);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 25);
            this.Nombre.TabIndex = 61;
            this.Nombre.Text = "Nombre:";
            // 
            // Carnet
            // 
            this.Carnet.BackColor = System.Drawing.Color.Transparent;
            this.Carnet.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carnet.Location = new System.Drawing.Point(3, 3);
            this.Carnet.Name = "Carnet";
            this.Carnet.Size = new System.Drawing.Size(68, 25);
            this.Carnet.TabIndex = 60;
            this.Carnet.Text = "Carnet:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(110, 63);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(146, 21);
            this.lblNombreUsuario.TabIndex = 55;
            this.lblNombreUsuario.Text = "lblNombreUsuario";
            // 
            // lblCarnetUsuario
            // 
            this.lblCarnetUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarnetUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblCarnetUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetUsuario.Location = new System.Drawing.Point(110, 3);
            this.lblCarnetUsuario.Name = "lblCarnetUsuario";
            this.lblCarnetUsuario.Size = new System.Drawing.Size(135, 21);
            this.lblCarnetUsuario.TabIndex = 56;
            this.lblCarnetUsuario.Text = "lblCarnetUsuario";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tableLayoutPanel3.Controls.Add(this.txtBuscarUsuario, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(381, 46);
            this.tableLayoutPanel3.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha de Devolucion";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(8, 548);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(297, 29);
            this.dtpFechaDevolucion.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de Prestamo:";
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.AutoSize = true;
            this.FechaPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPrestamo.Location = new System.Drawing.Point(182, 62);
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Size = new System.Drawing.Size(117, 25);
            this.FechaPrestamo.TabIndex = 30;
            this.FechaPrestamo.Text = "FechaActual";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1095, 56);
            this.panel4.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de Prestamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToOrderColumns = true;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(471, 418);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 2;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Controls.Add(this.btnAgregar, 1, 0);
            this.BotonesLayout.Controls.Add(this.btnCancelar, 0, 0);
            this.BotonesLayout.Location = new System.Drawing.Point(770, 501);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BotonesLayout.Size = new System.Drawing.Size(289, 54);
            this.BotonesLayout.TabIndex = 65;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 6;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_agregar_1001;
            this.btnAgregar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAgregar.Location = new System.Drawing.Point(147, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(139, 48);
            this.btnAgregar.TabIndex = 63;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BorderRadius = 6;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_cancelar_100__2_;
            this.btnCancelar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(138, 48);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarLibro.BorderRadius = 8;
            this.txtBuscarLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarLibro.DefaultText = "";
            this.txtBuscarLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarLibro.DisabledState.Parent = this.txtBuscarLibro;
            this.txtBuscarLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarLibro.FocusedState.Parent = this.txtBuscarLibro;
            this.txtBuscarLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarLibro.HoverState.Parent = this.txtBuscarLibro;
            this.txtBuscarLibro.IconLeft = global::GestorDeBiblioteca.Properties.Resources.icons8_search_24;
            this.txtBuscarLibro.Location = new System.Drawing.Point(4, 4);
            this.txtBuscarLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.PasswordChar = '\0';
            this.txtBuscarLibro.PlaceholderText = "Buscar libro...";
            this.txtBuscarLibro.SelectedText = "";
            this.txtBuscarLibro.ShadowDecoration.Parent = this.txtBuscarLibro;
            this.txtBuscarLibro.Size = new System.Drawing.Size(377, 33);
            this.txtBuscarLibro.TabIndex = 62;
            this.txtBuscarLibro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarLibro_KeyDown);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarUsuario.BorderRadius = 8;
            this.txtBuscarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarUsuario.DefaultText = "";
            this.txtBuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsuario.DisabledState.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.FocusedState.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.HoverState.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.IconLeft = global::GestorDeBiblioteca.Properties.Resources.icons8_search_24;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(4, 4);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.PasswordChar = '\0';
            this.txtBuscarUsuario.PlaceholderText = "Buscar usuario...";
            this.txtBuscarUsuario.SelectedText = "";
            this.txtBuscarUsuario.ShadowDecoration.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.Size = new System.Drawing.Size(373, 38);
            this.txtBuscarUsuario.TabIndex = 61;
            this.txtBuscarUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyDown_1);
            // 
            // FrmGestionDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 580);
            this.Controls.Add(this.panel3);
            this.Name = "FrmGestionDePrestamos";
            this.Text = "FrmGestionDePrestamos";
            this.Load += new System.EventHandler(this.FrmGestionDePrestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelregistroLibros.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panelregistroUsuarios.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.BotonesLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FechaPrestamo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTituloLibro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAutorLibro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstadoLibro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarnetUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Carnet;
        private Guna.UI2.WinForms.Guna2HtmlLabel Titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel Autor;
        private Guna.UI2.WinForms.Guna2HtmlLabel Estado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarLibro;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUsuario;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelregistroLibros;
        private Guna.UI2.WinForms.Guna2HtmlLabel Nombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2GradientPanel panelregistroUsuarios;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
    }
}