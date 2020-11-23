using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormExito : Form
    {
        public FormExito(string mensaje)
        {
            InitializeComponent();
            labelMensaje.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormSocioDeportivo form = new FormSocioDeportivo();
            form.ListarSociosDeportivos();
            this.Close();
            
        }

        public static void ConfirmarForm(string mensaje)
        {
            FormExito form = new FormExito(mensaje);
            form.ShowDialog();
        }
    }
}
