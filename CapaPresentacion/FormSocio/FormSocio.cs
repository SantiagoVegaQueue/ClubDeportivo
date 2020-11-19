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
        private void FormSocio_Load(object sender, EventArgs e)
        {
            ListarSocios();
            DiseñoTablaSocio();
            
        }

        #region Diseño e utilidades formulario
        public void DiseñoTablaSocio()
        {
            tablaSocio.Columns[0].Visible = false;
            tablaSocio.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            tablaSocio.ClearSelection();
        }

        #endregion

        #region Listar socios
        public void ListarSocios()
        {
            Socio socio = new Socio();
            tablaSocio.DataSource = socio.ListarSocio();
        }

        #endregion

        #region Buscar socios
        public void BuscarSocios(string buscar)
        {
            Socio socio = new Socio();
            tablaSocio.DataSource = socio.BuscarSocio(buscar);
        }

        private void txtBoxBuscarSocio_OnValueChanged(object sender, EventArgs e)
        {
            BuscarSocios(txtBoxBuscarSocio.Text);
        }

        #endregion

        #region Agregar socios
        
        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormMantenimientoSocio form = new FormMantenimientoSocio();
            form.ShowDialog();
            form.editar = false;
            ListarSocios();
            
        }

        #endregion

        #region Editar socios
        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            if (tablaSocio.SelectedRows.Count > 0)
            {
                DateTime fechanac;
                DateTime.TryParse(tablaSocio.CurrentRow.Cells[6].Value.ToString(), out fechanac);

                FormMantenimientoSocio form = new FormMantenimientoSocio();

                form.editar = true;

                form.txtBoxIdSocio.Text = tablaSocio.CurrentRow.Cells[0].Value.ToString();
                form.txtBoxNombre.Text = tablaSocio.CurrentRow.Cells[2].Value.ToString();
                form.txtBoxApellido.Text = tablaSocio.CurrentRow.Cells[3].Value.ToString();
                form.comboBoxSexo.Text = tablaSocio.CurrentRow.Cells[4].Value.ToString();
                form.txtBoxDni.Text = tablaSocio.CurrentRow.Cells[5].Value.ToString();
                form.datePickerFechaNac.Value = fechanac;
                form.txtBoxNacionalidad.Text = tablaSocio.CurrentRow.Cells[7].Value.ToString();
                form.comboBoxEstcivil.Text = tablaSocio.CurrentRow.Cells[8].Value.ToString();
                form.txtBoxDireccion.Text = tablaSocio.CurrentRow.Cells[9].Value.ToString();
                form.txtBoxTelefono.Text = tablaSocio.CurrentRow.Cells[10].Value.ToString();
                form.txtBoxEmail.Text = tablaSocio.CurrentRow.Cells[11].Value.ToString();

                form.ShowDialog();
                ListarSocios();

            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }
        #endregion

        #region Eliminar socios
        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            if (tablaSocio.SelectedRows.Count > 0)
            {
                Socio socio = new Socio();
                int idSocio = Convert.ToInt32(tablaSocio.CurrentRow.Cells[0].Value.ToString());
                socio.EliminarSocio(idSocio);

                MessageBox.Show("Se elimino");
                ListarSocios();
            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }




        #endregion

        
    }
}
