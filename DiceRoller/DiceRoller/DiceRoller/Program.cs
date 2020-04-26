using System;

namespace DiceRoller
{

    class Dice
     {
        #region DrawingFace
        public void Draw(int result)
        {
            bool[,] FaceMat = new bool[3,3];

            FaceMat[2, 2] = true;
            FaceMat[0, 0] = true;
            switch (result)
            {
                case 1:
                    FaceMat[1, 1] = true;
                    FaceMat[2, 2] = false;
                    FaceMat[0, 0] = false;

                    break;
                case 2: break;
                case 3: FaceMat[1, 1] = true;break;
                case 4:
                    FaceMat[0, 2]= true;
                    FaceMat[2, 0]= true;
                    FaceMat[1, 1] = false;

                    break;
                case 5:
                    FaceMat[0, 2] = true;
                    FaceMat[1, 1] = true;
                    FaceMat[2, 0] = true;


                    break;
                case 6:
                    FaceMat[0, 2] = true;
                    FaceMat[1, 0] = true;
                    FaceMat[1, 2] = true;
                    FaceMat[2, 0] = true;

                    break;
            }
            Console.WriteLine("---------\n-{0}     {1}-\n-{2}  {3}  {4}-\n-{5}     {6}-\n---------"
            
            , (FaceMat[0, 0] ? "O" : " ")
            ,(FaceMat[0, 2] ? "O" : " ")
            ,(FaceMat[1, 0] ? "O" : " ")
            ,(FaceMat[1, 1] ? "O" : " ")
            ,(FaceMat[1, 2] ? "O" : " ")
            ,(FaceMat[2, 0] ? "O" : " ")
            ,(FaceMat[2, 2] ? "O" : " "));
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
            string pcinput = ""; pcinput.Trim(); // removes compiler Warning
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
            int num =2;

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
