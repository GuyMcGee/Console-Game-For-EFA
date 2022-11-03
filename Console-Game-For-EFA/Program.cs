using System;

namespace Console_Game_For_EFA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userHP = 10;
            var enemyHP = 1000000000;
            var userDP = 3;
            var block = 3;

            Console.WriteLine("You encounter the boss, \"Puny human, prepare to die!\"");


            while (enemyHP > 0 && userHP > 0)
            {
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    int enemyDP = new Random().Next(1, 10);

                    enemyHP -= userDP;
                    Console.WriteLine("Boss takes " + userDP + " damage. Boss health is " + enemyHP);

                    Console.WriteLine("The boss prepares to attack...");
                    userHP -= enemyDP;
                    Console.WriteLine("Boss hits for " + enemyDP);
                    Console.WriteLine("Your health is " + userHP);
                }

                else if (userInput == 2)
                {
                    int enemyDP = new Random().Next(4, 10);
                    Console.WriteLine("Boss prepares to hit for " + enemyDP);
                    enemyDP -= block;
                    Console.WriteLine("You put your shield up. You take " + enemyDP);
                    Console.WriteLine("Your health is " + userHP);
                }

                else
                {
                    Console.WriteLine("Enter Valid Input, fool");
                }

            }

            if (enemyHP <= 0)
            {
                Console.WriteLine("YOU WIN");
            }

            else
            {
                Console.WriteLine("YOU LOSE, LOSER");
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
    }
}
    
