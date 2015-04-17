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
        public Board board;

        public Game()
        {

        }

        public Game(Form1 f, ref Panel bp, ref Panel lbp, ref Panel rbp, ref Panel sbp)
        {
            form = f;
            boardPanel = bp;
            leftBarPanel = lbp;
            rightBarPanel = rbp;
            scoreBoardPanel = sbp;
        }

        public void Start()
        {
            board = new Board();
            board.layoutBoard(ref boardPanel);
        }
    }
}
