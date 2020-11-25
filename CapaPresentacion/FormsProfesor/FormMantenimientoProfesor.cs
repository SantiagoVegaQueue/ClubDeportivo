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
    public partial class FormMantenimientoProfesor : Form
    {
        FormProfesor formProfesor = new FormProfesor();
        public bool editar = false;

        public FormMantenimientoProfesor()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Guardar datos
        private void btnGuardarProfesor_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxNombreProfesor, "string");
            Validaciones.ValidarCampos(ref txtBoxApellidoProfesor, "string");
            Validaciones.ValidarCampos(ref txtBoxDireccionProfesor, "string");
            Validaciones.ValidarCampos(ref txtBoxDniProfesor, "int");
            Validaciones.ValidarCampos(ref txtBoxTelefonoProfesor, "long");
            Validaciones.ValidarCampos(ref txtBoxEmailProfesor, "string");
            //Validaciones.ValidarCampoCombo(ref comboBoxSexoProfesor, "string");

            if (!editar)
            {
                try
                {
                    Profesor profesor = new Profesor();

                    profesor.InsertarProfesor(txtBoxNombreProfesor.Text, txtBoxApellidoProfesor.Text, comboBoxSexoProfesor.Text, Convert.ToInt32(txtBoxDniProfesor.Text), datePickerFechaNacProfesor.Value.Date, txtBoxDireccionProfesor.Text, Convert.ToInt64(txtBoxTelefonoProfesor.Text), txtBoxEmailProfesor.Text);

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
                    Profesor profesor = new Profesor();

                    profesor.EditarProfesor(Convert.ToInt32(txtBoxIdProfesor.Text), txtBoxNombreProfesor.Text, txtBoxApellidoProfesor.Text, comboBoxSexoProfesor.Text, Convert.ToInt32(txtBoxDniProfesor.Text), datePickerFechaNacProfesor.Value.Date, txtBoxDireccionProfesor.Text, Convert.ToInt64(txtBoxTelefonoProfesor.Text), txtBoxEmailProfesor.Text);

                    FormExito.ConfirmarForm("Se ha editado correctamente");
                    Close();
                    editar = false;
                }
                catch (Exception ex)
                {
                    FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
                }
            }

        }
        #endregion

    }
}
