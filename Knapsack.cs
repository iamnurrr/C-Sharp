using System;
/*

Ürün1 Ürün2 Ürün3 Ürün4 Ürün5
Ağırlık (kg) 1 2 3 4 5
Fiyat(TL) 1 3 4 5 6
Yukarıdaki tabloda ürünlerin ağırlık ve fiyat bilgileri yer almaktadır. Bu bilgilere göre kapasitesi 8kg olan 
bir çantayı fiyat toplamı en fazla olacak şekilde dolduran (Knapsack yöntemi ile), çantaya konan 
ürünlerin isimlerini ve çantaya konan ürünlerin toplam fiyat bilgisini ekrana yazdıran programı yazınız.*/

class Program
{
    static void Main()
    {
        string[] urunler = { "Ürün1", "Ürün2", "Ürün3", "Ürün4", "Ürün5" };
        int[] agirliklar = { 1, 2, 3, 4, 5 };
        int[] fiyatlar = { 1, 3, 4, 5, 6 };
        int toplamUrun = urunler.Length;

        int[,] tablo = new int[toplamUrun + 1, 9];

        for (int i = 0; i <= toplamUrun; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                if (i == 0 || j == 0)
                    tablo[i, j] = 0;
                else if (agirliklar[i - 1] <= j)
                    tablo[i, j] = Math.Max(fiyatlar[i - 1] + tablo[i - 1, j - agirliklar[i - 1]], tablo[i - 1, j]);
                else
                    tablo[i, j] = tablo[i - 1, j];
            }
        }

        int maxFiyat = tablo[toplamUrun, 8];
        Console.WriteLine("ÜRÜNLERİN İSİMLERİ : ");

        int urunIndex = toplamUrun;
        int agirlik = 8;

        while (urunIndex > 0 && maxFiyat > 0)
        {
            if (maxFiyat != tablo[urunIndex - 1, agirlik])
            {
                Console.WriteLine(urunler[urunIndex - 1]);
                maxFiyat -= fiyatlar[urunIndex - 1];
                agirlik -= agirliklar[urunIndex - 1];
            }
            urunIndex--;
        }

        Console.WriteLine(" ÜRÜNLERİN TOPLAM FİYATI : " + (tablo[toplamUrun, 8]));
        Console.ReadKey();
    }
    
}
