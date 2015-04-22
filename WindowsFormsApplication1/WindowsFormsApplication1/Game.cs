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
        public Player black = new Player();
        public Player white = new Player();
        public DiscStack whiteStack;
        public DiscStack blackStack;
        public int[,] directions = {{-1,1},{0,1},{1,1},{1,0},{1,-1},{0,-1},{-1,-1},{-1,0}};
        public List<Space> toFlip = new List<Space>();

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
            return whiteStack;
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
            Space toPlace = board.tryToPlace(pt, isBlack);
            findFlips(toPlace);
            if (isBlack)
            {
                black.decCount();
                blackStack.drawStack(black.discsLeft);
                black.raiseScore(1);

            }
            else
            {
                white.decCount();
                whiteStack.drawStack(white.discsLeft);
                white.raiseScore(1);
            }
        }

        public void undo()
        {
            board.undoMove();

        }

        public Space next(Space sp, int d)
        {
            int newC = sp.col + directions[d,1];
            int newR = sp.row + directions[d,0];
            if (newC < 0 || newC > 7 || newR < 0 || newR > 7) return null;
            else return board.board[newR, newC];
        }

        public void findFlips(Space sp)
        {
            for (int d = 0; d < 8; d++)
            {
                Space m = next(sp, d);
                //if (m == null)
                //{
                //    MessageBox.Show("NULL!");
                //    return;
                //}
                MessageBox.Show(m.row+","+m.col+","+m.status);
                while (m != null && m.status != 0 && m.status != sp.status)
                {
                    MessageBox.Show("looking at " + m.getX() + ", " + m.getY());
                    toFlip.Add(m);
                    m = next(m, d);
                }
            }//for each direction
            if (toFlip.Count() <= 0)
            {
                MessageBox.Show("Illegal move! Try again!");
                return;
                //bad move!
            }
            else
            {
                MessageBox.Show("Number to flip: " + toFlip.Count());
                toFlip.ForEach(highlight);
            }
            //reset List, highlight etc.

        }

        public void highlight(Space s)
        {
            s.highLight();
        }
    }
}