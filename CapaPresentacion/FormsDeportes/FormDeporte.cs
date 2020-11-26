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

        #region Diseño e utilidades formulario
        public void DiseñoTablaDeporte()
        {
            tablaDeporte.Columns[0].Visible = false;
            tablaDeporte.Columns[1].Visible = false;
            tablaDeporte.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        #endregion

        #region Listar deporte
        public void ListarDeporte()
        {
            Deporte deporte = new Deporte();
            tablaDeporte.DataSource = deporte.ListarDeporte();
        }

        #endregion

        #region Buscar deporte
        public void BuscarDeporte(string buscar)
        {
            Deporte deporte = new Deporte();
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

        #region Agregar deporte
        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            FormMantenimientoDeporte formMantenimientoDeporte = new FormMantenimientoDeporte();
            formMantenimientoDeporte.ShowDialog();
            formMantenimientoDeporte.editar = false;
            ListarDeporte();
        }
        #endregion

        #region Editar deporte
        private void btnEditarDeporte_Click(object sender, EventArgs e)
        {
            if (tablaDeporte.SelectedRows.Count > 0)
            {
                FormMantenimientoDeporte form = new FormMantenimientoDeporte();

                form.editar = true;
                form.txtBoxIdDeporte.Text = tablaDeporte.CurrentRow.Cells[0].Value.ToString();
                form.txtBoxIdProfesor.Text = tablaDeporte.CurrentRow.Cells[1].Value.ToString();
                form.txtBoxNombreDeporte.Text = tablaDeporte.CurrentRow.Cells[3].Value.ToString();
                form.comboBoxDiasDeporte.Text = tablaDeporte.CurrentRow.Cells[6].Value.ToString();
                form.comboBoxHorarios.Text = tablaDeporte.CurrentRow.Cells[7].Value.ToString();

                form.ShowDialog();
                ListarDeporte();

            }
            else
            {
                FormNotificacion.VerificarForm("Seleccione una fila para editar");
            }
        }
        #endregion

        #region Eliminar deporte
        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            if (tablaDeporte.SelectedRows.Count > 0)
            {
                DialogResult result = new DialogResult();
                FormAdvertencia form = new FormAdvertencia("¿Estas seguro de eliminar?");
                result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Deporte depo = new Deporte();
                    int idDeporte = Convert.ToInt32(tablaDeporte.CurrentRow.Cells[0].Value.ToString());
                    depo.EliminarDeporte(idDeporte);

                    FormExito.ConfirmarForm("Se eliminó correctamente");
                    ListarDeporte();
                }


            }
            else
            {
                FormNotificacion.VerificarForm("Seleccione una fila para eliminar");
            }
        }
        #endregion

        #region Basura
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Imprimir PDF
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ImprimirPDF.printTabla(ref tablaDeporte);
        }
        #endregion

    }
}
