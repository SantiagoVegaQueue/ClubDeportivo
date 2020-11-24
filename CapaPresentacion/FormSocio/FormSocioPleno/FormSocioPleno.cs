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
    public partial class FormSocioPleno : Form
    {
        public FormSocioPleno()
        {
            InitializeComponent();
            ListarSocioPlenos();
        }
        private void FormSocioPleno_Load(object sender, EventArgs e)
        {
            ListarSocioPlenos();
            DiseñoTabla();
        }
        public void ListarSocioPlenos()
        {
            //SocioPleno socio = new SocioPleno();
            //tablaSocioPleno.DataSource = socio.ListarSocio();

        }
        public void DiseñoTabla()
        {
            tablaSocioPleno.Columns[0].Visible = false;
            tablaSocioPleno.Columns[1].Visible = false;
            tablaSocioPleno.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
