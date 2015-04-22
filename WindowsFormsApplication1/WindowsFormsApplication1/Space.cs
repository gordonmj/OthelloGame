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

        public void placeDisc(bool black)
        {
            if (status != 0)
            {
                MessageBox.Show("That spot is taken!");
                return;
            }
            drawDisc(black);
        }

        public void flipDisc(bool black)
        {
            if (!(black && status == -1) || !(!black && status == 1))
            {
                MessageBox.Show("Can only flip opposite color!");
                return;
            }
            drawDisc(black);
        }

        public void drawDisc(bool black)
        {
            if (black)
            {
                status = 1;
                pG.FillEllipse(blackBrush, x, y, width, height);
            }
            else
            {
                status = -1;
                pG.FillEllipse(whiteBrush, x, y, width, height);
            }
        }

        public void highLight()
        {
            if (status==-1)
            {
                status = 2;
                pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                drawDisc(true);
            }
            else if (status == 1)
            {
                status = -2;
                pG.FillRectangle(new SolidBrush(Color.YellowGreen), x, y, width, height);
                drawDisc(false);
            }
        }

        public void eraseDisc(System.Drawing.Graphics pG)
        {
            pG.FillEllipse(new SolidBrush(Color.Green), x, y, width, height);
            status = 0;
        }
    }
}