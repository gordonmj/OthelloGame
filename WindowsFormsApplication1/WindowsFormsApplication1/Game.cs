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
        private Form1 form;
        private Panel boardPanel, leftBarPanel, rightBarPanel, scoreBoardPanel;

        public Game()
        {

        }

        public Game(Form1 f, Panel bp, Panel lbp, Panel rbp, Panel sbp)
        {
            form = f;
            boardPanel = bp;
            leftBarPanel = lbp;
            rightBarPanel = rbp;
            scoreBoardPanel = sbp;
        }

        public void Start()
        {
            Board board = new Board();
            board.layoutBoard(boardPanel);
        }
    }
}
