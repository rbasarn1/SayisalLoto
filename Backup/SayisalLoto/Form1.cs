using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] lotosayi = new int[6];
        int[] benimLoto = new int[6];

        int bilen2 = 0;
        int bilen3 = 0;
        int bilen4 = 0;
        int bilen5 = 0;
        int bilen6 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lotoCek();
        }

        void lotoCek() //Sayısal Lotodan çıkan sayılar.
        {
            int i = 0;
            while (i < 6)
            {
            uret:
                int sayi = rnd.Next(1, 50);
                if (lotosayi.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    lotosayi[i] = sayi;
                    i++;
                }
            }
            lotoYaz();
        }

        void lotoYaz()
        { //lotoyu textboxlara yazdırır.
            Array.Sort(lotosayi);

            loto1.Text = lotosayi[0].ToString();
            loto2.Text = lotosayi[1].ToString();
            loto3.Text = lotosayi[2].ToString();
            loto4.Text = lotosayi[3].ToString();
            loto5.Text = lotosayi[4].ToString();
            loto6.Text = lotosayi[5].ToString();
        }

        void lotokur() //kendi lotomuzu oluşturuyoruz.
        {
            int i = 0;
            while (i < 6)
            {
            uret:
                int sayi = rnd.Next(1, 50);
                if (benimLoto.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    benimLoto[i] = sayi;
                    i++;
                }
            }
            mylotoyaz();
        }

        void mylotoyaz()
        { //kendi lotomuzu yazdırır listboxa.
            Array.Sort(benimLoto);
            string loto;
            loto = benimLoto[0] + "-" + benimLoto[1] + "-" + benimLoto[2] + "-" + benimLoto[3] + "-" + benimLoto[4] + "-" + benimLoto[5];
            list_lotolar.Items.Add(loto);

            list_myLoto1.Items.Add(benimLoto[0].ToString());
            list_myLoto2.Items.Add(benimLoto[1].ToString());
            list_myLoto3.Items.Add(benimLoto[2].ToString());
            list_myLoto4.Items.Add(benimLoto[3].ToString());
            list_myLoto5.Items.Add(benimLoto[4].ToString());
            list_myLoto6.Items.Add(benimLoto[5].ToString());
        }

        private void txt_oynanacakLotoSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece sayı girmemizi sağlıyor.
        }

        private void btn_lotoOyna_Click(object sender, EventArgs e)
        {

            if (loto1.Text == "")
            {
                lotoCek();
            }

            int lotoSayisi = 0;
            if (txt_oynanacakLotoSayisi.Text == "")
            {
                MessageBox.Show("Oynanacak loto sayısını giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                lotoSayisi = int.Parse(txt_oynanacakLotoSayisi.Text);
            }

            for (int i = 0; i < lotoSayisi; i++)
            {
                lotokur();
            }
        }

        void bilenHesaplama()
        {
            int bildigim = 0;
            int l1, l2, l3, l4, l5, l6;
            

            for (int i = 0; i < list_myLoto1.Items.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    l1 = int.Parse(list_myLoto1.Items[i].ToString());
                    l2 = int.Parse(list_myLoto2.Items[i].ToString());
                    l3 = int.Parse(list_myLoto3.Items[i].ToString());
                    l4 = int.Parse(list_myLoto4.Items[i].ToString());
                    l5 = int.Parse(list_myLoto5.Items[i].ToString());
                    l6 = int.Parse(list_myLoto6.Items[i].ToString());

                    if (l1 == lotosayi[j])
                    {
                        bildigim++;
                    }
                    if (l2 == lotosayi[j])
                    {
                        bildigim++;
                    }
                    if (l3 == lotosayi[j])
                    {
                        bildigim++;
                    }
                    if (l4 == lotosayi[j])
                    {
                        bildigim++;
                    }
                    if (l5 == lotosayi[j])
                    {
                        bildigim++;
                    }
                    if (l6 == lotosayi[j])
                    {
                        bildigim++;
                    }
                }
                if (bildigim == 2)
                {
                    bilen2++;
                }
                else if (bildigim == 3)
                {
                    bilen3++;
                }
                else if (bildigim == 4)
                {
                    bilen4++;
                }
                else if (bildigim == 5)
                {
                    bilen5++;
                }
                else if (bildigim == 6)
                {
                    bilen6++;
                }
                bilenYazdir();
                bildigim = 0;
            }

            
            
        }

        void bilenYazdir() {
            lbl_2bilen.Text = "2 Bilen Sayısı = " + bilen2.ToString();
            lbl_3bilen.Text = "3 Bilen Sayısı = "+bilen3.ToString();
            lbl_4bilen.Text = "4 Bilen Sayısı = " + bilen4.ToString();
            lbl_5bilen.Text = "5 Bilen Sayısı = " + bilen5.ToString();
            lbl_6bilen.Text = "6 Bilen Sayısı = " + bilen6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bilenHesaplama();
        }

    }
}
