namespace TryParseVbOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayiText = "27";
            //int sayi = int.Parse(sayiText);
            //Console.WriteLine(sayi);

            int donusturulenSayi;
            bool sonuc= int.TryParse(sayiText, out donusturulenSayi);
            if (sonuc)
            {
                Console.WriteLine("Sayı Dönüştürüldü (" + donusturulenSayi + ")");
            }
            else
            {
                Console.WriteLine("Sayı Dönüştürülemedi.");
            }

            double carpim;
            double toplam = ToplaVeCarp(1.2, 4.6, out carpim);
            Console.WriteLine($"Toplam: {toplam}, Çarpım: {carpim}");
            float bolum = 0;
            float fark = CikarVeBol(2.4f, 2, ref bolum);
            Console.WriteLine($"Fark: {fark}, Bölüm: {bolum}");

        }

        static double ToplaVeCarp(double sayi1, double sayi2, out double carpim)
        {
            carpim = sayi1 * sayi2;
            return sayi1 + sayi2;
        }
        static float CikarVeBol(float sayi1, float sayi2, ref float bolum)
        {
            bolum = sayi1 / sayi2;
            return sayi1 - sayi2;
        }
    }
}