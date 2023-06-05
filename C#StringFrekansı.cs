internal class Program
{
    public static Dictionary<char, int> CountChars(string x)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        for (int i = 0; i < x.Length; i++)
        {
            char c = x[i];
            if (charCount.ContainsKey(c)) charCount[c]++;
            else charCount.Add(c, 1);
        }
        return charCount;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("String giriniz:");
        string a = Console.ReadLine();

        Dictionary<char, int> frekanslar = CountChars(a);

        Console.WriteLine("Harf frekansları:");

        for (int i = 0; i < frekanslar.Count; i++)
        {
            char harf = frekanslar.Keys.ElementAt(i);
            int frekans = frekanslar.Values.ElementAt(i);
            Console.WriteLine(harf + " : " + frekans);
        }
        Console.ReadKey();

    }
}

