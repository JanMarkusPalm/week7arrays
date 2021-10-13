using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida mida ta hommikusöögiks sööb

            Console.WriteLine("Tere tulemast väga ohutusse söögirestorani!");
            string[] food = { "võileib juustuga", "kruvid", "toores liha", "kurbade laste pisarad", "kala silmad" };
            /*
            food[3] = "hitler";
            food[2] = "un bro momento";
            */
            Console.WriteLine("Menüüs: ");

            for (int i = 0; i< food.Length; i++)
            {

                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Palun valige mida te soovite hommikusöögiks soovite süüa. (sisesta number 1-5)");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"oled valinud {food[userchoice]}");

            if (userchoice > 5)
            {
                Console.WriteLine("kas miski jäi arusaamatuks 1-5 vahel? ");
            }

        }
    }
}
