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
using MatchingGame_Project_III_.Classes;

namespace MatchingGame.Classes
{
   public class BoardClass
    {

        private const int NUMBER_OF_PAIRS = 8;

        public BoardClass()
        {
            //empty constructor
        }
        public  static int getNumberOfPairs {
            get
            {
                return NUMBER_OF_PAIRS;
            }
        }

    }

}
