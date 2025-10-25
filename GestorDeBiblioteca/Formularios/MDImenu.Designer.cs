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
            this.panelSiderbar = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnLibro = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrestamo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDevolucion = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSiderbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSiderbar
            // 
            this.panelSiderbar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSiderbar.Controls.Add(this.btnDashboard);
            this.panelSiderbar.Controls.Add(this.btnSalir);
            this.panelSiderbar.Controls.Add(this.btnUsuario);
            this.panelSiderbar.Controls.Add(this.btnLibro);
            this.panelSiderbar.Controls.Add(this.btnPrestamo);
            this.panelSiderbar.Controls.Add(this.btnDevolucion);
            this.panelSiderbar.Controls.Add(this.label1);
            this.panelSiderbar.Controls.Add(this.picLogo);
            this.panelSiderbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSiderbar.Location = new System.Drawing.Point(0, 0);
            this.panelSiderbar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSiderbar.Name = "panelSiderbar";
            this.panelSiderbar.Size = new System.Drawing.Size(221, 838);
            this.panelSiderbar.TabIndex = 15;
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_control_panel_100;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 225);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(221, 75);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.CheckedState.Parent = this.btnSalir;
            this.btnSalir.CustomImages.Parent = this.btnSalir;
            this.btnSalir.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverState.Parent = this.btnSalir;
            this.btnSalir.Image = global::GestorDeBiblioteca.Properties.Resources.icon_salida_48;
            this.btnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSalir.Location = new System.Drawing.Point(0, 759);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ShadowDecoration.Parent = this.btnSalir;
            this.btnSalir.Size = new System.Drawing.Size(221, 75);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.CheckedState.Parent = this.btnUsuario;
            this.btnUsuario.CustomImages.Parent = this.btnUsuario;
            this.btnUsuario.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.HoverState.Parent = this.btnUsuario;
            this.btnUsuario.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_customer_100;
            this.btnUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuario.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsuario.Location = new System.Drawing.Point(-3, 323);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.ShadowDecoration.Parent = this.btnUsuario;
            this.btnUsuario.Size = new System.Drawing.Size(221, 75);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.CheckedState.Parent = this.btnLibro;
            this.btnLibro.CustomImages.Parent = this.btnLibro;
            this.btnLibro.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.HoverState.Parent = this.btnLibro;
            this.btnLibro.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_libros_100;
            this.btnLibro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLibro.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLibro.Location = new System.Drawing.Point(0, 427);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.ShadowDecoration.Parent = this.btnLibro;
            this.btnLibro.Size = new System.Drawing.Size(221, 75);
            this.btnLibro.TabIndex = 1;
            this.btnLibro.Text = "Libros";
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.CheckedState.Parent = this.btnPrestamo;
            this.btnPrestamo.CustomImages.Parent = this.btnPrestamo;
            this.btnPrestamo.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.HoverState.Parent = this.btnPrestamo;
            this.btnPrestamo.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_libros_100__1_;
            this.btnPrestamo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrestamo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrestamo.Location = new System.Drawing.Point(0, 533);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.ShadowDecoration.Parent = this.btnPrestamo;
            this.btnPrestamo.Size = new System.Drawing.Size(221, 75);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.CheckedState.Parent = this.btnDevolucion;
            this.btnDevolucion.CustomImages.Parent = this.btnDevolucion;
            this.btnDevolucion.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.HoverState.Parent = this.btnDevolucion;
            this.btnDevolucion.Image = global::GestorDeBiblioteca.Properties.Resources.icon_actualizar_48;
            this.btnDevolucion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDevolucion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDevolucion.Location = new System.Drawing.Point(0, 647);
            this.btnDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.ShadowDecoration.Parent = this.btnDevolucion;
            this.btnDevolucion.Size = new System.Drawing.Size(221, 75);
            this.btnDevolucion.TabIndex = 0;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prestamos ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GestorDeBiblioteca.Properties.Resources.Logo__2_;
            this.picLogo.Location = new System.Drawing.Point(-41, -37);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(301, 254);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(221, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1464, 43);
            this.panelSuperior.TabIndex = 18;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(221, 43);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1464, 795);
            this.panelContenedor.TabIndex = 20;
            // 
            // MDImenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelSiderbar);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDImenu";
            this.Text = "MDImenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSiderbar.ResumeLayout(false);
            this.panelSiderbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelSiderbar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDevolucion;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2Button btnUsuario;
        private Guna.UI2.WinForms.Guna2Button btnLibro;
        private Guna.UI2.WinForms.Guna2Button btnPrestamo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
    }
}



