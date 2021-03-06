﻿namespace CapaPresentacion
{
    partial class FormSocioPleno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSocioPleno));
            this.tablaSocioPleno = new System.Windows.Forms.DataGridView();
            this.btnCalcularPrecioFinal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBoxBuscarSocio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportarPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocioPleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaSocioPleno
            // 
            this.tablaSocioPleno.AllowUserToAddRows = false;
            this.tablaSocioPleno.AllowUserToDeleteRows = false;
            this.tablaSocioPleno.AllowUserToResizeColumns = false;
            this.tablaSocioPleno.AllowUserToResizeRows = false;
            this.tablaSocioPleno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaSocioPleno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaSocioPleno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaSocioPleno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tablaSocioPleno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaSocioPleno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaSocioPleno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSocioPleno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSocioPleno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaSocioPleno.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSocioPleno.EnableHeadersVisualStyles = false;
            this.tablaSocioPleno.Location = new System.Drawing.Point(13, 88);
            this.tablaSocioPleno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaSocioPleno.Name = "tablaSocioPleno";
            this.tablaSocioPleno.ReadOnly = true;
            this.tablaSocioPleno.RowHeadersVisible = false;
            this.tablaSocioPleno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSocioPleno.Size = new System.Drawing.Size(1144, 567);
            this.tablaSocioPleno.TabIndex = 48;
            this.tablaSocioPleno.MouseHover += new System.EventHandler(this.FormSocioPleno_Load);
            // 
            // btnCalcularPrecioFinal
            // 
            this.btnCalcularPrecioFinal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnCalcularPrecioFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnCalcularPrecioFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcularPrecioFinal.BorderRadius = 7;
            this.btnCalcularPrecioFinal.ButtonText = "Calcular precio final";
            this.btnCalcularPrecioFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularPrecioFinal.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalcularPrecioFinal.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecioFinal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcularPrecioFinal.Iconimage = null;
            this.btnCalcularPrecioFinal.Iconimage_right = null;
            this.btnCalcularPrecioFinal.Iconimage_right_Selected = null;
            this.btnCalcularPrecioFinal.Iconimage_Selected = null;
            this.btnCalcularPrecioFinal.IconMarginLeft = 0;
            this.btnCalcularPrecioFinal.IconMarginRight = 0;
            this.btnCalcularPrecioFinal.IconRightVisible = true;
            this.btnCalcularPrecioFinal.IconRightZoom = 0D;
            this.btnCalcularPrecioFinal.IconVisible = true;
            this.btnCalcularPrecioFinal.IconZoom = 90D;
            this.btnCalcularPrecioFinal.IsTab = false;
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(296, 661);
            this.btnCalcularPrecioFinal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal";
            this.btnCalcularPrecioFinal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnCalcularPrecioFinal.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.btnCalcularPrecioFinal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcularPrecioFinal.selected = false;
            this.btnCalcularPrecioFinal.Size = new System.Drawing.Size(200, 50);
            this.btnCalcularPrecioFinal.TabIndex = 67;
            this.btnCalcularPrecioFinal.Text = "Calcular precio final";
            this.btnCalcularPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcularPrecioFinal.Textcolor = System.Drawing.Color.White;
            this.btnCalcularPrecioFinal.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecioFinal.Click += new System.EventHandler(this.btnCalcularPrecioFinal_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = null;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(506, 661);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(200, 50);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(428, 6);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(343, 29);
            this.bunifuCustomLabel1.TabIndex = 71;
            this.bunifuCustomLabel1.Text = "SOCIOS PLENOS DEL CLUB";
            // 
            // txtBoxBuscarSocio
            // 
            this.txtBoxBuscarSocio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxBuscarSocio.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuscarSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxBuscarSocio.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxBuscarSocio.HintText = "";
            this.txtBoxBuscarSocio.isPassword = false;
            this.txtBoxBuscarSocio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarSocio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxBuscarSocio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtBoxBuscarSocio.LineThickness = 3;
            this.txtBoxBuscarSocio.Location = new System.Drawing.Point(41, 40);
            this.txtBoxBuscarSocio.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtBoxBuscarSocio.Name = "txtBoxBuscarSocio";
            this.txtBoxBuscarSocio.Size = new System.Drawing.Size(435, 26);
            this.txtBoxBuscarSocio.TabIndex = 70;
            this.txtBoxBuscarSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxBuscarSocio.OnValueChanged += new System.EventHandler(this.txtBoxBuscarSocio_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
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
            this.btnExportarPDF.Location = new System.Drawing.Point(716, 661);
            this.btnExportarPDF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.OnHovercolor = System.Drawing.Color.White;
            this.btnExportarPDF.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnExportarPDF.selected = true;
            this.btnExportarPDF.Size = new System.Drawing.Size(200, 50);
            this.btnExportarPDF.TabIndex = 72;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarPDF.Textcolor = System.Drawing.Color.White;
            this.btnExportarPDF.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // FormSocioPleno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtBoxBuscarSocio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.tablaSocioPleno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSocioPleno";
            this.Text = "FormSocioPleno";
            this.Load += new System.EventHandler(this.FormSocioPleno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocioPleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaSocioPleno;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcularPrecioFinal;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxBuscarSocio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportarPDF;
    }
}