using System;

namespace if_else_if;

class Program
{
    static void Main(string[] args)
    {
        int hour = DateTime.Now.Hour;
        
        if(hour >= 6 && hour < 11)
            Console.WriteLine("Günaydın!");
        else if(hour <= 18)
            Console.WriteLine("İyi günler!");
        else
            Console.WriteLine("İyi geceler!");

        // string sonuc = hour <= 18 ? "İyi günler!" : "İyi geceler";
        string sonuc = hour >= 6 && hour < 11 ? "Günaydın!" : hour <= 18 ? "İyi günler!" : "İyi geceler!";
        Console.WriteLine(sonuc);
    }
}
