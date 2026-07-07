using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        private int randomNumber = 0;
        private int maximum = 0;
        private int minimum = 0;

        public void generateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();

            randomNumber = rand.Next( minimum, maximum);

            this.minimum = minimum;
            this.maximum = maximum;

            //return randomNumber;

        }

        public NumberGuessing(int minimum, int maximum)
        {
            generateRandomNumber(minimum, maximum);
        }
         

        public GuessResult makeGuess(int guess)
        {
            if( guess > maximum)
            {
                return GuessResult.outOfLimits;
            }else if (guess < minimum)
            {
                return GuessResult.outOfLimits;

            }
            else
            {
                if (guess == randomNumber)
                {


                    return GuessResult.correct;

                }
                else if (guess > randomNumber)
                {
                    return GuessResult.tooHigh;
                }
                else
                {
                    return GuessResult.tooLow;
                }
            }

            
        }
    }
}
