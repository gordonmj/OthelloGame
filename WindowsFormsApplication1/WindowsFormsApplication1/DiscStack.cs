using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class DiscStack
    {
        private System.Drawing.Graphics pG;
        private Panel p;
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private SolidBrush whiteBrush = new SolidBrush(Color.White);

        public DiscStack()
        {

        }

        public void setUpStack(System.Drawing.Graphics panelGraphics, Panel panel)
        {
            pG = panelGraphics;
            p = panel;
        }

        public void drawStack(int discsLeft)
        {
            int stackWidth = (p.Width - 10);
            int stackHeight = (p.Height - 5) / 64;
            for (int i = 0; i < discsLeft * 2; i++)
            {
                if (i % 2 == 0)
                {
                    pG.FillRectangle(blackBrush, 5, i * stackHeight, stackWidth, stackHeight);
                }
                else
                {
                    pG.FillRectangle(new SolidBrush(Color.White), 5, i * stackHeight, stackWidth, stackHeight);
                }
            }
        }
    }
}
