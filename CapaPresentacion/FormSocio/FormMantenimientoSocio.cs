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
            Validaciones.ValidarCampos(ref txtBoxNacionalidad, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxSexo, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxEstcivil, "string");
            Validaciones.ValidarCampoCombo(ref comboBoxPago, "string");
            
            if (!editar)
            {
                try
                {
                    Socio socio = new Socio();
                    socio.InsertarSocio(txtBoxNombre.Text, txtBoxApellido.Text, comboBoxSexo.Text, Convert.ToInt32(txtBoxDni.Text), datePickerFechaNac.Value.Date, txtBoxNacionalidad.Text, comboBoxEstcivil.Text, txtBoxDireccion.Text, Convert.ToInt64(txtBoxTelefono.Text), txtBoxEmail.Text, comboBoxPago.Text);
                    
                    FormExito.ConfirmarForm("Se ha guardado correctamente");
                    
                    
                    Close();
                    
                }
                catch (Exception ex)
                {
                    FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
                }
            }
            if (editar)
            {

                try
                {
                    Socio socio = new Socio();

                    FormSocioDeportivo form1 = new FormSocioDeportivo();

                    socio.EditarSocio(Convert.ToInt32(txtBoxIdSocio.Text), txtBoxNombre.Text, txtBoxApellido.Text, comboBoxSexo.Text, Convert.ToInt32(txtBoxDni.Text), datePickerFechaNac.Value.Date, txtBoxNacionalidad.Text, comboBoxEstcivil.Text, txtBoxDireccion.Text, Convert.ToInt64(txtBoxTelefono.Text), txtBoxEmail.Text, comboBoxPago.Text);
                    
                    FormExito.ConfirmarForm("Se ha editado correctamente");
                    form1.ListarSociosDeportivos();

                    Close();

                    
                    
                    editar = false;
                    
                }
                catch (Exception ex)
                {
                    FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
                }
            }
            
        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }
    }
}
