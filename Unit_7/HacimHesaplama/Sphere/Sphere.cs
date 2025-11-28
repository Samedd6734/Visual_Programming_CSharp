using System;

class Kure
{
    // Kullanıcıdan yarıçapı al ve kürenin hacmini ekrana yazdır
    static void Main()
    {
        Console.Write("Kürenin yarıçapını giriniz: ");
        // Kullanıcının girdiği yazıyı sayıya (double) çeviriyoruz
        double yaricap = double.Parse(Console.ReadLine());

        // Sonucu ekrana yazdır (F3: Virgülden sonra 3 basamak göster demek)
        Console.WriteLine($"Hacim: {KureHacmi(yaricap):F3}");
    }

    // Küre hacmini hesaplayan ve sonucu döndüren metot
    // Formül: (4/3) * Pi * r³
    static double KureHacmi(double yaricap) =>
       (4.0 / 3.0) * Math.PI * Math.Pow(yaricap, 3);
}