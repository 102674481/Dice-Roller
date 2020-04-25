﻿using System;

namespace DiceRoller
{
    class MainClass
    {

        public void draw(int result) {
            switch (result) {
                case 1:
                    Console.WriteLine("---------");
                    Console.WriteLine("-\t-");
                    Console.WriteLine("-   O   -");
                    Console.WriteLine("-\t-");
                    Console.WriteLine("---------");
                    break;
                case 2:
                    Console.WriteLine("---------");
                    Console.WriteLine("-O      -");
                    Console.WriteLine("-\t-");
                    Console.WriteLine("-      O-");
                    Console.WriteLine("---------");
                    break;
                case 3:
                    Console.WriteLine("---------");
                    Console.WriteLine("-O      -");
                    Console.WriteLine("-   O   -");
                    Console.WriteLine("-      O-");
                    Console.WriteLine("---------");

                    break;
                case 4:
                    Console.WriteLine("---------");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("-       -");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("---------");
                    break;
                case 5:
                    Console.WriteLine("---------");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("-   O   -");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("---------");

                    break;
                case 6:
                    Console.WriteLine("---------");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("-O     O-");
                    Console.WriteLine("---------");

                    break;
            }
        }

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string option;
            bool run = true;
            MainClass p = new MainClass();
            while (run)
            {
                int result = rnd.Next(1, 7);
                Console.WriteLine("Dice face value:" + result);
                p.draw(result);
                Console.Write("Roll again? (type no to quit)");
                option = Console.ReadLine();
                run = !option.Contains("n");
                if (!run)
                {
                    Console.WriteLine("Bye!");
                }

            }


        }
    }
}