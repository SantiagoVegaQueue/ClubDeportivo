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
        Negocio_Socio Socio = new Negocio_Socio();
        public bool editar = false;

        public FormMantenimientoSocio()
        {
            InitializeComponent();
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                try
                {
                    string nombre = txtBoxNombreSocio.Text;
                    string apellido = txtBoxApellidoSocio.Text;
                    string sexo = comboBoxSexoSocio.Text;
                    int dni = Convert.ToInt32(txtBoxDniSocio.Text);
                    DateTime fechanac = datePickerFechaNacSocio.Value.Date;
                    string nacionalidad = txtBoxNacionalidadSocio.Text;
                    string estcivil = comboBoxEstadoCivil.Text;
                    string direccion = txtBoxDireccionSocio.Text;
                    long telefono = Convert.ToInt64(txtBoxTelefonoSocio.Text);
                    string email = txtBoxEmailSocio.Text;

                    Socio.InsertarSocio(nombre, apellido, sexo, dni, fechanac, nacionalidad, estcivil, direccion, telefono, email);
                    Close();
                    
                    MessageBox.Show("Se guardó correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema" + ex + " no se pudo guardar los datos");
                }
            }
            if(editar)
            {
                try
                {
                    int idSocio = Convert.ToInt32(txtBoxIdSocio.Text);
                    string nombre = txtBoxNombreSocio.Text;
                    string apellido = txtBoxApellidoSocio.Text;
                    string sexo = comboBoxSexoSocio.Text;
                    int dni = Convert.ToInt32(txtBoxDniSocio.Text);
                    DateTime fechanac = datePickerFechaNacSocio.Value;
                    string nacionalidad = txtBoxNacionalidadSocio.Text;
                    string estcivil = comboBoxEstadoCivil.Text;
                    string direccion = txtBoxDireccionSocio.Text;
                    long telefono = Convert.ToInt64(txtBoxTelefonoSocio.Text);
                    string email = txtBoxEmailSocio.Text;

                    Socio.EditarSocio(idSocio, nombre, apellido, sexo, dni, fechanac, nacionalidad, estcivil, direccion, telefono, email);
                    Close();
                    editar = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema" + ex + " no se pudo guardar los datos");

                }
            }
        }
    }
}
