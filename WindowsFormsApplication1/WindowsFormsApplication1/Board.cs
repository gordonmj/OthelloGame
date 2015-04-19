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
        public SolidBrush blackBrush = new SolidBrush(Color.Black);

        Space[,] board = new Space[8, 8];
        
        public Board()
        {
            //make squares
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    board[r, c] = new Space();
                }
            }
        }

        public void layoutBoard(ref Panel p){
                        //print squares
            System.Drawing.Graphics pG = p.CreateGraphics();
            int width = (p.Width-1)/8;
            int height = (p.Height-1)/8;
            Pen border = new Pen(blackBrush, 10);
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    //dots go at 2,2 6,2 2,6 6,6
                    pG.DrawRectangle(new Pen(blackBrush), width * c, height * r, width, height);
                    if ((r==2 || r==6) && (c==2 || c==6))
                    {
                        pG.FillEllipse(blackBrush, (width * c) - 4, (height * r) - 4, 10, 10);
                    }//if
                }//for
            }//for
        }//method

        public void drawStack(Panel p, int discsLeft)
        {
            System.Drawing.Graphics pG = p.CreateGraphics();
            int width = (p.Width - 10);
            int height = (p.Height - 5) / 64;
            for (int i = 0; i < discsLeft*2; i++)
            {
                if (i % 2 == 0)
                {
                    pG.FillRectangle(blackBrush, 5, i * height, width, height);
                }
                else
                {
                    pG.FillRectangle(new SolidBrush(Color.White), 5, i * height, width, height);
                }
            }
        }
    }//class
}//namespace
