using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;

namespace OS_Projekt
{
    public partial class AsimetricnaKriptografija : Form
    {
        public AsimetricnaKriptografija()
        {
            InitializeComponent();
        }

        private void buttonStvoriKljuceve_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                try
                {
                    String pathJavniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "javni_kljuc.txt");
                    StreamWriter sw = new StreamWriter(pathJavniKljuc);
                    sw.WriteLine(RSA.ToXmlString(false));
                    sw.Close();

                    String pathPrivatniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "privatni_kljuc.txt");
                    sw = new StreamWriter(pathPrivatniKljuc);
                    sw.WriteLine(RSA.ToXmlString(true));
                    sw.Close();

                    MessageBox.Show("Ključevi stvoreni!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }

            }
        }

        private void buttonSifriraj_Click(object sender, EventArgs e)
        {
            try
            {
                String pathJavniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "javni_kljuc.txt");
                StreamReader sr = new StreamReader(pathJavniKljuc);
                string javniKljuc = sr.ReadLine();
                sr.Close();

                String pathJasniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "jasni_tekst.txt");
                string jasniTekst = File.ReadAllText(pathJasniTekst);

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.FromXmlString(javniKljuc);

                    byte[] tempBajtovi = System.Text.Encoding.UTF8.GetBytes(jasniTekst);
                    string jasniTekst64String = Convert.ToBase64String(tempBajtovi);

                    byte[] jasniTekstBajtovi = Convert.FromBase64String(jasniTekst64String);

                    byte[] kriptiraniTekstBajtovi = RSA.Encrypt(jasniTekstBajtovi, true);
                    
                    String pathKriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "kriptirani_tekst.txt");
                    StreamWriter sw = new StreamWriter(pathKriptiraniTekst);
                    sw.WriteLine(Convert.ToBase64String(kriptiraniTekstBajtovi));
                    sw.Close();

                    MessageBox.Show("Tekst kriptiran!");
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDesifriraj_Click(object sender, EventArgs e)
        {
            try
            {
                String pathPrivatniKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "privatni_kljuc.txt");
                StreamReader sr = new StreamReader(pathPrivatniKljuc);
                string privatniKljuc = sr.ReadLine();
                sr.Close();

                String pathKriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "kriptirani_tekst.txt");
                sr = new StreamReader(pathKriptiraniTekst);
                string kriptiraniTekst = sr.ReadLine();
                sr.Close();

                byte[] kriptiraniTekstBajtovi = Convert.FromBase64String(kriptiraniTekst);

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.FromXmlString(privatniKljuc);

                    byte[] dekriptiraniTekstBajtovi = RSA.Decrypt(kriptiraniTekstBajtovi, true);
                    string dekriptiraniTekst64String = Convert.ToBase64String(dekriptiraniTekstBajtovi);
                    byte[] tempBajtovi = Convert.FromBase64String(dekriptiraniTekst64String);
                    string dekriptiraniTekst = System.Text.Encoding.UTF8.GetString(tempBajtovi);

                    String pathDekriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "dekriptirani_tekst.txt");
                    StreamWriter sw = new StreamWriter(pathDekriptiraniTekst);
                    sw.WriteLine(dekriptiraniTekst);
                    sw.Close();

                    MessageBox.Show("Tekst dekriptiran!");
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
