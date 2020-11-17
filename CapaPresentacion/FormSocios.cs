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
    public partial class FormSocios : Form
    {
        Negocio_Socio Socio = new Negocio_Socio();
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            ListarSocio();
        }

        public void ListarSocio()
        {
            dgvSocios.DataSource = Socio.ListarSocio();
        }
    }
}
