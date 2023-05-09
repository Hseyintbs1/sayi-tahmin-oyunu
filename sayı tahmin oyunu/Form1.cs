using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sayı_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        int kucuksayi,
            buyuksayi,
            S1,
            can,
            puan = 0;
            

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            kucuksayi = Convert.ToUInt16(KucukSayi.Value);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KucukSayi.Value = 0;
            BuyukSayi.Value = 0;
            can = 0;
            puan= 0;
            S1= 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

        }

        

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
             
            buyuksayi = Convert.ToUInt16(BuyukSayi.Value);

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
             can = buyuksayi - kucuksayi;


            if (can == 0 )
            {
                MessageBox.Show("İki sayı eşit olamaz!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Form_Update();
            }
            else if (can < 0 )
            {
                
                MessageBox.Show("Birinci(soldaki) sayı İkinci sayidan büyük olamaz!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form_Update();
            }
            else
            {
        
                Random rnd = new Random();
                S1 = rnd.Next(kucuksayi , buyuksayi);
        
                
                label4.Text = Convert.ToString("Kalan deneme hakkı = " + can);
                label1.Text = Convert.ToString(kucuksayi) + " İle " + Convert.ToString(buyuksayi) + " arasında rastgele bir sayı oluşturuldu." + S1;
            }
         
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {

           
            
                if (Convert.ToInt32(textBox1.Text) == S1 )
                {
                    label3.Text = "Tebrikler Doğru bildiniz!";
                    puan += 10;
                    label2.Text = Convert.ToString("puan = " + puan);
                    can = can - 1;
                    ResetForm();
                }
                else
                {
                    label3.Text = "Tekrar deneyiniz!";
                    puan -= 2;
                    label2.Text = Convert.ToString("puan = " + puan);
                    can = can - 1;
                }

                label4.Text = Convert.ToString("Kalan deneme hakkı = " + can);

            if (can == 0 || can < 0)
            {
                DialogResult result = MessageBox.Show("Kalan deneme hakkı bitti, oyunu sıfırlamak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    ResetForm();
                }
                else
                {
                    Form_Update();
                }

            }
            
        }

        private void ResetForm()
        {
            // Tüm kontrol değerlerini sıfırla veya varsayılan değerlerine geri dön.
            KucukSayi.Value = 0;
            BuyukSayi.Value = 0;
            S1 = 0;
            can = 0;
            // vb.

            // Yapılandırılan özel kodları burada da ekleyebilirsiniz.
        }

        private void Form_Update() 
        {
            KucukSayi.Value = 0;
            BuyukSayi.Value = 0;
            can = 0;
           
            S1 = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";


        }


    }
}
