using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeless
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        string[] listPaises = { "Argentina", "Brasil", "Chile", "Colombia", "México", "Perú" };

        void selectPais()
        {
            for (int i = 0; i < listPaises.Length; i++)
            {
                cmbPaises.Items.Add(listPaises[i]);
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            selectPais();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            if ((txbNombre.Text.Trim() != String.Empty) && (txbNombre.Text.All(Char.IsLetter)))
            {
                errorProvider1.SetError(txbNombre, "");
            }

            else if ((txbNombre.Text.Trim() != String.Empty) && (!(txbNombre.Text.All(Char.IsLetter))))
            {
                errorProvider1.SetError(txbNombre, "Su nombre solo debe estar formado por letras");
            }

            else if ((txbNombre.Text.Trim() == String.Empty) && (cmbPaises.SelectedIndex >= 0 || (cmbPaises.SelectedIndex <= -1)))
            {
                errorProvider1.SetError(txbNombre, "");
            }
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbPaises.SelectedIndex >= 0))
            {
                errorProvider2.SetError(cmbPaises, "");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((txbNombre.Text.Trim() != String.Empty) && (txbNombre.Text.All(Char.IsLetter)) && (cmbPaises.SelectedIndex >= 0))
            {
                errorProvider1.SetError(txbNombre, "");
                errorProvider2.SetError(cmbPaises, "");
                using (FormServices Services = new FormServices(/*txbNombre.Text, cmbPaises.SelectedItem.ToString()*/))
                    Services.ShowDialog();
            }

            else if ((txbNombre.Text.Trim() == String.Empty) && (cmbPaises.SelectedIndex <= -1))
            {
                errorProvider1.SetError(txbNombre, "Debe ingresar su nombre");
                errorProvider2.SetError(cmbPaises, "Debe seleccionar su país");
            }

            else if ((txbNombre.Text.Trim() != String.Empty) && (txbNombre.Text.All(Char.IsLetter)) && (cmbPaises.SelectedIndex <= -1))
            {
                errorProvider1.SetError(txbNombre, "");
                errorProvider2.SetError(cmbPaises, "Selecciona tu pais");
            }

            else if ((txbNombre.Text.Trim() == String.Empty) && (cmbPaises.SelectedIndex >= 0))
            {
                errorProvider1.SetError(txbNombre, "Debe ingresar su nombre");
                errorProvider2.SetError(cmbPaises, "");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
