using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Projekt
{
    public partial class DigitalniPotpis : Form
    {
        public DigitalniPotpis()
        {
            InitializeComponent();
        }

        private void buttonPotpisi_Click(object sender, EventArgs e)
        {
            String pathPrivatniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "privatni_kljuc.txt");
            StreamReader sr = new StreamReader(pathPrivatniKljuc);
            string privatniKljuc = sr.ReadLine();
            sr.Close();

            String pathPoruka = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "jasni_tekst.txt");
            string poruka = File.ReadAllText(pathPoruka);
            byte[] tempBajtovi = System.Text.Encoding.UTF8.GetBytes(poruka);
            string poruka64String = Convert.ToBase64String(tempBajtovi);
            byte[] porukaBajtovi = Convert.FromBase64String(poruka64String);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privatniKljuc);
                byte[] potpisanaPorukaBajtovi = RSA.SignData(porukaBajtovi, SHA256.Create());

                String pathDigitalniPotpis = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "digitalni_potpis.txt");
                StreamWriter sw = new StreamWriter(pathDigitalniPotpis);
                sw.WriteLine(Convert.ToBase64String(potpisanaPorukaBajtovi));
                sw.Close();
            }
        }

        private void buttonProvjeriPotpis_Click(object sender, EventArgs e)
        {
            String pathJavniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "javni_kljuc.txt");
            StreamReader sr = new StreamReader(pathJavniKljuc);
            string javniKljuc = sr.ReadLine();
            sr.Close();

            String pathDigitalniPotpis = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "digitalni_potpis.txt");
            sr = new StreamReader(pathDigitalniPotpis);
            string digitalniPotpis = sr.ReadLine();
            byte[] potpisanaPorukaBajtovi = Convert.FromBase64String(digitalniPotpis);
            
            sr.Close();

            String pathPoruka = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "jasni_tekst.txt");
            string poruka = File.ReadAllText(pathPoruka);
            byte[] tempBajtovi = System.Text.Encoding.UTF8.GetBytes(poruka);
            string poruka64String = Convert.ToBase64String(tempBajtovi);
            byte[] porukaBajtovi = Convert.FromBase64String(poruka64String);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(javniKljuc);

                if(RSA.VerifyData(porukaBajtovi, SHA256.Create(), potpisanaPorukaBajtovi))
                {
                    MessageBox.Show("Digitalni potpis je ispravan!");
                }
                else
                {
                    MessageBox.Show("Digitalni potpis nije ispravan!");
                }
            }
        }
    }
}