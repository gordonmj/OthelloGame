﻿using System;
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
        private Space[,] board = new Space[8, 8];
        private System.Drawing.Graphics pG;
        private Panel p;
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
                    board[r, c] = new Space(r, c, width, height);
                }
            }
 
        }
        public void layoutBoard(){
                        //print squares
            //System.Drawing.Graphics pG = p.CreateGraphics();
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

        public void initConfig()
        {
            placeBlack(3, 3);
            placeBlack(4, 4);
            placeWhite(3, 4);
            placeWhite(4, 3);
        }

        public void placeBlack(int r, int c)
        {
            board[r, c].drawDisc(pG, true);
        }

        public void placeWhite(int r, int c)
        {
            board[r, c].drawDisc(pG, false);
        }
    }//class
}//namespace