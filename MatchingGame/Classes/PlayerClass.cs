using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame.Properties;
using MatchingGame_Project_III_.Classes;

namespace MatchingGame
{
    class PlayerClass:Form
    {
        private String playerName;
        private int playerScore;
        private int counter;

        public PlayerClass(String userName)
        {
            this.playerName = userName;
            this.playerScore = 0;
            this.counter = 0;
        }

        
    }
}
