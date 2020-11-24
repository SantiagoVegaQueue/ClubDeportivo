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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SocioPleno socio = new SocioPleno();

                

                socio.InsertarSocioPleno(Convert.ToInt32(txtBoxIdSocio.Text), comboBoxTipoPlan.Text);
                FormExito.ConfirmarForm("Se ha guardado correctamente");
                

                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PASO ESTO PAI: " + ex);
                //FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
            }
        }
    }
}
