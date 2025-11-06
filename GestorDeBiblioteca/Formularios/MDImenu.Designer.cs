namespace GestorDeBiblioteca
{
    partial class MDImenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLibro = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrestamo = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBloquearMenu = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnDevolucion = new Guna.UI2.WinForms.Guna2Button();
            this.panelSiderbar = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSuperior = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelSiderbar.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLibro
            // 
            this.btnLibro.CheckedState.Parent = this.btnLibro;
            this.btnLibro.CustomImages.Parent = this.btnLibro;
            this.btnLibro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.HoverState.Parent = this.btnLibro;
            this.btnLibro.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_libros_100;
            this.btnLibro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLibro.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLibro.Location = new System.Drawing.Point(3, 334);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.ShadowDecoration.Parent = this.btnLibro;
            this.btnLibro.Size = new System.Drawing.Size(160, 61);
            this.btnLibro.TabIndex = 1;
            this.btnLibro.Text = "Libros";
            this.toolTip.SetToolTip(this.btnLibro, "Registar Libros");
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightBlue;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_control_panel_100;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(3, 166);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(160, 61);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.toolTip.SetToolTip(this.btnDashboard, "Registro Bibliotecario");
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.CheckedState.Parent = this.btnPrestamo;
            this.btnPrestamo.CustomImages.Parent = this.btnPrestamo;
            this.btnPrestamo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.HoverState.Parent = this.btnPrestamo;
            this.btnPrestamo.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_libros_100__1_;
            this.btnPrestamo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrestamo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrestamo.Location = new System.Drawing.Point(3, 422);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.ShadowDecoration.Parent = this.btnPrestamo;
            this.btnPrestamo.Size = new System.Drawing.Size(160, 61);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "Prestamo";
            this.toolTip.SetToolTip(this.btnPrestamo, "Registar Un Prestamo");
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.CheckedState.Parent = this.btnUsuario;
            this.btnUsuario.CustomImages.Parent = this.btnUsuario;
            this.btnUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.HoverState.Parent = this.btnUsuario;
            this.btnUsuario.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_customer_100;
            this.btnUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuario.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsuario.Location = new System.Drawing.Point(3, 242);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.ShadowDecoration.Parent = this.btnUsuario;
            this.btnUsuario.Size = new System.Drawing.Size(160, 61);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuarios";
            this.toolTip.SetToolTip(this.btnUsuario, "Registar Usuarios");
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prestamos ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GestorDeBiblioteca.Properties.Resources.Gemini_Generated_Image_wa9p0swa9p0swa9p_Photoroom1;
            this.picLogo.Location = new System.Drawing.Point(-2, -35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(170, 155);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnBloquearMenu
            // 
            this.btnBloquearMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBloquearMenu.CheckedState.Parent = this.btnBloquearMenu;
            this.btnBloquearMenu.CustomImages.Parent = this.btnBloquearMenu;
            this.btnBloquearMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnBloquearMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBloquearMenu.ForeColor = System.Drawing.Color.White;
            this.btnBloquearMenu.HoverState.Parent = this.btnBloquearMenu;
            this.btnBloquearMenu.Image = global::GestorDeBiblioteca.Properties.Resources.icon_lock_322;
            this.btnBloquearMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBloquearMenu.Location = new System.Drawing.Point(855, 3);
            this.btnBloquearMenu.Name = "btnBloquearMenu";
            this.btnBloquearMenu.ShadowDecoration.Parent = this.btnBloquearMenu;
            this.btnBloquearMenu.Size = new System.Drawing.Size(34, 36);
            this.btnBloquearMenu.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnBloquearMenu, "Bloquear App");
            this.btnBloquearMenu.Click += new System.EventHandler(this.btnBloquearMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Location = new System.Drawing.Point(166, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(911, 704);
            this.panelContenedor.TabIndex = 20;
            // 
            // btnSalir
            // 
            this.btnSalir.CheckedState.Parent = this.btnSalir;
            this.btnSalir.CustomImages.Parent = this.btnSalir;
            this.btnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverState.Parent = this.btnSalir;
            this.btnSalir.Image = global::GestorDeBiblioteca.Properties.Resources.icon_salida_48;
            this.btnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSalir.Location = new System.Drawing.Point(3, 613);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ShadowDecoration.Parent = this.btnSalir;
            this.btnSalir.Size = new System.Drawing.Size(160, 61);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.toolTip.SetToolTip(this.btnSalir, "Cerrar App");
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.CheckedState.Parent = this.btnDevolucion;
            this.btnDevolucion.CustomImages.Parent = this.btnDevolucion;
            this.btnDevolucion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.HoverState.Parent = this.btnDevolucion;
            this.btnDevolucion.Image = global::GestorDeBiblioteca.Properties.Resources.icon_actualizar_48;
            this.btnDevolucion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDevolucion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDevolucion.Location = new System.Drawing.Point(3, 517);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.ShadowDecoration.Parent = this.btnDevolucion;
            this.btnDevolucion.Size = new System.Drawing.Size(160, 61);
            this.btnDevolucion.TabIndex = 0;
            this.btnDevolucion.Text = "Devolucion";
            this.toolTip.SetToolTip(this.btnDevolucion, "Devoluvion Del Prestamo");
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // panelSiderbar
            // 
            this.panelSiderbar.BackColor = System.Drawing.Color.Transparent;
            this.panelSiderbar.BorderColor = System.Drawing.Color.White;
            this.panelSiderbar.BorderRadius = 20;
            this.panelSiderbar.BorderThickness = 1;
            this.panelSiderbar.Controls.Add(this.picLogo);
            this.panelSiderbar.Controls.Add(this.btnDashboard);
            this.panelSiderbar.Controls.Add(this.btnPrestamo);
            this.panelSiderbar.Controls.Add(this.btnDevolucion);
            this.panelSiderbar.Controls.Add(this.btnSalir);
            this.panelSiderbar.Controls.Add(this.btnLibro);
            this.panelSiderbar.Controls.Add(this.label1);
            this.panelSiderbar.Controls.Add(this.btnUsuario);
            this.panelSiderbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSiderbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panelSiderbar.Location = new System.Drawing.Point(0, 0);
            this.panelSiderbar.Name = "panelSiderbar";
            this.panelSiderbar.ShadowDecoration.Parent = this.panelSiderbar;
            this.panelSiderbar.Size = new System.Drawing.Size(166, 749);
            this.panelSiderbar.TabIndex = 1;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BorderColor = System.Drawing.Color.White;
            this.panelSuperior.BorderRadius = 10;
            this.panelSuperior.BorderThickness = 1;
            this.panelSuperior.Controls.Add(this.btnBloquearMenu);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panelSuperior.Location = new System.Drawing.Point(166, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.ShadowDecoration.Parent = this.panelSuperior;
            this.panelSuperior.Size = new System.Drawing.Size(911, 49);
            this.panelSuperior.TabIndex = 0;
            // 
            // MDImenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 749);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelSiderbar);
            this.Controls.Add(this.panelContenedor);
            this.IsMdiContainer = true;
            this.Name = "MDImenu";
            this.Text = "MDImenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelSiderbar.ResumeLayout(false);
            this.panelSiderbar.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2Button btnLibro;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnPrestamo;
        private Guna.UI2.WinForms.Guna2Button btnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnBloquearMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2Button btnDevolucion;
        private Guna.UI2.WinForms.Guna2Panel panelSiderbar;
        private Guna.UI2.WinForms.Guna2Panel panelSuperior;
    }
}



