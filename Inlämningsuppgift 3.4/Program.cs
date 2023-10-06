using System;

namespace uppgift_3._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur lång är din låt? svara med två heltal t. ex. 3 50");
            string LåtLängd = Console.ReadLine();
            int mellanslagsindex = LåtLängd.IndexOf(" ");
            string minuter = LåtLängd[..mellanslagsindex];
            string sekunder = LåtLängd[(mellanslagsindex + 1)..];
            switch (minuter)
            {
                case "2":
                    if (int.Parse(sekunder) >= 45 && int.Parse(sekunder) <= 59) 
                    {
                        Console.WriteLine("Din låt får spelas");
                    }
                    else
                    {
                        Console.WriteLine("Din låt får tyvarr inte spelas.");
                    }
                    break;
                case "3":
                    if(int.Parse(sekunder) >=0 && int.Parse(sekunder) <= 59)
                    {
                        Console.WriteLine("Din låt får spelas");
                    }
                    else
                    {
                        Console.WriteLine("Din låt får tyvarr inte spelas.");
                    }
                    break;
                case "4":
                    if(int.Parse(sekunder) >=0 && int.Parse(sekunder) <= 20)
                    {
                        Console.WriteLine("Din låt får spelas");
                    }
                    else
                    {
                        Console.WriteLine("Din låt får tyvarr inte spelas.");
                    }
                    break;
                default:
                    Console.WriteLine("Din låt får tyvärr inte spelas");
                    break;

            }
        }
    }
}
