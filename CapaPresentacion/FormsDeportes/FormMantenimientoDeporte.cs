using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormMantenimientoDeporte : Form
    {
        Entidades_Deporte entidades_Deporte = new Entidades_Deporte();
        Negocio_Deporte negocio_Deporte = new Negocio_Deporte();
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
            Negocio_Profesor negocio_Profesor = new Negocio_Profesor();
            tablaListaProfesores.DataSource = negocio_Profesor.ListarProfesor();

            /*comboBoxProfesores.DataSource = negocio_Profesor.ListarProfesor();
            comboBoxProfesores.ValueMember = "IdProfesor";
            comboBoxProfesores.DisplayMember = "Nombre";

            comboBoxApellidoProfesores.DataSource = negocio_Profesor.ListarProfesor();
            comboBoxApellidoProfesores.ValueMember = "IdProfesor";
            comboBoxApellidoProfesores.DisplayMember = "Apellido";

            comboBoxDniProfesores.DataSource = negocio_Profesor.ListarProfesor();
            comboBoxDniProfesores.ValueMember = "IdProfesor";
            comboBoxDniProfesores.DisplayMember = "Dni";

            comboBoxTelefonoProfesores.DataSource = negocio_Profesor.ListarProfesor();
            comboBoxTelefonoProfesores.ValueMember = "IdProfesor";
            comboBoxTelefonoProfesores.DisplayMember = "Telefono";
            */


        }

        private void btnGuardarDeporte_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                try
                {
                    if (tablaListaProfesores.SelectedRows.Count > 0)
                    {
                        idProf = tablaListaProfesores.CurrentRow.Cells[0].Value.ToString();
                        entidades_Deporte.Nombre1 = txtBoxNombreDeporte.Text;
                        entidades_Deporte.Horarios1 = comboBoxHorarios.Text;
                        entidades_Deporte.Dias1 = comboBoxDiasDeporte.Text;
                        entidades_Deporte.IdProfesor = Convert.ToInt32(idProf);
                        

                        negocio_Deporte.InsertarDeporte(entidades_Deporte);

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Elige un profesor");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar" + ex);
                }
            }
            if (editar)
            {
                try
                {
                    if (tablaListaProfesores.SelectedRows.Count>0)
                    {
                        idProf = tablaListaProfesores.CurrentRow.Cells[0].Value.ToString();
                        entidades_Deporte.IdDeporte = Convert.ToInt32(txtBoxIdDeporte.Text);
                        entidades_Deporte.Nombre1 = txtBoxNombreDeporte.Text;
                        entidades_Deporte.Horarios1 = comboBoxHorarios.Text;
                        entidades_Deporte.Dias1 = comboBoxDiasDeporte.Text;
                        entidades_Deporte.IdProfesor = Convert.ToInt32(idProf);

                        negocio_Deporte.EditarDeporte(entidades_Deporte);



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
            Negocio_Profesor negocio_Profesor = new Negocio_Profesor();

            
        }

        
    }
}
