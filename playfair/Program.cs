namespace playfair
{
    internal class Program
    {
        static void Main()
        {
            PlayfairKodolo pk = new("kulcstabla.txt");
            Console.Write("6. feladat: Kérek egy nagybetűt: ");
            char betu = char.Parse(Console.ReadLine());
            (int S, int O) betuIndex = pk.Index(betu);
            Console.WriteLine($"A karakter sorának indexe: {betuIndex.S}");
            Console.WriteLine($"A karakter oszlopának indexe: {betuIndex.O}");
            Console.Write($"8. feladat: Kérek egy karakterpárt: ");
            string karakterpar = Console.ReadLine();
            Console.WriteLine($"Kódolva: {pk.KodbolBetupar(karakterpar)}");
            
        }
    }
}