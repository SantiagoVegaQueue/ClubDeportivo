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
        
        Negocio_Profesor negocio_Profesor = new Negocio_Profesor();
        public bool editar = false;

        public FormMantenimientoProfesor()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarProfesor_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                try
                {
                    string nombre = txtBoxNombreProfesor.Text;
                    string apellido = txtBoxApellidoProfesor.Text;
                    string sexo = comboBoxSexoProfesor.Text;
                    int dni = Convert.ToInt32(txtBoxDniProfesor.Text);
                    DateTime fechanac = datePickerFechaNacProfesor.Value.Date;
                    string direccion = txtBoxDireccionProfesor.Text;
                    long telefono = Convert.ToInt64(txtBoxTelefonoProfesor.Text);
                    string email = txtBoxEmailProfesor.Text;

                    negocio_Profesor.InsertarProfesor(nombre, apellido, sexo, dni, fechanac, direccion, telefono, email);
                   
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
                    int idProfe = Convert.ToInt32(txtBoxIdProfesor.Text);
                    string nombre = txtBoxNombreProfesor.Text;
                    string apellido = txtBoxApellidoProfesor.Text;
                    string sexo = comboBoxSexoProfesor.Text;
                    int dni = Convert.ToInt32(txtBoxDniProfesor.Text);
                    DateTime fechanac = datePickerFechaNacProfesor.Value.Date;
                    string direccion = txtBoxDireccionProfesor.Text;
                    long telefono = Convert.ToInt64(txtBoxTelefonoProfesor.Text);
                    string email = txtBoxEmailProfesor.Text;

                    negocio_Profesor.EditarProfesor(idProfe, nombre, apellido, sexo, dni, fechanac, direccion, telefono, email);
                   
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
