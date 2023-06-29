using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi_kelime_bulmaca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int sorusayisi = 0; //soru sayısını belirlemek için global değişken oluşturuldu
        
        int sure = 20; //süre tanımlandı
        private void button6_Click(object sender, EventArgs e) //başla butonu
        {
            button6.Enabled = false; 
            button1.Enabled = true; //oyuna başlamadan önce pasif olan şıklar aktif edildi
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button8.Enabled = true; //çekilme butonu 5.sorudan sonra aktif olacak
            
           

            timer1.Start(); //1.sorudan itibaren 20 saniye süre başladı
            sure = 20;
            button6.Text = "DİĞER SORUYA GEÇ"; //başla butonunun ismi değiştirildi
            sorusayisi++; //soru sayısı arttı ki diğer soruya geçebilelim
            label17.Text = sorusayisi.ToString(); //güncel soru sayısı yazdırıldı
            
            
            if (sorusayisi == 1) //1.sorudaysak
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bilgisayarda yazı yazma programıdır?"; //1.soru yazdırıldı
                button1.Text = "Microsoft Excel"; //şıklar yazdırıldı
                button2.Text = "Microsoft PowerPoint";
                button3.Text = "Microsoft Word";
                button4.Text = "Microsoft Access";
                label29.Text = "Microsoft Word"; //oyunda görülmeyecek bir label'a doğru cevabı yazdırdık
                label18.Visible = true; //kazanç tablosunda sorunun değeri olan miktarı ok gösterecek
                label1.ForeColor = Color.Yellow; //kazanacağımız miktarın rengi değişecek
                button8.Visible = false; //çekilme butonu 5.sorudan sonra aktif olacak
                button9.Enabled = true; //yarı yarıya joker hakkı aktifleşti
                button10.Enabled = true; //seyirciye sor joker hakkı aktifleşti
                
                
            }
            if (sorusayisi == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi diğerlerinden düşük seviyeli bir programlama dilidir?";
                button1.Text = "Python";
                button2.Text = "Assembly";
                button3.Text = "Javascript";
                button4.Text = "Pascal";
                label29.Text = "Assembly";
                label18.Visible = false;
                label19.Visible = true;
                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                button8.Visible = false;
                button9.Enabled = true;
                button10.Enabled = true;
                

            }
            if (sorusayisi == 3)
            {
                richTextBox1.Text = "Bir problemin çözümüne yönelik sonlu sayıda işlemin ardı ardına tanımlanmasına verilen ad?";
                button1.Text = "Algoritma";
                button2.Text = "Program";
                button3.Text = "Kod";
                button4.Text = "Yazılım";
                label29.Text = "Algoritma";
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = true;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                button8.Visible = false;
                button9.Enabled = true;
                button10.Enabled = true;
                

            }
            if (sorusayisi == 4)
            {
                richTextBox1.Text = "Belli bir şart sağlandığı sürece veya belirli bir şart sağlanana kadar belirli işlemlerin defalarca yapılmasını sağlayan kod yapısı hangisidir?";
                button1.Text = "Koşul Yapısı";
                button2.Text = "Döngü Yapısı";
                button3.Text = "Sınıflar";
                button4.Text = "Şablonlar";
                label29.Text = "Döngü Yapısı";
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = true;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                button8.Visible = false;
                button9.Enabled = true;
                button10.Enabled = true;
                
            }
            if (sorusayisi == 5)
            {
                richTextBox1.Text = "Bilgisayarda çalışan programların ve üzerinde işlem yapılan verilerin bulunduğu geçici belleğe ne ad verilir?";
                button1.Text = "İşlemci";
                button2.Text = "Anakart";
                button3.Text = "Sabit Disk";
                button4.Text = "Ram";
                label29.Text = "Ram";
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = true;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Yellow;
                button8.Visible = false;
                button9.Enabled = true;
                button10.Enabled = true;
                
            }
            if (sorusayisi == 6)
            {
                richTextBox1.Text = "Sadece 0 ve 1'lerden oluşan komutlarla yazılan programlama diline ne ad verilir?";
                button1.Text = "Kaynak Kod";
                button2.Text = "Makine Dili";
                button3.Text = "Derleyici";
                button4.Text = "Pseudo Kod";
                label29.Text = "Makine Dili";
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = true;
                label6.ForeColor = Color.Yellow;
                button8.Visible = true; //çekilme butonu aktifleşti
                button9.Enabled = true;
                button10.Enabled = true;
                
            }
            if (sorusayisi == 7)
            {
                richTextBox1.Text = "Aşağıdaki değişken tanımlamalarından hangisi doğrudur?";
                button1.Text = "int 1sozlu";
                button2.Text = "string try";
                button3.Text = "int sinav notu";
                button4.Text = "string adi_soyadi";
                label29.Text = "string adi_soyadi";
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = true;
                button9.Enabled = true;
                button10.Enabled = true;
                label7.ForeColor = Color.Yellow;
                
            }
            if (sorusayisi == 8)
            {
                richTextBox1.Text = "Python programlama dilinde fonksiyon oluşturmak için kullanılan anahtar kelime hangisidir?";
                button1.Text = "elif";
                button2.Text = "while";
                button3.Text = "def";
                button4.Text = "class";
                label29.Text = "def";
                
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = true;
                label8.ForeColor = Color.Yellow;
                button9.Enabled = true;
                button10.Enabled = true;
                
            }
            if (sorusayisi == 9)
            {
                richTextBox1.Text = "C# programlama dilinde 'veya' sembolü hangisidir?";
                button1.Text = "||";
                button2.Text = "&&";
                button3.Text = "+";
                button4.Text = "%";
                label29.Text = "||";

                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = true;
                label9.ForeColor = Color.Yellow;
                button9.Enabled = true;
                button10.Enabled = true;
                
            }
            if (sorusayisi == 10)
            {
                richTextBox1.Text = "C tabanlı dillerde bir komutun bittiğini gösteren işaret hangisidir?";
                button1.Text = "İki Nokta (:)";
                button2.Text = "Nokta (.)";
                button3.Text = "Virgül (,)";
                button4.Text = "Noktalı Virgül (;)";
                label29.Text = "Noktalı Virgül (;)";

                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = true;
                button9.Enabled = true;
                button10.Enabled = true;
                label10.ForeColor = Color.Yellow;
                
            }


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black; //mouseumuzla şıkların üzerine geldiğimizde şıkların rengi siyah olacak
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseMove_1(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseMove_1(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //A şıkkı butonu (her şıkta bu mantık izlendi)
        {
            label28.Text = button1.Text; //butondaki yazıyı oyunda görünmeyecek bir label'a aktardık 
            button1.Enabled = false; //diğer şıklar pasif olacak çünkü soruya cevap vermiş olduk
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            timer1.Stop(); //soruya cevap verdiğimizde 20 saniye süremiz duracak
            if (sorusayisi == 10) //eğer son sorudaysak 
            {
                MessageBox.Show("Tebrikler. Bütün Soruları Doğru Cevapladınız. Kazancınız: 1.000.000 TL"); //oyun bitecek
                sorusayisi = 0; //soru sayısı sıfırlandı (tekrar oynamaya hazırız)
                button6.Text = "TEKRAR OYNA";
                button6.Enabled = true;
                label18.Visible = false; //kazanç tablosundaki oklar pasif
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque; //miktarlar önceki renginde
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;

            }
            else if (sorusayisi != 10 && label28.Text == label29.Text) //eğer 10.sorudan farklı bir sorudaysak ve cevabımız doğru ise
            {
                MessageBox.Show("Doğru Cevap. Diğer Soruya Geçiniz."); //bir sonraki soruya geçeceğiz
                button6.Enabled = true;
                

            }
            else
            {
                if (sorusayisi < 5) //eğer 5.soruya gelmemiş ve yanlış cevap vermiş isek 0 TL ile ayrılıyoruz. Çünkü barajı geçemedik
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 0 TL");
                }
                if (sorusayisi >= 5 && sorusayisi <= 10) //eğer barajı geçtikten sonra yanlış cevap verdiysek 25.000 TL alıyoruz.
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 25.000 TL");
                }
                
                button6.Enabled = true;
                button6.Text = "TEKRAR OYNA"; // oyun bittiğinde tekrar oyna butonuna tıklayarak oyuna baştan başlayabiliriz
                sorusayisi = 0;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
                button8.Visible = false;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label28.Text = button2.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            timer1.Stop();
            if (sorusayisi == 10)
            {
                MessageBox.Show("Tebrikler. Bütün Soruları Doğru Cevapladınız. Kazancınız: 1.000.000 TL");
                sorusayisi = 0;
                button6.Text = "TEKRAR OYNA";
                button6.Enabled = true;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;

            }
            else if (sorusayisi != 10 && label28.Text == label29.Text)
            {
                MessageBox.Show("Doğru Cevap. Diğer Soruya Geçiniz.");
                button6.Enabled = true;
                
            }
            else
            {
                if (sorusayisi < 5)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 0 TL");
                }
                if (sorusayisi >= 5 && sorusayisi <= 10)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 25.000 TL");
                }
                button6.Enabled = true;
                button6.Text = "TEKRAR OYNA";
                sorusayisi = 0;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
                button8.Visible = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label28.Text = button3.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            timer1.Stop();
            if (sorusayisi == 10)
            {
                MessageBox.Show("Tebrikler. Bütün Soruları Doğru Cevapladınız. Kazancınız: 1.000.000 TL");
                sorusayisi = 0;
                button6.Text = "TEKRAR OYNA";
                button6.Enabled = true;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
            }
            else if (sorusayisi != 10 && label28.Text == label29.Text)
            {
                MessageBox.Show("Doğru Cevap. Diğer Soruya Geçiniz.");
                button6.Enabled = true;
                
            }
            else
            {
                if (sorusayisi < 5)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 0 TL");
                }
                if (sorusayisi >= 5 && sorusayisi <= 10)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 25.000 TL");
                }
                button6.Enabled = true;
                button6.Text = "TEKRAR OYNA";
                sorusayisi = 0;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
                button8.Visible = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label28.Text = button4.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            timer1.Stop();
            if (sorusayisi == 10)
            {
                MessageBox.Show("Tebrikler. Bütün Soruları Doğru Cevapladınız. Kazancınız: 1.000.000 TL");
                sorusayisi = 0;
                button6.Text = "TEKRAR OYNA";
                button6.Enabled = true;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
            }
            else if (sorusayisi != 10 && label28.Text == label29.Text)
            {
                MessageBox.Show("Doğru Cevap. Diğer Soruya Geçiniz.");
                button6.Enabled = true;
                
            }
            else
            {
                if (sorusayisi < 5)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 0 TL");
                }
                if (sorusayisi >= 5 && sorusayisi <= 10)
                {
                    MessageBox.Show("Yanlış Cevap. Oyun Bitti. Kazancınız: 25.000 TL");
                }
                button6.Enabled = true;
                button6.Text = "TEKRAR OYNA";
                sorusayisi = 0;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
                button8.Visible = false;
            }
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            Form1 anasayfa = new Form1(); //anasayfaya dönme
            anasayfa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); //programdan çıkış
        }

        private void button8_Click(object sender, EventArgs e) //çekilme butonu
        {
            if (sorusayisi == 6) //yarışmacı 6.sorudan itibaren yani barajı geçtikten sonra çekilebilecek ve 25.000 lira almış olacak
            {
                MessageBox.Show("Yarışmadan Çekildiniz. Kazancınız: 25.000");
            }
            if (sorusayisi == 7)
            {
                MessageBox.Show("Yarışmadan Çekildiniz. Kazancınız: 100.000");
            }
            if (sorusayisi == 8)
            {
                MessageBox.Show("Yarışmadan Çekildiniz. Kazancınız: 250.000");
            }
            if (sorusayisi == 9)
            {
                MessageBox.Show("Yarışmadan Çekildiniz. Kazancınız: 500.000");
            }
            if (sorusayisi == 10)
            {
                MessageBox.Show("Yarışmadan Çekildiniz. Kazancınız: 750.000");
            }
            button6.Text = "TEKRAR OYNA";
            button6.Enabled = true;
            sorusayisi = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label27.Visible = false;
            label26.Visible = false;
            label25.Visible = false;
            label24.Visible = false;
            label23.Visible = false;
            label1.ForeColor = Color.Bisque;
            label2.ForeColor = Color.Bisque;
            label3.ForeColor = Color.Bisque;
            label4.ForeColor = Color.Bisque;
            label5.ForeColor = Color.Bisque;
            label6.ForeColor = Color.Bisque;
            label7.ForeColor = Color.Bisque;
            label8.ForeColor = Color.Bisque;
            label9.ForeColor = Color.Bisque;
            label10.ForeColor = Color.Bisque;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e) //yarı yarıya joker hakkı butonu
        {
            button9.Visible = false; //bu joker bir kere kullanılabilir, bu yüzden bir kere tıklandığında gizlenecek
            
            if (sorusayisi == 1)
            {
                button2.Enabled = false; //şıklardan ikisi pasifleşti
                button4.Enabled = false;
            }
            if (sorusayisi == 2)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            if (sorusayisi == 3)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (sorusayisi == 4)
            {
                button1.Enabled = false;
                button4.Enabled = false;
            }
            if (sorusayisi == 5)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (sorusayisi == 6)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            if (sorusayisi == 7)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (sorusayisi == 8)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            if (sorusayisi == 9)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (sorusayisi == 10)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label32.Text = sure.ToString();
            if (sure == 0) //eğer süre biterse
            {
                timer1.Stop();
                MessageBox.Show("Süre Bitti. Kazancınız: 0 TL"); //yarışma bitti
                label18.Visible = false; //kazanç tablosu eski başlangıçtaki haline döndü
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label1.ForeColor = Color.Bisque;
                label2.ForeColor = Color.Bisque;
                label3.ForeColor = Color.Bisque;
                label4.ForeColor = Color.Bisque;
                label5.ForeColor = Color.Bisque;
                label6.ForeColor = Color.Bisque;
                label7.ForeColor = Color.Bisque;
                label8.ForeColor = Color.Bisque;
                label9.ForeColor = Color.Bisque;
                label10.ForeColor = Color.Bisque;
                label32.Text = "20";
                button9.Enabled = false;
                button10.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Text = "TEKRAR OYNA"; 
                button6.Enabled = true;
                sorusayisi = 0; //tekrar oynamak için
            }
        }

        private void button10_Click(object sender, EventArgs e) //seyirciye sor joker hakkı butonu
        {
            button10.Visible = false; //bir kere tıklandığında gizlenecek
            if (sorusayisi == 1) //her soruda ayrı seyirci cevapları
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %5\nB şıkkı: %10\nC şıkkı: %70\nD şıkkı: %15");
            }
            if (sorusayisi == 2)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %5\nB şıkkı: %80\nC şıkkı: %3\nD şıkkı: %12");
            }
            if (sorusayisi == 3)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %85\nB şıkkı: %5\nC şıkkı: %7\nD şıkkı: %3");
            }
            if (sorusayisi == 4)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %5\nB şıkkı: %80\nC şıkkı: %3\nD şıkkı: %12");
            }
            if (sorusayisi == 5)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %5\nB şıkkı: %15\nC şıkkı: %3\nD şıkkı: %72");
            }
            if (sorusayisi == 6)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %5\nB şıkkı: %80\nC şıkkı: %3\nD şıkkı: %12");
            }
            if (sorusayisi == 7)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %10\nB şıkkı: %5\nC şıkkı: %20\nD şıkkı: %65");
            }
            if (sorusayisi == 8)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %4\nB şıkkı: %5\nC şıkkı: %83\nD şıkkı: %8");
            }
            if (sorusayisi == 9)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %75\nB şıkkı: %5\nC şıkkı: %10\nD şıkkı: %10");
            }
            if (sorusayisi == 10)
            {
                MessageBox.Show("Seyircilerin Cevapları:\nA şıkkı: %4\nB şıkkı: %11\nC şıkkı: %5\nD şıkkı: %80");
            }
        }
    }
}
