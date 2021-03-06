﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FormResumen : Form
    {
        private double precioFinal;
        public FormResumen()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxPrecioBase, "double");
            try
            {
                SocioDeportivo socio = new SocioDeportivo(lblTipoPago.Text, Convert.ToDouble(txtBoxPrecioBase.Text), lblInscripcion.Text);
                this.precioFinal = socio.Calcularpreciofinal();
                lblPrecioFinal.Text = Convert.ToString(this.precioFinal);
            }
            catch (Exception)
            {
                FormNotificacion.VerificarForm("Los datos ingresados son incorrectos");
            }
            
           
        }
    }
}
