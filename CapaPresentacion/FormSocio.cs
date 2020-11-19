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
    public partial class FormSocio : Form
    {
        public FormSocio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();

        }

        public void listar()
        {
            Socio socio = new Socio();
            tablaSocio.DataSource = socio.ListarSocio();
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormMantenimientoSocio form = new FormMantenimientoSocio();
            form.ShowDialog();
            form.editar = false;
            listar();
        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            if (tablaSocio.SelectedRows.Count > 0)
            {
                DateTime fechanac;
                DateTime.TryParse(tablaSocio.CurrentRow.Cells[6].Value.ToString(), out fechanac);

                FormMantenimientoSocio form = new FormMantenimientoSocio();

                form.editar = true;

                form.txtBoxIdSocio.Text = tablaSocio.CurrentRow.Cells[0].Value.ToString();
                form.txtBoxNombreSocio.Text = tablaSocio.CurrentRow.Cells[2].Value.ToString();
                form.txtBoxApellidoSocio.Text = tablaSocio.CurrentRow.Cells[3].Value.ToString();
                form.comboBoxSexoSocio.Text = tablaSocio.CurrentRow.Cells[4].Value.ToString();
                form.txtBoxDniSocio.Text = tablaSocio.CurrentRow.Cells[5].Value.ToString();
                form.datePickerFechaNacSocio.Value = fechanac;
                form.txtBoxNacionalidadSocio.Text = tablaSocio.CurrentRow.Cells[7].Value.ToString();
                form.comboBoxEstadoCivilSocio.Text = tablaSocio.CurrentRow.Cells[8].Value.ToString();
                form.txtBoxDireccionSocio.Text = tablaSocio.CurrentRow.Cells[9].Value.ToString();
                form.txtBoxTelefonoSocio.Text = tablaSocio.CurrentRow.Cells[10].Value.ToString();
                form.txtBoxEmailSocio.Text = tablaSocio.CurrentRow.Cells[11].Value.ToString();
                form.ShowDialog();
                listar();

            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }

        private void txtBoxBuscarSocio_OnValueChanged(object sender, EventArgs e)
        {
            BuscarSocio(txtBoxBuscarSocio.Text);
        }

        public void BuscarSocio(string buscar)
        {
            Socio socio = new Socio();
            tablaSocio.DataSource = socio.BuscarSocio(buscar);
            
        }

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {

        }
    }
}
