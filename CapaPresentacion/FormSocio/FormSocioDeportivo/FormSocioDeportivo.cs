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
    public partial class FormSocioDeportivo : Form
    {
        public FormSocioDeportivo()
        {
            InitializeComponent();
            ListarSociosDeportivos();
        }

        private void FormSocioDeportivo_Load(object sender, EventArgs e)
        {
            ListarSociosDeportivos();
            DiseñoTabla();
        }

        #region Diseño e utilidades del formulario
        public void DiseñoTabla()
        {
            tablaSocioDeportivo.Columns[0].Visible = false;
            tablaSocioDeportivo.Columns[1].Visible = false;
            tablaSocioDeportivo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        #endregion

        #region Listar socios deportivos
        public void ListarSociosDeportivos()
        {
            SocioDeportivo socio = new SocioDeportivo();
            tablaSocioDeportivo.DataSource = socio.ListarSocio();
        }

        #endregion


        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            FormMantenimientoSocioDeportivo form = new FormMantenimientoSocioDeportivo();
            form.ShowDialog();
        }

        #region Basura
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            if (tablaSocioDeportivo.SelectedRows.Count > 0)
            {
                FormResumen form = new FormResumen();
                form.lblCodigo.Text = tablaSocioDeportivo.CurrentRow.Cells[2].Value.ToString();
                form.lblNombre.Text = tablaSocioDeportivo.CurrentRow.Cells[3].Value.ToString();
                form.lblApellido.Text = tablaSocioDeportivo.CurrentRow.Cells[4].Value.ToString();
                form.lblDni.Text = tablaSocioDeportivo.CurrentRow.Cells[5].Value.ToString();
                form.lblDireccion.Text = tablaSocioDeportivo.CurrentRow.Cells[6].Value.ToString();
                form.lblTelefono.Text = tablaSocioDeportivo.CurrentRow.Cells[7].Value.ToString();
                form.lblTipoPago.Text = tablaSocioDeportivo.CurrentRow.Cells[8].Value.ToString();
                form.lblInscripcion.Text = tablaSocioDeportivo.CurrentRow.Cells[9].Value.ToString();

                form.ShowDialog();

            }
            
        }
    }
}
