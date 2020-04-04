using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingGame.Classes
{
    public static class PlayerClass
    {
        private static int playerScore;
        private static string playerName;


        public static void setName(string name)
        {
            playerName = name;
        }

        public static string getName()
        {
            return playerName;
        }

        public static int getScore()
        {
            return playerScore;
        }

        public static void increaseScore()
        {
            playerScore = playerScore + 10;
        }

    }


}
