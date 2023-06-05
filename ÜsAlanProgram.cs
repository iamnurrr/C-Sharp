//SORU2
//Giriş parametresi olarak adı (x) ve (n) adlarında iki adet int tipinde değişken alan, buna göre x^n
//değerini hesaplayan ve cevabı geriye döndüren yinelemeli (recursive) bir fonksiyon yazınız.

/*Main fonksiyonu içinde ekrandan int tipinde (a) ve(b) adlarında iki tamsayı alınız. (a) maddesinde
oluşturduğunuz fonksiyonu kullanarak a^b  değerini hesaplayarak sonucu ekrana yazdırınız*/



internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("BU PROGRAM GİRİLEN X'IN ÜSSÜNÜ GİRİLEN N'E GÖRE ALMAKTADIR!!!");
        Console.WriteLine("X'i Giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("N'i Giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());


        int y = usAlma(a, b);

        Console.WriteLine(y);

    }

    public static int usAlma(int x, int n)
    {
        if (n == 0)
        {

            return 1;      // n=0 için , x^0 =1 olacağı durum.
        }
        else if (n % 2 == 0)
        {
            int y = usAlma(x, n / 2); // n çift sayı olması durumu.

            return y * y;
        }
        else
        {

            return x * usAlma(x, n - 1); //n tek sayı olması durumu

        }
    }

}

