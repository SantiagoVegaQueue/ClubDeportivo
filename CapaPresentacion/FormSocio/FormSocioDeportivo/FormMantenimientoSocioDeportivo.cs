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
    public partial class FormMantenimientoSocioDeportivo : Form
    {
        
        public FormMantenimientoSocioDeportivo()
        {
            InitializeComponent();
        }

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
           
        }

        private void tablaListaProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMantenimientoSocioDeportivo_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel18_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDeporte_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SocioDeportivo socio = new SocioDeportivo();

                socio.InsertarSocioDeportivo(Convert.ToInt32(txtBoxIdSocio.Text), comboBoxInscripcion.Text);
                FormExito.ConfirmarForm("Se ha guardado correctamente");

                FormSocioDeportivo form = new FormSocioDeportivo();
                form.ListarSociosDeportivos();
                Close();
                
            }
            catch(Exception)
            {
                FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");

            }
        }
    }
}
