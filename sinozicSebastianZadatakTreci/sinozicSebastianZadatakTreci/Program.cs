using System;

namespace sinozicSebastianZadatakTreci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Br = Convert.ToInt32(Console.ReadLine());

            if (Br % 4 == 0)
            {
                Console.WriteLine(" Broj je djeljiv sa 4. ");
            }
            if (Br % 6 == 0)
            {
         Console.WriteLine("Upisali ste broj: ", Br);
         Console.WriteLine("Broj je djeljiv sa 6.");
             }
        if (Br % 4 == 0 && Br % 6 == 0)
             {
         Console.WriteLine("Upisali ste broj: ", Br);
         Console.WriteLine("Broj je djeljiv sa 4 i sa 6.");
             }
         if (Br % 4 != 0 && Br % 6 != 0)
             {
         Console.WriteLine("Upisali ste broj: ", Br);
         Console.WriteLine("Broj nije djeljiv sa 4 i sa 6.");
             }
         Console.ReadKey();
  }
 }
}
