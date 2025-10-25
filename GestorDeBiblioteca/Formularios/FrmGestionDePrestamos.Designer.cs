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
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.panelregistroLibros = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Autor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Estado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAutorLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTituloLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEstadoLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelregistroUsuarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Nombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Carnet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCarnetUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaPrestamo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.BotonesLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.panelregistroLibros.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelregistroUsuarios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1460, 714);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 2;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Controls.Add(this.btnAgregar, 0, 0);
            this.BotonesLayout.Controls.Add(this.btnCancelar, 1, 0);
            this.BotonesLayout.Location = new System.Drawing.Point(28, 665);
            this.BotonesLayout.Margin = new System.Windows.Forms.Padding(4);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BotonesLayout.Size = new System.Drawing.Size(513, 49);
            this.BotonesLayout.TabIndex = 65;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 6;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_agregar_1001;
            this.btnAgregar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAgregar.Location = new System.Drawing.Point(4, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(248, 41);
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
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_cancelar_100__2_;
            this.btnCancelar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(260, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(248, 41);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvPrestamos);
            this.panel1.Location = new System.Drawing.Point(677, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 571);
            this.panel1.TabIndex = 60;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToOrderColumns = true;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.Size = new System.Drawing.Size(759, 571);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // panelregistroLibros
            // 
            this.panelregistroLibros.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelregistroLibros.BorderRadius = 20;
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel2);
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel4);
            this.panelregistroLibros.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelregistroLibros.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroLibros.Location = new System.Drawing.Point(23, 407);
            this.panelregistroLibros.Margin = new System.Windows.Forms.Padding(4);
            this.panelregistroLibros.Name = "panelregistroLibros";
            this.panelregistroLibros.ShadowDecoration.Parent = this.panelregistroLibros;
            this.panelregistroLibros.Size = new System.Drawing.Size(575, 250);
            this.panelregistroLibros.TabIndex = 62;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Autor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Estado, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAutorLibro, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloLibro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEstadoLibro, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 68);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.79953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.04843F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.15203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 169);
            this.tableLayoutPanel2.TabIndex = 55;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(4, 4);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(157, 49);
            this.Titulo.TabIndex = 61;
            this.Titulo.Text = "Titulo:";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Autor
            // 
            this.Autor.BackColor = System.Drawing.Color.Transparent;
            this.Autor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Autor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(4, 61);
            this.Autor.Margin = new System.Windows.Forms.Padding(4);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(157, 47);
            this.Autor.TabIndex = 62;
            this.Autor.Text = "Autor:";
            // 
            // Estado
            // 
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Estado.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(4, 116);
            this.Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(157, 49);
            this.Estado.TabIndex = 63;
            this.Estado.Text = "Estado:";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.BackColor = System.Drawing.Color.White;
            this.lblAutorLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutorLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(169, 61);
            this.lblAutorLibro.Margin = new System.Windows.Forms.Padding(4);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(357, 47);
            this.lblAutorLibro.TabIndex = 57;
            this.lblAutorLibro.Text = "lblAutorLibro";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.BackColor = System.Drawing.Color.White;
            this.lblTituloLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(169, 4);
            this.lblTituloLibro.Margin = new System.Windows.Forms.Padding(4);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(357, 49);
            this.lblTituloLibro.TabIndex = 56;
            this.lblTituloLibro.Text = "lblTituloLibro";
            // 
            // lblEstadoLibro
            // 
            this.lblEstadoLibro.BackColor = System.Drawing.Color.White;
            this.lblEstadoLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLibro.Location = new System.Drawing.Point(169, 116);
            this.lblEstadoLibro.Margin = new System.Windows.Forms.Padding(4);
            this.lblEstadoLibro.Name = "lblEstadoLibro";
            this.lblEstadoLibro.Size = new System.Drawing.Size(357, 49);
            this.lblEstadoLibro.TabIndex = 58;
            this.lblEstadoLibro.Text = "lblEstadoLibro";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 552F));
            this.tableLayoutPanel4.Controls.Add(this.txtBuscarLibro, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(575, 60);
            this.tableLayoutPanel4.TabIndex = 61;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
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
            this.txtBuscarLibro.Location = new System.Drawing.Point(5, 5);
            this.txtBuscarLibro.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.PasswordChar = '\0';
            this.txtBuscarLibro.PlaceholderText = "Buscar libro...";
            this.txtBuscarLibro.SelectedText = "";
            this.txtBuscarLibro.ShadowDecoration.Parent = this.txtBuscarLibro;
            this.txtBuscarLibro.Size = new System.Drawing.Size(565, 50);
            this.txtBuscarLibro.TabIndex = 62;
            this.txtBuscarLibro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarLibro_KeyDown);
            // 
            // panelregistroUsuarios
            // 
            this.panelregistroUsuarios.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelregistroUsuarios.BorderRadius = 20;
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel1);
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel3);
            this.panelregistroUsuarios.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroUsuarios.Location = new System.Drawing.Point(23, 132);
            this.panelregistroUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.panelregistroUsuarios.Name = "panelregistroUsuarios";
            this.panelregistroUsuarios.ShadowDecoration.Parent = this.panelregistroUsuarios;
            this.panelregistroUsuarios.Size = new System.Drawing.Size(575, 250);
            this.panelregistroUsuarios.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Carnet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarnetUsuario, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 80);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 148);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nombre.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(4, 78);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(135, 66);
            this.Nombre.TabIndex = 61;
            this.Nombre.Text = "Nombre:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(147, 78);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(383, 66);
            this.lblNombreUsuario.TabIndex = 55;
            this.lblNombreUsuario.Text = "lblNombreUsuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // Carnet
            // 
            this.Carnet.BackColor = System.Drawing.Color.Transparent;
            this.Carnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Carnet.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carnet.Location = new System.Drawing.Point(4, 4);
            this.Carnet.Margin = new System.Windows.Forms.Padding(4);
            this.Carnet.Name = "Carnet";
            this.Carnet.Size = new System.Drawing.Size(135, 66);
            this.Carnet.TabIndex = 60;
            this.Carnet.Text = "Carnet:";
            // 
            // lblCarnetUsuario
            // 
            this.lblCarnetUsuario.BackColor = System.Drawing.Color.White;
            this.lblCarnetUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarnetUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetUsuario.Location = new System.Drawing.Point(147, 4);
            this.lblCarnetUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.lblCarnetUsuario.Name = "lblCarnetUsuario";
            this.lblCarnetUsuario.Size = new System.Drawing.Size(383, 66);
            this.lblCarnetUsuario.TabIndex = 56;
            this.lblCarnetUsuario.Text = "lblCarnetUsuario";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 552F));
            this.tableLayoutPanel3.Controls.Add(this.txtBuscarUsuario, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(575, 72);
            this.tableLayoutPanel3.TabIndex = 60;
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
            this.txtBuscarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.FocusedState.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.HoverState.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.IconLeft = global::GestorDeBiblioteca.Properties.Resources.icons8_search_24;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(5, 5);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.PasswordChar = '\0';
            this.txtBuscarUsuario.PlaceholderText = "Buscar usuario...";
            this.txtBuscarUsuario.SelectedText = "";
            this.txtBuscarUsuario.ShadowDecoration.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.Size = new System.Drawing.Size(542, 52);
            this.txtBuscarUsuario.TabIndex = 61;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            this.txtBuscarUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyDown_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha de Devolucion";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(269, 90);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(381, 34);
            this.dtpFechaDevolucion.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.FechaPrestamo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1460, 69);
            this.panel4.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión de Prestamos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.AutoSize = true;
            this.FechaPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPrestamo.Location = new System.Drawing.Point(1270, 11);
            this.FechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Size = new System.Drawing.Size(146, 32);
            this.FechaPrestamo.TabIndex = 30;
            this.FechaPrestamo.Text = "FechaActual";
            this.FechaPrestamo.Visible = false;
            this.FechaPrestamo.Click += new System.EventHandler(this.FechaPrestamo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1035, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 32);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de Prestamo:";
            this.label7.Visible = false;
            // 
            // FrmGestionDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 714);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionDePrestamos";
            this.Text = "FrmGestionDePrestamos";
            this.Load += new System.EventHandler(this.FrmGestionDePrestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.BotonesLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
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