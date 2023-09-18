using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwd_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Dil EKLEME
            langCombo.Items.Add("Türkçe");
            langCombo.Items.Add("Ingilizce");
            #endregion

            #region Numara Ekleme
            numberLenghCombo.Items.Add("ZAYIF");
            numberLenghCombo.Items.Add("6");
            numberLenghCombo.Items.Add("7");
            numberLenghCombo.Items.Add("8");
            numberLenghCombo.Items.Add("9");
            numberLenghCombo.Items.Add("10");
            numberLenghCombo.Items.Add("11");
            numberLenghCombo.Items.Add("12");
            numberLenghCombo.Items.Add("13");
            numberLenghCombo.Items.Add("14");
            numberLenghCombo.Items.Add("15");
            numberLenghCombo.Items.Add("GÜÇLÜ");
            numberLenghCombo.Items.Add("16");
            numberLenghCombo.Items.Add("17");
            numberLenghCombo.Items.Add("18");
            numberLenghCombo.Items.Add("19");
            numberLenghCombo.Items.Add("20");
            numberLenghCombo.Items.Add("21");
            numberLenghCombo.Items.Add("22");
            numberLenghCombo.Items.Add("23");
            numberLenghCombo.Items.Add("24");
            numberLenghCombo.Items.Add("25");
            numberLenghCombo.Items.Add("26");
            numberLenghCombo.Items.Add("27");
            numberLenghCombo.Items.Add("28");
            numberLenghCombo.Items.Add("29");
            numberLenghCombo.Items.Add("30");
            numberLenghCombo.Items.Add("31");
            numberLenghCombo.Items.Add("32");
            numberLenghCombo.Items.Add("33");
            numberLenghCombo.Items.Add("34");
            numberLenghCombo.Items.Add("35");
            numberLenghCombo.Items.Add("36");
            numberLenghCombo.Items.Add("37");
            numberLenghCombo.Items.Add("38");
            numberLenghCombo.Items.Add("39");
            numberLenghCombo.Items.Add("40");
            #endregion
        }

        #region Dil Ayarları
        private void langCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = langCombo.SelectedItem.ToString();

            #region Dil Değiştirme
            if (selectedValue == "Türkçe" || selectedValue == "Turkish")
            {
                langCombo.Items.Clear();
                langCombo.Items.Add("Türkçe");
                langCombo.Items.Add("Ingilizce");

                label1.Text = "Güvenli Şifre Oluşturucu";
                label2.Text = "Şifre uzunluğu:";
                label3.Text = "Sembolleri Dahil Et:";
                label4.Text = "Numaraları Dahil Et:";
                label5.Text = "Küçük Harf Karakterleri Dahil Et:";
                label6.Text = "Büyük Harf Karakterleri Dahil Et:";
                label7.Text = "Yeni Şifreleriniz:";

                passGeneratorBTN.Text = "Şifre oluştur";
                CopyBTN.Text = "Kopyala";
                
            }
            else if(selectedValue == "Ingilizce" || selectedValue == "English")
            {
                langCombo.Items.Clear();
                langCombo.Items.Add("Turkish");
                langCombo.Items.Add("English");

                label1.Text = "Secure Password Generator";
                label2.Text = "Password length:";
                label3.Text = "Include Symbols:";
                label4.Text = "Include Numbers:";
                label5.Text = "Include Lowercase Characters:";
                label6.Text = "Include Uppercase Characters:";
                label7.Text = "Your New Passwords:";

                passGeneratorBTN.Text = "Create Password";
                CopyBTN.Text = "Copy";
            }
            #endregion
        }
        #endregion

        private const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string digitChars = "0123456789";
        private const string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        private int length = 0;


        private void numberLenghCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            length = Convert.ToInt32(numberLenghCombo.SelectedItem.ToString());
        }

        private void passGeneratorBTN_Click(object sender, EventArgs e)
        {
            if (length == 0)
                MessageBox.Show("Lütfen Uzunluk Seçiniz", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);            
            

            bool useLowercase = küçükHarfCH.Checked;
            bool useUppercase = büyükHarfCH.Checked;
            bool useDigits = numaraCH.Checked;
            bool useSpecialChars = sembolCH.Checked;

            if(!useLowercase && !useUppercase && !useDigits && !useSpecialChars)
                MessageBox.Show("Lütfen Kullanmak İstediğiniz Özellikleri Seçiniz", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            StringBuilder passwordBuilder = new StringBuilder();
            Random rnd = new Random();

            while (passwordBuilder.Length < length)
            {
                if (useSpecialChars && passwordBuilder.Length < length)
                {
                    passwordBuilder.Append(specialChars[rnd.Next(specialChars.Length)]);
                }

                if (useDigits && passwordBuilder.Length < length)
                {
                    passwordBuilder.Append(digitChars[rnd.Next(digitChars.Length)]);
                }

                if (useLowercase && passwordBuilder.Length < length)
                {
                    passwordBuilder.Append(lowercaseChars[rnd.Next(lowercaseChars.Length)]);
                }

                if (useUppercase && passwordBuilder.Length < length)
                {
                    passwordBuilder.Append(uppercaseChars[rnd.Next(uppercaseChars.Length)]);
                }
            }

            newText.Text = passwordBuilder.ToString();
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            string originalText = newText.Text;
            string copyText = originalText;

            Clipboard.SetText(copyText);
        }
    }
}
