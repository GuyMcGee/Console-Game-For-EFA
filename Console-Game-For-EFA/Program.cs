using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Console_Game_For_EFA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var User = new User();
            User.Name = Console.ReadLine();
            User.HP = 300;
            User.Block = 10;

            var Boss = new Enemy();
            Boss.Name = "Boss Terry";
            Boss.HP = 75;

            Console.WriteLine("You have reached level 3.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Your HP is now " + User.HP + ".");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Previous enemy dropped emerald sword and shield; you pick them up.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Your attack and defense has increased.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You encounter " + Boss.Name + ".");
            System.Threading.Thread.Sleep(3200);
            Console.WriteLine("\"..." + User.Name + "...");
            System.Threading.Thread.Sleep(3200);
            Console.WriteLine("IT'S TIME TO FALL ON YOUR FACE!\"");
            System.Threading.Thread.Sleep(2000);

            while (Boss.HP > 0 && User.HP > 0)
            {
                User.Attack = new Random().Next(5, 30);
                Boss.Attack = new Random().Next(25, 75);
                Console.WriteLine("What do you do?");
                var userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine(Boss.Name + " attacks");
                    System.Threading.Thread.Sleep(1000);
                    User.HP -= Boss.Attack;
                    Console.WriteLine(Boss.Name + " hits for " + Boss.Attack + ". Your health is now " + User.HP);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(User.Name + " attacks");
                    System.Threading.Thread.Sleep(1000);
                    Boss.HP -= User.Attack;
                    Console.WriteLine(Boss.Name + " takes " + User.Attack + " damage. " + Boss.Name + "'s health is now " + Boss.HP);
                    System.Threading.Thread.Sleep(1000);
                }

                else if (userInput == "2")
                {
                    Console.WriteLine(Boss.Name + " prepares to hit for " + Boss.Attack);
                    System.Threading.Thread.Sleep(1000);
                    Boss.Attack -= User.Block;
                    User.HP -= Boss.Attack;
                    Console.WriteLine("You put your shield up. You take " + Boss.Attack);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Your health is now " + User.HP);
                    System.Threading.Thread.Sleep(1000);
                }

                else
                {
                    Console.WriteLine("Enter Valid Input, fool");
                }

            }

            if (Boss.HP <= 0 && User.HP > 0)
            {
                Console.WriteLine(User.Name + " defeated " + Boss.Name + " and found six-figures worth of treasure.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("THE END");
            }

            else if (Boss.HP <= 0 && User.HP <= 0)
            {
                Console.WriteLine(User.Name +" & " + Boss.Name + " slay each other in simultaneous attacks and waste away together");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("THE END");
            }

            else if (User.HP <= 0)
            {
                Console.WriteLine("You have fallen on your face."); 
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("GAME OVER");
            }
        }
    }
}


    
