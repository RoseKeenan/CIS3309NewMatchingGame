/* Rose Marie Keenan
 * Maryam Salawu
 * CIS 3309 Section 01
 * Matching Game
 * Player Class
 * Due: 04.05.2020
 * This is a static class - no initialization necessary
 * Includes information of the player such as the score and the name
 * Includes getter and setter methods
 * Includes increase score method that increases the score for every correct match
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingGame.Classes
{
    // no constructor in static class
    public static class PlayerClass
    {
        private static int playerScore;
        private static string playerName;

        // Setter method for the name attribute
        public static void setName(string name)
        {
            playerName = name;
        }

        // getter method for the name attribute
        public static string getName()
        {
            return playerName;
        }

        // getter method for the score attribute
        public static int getScore()
        {
            return playerScore;
        }

        // increases the player score by 10 every time it is called - this happens when the player finds a match
        public static void increaseScore()
        {
            playerScore = playerScore + 10;
        }

    }


}
