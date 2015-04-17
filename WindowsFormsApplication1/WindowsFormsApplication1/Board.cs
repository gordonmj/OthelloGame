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

        public void layoutBoard(Panel p){
                        //print squares
            System.Drawing.Graphics pG = p.CreateGraphics();
            int width = p.Width;
            int height = p.Height;

            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    pG.FillRectangle(new SolidBrush(Color.Green), width * c, height * r, width, height);
                    pG.DrawRectangle(new Pen(new SolidBrush(Color.Black)), width * c, height * r, width, height);
                }
            }
        }
    }
}
