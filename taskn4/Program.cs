using System;

namespace taskn4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("baslangic eded :");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("son eded :");
            int son = int.Parse(Console.ReadLine());
            int teksum = 0;



            for (int i = baslangic; i < son; i++)
            {

                if (i % 2 != 0)
                {
                    teksum = teksum + i;
                }
            }

            Console.WriteLine("daxil etdiyiniz iki eded araligindaki teklerin cemi:" + teksum);
        }
    }
}
