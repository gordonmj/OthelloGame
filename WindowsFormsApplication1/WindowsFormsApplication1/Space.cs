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
        private int row;
        private int col;
        private int width;
        private int height;
        private int x;
        private int y;
        private int status = 0;
        private int[] stati = {-2,-1,0,1,2}; //0=empty, 1=black placed, -1=white placed, 2=black tentative, -2=white tentative
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private SolidBrush whiteBrush = new SolidBrush(Color.White);

        public Space(int r, int c, int w, int h)
        {
            row = r;
            col = c;
            width = w;
            height = h;
            x = width * c;
            y = height * r;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

        public void placeDisc(System.Drawing.Graphics pG, bool black)
        {
            if (status != 0)
            {
                MessageBox.Show("That spot is taken!");
                return;
            }
            drawDisc(pG, black);
        }

        public void flipDisc(System.Drawing.Graphics pG, bool black)
        {
            if (!(black && status==-1) || !(!black && status ==1))
            {
                MessageBox.Show("Can only flip opposite color!");
                return;
            }
            drawDisc(pG, black);
        }

        public void drawDisc(System.Drawing.Graphics pG, bool black){
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
    }
}
