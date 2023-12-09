using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Projekt
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void buttonSimetricna_Click(object sender, EventArgs e)
        {
            Form form = new SimetricnaKriptografija();
            form.ShowDialog();
        }

        private void buttonAsimetricna_Click(object sender, EventArgs e)
        {
            Form form = new AsimetricnaKriptografija();
            form.ShowDialog();
        }

        private void buttonSazetak_Click(object sender, EventArgs e)
        {
            Form form = new Sazetak();
            form.ShowDialog();
        }

        private void buttonDigitalniPotpis_Click(object sender, EventArgs e)
        {
            Form form = new DigitalniPotpis();
            form.ShowDialog();
        }
    }
}
