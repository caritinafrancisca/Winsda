using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winsda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAzul azul = new FormAzul();
            azul.Show();
        }

        private void formVerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formverde verde = new Formverde();
            verde.Show();
        }
    }
}
