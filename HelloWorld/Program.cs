using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace IfStatmentsChalange
{
    class Program {

        static int highScore = 300;
        static string highScorePlayer = "Denis";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michel");
            CheckHighScore(350, "Denis");
            CheckHighScore(270, "Alex");

        }

        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highScore )
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine("New higscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore culd not be broke. it is still " + highScore + " and heald by " + highScorePlayer);
            }
        }


    }
}