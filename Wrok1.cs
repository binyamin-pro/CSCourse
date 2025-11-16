using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void task1()
        {

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0) { if (num % 2 == 0) { Console.WriteLine("Positive & Even"); } else { Console.WriteLine("Positive but not even"); } }
            else if (num < 0) { Console.WriteLine("Negitive"); }
            else { Console.WriteLine("ZERO"); }

        }

        static void task2()
        {
            Console.Write("Enter usage: ");
            double price, num = int.Parse(Console.ReadLine());
            Console.Write("Is Business? ");
            bool IsBusiness = bool.Parse(Console.ReadLine());

            if (num <= 300) { price = (num * 0.5); }
            else if (num <= 600) { price = (num * 0.7); } else { price = (num * 1); }

            if (IsBusiness) { price = (price * 1.15); } else { price = (price * 1.05); }


            Console.WriteLine(price);

        }

        static void task3()
        {
            Console.Write("City bus? ");
            bool city = bool.Parse(Console.ReadLine());
            Console.Write("Student? ");
            bool student = bool.Parse(Console.ReadLine());
            Console.Write("Gmal? ");
            bool gmal = bool.Parse(Console.ReadLine());

            double price;
            if (city) { price = 6; } else {  price = 12; }
            if (student) { price = price - price * 0.2; }
            if (gmal) { price = price - price * 0.3; }

            Console.Write("Price: " + price);

        }

        static void task4()
        {
            double price;
            Console.Write("Age? ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                price = 120;
                Console.Write("In School? ");
                if (bool.Parse(Console.ReadLine())) { price = price - price * 0.2; }
            }
            else if (age <= 60)
            {
                price = 180;
                Console.Write("VIP? ");
                if (bool.Parse(Console.ReadLine())) { price = price + price * 0.3; }
            }
            else
            {
                price = 150;
                Console.Write("Gmal? ");
                if (bool.Parse(Console.ReadLine())) { price = price - price * 0.15; }
            }


            Console.WriteLine("Price: " + price);

        }

        static void task5()
        {
            Console.WriteLine("Regular room? ");
            bool regular = bool.Parse(Console.ReadLine());
            Console.WriteLine("Weekend? ");
            bool Weekend = bool.Parse(Console.ReadLine());
            Console.WriteLine("VIP Member? ");
            bool VIP = bool.Parse(Console.ReadLine());

            double price;
            if (regular) { price = 400; } else { price = 700; }
            if (Weekend) { price = price + price * 0.1; }
            if (VIP) { price = price - price * 0.15; }

            Console.WriteLine("Price: " + price);
           
        }

        static void task6()
        {

            double price;
            Console.Write("Age? ");
            int age = int.Parse(Console.ReadLine());

            if (age < 12)
            {
                price = 50;
                Console.Write("Weekend? ");
                if (bool.Parse(Console.ReadLine())) { price = price + 10; }
            }
            else if (age <= 17)
            {
                price = 70;
                Console.Write("Member? ");
                if (bool.Parse(Console.ReadLine())) { price = price - price * 0.2; }
            }
            else
            {
                price = 100;
                Console.Write("VIP? ");
                if (bool.Parse(Console.ReadLine())) { price = price + price * 0.3; }
            }


            Console.WriteLine("Price: " + price);

        }

        static void task7()
        {

            double price;
            Console.Write("Age? ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 24)
            {
                price = 600;
                Console.Write("Sports car? ");
                if (bool.Parse(Console.ReadLine())) { price = price + price*0.25; }
            }
            else if (age <= 50)
            {
                price = 450;
                Console.Write("Accident last year? ");
                if (bool.Parse(Console.ReadLine())) { price = price + price * 0.2; }
            }
            else
            {
                price = 400;
                Console.Write("Regular car? ");
                if (bool.Parse(Console.ReadLine())) { price = price - price * 0.1; }
            }


            Console.WriteLine("Price: " + price);

        }

        static void Main(string[] args)
        {

            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();

            Console.WriteLine("Work by H. Binyamin & L. Netanel");
            Console.Write("Select task: [1-7] ");
            int taskN = int.Parse(Console.ReadLine());

            if (taskN == 1) { task1(); }
            if (taskN == 2) { task2(); }
            if (taskN == 3) { task3(); }
            if (taskN == 4) { task4(); }
            if (taskN == 5) { task5(); }
            if (taskN == 6) { task6(); }
            if (taskN == 7) { task7(); }

        }
    }
}
