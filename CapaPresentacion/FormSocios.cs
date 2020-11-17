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
        private string idSocio;
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

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormMantenimientoSocio form = new FormMantenimientoSocio();
            form.ShowDialog();
            form.editar = false;
            ListarSocio();
        }

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count>0)
            {
                FormMantenimientoSocio form = new FormMantenimientoSocio();

                form.editar = true;

                form.txtBoxIdSocio.Text = dgvSocios.CurrentRow.Cells[0].Value.ToString();
                form.txtBoxNombreSocio.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
                form.txtBoxApellidoSocio.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
                form.comboBoxSexoSocio.Text = dgvSocios.CurrentRow.Cells[4].Value.ToString();
                form.txtBoxDniSocio.Text = dgvSocios.CurrentRow.Cells[5].Value.ToString();
                form.datePickerFechaNacSocio.Text = dgvSocios.CurrentRow.Cells[6].Value.ToString();
                form.txtBoxNacionalidadSocio.Text = dgvSocios.CurrentRow.Cells[7].Value.ToString();
                form.comboBoxEstadoCivil.Text = dgvSocios.CurrentRow.Cells[8].Value.ToString();
                form.txtBoxDireccionSocio.Text = dgvSocios.CurrentRow.Cells[9].Value.ToString();
                form.txtBoxTelefonoSocio.Text = dgvSocios.CurrentRow.Cells[10].Value.ToString();
                form.txtBoxEmailSocio.Text = dgvSocios.CurrentRow.Cells[11].Value.ToString();

                form.ShowDialog();

                ListarSocio();

            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }
    }
}
