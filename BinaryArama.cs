internal class Program
{
    private static void Main(string[] args)
    {
        /* SORU 1 :
  Giriş parametresi olarak adı (d) olan int tipinde tek boyutlu bir dizi ve adı (a) olan int tipinde bir 
 değişken alan, (a) değişkenini (d) dizisi içinde İkili Arama (Binary Search) yöntemine göre arayan ve 
 aranan değişken varsa dizideki indis numarasını yoksa -1 değerini geriye cevap olarak döndüren bir 
 fonksiyon yazınız (Parametre olarak verilen (d) dizisinin sıralı olup olmadığı bilinmemektedir). 

b) Main fonksiyonu içinde ekrandan dizinin kapasite bilgisi ve aranacak eleman bilgisini int tipinde 
alınız. Belirtilen kapasitede tek boyutlu bir int dizi tanımlayınız. Bu dizinin içine 10-100 arasında (10 
ve 100 dahil olmak üzere) rastgele sayılar atayınız. (a) maddesinde oluşturduğunuz fonksiyonu 
kullanarak aranacak elemanı dizide arayarak, fonksiyondan gelen cevaba göre uygun mesajı ekrana 
yazdırınız.*/

        int elemansayisi;
        int ara;
        int i;
        Console.WriteLine("DİZİNİN ELAMAN SAYISI KAÇ OLACAK ? \n GİRİNİZ: ");
        elemansayisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("DİZİDE ARANACAK ELAMAN NEDİR ? \n GİRİNİZ: ");
        ara = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[elemansayisi];
        Random r = new Random();
        for (i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(10, 101);
        }
        Array.Sort(dizi); //diziyi sıraladık.

        Console.WriteLine("OLUŞAN SIRALI DİZİ : ");
        for (i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi[i]);
        }

        int x = BinaryArama(dizi, ara);
        Console.WriteLine(x);

    }
    public static int BinaryArama(int[] d, int a)
    {

        int n = d.Length;
        int alt = 0;
        int ust = n - 1;

        //Binary Search
        Boolean flag = false;
        while (alt <= ust)
        {
            int orta = (ust + alt) / 2;
            if (d[orta] == a)

            {

                Console.WriteLine("\n VAR İNDİS NUMARASI: ");
                flag = true;
                return orta;

            }
            else
            {
                if (a < d[orta])
                {
                    ust = orta - 1;
                }
                else
                    alt = orta + 1;
            }
        }
        Console.WriteLine("");
        return -1;
    }
}

