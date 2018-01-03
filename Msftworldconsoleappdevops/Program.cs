using System;



namespace Msftworldconsoleappdevops
{
    class Program
    {
     

        static void Main(string[] args)
        {
            string appNName = "Numbergusser";
            string appversion = "1.0.0";
            string author = "Revi Bennett";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine ("{0}: Version {1} by {2 }.", appNName, appversion, author);
           

            Console.ResetColor();


            Console.WriteLine("What is Your Name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);

            int correctNumber = 7;

            int guess = 0;

          

            Console.WriteLine("Guess A Number Between 1 and 10");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);

                if(!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Input A Number");


                    Console.ResetColor();
                    continue;
                }

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Answer. Guess Again" );


                    Console.ResetColor();
                }
                
            }    Console.ForegroundColor = ConsoleColor.Yellow;

                 Console.WriteLine("Good Job, You have Guessed The Correct Number");
                 Console.ResetColor();

        } 

    }
}       
