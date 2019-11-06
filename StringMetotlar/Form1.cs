using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ornekMetin = "";
        private void BtnCOMPARETO_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int result = ornekMetin.CompareTo("araba");
            string mesaj = "";
            switch (result)
            {
                case -1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, eksik karakter mevcut.";
                    break;
                case 0:
                    mesaj = "Kelime, diğer kelime ile eşleşmektedir.";
                    break;
                case 1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, fazla karakter mevcut.";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void BtnCONTAINS_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.Contains("adam");
            MessageBox.Show($"Aradığınız kelime metin içerisinde geçme{(result?"":"me")}ktedir");
        }

        private void BtnSTARTSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.StartsWith("bil");
            MessageBox.Show($"Metin parametrede gönderdiğiniz anahtar kelime ile başlama{(result ? "" : "ma")}ktadır");
        }

        private void BtnENDSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.EndsWith("dam");
            MessageBox.Show($"Metin parametrede gönderdiğiniz anahtar kelime ile bitme{(result ? "" : "me")}ktedir");
        }

        private void BtnINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('@');
            MessageBox.Show(index>-1 ? "Aradığınız karakterin metin içerisindeki index değeri : "+index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }

        private void BtnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.LastIndexOf('a');
            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri : " + index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }

        private void BtnREMOVE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            //ornekMetin = ornekMetin.Remove(5); // verilen index değeri dahil olmak üzere kalan tüm karakterleri siler
            ornekMetin = ornekMetin.Remove(3, 2); // 1. parametre: başlangıç değeri(oguzhan = u dan başla (uzh) yi sil # 2.parametre: silinecek eleman sayısı
            MessageBox.Show(ornekMetin);
        }

        private void BtnREPLACE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            //ornekMetin = ornekMetin.Replace("adam", "erkek");
            //MessageBox.Show(ornekMetin);

            ornekMetin = ornekMetin.Replace("İ", "I").Replace("Ö", "O").Replace("Ü", "U").Replace("Ş", "S").Replace("ı", "i").Replace("ö","o").Replace("ş","s").Replace("ç","c").Replace("Ç","C");

            MessageBox.Show(ornekMetin);
        }

        private void BtnSPLIT_Click(object sender, EventArgs e)
        {
            //string[] mailAdresler = txtGirisAlani.Text.Split(';');
            //foreach (string mail in mailAdresler)
            //{
            //    MessageBox.Show(mail);
            //}

            string[] data = txtGirisAlani.Text.Split('.',',','.',';','+');
            foreach (string item in data)
            {
                MessageBox.Show(item);
            }
        }

        private void BtnINSERT_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5, "cik");
            MessageBox.Show(ornekMetin);
        }

        private void BtnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            this.Text = txtGirisAlani.Text.ToLower();
            MessageBox.Show(txtGirisAlani.Text.ToUpper());
        }

        private void BtnSUBSTRING_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Substring(3,2);
            MessageBox.Show(ornekMetin);
        }

        private void BtnTOCHARARRAY_Click(object sender, EventArgs e)
        {
            //ornekMetin = txtGirisAlani.Text;
            //char[] karakterler = ornekMetin.ToCharArray();

            ornekMetin = txtGirisAlani.Text;
            char[] karakterler = ornekMetin.ToCharArray();
            int toplam = 0;

            //for (int i = 0; i < txtGirisAlani.Text.Length; i++)
            //{
            //    toplam += Convert.ToInt32(txtGirisAlani.Text[i]);
            //}
            //MessageBox.Show(toplam.ToString());

            foreach (char item in karakterler)
            {
                toplam += item;
            }
            MessageBox.Show(toplam.ToString());


        }

        private void BtnTRIM_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int l1 = ornekMetin.Length;
            ornekMetin = ornekMetin.Trim();
            int l2 = ornekMetin.Length;

            MessageBox.Show($"Metin boşluklar dahil toplamda: {l1} karakterden oluşmaktadır.\nMetin boşluklar silinerek toplamda {l2} karakterden oluşmaktadır.");
        }
    }
}
