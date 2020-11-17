using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
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
                    entidades_Profesor.IdProfesor = Convert.ToInt32(txtBoxIdProfesor.Text);
                    entidades_Profesor.Nombre1 = txtBoxNombreProfesor.Text;
                    entidades_Profesor.Apellido1 = txtBoxApellidoProfesor.Text;
                    entidades_Profesor.Sexo1 = comboBoxSexoProfesor.Text;
                    entidades_Profesor.Dni1 = Convert.ToInt32(txtBoxDniProfesor.Text);
                    entidades_Profesor.Fechanac1 = datePickerFechaNacProfesor.Value.Date;
                    entidades_Profesor.Direccion1 = txtBoxDireccionProfesor.Text;
                    entidades_Profesor.Telefono1 = Convert.ToInt64(txtBoxTelefonoProfesor.Text);
                    entidades_Profesor.Email1 = txtBoxEmailProfesor.Text;

                    negocio_Profesor.EditarProfesor(entidades_Profesor);
                   
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
