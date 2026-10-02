namespace GestorDeBiblioteca
{
    partial class FrmPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvPrestamos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelregistroLibros = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Autor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Estado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAutorLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTituloLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEstadoLibro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelregistroUsuarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Nombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Carnet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCarnetUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.BotonesLayout.SuspendLayout();
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
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpFechaDevolucion);
            this.panel3.Controls.Add(this.dgvPrestamos);
            this.panel3.Controls.Add(this.BotonesLayout);
            this.panel3.Controls.Add(this.panelregistroLibros);
            this.panel3.Controls.Add(this.panelregistroUsuarios);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 623);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Historial de Prestamos del Usuario";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDevolucion.BackColor = System.Drawing.Color.White;
            this.dtpFechaDevolucion.BorderRadius = 16;
            this.dtpFechaDevolucion.CheckedState.Parent = this.dtpFechaDevolucion;
            this.dtpFechaDevolucion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(128)))));
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaDevolucion.HoverState.Parent = this.dtpFechaDevolucion;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(780, 54);
            this.dtpFechaDevolucion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDevolucion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.ShadowDecoration.Parent = this.dtpFechaDevolucion;
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(329, 36);
            this.dtpFechaDevolucion.TabIndex = 66;
            this.toolTip1.SetToolTip(this.dtpFechaDevolucion, "Fecha de devolucion del prestamo");
            this.dtpFechaDevolucion.Value = new System.DateTime(2025, 10, 25, 17, 16, 27, 136);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrestamos.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.Location = new System.Drawing.Point(523, 153);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(559, 329);
            this.dgvPrestamos.TabIndex = 67;
            this.dgvPrestamos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPrestamos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPrestamos.ThemeStyle.ReadOnly = true;
            this.dgvPrestamos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrestamos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrestamos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPrestamos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonesLayout.ColumnCount = 2;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Controls.Add(this.btnCancelar, 1, 0);
            this.BotonesLayout.Controls.Add(this.btnAgregar, 0, 0);
            this.BotonesLayout.Location = new System.Drawing.Point(20, 542);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BotonesLayout.Size = new System.Drawing.Size(385, 54);
            this.BotonesLayout.TabIndex = 65;
            // 
            // panelregistroLibros
            // 
            this.panelregistroLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelregistroLibros.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelregistroLibros.BorderRadius = 20;
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel2);
            this.panelregistroLibros.Controls.Add(this.tableLayoutPanel4);
            this.panelregistroLibros.CustomBorderColor = System.Drawing.Color.White;
            this.panelregistroLibros.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroLibros.Location = new System.Drawing.Point(16, 290);
            this.panelregistroLibros.Name = "panelregistroLibros";
            this.panelregistroLibros.ShadowDecoration.Parent = this.panelregistroLibros;
            this.panelregistroLibros.Size = new System.Drawing.Size(431, 246);
            this.panelregistroLibros.TabIndex = 62;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Autor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Estado, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAutorLibro, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloLibro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEstadoLibro, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.79953F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.04843F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.15203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(431, 188);
            this.tableLayoutPanel2.TabIndex = 55;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(3, 3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(62, 25);
            this.Titulo.TabIndex = 61;
            this.Titulo.Text = "Titulo:";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Autor
            // 
            this.Autor.BackColor = System.Drawing.Color.Transparent;
            this.Autor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(3, 66);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(59, 25);
            this.Autor.TabIndex = 62;
            this.Autor.Text = "Autor:";
            // 
            // Estado
            // 
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(3, 128);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(68, 25);
            this.Estado.TabIndex = 63;
            this.Estado.Text = "Estado:";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAutorLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(127, 66);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(108, 21);
            this.lblAutorLibro.TabIndex = 57;
            this.lblAutorLibro.Text = "lblAutorLibro";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTituloLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(127, 3);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(110, 21);
            this.lblTituloLibro.TabIndex = 56;
            this.lblTituloLibro.Text = "lblTituloLibro";
            // 
            // lblEstadoLibro
            // 
            this.lblEstadoLibro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadoLibro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLibro.Location = new System.Drawing.Point(127, 128);
            this.lblEstadoLibro.Name = "lblEstadoLibro";
            this.lblEstadoLibro.Size = new System.Drawing.Size(116, 21);
            this.lblEstadoLibro.TabIndex = 58;
            this.lblEstadoLibro.Text = "lblEstadoLibro";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel4.Controls.Add(this.txtBuscarLibro, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(431, 58);
            this.tableLayoutPanel4.TabIndex = 61;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // panelregistroUsuarios
            // 
            this.panelregistroUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelregistroUsuarios.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelregistroUsuarios.BorderRadius = 20;
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel1);
            this.panelregistroUsuarios.Controls.Add(this.tableLayoutPanel3);
            this.panelregistroUsuarios.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelregistroUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.panelregistroUsuarios.Location = new System.Drawing.Point(16, 64);
            this.panelregistroUsuarios.Name = "panelregistroUsuarios";
            this.panelregistroUsuarios.ShadowDecoration.Parent = this.panelregistroUsuarios;
            this.panelregistroUsuarios.Size = new System.Drawing.Size(431, 211);
            this.panelregistroUsuarios.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Carnet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarnetUsuario, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 153);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(3, 79);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 25);
            this.Nombre.TabIndex = 61;
            this.Nombre.Text = "Nombre:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(110, 79);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(146, 21);
            this.lblNombreUsuario.TabIndex = 55;
            this.lblNombreUsuario.Text = "lblNombreUsuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
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
            // lblCarnetUsuario
            // 
            this.lblCarnetUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCarnetUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetUsuario.Location = new System.Drawing.Point(110, 3);
            this.lblCarnetUsuario.Name = "lblCarnetUsuario";
            this.lblCarnetUsuario.Size = new System.Drawing.Size(135, 21);
            this.lblCarnetUsuario.TabIndex = 56;
            this.lblCarnetUsuario.Text = "lblCarnetUsuario";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel3.Controls.Add(this.txtBuscarUsuario, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(431, 58);
            this.tableLayoutPanel3.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1121, 48);
            this.panel4.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión de Prestamos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 6;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = global::GestorDeBiblioteca.Properties.Resources.eed2;
            this.btnAgregar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(186, 48);
            this.btnAgregar.TabIndex = 63;
            this.btnAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Confirmar Prestamo");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BorderRadius = 6;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::GestorDeBiblioteca.Properties.Resources.sasad3;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.Location = new System.Drawing.Point(195, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(187, 48);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Prestamo");
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
            this.txtBuscarLibro.Size = new System.Drawing.Size(406, 41);
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
            this.txtBuscarUsuario.PlaceholderText = "Buscar usuarios...";
            this.txtBuscarUsuario.SelectedText = "";
            this.txtBuscarUsuario.ShadowDecoration.Parent = this.txtBuscarUsuario;
            this.txtBuscarUsuario.Size = new System.Drawing.Size(406, 41);
            this.txtBuscarUsuario.TabIndex = 63;
            this.txtBuscarUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyDown);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 623);
            this.Controls.Add(this.panel3);
            this.Name = "FrmPrestamos";
            this.Text = "FrmGestionDePrestamos";
            this.Load += new System.EventHandler(this.FrmGestionDePrestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.BotonesLayout.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2GradientPanel panelregistroLibros;
        private Guna.UI2.WinForms.Guna2HtmlLabel Nombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2GradientPanel panelregistroUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaDevolucion;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrestamos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUsuario;
    }
}