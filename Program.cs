namespace problem1
{
   internal class Program
    {
      static void Main(string[] args)
      {
         //Berilgan 3 ta sondan nechtasi musbat
         //ekanligini aniqlovchi dastur yozing va
         //musbat sonlar sonini konsolga chiqaring.
         while (true)
         {
            Console.Write("Birinchi son: "); int.TryParse(Console.ReadLine(), out int x);
            Console.Write("Ikkinchi son: "); int.TryParse(Console.ReadLine(), out int y);
            Console.Write("Uchinchi son: "); int.TryParse(Console.ReadLine(), out int z);

            if (x > 0 && y > 0 && z > 0) Console.WriteLine($"Kiritilgan sondan 3 tasi musbat: {x}, {y}, {z}.");
            else if (x > 0 && y > 0 && z < 0) Console.WriteLine($"Kiritilgan sondan 2 tasi musbat: {x}, {y}.");
            else if (x < 0 && z > 0 && y > 0) Console.WriteLine($"Kiritilgan sondan 2 tasi musbat: {y}, {z}.");
            else if (x > 0 && y < 0 && z > 0) Console.WriteLine($"Kiritilgan sondan 2 tasi musbat: {x}, {z}.");
            else if (x > 0 && y < 0 && z < 0) Console.WriteLine($"Kiritilgan sondan 1 tasi musbat: {x}.");
            else if (x < 0 && y > 0 && z < 0) Console.WriteLine($"Kiritilgan sondan 1 tasi musbat: {y}.");
            else if (x < 0 && y < 0 && z > 0) Console.WriteLine($"Kiritilgan sondan 1 tasi musbat: {z}.");
            else if ( x == 0 || y == 0 || z == 0) Console.WriteLine("0 dan farqli son kiriting!");
            Console.WriteLine();
         }          
      }
   }
}