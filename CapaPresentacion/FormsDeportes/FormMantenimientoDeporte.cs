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
    public partial class FormMantenimientoDeporte : Form
    {
        
        Deporte negocio_Deporte = new Deporte();
        public string idProf;
        public bool editar = false;

        public FormMantenimientoDeporte()
        {
            InitializeComponent();
            ListarProfesores();
        }
        private void FormMantenimientoDeporte_Load(object sender, EventArgs e)
        {
            diseñoTablaListaProfes();
        }
        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void diseñoTablaListaProfes()
        {
            tablaListaProfesores.Columns[0].Visible = false;
            tablaListaProfesores.Columns[4].Visible = false;
            tablaListaProfesores.Columns[6].Visible = false;
            tablaListaProfesores.Columns[7].Visible = false;
            tablaListaProfesores.Columns[9].Visible = false;

            tablaListaProfesores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void ListarProfesores()
        {
            Profesor profesor = new Profesor();
            tablaListaProfesores.DataSource = profesor.ListarProfesor();
        }

        private void btnGuardarDeporte_Click(object sender, EventArgs e)
        {
            Validaciones.ValidarCampos(ref txtBoxNombreDeporte, "string");
            
            if (!editar)
            {
                try
                {
                    if (tablaListaProfesores.SelectedRows.Count > 0)
                    {
                        Deporte depo = new Deporte();
                        txtBoxIdProfesor.Text = tablaListaProfesores.CurrentRow.Cells[0].Value.ToString();
                        
                        string nombre = txtBoxNombreDeporte.Text;
                        string horarios = comboBoxHorarios.Text;
                        string dias = comboBoxDiasDeporte.Text;
                        int idProfesor = Convert.ToInt32(idProf);

                        depo.InsertarDeporte(txtBoxNombreDeporte.Text, comboBoxDiasDeporte.Text, comboBoxHorarios.Text, Convert.ToInt32(txtBoxIdProfesor.Text));

                        FormExito.ConfirmarForm("Se ha guardado correctamente");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Elige un profesor");
                    }
                    

                }
                catch (Exception ex)
                {
                    FormNotificacion.VerificarForm("Atención. Uno o más datos son incorrectos");
                }
            }
            if (editar)
            {
                try
                {
                    if (tablaListaProfesores.SelectedRows.Count>0)
                    {
                        FormDeporte form = new FormDeporte();

                        string idProfe = tablaListaProfesores.CurrentRow.Cells[0].Value.ToString();

                        Deporte depo = new Deporte();

                        

                        depo.EditarDeporte(Convert.ToInt32(txtBoxIdDeporte.Text), txtBoxNombreDeporte.Text, comboBoxDiasDeporte.Text, comboBoxHorarios.Text, Convert.ToInt32(tablaListaProfesores.CurrentRow.Cells[0].Value.ToString()));

                        Close();
                        editar = false;
                    }
                    else
                    {
                        MessageBox.Show("Elija una fila");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar" + ex);
                }
            }
        }

        private void comboBoxProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profesor negocio_Profesor = new Profesor();

            
        }

        private void tablaListaProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
