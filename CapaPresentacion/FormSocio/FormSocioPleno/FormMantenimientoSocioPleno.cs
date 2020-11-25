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
    public partial class FormMantenimientoSocioPleno : Form
    {
        public FormMantenimientoSocioPleno()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void invalidarTextbox()
        {
            txtBoxIdSocio.Visible = false;
            txtBoxApellido.Enabled = false;
            txtBoxNombre.Enabled = false;
            txtBoxDni.Enabled = false;
            txtBoxNacionalidad.Enabled = false;
            comboBoxEstcivil.Enabled = false;
            comboBoxSexo.Enabled = false;
            txtBoxEmail.Enabled = false;
            txtBoxDireccion.Enabled = false;
            txtBoxTelefono.Enabled = false;
            comboBoxPago.Enabled = false;
            datePickerFechaNac.Enabled = false;

            comboBoxTipoPlan.Focus();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxNombre, "string");
            Validaciones.ValidarCampos(ref txtBoxApellido, "string");
            Validaciones.ValidarCampos(ref txtBoxDni, "int");
            Validaciones.ValidarCampos(ref txtBoxNacionalidad, "string");
            Validaciones.ValidarCampos(ref txtBoxEmail, "string");
            Validaciones.ValidarCampos(ref txtBoxDireccion, "string");
            Validaciones.ValidarCampos(ref txtBoxTelefono, "double");
            Validaciones.ValidarCampoCombo(ref comboBoxPago, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxEstcivil, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxSexo, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxTipoPlan, "string");
            
            try
            {

                SocioPleno socio = new SocioPleno();

                socio.InsertarSocioPleno(Convert.ToInt32(txtBoxIdSocio.Text), comboBoxTipoPlan.Text);
                FormExito.ConfirmarForm("Se ha guardado correctamente");

                Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("PASO ESTO PAI: " + ex);
                FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
            }
        }
    }
}
