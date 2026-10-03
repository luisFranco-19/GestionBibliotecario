namespace GestorDeBiblioteca
{
    partial class FrmLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisenoCampo = new System.Windows.Forms.Label();
            this.txtTitulos = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDisenoCampo2 = new System.Windows.Forms.Label();
            this.txtAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDisenoCampo3 = new System.Windows.Forms.Label();
            this.txtAñoPublicacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDisenoCampo4 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDisenoCampo5 = new System.Windows.Forms.Label();
            this.cmbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDisenoCampo6 = new System.Windows.Forms.Label();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.iconReporte = new Guna.UI2.WinForms.Guna2Button();
            this.tlpDisenoRaiz = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDisenoEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisenoSeccion = new System.Windows.Forms.Label();
            this.lblDisenoTitulo = new System.Windows.Forms.Label();
            this.lblDisenoSubtitulo = new System.Windows.Forms.Label();
            this.pnlDisenoEditor = new Guna.UI2.WinForms.Guna2Panel();
            this.flpDisenoAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDisenoListado = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpDisenoListado = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisenoListado = new System.Windows.Forms.Label();
            this.lblDisenoContador = new System.Windows.Forms.Label();
            this.lblDisenoAyuda = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tlpDisenoRaiz.SuspendLayout();
            this.tlpDisenoEncabezado.SuspendLayout();
            this.pnlDisenoEditor.SuspendLayout();
            this.flpDisenoAcciones.SuspendLayout();
            this.pnlDisenoListado.SuspendLayout();
            this.tlpDisenoListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333F));
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAutor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAñoPublicacion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNacionalidad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstado, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDisenoCampo6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCantidad, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1321, 193);
            this.tableLayoutPanel1.TabIndex = 68;
            // 
            // lblDisenoCampo
            // 
            this.lblDisenoCampo.AutoEllipsis = true;
            this.lblDisenoCampo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo.Location = new System.Drawing.Point(0, 0);
            this.lblDisenoCampo.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo.Name = "lblDisenoCampo";
            this.lblDisenoCampo.Size = new System.Drawing.Size(420, 31);
            this.lblDisenoCampo.TabIndex = 0;
            this.lblDisenoCampo.Text = "Título del libro";
            this.lblDisenoCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitulos
            // 
            this.txtTitulos.AccessibleName = "Título del libro";
            this.txtTitulos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.txtTitulos.BorderRadius = 6;
            this.txtTitulos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulos.DefaultText = "";
            this.txtTitulos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtTitulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.txtTitulos.DisabledState.Parent = this.txtTitulos;
            this.txtTitulos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.txtTitulos.FocusedState.Parent = this.txtTitulos;
            this.txtTitulos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.txtTitulos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.txtTitulos.HoverState.Parent = this.txtTitulos;
            this.txtTitulos.Location = new System.Drawing.Point(0, 31);
            this.txtTitulos.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.txtTitulos.Name = "txtTitulos";
            this.txtTitulos.PasswordChar = '\0';
            this.txtTitulos.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(145)))));
            this.txtTitulos.PlaceholderText = "Título del libro";
            this.txtTitulos.SelectedText = "";
            this.txtTitulos.ShadowDecoration.Parent = this.txtTitulos;
            this.txtTitulos.Size = new System.Drawing.Size(420, 51);
            this.txtTitulos.TabIndex = 0;
            this.txtTitulos.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblDisenoCampo2
            // 
            this.lblDisenoCampo2.AutoEllipsis = true;
            this.lblDisenoCampo2.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo2.Location = new System.Drawing.Point(440, 0);
            this.lblDisenoCampo2.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo2.Name = "lblDisenoCampo2";
            this.lblDisenoCampo2.Size = new System.Drawing.Size(420, 31);
            this.lblDisenoCampo2.TabIndex = 1;
            this.lblDisenoCampo2.Text = "Autor";
            this.lblDisenoCampo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAutor
            // 
            this.txtAutor.AccessibleName = "Autor";
            this.txtAutor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.txtAutor.BorderRadius = 6;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.DefaultText = "";
            this.txtAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.txtAutor.DisabledState.Parent = this.txtAutor;
            this.txtAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.txtAutor.FocusedState.Parent = this.txtAutor;
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.txtAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.txtAutor.HoverState.Parent = this.txtAutor;
            this.txtAutor.Location = new System.Drawing.Point(440, 31);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(145)))));
            this.txtAutor.PlaceholderText = "Autor";
            this.txtAutor.SelectedText = "";
            this.txtAutor.ShadowDecoration.Parent = this.txtAutor;
            this.txtAutor.Size = new System.Drawing.Size(420, 51);
            this.txtAutor.TabIndex = 1;
            this.txtAutor.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblDisenoCampo3
            // 
            this.lblDisenoCampo3.AutoEllipsis = true;
            this.lblDisenoCampo3.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo3.Location = new System.Drawing.Point(880, 0);
            this.lblDisenoCampo3.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo3.Name = "lblDisenoCampo3";
            this.lblDisenoCampo3.Size = new System.Drawing.Size(421, 31);
            this.lblDisenoCampo3.TabIndex = 2;
            this.lblDisenoCampo3.Text = "Año de publicación";
            this.lblDisenoCampo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAñoPublicacion
            // 
            this.txtAñoPublicacion.AccessibleName = "Año de publicación";
            this.txtAñoPublicacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.txtAñoPublicacion.BorderRadius = 6;
            this.txtAñoPublicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAñoPublicacion.DefaultText = "";
            this.txtAñoPublicacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAñoPublicacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtAñoPublicacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.txtAñoPublicacion.DisabledState.Parent = this.txtAñoPublicacion;
            this.txtAñoPublicacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAñoPublicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAñoPublicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.txtAñoPublicacion.FocusedState.Parent = this.txtAñoPublicacion;
            this.txtAñoPublicacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAñoPublicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.txtAñoPublicacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.txtAñoPublicacion.HoverState.Parent = this.txtAñoPublicacion;
            this.txtAñoPublicacion.Location = new System.Drawing.Point(880, 31);
            this.txtAñoPublicacion.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.txtAñoPublicacion.Name = "txtAñoPublicacion";
            this.txtAñoPublicacion.PasswordChar = '\0';
            this.txtAñoPublicacion.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(145)))));
            this.txtAñoPublicacion.PlaceholderText = "Año de publicación";
            this.txtAñoPublicacion.SelectedText = "";
            this.txtAñoPublicacion.ShadowDecoration.Parent = this.txtAñoPublicacion;
            this.txtAñoPublicacion.Size = new System.Drawing.Size(421, 51);
            this.txtAñoPublicacion.TabIndex = 2;
            this.txtAñoPublicacion.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblDisenoCampo4
            // 
            this.lblDisenoCampo4.AutoEllipsis = true;
            this.lblDisenoCampo4.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo4.Location = new System.Drawing.Point(0, 92);
            this.lblDisenoCampo4.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo4.Name = "lblDisenoCampo4";
            this.lblDisenoCampo4.Size = new System.Drawing.Size(420, 31);
            this.lblDisenoCampo4.TabIndex = 3;
            this.lblDisenoCampo4.Text = "Nacionalidad del autor";
            this.lblDisenoCampo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.AccessibleName = "Nacionalidad del autor";
            this.txtNacionalidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.txtNacionalidad.BorderRadius = 6;
            this.txtNacionalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNacionalidad.DefaultText = "";
            this.txtNacionalidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNacionalidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtNacionalidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.txtNacionalidad.DisabledState.Parent = this.txtNacionalidad;
            this.txtNacionalidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNacionalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNacionalidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.txtNacionalidad.FocusedState.Parent = this.txtNacionalidad;
            this.txtNacionalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNacionalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.txtNacionalidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.txtNacionalidad.HoverState.Parent = this.txtNacionalidad;
            this.txtNacionalidad.Location = new System.Drawing.Point(0, 123);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PasswordChar = '\0';
            this.txtNacionalidad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(145)))));
            this.txtNacionalidad.PlaceholderText = "Nacionalidad del autor";
            this.txtNacionalidad.SelectedText = "";
            this.txtNacionalidad.ShadowDecoration.Parent = this.txtNacionalidad;
            this.txtNacionalidad.Size = new System.Drawing.Size(420, 60);
            this.txtNacionalidad.TabIndex = 3;
            this.txtNacionalidad.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblDisenoCampo5
            // 
            this.lblDisenoCampo5.AutoEllipsis = true;
            this.lblDisenoCampo5.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo5.Location = new System.Drawing.Point(440, 92);
            this.lblDisenoCampo5.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo5.Name = "lblDisenoCampo5";
            this.lblDisenoCampo5.Size = new System.Drawing.Size(420, 31);
            this.lblDisenoCampo5.TabIndex = 4;
            this.lblDisenoCampo5.Text = "Estado";
            this.lblDisenoCampo5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AccessibleName = "Estado";
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.cmbEstado.BorderRadius = 6;
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.cmbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.cmbEstado.FocusedState.Parent = this.cmbEstado;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.HoverState.Parent = this.cmbEstado;
            this.cmbEstado.ItemHeight = 35;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.ItemsAppearance.Parent = this.cmbEstado;
            this.cmbEstado.Location = new System.Drawing.Point(440, 123);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.ShadowDecoration.Parent = this.cmbEstado;
            this.cmbEstado.Size = new System.Drawing.Size(420, 41);
            this.cmbEstado.TabIndex = 4;
            // 
            // lblDisenoCampo6
            // 
            this.lblDisenoCampo6.AutoEllipsis = true;
            this.lblDisenoCampo6.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoCampo6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoCampo6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoCampo6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoCampo6.Location = new System.Drawing.Point(880, 92);
            this.lblDisenoCampo6.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblDisenoCampo6.Name = "lblDisenoCampo6";
            this.lblDisenoCampo6.Size = new System.Drawing.Size(421, 31);
            this.lblDisenoCampo6.TabIndex = 5;
            this.lblDisenoCampo6.Text = "Ejemplares disponibles";
            this.lblDisenoCampo6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AccessibleName = "Ejemplares disponibles";
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.txtCantidad.BorderRadius = 6;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.txtCantidad.HoverState.Parent = this.txtCantidad;
            this.txtCantidad.Location = new System.Drawing.Point(880, 123);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(145)))));
            this.txtCantidad.PlaceholderText = "Ejemplares disponibles";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(421, 60);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListado.ColumnHeadersHeight = 42;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.dgvListado.Location = new System.Drawing.Point(0, 44);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(0);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 38;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(1329, 293);
            this.dgvListado.TabIndex = 38;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 15;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(0, 0);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(1, 1);
            this.txtId.TabIndex = 74;
            this.txtId.Visible = false;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleName = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.btnActualizar.BorderRadius = 7;
            this.btnActualizar.BorderThickness = 1;
            this.btnActualizar.CheckedState.Parent = this.btnActualizar;
            this.btnActualizar.CustomImages.Parent = this.btnActualizar;
            this.btnActualizar.FillColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btnActualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.btnActualizar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btnActualizar.HoverState.Parent = this.btnActualizar;
            this.btnActualizar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnActualizar.Location = new System.Drawing.Point(202, 2);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnActualizar.MinimumSize = new System.Drawing.Size(160, 52);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnActualizar.ShadowDecoration.Parent = this.btnActualizar;
            this.btnActualizar.Size = new System.Drawing.Size(160, 52);
            this.btnActualizar.TabIndex = 65;
            this.btnActualizar.Text = "Actualizar";
            this.toolTip1.SetToolTip(this.btnActualizar, "Actualizar Registro");
            this.toolTip1.SetToolTip(this.btnActualizar, "Actualizar Registro");
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleName = "Limpiar";
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.btnCancelar.BorderRadius = 7;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.btnCancelar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.Location = new System.Drawing.Point(374, 2);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(135, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 52);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Registro");
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Registro");
            this.btnCancelar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleName = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(215)))));
            this.btnEliminar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEliminar.Location = new System.Drawing.Point(521, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(135, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(135, 52);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar Registro");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar Registro");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleName = "Guardar libro";
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.btnAceptar.BorderRadius = 7;
            this.btnAceptar.CheckedState.Parent = this.btnAceptar;
            this.btnAceptar.CustomImages.Parent = this.btnAceptar;
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.btnAceptar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.HoverState.Parent = this.btnAceptar;
            this.btnAceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.Location = new System.Drawing.Point(0, 2);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(190, 52);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.btnAceptar.ShadowDecoration.Parent = this.btnAceptar;
            this.btnAceptar.Size = new System.Drawing.Size(190, 52);
            this.btnAceptar.TabIndex = 63;
            this.btnAceptar.Text = "Guardar libro";
            this.toolTip1.SetToolTip(this.btnAceptar, "Guardar Registro");
            this.toolTip1.SetToolTip(this.btnAceptar, "Guardar Registro");
            this.btnAceptar.Click += new System.EventHandler(this.btnAcepatr_Click);
            // 
            // iconReporte
            // 
            this.iconReporte.AccessibleName = "Ver reporte";
            this.iconReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconReporte.BackColor = System.Drawing.Color.Transparent;
            this.iconReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.iconReporte.BorderRadius = 7;
            this.iconReporte.BorderThickness = 1;
            this.iconReporte.CheckedState.Parent = this.iconReporte;
            this.iconReporte.CustomImages.Parent = this.iconReporte;
            this.iconReporte.FillColor = System.Drawing.Color.White;
            this.iconReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.iconReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconReporte.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.iconReporte.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.iconReporte.HoverState.Parent = this.iconReporte;
            this.iconReporte.ImageSize = new System.Drawing.Size(30, 30);
            this.iconReporte.Location = new System.Drawing.Point(668, 2);
            this.iconReporte.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.iconReporte.MinimumSize = new System.Drawing.Size(172, 52);
            this.iconReporte.Name = "iconReporte";
            this.iconReporte.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.iconReporte.ShadowDecoration.Parent = this.iconReporte;
            this.iconReporte.Size = new System.Drawing.Size(172, 52);
            this.iconReporte.TabIndex = 75;
            this.iconReporte.Text = "Ver reporte";
            this.toolTip1.SetToolTip(this.iconReporte, "Reporte del stock de libros");
            this.toolTip1.SetToolTip(this.iconReporte, "Reporte del stock de libros");
            this.iconReporte.Click += new System.EventHandler(this.iconReporte_Click_1);
            // 
            // tlpDisenoRaiz
            // 
            this.tlpDisenoRaiz.BackColor = System.Drawing.Color.Transparent;
            this.tlpDisenoRaiz.ColumnCount = 1;
            this.tlpDisenoRaiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoRaiz.Controls.Add(this.tlpDisenoEncabezado, 0, 0);
            this.tlpDisenoRaiz.Controls.Add(this.pnlDisenoEditor, 0, 1);
            this.tlpDisenoRaiz.Controls.Add(this.flpDisenoAcciones, 0, 2);
            this.tlpDisenoRaiz.Controls.Add(this.pnlDisenoListado, 0, 3);
            this.tlpDisenoRaiz.Controls.Add(this.lblDisenoAyuda, 0, 4);
            this.tlpDisenoRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisenoRaiz.Location = new System.Drawing.Point(0, 0);
            this.tlpDisenoRaiz.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDisenoRaiz.Name = "tlpDisenoRaiz";
            this.tlpDisenoRaiz.Padding = new System.Windows.Forms.Padding(30, 20, 30, 18);
            this.tlpDisenoRaiz.RowCount = 5;
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDisenoRaiz.Size = new System.Drawing.Size(1425, 925);
            this.tlpDisenoRaiz.TabIndex = 0;
            // 
            // tlpDisenoEncabezado
            // 
            this.tlpDisenoEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.tlpDisenoEncabezado.ColumnCount = 1;
            this.tlpDisenoEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoSeccion, 0, 0);
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoTitulo, 0, 1);
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoSubtitulo, 0, 2);
            this.tlpDisenoEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisenoEncabezado.Location = new System.Drawing.Point(30, 20);
            this.tlpDisenoEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tlpDisenoEncabezado.Name = "tlpDisenoEncabezado";
            this.tlpDisenoEncabezado.RowCount = 3;
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDisenoEncabezado.Size = new System.Drawing.Size(1365, 108);
            this.tlpDisenoEncabezado.TabIndex = 0;
            // 
            // lblDisenoSeccion
            // 
            this.lblDisenoSeccion.AutoEllipsis = true;
            this.lblDisenoSeccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoSeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblDisenoSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(113)))), ((int)(((byte)(55)))));
            this.lblDisenoSeccion.Location = new System.Drawing.Point(0, 0);
            this.lblDisenoSeccion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoSeccion.Name = "lblDisenoSeccion";
            this.lblDisenoSeccion.Size = new System.Drawing.Size(1365, 25);
            this.lblDisenoSeccion.TabIndex = 0;
            this.lblDisenoSeccion.Text = "COLECCIÓN";
            this.lblDisenoSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisenoTitulo
            // 
            this.lblDisenoTitulo.AutoEllipsis = true;
            this.lblDisenoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoTitulo.Font = new System.Drawing.Font("Georgia", 25F);
            this.lblDisenoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.lblDisenoTitulo.Location = new System.Drawing.Point(0, 25);
            this.lblDisenoTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoTitulo.Name = "lblDisenoTitulo";
            this.lblDisenoTitulo.Size = new System.Drawing.Size(1365, 52);
            this.lblDisenoTitulo.TabIndex = 1;
            this.lblDisenoTitulo.Text = "Catálogo de libros";
            this.lblDisenoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisenoSubtitulo
            // 
            this.lblDisenoSubtitulo.AutoEllipsis = true;
            this.lblDisenoSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisenoSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoSubtitulo.Location = new System.Drawing.Point(0, 77);
            this.lblDisenoSubtitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoSubtitulo.Name = "lblDisenoSubtitulo";
            this.lblDisenoSubtitulo.Size = new System.Drawing.Size(1365, 31);
            this.lblDisenoSubtitulo.TabIndex = 2;
            this.lblDisenoSubtitulo.Text = "Organiza títulos, autores y ejemplares disponibles.";
            this.lblDisenoSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDisenoEditor
            // 
            this.pnlDisenoEditor.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisenoEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.pnlDisenoEditor.BorderRadius = 12;
            this.pnlDisenoEditor.BorderThickness = 1;
            this.pnlDisenoEditor.Controls.Add(this.tableLayoutPanel1);
            this.pnlDisenoEditor.Controls.Add(this.txtId);
            this.pnlDisenoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisenoEditor.FillColor = System.Drawing.Color.White;
            this.pnlDisenoEditor.Location = new System.Drawing.Point(30, 140);
            this.pnlDisenoEditor.Margin = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pnlDisenoEditor.Name = "pnlDisenoEditor";
            this.pnlDisenoEditor.Padding = new System.Windows.Forms.Padding(22);
            this.pnlDisenoEditor.ShadowDecoration.Parent = this.pnlDisenoEditor;
            this.pnlDisenoEditor.Size = new System.Drawing.Size(1365, 237);
            this.pnlDisenoEditor.TabIndex = 1;
            // 
            // flpDisenoAcciones
            // 
            this.flpDisenoAcciones.BackColor = System.Drawing.Color.Transparent;
            this.flpDisenoAcciones.Controls.Add(this.btnAceptar);
            this.flpDisenoAcciones.Controls.Add(this.btnActualizar);
            this.flpDisenoAcciones.Controls.Add(this.btnCancelar);
            this.flpDisenoAcciones.Controls.Add(this.btnEliminar);
            this.flpDisenoAcciones.Controls.Add(this.iconReporte);
            this.flpDisenoAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDisenoAcciones.Location = new System.Drawing.Point(30, 395);
            this.flpDisenoAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpDisenoAcciones.Name = "flpDisenoAcciones";
            this.flpDisenoAcciones.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flpDisenoAcciones.Size = new System.Drawing.Size(1365, 72);
            this.flpDisenoAcciones.TabIndex = 2;
            this.flpDisenoAcciones.WrapContents = false;
            // 
            // pnlDisenoListado
            // 
            this.pnlDisenoListado.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisenoListado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.pnlDisenoListado.BorderRadius = 12;
            this.pnlDisenoListado.BorderThickness = 1;
            this.pnlDisenoListado.Controls.Add(this.tlpDisenoListado);
            this.pnlDisenoListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisenoListado.FillColor = System.Drawing.Color.White;
            this.pnlDisenoListado.Location = new System.Drawing.Point(30, 467);
            this.pnlDisenoListado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisenoListado.Name = "pnlDisenoListado";
            this.pnlDisenoListado.Padding = new System.Windows.Forms.Padding(18);
            this.pnlDisenoListado.ShadowDecoration.Parent = this.pnlDisenoListado;
            this.pnlDisenoListado.Size = new System.Drawing.Size(1365, 405);
            this.pnlDisenoListado.TabIndex = 3;
            // 
            // tlpDisenoListado
            // 
            this.tlpDisenoListado.BackColor = System.Drawing.Color.Transparent;
            this.tlpDisenoListado.ColumnCount = 1;
            this.tlpDisenoListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoListado.Controls.Add(this.lblDisenoListado, 0, 0);
            this.tlpDisenoListado.Controls.Add(this.dgvListado, 0, 1);
            this.tlpDisenoListado.Controls.Add(this.lblDisenoContador, 0, 2);
            this.tlpDisenoListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisenoListado.Location = new System.Drawing.Point(18, 18);
            this.tlpDisenoListado.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDisenoListado.Name = "tlpDisenoListado";
            this.tlpDisenoListado.RowCount = 3;
            this.tlpDisenoListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpDisenoListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpDisenoListado.Size = new System.Drawing.Size(1329, 369);
            this.tlpDisenoListado.TabIndex = 0;
            // 
            // lblDisenoListado
            // 
            this.lblDisenoListado.AutoEllipsis = true;
            this.lblDisenoListado.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoListado.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDisenoListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.lblDisenoListado.Location = new System.Drawing.Point(0, 0);
            this.lblDisenoListado.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoListado.Name = "lblDisenoListado";
            this.lblDisenoListado.Size = new System.Drawing.Size(1329, 44);
            this.lblDisenoListado.TabIndex = 0;
            this.lblDisenoListado.Text = "Inventario de la biblioteca";
            this.lblDisenoListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisenoContador
            // 
            this.lblDisenoContador.AutoEllipsis = true;
            this.lblDisenoContador.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoContador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoContador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisenoContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoContador.Location = new System.Drawing.Point(0, 337);
            this.lblDisenoContador.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoContador.Name = "lblDisenoContador";
            this.lblDisenoContador.Size = new System.Drawing.Size(1329, 32);
            this.lblDisenoContador.TabIndex = 39;
            this.lblDisenoContador.Text = "Sin registros para mostrar";
            this.lblDisenoContador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisenoAyuda
            // 
            this.lblDisenoAyuda.AutoEllipsis = true;
            this.lblDisenoAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDisenoAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(120)))));
            this.lblDisenoAyuda.Location = new System.Drawing.Point(30, 872);
            this.lblDisenoAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisenoAyuda.Name = "lblDisenoAyuda";
            this.lblDisenoAyuda.Size = new System.Drawing.Size(1365, 35);
            this.lblDisenoAyuda.TabIndex = 4;
            this.lblDisenoAyuda.Text = "Haz doble clic en un libro para actualizar su información.";
            this.lblDisenoAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1425, 925);
            this.Controls.Add(this.tlpDisenoRaiz);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1120, 801);
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo | Biblioteca";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.Shown += new System.EventHandler(this.FrmLibros_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tlpDisenoRaiz.ResumeLayout(false);
            this.tlpDisenoEncabezado.ResumeLayout(false);
            this.pnlDisenoEditor.ResumeLayout(false);
            this.flpDisenoAcciones.ResumeLayout(false);
            this.pnlDisenoListado.ResumeLayout(false);
            this.tlpDisenoListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulos;
        private Guna.UI2.WinForms.Guna2TextBox txtAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtNacionalidad;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtAñoPublicacion;
        private Guna.UI2.WinForms.Guna2Button iconReporte;

        private System.Windows.Forms.TableLayoutPanel tlpDisenoRaiz;
        private System.Windows.Forms.TableLayoutPanel tlpDisenoEncabezado;
        private System.Windows.Forms.Label lblDisenoSeccion;
        private System.Windows.Forms.Label lblDisenoTitulo;
        private System.Windows.Forms.Label lblDisenoSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlDisenoEditor;
        private System.Windows.Forms.Label lblDisenoCampo;
        private System.Windows.Forms.Label lblDisenoCampo2;
        private System.Windows.Forms.Label lblDisenoCampo3;
        private System.Windows.Forms.Label lblDisenoCampo4;
        private System.Windows.Forms.Label lblDisenoCampo5;
        private System.Windows.Forms.Label lblDisenoCampo6;
        private System.Windows.Forms.FlowLayoutPanel flpDisenoAcciones;
        private Guna.UI2.WinForms.Guna2Panel pnlDisenoListado;
        private System.Windows.Forms.TableLayoutPanel tlpDisenoListado;
        private System.Windows.Forms.Label lblDisenoListado;
        private System.Windows.Forms.Label lblDisenoContador;
        private System.Windows.Forms.Label lblDisenoAyuda;
    }
}
