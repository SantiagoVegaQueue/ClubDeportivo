namespace CapaPresentacion
{
    partial class FormResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarVentana = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelNombreProfesorRegistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCalcularPrecioFinal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellido = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDireccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTelefono = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTipoPago = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblInscripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrecioFinal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtBoxPrecioBase = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.cerrarVentana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 40);
            this.panel1.TabIndex = 108;
            // 
            // cerrarVentana
            // 
            this.cerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("cerrarVentana.Image")));
            this.cerrarVentana.Location = new System.Drawing.Point(311, 11);
            this.cerrarVentana.Name = "cerrarVentana";
            this.cerrarVentana.Size = new System.Drawing.Size(26, 26);
            this.cerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cerrarVentana.TabIndex = 66;
            this.cerrarVentana.TabStop = false;
            this.cerrarVentana.Click += new System.EventHandler(this.cerrarVentana_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // labelNombreProfesorRegistro
            // 
            this.labelNombreProfesorRegistro.AutoSize = true;
            this.labelNombreProfesorRegistro.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProfesorRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.labelNombreProfesorRegistro.Location = new System.Drawing.Point(56, 125);
            this.labelNombreProfesorRegistro.Name = "labelNombreProfesorRegistro";
            this.labelNombreProfesorRegistro.Size = new System.Drawing.Size(66, 16);
            this.labelNombreProfesorRegistro.TabIndex = 119;
            this.labelNombreProfesorRegistro.Text = "Nombre:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(74, 55);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(204, 25);
            this.bunifuCustomLabel7.TabIndex = 120;
            this.bunifuCustomLabel7.Text = "Resumen de pago";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 156);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel3.TabIndex = 122;
            this.bunifuCustomLabel3.Text = "Apellido:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(56, 187);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 16);
            this.bunifuCustomLabel5.TabIndex = 124;
            this.bunifuCustomLabel5.Text = "DNI:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(56, 216);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(75, 16);
            this.bunifuCustomLabel8.TabIndex = 126;
            this.bunifuCustomLabel8.Text = "Dirección:";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(56, 246);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(69, 16);
            this.bunifuCustomLabel10.TabIndex = 128;
            this.bunifuCustomLabel10.Text = "Teléfono:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(56, 279);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(98, 16);
            this.bunifuCustomLabel12.TabIndex = 130;
            this.bunifuCustomLabel12.Text = "Tipo de pago:";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(56, 308);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(85, 16);
            this.bunifuCustomLabel13.TabIndex = 132;
            this.bunifuCustomLabel13.Text = "Inscripción:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 373);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 16);
            this.bunifuCustomLabel1.TabIndex = 133;
            this.bunifuCustomLabel1.Text = "Total a pagar: $";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 339);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 16);
            this.bunifuCustomLabel2.TabIndex = 134;
            this.bunifuCustomLabel2.Text = "Precio base: $";
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
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(14, 410);
            this.btnCalcularPrecioFinal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal";
            this.btnCalcularPrecioFinal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.btnCalcularPrecioFinal.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.btnCalcularPrecioFinal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcularPrecioFinal.selected = false;
            this.btnCalcularPrecioFinal.Size = new System.Drawing.Size(323, 50);
            this.btnCalcularPrecioFinal.TabIndex = 135;
            this.btnCalcularPrecioFinal.Text = "Calcular precio final";
            this.btnCalcularPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcularPrecioFinal.Textcolor = System.Drawing.Color.White;
            this.btnCalcularPrecioFinal.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecioFinal.Click += new System.EventHandler(this.btnCalcularPrecioFinal_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(56, 98);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 16);
            this.bunifuCustomLabel4.TabIndex = 136;
            this.bunifuCustomLabel4.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblCodigo.Location = new System.Drawing.Point(122, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 16);
            this.lblCodigo.TabIndex = 137;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblNombre.Location = new System.Drawing.Point(129, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 138;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblApellido.Location = new System.Drawing.Point(130, 156);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 16);
            this.lblApellido.TabIndex = 139;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblDni.Location = new System.Drawing.Point(99, 187);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(0, 16);
            this.lblDni.TabIndex = 140;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblDireccion.Location = new System.Drawing.Point(135, 216);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(0, 16);
            this.lblDireccion.TabIndex = 141;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblTelefono.Location = new System.Drawing.Point(125, 246);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(0, 16);
            this.lblTelefono.TabIndex = 142;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblTipoPago.Location = new System.Drawing.Point(157, 279);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(0, 16);
            this.lblTipoPago.TabIndex = 143;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblInscripcion.Location = new System.Drawing.Point(139, 308);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(0, 16);
            this.lblInscripcion.TabIndex = 144;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblPrecioFinal.Location = new System.Drawing.Point(173, 373);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioFinal.TabIndex = 146;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtBoxPrecioBase
            // 
            this.txtBoxPrecioBase.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.txtBoxPrecioBase.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPrecioBase.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.txtBoxPrecioBase.BorderThickness = 1;
            this.txtBoxPrecioBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPrecioBase.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecioBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPrecioBase.isPassword = false;
            this.txtBoxPrecioBase.Location = new System.Drawing.Point(160, 337);
            this.txtBoxPrecioBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrecioBase.Name = "txtBoxPrecioBase";
            this.txtBoxPrecioBase.Size = new System.Drawing.Size(114, 18);
            this.txtBoxPrecioBase.TabIndex = 171;
            this.txtBoxPrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(349, 481);
            this.Controls.Add(this.txtBoxPrecioBase);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.labelNombreProfesorRegistro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResumen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cerrarVentana;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcularPrecioFinal;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblPrecioFinal;
        public Bunifu.Framework.UI.BunifuCustomLabel lblInscripcion;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTipoPago;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTelefono;
        public Bunifu.Framework.UI.BunifuCustomLabel lblDireccion;
        public Bunifu.Framework.UI.BunifuCustomLabel lblDni;
        public Bunifu.Framework.UI.BunifuCustomLabel lblApellido;
        public Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        public Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel labelNombreProfesorRegistro;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtBoxPrecioBase;
    }
}