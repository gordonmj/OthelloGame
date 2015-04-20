using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public void drawDisc(System.Drawing.Graphics pG, bool black){
            if (black)
            {
                pG.FillEllipse(blackBrush, x, y, width, height);
            }
            else
            {
                pG.FillEllipse(whiteBrush, x, y, width, height);

            }
        }
    }
}
