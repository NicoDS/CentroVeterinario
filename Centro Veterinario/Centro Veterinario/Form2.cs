using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Veterinario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void NuevaMascota_Click(object sender, EventArgs e)
        {
            Nueva_Mascota frm = new Nueva_Mascota();
            frm.Show();
            this.Close();
        }

        private void NuevoUsuario_Click(object sender, EventArgs e)
        {
            Nuevo_Cliente frm = new Nuevo_Cliente();
            frm.Show();
            this.Close();
        }

        private void AnteriorCliente_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteCliente_Click(object sender, EventArgs e)
        {

        }

        private void AnteriorMascota_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteMascota_Click(object sender, EventArgs e)
        {

        }
    }
}
