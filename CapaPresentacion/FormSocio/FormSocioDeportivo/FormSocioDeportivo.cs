using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormSocioDeportivo : Form
    {
        public FormSocioDeportivo()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormMantenimientoSocioDeportivo form = new FormMantenimientoSocioDeportivo();
            form.ShowDialog();
        }
    }
}
