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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int sorusayisi = 0; //hangi soruda olduğumuzu belirleyecek global değişken tanımlandı
        private void button21_Click(object sender, EventArgs e)
        {
            button1.Enabled = true; //oyun başlamadan önce enabled=false olan butonları başla butonuna tıklandığında tıklanmaları sağlandı
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true; //kontrol butonu aktifleşti
            button16.Enabled = true; //harf sil butonu aktifleşti
            button17.Enabled = true; //ipucu butonu aktifleşti
            button21.Enabled = false; //sorudayken bu buton pasif halde olacak. Soru cevaplandığında aktifleşecek
            button21.Text = "DİĞER SORUYA GEÇ"; //başla butonunun ismi değiştirildi
            sorusayisi++; //soru sayısını arttırıyoruz ki diğer soruya geçebilelim
            label2.Text = sorusayisi.ToString(); //güncel soru sayısı yazdırıldı
            label4.Text = ipucu.ToString(); //güncel ipucu sayısı yazdırıldı
            if (sorusayisi == 1) //eğer 1.sorudaysak
            {
                richTextBox1.Text = "Eşitliğin sağındaki ifadenin soldaki değişkene aktarılma işlemi."; //ilk soru yazdırıldı
                
                button1.Text = "S"; //butona harfler yazdırıldı
                button2.Text = "D"; //bu butonlara tıklandığında butondaki harfler textboxlara yazdırılacak
                button3.Text = "A";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "R";
                button7.Text = "Y";
                button8.Text = "U";
                button9.Text = "M";
                button10.Text = "O";
                button11.Text = "G";
                button12.Text = "A";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 2) //eğer 2.sorudaysak
            {
                richTextBox1.Text = "Her algoritma köşeleri yuvarlatılmış bir dikdörtgen içine alınan ... komutu ile başlar."; //2.soru yazdırıldı
                
                button1.Text = "D"; //butona harfler yazdırıldı
                button2.Text = "Ş";
                button3.Text = "P";
                button4.Text = "E";
                button5.Text = "L";
                button6.Text = "R";
                button7.Text = "Y";
                button8.Text = "A";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "L";
                button12.Text = "B";
                button13.Text = "E";
                button14.Text = "A";
                
            }
            if (sorusayisi == 3)//3.sorudaysak
            {
                richTextBox1.Text = "Bir değişkenin 1 veya 0, true veya false olarak saklanmasını sağlayan veri tipi.";//3.soru yazdırıldı
                textBox5.Visible = false; //sorunun cevabı 4 harfli olduğu için 5.textbox gizlendi
                button1.Text = "N";//butona harfler yazdırıldı
                button2.Text = "O";
                button3.Text = "P";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "B";
                button7.Text = "Y";
                button8.Text = "U";
                button9.Text = "L";
                button10.Text = "O";
                button11.Text = "G";
                button12.Text = "M";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 4) //4.sorudaysak
            {
                richTextBox1.Text = "Ölçüm, sayım, deney, gözlem ya da araştırma yolu ile elde edilen, belirli bir nesne, birey ya da olguya ilişkin bir soyutlamadır.";//4.soru yazdırıldı
                textBox5.Visible = false;//sorunun cevabı 4 harfli olduğu için 5.textbox gizlendi

                button1.Text = "S";//butona harfler yazdırıldı
                button2.Text = "E";
                button3.Text = "P";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "İ";
                button7.Text = "Y";
                button8.Text = "U";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "V";
                button12.Text = "M";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 5)
            {
                richTextBox1.Text = "Veri yapılarından biridir.";
                textBox5.Visible = false;
                
                button1.Text = "Ç";
                button2.Text = "D";
                button3.Text = "P";
                button4.Text = "A";
                button5.Text = "P";
                button6.Text = "R";
                button7.Text = "Y";
                button8.Text = "U";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "Ğ";
                button12.Text = "M";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 6)
            {
                richTextBox1.Text = "Eleman ekleme çıkarmaların en üstten yapıldığı soyut veri tipidir.";
                textBox5.Visible = true;//bu ve bundan sonraki sorular 5 harfli olduğu için 5.textbox görünür yapıldı
                button1.Text = "N";
                button2.Text = "Y";
                button3.Text = "P";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "R";
                button7.Text = "I";
                button8.Text = "U";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "Ğ";
                button12.Text = "I";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 7)
            {
                richTextBox1.Text = "Nesne tabanlı programlamada kullanılan, değişkenleri ve methodları bir arada saklayan sistemdir.";
                textBox5.Visible = true;
                button1.Text = "S";
                button2.Text = "D";
                button3.Text = "P";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "F";
                button7.Text = "Y";
                button8.Text = "I";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "G";
                button12.Text = "M";
                button13.Text = "N";
                button14.Text = "I";
               
            }
            if (sorusayisi == 8)
            {
                richTextBox1.Text = "Koşul döngüsünün anahtar kelimesidir.";
                textBox5.Visible = true;
                button1.Text = "E";
                button2.Text = "D";
                button3.Text = "P";
                button4.Text = "L";
                button5.Text = "P";
                button6.Text = "H";
                button7.Text = "Y";
                button8.Text = "S";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "G";
                button12.Text = "W";
                button13.Text = "A";
                button14.Text = "I";
                
            }
            if (sorusayisi == 9)
            {
                richTextBox1.Text = "Bir işlemin kaç defa yapıldığını sayan değişken.";
                textBox5.Visible = true;
                button1.Text = "S";
                button2.Text = "D";
                button3.Text = "P";
                button4.Text = "T";
                button5.Text = "A";
                button6.Text = "N";
                button7.Text = "Y";
                button8.Text = "U";
                button9.Text = "İ";
                button10.Text = "Ç";
                button11.Text = "G";
                button12.Text = "K";
                button13.Text = "A";
                button14.Text = "R";
                
            }
            if (sorusayisi == 10)
            {
                richTextBox1.Text = "Belli bir işi yapmaya yarayan, hazır veya kullanıcı tarafından oluşturulan kodlara denir.";
                textBox5.Visible = true;

                button1.Text = "N";
                button2.Text = "D";
                button3.Text = "E";
                button4.Text = "T";
                button5.Text = "P";
                button6.Text = "K";
                button7.Text = "Y";
                button8.Text = "T";
                button9.Text = "H";
                button10.Text = "O";
                button11.Text = "G";
                button12.Text = "M";
                button13.Text = "A";
                button14.Text = "Ğ";
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = ""; //form yüklendiğinde textboxlar boş olacak
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();//anasayfaya dönüş işlemi
            anasayfa.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();//çıkış işlemi
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1) //üzerinde harflerin yazdığı butonlar soru sayısına göre değişiklik gösterecek. button1'den button14'e kadar hepsi aynı şekilde oluşturuldu
            {
                if (textBox1.Text == "") //eğer 1.textbox boş ise tıklanılan butondaki harf 1.textboxa yazdırılacak
                {
                    textBox1.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text == "") //eğer txt1 dolu ve txt2 boş ise txt2'ye yazdır
                {
                    textBox2.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "") //eğer txt1 ve txt2 dolu ise txt3'e yazdır
                {
                    textBox3.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "") //eğer txt1, txt2 ve txt3 dolu ise txt4'e yazdır
                {
                    textBox4.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "") //eğer txt1, txt2, txt3 ve txt4 dolu ise txt5'e yazdır
                {
                    textBox5.Text = "S";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "N";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "S";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ç";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "N";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "S";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "E";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "S";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "N";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ş";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ş";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ş";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ş";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ş";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "E";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "D";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "D";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "E";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "E";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "L";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "L";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "P";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "P";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "B";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "İ";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "F";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "F";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "F";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "F";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "F";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "N";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "K";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "I";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Y";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Y";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "I";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "S";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "S";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "U";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "U";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "T";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "T";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "L";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "İ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "İ";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "H";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "H";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ç";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ç";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "O";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "O";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "L";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "L";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "V";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "V";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "V";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "V";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "V";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ğ";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ğ";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "G";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "G";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "B";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "B";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "I";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "W";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "W";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "W";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "W";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "W";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "K";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "K";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "M";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "M";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "E";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "E";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "N";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "N";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }

            }
            else if (sorusayisi == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "A";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "A";
                }
            }
            else if (sorusayisi == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 6)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 7)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "I";
                }
            }
            else if (sorusayisi == 8)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "I";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "I";
                }
            }
            else if (sorusayisi == 9)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "R";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "R";
                }
            }
            else if (sorusayisi == 10)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text == "")
                {
                    textBox2.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                {
                    textBox3.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
                {
                    textBox4.Text = "Ğ";
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text == "")
                {
                    textBox5.Text = "Ğ";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e) //kontrol butonu, textboxlar dolduğunda cevabımızın doğru olup olmadığını öğreneceğiz (1.sorudan 10.soruya kadar aynı şekilde)
        {
            if (sorusayisi == 1) //ilk soruda
            {
                if (textBox1.Text == "A" && textBox2.Text == "T" && textBox3.Text == "A" && textBox4.Text == "M" && textBox5.Text == "A") //textboxlardaki harfler cevabı oluşturuyorsa
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz."); //cevabımız doğru
                    button1.Enabled = false; //diğer soruya geçene kadar butonlar pasif olacak
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = ""; //sorunun cevabını doğru verirsek textboxlar boşaltılacak
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış"); //değilse cevabımız yanlış
                }
            }
            if (sorusayisi == 2)
            {
                if (textBox1.Text == "B" && textBox2.Text == "A" && textBox3.Text == "Ş" && textBox4.Text == "L" && textBox5.Text == "A")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 3)
            {
                if (textBox1.Text == "B" && textBox2.Text == "O" && textBox3.Text == "O" && textBox4.Text == "L")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 4)
            {
                if (textBox1.Text == "V" && textBox2.Text == "E" && textBox3.Text == "R" && textBox4.Text == "İ")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 5)
            {
                if (textBox1.Text == "A" && textBox2.Text == "Ğ" && textBox3.Text == "A" && textBox4.Text == "Ç")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 6)
            {
                if (textBox1.Text == "Y" && textBox2.Text == "I" && textBox3.Text == "Ğ" && textBox4.Text == "I" && textBox5.Text == "N")
                {

                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 7)
            {
                if (textBox1.Text == "S" && textBox2.Text == "I" && textBox3.Text == "N" && textBox4.Text == "I" && textBox5.Text == "F")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 8)
            {
                if (textBox1.Text == "W" && textBox2.Text == "H" && textBox3.Text == "I" && textBox4.Text == "L" && textBox5.Text == "E")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 9)
            {
                if (textBox1.Text == "S" && textBox2.Text == "A" && textBox3.Text == "Y" && textBox4.Text == "A" && textBox5.Text == "Ç")
                {
                    MessageBox.Show("Tebrikler. Cevap Doğru. Diğer Soruya Geçiniz.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
            if (sorusayisi == 10)//son soru
            {
                if (textBox1.Text == "M" && textBox2.Text == "E" && textBox3.Text == "T" && textBox4.Text == "O" && textBox5.Text == "T")
                {
                    MessageBox.Show("Tebrikler. Oyun Bitti.");
                    richTextBox1.Text = ""; //oyun bitince richtextbox boşaltılacak
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button21.Enabled = true;
                    button21.Text = "YENİDEN BAŞLAT"; //başla butonunun ismi değiştirildi
                    ipucu = 3; //ipucu sayısı tekrar 3 oldu
                    
                    sorusayisi = 0; //yeniden başlamamız için soru sayısı sıfırlanmalı
                    label2.Text = sorusayisi.ToString(); //güncel soru sayısı yazdırıldı
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Cevap Yanlış");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e) //harf sil butonu
        {
            if (textBox5.Text != "") //butona tıkladığımızda textboxlardaki son harfi silecek
            {
                textBox5.Text = "";
            }
            else if (textBox5.Text == "" && textBox4.Text != "")
            {
                textBox4.Text = "";
            }
            else if (textBox5.Text == "" && textBox4.Text == "" && textBox3.Text != "")
            {
                textBox3.Text = "";
            }
            else if (textBox5.Text == "" && textBox4.Text == "" && textBox3.Text == "" && textBox2.Text != "")
            {
                textBox2.Text = "";
            }
            else if (textBox5.Text == "" && textBox4.Text == "" && textBox3.Text == "" && textBox2.Text == "" && textBox1.Text != "")
            {
                textBox1.Text = "";
            }
        }
        int ipucu = 3; //global olarak ipucu sayısını belirledik
        private void button17_Click(object sender, EventArgs e) //ipucu butonu
        {
            ipucu--; //ipucu butonuna her tıklandığında ipucu hakkımız azalacak
            label4.Text = ipucu.ToString(); //güncel ipucu yazdırıldı
            if (ipucu >= 0) //ipucu 0 olana kadar devam edecek
            {
                if (sorusayisi == 1) //1.sorudaki ipucu, eğer sırada hangi textbox boş ise oraya harf ekleyecek (son soruya kadar aynı yapı)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "A";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "T";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "A";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "M";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "A";
                    }
                }
                if (sorusayisi == 2)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "B";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "A";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "Ş";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "L";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "A";
                    }
                }
                if (sorusayisi == 3)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "B";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "O";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "O";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "L";
                    }
                    
                }
                if (sorusayisi == 4)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "V";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "E";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "R";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "İ";
                    }
                    
                }
                if (sorusayisi == 5)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "A";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "Ğ";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "A";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "Ç";
                    }
                    
                }
                if (sorusayisi == 6)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "Y";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "I";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "Ğ";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "I";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "N";
                    }
                }
                if (sorusayisi == 7)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "S";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "I";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "N";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "I";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "F";
                    }
                }
                if (sorusayisi == 8)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "W";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "H";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "I";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "L";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "E";
                    }
                }
                if (sorusayisi == 9)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "S";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "A";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "Y";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "A";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "Ç";
                    }
                }
                if (sorusayisi == 10)
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "M";
                    }
                    else if (textBox2.Text == "")
                    {
                        textBox2.Text = "E";
                    }
                    else if (textBox3.Text == "")
                    {
                        textBox3.Text = "T";
                    }
                    else if (textBox4.Text == "")
                    {
                        textBox4.Text = "O";
                    }
                    else if (textBox5.Text == "")
                    {
                        textBox5.Text = "T";
                    }
                }
            }
            else //eğer ipucu sayısı 0 olursa
            {
                ipucu = 0;
                label4.Text = ipucu.ToString(); //0 olan ipucu yazdırıldı (negatif sayılara düşmesini önlemek için)
                MessageBox.Show("İpucu Hakkınız Bitti.");
                
            }
        }
    }
}
