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
    }
}
