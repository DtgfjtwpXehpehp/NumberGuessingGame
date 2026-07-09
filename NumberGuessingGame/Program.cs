namespace NumberGuessingGame
{
    internal class Program
    {
        public static void play()
        {
            int maximum = 0;
            Console.WriteLine("What difficulty do you like (E) Easy, (M) Meduim, (H) Hard? ");

            string difficulty = Console.ReadLine().ToUpper();


            //if ((di))
            if (difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M")
            {
                maximum = 50;

            }
            else
            {
                maximum = 1000;
            }




            NumberGuessing numberGuesing = new NumberGuessing(1, maximum);

            bool guessed = false;

            while (!guessed)
            {

                Console.WriteLine("Please enter your guess");

                string guess = Console.ReadLine();

                if (guess == " " || guess == "")
                {
                    Console.WriteLine("Please enter a correct guess");

                    guess = Console.ReadLine();
                    GuessResult result = numberGuesing.makeGuess(Convert.ToInt32(guess));
                    if (result == GuessResult.tooLow)
                    {
                        Console.WriteLine("Your guess is too low please try again");
                    }
                    else if (result == GuessResult.tooHigh)
                    {
                        Console.WriteLine("Your guess is too high please try again");

                    }
                    else if (result == GuessResult.correct)
                    {
                        Console.WriteLine("Welldone your guess is correct.");

                        guessed = true;

                    }


                }
                else
                {

                    GuessResult result = numberGuesing.makeGuess(Convert.ToInt32(guess));

                    if (result == GuessResult.tooLow)
                    {
                        Console.WriteLine("Your guess is too low please try again");
                    }
                    else if (result == GuessResult.tooHigh)
                    {
                        Console.WriteLine("Your guess is too high please try again");

                    }
                    else if (result == GuessResult.correct)
                    {
                        Console.WriteLine("Welldone your guess is correct.");

                        guessed = true;

                    }
                    else
                    {
                        Console.WriteLine("Your guess is out of bounds please try again.");

                    }




                }
            }


            Console.WriteLine("Do you want to play again? press (Y) for yes or press (N) for no");

            string response = Console.ReadLine().ToUpper();

            bool responseCorrect = false;


            if ((response == "Y" )|| (response == "N"))
            {
                responseCorrect = true;
            }
            else
            {
                responseCorrect = false;
            }


            if (responseCorrect == true)
            {




                if (response == "Y")
                {

                    guessed = false;
                    play();
                }
                else if (response == "N")
                {
                    guessed = true;

                    Console.WriteLine("Game Over!!!");

                }
            }
            else
            {
                Console.WriteLine("Please respond only with (Y) or (N) for no!");

            }

            }
        
        static void Main(string[] args)
        {

            play();


        }
    }
}
