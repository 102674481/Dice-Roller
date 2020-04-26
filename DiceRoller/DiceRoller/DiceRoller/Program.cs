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
        public static void Rockgame()
        {
            string input;
            string pcinput;

            Console.WriteLine("rock, paper, scissor");
            input = Console.ReadLine();

            // int inputnumber = Convert.ToInt32(input);


            // Console.WriteLine("your input = {0} ", inputnumber);

            Random random = new Random();
            int gamerandom = random.Next(1, 4);

            switch (gamerandom)
            {
                case 1:
                    pcinput = "rock";
                    Console.WriteLine("cpu choose Rock");
                    //int inputcpu = Convert.ToInt32(pcinput);
                    if (input == "rock")
                    {
                        Console.WriteLine("DRAW!!!");

                        Console.WriteLine("*****                *****");
                        Console.WriteLine("*****       ---      *****");
                        Console.WriteLine("*****                *****");

                    }
                    else if (input == "paper")
                    {
                        Console.WriteLine("WIN!!!");

                        Console.WriteLine("****                * * *");
                        Console.WriteLine("****     ---        *   *");
                        Console.WriteLine("****                * * *");
                    }
                    else if (input == "scissor")
                    {
                        Console.WriteLine("LOSE!!!");

                        Console.WriteLine("*****                *   *  ");
                        Console.WriteLine("*****    ---           *    ");
                        Console.WriteLine("*****              ***   ***");
                    }

                    Console.WriteLine("{0}", gamerandom);

                    break;

                case 2:
                    pcinput = "paper";
                    Console.WriteLine("cpu choose paper");
                    if (input == "paper")
                    {
                        Console.WriteLine("DRAW!!!");

                        Console.WriteLine("* * *               * * *");
                        Console.WriteLine("*   *    ---        *   *");
                        Console.WriteLine("* * *               * * *");
                    }
                    else if (input == "rock")
                    {
                        Console.WriteLine("LOSE!!!");

                        Console.WriteLine("* * *               *****");
                        Console.WriteLine("*   *    ---        *****");
                        Console.WriteLine("* * *               *****");

                    }
                    else if (input == "scissor")
                    {
                        Console.WriteLine("WIN!!!");

                        Console.WriteLine("* * *                *   *  ");
                        Console.WriteLine("*   *    ---           *    ");
                        Console.WriteLine("* * *              ***   ***");
                    }

                    Console.WriteLine("{0}", gamerandom);
                    break;

                case 3:
                    pcinput = "scissor";
                    Console.WriteLine("cpu choose scissor");
                    if (input == "scissor")
                    {
                        Console.WriteLine("DRAW!!!");

                        Console.WriteLine("  *   *                      *   *  ");
                        Console.WriteLine("    *                          *    ");
                        Console.WriteLine("***   ***                  ***   ***");
                    }
                    else if (input == "rock")
                    {
                        Console.WriteLine("WIN!!!");


                        Console.WriteLine("  *   *                    *****\n" +
                                          "    *                      *****\n" +
                                          "***   ***                  *****");
                    }
                    else if (input == "paper")
                    {
                        Console.WriteLine("LOSE!!!");

                        Console.WriteLine("  *   *                    * * *\n"
                                         +"    *                      *   *\n"
                                         +"***   ***                  * * *");
                    }

                    Console.WriteLine("{0}", gamerandom);

                    break;

            }

        }

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
            Console.WriteLine((result > result2) ? "You win" : "You lose");
            if (result == result2)
                Console.WriteLine("Its a draw");

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
            Console.Write("Would you like to play a game or roll dice?, 1 for game, 2 for rolling dice and 3 for Rock Paper Scissors" +
            	"\nEnter Selection:");
           
            choice  = Convert.ToInt16(Console.ReadLine());
            while (run)
            {


                if (choice == 1)
                    GameLogic();

                if(choice == 2)
                    DiceLogic();
                if (choice == 3)
                    Rockgame();

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
