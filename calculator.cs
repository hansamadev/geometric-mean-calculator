using System;

class Program
{
    static void Main()
    {
        // Birinci sayıyı al
        Console.Write("İlk sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        // İkinci sayıyı al 
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // Geometrik ortalamayı al.
        double geometrikOrtalama = Math.Sqrt(sayi1 * sayi2);

        // Sonucu ekrana yaz.
        Console.WriteLine("Geometrik Ortalama: " + geometrikOrtalama);
    }
}
