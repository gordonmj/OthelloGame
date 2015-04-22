using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Player
    {

        private Color color;
        public int score = 2;
        public int discsLeft = 32;
        public int gamesWon = 0;

        public Player()
        {

        }

        public void setColor(Color c)
        {
            color = c;
        }

        public Color getColor()
        {
            return color;
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int s)
        {
            score = s;
        }

        public void raiseScore(int amt)
        {
            score += amt;
        }

        public void lowerScore(int amt)
        {
            score -= amt;
        }

        public void decCount()
        {
            discsLeft--;
        }

        public void resetCount()
        {
            discsLeft = 32;
        }


    }
}
