namespace CapaPresentacion
{
    partial class FormProfesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesor));
            this.tablaProfesor = new System.Windows.Forms.DataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxBuscarProfesor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAgregarProfesor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEliminarProfesor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarProfesor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExportarPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProfesor
            // 
            this.tablaProfesor.AllowUserToAddRows = false;
            this.tablaProfesor.AllowUserToDeleteRows = false;
            this.tablaProfesor.AllowUserToResizeColumns = false;
            this.tablaProfesor.AllowUserToResizeRows = false;
            this.tablaProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProfesor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tablaProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProfesor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProfesor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProfesor.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaProfesor.EnableHeadersVisualStyles = false;
            this.tablaProfesor.Location = new System.Drawing.Point(13, 102);
            this.tablaProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaProfesor.Name = "tablaProfesor";
            this.tablaProfesor.ReadOnly = true;
            this.tablaProfesor.RowHeadersVisible = false;
            this.tablaProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProfesor.Size = new System.Drawing.Size(1144, 553);
            this.tablaProfesor.TabIndex = 0;
            this.tablaProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProfesor_CellContentClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxBuscarProfesor
            // 
            this.txtBoxBuscarProfesor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxBuscarProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuscarProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxBuscarProfesor.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxBuscarProfesor.HintText = "";
            this.txtBoxBuscarProfesor.isPassword = false;
            this.txtBoxBuscarProfesor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarProfesor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxBuscarProfesor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarProfesor.LineThickness = 3;
            this.txtBoxBuscarProfesor.Location = new System.Drawing.Point(50, 68);
            this.txtBoxBuscarProfesor.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBoxBuscarProfesor.Name = "txtBoxBuscarProfesor";
            this.txtBoxBuscarProfesor.Size = new System.Drawing.Size(435, 26);
            this.txtBoxBuscarProfesor.TabIndex = 20;
            this.txtBoxBuscarProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxBuscarProfesor.OnValueChanged += new System.EventHandler(this.txtBoxBuscarProfesor_OnValueChanged);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProfesor.BorderRadius = 7;
            this.btnAgregarProfesor.ButtonText = "Agregar";
            this.btnAgregarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProfesor.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProfesor.Iconimage = null;
            this.btnAgregarProfesor.Iconimage_right = null;
            this.btnAgregarProfesor.Iconimage_right_Selected = null;
            this.btnAgregarProfesor.Iconimage_Selected = null;
            this.btnAgregarProfesor.IconMarginLeft = 0;
            this.btnAgregarProfesor.IconMarginRight = 0;
            this.btnAgregarProfesor.IconRightVisible = true;
            this.btnAgregarProfesor.IconRightZoom = 0D;
            this.btnAgregarProfesor.IconVisible = true;
            this.btnAgregarProfesor.IconZoom = 90D;
            this.btnAgregarProfesor.IsTab = false;
            this.btnAgregarProfesor.Location = new System.Drawing.Point(172, 661);
            this.btnAgregarProfesor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarProfesor.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProfesor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarProfesor.selected = false;
            this.btnAgregarProfesor.Size = new System.Drawing.Size(200, 50);
            this.btnAgregarProfesor.TabIndex = 21;
            this.btnAgregarProfesor.Text = "Agregar";
            this.btnAgregarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProfesor.Textcolor = System.Drawing.Color.White;
            this.btnAgregarProfesor.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(414, 24);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(363, 29);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "PROFESORES REGISTRADOS";
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarProfesor.BorderRadius = 7;
            this.btnEliminarProfesor.ButtonText = "Eliminar";
            this.btnEliminarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProfesor.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProfesor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarProfesor.Iconimage = null;
            this.btnEliminarProfesor.Iconimage_right = null;
            this.btnEliminarProfesor.Iconimage_right_Selected = null;
            this.btnEliminarProfesor.Iconimage_Selected = null;
            this.btnEliminarProfesor.IconMarginLeft = 0;
            this.btnEliminarProfesor.IconMarginRight = 0;
            this.btnEliminarProfesor.IconRightVisible = true;
            this.btnEliminarProfesor.IconRightZoom = 0D;
            this.btnEliminarProfesor.IconVisible = true;
            this.btnEliminarProfesor.IconZoom = 90D;
            this.btnEliminarProfesor.IsTab = false;
            this.btnEliminarProfesor.Location = new System.Drawing.Point(592, 661);
            this.btnEliminarProfesor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarProfesor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.btnEliminarProfesor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarProfesor.selected = false;
            this.btnEliminarProfesor.Size = new System.Drawing.Size(200, 50);
            this.btnEliminarProfesor.TabIndex = 23;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarProfesor.Textcolor = System.Drawing.Color.White;
            this.btnEliminarProfesor.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnEditarProfesor
            // 
            this.btnEditarProfesor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarProfesor.BorderRadius = 7;
            this.btnEditarProfesor.ButtonText = "Editar";
            this.btnEditarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProfesor.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProfesor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarProfesor.Iconimage = null;
            this.btnEditarProfesor.Iconimage_right = null;
            this.btnEditarProfesor.Iconimage_right_Selected = null;
            this.btnEditarProfesor.Iconimage_Selected = null;
            this.btnEditarProfesor.IconMarginLeft = 0;
            this.btnEditarProfesor.IconMarginRight = 0;
            this.btnEditarProfesor.IconRightVisible = true;
            this.btnEditarProfesor.IconRightZoom = 0D;
            this.btnEditarProfesor.IconVisible = true;
            this.btnEditarProfesor.IconZoom = 90D;
            this.btnEditarProfesor.IsTab = false;
            this.btnEditarProfesor.Location = new System.Drawing.Point(382, 661);
            this.btnEditarProfesor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditarProfesor.Name = "btnEditarProfesor";
            this.btnEditarProfesor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarProfesor.OnHovercolor = System.Drawing.Color.Orange;
            this.btnEditarProfesor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarProfesor.selected = false;
            this.btnEditarProfesor.Size = new System.Drawing.Size(200, 50);
            this.btnEditarProfesor.TabIndex = 24;
            this.btnEditarProfesor.Text = "Editar";
            this.btnEditarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarProfesor.Textcolor = System.Drawing.Color.White;
            this.btnEditarProfesor.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProfesor.Click += new System.EventHandler(this.btnEditarProfesor_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarPDF.BorderRadius = 7;
            this.btnExportarPDF.ButtonText = "Exportar a PDF";
            this.btnExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportarPDF.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExportarPDF.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.Iconimage")));
            this.btnExportarPDF.Iconimage_right = null;
            this.btnExportarPDF.Iconimage_right_Selected = null;
            this.btnExportarPDF.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.Iconimage_Selected")));
            this.btnExportarPDF.IconMarginLeft = 0;
            this.btnExportarPDF.IconMarginRight = 0;
            this.btnExportarPDF.IconRightVisible = true;
            this.btnExportarPDF.IconRightZoom = 0D;
            this.btnExportarPDF.IconVisible = true;
            this.btnExportarPDF.IconZoom = 50D;
            this.btnExportarPDF.IsTab = false;
            this.btnExportarPDF.Location = new System.Drawing.Point(802, 661);
            this.btnExportarPDF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.OnHovercolor = System.Drawing.Color.White;
            this.btnExportarPDF.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.selected = true;
            this.btnExportarPDF.Size = new System.Drawing.Size(200, 50);
            this.btnExportarPDF.TabIndex = 46;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarPDF.Textcolor = System.Drawing.Color.White;
            this.btnExportarPDF.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            this.btnExportarPDF.MouseHover += new System.EventHandler(this.btnExportarPDF_MouseHover);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnEditarProfesor);
            this.Controls.Add(this.btnEliminarProfesor);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.txtBoxBuscarProfesor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaProfesor);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProfesor";
            this.Load += new System.EventHandler(this.FormProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProfesor;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxBuscarProfesor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarProfesor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarProfesor;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarProfesor;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportarPDF;
    }
}