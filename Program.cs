/*
 MERVE NUR ÇELİK 

 Soru 1:  Main fonksiyonu içinde ekrandan dizinin boyutlarının kapasite 
bilgisini (n) (satır ya da sütun bilgisinin sadece birini) alınız. nxn
kapasitesinde iki boyutlu int tipinde bir dizi tanımlayınız. Bu dizinin içine 10-100 arasında (10 ve 
100 dahil olmak üzere) rastgele tek sayılar atayınız. (a) maddesinde oluşturduğunuz fonksiyonu 
kullanarak belirlenen bölgenin içinde kalan sayıların toplamını bulunuz ve ekrana yazdırınız.

*************************************************************************
Giriş parametresi olarak adı (dizi) olan int tipinde iki boyutlu, 
boyut kapasiteleri birbirine eşit (satır ve sütun sayısı aynı ve tek 
sayıdır) bir dizi alan, bu dizi içindeki yandaki şekilde gösterildiği esas 
köşegenler arasında kalan yeşil alanda kalan elemanların toplamını 
geriye cevap olarak döndüren bir fonksiyon yazınız.

*/
using System.Security.Cryptography.X509Certificates;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dizi için kapasite giriniz : " +
            "\n Not: Dizi bir kare matris olacağından (nxn) bir tane sayı giriniz .");
        int n= Convert.ToInt32(Console.ReadLine());
        int[,] dizi = new int[n, n];
        Random r = new Random();

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {

                int randomsayi = r.Next(10, 101);
                while(randomsayi %2==0) { // Gelen sayı çift ise tekrardan rastgele sayı çekiyoruz.

                    randomsayi = r.Next(10, 101);
                }

                dizi[i,j] = randomsayi;

            }
        }

        for(int i = 0; i < n; ++i) // diziyi yazdırırız:
        {
            for( int j = 0; j < n; ++j )
            {
                Console.Write(dizi[i,j]+" ");
                
            }
            Console.WriteLine();
        }

        Console.WriteLine("İstenilen Toplam : "+fonksiyon(dizi));


       // ****************************************************** FONKSİYON************************************************************
        static int fonksiyon(int[,]dizi)
        {

            int toplam = 0;
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(0); j++)
                {
                    if (i == j)     //Köşegen kontrolü yapıyoruz :
                    {
                       
                        if (j < dizi.GetLength(0) - i - 2)  //Köşegen üzerindeyken iki durumdan birini ele alıyoruz.Eğer toplanacak sayılar köşegenin sağında ise bu koşul sağlanıyor
                            for (int k = j; k < dizi.GetLength(0)-i-2; k++) {
                                toplam += dizi[i, k + 1];// Köşegenin sağında olduğundan dolayı toplama ve artırma işlemleri kullandım.
                            }
                        if (j > dizi.GetLength(0) - i -2 && i!=dizi.GetLength(0)/2) //Toplanacak sayılar köşegenin solunda ise bu koşulu sağlıyor.Ve tam ortada olmaması gerekiyor.
                        {
                            for (int k = j; k >dizi.GetLength(0)-i; k--)  {
                                toplam += dizi[i, k -1]; // Köşegenin solunda olduğundan dolayı çıkarma ve azaltma kullandım.
                            }
                        }
                    }

                }
            }

            return toplam; //Toplama eklenen sayılar fonksiyon çağırıldığında geri döndürülür.
        }

        Console.ReadKey();
    }

}
