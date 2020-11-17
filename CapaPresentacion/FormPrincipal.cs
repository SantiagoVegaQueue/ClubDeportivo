using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            personalizarForm();
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


        private void btnInicio_Click(object sender, EventArgs e)
        {
            // codigo

            ocultarSubMenu();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            //abrirFormsPanelContenedor<>();
            mostrarSubMenu(panelSubMenuSocios);
        }

        private void btnDeportivos_Click(object sender, EventArgs e)
        {
            //codigo

            ocultarSubMenu();
        }

        private void btnPlenos_Click(object sender, EventArgs e)
        {
            //codigo

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
    }
}
