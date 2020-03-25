using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingGame
{
    class PlayerClass
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
