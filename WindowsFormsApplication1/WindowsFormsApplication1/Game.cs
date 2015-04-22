using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Game
    {
        public Board board;
        public Player black= new Player();
        public Player white = new Player();
        public DiscStack whiteStack = new DiscStack();
        public DiscStack blackStack = new DiscStack();


        public Game()
        {

        }


        public Board getBoard()
        {
            board = new Board();
            return board;
        }

        public DiscStack getStack()
        {
            return new DiscStack();
        }

        public Player getPlayer()
        {
            return new Player();
        }

        public void setPlayer(Player blackPlayer, Player whitePlayer)
        {
            black = blackPlayer;
            white = whitePlayer;
        }

        public Player assignColor(Player p1, Player p2)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 2);
            if (n == 0)
            {
                p1.setColor(Color.Black);
                p2.setColor(Color.White);
                return p1;
            }
            else
            {
                p1.setColor(Color.White);
                p2.setColor(Color.Black);
                return p2;
            }
        }//method

        public bool takeTurn(bool blackTurn)
        {

            return !blackTurn;
        }

        public void tryToPlace(Point pt, bool isBlack)
        {
            board.tryToPlace(pt, isBlack);
            if (isBlack)
            {
                black.decCount();
                blackStack.drawStack(black.discsLeft);

            }
            else
            {
                white.decCount();
                whiteStack.drawStack(white.discsLeft);
            }
        }

         
    }
}
