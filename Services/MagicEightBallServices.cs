using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen_Endpoints.Services
{
    public class MagicEightBallServices
    {
        public List<string> answerList = new ();

        public MagicEightBallServices(){
        answerList.Add("It is certain");
        answerList.Add("It is decidedly so");
        answerList.Add("Without a doubt");
        answerList.Add("Yes definitely");
        answerList.Add("You may rely on it");
        answerList.Add("As I see it, yes");
        answerList.Add("Most likely");
        answerList.Add("Outlook good");
        answerList.Add("Yes");
        answerList.Add("Signs point to yes");
        answerList.Add("Reply hazy, try again");
        answerList.Add("Ask again later");
        answerList.Add("Better not tell you now");
        answerList.Add("Cannot predict now");
        answerList.Add("Concentrate and ask again");
        answerList.Add("Don’t count on it");
        answerList.Add("My reply is no");
        answerList.Add("My sources say no");
        answerList.Add("Outlook not so good");
        answerList.Add("Very doubtful");
        }

        public string GetAnswer(string question){
            Random rng = new Random();
            int randomNum = rng.Next(answerList.Count);

            return "Your Question: " +question+ ". 8 ball answer is: " + answerList[randomNum]; 
        }
        }
}
