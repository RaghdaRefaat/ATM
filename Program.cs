using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            int choice = 0;
            int id = 0;
            Console.WriteLine("** Welcome At Auto Teller Machine **");
            Console.WriteLine("Tell Us Who Are You ?!");
            Console.WriteLine("1- New Client ! ");
            Console.WriteLine("2- Existing Client !");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1 :
                    client.AddClient();
                    break;
                case 2:
                    Console.WriteLine("Please enter Your ID !");
                    id = int.Parse(Console.ReadLine());
                    if (id < client.counter)
                    { }
                    else
                        Console.WriteLine("Sorry invalid ID ! , You Have 3 trials only");

                    break;
            }
        }
    }
}
