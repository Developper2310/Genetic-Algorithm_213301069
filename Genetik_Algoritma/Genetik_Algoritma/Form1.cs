using OxyPlot.Series;
using OxyPlot;
using System.Reflection;

namespace Genetik_Algoritma
{
    public partial class Form1 : Form
    {
        static Birey eniyi=new Birey(0,0);
        

        public void Ciz(List<double> uygunluklar)
        {
            var model = new PlotModel { Title = "Uygunluk Değerleri" };
            var series = new LineSeries();
            for (int i = 0; i < uygunluklar.Count; i++)
            {
                series.Points.Add(new DataPoint(i, uygunluklar[i]));
            }
            model.Series.Add(series);

            // Oluşturulan grafiğin PlotView kontrolüne atanması
            plotView1.Model = model;
        } 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int populasyonBoyutu = int.Parse(textBox1.Text);
            double caprazlamaOrani = double.Parse(textBox2.Text);
            double mutasyonOrani = double.Parse(textBox3.Text);
            int jenerasyonSayisi = int.Parse(textBox4.Text);
            double secimOrani = double.Parse(textBox5.Text);

            double minDeger = -10;
            double maxDeger = 10;
           

          
            GenetikAlgoritma genetikAlgoritma = new GenetikAlgoritma(populasyonBoyutu, caprazlamaOrani, mutasyonOrani, jenerasyonSayisi, minDeger, maxDeger, secimOrani);
            genetikAlgoritma.Calistir();
            Ciz(genetikAlgoritma.uygunluklar);
            textBox6.Text = $"X={eniyi.X}";
            textBox7.Text = $"Y={eniyi.Y}";
            textBox8.Text = $"{eniyi.Uygunluk}";
            // Grafik çizimini burada yap
        }


        public class GenetikAlgoritma
        {
            public List<double> uygunluklar{ get; private set;}
            private List<Birey> popülasyon;
            private int populasyonBoyutu;
            private double caprazlamaOrani;
            private double mutasyonOrani;
            private int jenerasyonSayisi;
            private double secimOrani;

            private double minDeger;
            private double maxDeger;


       
            public GenetikAlgoritma(int populasyonBoyutu, double caprazlamaOrani, double mutasyonOrani, int jenerasyonSayisi, double minDeger, double maxDeger, double secimOrani)
            {

                this.populasyonBoyutu = populasyonBoyutu;
                this.caprazlamaOrani = caprazlamaOrani;
                this.mutasyonOrani = mutasyonOrani;
                this.jenerasyonSayisi = jenerasyonSayisi;
                this.minDeger = minDeger;
                this.maxDeger = maxDeger;

                this.secimOrani = secimOrani;
                uygunluklar = new List<double>(); 

            }


            public void Calistir()
            {
                PopülasyonOluştur(); 

                for (int jenerasyon = 0; jenerasyon < jenerasyonSayisi; jenerasyon++)
                {
                    // uygunluk değerei-------------------
                    //plot burada
                    foreach (var birey in popülasyon)
                    {
                        birey.UygunlukHesapla();
                        uygunluklar.Add(birey.Uygunluk);
                        
                    }

                    Birey enIyiBirey = popülasyon.OrderBy(birey => birey.Uygunluk).First();

                
                    if (jenerasyon == jenerasyonSayisi - 1)
                    {
                        Console.WriteLine("Başarılı bir çözüm bulundu.");
                        Console.WriteLine($"Jenerasyon: {jenerasyon + 1}");
                        Console.WriteLine($"En iyi çözümün x değeri: {enIyiBirey.X}");
                        eniyi.X = enIyiBirey.X;
                        eniyi.Y = enIyiBirey.Y;
                        eniyi.SetUygunluk(enIyiBirey.Uygunluk);
                        Console.WriteLine($"En iyi çözümün y değeri: {enIyiBirey.Y}");
                        Console.WriteLine($"En iyi çözümün uygunluk değeri: {enIyiBirey.Uygunluk}");
                      
                        break;

                    }

                    // Yeni bireyl oluşturucu
                    List<Birey> yeniNesil = new List<Birey>();
                    for (int i = 0; i < populasyonBoyutu; i++)
                    {
                        Birey ebeveyn1 = Secim(secimOrani);
                        Birey ebeveyn2 = Secim(secimOrani);
                        Birey cocuk = Crossover(ebeveyn1, ebeveyn2);
                        Mutasyon(cocuk);
                        yeniNesil.Add(cocuk);
                    }

                    
                    popülasyon = yeniNesil;
                }
            }


            private void PopülasyonOluştur()
            {
                popülasyon = new List<Birey>(); 
                Random rastgele = new Random();
                for (int i = 0; i < populasyonBoyutu; i++)
                {
                    
                    double x = rastgele.NextDouble() * 20 - 10; 
                    double y = rastgele.NextDouble() * 20 - 10;
                    Birey yeniBirey = new Birey(x, y); 
                    popülasyon.Add(yeniBirey); 
                }
            }
          
            private Birey Crossover(Birey ebeveyn1, Birey ebeveyn2)
            {
               
                Random rastgele = new Random();
                double x = (ebeveyn1.X + ebeveyn2.X) / 2; // orta nokta
                double y = (ebeveyn1.Y + ebeveyn2.Y) / 2; 
                return new Birey(x, y);
            }

      
            private void Mutasyon(Birey birey)
            {
               
                Random rastgele = new Random();
                if (rastgele.NextDouble() < mutasyonOrani)
                {
                    birey.X += (rastgele.NextDouble() * 2 - 1); //-1 ve 1 arasında sayı
                }
                if (rastgele.NextDouble() < mutasyonOrani)
                {
                    birey.Y += (rastgele.NextDouble() * 2 - 1); 
                }
            }



            private Birey Secim(double secimOrani)//rulet tekerliği
            {
                
                Random rastgele = new Random();
                if (rastgele.NextDouble() < secimOrani)//max 1
                {
                
                    return popülasyon.OrderBy(birey => birey.Uygunluk).First();
                }
                else
                {
                    
                    int indeks = rastgele.Next(popülasyon.Count);
                    return popülasyon[indeks];
                }
            }
        }


    

    class Birey
    {
        public double X { get; set; } 
        public double Y { get; set; } 
        public double Uygunluk { get; private set; } 

       
        public Birey(double x, double y)
        {
            X = x;
            Y = y;
            UygunlukHesapla(); // Başlangıçta uygunluk değerini hesapla
        }
            public void SetUygunluk(double uygunluk)
            {
                Uygunluk = uygunluk;//eniyi atmsını yapmak için
            }

            public void UygunlukHesapla()
        {
            // İstenen fonksiyonu buraya uygulayarak uygunluk değerini hesapla
            Uygunluk = Math.Pow(Math.Sin(3 * Math.PI * X), 2) + Math.Pow(X - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * Y), 2)) + Math.Pow(Y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * Y), 2));
        }
    }
    

}





}
