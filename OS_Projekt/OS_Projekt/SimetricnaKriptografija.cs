using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;

namespace OS_Projekt
{
    public partial class SimetricnaKriptografija : Form
    {
        public SimetricnaKriptografija()
        {
            InitializeComponent();
        }

        private void buttonStvoriKljuc_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                try
                {
                    String path = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "tajni_kljuc.txt");
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(Convert.ToBase64String(myAes.Key));
                    sw.Close();

                    MessageBox.Show("Ključ stvoren!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        private void buttonSifriraj_Click(object sender, EventArgs e)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] kriptiraniTekstBajtovi = null;

                try
                {
                    String pathKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "tajni_kljuc.txt");
                    StreamReader sr = new StreamReader(pathKljuc);
                    aes.Key = Convert.FromBase64String(sr.ReadLine());
                    sr.Close();

                    String pathJasniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "jasni_tekst.txt");
                    string jasniTekst = File.ReadAllText(pathJasniTekst);

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    using (MemoryStream mse = new MemoryStream())
                    {
                        using (CryptoStream cse = new CryptoStream(mse, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swe = new StreamWriter(cse))
                            {
                                swe.Write(jasniTekst);
                            }
                            kriptiraniTekstBajtovi = mse.ToArray();
                        }
                    }

                    MessageBox.Show("Tekst kriptiran!");
                    String pathKriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "kriptirani_tekst.txt");
                    StreamWriter sw = new StreamWriter(pathKriptiraniTekst);
                    sw.WriteLine(Convert.ToBase64String(kriptiraniTekstBajtovi));
                    sw.Close();

                    String pathInicijacijskiVektor = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "inicijacijski_vektor.txt");
                    sw = new StreamWriter(pathInicijacijskiVektor);
                    sw.WriteLine(Convert.ToBase64String(aes.IV));
                    sw.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                } 
            }
        }

        private void buttonDesifriraj_Click(object sender, EventArgs e)
        {
            try
            {
                String dekriptiraniTekst;

                String pathKljuc = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "tajni_kljuc.txt");
                StreamReader sr = new StreamReader(pathKljuc);
                byte[] kljuc = Convert.FromBase64String(sr.ReadLine());
                sr.Close();

                String pathKriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "kriptirani_tekst.txt");
                sr = new StreamReader(pathKriptiraniTekst);
                byte[] kriptiraniTekstBajtovi = Convert.FromBase64String(sr.ReadLine());
                sr.Close();

                String pathInicijacijskiVektor = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "inicijacijski_vektor.txt");
                sr = new StreamReader(pathInicijacijskiVektor);
                byte[] inicijaciskiVektorBajtovi = Convert.FromBase64String(sr.ReadLine());
                sr.Close();

                using (Aes aes = Aes.Create())
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor(kljuc, inicijaciskiVektorBajtovi);
                    using (MemoryStream msd = new MemoryStream(kriptiraniTekstBajtovi))
                    {
                        using (CryptoStream csd = new CryptoStream(msd, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srd = new StreamReader(csd))
                            {
                                dekriptiraniTekst = srd.ReadToEnd();
                            }
                        }
                    }
                }

                String pathDekriptiraniTekst = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "dekriptirani_tekst.txt");
                StreamWriter sw = new StreamWriter(pathDekriptiraniTekst);
                sw.WriteLine(dekriptiraniTekst);
                sw.Close();

                MessageBox.Show("Tekst Dekriptiran!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
