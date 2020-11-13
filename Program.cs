using System;
using System.Collections.Generic;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            //enthusiastic magic 8 ball
            MagicMoose();
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //prompts for a question and responds with a random answer
        static void MagicMoose()
        {
            Console.Write("Ask a question: ");
            string question = Console.ReadLine();
            
            //if the user just hits enter, stop looping
            while(!(String.IsNullOrEmpty(question)))
            {
                RandomResponse();
                Console.Write("Ask a question: ");
                question = Console.ReadLine();
            }
        }

        //prints a random string
        static void RandomResponse()
        {
            //list of responses
            List<string> responses = new List<string>()
            {
                "As I see it, yes.",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again.",
                "Don't count on it",
                "It is certain",
                "It is decidedly so",
                "Most likely",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good",
                "Outlook good",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very duobtful.",
                "Without a doubt",
                "Yes",
                "Yes - definitely",
                "You may rely on it."
            };

            //get a random response
            Random r = new Random();
            int randomNumber = r.Next(0,20);
            String randomResponse = responses[randomNumber];

            //have the moose say the random response
            MooseSays(randomResponse);
        }

        //invokes all of the question methods 
        static void MooseResponse(string question, string trueResponse, string falseResponse)
        {
            bool isTrue = MooseAsks(question);
            if(isTrue)
            {
                MooseSays(trueResponse);
            }
            else{
                MooseSays(falseResponse);
            }
        }

        //Respond to all the appropriate questions
        static void Questions()
        {
            MooseResponse("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            MooseResponse("Are you enthusiastic?", "Yay!", "You should try it!");
            MooseResponse("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            MooseResponse("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        }
    }
}
