using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("Dizi boyutunu girin (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] dizi = new int[n, n];
        Random rastgele = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dizi[i, j] = rastgele.Next(10, 101); // 10-100 arasında rastgele sayılar
            }
        }

        Console.WriteLine("Dizi:");
        Yazdir(dizi);

        int toplam = ToplamEsasKosegenKesisimi(dizi);
        Console.WriteLine("Esas köşegenlerin kesiştiği elemanların üstünde ve altında kalan bölgedeki elemanların toplamı: " + toplam);
        Console.ReadKey();
    }

    static int ToplamEsasKosegenKesisimi(int[,] dizi)
    {
        int boyut = dizi.GetLength(0);
        int toplam = 0;

        int baslangic = boyut / 2;  // Esas köşegenin başlangıç indeksi

        for (int i = 0; i < baslangic; i++)
        {
            for (int j = i + 1; j < boyut - i - 1; j++)
            {
                toplam += dizi[i, j]; // Üstte kalan bölge
                toplam += dizi[boyut - i - 1, j]; // Altta kalan bölge
            }
        }

        return toplam;
    }

    static void Yazdir(int[,] dizi)
    {
        int boyut = dizi.GetLength(0);

        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write(dizi[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}