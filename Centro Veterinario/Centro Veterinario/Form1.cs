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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            String Usuario = textBox1.Text;
            String Password = textBox2.Text;
            if (Usuario.Equals("admin") && Password.Equals("contraseña"))
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

            }
        }
    }
}

