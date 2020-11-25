using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public static class Validaciones
    {
        public static void ValidarCampos(ref Bunifu.Framework.UI.BunifuMetroTextbox campo, string tipo)
        {
            switch (tipo)
            {
                case "string":
                    if (campo.Text != "")
                    {
                        try
                        {
                            Convert.ToString(campo.Text);
                            campo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                        }
                    }
                    else
                    {
                        campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                    }
                    break;

                case "int":
                    if (campo.Text != "")
                    {
                        try
                        {
                            Convert.ToInt32(campo.Text);
                            campo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                        }
                    }
                    else
                    {
                        campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                    }
                    break;

                case "long":
                    if(campo.Text != "")
                    {
                        try
                        {
                            Convert.ToInt64(campo.Text);
                            campo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                        }
                    }
                    else
                    {
                        campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                    }
                    break;

                default:
                    break;

            }
        }

        public static void ValidarCampoCombo(ref ComboBox campo, string tipo)
        {
            switch (tipo)
            {
                case "string":
                    if (campo.Text == "")
                    {
                        campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                       
                    }
                    else
                    {
                        try
                        {
                            Convert.ToString(campo.Text);
                            campo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.FromArgb(255, 183, 170);
                        }
                    }
                    break;
                default:
                    break;
            }
       
        }

        
    }
}
