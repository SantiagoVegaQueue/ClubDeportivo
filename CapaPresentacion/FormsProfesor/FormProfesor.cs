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
    public partial class FormProfesor : Form
    {

        private string idProfesor;
        public string IdProfesor { get => idProfesor; set => idProfesor = value; }

        public FormProfesor()
        {
            InitializeComponent();
            listarProfesor();
        }

        private void FormProfesor_Load(object sender, EventArgs e)
        {
            listarProfesor();
            diseñoTablaProfesor();
        }

        #region Diseño e utilidades formulario
        public void diseñoTablaProfesor()
        {
            tablaProfesor.Columns[0].Visible = false;
            tablaProfesor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            tablaProfesor.ClearSelection();

        }

        private void limpiarTexBox()
        {
            
        }

        private void btnLimpiarCajas_Click(object sender, EventArgs e)
        {
            limpiarTexBox();
        }

        #endregion

        #region Listar profesores
        public void listarProfesor()
        {
            Profesor profesor = new Profesor();
            tablaProfesor.DataSource = profesor.ListarProfesor();
        }

        #endregion

        #region Buscar profesor
        public void buscarProfesor(string buscar)
        {
            Profesor negocioProfesor = new Profesor();
            tablaProfesor.DataSource = negocioProfesor.BuscarProfesor(buscar);
        }

        private void txtBoxBuscarProfesor_OnValueChanged(object sender, EventArgs e)
        {
            buscarProfesor(txtBoxBuscarProfesor.Text);
        }

        #endregion

        #region Agregar profesor
        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            FormMantenimientoProfesor form = new FormMantenimientoProfesor();

            form.ShowDialog();
            form.editar = false;
            listarProfesor();
        }

        #endregion

        #region Editar profesor
        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            if (tablaProfesor.SelectedRows.Count > 0)
            {
                DateTime fechanac;
                DateTime.TryParse(tablaProfesor.CurrentRow.Cells[6].Value.ToString(),out fechanac);

                FormMantenimientoProfesor form = new FormMantenimientoProfesor();

                form.editar = true;

                form.txtBoxIdProfesor.Text = tablaProfesor.CurrentRow.Cells[0].Value.ToString();
                form.txtBoxNombreProfesor.Text = tablaProfesor.CurrentRow.Cells[2].Value.ToString();
                form.txtBoxApellidoProfesor.Text = tablaProfesor.CurrentRow.Cells[3].Value.ToString();
                form.comboBoxSexoProfesor.Text = tablaProfesor.CurrentRow.Cells[4].Value.ToString();
                form.txtBoxDniProfesor.Text = tablaProfesor.CurrentRow.Cells[5].Value.ToString();
                form.datePickerFechaNacProfesor.Value = fechanac;
                form.txtBoxDireccionProfesor.Text = tablaProfesor.CurrentRow.Cells[7].Value.ToString();
                form.txtBoxTelefonoProfesor.Text = tablaProfesor.CurrentRow.Cells[8].Value.ToString();
                form.txtBoxEmailProfesor.Text = tablaProfesor.CurrentRow.Cells[9].Value.ToString();
                form.ShowDialog();
                
                listarProfesor();
                
            }
            else
            {
                FormNotificacion.VerificarForm("Seleccione una fila para editar");
            }
        }

        #endregion

        #region Eliminar profesor
        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (tablaProfesor.SelectedRows.Count > 0)
            {
                DialogResult result = new DialogResult();
                FormAdvertencia form = new FormAdvertencia("¿Estas seguro de eliminar?");
                result = form.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        Profesor negocioProfesor = new Profesor();
                        int idProfesor = Convert.ToInt32(tablaProfesor.CurrentRow.Cells[0].Value.ToString());
                        negocioProfesor.EliminarProfesor(idProfesor);

                        FormExito.ConfirmarForm("Se eliminó correctamente");
                        listarProfesor();
                    }     
            }
            else
            {
                FormNotificacion.VerificarForm("Seleccione una fila para eliminar");
            }

        }

        #endregion

        #region Basura
        private void tablaProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxNombreProfesor_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botón de exportar a PDF
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarPDF_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
