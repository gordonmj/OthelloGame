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
        public int[,] directions = {{-1,-1},{-1,0},{-1,1},{0,1},{1,1},{1,0},{1,-1},{0,-1}};
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

        public int tryToPlace(Point pt, bool isBlack)
        {
            Space toPlace = board.tryToPlace(pt, isBlack);
            if (toPlace == null)
            {
                return -1;
            }
            int score = findFlips(toPlace);
            if (score == -1)
            {
                return -1;
            }
            if (isBlack)
            {
                black.decCount();
                blackStack.drawStack(black.discsLeft);
                black.raiseScore(score+1);
                white.lowerScore(score);

            }
            else
            {
                white.decCount();
                whiteStack.drawStack(white.discsLeft);
                white.raiseScore(score+1);
                black.lowerScore(score);
            }
            return score;
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

        public int findFlips(Space sp)
        {
            for (int d = 0; d < 8; d++)
            {
                List<Space> tentative = new List<Space>();
                Space m = next(sp, d);
                while (m != null && m.status != 0 && m.status != sp.status)
                {
                    tentative.Add(m);
                    m = next(m, d);
                }
                if (m==null || m.status == 0){
                    tentative.Clear();
                }
                else if (m.status != sp.status)
                {
                    tentative.Clear();
                }
                else if (m.status == sp.status)
                {
                    tentative.Remove(m);
                    toFlip.AddRange(tentative);
                }
                else
                {
                    MessageBox.Show("last space is: " + m.status);
                }
            }//for each direction
            if (toFlip.Count() <= 0)
            {
                MessageBox.Show("Illegal move! Try again!");
                sp.eraseDisc();
                return -1;
                //bad move!
            }
            else
            {
                //MessageBox.Show("Number to flip: " + toFlip.Count());
                toFlip.ForEach(highlight);
                DialogResult answer = MessageBox.Show("Confirm that move?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    toFlip.ForEach(confirm);
                    //return score
                    int score = toFlip.Count();
                    toFlip.Clear();
                    return score;
                }

                else if (answer == DialogResult.No)
                {
                    toFlip.ForEach(unhighlight);
                    //return score
                    sp.eraseDisc();
                    toFlip.Clear();
                    return -1;
                }
                return 0;
            }
            //reset List, highlight etc.

        }

        public static void highlight(Space s)
        {
            s.highLight();
        }

        public static void confirm(Space s)
        {
            s.confirm();
        }

        public static void unhighlight(Space s)
        {
            s.unhighLight();
        }
    }
}