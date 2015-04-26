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
        public Player blackPlayer = new Player();
        public Player whitePlayer = new Player();
        public DiscStack whiteStack;
        public DiscStack blackStack;
        public int[,] directions = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };
        public List<Space> toFlip = new List<Space>();
        public static bool isBlack;

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

        public void setPlayer(Player bP, Player wP)
        {
            blackPlayer = bP;
            whitePlayer = wP;
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
            int score = findFlips(toPlace, false);
            if (score == -1)
            {
                return -1;
            }
            if (isBlack)
            {
                blackPlayer.decCount();
                blackStack.drawStack(blackPlayer.discsLeft);
                blackPlayer.raiseScore(score + 1);
                whitePlayer.lowerScore(score);
            }
            else
            {
                whitePlayer.decCount();
                whiteStack.drawStack(whitePlayer.discsLeft);
                whitePlayer.raiseScore(score + 1);
                blackPlayer.lowerScore(score);
            }
            return score;
        }

        public void undo()
        {
            board.undoMove();

        }

        public Space next(Space sp, int d)
        {
            int newC = sp.col + directions[d, 1];
            int newR = sp.row + directions[d, 0];
            if (newC < 0 || newC > 7 || newR < 0 || newR > 7) return null;
            else return board.board[newR, newC];
        }

        public int findFlips(Space sp, bool isHintSearch)
        {
            int score = -1;
            for (int d = 0; d < 8; d++)
            {
                List<Space> tentative = new List<Space>();
                Space m = next(sp, d);
                while (m != null && m.status != 0 && m.status != sp.status)
                {
                    tentative.Add(m);
                    m = next(m, d);
                }
                if (m == null || m.status == 0)
                {
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
            //MessageBox.Show("Number to flip: " + toFlip.Count());
            if (!isHintSearch)
            {
                if (toFlip.Count() <= 0)
                {
                    MessageBox.Show("Illegal move! Try again!");
                    sp.eraseDisc();
                    return -1;
                    //bad move!
                }
                else
                {
                    toFlip.ForEach(highlight);
                    DialogResult answer = MessageBox.Show("Confirm that move?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        toFlip.ForEach(confirm);
                        //return score
                        score = toFlip.Count();
                        toFlip.Clear();
                        return score;
                    }

                    else if (answer == DialogResult.No)
                    {
                        toFlip.ForEach(unhighlight);
                        //return score
                        sp.eraseDisc();
                        sp.unhighLight();
                        toFlip.Clear();
                        return -1;
                    }
                    return score;
                }//flips pos
            }//is hint search
            return toFlip.Count();
        }//method

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

        public static void hint(Space s)
        {
            s.hint(isBlack);
        }

        public static void unhint(Space s)
        {
            s.unhint(isBlack);
        }

        public int hint(bool black)
        {
            int score = -1;
            isBlack = black;
            int[,] scores = new int[8, 8];
            int maxR = 0;
            int maxC = 0;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Space here = board.board[r, c];
                    if (here.status != 0)
                    {
                        continue;
                    }
                    here.placeDisc(black);
                    int flips = findFlips(here, true);
                    toFlip.Clear();
                    here.eraseDisc();
                    if (flips > 0)
                    {
                        //MessageBox.Show(r+","+c+" has "+flips);
                        scores[r, c] = flips;
                        if (flips > scores[maxR, maxC])
                        {
                            maxR = r;
                            maxC = c;
                        }//if max
                    }// if positive (unnec?)
                }//for c
            }//for r
            //MessageBox.Show("max is " + scores[maxR, maxC] + " at " + maxR + ", " + maxC);
            if (scores[maxR, maxC] == 0)
            {
                return 0;
            }
            Space max = board.board[maxR, maxC];
            //MessageBox.Show("Max is at " + maxR + "," + maxC + " with flips: "+scores[maxR,maxC]);
            max.placeDisc(!isBlack);
            findFlips(max, true);
            toFlip.ForEach(highlight);
            max.highLight();
            max.status = 0;
            MessageBox.Show("Here's your hint");
                toFlip.ForEach(unhighlight);
                //return score
                max.unhighLight();
                max.eraseDisc();
                toFlip.Clear();
            //if (score == -1)
            //{
            //    return -1;
            //}
            //if (black)
            //{
            //    blackPlayer.decCount();
            //    blackStack.drawStack(blackPlayer.discsLeft);
            //    blackPlayer.raiseScore(score + 1);
            //    whitePlayer.lowerScore(score);
            //}
            //else
            //{
            //    whitePlayer.decCount();
            //    whiteStack.drawStack(whitePlayer.discsLeft);
            //    whitePlayer.raiseScore(score + 1);
            //    blackPlayer.lowerScore(score);
            //}
            return score;
        }//method

        public int flipManual(Point pt)
        {
            Space toPlace = board.flipMan(pt);
            if (toPlace.status == 0)
            {
                MessageBox.Show("Please click a white or black piece.");
                return 0;
            }
            else if (toPlace.status == 1)
            {
                toPlace.flipDiscMan(false);
                whitePlayer.raiseScore(1);
                blackPlayer.lowerScore(1);
                return 0;
            }
            else if (toPlace.status == -1)
            {
                toPlace.flipDiscMan(true);
                blackPlayer.raiseScore(1);
                whitePlayer.lowerScore(1);
                return 0;
            }
            else
            {
                MessageBox.Show("Please click a white or black piece.");
                return -1;
            }
        }
    }
}