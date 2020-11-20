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
            SocioDeportivo socio = new SocioDeportivo();
            
        }

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
