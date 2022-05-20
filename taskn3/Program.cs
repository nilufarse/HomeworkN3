using System;

namespace taskn3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            int point = 50;
            bool iscontinue = true;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine("note your age");
                int ageask = int.Parse(Console.ReadLine());
                if (ageask > age)
                {
                    Console.WriteLine("note your point");
                    int pointask = int.Parse(Console.ReadLine());
                    if (pointask > point)
                    {
                        Console.WriteLine("you passed successfully");
                    }
                    else
                    {
                        Console.WriteLine("point not enough");
                    }
                }
                else
                {
                    Console.WriteLine("you are not old enough");
                }
                Console.WriteLine("is continue? yes/no");
                string ask = Console.ReadLine();

                if (ask == "yes")
                {
                    iscontinue = true;
                }
                if (ask == "no")
                {
                    Console.WriteLine("thank you");
                    iscontinue = false;
                }
            } while (iscontinue);
        }
    }
}
