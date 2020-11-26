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
            
        }
        private void FormSocioPleno_Load(object sender, EventArgs e)
        {
            ListarSocioPlenos();
            DiseñoTabla();
        }
        public void ListarSocioPlenos()
        {
            SocioPleno socio = new SocioPleno();
            tablaSocioPleno.DataSource = socio.ListarSocioPleno();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaSocioPleno.SelectedRows.Count > 0)
            {
                DialogResult result = new DialogResult();
                FormAdvertencia form = new FormAdvertencia("¿Estas seguro de eliminar?");
                result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Socio socio = new Socio();
                    int idSocio = Convert.ToInt32(tablaSocioPleno.CurrentRow.Cells[0].Value.ToString());
                    socio.EliminarSocio(idSocio);

                    FormExito.ConfirmarForm("Se eliminó correctamente");
                    ListarSocioPlenos();
                }

            }
            else
            {
                FormNotificacion.VerificarForm("Seleccione una fila para eliminar");
            }
        }

        public void BuscarSocios(string buscar)
        {
            SocioPleno socio = new SocioPleno();
            tablaSocioPleno.DataSource = socio.BuscarSocio(buscar);
        }


        private void txtBoxBuscarSocio_OnValueChanged(object sender, EventArgs e)
        {
            BuscarSocios(txtBoxBuscarSocio.Text);
        }

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            if(tablaSocioPleno.SelectedRows.Count > 0)
            {
                FormResumen2 form = new FormResumen2();


                form.lblCodigo.Text = tablaSocioPleno.CurrentRow.Cells[2].Value.ToString();
                form.lblNombre.Text = tablaSocioPleno.CurrentRow.Cells[3].Value.ToString();
                form.lblApellido.Text = tablaSocioPleno.CurrentRow.Cells[4].Value.ToString();
                form.lblDni.Text = tablaSocioPleno.CurrentRow.Cells[5].Value.ToString();
                form.lblDireccion.Text = tablaSocioPleno.CurrentRow.Cells[6].Value.ToString();
                form.lblTelefono.Text = tablaSocioPleno.CurrentRow.Cells[7].Value.ToString();
                form.lblTipoPago.Text = tablaSocioPleno.CurrentRow.Cells[8].Value.ToString();
                form.lblPlan.Text = tablaSocioPleno.CurrentRow.Cells[9].Value.ToString();


                ListarSocioPlenos();
                form.ShowDialog();

            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ImprimirPDF.printTabla(ref tablaSocioPleno);
        }
    }
}
