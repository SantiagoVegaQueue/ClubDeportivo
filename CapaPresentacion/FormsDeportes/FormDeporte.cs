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
    public partial class FormDeporte : Form
    {
        Negocio_Deporte negocio_Deporte = new Negocio_Deporte();
        public FormDeporte()
        {
            InitializeComponent();
        }

        private void FormDeporte_Load(object sender, EventArgs e)
        {
            ListarDeporte();
            DiseñoTablaDeporte();
            tablaDeporte.ClearSelection();
        }

        public void DiseñoTablaDeporte()
        {
            tablaDeporte.Columns[0].Visible = false;
            tablaDeporte.Columns[1].Visible = false;
            tablaDeporte.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        #region Listar deporte
        public void ListarDeporte()
        {
            Negocio_Deporte deporte = new Negocio_Deporte();
            tablaDeporte.DataSource = deporte.ListarDeporte();
        }

        #endregion

        #region Buscar deporte
        public void BuscarDeporte(string buscar)
        {
            Negocio_Deporte deporte = new Negocio_Deporte();
            tablaDeporte.DataSource = deporte.BuscarDeporte(buscar);
        }

        private void txtBoxBuscarDeporte_OnValueChanged(object sender, EventArgs e)
        {
            BuscarDeporte(txtBoxBuscarDeporte.Text);
        }

        private void txtBoxBuscarProfesor_OnValueChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            FormMantenimientoDeporte formMantenimientoDeporte = new FormMantenimientoDeporte();
            formMantenimientoDeporte.ShowDialog();
            formMantenimientoDeporte.editar = false;
            ListarDeporte();
        }

        private void btnEditarDeporte_Click(object sender, EventArgs e)
        {
            if (tablaDeporte.SelectedRows.Count > 0)
            {
                FormMantenimientoDeporte formMantenimientoDeporte = new FormMantenimientoDeporte();

                formMantenimientoDeporte.editar = true;
                formMantenimientoDeporte.txtBoxIdDeporte.Text = tablaDeporte.CurrentRow.Cells[0].Value.ToString();
                formMantenimientoDeporte.txtBoxIdProfesor.Text= tablaDeporte.CurrentRow.Cells[1].Value.ToString();
                formMantenimientoDeporte.txtBoxNombreDeporte.Text = tablaDeporte.CurrentRow.Cells[3].Value.ToString();
                formMantenimientoDeporte.comboBoxDiasDeporte.Text = tablaDeporte.CurrentRow.Cells[6].Value.ToString();
                formMantenimientoDeporte.comboBoxHorarios.Text = tablaDeporte.CurrentRow.Cells[7].Value.ToString();

                formMantenimientoDeporte.ShowDialog();
                ListarDeporte();

            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            if (tablaDeporte.SelectedRows.Count > 0)
            {
                int idDeporte = Convert.ToInt32(tablaDeporte.CurrentRow.Cells[0].Value.ToString());
                negocio_Deporte.EliminarDeporte(idDeporte);

                MessageBox.Show("Se elimino");
                ListarDeporte();
            }
            else
            {
                MessageBox.Show("Elija una fila");
            }
        }
    }
}
