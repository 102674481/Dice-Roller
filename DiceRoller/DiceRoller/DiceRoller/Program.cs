using System;

namespace DiceRoller
{

    class Dice
     {
        #region DrawingFace
        public void Draw(int result)
        {
            switch (result)
            {
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

        #endregion
    }
    class MainClass
    {



        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string option;
            bool run = true;
            int num;
            int choice = 2;
            Console.Write("Would you like to play a game or roll dice?, 1 for game and 2 for rolling dice?");
           
            choice  = Convert.ToInt16(Console.ReadLine());
            while (run)
            {
                Console.Write("How many dice:");
                num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Dice Dice = new Dice();
                    int result = rnd.Next(1, 7);
                    Console.WriteLine("Dice face value:" + result);
                    Dice.Draw(result);
                }
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
