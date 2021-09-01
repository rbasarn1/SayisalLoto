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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int kackisi; // kaç kişi oynadı
        public int bildigim; //kaç bildiğimi tutar
        Random rnd = new Random(); // random sınıfı oluşturuldu
        int[] lotosayi = new int[6];    // çekilen altili lotoya gelen sayılar burada tutuluyor
        int[] benimLoto = new int[6];   // kullanıcının oluşturduğu 6'lı burada tutuluyor

        ArrayList bilen2Index = new ArrayList(); //2bilen sayıları arraylistte tutuyorum
        ArrayList bilen3Index = new ArrayList();
        ArrayList bilen4Index = new ArrayList();
        ArrayList bilen5Index = new ArrayList();
        ArrayList bilen6Index = new ArrayList();

        string loto; //listbox yazdırabilmek için dönüştürüyorum

        int bilenIndex;//bilen sayının listboxtaki indexini tutuyorum

        int bilen2 = 0;//2 bilen sayısı
        int bilen3 = 0;// 3 bilen sayısı
        int bilen4 = 0;// 4 bilen sayısı
        int bilen5 = 0;// 5 bilen sayısı
        int bilen6 = 0;// 6 bilen sayısı

        bool gelismis = false; //sonuçlar form2 de gösterilsin mi?

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_lotoCek_Click(object sender, EventArgs e)
        {
            try
            {
                altiliCek(); // loto çek komutunu/metodunu çalıştırır
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak
            }
        }//loto çeker

        void altiliCek() //Sayısal Lotodan çıkan sayılar.
        {
            try
            {
                int i = 0; // kendi el sayacımı oluşturdum
                while (i < 6) // döngüye aldım
                {
                uret: // eğer loto daki sayılar gelirse yeni sayı çekmek için checkpoint oluşturdum
                    int sayi = rnd.Next(1, 50);// sayi değişkenine rastgele sayılar çekiyorum
                    if (lotosayi.Contains(sayi))//çıkan 6'lı da aynı sayı gelip gelmediğini kontrol ediyorum
                    {
                        goto uret;// aynı sayı geldiyse uret checkpointine gidiyorum
                    }
                    else
                    {
                        lotosayi[i] = sayi; // gelen rastgele sayıyı lotosayi dizininin[i] elemanına atıyorum.
                        i++;// el sayacımı burada arttırıyorum.
                    }
                }
                altiliYaz(); //çekilen altili lotoyu yaz metodunu çağırıyorum
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak

            }

        }

        void altiliYaz() // çekilen 6'lıyı textboxlara yazdırır.
        { //lotoyu textboxlara yazdırır.
            try
            {
                Array.Sort(lotosayi);

                loto1.Text = lotosayi[0].ToString(); //gelen sayıları yazdırıyorum
                loto2.Text = lotosayi[1].ToString();
                loto3.Text = lotosayi[2].ToString();
                loto4.Text = lotosayi[3].ToString();
                loto5.Text = lotosayi[4].ToString();
                loto6.Text = lotosayi[5].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak

            }

        }

        void myLoto() //kendi lotomuzu oluşturuyoruz.
        {
            try
            {
                int i = 0; // kendi sayacımızı oluşturduk
                while (i < 6) // sayaç şartını girdik
                {
                uret://geri dönmek için checkpoint oluşturduk
                    int sayi = rnd.Next(1, 50); //1-50 arası sayı çekiyorum
                    if (benimLoto.Contains(sayi))//kendi 6'lımızda bu sayı daha önce geldi mi onu kontrol ediyoruz
                    {
                        goto uret;// eğer çekilen sayı bizim 6'lı da bulunuyorsa uret kısmına geri döner
                    }
                    else
                    {
                        benimLoto[i] = sayi; // eğer çekilen sayı bizim 6'lı da bulunmuyorsa, ekler
                        i++; // sayacı arttırır bir sonraki sayıyı çeker
                    }
                }
                mylotoyaz();//mylotoyaz metodunu çağırır
                bilenHesaplama();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak

            }

        }

        void mylotoyaz()//kendi lotomuz
        { //kendi lotomuzu yazdırır listboxa.
            try
            {
                Array.Sort(benimLoto); //lotomuzu düşükten yükseğe sıralar

                loto = benimLoto[0] + "-" + benimLoto[1] + "-" + benimLoto[2] + "-" + benimLoto[3] + "-" + benimLoto[4] + "-" + benimLoto[5];
                //lotoya gelen sayıları yazıyorum.
                list_lotolar.Items.Add(loto); // listboxa da ekliyorum
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak
            }

        }

        private void txt_oynanacakLotoSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece sayı girmemizi sağlıyor.
            // sadece sayı girişini aktif ediyorum
        }//only number


        private void btn_lotoOyna_Click(object sender, EventArgs e) //kendimize loto oynar
        {
            DialogResult result = MessageBox.Show("Sonuçları daha detaylı bir şekilde görmek istermisiniz? \n\nİşlem süresi uzayabilir.", "Sayısal Loto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //gelişmiş pencerede sonuçları görmek istermsiin diye soruyorum
            if (result == DialogResult.Yes) // evet ise
            {
                gelismis = true;
                btn_gelismisSonuc.Enabled = true;
            }
            else // hayır ise
            {
                gelismis = false;
                btn_gelismisSonuc.Enabled = false;
            }
            try
            {
                if (loto6.Text == "") //eğer daha önce 6'lı çekilmemiş ise otomatik olarak çekiyor.
                {
                    altiliCek();//lotocek metodunu calıştırır
                }

                if (txt_oynanacakLotoSayisi.Text == "")//kaç tane oynanacağı girildi mi?
                {
                    MessageBox.Show("Oynanacak loto sayısını giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    //girilmediyse hata ver
                }
                else
                {
                    kackisi = int.Parse(txt_oynanacakLotoSayisi.Text);
                }

                for (int i = 0; i < kackisi; i++) //oynanacak loto sayısı kadar 
                {
                    myLoto(); // 6'lı oynar
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak
            }
        }

        void bilenHesaplama()
        {
            try
            {
                int l1, l2, l3, l4, l5, l6; //loto1,loto2... değişkenler oluşturdum.
                Array.Sort(benimLoto);

                for (int j = 0; j < 6; j++)
                //lotodaki 6 sayıyı da kontrol edecek. 1 sayıyı 6 kere kontrol ediyor
                {
                    l1 = benimLoto[0];
                    //l1 değişkenine bizim lotomuzun ilk rakamını alır
                    //(örneğin bu kodda yukarıdaki bizimlotomuzun[i] sinin 1. rakamını alıyor)
                    // örnek burada 7. Loto'nun ilk rakamını alır. Aşağıdakilerde aynı
                    l2 = benimLoto[1];
                    l3 = benimLoto[2];
                    l4 = benimLoto[3];
                    l5 = benimLoto[4];
                    l6 = benimLoto[5];

                    if (l1 == lotosayi[j])//eğer l1 eşitse 6'lının j elemanına
                    {
                        bildigim++;//bildigim degişkenine 1 ekle! aşağıdakilerde aynı
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
                    if (j == 5)
                    {
                        bilenYazdir();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse mesaj box açılacak
            }
        }

        void bilenYazdir()
        {
            try
            {
                sonuclar sonuclar = new sonuclar(); //sonuclar adlı forma erişiyorum
                bilenIndex = int.MaxValue;
                if (bildigim == 2) // eğer bildiğim eşitse 2 ye bilen2 yi arttırır. (2 bilen sayısı)
                {
                    bilen2++;//bilen2 arttırır.
                    bilenIndex = list_lotolar.Items.Count - 1; //2 bildiyse listboxın son elemanının indexini alıyor.
                    if (bilenIndex != int.MaxValue) //eğer bilenindex eşit değilse int alabileceği en yüksek değere
                    {
                        bilen2Index.Add(bilenIndex);//bilen2index adlı arrayliste ekliyor
                    }
                    if (gelismis) //gelismis aktif ise
                    {
                        sonuclar.bilen2.Add(loto);//sonuclar formundaki bilen2 adlı arrayliste bilen lotoyu ekliyor
                    }
                }
                else if (bildigim == 3)// eğer 3 bildiyse bilen3 arttırır.
                {
                    bilen3++;//bilen3 arttırır. aşağıdakilerde aynı
                    bilenIndex = list_lotolar.Items.Count - 1;
                    if (bilenIndex != int.MaxValue)
                    {
                        bilen3Index.Add(bilenIndex);
                    }
                    if (gelismis) //gelismis aktif ise
                    {
                        sonuclar.bilen3.Add(loto);//sonuclar formundaki bilen2 adlı arrayliste bilen lotoyu ekliyor
                    }
                }
                else if (bildigim == 4)
                {
                    bilen4++;
                    bilenIndex = list_lotolar.Items.Count - 1;
                    if (bilenIndex != int.MaxValue)
                    {
                        bilen4Index.Add(bilenIndex);
                    }
                    if (gelismis) //gelismis aktif ise
                    {
                        sonuclar.bilen4.Add(loto);//sonuclar formundaki bilen2 adlı arrayliste bilen lotoyu ekliyor
                    }
                }
                else if (bildigim == 5)
                {
                    bilen5++;
                    bilenIndex = list_lotolar.Items.Count - 1;
                    if (bilenIndex != int.MaxValue)
                    {
                        bilen5Index.Add(bilenIndex);
                    }
                    if (gelismis) //gelismis aktif ise
                    {
                        sonuclar.bilen5.Add(loto);//sonuclar formundaki bilen2 adlı arrayliste bilen lotoyu ekliyor
                    }
                }
                else if (bildigim == 6)
                {
                    bilen6++;
                    bilenIndex = list_lotolar.Items.Count - 1;

                    if (bilenIndex != int.MaxValue)
                    {
                        bilen6Index.Add(bilenIndex);
                    }
                    if (gelismis) //gelismis aktif ise
                    {
                        sonuclar.bilen6.Add(loto);//sonuclar formundaki bilen2 adlı arrayliste bilen lotoyu ekliyor
                    }
                }


                bilenIndex = int.MaxValue; //her ihtimale karşı değeri maksimuma çekiyor

                lbl_2bilen.Text = "2 Bilen Sayısı = " + bilen2.ToString(); //2 bilen sayısını yazdırır
                lbl_3bilen.Text = "3 Bilen Sayısı = " + bilen3.ToString();
                lbl_4bilen.Text = "4 Bilen Sayısı = " + bilen4.ToString();
                lbl_5bilen.Text = "5 Bilen Sayısı = " + bilen5.ToString();
                lbl_6bilen.Text = "6 Bilen Sayısı = " + bilen6.ToString();
                bildigim = 0; // yeni lotoyu kontrol etmek üzere bildigimi 0lar
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }//bilenleri yazdırır

        private void list_lotolar_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;

                for (int i = 0; i < bilen2Index.Count; i++) //bilen2 arraylistinin içindeki elemanları tek tek sayar
                {
                    int index = int.Parse(bilen2Index[i].ToString()); //int indexe çevirir
                    if (e.Index == index) //eğer listboxun indexi ile bizim oluşturduğumuz index eşit ise (örnek : listbox da 10 öge var, benim indexim 3, listboxda index nosu 3 varsa aşağıdakileri uygula
                    {
                        myBrush = Brushes.NavajoWhite;//o ögenin rengini istediğim renge çevir
                    }
                }
                for (int i = 0; i < bilen3Index.Count; i++)
                {
                    int index = int.Parse(bilen3Index[i].ToString());
                    if (e.Index == index)
                    {
                        myBrush = Brushes.Yellow;
                    }
                }
                for (int i = 0; i < bilen4Index.Count; i++)
                {
                    int index = int.Parse(bilen4Index[i].ToString());
                    if (e.Index == index)
                    {
                        myBrush = Brushes.Orange;
                    }
                }
                for (int i = 0; i < bilen5Index.Count; i++)
                {
                    int index = int.Parse(bilen5Index[i].ToString());
                    if (e.Index == index)
                    {
                        myBrush = Brushes.Red;
                    }
                }
                for (int i = 0; i < bilen6Index.Count; i++)
                {
                    int index = int.Parse(bilen6Index[i].ToString());
                    if (e.Index == index)
                    {
                        myBrush = Brushes.Maroon;
                    }
                }
                e.Graphics.DrawString(list_lotolar.Items[e.Index].ToString(),
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault); //her bir öge(item) için ayarlar. (font stil = default, çizim şekli = myBrush, yazı biçimi = form yazı stili)
                e.DrawFocusRectangle(); // eğer seçili öğe varsa dikdörtgen çiz
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse bu mesajbox çalışacak
            }

        }

        private void txt_oynanacakLotoSayisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_oynanacakLotoSayisi.Text == "0") //text eşitse 0'a
                {
                    txt_oynanacakLotoSayisi.Clear();//texti temizle
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }//textboxa tıklandıysa

        private void txt_oynanacakLotoSayisi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_oynanacakLotoSayisi.Text == "")//eğer text içi boşsa
                {
                    kackisi = 0; //kaç kişi 0 demektir
                }
                else//değilse
                {
                    kackisi = int.Parse(txt_oynanacakLotoSayisi.Text);//textin içerisinde hangi sayı yazılıysa direk kackisiye ata
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }//text değişirse

        private void btn_Add1k_Click(object sender, EventArgs e)
        {
            try
            {
                kackisi += 1000; //1k = 1000 //oynayankişiye 1000ekler
                txt_oynanacakLotoSayisi.Text = kackisi.ToString();//textde yazdırır
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }//loto oynayan kişi ekler

        private void btn_Add10k_Click(object sender, EventArgs e)
        {
            try
            {

                kackisi += 10000;//10k = 10000 //oynayankişiye 10000ekler
                txt_oynanacakLotoSayisi.Text = kackisi.ToString();//textde yazdırır
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse bu mesajbox çalışacak
            }
        }//loto oynayan kişi ekler

        private void btn_Add100k_Click(object sender, EventArgs e)
        {
            try
            {
                kackisi += 100000;
                txt_oynanacakLotoSayisi.Text = kackisi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse bu mesajbox çalışacak
            }

        }

        private void btn_Add1m_Click(object sender, EventArgs e)
        {
            try
            {
                kackisi += 1000000; //yukardakilerle aynı 1m = 1.000.000
                txt_oynanacakLotoSayisi.Text = kackisi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse bu mesajbox çalışacak
            }

        }

        private void btn_Sifirla_Click(object sender, EventArgs e) //form başladığındaki hale getirir (herşeyi 0 yapar veya sıfırlar)
        {
            try
            {
                bilen2 = 0; //2bilenleri 0 ladım
                bilen3 = 0;
                bilen4 = 0;
                bilen5 = 0;
                bilen6 = 0;

                list_lotolar.Items.Clear();
                txt_oynanacakLotoSayisi.Text = "0"; //oynayan kişileri sildikten sonra oynayan kişi sayısını da boş yapıyorum
                kackisi = 0;
                loto1.Text = "";//lotonun textini boş yapıyorum
                loto2.Text = "";
                loto3.Text = "";
                loto4.Text = "";
                loto5.Text = "";
                loto6.Text = "";

                lbl_2bilen.Text = "2 Bilen Sayısı = " + bilen2.ToString(); //2 bilenleri 0 ladıktan sonra tekrar yazdırıyorum
                lbl_3bilen.Text = "3 Bilen Sayısı = " + bilen3.ToString();
                lbl_4bilen.Text = "4 Bilen Sayısı = " + bilen4.ToString();
                lbl_5bilen.Text = "5 Bilen Sayısı = " + bilen5.ToString();
                lbl_6bilen.Text = "6 Bilen Sayısı = " + bilen6.ToString();

                sonuclar sonuclar = new sonuclar();//sonuclar formuna eriştim.
                sonuclar.bilen2.Clear(); //sonuclar formundaki bilen2 arraylistini temizledim
                sonuclar.bilen3.Clear();
                sonuclar.bilen4.Clear();
                sonuclar.bilen5.Clear();
                sonuclar.bilen6.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);//hata verirse bu mesajbox çalışacak
            }

        }

        public static int formAcik = 0; //formacik olup olmadığını sorgulamak için oluşturdum

        private void btn_gelismisSonuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (formAcik == 0)
                {
                    sonuclar sonuclar = new sonuclar();//sonuclar formuna eriştim.
                    sonuclar.Show();//sonuclar formunu gösterdim
                    formAcik = 1; // form acik 1 yapıyor
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem yapılırken bir sorun oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); //hata verirse bu mesajbox çalışacak
            }

        }
    }
}
