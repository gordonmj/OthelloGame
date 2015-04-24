using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Space
    {
        public int row;
        public int col;
        public int width;
        public int height;
        public int x;
        public int y;
        public int status = 0;
        public int[] stati = { -2, -1, 0, 1, 2 }; //0=empty, 1=black placed, -1=white placed, 2=black tentative, -2=white tentative
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private SolidBrush whiteBrush = new SolidBrush(Color.White);
        public System.Drawing.Graphics pG;

        public Space(int r, int c, int w, int h, System.Drawing.Graphics panelG)
        {
            row = r;
            col = c;
            width = w;
            height = h;
            x = width * c;
            y = height * r;
            pG = panelG;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

        public int placeDisc(bool black)
        {
            if (status != 0)
            {
                MessageBox.Show("That spot is taken!");
                return 0;
            }
            drawDisc(black);
            if (black)
            {
                status = 1;
                return 1;
            }
            else
            {
                status = -1;
                return -1;
            }
        }

        public void flipDisc(bool black)
        {
            if (!(black && status == -1) || !(!black && status == 1))
            {
                MessageBox.Show("Can only flip opposite color!");
                return;
            }
            drawDisc(black);
            //set status?
        }

        public void flipDiscMan(bool black)
        {
            drawDisc(black);
            if (black)
            {
                status = 1;
            }
            else
            {
                status = -1;
            }
        }

        public void drawDisc(bool black)
        {
            if (black)
            {
                pG.FillEllipse(blackBrush, x, y, width, height);
            }
            else
            {
                pG.FillEllipse(whiteBrush, x, y, width, height);
            }
        }

        public void highLight()
        {
            if (status==-1)
            {
                status = 2;
                pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(true);
            }
            else if (status == 1)
            {
                status = -2;
                pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(false);
            }
            else if (status == 0)
            {
                //pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                //pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
        }

        public void unhighLight()
        {
            if (status == -2)
            {
                status = 1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(true);
            }
            else if (status == 2)
            {
                status = -1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(false);
            }
            else
            {
                status = 0;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
        }

        public void confirm()
        {
            if (status == -2)
            {
                status = -1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(false);
            }
            else if (status == 2)
            {
                status = 1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(true);
            }
            else if (status == 1)
            {
                status = 1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(true);
            }
            else if (status == -1)
            {
                status = 1;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                drawDisc(false);
            }
        }

        public void hint(bool black)
        {
            if (status == 0)
            {
                if (black)
                {
                    status = 1;
                    pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                    pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                    drawDisc(true);
                }
                else
                {
                    status = -1;
                    pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                    pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
                    drawDisc(false);
                }
            }
        }

        public void unhint(bool black)
        {
            if (status == 0)
            {
                status = 0;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
            else if (status == 1)
            {
                status = 0;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
            else if (status == -1)
            {
                status = 0;
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
            else
            {
                MessageBox.Show("status is " + status);
                pG.FillRectangle(new SolidBrush(Color.Green), x, y, width, height);
                pG.DrawRectangle(new Pen(blackBrush), x, y, width, height);
            }
        }

        public void eraseDisc()
        {
            pG.FillEllipse(new SolidBrush(Color.Green), x, y, width, height);
            status = 0;
        }
    }
}