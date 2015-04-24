using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{

    class Board
    {
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private int width;
        private int height;
        public Space[,] board = new Space[8, 8];
        private System.Drawing.Graphics pG;
        private Panel p;
        private Space lastMove;

        public Board()
        {
            //make squares
        }

        public void setUpBoard(Panel panel, System.Drawing.Graphics PG)
        {
            p = panel;
            pG = PG;
            width = (p.Width - 1) / 8;
            height = (p.Height - 1) / 8;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    board[r, c] = new Space(r, c, width, height,pG);
                }
            }

        }
        public void layoutBoard()
        {
            //print squares
            //System.Drawing.Graphics pG = p.CreateGraphics();
            Pen border = new Pen(blackBrush, 10);
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    //dots go at 2,2 6,2 2,6 6,6
                    pG.DrawRectangle(new Pen(blackBrush), width * c, height * r, width, height);
                    if ((r == 2 || r == 6) && (c == 2 || c == 6))
                    {
                        pG.FillEllipse(blackBrush, (width * c) - 4, (height * r) - 4, 10, 10);
                    }//if
                }//for
            }//for
        }//method

        public void clearBoard()
        {
            board = new Space[8, 8];
        }

        public void initConfig()
        {
            placeBlack(3, 3);
            placeBlack(4, 4);
            placeWhite(3, 4);
            placeWhite(4, 3);
        }

        public void placeBlack(int r, int c)
        {
            board[r, c].placeDisc(true);
        }

        public void placeWhite(int r, int c)
        {
            board[r, c].placeDisc(false);
        }

        public Space whichSpace(Point pt)
        {
            int probR = -1, probC = -1;
            try
            {
                probC = pt.X / width;
                probR = pt.Y / height;
                Space prob = board[probR, probC];
                if (pt.X > prob.getX() && pt.X < prob.getX() + width && pt.Y > prob.getY() && pt.Y < prob.getY() + height)
                {
                    return prob;
                }
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC);
            }
            return null;
        }

        public Space tryToPlace(Point pt, bool isBlack)
        {
            if (whichSpace(pt) != null)
            {
                Space toPlace = whichSpace(pt);
                if (toPlace.placeDisc(isBlack) == 0)
                {
                    return null;
                }
                lastMove = toPlace;
                return toPlace;
            }
            else
            {
                return null;
            }
        }

        public Space flipMan(Point pt)
        {
            if (whichSpace(pt) != null)
            {
                Space toPlace = whichSpace(pt);
                return toPlace;
            }
            else
            {
                return null;
            }
        }

        public void undoMove()
        {
            lastMove.eraseDisc();
        }

        public String boardToString()
        {
            String s = "";
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    s += board[r, c].status + " ";
                }//columns
                s += Environment.NewLine;
            }//rows
            return s;
        }


        public int stringToBoard(String fileName)
        {
            try
            {
                            if (fileName == null)
            {
                MessageBox.Show("You must select an input file first. Use 'Image>Load'");
                return -1;
            }
            string[] lines = System.IO.File.ReadAllLines(@fileName);
            char[] delims = { ' ', '\n' };
            string[] firstLine = lines[0].Split(delims);
            clearBoard();
            for (int r = 0; r < 8; r++)
            {
                string[] nextLine = lines[r].Split(delims);
                for (int c = 0; c < 8; c++)
                {
                    int stat = Convert.ToInt32(nextLine[c]);
                    Space newSpace = new Space(r, c, width, height, pG);
                    board[r, c] = newSpace;
                    if (stat == 1)
                    {
                        newSpace.placeDisc(true);
                    }
                    else if (stat == -1)
                    {
                        newSpace.placeDisc(false);
                    }
                    newSpace.status = stat;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failure. Please try again with a valid text file.");
            }
            return 0;
        }
    }//class
}//namespace