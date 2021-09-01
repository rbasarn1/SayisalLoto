using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SayisalLoto
{
    public partial class sonuclar : Form
    {
        public sonuclar()
        {
            InitializeComponent();
        }

        public static ArrayList bilen2 = new ArrayList(); //2 bilen lotoları bu arraylistte tutuyorum 1-12-24-33-44-46 gibi gibi
        public static ArrayList bilen3 = new ArrayList();//3 bilenlerde aynı şekilde
        public static ArrayList bilen4 = new ArrayList();
        public static ArrayList bilen5 = new ArrayList();
        public static ArrayList bilen6 = new ArrayList();

        private void sonuclar_Shown(object sender, EventArgs e)
        {

            list_2bilen.Items.Clear();//listbox temizliyor
            list_3bilen.Items.Clear();
            list_4bilen.Items.Clear();
            list_5bilen.Items.Clear();
            list_6bilen.Items.Clear();

            for (int i = 0; i < bilen2.Count; i++) //bilen2 kadar, listboxa 2 bilen lotoları ekliyor
            {
                list_2bilen.Items.Add(bilen2[i]);
            }
             
            for (int i = 0; i < bilen3.Count; i++)//3 bilen kadar, 3 bilen lotoları ekliyor
            {
                list_3bilen.Items.Add(bilen3[i]);
            }

            for (int i = 0; i < bilen4.Count; i++)
            {
                list_4bilen.Items.Add(bilen4[i]);
            }

            for (int i = 0; i < bilen5.Count; i++)
            {
                list_5bilen.Items.Add(bilen5[i]);
            }

            for (int i = 0; i < bilen6.Count; i++)
            {
                list_6bilen.Items.Add(bilen6[i]);
            }

            lbl_2bilen.Text = "2 Bilen Sayısı = " + bilen2.Count; //bilen2 arraylistinde kaç tane loto bulunuyorsa onu yazdırıyor (2 bilen sayısı = arraylist sayısı)
            lbl_3bilen.Text = "3 Bilen Sayısı = " + bilen3.Count;
            lbl_4bilen.Text = "4 Bilen Sayısı = " + bilen4.Count;
            lbl_5bilen.Text = "5 Bilen Sayısı = " + bilen5.Count;
            lbl_6bilen.Text = "6 Bilen Sayısı = " + bilen6.Count;
        }

        private void sonuclar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.formAcik = 0; //form kapanırken, form1deki açık kapalı kontrol etmek için yazdığım formacik komutunu 0 yani basitçe false yapıyor.
        }
    }
}
