namespace GestorDeBiblioteca.Formularios
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.labelIni = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.Aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 49);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sistema de Biblioteca";
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.Controls.Add(this.txtContraseña);
            this.panelImage.Controls.Add(this.labelIni);
            this.panelImage.Controls.Add(this.Welcome);
            this.panelImage.Controls.Add(this.pictureBox3);
            this.panelImage.Controls.Add(this.pictureUser);
            this.panelImage.Controls.Add(this.txtUser);
            this.panelImage.Controls.Add(this.Cancelar);
            this.panelImage.Controls.Add(this.Aceptar);
            this.panelImage.Location = new System.Drawing.Point(465, 46);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(416, 524);
            this.panelImage.TabIndex = 12;
            // 
            // txtContraseña
            // 
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtContraseña.Location = new System.Drawing.Point(94, 267);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(289, 22);
            this.txtContraseña.TabIndex = 9;
            // 
            // labelIni
            // 
            this.labelIni.AutoSize = true;
            this.labelIni.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.labelIni.Location = new System.Drawing.Point(125, 50);
            this.labelIni.Name = "labelIni";
            this.labelIni.Size = new System.Drawing.Size(171, 38);
            this.labelIni.TabIndex = 8;
            this.labelIni.Text = "¡WELCOME!";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Welcome.Location = new System.Drawing.Point(85, 97);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(266, 45);
            this.Welcome.TabIndex = 7;
            this.Welcome.Text = "Inicio de sesión ";
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtUser.Location = new System.Drawing.Point(93, 193);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(289, 22);
            this.txtUser.TabIndex = 3;
            // 
            // Cancelar
            // 
            this.Cancelar.BorderRadius = 10;
            this.Cancelar.CheckedState.Parent = this.Cancelar;
            this.Cancelar.CustomImages.Parent = this.Cancelar;
            this.Cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.HoverState.Parent = this.Cancelar;
            this.Cancelar.Location = new System.Drawing.Point(218, 370);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ShadowDecoration.Parent = this.Cancelar;
            this.Cancelar.Size = new System.Drawing.Size(180, 45);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BorderRadius = 10;
            this.Aceptar.CheckedState.Parent = this.Aceptar;
            this.Aceptar.CustomImages.Parent = this.Aceptar;
            this.Aceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Aceptar.ForeColor = System.Drawing.Color.White;
            this.Aceptar.HoverState.Parent = this.Aceptar;
            this.Aceptar.Location = new System.Drawing.Point(18, 370);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.ShadowDecoration.Parent = this.Aceptar;
            this.Aceptar.Size = new System.Drawing.Size(180, 45);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::GestorDeBiblioteca.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(7, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestorDeBiblioteca.Properties.Resources.icons8_contraseña_48;
            this.pictureBox3.Location = new System.Drawing.Point(29, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 49);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::GestorDeBiblioteca.Properties.Resources.user;
            this.pictureUser.Location = new System.Drawing.Point(29, 178);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(58, 49);
            this.pictureUser.TabIndex = 5;
            this.pictureUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelImage);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label labelIni;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button Cancelar;
        private Guna.UI2.WinForms.Guna2Button Aceptar;
    }
}