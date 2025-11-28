using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace paint
{
    public partial class Form1 : Form
    {
        // --- 1. DEĞİŞKENLERİMİZ ---
        Bitmap kagit;           // Üzerine çizeceğimiz sanal kağıt
        Graphics ressam;        // Çizim yapan araç
        bool ciziyorMu = false; // Mouse basılı mı?
        Point eskiNokta;        // Farenin bir önceki konumu
        Pen kalem;              // Kullandığımız kalem

        // Geri alma işlemi için listemiz (Stack en son gireni ilk verir)
        Stack<Image> gecmis = new Stack<Image>();

        public Form1()
        {
            InitializeComponent();
        }

        // --- 2. PROGRAM AÇILINCA YAPILACAKLAR ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ekran boyutuna göre kağıt oluştur (Genişlik, Yükseklik)
            kagit = new Bitmap(pcbTuval.Width, pcbTuval.Height);

            // Ressamı kağıda ata
            ressam = Graphics.FromImage(kagit);
            ressam.Clear(Color.White); // Arka planı beyaz yap

            // Hazırladığımız kağıdı PictureBox'a koy
            pcbTuval.Image = kagit;

            // Varsayılan Kalem Ayarı
            kalem = new Pen(Color.Black, 5);
            kalem.StartCap = LineCap.Round; // Kalem ucu yuvarlak başlasın
            kalem.EndCap = LineCap.Round;   // Kalem ucu yuvarlak bitsin
            kalem.LineJoin = LineJoin.Round; // Köşeler yuvarlak dönsün
        }

        // --- 3. ÇİZİM İŞLEMLERİ (MOUSE OLAYLARI) ---

        // Fareye basıldığında (Çizim başlar)
        private void pcbTuval_MouseDown(object sender, MouseEventArgs e)
        {
            ciziyorMu = true;
            eskiNokta = e.Location; // Başladığımız yeri kaydet

            // Çizime başlamadan ÖNCE şu anki hali hafızaya at (Undo için)
            // .Clone() demezsek referans hatası olur, kopyasını almalıyız.
            gecmis.Push((Image)kagit.Clone());
        }

        // Fare hareket ettiğinde (Çizim devam eder)
        private void pcbTuval_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciziyorMu == true)
            {
                Point yeniNokta = e.Location;

                // Eski noktadan yeni noktaya çizgi çek
                ressam.DrawLine(kalem, eskiNokta, yeniNokta);

                // Görüntüyü güncelle
                pcbTuval.Invalidate();

                // Yeni noktayı eski nokta yap ki çizgi devam etsin
                eskiNokta = yeniNokta;
            }
        }

        // Fare bırakıldığında (Çizim biter)
        private void pcbTuval_MouseUp(object sender, MouseEventArgs e)
        {
            ciziyorMu = false;
        }

        // --- 4. ARAÇ BUTONLARI ---

        // Temizle Butonu
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Silmeden önce yedeğini al
            gecmis.Push((Image)kagit.Clone());

            ressam.Clear(Color.White);
            pcbTuval.Invalidate();
        }

        // Geri Al Butonu
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (gecmis.Count > 0) // Eğer geçmişte kayıt varsa
            {
                // En son eklenen resmi al
                Image eskiResim = gecmis.Pop();

                // Şu anki kağıda bu eski resmi yükle
                kagit = new Bitmap(eskiResim);
                ressam = Graphics.FromImage(kagit);
                pcbTuval.Image = kagit;
                pcbTuval.Invalidate();
            }
            else
            {
                MessageBox.Show("Geri alınacak işlem kalmadı!");
            }
        }

        // --- 5. RENK VE BOYUT AYARLARI ---

        // Renk Radyo Butonları için Ortak Metot
        private void RenkDegistir(object sender, EventArgs e)
        {
            // Tıklanan butonu yakala
            RadioButton secilen = (RadioButton)sender;
            if (kalem == null) return;
            if (secilen.Name == "rbKirmizi") kalem.Color = Color.Red;
            else if (secilen.Name == "rbMavi") kalem.Color = Color.Blue;
            else if (secilen.Name == "rbYesil") kalem.Color = Color.Green;
            else if (secilen.Name == "rbSiyah") kalem.Color = Color.Black;

        }

        // Boyut Radyo Butonları için Ortak Metot
        private void BoyutDegistir(object sender, EventArgs e)
        {
            RadioButton secilen = (RadioButton)sender;
            if (kalem == null) return;
            if (secilen.Name == "rbKucuk") kalem.Width = 3;
            else if (secilen.Name == "rbOrta") kalem.Width = 8;
            else if (secilen.Name == "rbBuyuk") kalem.Width = 15;
        }
    
    }
}

