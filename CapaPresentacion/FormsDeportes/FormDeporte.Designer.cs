namespace CapaPresentacion
{
    partial class FormDeporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeporte));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxBuscarDeporte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEditarDeporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarDeporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarDeporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExportarPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablaDeporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeporte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxBuscarDeporte
            // 
            this.txtBoxBuscarDeporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxBuscarDeporte.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuscarDeporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxBuscarDeporte.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxBuscarDeporte.HintText = "";
            this.txtBoxBuscarDeporte.isPassword = false;
            this.txtBoxBuscarDeporte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarDeporte.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxBuscarDeporte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarDeporte.LineThickness = 3;
            this.txtBoxBuscarDeporte.Location = new System.Drawing.Point(49, 53);
            this.txtBoxBuscarDeporte.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBoxBuscarDeporte.Name = "txtBoxBuscarDeporte";
            this.txtBoxBuscarDeporte.Size = new System.Drawing.Size(435, 26);
            this.txtBoxBuscarDeporte.TabIndex = 22;
            this.txtBoxBuscarDeporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxBuscarDeporte.OnValueChanged += new System.EventHandler(this.txtBoxBuscarDeporte_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(450, 19);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(329, 29);
            this.bunifuCustomLabel1.TabIndex = 48;
            this.bunifuCustomLabel1.Text = "DEPORTES REGISTRADOS";
            // 
            // btnEditarDeporte
            // 
            this.btnEditarDeporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarDeporte.BorderRadius = 7;
            this.btnEditarDeporte.ButtonText = "Editar";
            this.btnEditarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarDeporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarDeporte.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDeporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarDeporte.Iconimage = null;
            this.btnEditarDeporte.Iconimage_right = null;
            this.btnEditarDeporte.Iconimage_right_Selected = null;
            this.btnEditarDeporte.Iconimage_Selected = null;
            this.btnEditarDeporte.IconMarginLeft = 0;
            this.btnEditarDeporte.IconMarginRight = 0;
            this.btnEditarDeporte.IconRightVisible = true;
            this.btnEditarDeporte.IconRightZoom = 0D;
            this.btnEditarDeporte.IconVisible = true;
            this.btnEditarDeporte.IconZoom = 90D;
            this.btnEditarDeporte.IsTab = false;
            this.btnEditarDeporte.Location = new System.Drawing.Point(494, 661);
            this.btnEditarDeporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditarDeporte.Name = "btnEditarDeporte";
            this.btnEditarDeporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEditarDeporte.OnHovercolor = System.Drawing.Color.Orange;
            this.btnEditarDeporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarDeporte.selected = false;
            this.btnEditarDeporte.Size = new System.Drawing.Size(200, 50);
            this.btnEditarDeporte.TabIndex = 51;
            this.btnEditarDeporte.Text = "Editar";
            this.btnEditarDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarDeporte.Textcolor = System.Drawing.Color.White;
            this.btnEditarDeporte.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDeporte.Click += new System.EventHandler(this.btnEditarDeporte_Click);
            // 
            // btnEliminarDeporte
            // 
            this.btnEliminarDeporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarDeporte.BorderRadius = 7;
            this.btnEliminarDeporte.ButtonText = "Eliminar";
            this.btnEliminarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDeporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarDeporte.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDeporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarDeporte.Iconimage = null;
            this.btnEliminarDeporte.Iconimage_right = null;
            this.btnEliminarDeporte.Iconimage_right_Selected = null;
            this.btnEliminarDeporte.Iconimage_Selected = null;
            this.btnEliminarDeporte.IconMarginLeft = 0;
            this.btnEliminarDeporte.IconMarginRight = 0;
            this.btnEliminarDeporte.IconRightVisible = true;
            this.btnEliminarDeporte.IconRightZoom = 0D;
            this.btnEliminarDeporte.IconVisible = true;
            this.btnEliminarDeporte.IconZoom = 90D;
            this.btnEliminarDeporte.IsTab = false;
            this.btnEliminarDeporte.Location = new System.Drawing.Point(704, 661);
            this.btnEliminarDeporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarDeporte.Name = "btnEliminarDeporte";
            this.btnEliminarDeporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminarDeporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.btnEliminarDeporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarDeporte.selected = false;
            this.btnEliminarDeporte.Size = new System.Drawing.Size(200, 50);
            this.btnEliminarDeporte.TabIndex = 50;
            this.btnEliminarDeporte.Text = "Eliminar";
            this.btnEliminarDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarDeporte.Textcolor = System.Drawing.Color.White;
            this.btnEliminarDeporte.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDeporte.Click += new System.EventHandler(this.btnEliminarDeporte_Click);
            // 
            // btnAgregarDeporte
            // 
            this.btnAgregarDeporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarDeporte.BorderRadius = 7;
            this.btnAgregarDeporte.ButtonText = "Agregar";
            this.btnAgregarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDeporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarDeporte.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDeporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.Iconimage = null;
            this.btnAgregarDeporte.Iconimage_right = null;
            this.btnAgregarDeporte.Iconimage_right_Selected = null;
            this.btnAgregarDeporte.Iconimage_Selected = null;
            this.btnAgregarDeporte.IconMarginLeft = 0;
            this.btnAgregarDeporte.IconMarginRight = 0;
            this.btnAgregarDeporte.IconRightVisible = true;
            this.btnAgregarDeporte.IconRightZoom = 0D;
            this.btnAgregarDeporte.IconVisible = true;
            this.btnAgregarDeporte.IconZoom = 90D;
            this.btnAgregarDeporte.IsTab = false;
            this.btnAgregarDeporte.Location = new System.Drawing.Point(284, 661);
            this.btnAgregarDeporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarDeporte.Name = "btnAgregarDeporte";
            this.btnAgregarDeporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnAgregarDeporte.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnAgregarDeporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarDeporte.selected = false;
            this.btnAgregarDeporte.Size = new System.Drawing.Size(200, 50);
            this.btnAgregarDeporte.TabIndex = 49;
            this.btnAgregarDeporte.Text = "Agregar";
            this.btnAgregarDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarDeporte.Textcolor = System.Drawing.Color.White;
            this.btnAgregarDeporte.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDeporte.Click += new System.EventHandler(this.btnAgregarDeporte_Click);
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
            this.btnExportarPDF.Iconimage_Selected = null;
            this.btnExportarPDF.IconMarginLeft = 0;
            this.btnExportarPDF.IconMarginRight = 0;
            this.btnExportarPDF.IconRightVisible = true;
            this.btnExportarPDF.IconRightZoom = 0D;
            this.btnExportarPDF.IconVisible = true;
            this.btnExportarPDF.IconZoom = 50D;
            this.btnExportarPDF.IsTab = false;
            this.btnExportarPDF.Location = new System.Drawing.Point(956, 31);
            this.btnExportarPDF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.OnHovercolor = System.Drawing.Color.White;
            this.btnExportarPDF.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.selected = false;
            this.btnExportarPDF.Size = new System.Drawing.Size(200, 50);
            this.btnExportarPDF.TabIndex = 52;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarPDF.Textcolor = System.Drawing.Color.White;
            this.btnExportarPDF.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tablaDeporte
            // 
            this.tablaDeporte.AllowUserToAddRows = false;
            this.tablaDeporte.AllowUserToDeleteRows = false;
            this.tablaDeporte.AllowUserToResizeColumns = false;
            this.tablaDeporte.AllowUserToResizeRows = false;
            this.tablaDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDeporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDeporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tablaDeporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDeporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaDeporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDeporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDeporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDeporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDeporte.EnableHeadersVisualStyles = false;
            this.tablaDeporte.Location = new System.Drawing.Point(13, 87);
            this.tablaDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaDeporte.Name = "tablaDeporte";
            this.tablaDeporte.ReadOnly = true;
            this.tablaDeporte.RowHeadersVisible = false;
            this.tablaDeporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeporte.Size = new System.Drawing.Size(1144, 551);
            this.tablaDeporte.TabIndex = 53;
            // 
            // FormDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.tablaDeporte);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnEditarDeporte);
            this.Controls.Add(this.btnEliminarDeporte);
            this.Controls.Add(this.btnAgregarDeporte);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtBoxBuscarDeporte);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeporte";
            this.Text = "FormDeporte";
            this.Load += new System.EventHandler(this.FormDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxBuscarDeporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarDeporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarDeporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarDeporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportarPDF;
        private System.Windows.Forms.DataGridView tablaDeporte;
    }
}