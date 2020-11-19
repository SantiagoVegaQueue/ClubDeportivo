using System;
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
    public partial class FormMantenimientoSocio : Form
    {

        public bool editar = false;
        public FormMantenimientoSocio()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarProfesor_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxNombreSocio, "string");
            Validaciones.ValidarCampos(ref txtBoxApellidoSocio, "string");
            Validaciones.ValidarCampos(ref txtBoxDireccionSocio, "string");
            Validaciones.ValidarCampos(ref txtBoxDniSocio, "int");
            Validaciones.ValidarCampos(ref txtBoxTelefonoSocio, "long");
            Validaciones.ValidarCampos(ref txtBoxEmailSocio, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxSexoSocio, "string");
            Validaciones.ValidarCampos(ref txtBoxNacionalidadSocio, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxEstadoCivilSocio, "string");

            if (!editar)
            {
                try
                {
                    Socio socio = new Socio(txtBoxNombreSocio.Text, txtBoxApellidoSocio.Text, comboBoxSexoSocio.Text, Convert.ToInt32(txtBoxDniSocio.Text), datePickerFechaNacSocio.Value, txtBoxNacionalidadSocio.Text, comboBoxEstadoCivilSocio.Text, txtBoxDireccionSocio.Text, Convert.ToInt64(txtBoxTelefonoSocio.Text), txtBoxEmailSocio.Text);

                    socio.InsertarSocio();

                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar" + ex);
                }
            }
            if (editar)
            {

                try
                {
                    Socio socio = new Socio(txtBoxNombreSocio.Text, txtBoxApellidoSocio.Text, comboBoxSexoSocio.Text, Convert.ToInt32(txtBoxDniSocio.Text), datePickerFechaNacSocio.Value, txtBoxNacionalidadSocio.Text, comboBoxEstadoCivilSocio.Text, txtBoxDireccionSocio.Text, Convert.ToInt64(txtBoxTelefonoSocio.Text), txtBoxEmailSocio.Text);

                    socio.EditarSocio(Convert.ToInt32(txtBoxIdSocio.Text));

                    Close();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar" + ex);
                }
            }
        }
    }
}
