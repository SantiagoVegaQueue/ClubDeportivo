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

        private void txtBoxDniProfesor_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxNombre, "string");
            Validaciones.ValidarCampos(ref txtBoxApellido, "string");
            Validaciones.ValidarCampos(ref txtBoxDireccion, "string");
            Validaciones.ValidarCampos(ref txtBoxDni, "int");
            Validaciones.ValidarCampos(ref txtBoxTelefono, "long");
            Validaciones.ValidarCampos(ref txtBoxEmail, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxSexo, "string");

            if (!editar)
            {
                try
                {
                    Socio socio = new Socio();

                    socio.InsertarSocio(txtBoxNombre.Text, txtBoxApellido.Text, comboBoxSexo.Text, Convert.ToInt32(txtBoxDni.Text), datePickerFechaNac.Value.Date, txtBoxNacionalidad.Text, comboBoxEstcivil.Text, txtBoxDireccion.Text, Convert.ToInt64(txtBoxTelefono.Text), txtBoxEmail.Text);
                    
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
                    Socio socio = new Socio();


                    socio.EditarSocio(Convert.ToInt32(txtBoxIdSocio.Text), txtBoxNombre.Text, txtBoxApellido.Text, comboBoxSexo.Text, Convert.ToInt32(txtBoxDni.Text), datePickerFechaNac.Value.Date, txtBoxNacionalidad.Text, comboBoxEstcivil.Text, txtBoxDireccion.Text, Convert.ToInt64(txtBoxTelefono.Text), txtBoxEmail.Text);

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
