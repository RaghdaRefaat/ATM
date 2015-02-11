using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ATM
{
    class Client
    {
        private string Name;
        private int ID;
        private float Balance;

        public int counter;

        public Client()
        {
            Name = " " ;
            ID = 0 ;
            Balance = 0 ;
        }

        public void SetName(string name)
        { Name = name ; }

        public void SetID(int id)
        { ID = id ; }

        public void SetBalance(float bal)
        { Balance = bal ; }

        public string GetName()
        { return Name; }

        public int GetID()
        { return ID; }

        public float GetBalance()
        { return Balance; }

        public void AddClient()
        {
            FileStream fs = new FileStream("D://ClientData.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string name = " ";
            float bal = 0;
            Console.WriteLine("Please Enter Your Name !");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Balance !");
            bal = int.Parse(Console.ReadLine());
            if (bal < 1)
            {
                Console.WriteLine("invalid balance , please enter another one");
                bal = int.Parse(Console.ReadLine());
            }
            counter++;
            Console.Write("Your ID is : ");
            Console.WriteLine(counter);
            SetName(name);
            SetID(counter);
            SetBalance(bal);
            sw.WriteLine(Name);
            sw.WriteLine(counter);
            sw.WriteLine(Balance);
            sw.Close();
        }

        public Client GetClient(int id)
        {
            FileStream f = new FileStream("D://ClientData.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            int tmp = 0;
            string name = " ";
            int bal = 0;
            int len = counter * 3;
            while (sr.Peek() != -1)
            {
                tmp = int.Parse(sr.ReadLine());
                if (tmp == id)
                {
                    name = sr.ReadLine();
                    bal = int.Parse(sr.ReadLine());
                    break;
                }
                else
                {
                    sr.ReadLine();
                    sr.ReadLine();
                }

            }
            SetID(id);
            SetName(name);
            SetBalance(bal);
            return this;
        }

        public void AddMoney(int balance)
        {
            FileStream f = new FileStream("D://ClientData.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(f);
        }

    }
}
