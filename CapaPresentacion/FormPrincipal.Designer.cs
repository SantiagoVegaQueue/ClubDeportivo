namespace CapaPresentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.panelSubMenuSocios = new System.Windows.Forms.Panel();
            this.btnPlenos = new System.Windows.Forms.Button();
            this.btnDeportivos = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.panelLogoLateral = new System.Windows.Forms.Panel();
            this.cerrarVentana = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelControlSuperior = new System.Windows.Forms.Panel();
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelContedorDeForms = new System.Windows.Forms.Panel();
            this.bunifuDragControl6 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuSocios.SuspendLayout();
            this.panelLogoLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentana)).BeginInit();
            this.panelControlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelMenuLateral.Controls.Add(this.btnProfesores);
            this.panelMenuLateral.Controls.Add(this.btnDeportes);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuSocios);
            this.panelMenuLateral.Controls.Add(this.btnSocios);
            this.panelMenuLateral.Controls.Add(this.panelLogoLateral);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(166, 768);
            this.panelMenuLateral.TabIndex = 8;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesores.FlatAppearance.BorderSize = 0;
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnProfesores.Location = new System.Drawing.Point(0, 370);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfesores.Size = new System.Drawing.Size(166, 60);
            this.btnProfesores.TabIndex = 15;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnDeportes
            // 
            this.btnDeportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeportes.FlatAppearance.BorderSize = 0;
            this.btnDeportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeportes.Location = new System.Drawing.Point(0, 310);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeportes.Size = new System.Drawing.Size(166, 60);
            this.btnDeportes.TabIndex = 14;
            this.btnDeportes.Text = "Deportes";
            this.btnDeportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeportes.UseVisualStyleBackColor = true;
            this.btnDeportes.Click += new System.EventHandler(this.btnDeportes_Click);
            // 
            // panelSubMenuSocios
            // 
            this.panelSubMenuSocios.Controls.Add(this.btnPlenos);
            this.panelSubMenuSocios.Controls.Add(this.btnDeportivos);
            this.panelSubMenuSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuSocios.Location = new System.Drawing.Point(0, 210);
            this.panelSubMenuSocios.Name = "panelSubMenuSocios";
            this.panelSubMenuSocios.Size = new System.Drawing.Size(166, 100);
            this.panelSubMenuSocios.TabIndex = 13;
            // 
            // btnPlenos
            // 
            this.btnPlenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnPlenos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlenos.FlatAppearance.BorderSize = 0;
            this.btnPlenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlenos.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlenos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlenos.Location = new System.Drawing.Point(0, 50);
            this.btnPlenos.Name = "btnPlenos";
            this.btnPlenos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPlenos.Size = new System.Drawing.Size(166, 50);
            this.btnPlenos.TabIndex = 1;
            this.btnPlenos.Text = "Plenos";
            this.btnPlenos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlenos.UseVisualStyleBackColor = false;
            this.btnPlenos.Click += new System.EventHandler(this.btnPlenos_Click);
            // 
            // btnDeportivos
            // 
            this.btnDeportivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnDeportivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeportivos.FlatAppearance.BorderSize = 0;
            this.btnDeportivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportivos.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportivos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeportivos.Location = new System.Drawing.Point(0, 0);
            this.btnDeportivos.Name = "btnDeportivos";
            this.btnDeportivos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeportivos.Size = new System.Drawing.Size(166, 50);
            this.btnDeportivos.TabIndex = 0;
            this.btnDeportivos.Text = "Deportivos";
            this.btnDeportivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeportivos.UseVisualStyleBackColor = false;
            this.btnDeportivos.Click += new System.EventHandler(this.btnDeportivos_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSocios.Location = new System.Drawing.Point(0, 150);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSocios.Size = new System.Drawing.Size(166, 60);
            this.btnSocios.TabIndex = 12;
            this.btnSocios.Text = "Socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            this.btnSocios.MouseHover += new System.EventHandler(this.btnSocios_MouseHover);
            // 
            // panelLogoLateral
            // 
            this.panelLogoLateral.Controls.Add(this.lblHora);
            this.panelLogoLateral.Controls.Add(this.pictureBox2);
            this.panelLogoLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLogoLateral.Name = "panelLogoLateral";
            this.panelLogoLateral.Size = new System.Drawing.Size(166, 150);
            this.panelLogoLateral.TabIndex = 10;
            // 
            // cerrarVentana
            // 
            this.cerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("cerrarVentana.Image")));
            this.cerrarVentana.Location = new System.Drawing.Point(1132, 12);
            this.cerrarVentana.Name = "cerrarVentana";
            this.cerrarVentana.Size = new System.Drawing.Size(26, 26);
            this.cerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrarVentana.TabIndex = 10;
            this.cerrarVentana.TabStop = false;
            this.cerrarVentana.Click += new System.EventHandler(this.cerrarVentana_Click);
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panelMenuLateral;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.panelControlSuperior;
            this.bunifuDragControl4.Vertical = true;
            // 
            // panelControlSuperior
            // 
            this.panelControlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelControlSuperior.Controls.Add(this.cerrarVentana);
            this.panelControlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlSuperior.Location = new System.Drawing.Point(166, 0);
            this.panelControlSuperior.Name = "panelControlSuperior";
            this.panelControlSuperior.Size = new System.Drawing.Size(1170, 45);
            this.panelControlSuperior.TabIndex = 9;
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.panelLogoLateral;
            this.bunifuDragControl5.Vertical = true;
            // 
            // panelContedorDeForms
            // 
            this.panelContedorDeForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContedorDeForms.Location = new System.Drawing.Point(166, 45);
            this.panelContedorDeForms.Name = "panelContedorDeForms";
            this.panelContedorDeForms.Size = new System.Drawing.Size(1170, 723);
            this.panelContedorDeForms.TabIndex = 10;
            this.panelContedorDeForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContedorDeForms_Paint);
            // 
            // bunifuDragControl6
            // 
            this.bunifuDragControl6.Fixed = true;
            this.bunifuDragControl6.Horizontal = true;
            this.bunifuDragControl6.TargetControl = this.panelContedorDeForms;
            this.bunifuDragControl6.Vertical = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(48, 120);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 23);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "lblHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1336, 768);
            this.Controls.Add(this.panelContedorDeForms);
            this.Controls.Add(this.panelControlSuperior);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuSocios.ResumeLayout(false);
            this.panelLogoLateral.ResumeLayout(false);
            this.panelLogoLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentana)).EndInit();
            this.panelControlSuperior.ResumeLayout(false);
            this.panelControlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogoLateral;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnDeportes;
        private System.Windows.Forms.Panel panelSubMenuSocios;
        private System.Windows.Forms.Button btnPlenos;
        private System.Windows.Forms.Button btnDeportivos;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.PictureBox cerrarVentana;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl5;
        private System.Windows.Forms.Panel panelControlSuperior;
        private System.Windows.Forms.Panel panelContedorDeForms;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl6;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}