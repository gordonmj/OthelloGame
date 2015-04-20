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
        DiscStack leftStack;
        DiscStack rightStack;
        Player leftPlayer;
        Player rightPlayer;
        Player blackPlayer;
        Player whitePlayer;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            game = new Game();
            board = game.getBoard();
            leftStack = game.getStack();
            rightStack = game.getStack();
            leftPlayer = game.getPlayer();
            rightPlayer = game.getPlayer();

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

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            pG2 = panel2.CreateGraphics();
            leftStack.setUpStack(pG2, panel2);
            leftStack.drawStack(32);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            pG3 = panel3.CreateGraphics();
            rightStack.setUpStack(pG3, panel3);
            rightStack.drawStack(32);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeInitialConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.board.initConfig();
        }

        private void leftPlayerInfo_Click(object sender, EventArgs e)
        {
        }

        private void rightPlayerInfo_Click(object sender, EventArgs e)
        {

        }

        private void chooseColors()
        {
                        MessageBox.Show("Choosing colors");
            blackPlayer = game.assignColor(leftPlayer, rightPlayer);
            if (ReferenceEquals(blackPlayer, leftPlayer))
            {
                whitePlayer = rightPlayer;
                leftPlayerInfo.ForeColor = Color.Black;
                rightPlayerInfo.ForeColor = Color.White;
                MessageBox.Show("Left is black and right is white.");
            }
            else
            {
                leftPlayerInfo.ForeColor = Color.White;
                rightPlayerInfo.ForeColor = Color.Black;
                whitePlayer = leftPlayer;
                MessageBox.Show("Right is black and left is white.");
            }

        }
        private void chooseColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chooseColors();
        }
    }
}
