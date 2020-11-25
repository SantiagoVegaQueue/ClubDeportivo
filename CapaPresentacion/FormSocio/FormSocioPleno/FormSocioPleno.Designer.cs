namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaSocioPleno = new System.Windows.Forms.DataGridView();
            this.btnCalcularPrecioFinal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocioPleno)).BeginInit();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSocioPleno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaSocioPleno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaSocioPleno.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaSocioPleno.EnableHeadersVisualStyles = false;
            this.tablaSocioPleno.Location = new System.Drawing.Point(13, 74);
            this.tablaSocioPleno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaSocioPleno.Name = "tablaSocioPleno";
            this.tablaSocioPleno.ReadOnly = true;
            this.tablaSocioPleno.RowHeadersVisible = false;
            this.tablaSocioPleno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSocioPleno.Size = new System.Drawing.Size(1144, 581);
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
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(394, 661);
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
            this.btnEliminar.Location = new System.Drawing.Point(604, 661);
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
            // FormSocioPleno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.tablaSocioPleno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSocioPleno";
            this.Text = "FormSocioPleno";
            this.Load += new System.EventHandler(this.FormSocioPleno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocioPleno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaSocioPleno;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcularPrecioFinal;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
    }
}