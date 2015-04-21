using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Game game;
        private System.Drawing.Graphics pG1;
        private System.Drawing.Graphics pG2;
        private System.Drawing.Graphics pG3;
        //private System.Drawing.Graphics pG4;
        //private System.Drawing.Graphics pG5;
        private System.Drawing.Graphics pG6;
        //private System.Drawing.Graphics pG7;
        Board board;
        DiscStack left;
        DiscStack right;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            game = new Game();
            board = game.getBoard();
            left = game.getStack();
            right = game.getStack();
        }

        //private void panel5_Paint(object sender, PaintEventArgs e)
        //{
        //    pG5 = panel5.CreateGraphics();
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pG1 = panel1.CreateGraphics();
            game.board.setUpBoard(panel1,pG1);
            game.board.layoutBoard();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            pG6 = panel6.CreateGraphics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            pG2 = panel2.CreateGraphics();
            left.setUpStack(pG2, panel2);
            left.drawStack(32);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            pG3 = panel3.CreateGraphics();
            right.setUpStack(pG3, panel3);
            right.drawStack(32);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeInitialConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
