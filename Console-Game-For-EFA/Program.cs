﻿using System;
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
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\"..." + User.Name + "...");
            System.Threading.Thread.Sleep(3200);
            Console.WriteLine("IT'S TIME TO FALL ON YOUR FACE\"");
            System.Threading.Thread.Sleep(2000);

            while (Boss.HP > 0 && User.HP > 0)
            {
                User.Attack = new Random().Next(5, 30);
                Boss.Attack = new Random().Next(25, 75);
                Console.WriteLine("What do you do?");
                var userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Boss.HP -= User.Attack;
                    Console.WriteLine("Boss takes " + User.Attack + " damage. Boss health is " + Boss.HP);
                    System.Threading.Thread.Sleep(2000);

                    Console.WriteLine("The boss prepares to attack...");
                    System.Threading.Thread.Sleep(2000);
                    User.HP -= Boss.Attack;
                    Console.WriteLine("Boss hits for " + Boss.Attack + ". Your health is " + User.HP);
                    System.Threading.Thread.Sleep(2000);
                }

                else if (userInput == "2")
                {
                    Console.WriteLine("Boss prepares to hit for " + Boss.Attack);
                    System.Threading.Thread.Sleep(2000);
                    Boss.Attack -= User.Block;
                    User.HP -= Boss.Attack;
                    Console.WriteLine("You put your shield up. You take " + Boss.Attack);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Your health is " + User.HP);
                    System.Threading.Thread.Sleep(2000);
                }

                else
                {
                    Console.WriteLine("Enter Valid Input, fool");
                }

            }

                if (Boss.HP <= 0)
                {
                    Console.WriteLine("YOU WIN");
                }

                else
                {
                    Console.WriteLine("YOU LOSE, LOSER");
                }
        }
    }




            //if (userInput = 1)
            //    Console.WriteLine("");

            //var bossHP = 200;

            //Random ranNum = new Random();
            //int secretNumber = ranNum.Next(1, 10);
            //var counter = 4;

            //do
            //{
            //    if (int.Parse(Console.ReadLine()) == secretNumber)
            //    {
            //        Console.WriteLine("A WINNER IS YOU!");
            //    }

            //    counter--;

            //} while (counter > 0);

            //Console.WriteLine("LOSER");
        }
    

    
