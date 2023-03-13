using System;

namespace Kittichai {
    class Program {
        static void Main(string[] args) {

            Console.Write("Input your day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Input your time: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Input your menu: ");
            string menu = Console.ReadLine();

            Console.Write("Sorry your order is out of stock");
            string order = Console.ReadLine();

            int Monday = 1;
            int Tuesday = 2;
            int Wednesday = 3;
            int Thursday = 4;
            int Friday = 5;
            int Saturday = 6;
            int Sunday = 7;
            int Time8 = 8;
            int Time9 = 9;
            int Time10 = 10;
            int Time11 = 11;
            int Time12 = 12;
            int Time13 = 13;
            int Time14 = 14;
            int Time15 = 15;
            int Time16 = 16;
            int Time17 = 17;
            int Time18 = 18;
            int Order1 = 0;
            int Order2 = 0;
            int Order3 = 0;
            
            if(menu == "Breakfast Set"){
                if(Time8 == 8 || Time9 == 9 || Time10 == 10 || Time11 == 11){
                    if(Order1 > 0){
                        Console.WriteLine("Please wait a minute");
                    }
                    else{
                        Console.WriteLine("Please wait a minute");
                    }
                }
                else{
                    Console.WriteLine("Sorry your order is out of stock");
                }
            }
            else if(menu == "Weekend Set"){
                if(Monday == 1 || Tuesday == 2 || Wednesday == 3 || Thursday == 4 || Friday == 5){
                    if(Order2 > 0){
                    Console.WriteLine("Sorry your order is not available");
                    }
                }
                else{
                    Console.WriteLine("Please wait a minute");
                }
            }
            else if(menu == "Coffee"){
                if(Order3 >0){
                    Console.WriteLine("Please wait a minute");
                }
            }
        }
    }
}