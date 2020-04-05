// Rose Keenan
// Maryam Salawu
// CIS 3309 Section 01
// Matching Game
// Board Class
// Due: 04.05.2020
// Holds the number of pairs
// Initially had the createboard method but was moved to the form load


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame.Forms;
using MatchingGame.Properties;

namespace MatchingGame.Classes
{
   public class BoardClass
    {

        private const int NUMBER_OF_PAIRS = 8;

        public BoardClass()
        {
            //empty constructor
        }

        // getter method to get the constant integer of number of pairs for the board
        public  static int getNumberOfPairs {
            get
            {
                return NUMBER_OF_PAIRS;
            }
        }

    }

}
