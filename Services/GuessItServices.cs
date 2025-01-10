using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen_Endpoints.Services
{
    public class GuessItServices
    {
        public string feedback = "";

        public string GuessIt(string guess, int mode)
        {

            int endRange =0;
             int randomNum=0;
            int guessedNum = 0;
            string returnedMsg = "";
            Random rng = new Random();
            switch (mode)
            {

                case 1:

                    endRange = 10;
                    break;

                case 2:

                    endRange = 50;
                    break;

                case 3:
                    endRange = 100;
                    break;

             

                default:
                    return "Invalid Mode selected";
                    
            }
           
            randomNum = rng.Next(1,endRange+1); //generate the random number
            
            bool isGuessNumValid = int.TryParse(guess, out guessedNum);

            if (isGuessNumValid)
            {

                if (guessedNum == randomNum)
                {
                    returnedMsg = $"Congratulations, you guessed the right number! The random number is {randomNum}";
                }
                else if (guessedNum > randomNum)
                {
                    returnedMsg = $"Your guess is greater than the random number.The random number is {randomNum}";
                }
                else
                {
                    returnedMsg = $"Your guess is less than the random number.The random number is {randomNum}";
                }

            }
            else
            {
                returnedMsg = "Entered value is not an integer.Please enter a number";
            }

            return returnedMsg;

        }

    }
}
