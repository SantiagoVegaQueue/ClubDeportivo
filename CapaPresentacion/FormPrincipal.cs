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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            personalizarForm();

        }
        #region Funcionalidades form principal

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirFormsPanelContenedor<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContedorDeForms.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelContedorDeForms.Controls.Add(formulario);
                panelContedorDeForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void personalizarForm()
        {
            panelSubMenuSocios.Visible = false;

        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuSocios.Visible)
            {
                panelSubMenuSocios.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Acceso a los distintos forms
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // codigo

            ocultarSubMenu();
        }
        private void btnSocios_MouseHover(object sender, EventArgs e)
        {
            abrirFormsPanelContenedor<FormSocio>();
            mostrarSubMenu(panelSubMenuSocios);
        }
        private void btnSocios_Click(object sender, EventArgs e)
        {
            //abrirFormsPanelContenedor<FormSocio>();
            //mostrarSubMenu(panelSubMenuSocios);
        }

        private void btnDeportivos_Click(object sender, EventArgs e)
        {
           //codigo
            
            abrirFormsPanelContenedor<FormSocioDeportivo>();
            
            ocultarSubMenu();
        }

        private void btnPlenos_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormsPanelContenedor<FormSocioPleno>();
            ocultarSubMenu();
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormsPanelContenedor<FormDeporte>();

            ocultarSubMenu();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            //codigo
            abrirFormsPanelContenedor<FormProfesor>();
            ocultarSubMenu();
        }
        #endregion

        private void panelContedorDeForms_Paint(object sender, PaintEventArgs e)
        {
            abrirFormsPanelContenedor<FormSocio>();
            mostrarSubMenu(panelSubMenuSocios);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
