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
   class DiceRoller 
   {
   
     }
    class MainClass
  
    {

        public static void DiceLogic() 
        {
            Random rnd = new Random();
            int num;

            Console.Write("How many dice:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Dice Dice = new Dice();
                int result = rnd.Next(1, 7);
                Console.WriteLine("Dice face value:" + result);
                Dice.Draw(result);
            }


        }

        public static void GameLogic() 
        {
            Dice Dice = new Dice();
            int result, result2;
            Random rnd = new Random();
            result = rnd.Next(1, 7);
            result2 = rnd.Next(1, 7);
            if (result > result2)
            {
                Console.WriteLine("You win");
            }
            else if (result < result2)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("Its a draw");
            }
            Console.WriteLine("Your dice face value:" + result);
            Dice.Draw(result);
            Console.WriteLine("Computer's dice face value:" + result2);
            Dice.Draw(result2);
        }

        public static void Main(string[] args)
        {


            bool run = true;
            string option;
            int choice = 2;
            Console.Write("Would you like to play a game or roll dice?, 1 for game and 2 for rolling dice?\nEnter Selection:");
           
            choice  = Convert.ToInt16(Console.ReadLine());
            while (run)
            {


                if (choice == 1)
                    GameLogic();

                if(choice == 2)
                    DiceLogic();

                Console.Write("again? (type no to quit)\nSelection:");
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
