using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Projekt
{
    public partial class Sazetak : Form
    {
        public Sazetak()
        {
            InitializeComponent();
        }

        private void buttonSazetak_Click(object sender, EventArgs e)
        {
            string nazivDatoteke = textBoxDatoteka.Text;
            String pathPoruka = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, nazivDatoteke);
            if (File.Exists(pathPoruka))
            {
                string poruka = File.ReadAllText(pathPoruka);
                if(poruka != "")
                {
                    using (var sha = new System.Security.Cryptography.SHA256Managed())
                    {
                        byte[] tekstBajtovi = System.Text.Encoding.UTF8.GetBytes(poruka);
                        byte[] sazetakBajtovi = sha.ComputeHash(tekstBajtovi);
                        string sazetak = BitConverter.ToString(sazetakBajtovi).Replace("-", String.Empty);

                        String pathSazetak = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "sazetak.txt");
                        StreamWriter sw = new StreamWriter(pathSazetak);
                        sw.WriteLine(sazetak);
                        sw.Close();

                        MessageBox.Show("Sažetak izračunat!");
                    }
                }
                else
                {
                    MessageBox.Show("Molimo unesite poruku!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Datoteka s navedenim imenom ne postoji!");
                return;
            }
        }
    }
}
